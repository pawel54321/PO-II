using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace KOLOKWIUM_II
{
    public partial class Form1 :  Form
    {
        List<Miasto> lista;

        public Form1()
        {
            InitializeComponent();

            lista = new List<Miasto>();


            Miasto obiekt1 = new Miasto("male",3000);
            Miasto obiekt2 = new Miasto("srednie",5000);

            Miasto_2 obiekt3 = new Miasto_2("duze", 8000,10000.7);
            Miasto_2 obiekt4 = new Miasto_2("male", 1000,2000.5);

            lista.Add(obiekt1);
            lista.Add(obiekt2);

            lista.Add(obiekt3);
            lista.Add(obiekt4);

            
            dataGridView1.Rows.Add(obiekt1.Rodzaj, obiekt1.LiczbaMieszkancow);
            dataGridView1.Rows.Add(obiekt2.Rodzaj, obiekt2.LiczbaMieszkancow);
            
            dataGridView1.Rows.Add(obiekt3.Rodzaj, obiekt3.LiczbaMieszkancow,obiekt3.Powierzchnia);
            dataGridView1.Rows.Add(obiekt4.Rodzaj, obiekt4.LiczbaMieszkancow,obiekt4.Powierzchnia);

        }

        private void label1_Click(object sender, EventArgs e)
        {
            //Rodzaj - label
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Wyczysc - button

            for (  int a = 0; a<lista.Count; a++)
            dataGridView1.Rows.Clear();

            //lista.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Rodzaj - pole tekstowe
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //Liczba mieszkancow - label
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //Rodzaj - label 2
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //tabela
        }

        private void Wprowadzanie_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //Powierzchnia label
        }

        /*
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Liczba mieszkańców - pole tekstowe
        }
        */

        private void Wyszukaj_Click(object sender, EventArgs e)
        {
            //wyszukaj - button

            if (Rodzaj_wprowadz_2.Text == "")
                return;

            for (int x = 0; x < lista.Count; x++)
                dataGridView1.Rows.Clear();

            foreach (Miasto obiekt in lista)
            {
                
                if (obiekt.Rodzaj == Rodzaj_wprowadz_2.Text)
                {

                    if (obiekt is Miasto_2)
                    {
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow, ((Miasto_2)obiekt).Powierzchnia);
                    }

                    else if (obiekt is Miasto)
                    {
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow);
                    }

                }
            }
            
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Dodaj - button
            //numericUpDown1 - Liczba_mieszkancow
            //numericUpDown2 - Powierzchnia

            if (Rodzaj_wprowadz.Text == "male" || Rodzaj_wprowadz.Text == "srednie" || Rodzaj_wprowadz.Text == "duze") // dodatkowo zeby nie wprowadzalo puste jak wpisałem w właściwościach pól
            {
                if (numericUpDown1.Text != "" && numericUpDown2.Text == "")
                {
                    Miasto obiekt1 = new Miasto();
                    obiekt1.Rodzaj = Rodzaj_wprowadz.Text;  
                    obiekt1.LiczbaMieszkancow = Int32.Parse(numericUpDown1.Text);

                    lista.Add(obiekt1);
                    dataGridView1.Rows.Add(obiekt1.Rodzaj, obiekt1.LiczbaMieszkancow);
                }
                else if (numericUpDown1.Text != "" && numericUpDown2.Text != "")
                {
                    Miasto_2 obiekt2 = new Miasto_2();
                    obiekt2.Rodzaj = Rodzaj_wprowadz.Text;
                    obiekt2.LiczbaMieszkancow = Int32.Parse(numericUpDown1.Text);
                    obiekt2.Powierzchnia = Double.Parse(numericUpDown2.Text);

                    lista.Add(obiekt2);
                    dataGridView1.Rows.Add(obiekt2.Rodzaj,obiekt2.LiczbaMieszkancow, obiekt2.Powierzchnia);
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Pierwszy Radio Group
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //Zapisz - button

            //Zapis listy:
            /*
            string znak = "";

            if (radioButton2.Checked)
                znak = ";";
            else if (radioButton1.Checked)
                znak = ",";
            else return;
                        
            bool tryb = false;
            if (checkBox1.Checked)
            tryb = true;

            FileInfo plik = new FileInfo("plik.txt");
            StreamWriter str_wy = str_wy = new StreamWriter("plik.txt", tryb);

            string tekst = "";

            foreach (Miasto obiekt in lista)
            {  
                tekst += obiekt.Rodzaj + znak;
                tekst += obiekt.LiczbaMieszkancow + znak;
                if (obiekt is Miasto_2)
                {
                    tekst += ((Miasto_2)obiekt).LiczbaMieszkancow + znak;
                }
                tekst+='\n';
            }

            str_wy.WriteLine(tekst);
            str_wy.Close();
            */

            //Zapis tabeli:
            string znak = "";

            if (radioButton2.Checked)
                znak = ";";
            else if (radioButton1.Checked)
                znak = ".";
            else return;

            bool tryb = false;
            if (checkBox1.Checked)
                tryb = true;

            FileInfo plik = new FileInfo("plik.txt");
            StreamWriter str_wy = str_wy = new StreamWriter("plik.txt", tryb);

            string tekst = "";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Rodzaj_tab"].Value == null)
                    break;

                    tekst += row.Cells["Rodzaj_tab"].Value + znak;
                    tekst += row.Cells["Liczba_mieszkancow_tab"].Value + znak;
                    tekst += row.Cells["Powierzchnia_tab"].Value + znak;

                    tekst += '\n';
                
            }

            str_wy.WriteLine(tekst);
            str_wy.Close();


                    }

        private void button4_Click(object sender, EventArgs e)
        {
            //Odczyt - button
            char znak = '\0';

            if (radioButton4.Checked)
                znak = ';';
            else if (radioButton3.Checked)
                znak = '.';
            else return;

            FileInfo plik = new FileInfo("plik.txt");
            StreamReader str_we = plik.OpenText();

            string tekst="";
            
            while((tekst = str_we.ReadLine())!=null)
            {
                string[] t = tekst.Split(znak);

                //MessageBox.Show("|" + t[0] + "|" + t[1] + "|" + t[2]);
                if (t.Length >= 2)
                {
                    //if(t.Length==2)
                    if (t[2] == "")
                    {
                        Miasto obiekt = new Miasto();
                        obiekt.Rodzaj = t[0];
                        obiekt.LiczbaMieszkancow = Int32.Parse(t[1]);

                        lista.Add(obiekt);
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow);

                    }
                    // else if (t.Length == 3)
                    else if (t[2] != "")
                    {
                        Miasto_2 obiekt = new Miasto_2();
                        obiekt.Rodzaj = t[0];
                        obiekt.LiczbaMieszkancow = Int32.Parse(t[1]);
                        obiekt.Powierzchnia = Double.Parse(t[2]);

                        lista.Add(obiekt);
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow, obiekt.Powierzchnia);
                    }
                }
            }
        
            str_we.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // przecinek - pierwszy (zapis)
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // srednik - pierwszy (zapis)
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Nadpisywanie - Checkbox
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            // przecinek - drugi (odczyt)
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // srednik - drugi (odczyt)
        }

        private void Rodzaj_wprowadz_2_TextChanged(object sender, EventArgs e)
        {
            //Rodzaj - pole tekstowe 2
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            //Drugi Radio Group
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Pokaż cała listę - button

            for (int x = 0; x < lista.Count; x++)
                dataGridView1.Rows.Clear();

            foreach (Miasto obiekt in lista)
            {

                    if (obiekt is Miasto_2)
                    {
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow, ((Miasto_2)obiekt).Powierzchnia);
                    }

                    else if (obiekt is Miasto)
                    {
                        dataGridView1.Rows.Add(obiekt.Rodzaj, obiekt.LiczbaMieszkancow);
                    }

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            //Liczba mieszkancow - DomainUpDown
        }

        
    }
}
