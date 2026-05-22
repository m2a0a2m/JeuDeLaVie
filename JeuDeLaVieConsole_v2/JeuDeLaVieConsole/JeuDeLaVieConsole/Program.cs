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
            //cache le curseur pour éviter les scintillements
            Console.CursorVisible = false;
            //afficher le menu et choisir forme
            int choixForme = Control.AfficherMenu();

            //cree grille
            int[,] grille = Control.CreerGrille();

            //place la forme choisie dans la grille
            grille = Control.FaireShip(choixForme, grille);

            //initialisaton de 2 variables
            int[,] grilleTemp = grille;
            bool fin = false;
            
            //boucle infinie
            while (!fin)
            {
                //affiche la grille
                Console.Clear();
                Control.AfficherGrille(grille);

                //copie la grille dans une grille temporaire 
                grilleTemp = (int[,])grille.Clone();

                //regarde chaque cellule de la grille
                for (int i = 0; i < grille.GetLength(0); i++)
                {
                    
                    for (int j = 0; j < grille.GetLength(1); j++)
                    {
                        
                        //evite les erreur out of range
                        if (Control.VerifierLongueur(grille, j, i) == true)
                        {
                            //compte le nombre de cellules adjacentes vivantes
                            int nbAdjacents = 0;

                                //verifie les 8 cellules adjacentes et ajoute 1 si elle est vivante
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

                            //fais vivre ou mourir la cellule en fonction des adjacents
                            if (j != -1 && i != -1)
                            {
                                if (nbAdjacents == 3)
                                {
                                    grilleTemp[i, j] = 1;
                                }
                                else if (nbAdjacents < 2 || nbAdjacents > 3)
                                {
                                    grilleTemp[i, j] = 0;
                                }
                                else if (nbAdjacents == 2)
                                {
                                    grilleTemp[i, j] = grille[i, j];
                                }
                            }
                        }
                        else
                        {
                            //si la cellule est en bordure, elle meurt
                            grilleTemp[i, j] = 0;
                        }
                    }
                }
                //remplace la grille par la grille temporaire 
                grille = grilleTemp;
            }
        }
    }
}

