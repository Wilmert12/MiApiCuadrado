namespace MiCuadrado.models
{
    public class Tenis
    {
        public int Id { get; set; }
        public string Marca { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public decimal Talla { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}