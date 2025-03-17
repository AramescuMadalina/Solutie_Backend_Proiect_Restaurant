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
    public partial class MenuItem : UserControl
    {
        private string _ingredientName = "<ingredient_name>";
        private string _ingredientPrice = "<ingredient_price>";
        private Image _image;
        public event EventHandler <Ingredient> IngredientAdded;
        private Ingredient _currentIngredient;
        public MenuItem()
        {
            InitializeComponent();
        }
        //public string IngredientName
        //{
        //    get => _ingredientName; set
        //    {
        //        _ingredientName = value;
        //        _ingredientNameLabel.Text = value;
        //    }
        //}
        //public string IngredientPrice
        //{
        //    get => _ingredientPrice; set
        //    {
        //        _ingredientPrice = value;
        //        _ingredientPriceLabel.Text = value;
        //    }
        //}
        //public Image IngredientImage
        //{
        //    get { return _image; }
        //    set
        //    {
        //        _image = value;
        //        pictureBox1.Image = _image;
        //    }
        //}
        public void SetIngredient(Ingredient ingredient)
        {
            _currentIngredient = ingredient;
            _ingredientNameLabel.Text = ingredient.Nume;
            _ingredientPriceLabel.Text = $"{ingredient.Pret}";
        }
        public void GetImage(ImageResource Image)
        {
            pictureBox1.Image = Image.Image;

        }
        private void label2_Click(object sender, EventArgs e)
        {
          
            IngredientAdded?.Invoke(this, _currentIngredient);

        }
    }
}
