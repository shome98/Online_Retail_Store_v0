using System.ComponentModel.DataAnnotations;

namespace Online_Retail_Store_v0.Models
{
    public class Product
    {
        public string Product_Id { get; set; }
        [Required]
        public string Product_Name { get; set;}
        [Required]
        public string Product_Description { get; set;} = string.Empty;
        [Required]
        public ProductCategory Product_Category { get; set;}
    }
}
