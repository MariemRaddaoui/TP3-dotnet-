using System.Data.SQLite;
using TP3.Models;

namespace TP3.Models
{
    public class Personal_info

    {
        public List<Person> GetAllPerson()
        {
            List<Person> list = new List<Person>();
            SQLiteConnection dbCon = new SQLiteConnection("Data Source=C:\\Users\\Maryouma\\Desktop\\TP.net\\tp3\\tp3.db;");
            dbCon.Open();

            using (dbCon)
            {
                SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM personal_info", dbCon);
                SQLiteDataReader reader = cmd.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        Int64 Id = (Int64)reader["id"];
                        string FirstName = (string)reader["FirstName"];
                        string LastName = (string)reader["LastName"];
                        string Email = (string)reader["Email"];
                        string DateOfBirth = (string)reader["DateOfBirth"];
                        string Image = (string)reader["Image"];
                        string Country = (string)reader["Country"];
                        list.Add(new Person(Id, FirstName, LastName, Email,DateOfBirth, Image, Country));
                    }
                }
            }

            return list;
        }
        public Person? GetPerson(Int64 id)
        {
            List<Person> list = GetAllPerson();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Id == id)
                {
                    return list[i];
                }
            }
            return null;

        }
    }
}
