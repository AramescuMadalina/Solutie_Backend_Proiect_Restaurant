using Solutie_Backend_Proiect_Restaurant_N;
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
    public partial class MyList : Form
    {
        List<Ingredient> list = new List<Ingredient>();
        public MyList(List<Ingredient> allIngredients)
        {
            InitializeComponent();
            list = allIngredients;
            this.MaximizeBox = false;

        }
        private void MyList_Load(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MainMenu mainMenu = new MainMenu();
                MessageBox.Show("Lista este goala!");
                this.Close();
                mainMenu.Show();

            }
            LoadMyList();
        }

        private void LoadMyList()
        {
            flowLayoutPanel1.Controls.Clear();
            decimal totalPrice = 0;
            decimal deliveryPrice = 5m;
            string currency = " ";
            
            foreach (var item in list)
            {
                MenuListControl menuListControl = new MenuListControl();
                menuListControl.SetIngredient(item);
                flowLayoutPanel1.Controls.Add(menuListControl);
                menuListControl.IngredientRemoved += RemoveItemInShoppingList;
                SetTotalPrice(item);
                decimal priceValue = item.GetPretNumeric();
                if (priceValue > 0)
                {
                    totalPrice += priceValue;
                    if (string.IsNullOrEmpty(currency)) currency = item.GetMoneda();
                }

            }
            decimal totalDeliveryPrice = totalPrice + deliveryPrice;
            totalPriceLabel.Text = $"{totalPrice} RON";
            deliveryPriceLabel.Text = $"{deliveryPrice} RON";
            totalDeliveryTotal.Text = $"{totalDeliveryPrice} RON";

            tableLayoutPanel1.Controls.Add(totalPriceLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(deliveryPriceLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(totalDeliveryTotal, 1, 2);

        }
        public void SetTotalPrice(Ingredient ingredient)
        {
            totalPriceLabel.Text = ingredient.Pret;

        }
        private void RemoveItemInShoppingList(object sender, Ingredient ingredient)
        {
            MenuListControl listControlRemove = new MenuListControl();
            if (listControlRemove != null)
            {
                list.Remove(ingredient);
                flowLayoutPanel1.Controls.Remove(listControlRemove);
                listControlRemove.Dispose();
            } 
            LoadMyList();
            MessageBox.Show($"Preparatul {ingredient.Nume} a fost sters din lista de cumpărături!");
            MainMenu mainMenu = new MainMenu();
            if (list.Count == 0)
            {
                this.Close();
                MessageBox.Show("Lista este goala!");
                mainMenu.Show();
            }

                flowLayoutPanel1.Refresh();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OrderNowButton_Click(object sender, EventArgs e)
        {
            DataDelivery dataDelivery = new DataDelivery();
            dataDelivery.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
