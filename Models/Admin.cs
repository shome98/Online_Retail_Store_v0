namespace Online_Retail_Store_v0.Models
{
    public class Admin:User
    {
        public Admin()
        {
            User_Type=UserType.Admin;
        }
    }
}
