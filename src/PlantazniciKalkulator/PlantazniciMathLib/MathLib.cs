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
                throw new System.DivideByZeroException();
            }
            else
            {
                return delenec / delitel;
            }
        }

        public double Faktorial(double n)
        {
            if (n < 0)
            {
                if (n % 1 != 0)
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
                    throw new System.ArgumentException("Faktorial je definovan pouze pro prirozena cisla");
                }
            }
            elses
            {
                throw new System.ArgumentException("Faktorial zaporneho cisla neni definovan");
            }
        }

        public double Umocneni(double zaklad, double exponent)
        {

            return 0;
        }

        public double Odmocneni(double zaklad, double exponent)
        {
            return 0;
        }

        public double AbsHodnota(double n)
        {
            return 0;
        }
    }
}
