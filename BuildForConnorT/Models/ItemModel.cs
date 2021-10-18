using System.ComponentModel.DataAnnotations;

namespace BuildForConnorT.Models
{
    public class ItemModel
    {
        public int ID { get; set; }
        [Required]
        public string Customer { get; set; }
        public string PartNumber { get; set; }
        public int Quantity { get; set; }
        public string ConType { get; set; }
        public string Cat { get; set; }
        public string Con { get; set; }
        public string BatchNumber { get; set; }
        public string Reason { get; set; }
        public string Action { get; set; }
        public string Raised { get; set; }
        public string Requested { get; set; }
    }
}
