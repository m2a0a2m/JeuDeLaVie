using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDeLaVieConsole
{
    internal class Control
    {
        public static int[,] CreerGrille()
        {
            int[,] grille = new int [Console.WindowWidth, Console.WindowHeight];
                for (int i = 0; i < Console.WindowWidth; i++)
                {
                    for (int j = 0; j < Console.WindowHeight; j++)
                    {
                        grille[i, j] = 0;
                    }
                }
                return grille;
        }
        public static void AfficherMenu()
        {
            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1. ship");

            string forme = Console.ReadLine();
            Console.Clear();

            return forme;
        }
        public static int[,] FaireShip(string forme, int[,] grille)
        {
            switch(forme)
            {
                case "1":
                    grille[1,3] = 1;
                    grille[2,1] = 1;
                    grille[2,3] = 1;
                    grille[3,2] = 1;
                    grille[3,3] = 1;
                    break;
            }
            return grille;        
        }
        public static void AfficherGrille(int[,] grille)
        {
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                for (int j = 0; j < Console.WindowHeight; j++)
                {
                    if (grille[i, j] == 1)
                    {
                        Console.Write("#");
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
                if (i < 1 || j<1 || i>Console.WindowHeight-1 || j>Console.WindowWidth-1)
                {
                    return true;
                }
                return false;
            }
    }
}
