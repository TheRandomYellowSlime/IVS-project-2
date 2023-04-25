/*
 * Projekt: Plantážníci - Kalkulačka
 *
 * Soubor:  FormHint.cs
 * 
 * Tým:     Plantážníci
 *
 * Autoři:  Marek Kunz (xkunzm02)
 *          Jan Křivák (xkriva36)
 *          Marian Pražák (xpraza11)
 *          Kryštof Pleva (xpleva09)
 * 
 * Popis:   Backend kalkulačky
 * 
 */
/**
 * @file FormHint.cs
 * 
 * @brief Nápověda kalkulačky
 * 
 * @author Marek Kunz, Jan Křivák, Marian Pražák, Kryštof Pleva
 *
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Nápověda
/// </summary>
namespace Plantaznici.Kalkulacka
{
    /// <summary>
    /// Třída s tělem formuláře nápovědy
    /// </summary>
    public partial class FormHint : Form
    {
        public Point mouseLocation;
        public FormHint()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
