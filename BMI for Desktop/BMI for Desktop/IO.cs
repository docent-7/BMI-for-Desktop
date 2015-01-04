using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BMI_for_Desktop
{
    class IO
    {
        public void Save(float waga, float wzrost, string rezultatWynik, string rezultat)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Dokumenty tekstowe (*.txt)|*.txt";

            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    FileStream file = new FileStream(save.FileName, FileMode.OpenOrCreate, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(file);

                    sw.WriteLine("Waga: " + waga);
                    sw.WriteLine("Wzrost: " + wzrost);
                    sw.WriteLine("Wynik Mojego BMI: " + rezultatWynik);
                    sw.WriteLine("Stan: " + rezultat);

                    sw.Close();
                    file.Close();

                    MessageBox.Show("Gratulacje! Zapisano dane do pliku tekstowego.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd zapisu!");
                MessageBox.Show(ex.Message);
            }
        }
    }
}
