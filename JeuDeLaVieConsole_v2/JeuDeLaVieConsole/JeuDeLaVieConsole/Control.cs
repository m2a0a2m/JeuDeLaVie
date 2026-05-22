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
            Console.WriteLine("3. pulsar");
            Console.WriteLine("4. Canon à planeurs de Gosper");

            int forme =Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            return forme;
        }
        public static int[,] FaireShip(int forme, int[,] grille)
        {
            switch(forme)
            {
                case 1:
                    grille[4,6] = 1;
                    grille[5,4] = 1;
                    grille[5,6] = 1;
                    grille[6,5] = 1;
                    grille[6,6] = 1;
                    break;
                case 2:
                    grille[4, 7] = 1;
                    grille[5, 7] = 1;
                    grille[6, 7] = 1;
                    break;
                case 3:

                    int x = 10;
                    int y = 10;

                    // Haut
                    grille[y, x + 2] = 1;
                    grille[y, x + 3] = 1;
                    grille[y, x + 4] = 1;

                    grille[y, x + 8] = 1;
                    grille[y, x + 9] = 1;
                    grille[y, x + 10] = 1;

                    // Bas
                    grille[y + 12, x + 2] = 1;
                    grille[y + 12, x + 3] = 1;
                    grille[y + 12, x + 4] = 1;

                    grille[y + 12, x + 8] = 1;
                    grille[y + 12, x + 9] = 1;
                    grille[y + 12, x + 10] = 1;

                    // Gauche
                    grille[y + 2, x] = 1;
                    grille[y + 3, x] = 1;
                    grille[y + 4, x] = 1;

                    grille[y + 8, x] = 1;
                    grille[y + 9, x] = 1;
                    grille[y + 10, x] = 1;

                    // Droite
                    grille[y + 2, x + 12] = 1;
                    grille[y + 3, x + 12] = 1;
                    grille[y + 4, x + 12] = 1;

                    grille[y + 8, x + 12] = 1;
                    grille[y + 9, x + 12] = 1;
                    grille[y + 10, x + 12] = 1;

                    // Centre haut gauche
                    grille[y + 2, x + 5] = 1;
                    grille[y + 3, x + 5] = 1;
                    grille[y + 4, x + 5] = 1;

                    // Centre haut droite
                    grille[y + 2, x + 7] = 1;
                    grille[y + 3, x + 7] = 1;
                    grille[y + 4, x + 7] = 1;

                    // Centre bas gauche
                    grille[y + 8, x + 5] = 1;
                    grille[y + 9, x + 5] = 1;
                    grille[y + 10, x + 5] = 1;

                    // Centre bas droite
                    grille[y + 8, x + 7] = 1;
                    grille[y + 9, x + 7] = 1;
                    grille[y + 10, x + 7] = 1;

                    // Centre gauche haut
                    grille[y + 5, x + 2] = 1;
                    grille[y + 5, x + 3] = 1;
                    grille[y + 5, x + 4] = 1;

                    // Centre gauche bas
                    grille[y + 7, x + 2] = 1;
                    grille[y + 7, x + 3] = 1;
                    grille[y + 7, x + 4] = 1;

                    // Centre droite haut
                    grille[y + 5, x + 8] = 1;
                    grille[y + 5, x + 9] = 1;
                    grille[y + 5, x + 10] = 1;

                    // Centre droite bas
                    grille[y + 7, x + 8] = 1;
                    grille[y + 7, x + 9] = 1;
                    grille[y + 7, x + 10] = 1;

                    break;
                case 4:

                    int gx = 5;
                    int gy = 5;

                    // Carré gauche
                    grille[gy + 1, gx + 0] = 1;
                    grille[gy + 1, gx + 1] = 1;
                    grille[gy + 2, gx + 0] = 1;
                    grille[gy + 2, gx + 1] = 1;

                    // Partie gauche
                    grille[gy + 1, gx + 10] = 1;
                    grille[gy + 2, gx + 10] = 1;
                    grille[gy + 3, gx + 10] = 1;

                    grille[gy + 0, gx + 11] = 1;
                    grille[gy + 4, gx + 11] = 1;

                    grille[gy - 1, gx + 12] = 1;
                    grille[gy + 5, gx + 12] = 1;

                    grille[gy - 1, gx + 13] = 1;
                    grille[gy + 5, gx + 13] = 1;

                    grille[gy + 2, gx + 14] = 1;

                    grille[gy + 0, gx + 15] = 1;
                    grille[gy + 4, gx + 15] = 1;

                    grille[gy + 1, gx + 16] = 1;
                    grille[gy + 2, gx + 16] = 1;
                    grille[gy + 3, gx + 16] = 1;

                    grille[gy + 2, gx + 17] = 1;

                    // Partie droite
                    grille[gy - 1, gx + 20] = 1;
                    grille[gy + 0, gx + 20] = 1;
                    grille[gy + 1, gx + 20] = 1;

                    grille[gy - 1, gx + 21] = 1;
                    grille[gy + 0, gx + 21] = 1;
                    grille[gy + 1, gx + 21] = 1;

                    grille[gy - 2, gx + 22] = 1;
                    grille[gy + 2, gx + 22] = 1;

                    grille[gy - 3, gx + 24] = 1;
                    grille[gy - 2, gx + 24] = 1;
                    grille[gy + 2, gx + 24] = 1;
                    grille[gy + 3, gx + 24] = 1;

                    // Carré droite
                    grille[gy - 1, gx + 34] = 1;
                    grille[gy - 1, gx + 35] = 1;
                    grille[gy + 0, gx + 34] = 1;
                    grille[gy + 0, gx + 35] = 1;

                    break;
                default:
                    Console.WriteLine("Choix invalide, aucune forme ne sera placée.");
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
                if (i <1 || j<1 || i>Console.WindowHeight-3 || j>Console.WindowWidth-3)
                {
                    return false;
                }
                return true;
            }
    }
}
