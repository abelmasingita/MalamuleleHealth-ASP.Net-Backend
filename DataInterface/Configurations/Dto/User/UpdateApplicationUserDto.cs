namespace DataInterface.Configurations.Dto.User
{
    public class UpdateApplicationUserDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Specialist { get; set; }
        public string PhoneNumber { get; set; }
        public bool LockoutEnabled { get; set; }

    }
}
