namespace Online_Retail_Store_v0.Models
{
    public class Customer:User
    {
        public Customer() { 
            User_Type=UserType.Customer;
        }
    }
}
