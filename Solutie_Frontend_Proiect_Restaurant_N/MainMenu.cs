using Solutie_Backend_Proiect_Restaurant_N;
using Solutie_Frontend_Proiect_Restaurant_N.Properties;
using System.Security.Cryptography.X509Certificates;
namespace Solutie_Frontend_Proiect_Restaurant_N
{
    public partial class MainMenu : Form
    {
        public List<Ingredient> ingrediente = new List<Ingredient>();
        public MainMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        public static Dictionary<string, Image> ImageDictionary = new Dictionary<string, Image>()
        {
            {"Ciorba de burta", null }
        };

        private void MainMenu_Load(object sender, EventArgs e)
        {
            List<Ingredient> ingrediente = new List<Ingredient>
            {
                 new Ingredient("Ciorbă de burtă", "25 RON"),
                 new Ingredient("Ciorbă rădăuțeană", "24 RON"),
                 new Ingredient("Supa cremă de linte", "20 RON"),
                 new Ingredient("Ciorba de vacuta", "21 RON"),
                 new Ingredient("Piept de pui la gratar", "28 RON"),
                 new Ingredient("Rulada de pui cu gorgonzola", "28 RON"),
                 new Ingredient("Snitel de pui", "28 RON"),

             };

            //List<ImageResource> imagini = new List<ImageResource>
            //{
                //new ImageResource("Ciorba de burta", Resources.ciorbavacuta),
            //    new ImageResource("Ciorba de burta", Image.FromFile("Resources/_ciorbavacuta")),
            //    new ImageResource("Ciorba radauteana", Resources.CIORBA_DE_VACUTA_2),
            //    new ImageResource("Supa crema de linte", Resources.CIORBA_DE_VACUTA_2),
            //    new ImageResource("Ciorba de vacuta", Resources.CIORBA_DE_VACUTA_2),

            

            foreach (var ingredient in ingrediente)
            {
                MenuItem control = new MenuItem();
                //var imagine = imagini.Find(x => x.Name == ingredient.Nume);
                ////imagini.FirstOrDefault();
                //if (imagine != null)
                //{
                //   control.GetImage(imagine);
                //}
                control.SetIngredient(ingredient);
                control.IngredientAdded += AddInShoppingList;
                flowLayoutPanel1.Controls.Add(control);

            }
        }
        private void AddInShoppingList(object sender, Ingredient ingredient)
        {
            if (ingrediente == null && ingrediente.Count < 0)
            {
                MessageBox.Show("Lista este goala!!");
            }
            ingrediente.Add(ingredient);
            MessageBox.Show($"Preparatul {ingredient.Nume} a fost adăugat în lista de cumpărături!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Hide();
            MyList menulist = new MyList(ingrediente);
            menulist.Show(this);
        }
    }
    public class ImageResource
    {
        public string Name;
        public Image Image;

        public ImageResource(string name, Image image)
        {
            Name = name;
            Image = image;
        }

        public ImageResource(string v, byte[] ciorbavacuta)
        {
        }
    }
}
