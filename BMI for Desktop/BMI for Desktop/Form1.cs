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

namespace BMI_for_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            BMI bmi = new BMI();

            try 
            {
                if (txtWzrost.Text == "0")
                {
                    MessageBox.Show("Wzrost nie może wynosić 0m.");
                }
                else
                {
                    double wynik = Math.Round(bmi.obliczBMI(Convert.ToSingle(txtWaga.Text), Convert.ToSingle(txtWzrost.Text)), 2);
                    lbnWynikBMI.Text = wynik.ToString();
                    bmi.infoBMI(Convert.ToSingle(wynik));
                    infoBMI.Text = bmi.textInfoBMI;
                }
            }
            catch
            {
                MessageBox.Show("Nie można obliczyć BMI!", "Błąd!");
            }
        }

        private void noweOknoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("BMI for Desktop.exe");
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IO io = new IO();
            io.Save(Convert.ToSingle(txtWaga.Text), Convert.ToSingle(txtWzrost.Text), lbnWynikBMI.Text,infoBMI.Text);
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new oProgramie().Show();
        }

        private void wytnijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(infoBMI.SelectedText);
            }
            catch { }
        }

        private void kopiujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(infoBMI.SelectedText);
                infoBMI.SelectedText = string.Empty;
            }
            catch { }
        }

        private void wklejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string paste = Clipboard.GetText();
            infoBMI.Text = infoBMI.Text.Insert(infoBMI.SelectionStart, paste);
        }

        private void zaznaczWszystkoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            infoBMI.SelectAll();
        }
    }
}
