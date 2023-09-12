namespace MalamuleleHealth.Web.Configurations.Dto
{
    public class UpdateApplicationUserDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public bool LockoutEnabled { get; set; }

    }
}
