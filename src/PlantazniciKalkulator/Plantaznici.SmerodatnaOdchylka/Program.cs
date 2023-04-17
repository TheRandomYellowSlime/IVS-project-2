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

using Plantaznici.Kalkulacka.MathLib;

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
        /// <param name="args"> Vstupní argumenty </param>
        static void Main(string[] args)
        {
            MatematickaKnihovna vypocet = new MatematickaKnihovna(); //Pro praci s mat. knihovnou

            // double vysledek = 0;            //vysledek vypoctu
            string vstupniData = "";        //cesta k vstupnimu souboru
            int N = 0;                      //pocet mereni
            // double suma = 0;                //suma hodnot
            // double aritmetickyPrumer = 0;   //aritmeticky prumer

            console.ReadLine(vstupniData);

            if(!File.Exists(vstupniData))   //kontrola existence souboru
            {
                throw new ArgumentException("Soubor neexistuje");
            }

            string[] radky = File.ReadAllLines(vstupniData); //nacteni radku ze souboru

            foreach (string radek in radky) 
            {
                string[] dataString = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries); //rozdeli radek na jednotlive hodnoty
            }

            double[] dataDouble = Array.ConvertAll(dataS, double.Parse); //prevod stringu na double
            N = dataDouble.Length;

            console.WriteLine("Smerodatna odchylka: " + smerodatnaOdchylka(dataDouble, N));   //vypis vysledku
        }

        /// <summary>
        /// Funkce pro výpočet aritmetického průměru
        /// </summary>
        /// <param name="dataDouble"> Pole všech čísel, se kterými pracujeme </param>
        /// <param name="N"> Počet čísel, se kterými pracujeme </param>
        /// <returns> Vrací hodnotu aritmetického průměru </returns>
        private double aritmetickyPrumer(double[] dataDouble, int N)
        {
            double suma = 0;
            for (int i = 0; i < N; i++)
            {
                suma = vypocet.Soucet(suma, dataDouble[i]);
            }
            return vypocet.Deleni(suma, N);
        }

        /// <summary>
        /// Funkce pro výpočet směrodatné odchylky
        /// </summary>
        /// <param name="dataDouble"> Pole všech čísel, se kterými pracujeme </param>
        /// <param name="N"> Počet čísel, se kterými pracujeme </param>
        /// <returns> Vrací hodnotu směrodatné odchylky </returns>
        private double smerodatnaOdchylka(double[] dataDouble, int N)
        {
            double suma = 0;
            for (int i = 0; i < N; i++)
            {
                suma = vypocet.Soucet(suma, vypocet.Mocnina(vypocet.Rozdil(dataDouble[i], aritmetickyPrumer(double[] dataDouble, int N)), 2));
            }
            return vypocet.Odmocnina(vypocet.Deleni(suma, vypocet.rozdil(N, 1)), 2);
        }
    }
}
