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
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Plantaznici.Kalkulacka.MathLib;


namespace Plantaznici.Kalkulacka
{
    public partial class Form1 : Form
    {

        MatematickaKnihovna vypocet = new MatematickaKnihovna();

        public Point mouseLocation;
        string podretezecPrvnihoCisla = "";
        string podretezecDruhehoCisla = "";
        double vysledek = 0;
        bool existujeZnamenko = false;
        string znamenko = "";
        bool zacatek = true;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnPow.Enabled = false;
            BtnRoot.Enabled = false;
            BtnAbs.Enabled = false;
            BtnEq.Enabled = false;
            BtnFact.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimalize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnHint_Click(object sender, EventArgs e)
        {
            FormHint napoveda = new FormHint();
            napoveda.Show();
            /*
            string filePath = "/cesta/k/uzivatelske/prirucce.pdf";
            Process.Start(filePath);
            */
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            if(zacatek==true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            textBox1.Text += "0";
            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            if (existujeZnamenko == false)
            {
                podretezecPrvnihoCisla += "0";
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
            }
            else
            {
                podretezecDruhehoCisla += "0";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            textBox1.Text += "1";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "1";
            }
            else
            {
                podretezecDruhehoCisla += "1";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            textBox1.Text += "2";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "2";
            }
            else
            {
                podretezecDruhehoCisla += "2";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            textBox1.Text += "3";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "3";
            }
            else
            {
                podretezecDruhehoCisla += "3";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            textBox1.Text += "4";
            if(podretezecPrvnihoCisla.Length==1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "4";
            }
            else
            {
                podretezecDruhehoCisla += "4";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                if(podretezecPrvnihoCisla=="+")
                {
                    podretezecPrvnihoCisla = "";
                }
                if(podretezecDruhehoCisla=="+")
                {
                    podretezecDruhehoCisla = "";
                }
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            textBox1.Text += "5";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "5";
            }
            else
            {
                podretezecDruhehoCisla += "5";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnFact.Enabled = true;
                BtnAbs.Enabled = true;
            }
            textBox1.Text += "6";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "6";
            }
            else
            {
                podretezecDruhehoCisla += "6";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
                BtnFact.Enabled = true;
            }
            textBox1.Text += "7";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "7";
            }
            else
            {
                podretezecDruhehoCisla += "7";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnFact.Enabled = true;
                BtnAbs.Enabled = true;
            }
            textBox1.Text += "8";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "8";
            }
            else
            {
                podretezecDruhehoCisla += "8";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            if (zacatek == true)
            {
                textBox1.Text = "";
                podretezecPrvnihoCisla = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }

            if (podretezecDruhehoCisla.Contains(',') || podretezecPrvnihoCisla.Contains(','))
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
            }
            if (podretezecPrvnihoCisla.Length == 1 || podretezecDruhehoCisla.Length == 1)
            {
                BtnPlus.Enabled = true;
                BtnMinus.Enabled = true;
                BtnEq.Enabled = true;
                BtnAbs.Enabled = true;
            }
            textBox1.Text += "9";
            if (existujeZnamenko == false)
            {
                BtnMul.Enabled = true;
                BtnDiv.Enabled = true;
                BtnRoot.Enabled = true;
                BtnPow.Enabled = true;
                podretezecPrvnihoCisla += "9";
            }
            else
            {
                podretezecDruhehoCisla += "9";
                BtnPlus.Enabled = false;
                BtnMinus.Enabled = false;
            }
            BtnEq.Enabled = true;
            BtnAbs.Enabled = true;
            BtnFact.Enabled = true;
            zacatek = false;
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            /*if (textBox1.Text.Length > 0)
            {
                char last = char.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
                if (char.IsDigit(last))
                {
                    textBox1.Text += ",";
                }
            }*/
            if(existujeZnamenko == false)
            {
                if (!podretezecPrvnihoCisla.Contains(','))
                {
                    if(podretezecPrvnihoCisla.Length>0)
                    {
                        if(podretezecPrvnihoCisla!="-")
                        {
                            podretezecPrvnihoCisla = podretezecPrvnihoCisla + ",";
                            textBox1.Text += ",";
                            BtnPlus.Enabled = false;
                            BtnMinus.Enabled = false;
                            BtnEq.Enabled = false;
                            BtnAbs.Enabled = false;
                            BtnMul.Enabled = false;
                            BtnFact.Enabled = false;
                            BtnDiv.Enabled = false;
                            BtnPow.Enabled = false;
                            BtnRoot.Enabled = false;
                        }
                    }    
                }
            }
            else
            {
                if (!podretezecDruhehoCisla.Contains(','))
                {
                    if (podretezecDruhehoCisla.Length > 0)
                    {
                        if (podretezecDruhehoCisla != "-")
                        {
                            podretezecDruhehoCisla = podretezecDruhehoCisla + ",";
                            textBox1.Text += ",";
                            BtnPlus.Enabled = false;
                            BtnMinus.Enabled = false;
                            BtnEq.Enabled = false;
                            BtnMul.Enabled = false;
                            BtnFact.Enabled = false;
                            BtnDiv.Enabled = false;
                            BtnPow.Enabled = false;
                            BtnRoot.Enabled = false;
                            BtnAbs.Enabled = false;
                        }
                    }
                }
            }
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text + " = ";
            label1.Text = text;
            podretezecPrvnihoCisla = podretezecPrvnihoCisla.Trim();
            podretezecDruhehoCisla = podretezecDruhehoCisla.Trim();
            switch (znamenko)
            {            
                case "+":                 
                    vysledek = vypocet.Scitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "-":
                    vysledek = vypocet.Odcitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "*":
                    vysledek = vypocet.Nasobeni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "/":
                    try
                    {
                        vysledek = vypocet.Deleni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Zakazane deleni 0", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "pow":
                    try
                    {
                        vysledek = vypocet.Umocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu mocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "root":
                    try
                    {
                        vysledek = vypocet.Odmocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu odmocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    vysledek = Convert.ToDouble(podretezecPrvnihoCisla);
                    break;
            }
            textBox1.Text = vysledek.ToString();
            podretezecPrvnihoCisla = vysledek.ToString();
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            BtnMul.Enabled = true;
            BtnDiv.Enabled = true;
            BtnRoot.Enabled = true;
            BtnPow.Enabled = true;

            podretezecDruhehoCisla = "";
            znamenko = "";
            existujeZnamenko = false;
            BtnAbs.Enabled = true;
            BtnEq.Enabled = true;
            BtnFact.Enabled = true;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            BtnRoot.Enabled = true;
            BtnPow.Enabled = true;
            zacatek = true;
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            //if (resEQ == true) resEQ = false;
            //if (textBox1.Text.Length == 0) textBox1.Text += "0";
            //textBox1.Text += "+";
            zacatek = false;
            if (existujeZnamenko==false)
            {
                if(podretezecPrvnihoCisla=="")
                {
                    BtnPlus.Enabled = false;
                    BtnMinus.Enabled = false;
                    podretezecPrvnihoCisla = "+";
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
                else
                {
                    existujeZnamenko = true;
                    BtnMul.Enabled = false;
                    BtnDiv.Enabled = false;
                    BtnRoot.Enabled = false;
                    BtnPow.Enabled = false;
                    znamenko = "+";
                    textBox1.Text += "+";
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
            }

            else if(existujeZnamenko == true)
            {
                if(podretezecDruhehoCisla=="")
                {
                    BtnPlus.Enabled = false;
                    BtnMinus.Enabled = false;
                    podretezecDruhehoCisla = "+";
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            //if (resEQ == true) resEQ = false;
            //textBox1.Text += "-";
            zacatek = false;
            if (existujeZnamenko == false)
            {
                if (podretezecPrvnihoCisla == "")
                {
                    podretezecPrvnihoCisla = "-";
                    BtnPlus.Enabled = false;
                    BtnMinus.Enabled = false;
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
                else
                {
                    existujeZnamenko = true;
                    BtnMul.Enabled = false;
                    BtnDiv.Enabled = false;
                    BtnRoot.Enabled = false;
                    BtnPow.Enabled = false;
                    znamenko = "-";
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
            }

            else if (existujeZnamenko == true)
            {
                if (podretezecDruhehoCisla == "")
                {
                    podretezecDruhehoCisla = "-";
                    BtnPlus.Enabled = false;
                    BtnMinus.Enabled = false;
                    BtnEq.Enabled = false;
                    BtnAbs.Enabled = false;
                    BtnFact.Enabled = false;
                }
            }
            textBox1.Text += "-";
        }

        private void BtnMul_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length == 0) return;
            //if (resEQ == true) resEQ = false;
            zacatek = false;
            existujeZnamenko = true;
            znamenko = "*";
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnRoot.Enabled = false;
            BtnPow.Enabled = false;
            BtnEq.Enabled = false;
            BtnAbs.Enabled = false;
            BtnFact.Enabled = false;
            textBox1.Text += "×";
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text.Length == 0) return;
            //char last = char.Parse(textBox1.Text.Substring(textBox1.Text.Length - 1));
            //if (last == '+' || last == '-' || last == '×' || last == '÷') return;
            //if (resEQ == true) resEQ = false;
            zacatek = false;
            existujeZnamenko = true;
            znamenko = "/";
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnRoot.Enabled = false;
            BtnPow.Enabled = false;
            textBox1.Text += "÷";
            BtnEq.Enabled = false;
            BtnAbs.Enabled = false;
            BtnFact.Enabled = false;
        }

        private void BtnAbs_Click(object sender, EventArgs e)
        {
            string text = "| " + textBox1.Text + " | = ";
            label1.Text = text;
            podretezecPrvnihoCisla = podretezecPrvnihoCisla.Trim();
            podretezecDruhehoCisla = podretezecDruhehoCisla.Trim();
            switch (znamenko)
            {
                case "+":
                    vysledek = vypocet.Scitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "-":
                    vysledek = vypocet.Odcitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "*":
                    vysledek = vypocet.Nasobeni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "/":
                    try
                    {
                        vysledek = vypocet.Deleni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Zakazane deleni 0", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "pow":
                    try
                    {
                        vysledek = vypocet.Umocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu mocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "root":
                    try
                    {
                        vysledek = vypocet.Odmocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu odmocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    vysledek = Convert.ToDouble(podretezecPrvnihoCisla);
                    break;
            }

            vysledek = vypocet.AbsHodnota(vysledek);
            textBox1.Text = vysledek.ToString();
            podretezecPrvnihoCisla = vysledek.ToString();
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            BtnMul.Enabled = true;
            BtnDiv.Enabled = true;

            podretezecDruhehoCisla = "";
            znamenko = "";
            existujeZnamenko = false;
            BtnAbs.Enabled = true;
            BtnEq.Enabled = true;
            BtnFact.Enabled = true;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            zacatek = true;
        }

        private void BtnPow_Click(object sender, EventArgs e)
        {
            zacatek = false;
            existujeZnamenko = true;
            znamenko = "pow";
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnRoot.Enabled = false;
            BtnPow.Enabled = false;
            textBox1.Text += "∧";
            BtnEq.Enabled = false;
            BtnAbs.Enabled = false;
            BtnFact.Enabled = false;
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            zacatek = false;
            existujeZnamenko = true;
            znamenko = "root";
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnRoot.Enabled = false;
            BtnPow.Enabled = false;
            textBox1.Text += "∨";
            BtnEq.Enabled = false;
            BtnAbs.Enabled = false;
            BtnFact.Enabled = false;
        }

        private void BtnFact_Click(object sender, EventArgs e)
        {
            string text = " (" + textBox1.Text + ")!  = ";
            label1.Text = text;
            podretezecPrvnihoCisla = podretezecPrvnihoCisla.Trim();
            podretezecDruhehoCisla = podretezecDruhehoCisla.Trim();
            switch (znamenko)
            {
                case "+":
                    vysledek = vypocet.Scitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "-":
                    vysledek = vypocet.Odcitani(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "*":
                    vysledek = vypocet.Nasobeni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    break;
                case "/":
                    try
                    {
                        vysledek = vypocet.Deleni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Zakazane deleni 0", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "pow":
                    try
                    {
                        vysledek = vypocet.Umocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu mocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "root":
                    try
                    {
                        vysledek = vypocet.Odmocneni(Convert.ToDouble(podretezecPrvnihoCisla), Convert.ToDouble(podretezecDruhehoCisla));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chyba pri vypoctu odmocniny", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    vysledek = Convert.ToDouble(podretezecPrvnihoCisla);
                    break;
            }

            try
            {
                vysledek = vypocet.Faktorial(vysledek);
            }
            catch (Exception)
            {

                MessageBox.Show("Chyba pri vypoctu faktorialu", "Chyba vypoctu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox1.Text = vysledek.ToString();
            podretezecPrvnihoCisla = vysledek.ToString();
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            BtnMul.Enabled = true;
            BtnDiv.Enabled = true;

            podretezecDruhehoCisla = "";
            znamenko = "";
            existujeZnamenko = false;
            BtnAbs.Enabled = true;
            BtnEq.Enabled = true;
            BtnFact.Enabled = true;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            zacatek = true;
        }

        private void BtnCA_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            podretezecPrvnihoCisla = "";
            podretezecDruhehoCisla = "";
            znamenko = "";
            existujeZnamenko = false;
            vysledek = 0;
            label1.Text = "";
            BtnMul.Enabled = false;
            BtnDiv.Enabled = false;
            BtnAbs.Enabled = false;
            BtnEq.Enabled = false;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
            BtnFact.Enabled = false;
            BtnRoot.Enabled = false;
            BtnPow.Enabled = false;
            zacatek = true;
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void Btn3_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Add)
            {
                BtnPlus.PerformClick();
            }

            if (e.KeyCode == Keys.Subtract)
            {
                BtnMinus.PerformClick();
            }

            if (e.KeyCode == Keys.Multiply)
            {
                BtnMul.PerformClick();
            }

            if (e.KeyCode == Keys.Divide)
            {
                BtnDiv.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                Btn0.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                Btn1.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                Btn2.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                Btn3.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                Btn4.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                Btn5.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                Btn6.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                Btn7.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                Btn8.PerformClick();
            }

            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                Btn9.PerformClick();
            }

            if (e.KeyCode == Keys.E)
            {
                BtnEq.PerformClick();
            }

            if (e.KeyCode == Keys.A)
            {
                BtnAbs.PerformClick();
            }

            if (e.KeyCode == Keys.F)
            {
                BtnFact.PerformClick();
            }

            if (e.KeyCode == Keys.P)
            {
                BtnPow.PerformClick();
            }

            if (e.KeyCode == Keys.R)
            {
                BtnRoot.PerformClick();
            }

            if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Oemcomma)
            {
                BtnComma.PerformClick();
            }

            if (e.KeyCode == Keys.Back)
            {
                BtnCA.PerformClick();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
