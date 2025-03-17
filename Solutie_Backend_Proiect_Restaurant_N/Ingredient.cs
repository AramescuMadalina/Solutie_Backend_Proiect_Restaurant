namespace Solutie_Backend_Proiect_Restaurant_N
{
    public class Ingredient
    {
        public string Nume;
        public string Pret;

        public Ingredient(string nume, string pret)
        {
            Nume = nume;
            Pret = pret;

        }
        public decimal GetPretNumeric()
        {
            if (string.IsNullOrWhiteSpace(Pret)) return 0;

            
            string numericPart = new string(Pret.TakeWhile(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());

            return decimal.TryParse(numericPart, out decimal valoare) ? valoare : 0;
        }

        public string GetMoneda()
        {
            if (string.IsNullOrWhiteSpace(Pret)) return "";

            string numericPart = new string(Pret.TakeWhile(c => char.IsDigit(c) || c == '.' || c == ',').ToArray());
            return Pret.Substring(numericPart.Length).Trim();
        }

        public override string ToString()
        {
            return $"{Nume}| Pret :${Pret}";
        }

    }
}
