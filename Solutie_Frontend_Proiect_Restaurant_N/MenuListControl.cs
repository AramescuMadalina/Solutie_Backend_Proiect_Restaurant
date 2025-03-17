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
    public partial class MenuListControl : UserControl
    {
        public event EventHandler<Ingredient> IngredientRemoved;
        private Ingredient _currentIngredient;
        public MenuListControl()
        {
            InitializeComponent();
 
        }
        public void SetIngredient(Ingredient ingredient)
        {
            _currentIngredient = ingredient;
            _ingredientListNameLabel.Text = ingredient.Nume;
            _ingredientListPriceLabel.Text = $"{ingredient.Pret}";
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            IngredientRemoved?.Invoke(this, _currentIngredient);
        }
    }
}
