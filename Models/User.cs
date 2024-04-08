using System.ComponentModel.DataAnnotations;

namespace Online_Retail_Store_v0.Models
{
    public class User
    {
        public string User_Id { get; set; }
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name { get; set;}
        [Required]
        public string Email { get; set;}
        [Required]
        public long Phone_Number { get; set;}
        [Required]
        public string Password { get; set;} 
        public string User_Name { get; set;}
        public UserType User_Type { get; set;}

    }
}
