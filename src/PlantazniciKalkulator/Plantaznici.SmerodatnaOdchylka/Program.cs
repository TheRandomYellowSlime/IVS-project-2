/*
 * Projekt: Plantážníci - Kalkulačka
 *
 * Soubor:  Program.cs
 * 
 * Tým:     Plantážníci
 *
 * Autoři:  Marek Kunz (xkunzm02) - vedouci
 *          Jan Křivák (xkriva36)
 *          Marian Pražák (xpraza11)
 *          Kryštof Pleva (xpleva09)
 * 
 * Popis:   Program pro výpočet smerodatné odchylky
 * 
 */
/**
 * @file Program.cs
 * 
 * @brief Program pro výpočet smerodatné odchylky
 * 
 * @author Marek Kunz, Jan Křivák, Marian Pražák, Kryštof Pleva
 *
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using Plantaznici.Kalkulacka.MathLib;

/// <summary>
/// Směrodatná odchylka
/// </summary>
namespace Plantaznici.SmerodatnaOdchylka
{
    /// <summary>
    /// Třída s tělem programu pro výpočet smerodatné odchylky
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tělo programu pro výpočet smerodatné odchylky
        /// </summary>
        /// <exception cref="IOException"> Výjimka pro neexistující soubor </exception>
        /// <exception cref="ArgumentException"> Výjimka pro prázdný soubor </exception>
        /// <param name="args"> Vstupní argumenty </param>    
        static void Main(string[] args)
        {
            MatematickaKnihovna vypocet = new MatematickaKnihovna();    //Pro praci s mat. knihovnou

            string vstupniData = "";                         // proměnná cesta k vstupnímu souboru
            vstupniData = Console.ReadLine();

            if(!File.Exists(vstupniData))   //kontrola existence souboru
            {
                try
                {
                    throw new IOException("Soubor neexistuje");
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    return;
                }
            }

            List<string> radky = new List<string>(File.ReadAllLines(vstupniData));  //nacteni radku ze souboru
            List<string> cislaString = new List<string>();                          //list pro ulozeni vsech cisel jako string

            foreach (string radek in radky)                                         //nacteni radku ze souboru 
            {
                string[] splitString = radek.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                cislaString.AddRange(splitString);
            }
            
            for (int i = 0; i < cislaString.Count; i++)                              //nahrazeni desetinne tecky carkou
            {
                if (cislaString[i].Contains("."))
                {
                    cislaString[i] = cislaString[i].Replace(".", ",");
                }
            }

            List<double> cislaDouble = new List<double>();                           //list pro ulozeni vsech cisel jako double
            foreach (string hodnoty in cislaString)
            {
                double result;
                if(double.TryParse(hodnoty, out result))
                {
                    cislaDouble.Add(result);
                }
            }

            if(cislaDouble.Count == 0)  //kontrola, zda byla nactena alespon jedna hodnota
            {
                try
                {
                    throw new ArgumentException("Soubor neobsahuje zadna cisla");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine(smerodatnaOdchylka(cislaDouble));   //vypis vysledku

            Console.ReadLine(); // čekání na klávesu enter (aby se okno nezavřelo)
        }   // konec těla programu

        /// <summary>
        /// Funkce pro výpočet směrodatné odchylky
        /// </summary>
        /// <param name="cislaDouble"> List všech čísel, se kterými pracujeme </param>
        /// <exception cref="ArgumentException"> Odmocnění záporného čísla </exception>
        /// <returns> Vrací hodnotu směrodatné odchylky </returns>
        private static double smerodatnaOdchylka(List<double> cislaDouble)
        {
            MatematickaKnihovna vypocet = new MatematickaKnihovna();    //Pro praci s mat. knihovnou
            double suma = 0;
            foreach (double cislo in cislaDouble)
            {
                suma = vypocet.Scitani(suma, vypocet.Umocneni(vypocet.Odcitani(cislo, aritmetickyPrumer(cislaDouble)), 2));
            }
            try
            {
                return vypocet.Odmocneni(vypocet.Deleni(suma, vypocet.Odcitani(cislaDouble.Count, 1)), 2);
            }
            catch (Exception)
            {
                return 0;
            }
        }   // konec funkce smerodatnaOdchylka

        /// <summary>
        /// Funkce pro výpočet aritmetického průměru
        /// </summary>
        /// <exception cref="DivideByZeroException"> Výjimka pro dělení nulou </exception>
        /// <param name="cislaDouble"> List všech čísel, se kterými pracujeme </param>
        /// <returns> Vrací hodnotu aritmetického průměru </returns>
        private static double aritmetickyPrumer(List<double> cislaDouble)
        {
            MatematickaKnihovna vypocet = new MatematickaKnihovna();    //Pro praci s mat. knihovnou
            double suma = 0;
            foreach(double cislo in cislaDouble)
            {
                suma = vypocet.Scitani(suma, cislo);
            }
            try
            {
                return vypocet.Deleni(suma, cislaDouble.Count);
            }
            catch (DivideByZeroException)   //kontrola dělení nulou (oštřeno kontrolou prázného souboru)
            {
                return 0;
            }           
        }   // Konec funkce aritmetickyPrumer
    }   // Konec třídy Program
}   // Konec programu pro výpočet směrodatné odchylky
