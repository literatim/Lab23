using System.ComponentModel.DataAnnotations;

namespace Lab21.Models
{
    public class Items
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}