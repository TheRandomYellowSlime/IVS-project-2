/*
 * Autoři:  Marek Kunz (xkunzm02) - vedouci
 *          Jan Křivák (xkriva36)
 *          Marian Pražák (xpraza11)
 *          Kryštof Pleva (xpleva09)
 * 
 * Tým:     Plantážníci
 * 
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantaznici.Kalkulacka.MathLib
{
    public class MathLib
    {
        public double Scitani(double scitanecA, double scitanecB)
        {
            return scitanecA + scitanecB;
        }

        public double Odcitani(double mensenec, double mensitel)
        {
            return mensenec - mensitel;
        }

        public double Nasobeni(double cinitelA, double cinitelB)
        {
            return cinitelA * cinitelB;
        }

        public double Deleni(double delenec, double delitel)
        {
            if (delitel == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return delenec / delitel;
            }
        }

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
                    throw new ArgumentException("Faktorial je definovan pouze pro prirozena cisla");
                }
            }
            else
            {
                throw new ArgumentException("Faktorial zaporneho cisla neni definovan");
            }
        }

        public double Umocneni(double zaklad, double exponent)
        {
            double vysledek = 1;
            if (exponent == 0)
            {
                if (zaklad == 0)
                {
                    throw new ArgumentException("Nedefinovany vysledek");
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

            if (exponent > 0)
            {
                for (int i = 0; i < exponent; i++)
                {
                    vysledek *= zaklad;
                }
            }
            else if (exponent < 0)
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
                    throw new ArgumentException("Deleni nulou");
                }
            }

            return vysledek;
        }

        public double Odmocneni(double zaklad, double exponent)
        {
            if (exponent == 0)
            {
                throw new ArgumentException("Nelze mit odmocninu s nulovym exponentem");
            }
            if (zaklad == 0)
            {
                if (exponent < 0)
                {
                    throw new ArgumentException("Deleni nulou");
                }
                else
                {
                    return 0;
                }
            }

            if (exponent % 2 == 0 && zaklad < 0)
            {
                throw new ArgumentException("Nelze odmocnit zaporne cislo sudym exponentem");
            }

            if (exponent < 0)
            {
                return 1 / Odmocneni(zaklad, -exponent);
            }

            double x = zaklad / exponent;
            double xPredchozi;
            double odchylka = 0.0000001;
            do
            {
                xPredchozi = x;
                x = ((exponent - 1.0) * x + zaklad / Umocneni(x, exponent - 1)) / exponent;
            } while (AbsHodnota(x - xPredchozi) > odchylka);
            return x;
        }

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
        }
    }
}