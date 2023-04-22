/*
 * Projekt: Plantážníci - Kalkulačka
 *
 * Soubor:  MathLib.cs
 * 
 * Tým:     Plantážníci
 *
 * Autoři:  Marek Kunz (xkunzm02) - vedouci
 *          Jan Křivák (xkriva36)
 *          Marian Pražák (xpraza11)
 *          Kryštof Pleva (xpleva09)
 * 
 * Popis:   Knihovna matematických operací
 * 
 */
/**
 * @file MathLib.cs
 * 
 * @brief Knihovna matematických operací
 * 
 * @author Marek Kunz, Jan Křivák, Marian Pražák, Kryštof Pleva
 *
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantaznici.Kalkulacka.MathLib
{
    /// <summary>
    /// Třída pro knihovnu matematických operací
    /// </summary>
    public class MatematickaKnihovna
    {
        /// <summary>
        /// Funkce pro sčítání dvou čísel
        /// </summary>
        /// <param name="scitanecA"> První sčítané číslo </param>
        /// <param name="scitanecB"> Druhé sčítané číslo </param>
        /// <returns> Vrací součet vstupních hodnot</returns>
        public double Scitani(double scitanecA, double scitanecB)
        {
            return scitanecA + scitanecB;
        }   // Konec funkce Scitani

        /// <summary>
        /// Funkce pro odčítání dvou čísel
        /// </summary>
        /// <param name="mensenec"> Základ, od kterého odčítáme </param>
        /// <param name="mensitel"> Hodnota, kterou odčítáme od základu </param>
        /// <returns> Vrací rozdíl vstupních hodnot </returns>
        public double Odcitani(double mensenec, double mensitel)
        {
            return mensenec - mensitel;
        }   // Konec funkce Odcitani

        /// <summary>
        /// Funkce pro násobení dvou čísel
        /// </summary>
        /// <param name="cinitelA"> První násobené číslo </param>
        /// <param name="cinitelB"> Druhé násobené číslo </param>
        /// <returns> Vrací součin vstupních hodnot </returns>
        public double Nasobeni(double cinitelA, double cinitelB)
        {
            return cinitelA * cinitelB;
        }   // Konec funkce Nasobeni

        /// <summary>
        /// Funkce pro dělení dvou čísel
        /// </summary>
        /// <exception cref="DivideByZeroException"> Vyvolá výjimku, pokud je dělitel nulou </exception>
        /// <param name="delenec"> Základ, od který dělíme </param>
        /// <param name="delitel"> Hodnota, kterou dělíme základ </param>
        /// <returns> Vrací podíl vstupních hodnot </returns>
        public double Deleni(double delenec, double delitel)
        {
            if (delitel == 0)
            {
                try
                {
                    throw new DivideByZeroException("Neplatne deleni nulou");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            else
            {
                return delenec / delitel;
            }
        }   // Konec funkce Deleni

        /// <summary>
        /// Funkce pro výpočet faktoriálu čísla
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <list type="bullet">
        ///            <item>
        ///                <term> Výchozí hodnota návratové hodnoty je 1  </term>
        ///            </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud  vstupní hodnota není přirozeným číslem </exception>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je vstupní hodnota záporná </exception>
        /// <param name="n"> Číslo, pro které hledáme faktoriál </param>
        /// <returns> Vrací hodnotu faktoriálu ze vstupní hodnoty </returns>
        public double Faktorial(double n)
        {
            if (n >= 0)
            {
                if (n == (int)n)
                {
                    double faktorial = 1;
                    for (uint i = 1; i <= n; i++)
                    {
                        faktorial *= i;
                    }
                    return faktorial;
                }
                else
                {
                    try
                    {
                        throw new ArgumentException("Faktorial je definovan pouze pro prirozena cisla");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
            }
            else
            {
                try
                {
                    throw new ArgumentException("Faktorial zaporneho cisla neni definovan");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
        }   // Konec funkce Faktorial

        /// <summary>
        /// Funkce pro výpočet mocniny čísla
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         <list type="bullet">
        ///            <item>
        ///                <term> Výchozí hodnota návratové hodnoty je 1  </term>
        ///            </item>
        ///         </list>
        ///     </para>
        ///     <para>
        ///         Využité externí funkce:
        ///     </para>
        ///     <para>
        ///         <list type="table">
        ///             <item>
        ///                 <term> Zaokrouhleni </term>
        ///                 <description> Využita pro zaokrouhlení exponentu na celé číslo </description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je základ i exponent nulou </exception>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je základ nulou a exponent je záporný </exception>
        /// <param name="zaklad"> Základ, který umocňujeme </param>
        /// <param name="exponent"> Exponent, kterým umocňujeme základ</param>
        /// <returns> Vrací hodnotu po umocnění základu exponentem </returns>
        public double Umocneni(double zaklad, double exponent)
        {
            exponent = Zaokrouhleni(exponent);
            double vysledek = 1;
            if (exponent == 0)
            {
                if (zaklad == 0)
                {
                    try
                    {
                        throw new ArgumentException("Nedefinovany vysledek");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
                else if (zaklad < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }

            if (exponent > 0)   // Výpočet mocniny pro kladné exponenty
            {
                for (int i = 0; i < exponent; i++)
                {
                    vysledek *= zaklad;
                }
            }
            else if (exponent < 0)  // Výpočet mocniny pro záporné exponenty
            {
                if (zaklad != 0)
                {
                    for (int i = 0; i > exponent; i--)
                    {
                        vysledek = vysledek / zaklad;
                    }
                }
                else 
                {
                    try
                    {
                        throw new ArgumentException("Deleni nulou");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
            }

            return vysledek;
        }   // Konec funkce Umocneni

        /// <summary>
        /// Funkce pro výpočet odmocniny čísla
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Využité externí funkce:
        ///     </para>
        ///     <para>
        ///         <list type="table">
        ///             <item>
        ///                 <term> Zaokrouhleni </term>
        ///                 <description> Využita pro zaokrouhlení exponentu na celé číslo </description>
        ///             </item>
        ///             <item>
        ///                 <term> AbsHodnota </term>
        ///                 <description> Využita při kontrole odchilky při výpočtu odmocniny </description>
        ///             </item>
        ///             <item>
        ///                 <term> Umocneni </term>
        ///                 <description> Využita při výpočtu odmocniny </description>
        ///             </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je exponent nulový </exception>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je základ nulový a exponent je záporný </exception>
        /// <exception cref="ArgumentException"> Vyvolá výjimku, pokud je základ záporný a exponent je sudý </exception>
        /// <param name="zaklad"> Základ, který odmocňujeme </param>
        /// <param name="exponent"> Exponent, kterým odmocňujeme základ </param>
        /// <returns> Vrací hodnotu po odmocnění základu exponentem </returns>
        public double Odmocneni(double zaklad, double exponent)
        {
            exponent = Zaokrouhleni(exponent);
            if (exponent == 0)
            {
                try
                {
                    throw new ArgumentException("Nelze mit odmocninu s nulovym exponentem");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }
            if (zaklad == 0)
            {
                if (exponent < 0)
                {
                    try
                    {
                        throw new ArgumentException("Deleni nulou");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        throw;
                    }
                }
                else
                {
                    return 0;
                }
            }

            if (exponent % 2 == 0 && zaklad < 0)
            {
                try
                {
                    throw new ArgumentException("Nelze odmocnit zaporne cislo sudym exponentem");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    throw;
                }
            }

            if (exponent < 0)
            {
                return 1 / Odmocneni(zaklad, -exponent);
            }

            if (exponent == 1)
            {
                return zaklad;
            }

            double x = zaklad / exponent;
            double xPredchozi;
            double odchylka = 0.0000001;
            do  // cyklus pro výpočet odmocniny s přesností na 7 desetinných míst
            {
                xPredchozi = x;
                x = ((exponent - 1.0) * x + zaklad / Umocneni(x, exponent - 1)) / exponent;
            } while (AbsHodnota(x - xPredchozi) > odchylka);
            return x;
        }   // Konec funkce Odmocneni

        /// <summary>
        /// Funkce pro výpočet absolutní hodnoty čísla
        /// </summary>
        /// <param name="n"> Číslo, pro které hledáme absolutní hodnotu </param>
        /// <returns> Vrací hodnotu absolutní hodnoty ze vstupní hodnoty </returns>
        public double AbsHodnota(double n)
        {
            if (n < 0)
            {
                return -n;
            }
            else
            {
                return n;
            }
        }   // Konec funkce AbsHodnota

        /// <summary>
        /// Funkce pro zaokrouhlení čísla
        /// </summary>
        /// <param name="n"> Číslo, které chceme zaokrouhlit </param>
        /// <returns> Vrací zaokrouhlenou hodnotu vstupní hodnoty </returns>
        public double Zaokrouhleni(double n)
        {
            double x = (int)n;  // Získání celé části čísla

            if (n < 0)
            {
                if ((n - x) > -0.5) // Je-li původní číslo záporné a rozdíl mezi původním číslem a jeho celou částí větší než -0.5
                {
                    return x;
                }
                else
                {
                    x -= 1;
                    return x;
                }
            }
            else
            {
                if ((n - x) < 0.5)  // Je-li původní číslo kladné a rozdíl mezi původním číslem a jeho celou částí menší než 0.5
                {
                    return x;
                }
                else
                {
                    x += 1;
                    return x;
                }
            }
        }   // Konec funkce Zaokrouhleni
    }   // Konec třídy pro knihovnu matematických operací
}   // Konec Knihovny matematických operací