using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JeuDeLaVieConsole
{
    internal class Control
    {
        
        public static int[,] CreerGrille()
        {
            int[,] grille = new int [Console.WindowHeight-1, Console.WindowWidth-1];
                for (int i = 0; i < Console.WindowHeight - 1; i++)
                {
                    for (int j = 0; j < Console.WindowWidth - 1; j++)
                    {
                        grille[i, j] = 0;
                    }
                }
                return grille;
        }
        public static int AfficherMenu()
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1. ship");
            Console.WriteLine("2. tris");

            int forme =Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return forme;
        }
        public static int[,] FaireShip(int forme, int[,] grille)
        {
            switch(forme)
            {
                case 1:
                    grille[1,3] = 1;
                    grille[2,1] = 1;
                    grille[2,3] = 1;
                    grille[3,2] = 1;
                    grille[3,3] = 1;
                    break;
                case 2:
                    grille[1, 1] = 1;
                    grille[2, 1] = 1;
                    grille[2, 1] = 1;
                    break;

            }
            return grille;        
        }
        public static void AfficherGrille(int[,] grille)
        {
            
            for (int i = 0; i < Console.WindowHeight-1; i++)
            {
                for (int j = 0; j < Console.WindowWidth-1; j++)
                {
                    if (grille[i, j] == 1)
                    {
                        Console.Write("█");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                    
                }
                Console.WriteLine("");
            }
            
        }
            public static bool VerifierLongueur(int[,] grille, int j,int i)
            {
                if (i <1 || j<1 || i>Console.WindowHeight-1 || j>Console.WindowWidth-1)
                {
                    return false;
                }
                return true;
            }
    }
}
