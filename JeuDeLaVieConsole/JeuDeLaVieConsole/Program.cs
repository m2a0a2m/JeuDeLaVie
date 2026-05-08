using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


using System.Threading;

namespace JeuDeLaVieConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.CursorVisible = false;
            int choixForme = Control.AfficherMenu();
            int[,] grille = Control.CreerGrille();
            grille = Control.FaireShip(choixForme, grille);
            bool fin = false;
            

            while (!fin)
            {
                Thread.Sleep(1000);

                Console.Clear();
                

                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {

                        if (Control.VerifierLongueur(grille, j, i))
                        {
                            int nbAdjacents = 0;
                            
                            
                                if (grille[i - 1, j - 1] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i - 1, j] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i - 1, j + 1] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i, j - 1] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i, j + 1] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i + 1, j - 1] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i + 1, j] == 1)
                                {
                                    nbAdjacents++;
                                }
                                if (grille[i + 1, j + 1] == 1)
                                {
                                    nbAdjacents++;
                                }

                                if (nbAdjacents != 0)
                                {
                                   Thread.Sleep(1000);
                                }
                            

                            if (j != -1 && i != -1)
                            {
                                if (nbAdjacents == 3)
                                {
                                    grille[i, j] = 1;
                                }
                                else if (nbAdjacents < 2 || nbAdjacents > 3)
                                {
                                    grille[i, j] = 0;
                                }
                                else if (nbAdjacents == 2)
                                {
                                    grille[i, j] = grille[i, j];
                                }
                            }
                            

                        }
                        Console.Clear();
                        Control.AfficherGrille(grille);
                        


                    }
                    
                }
                
                

            }
        }
    }
}

