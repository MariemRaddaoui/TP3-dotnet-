namespace TP3.Models
{
    public class Person
    {
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Image { get; set; }
        public string Country { get; set; }

        public Person(Int64 id, string firstName, string lastName, string email,string dateOfBirth, string image, string country)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.DateOfBirth=dateOfBirth;
            this.Image = image;
            this.Country = country;
        }
    }
}