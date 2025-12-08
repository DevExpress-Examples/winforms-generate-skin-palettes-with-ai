namespace DevExpress.AI.WinForms.AIGeneratePalette.Demo.Model
{
    public class Product(int id, string name, decimal unitPrice)
    {
        public Product() : this(-1, null, -1)
        {
        }
        public int Id { get; set; } = id;
        public string? Name { get; set; } = name;
        public decimal UnitPrice { get; set; } = unitPrice;
        public override string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}