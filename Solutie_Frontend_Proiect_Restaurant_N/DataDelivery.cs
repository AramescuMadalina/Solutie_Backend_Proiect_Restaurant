using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solutie_Frontend_Proiect_Restaurant_N
{
    public partial class DataDelivery : Form
    {
        public DataDelivery()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void DetailsAddresGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            foreach (Form form in Application.OpenForms)
            {
                if (form is MainMenu)
                {
                    form.Show();
                    return;
                }
            }
            MainMenu mainMenu = new MainMenu();
            mainMenu.Close();
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageBox.Show("Introduceti numele!");
                return;
            }

            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                MessageBox.Show("Introduceti numarul de telefon!");
                if (PhoneTextBox.Text.Length > 10)
                {
                    MessageBox.Show("Numarul introdus nu este corect");
                }
                return;
            }
            if (string.IsNullOrEmpty(StreetTextBox.Text))
            {
                MessageBox.Show("Introduceti adresa de domiciliu!");
                return;
            }
            if (string.IsNullOrEmpty(CityTextBox.Text))
            {
                MessageBox.Show("Introduceti orasul!");
                return;
            }
            MessageBox.Show("Comanda a fost plasata!");
            this.Close();
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
