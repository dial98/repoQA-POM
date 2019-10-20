namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Ventsi",
                LastName = "Batman",
                Year = "1989",
                Month = "3",
                Date = "3",
                Password = "gdsjafgujdsw",
                Gender = "male",
                PostCode = "43244",
                RealFirstName = "ventsi",
                RealLastName = "Batman",
                Address = "bul bulgaria",
                City = "Plovdiv",
                State = "Arizona",
                Country = "Bulgaria",
                Phone = "089999999",
                Alias = "neshto"             
            };
        }
    }
}
