using Microsoft.AspNetCore.Components;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Linq;
using Dating_App.Data;

namespace Dating_App.Data
{
    public class ProfileListBase : ComponentBase
    {
        public IEnumerable<ProfileInfo> Profiles { get; set; }

        //public string firstName { get; set; }
        //public string Description { get; set; }
        //public DateTime Age { get; set; }
        //public string City { get; set; }
        //public string Height { get; set; }
        //public string Weight { get; set; }

        public object LoadProfiles(string _searchGender)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2B7RBNS\SQLEXPRESS;Initial Catalog=DatingDB;Integrated Security=True");
            if (con.State == ConnectionState.Closed)
            {
                // Opens the SQL connection
                con.Open();
            }
            string query = $"SELECT Account.AccountID, Account.Email, Account.Username, Account.Password, Profile.AccountID, Profile.Firstname, Profile.Description, Profile.Area, Profile.Age, Profile.Gender, Profile.Height, Profile.Weight, Profile.DELETED FROM Account INNER JOIN Profile ON Profile.AccountID=Account.AccountID WHERE gender=@Gender AND isDeleted=@IsDeleted;";

            using (SqlCommand sqlCmd = new SqlCommand(query, con))
            {
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Gender", _searchGender);
                sqlCmd.Parameters.AddWithValue("@IsDeleted", 0);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                List<ProfileInfo> loadedProfiles = new List<ProfileInfo>();
                while (reader.Read())
                {
                    for (int i = 0; i <= reader.FieldCount - 1; i++)
                    {
                        ProfileInfo profileName = new ProfileInfo();

                        profileName.Firstname = reader.GetString(reader.GetOrdinal("Firstname"));
                        profileName.Description = reader.GetString(reader.GetOrdinal("Description"));
                        profileName.Age = reader.GetDateTime(reader.GetOrdinal("Age"));
                        profileName.Weight = reader.GetInt32(reader.GetOrdinal("Weight"));
                        profileName.Height = reader.GetInt32(reader.GetOrdinal("Height"));
                        profileName.Gender = reader.GetString(reader.GetOrdinal("Gender"));
                        profileName.isDeleted = reader.GetInt32(reader.GetOrdinal("DELETED"));

                        loadedProfiles.Add(profileName);
                    }

                }
                return loadedProfiles;
            }
        }
    }
}
    
