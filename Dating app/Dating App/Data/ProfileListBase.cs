using Microsoft.AspNetCore.Components;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Linq;
using Dating_App.Data;
using System.Collections.Generic;

namespace Dating_App.Data
{
    public class ProfileListBase : ComponentBase
    {
        //public string sGender { get; set; }
        //public profileGender(string _gender)
        //{
        //    get return
        //}
        //public IEnumerable<ProfileInfo> loadedProfiles
        //{
        //    get
        //    {
        //        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2B7RBNS\SQLEXPRESS;Initial Catalog=DatingDB;Integrated Security=True");
        //        if (con.State == ConnectionState.Closed)
        //        {
        //            // Opens the SQL connection
        //            con.Open();
        //        }
        //        string query = $"SELECT Account.AccountID, Account.Email, Account.Username, Profile.AccountID, Profile.Firstname, Profile.Description, Profile.Area, Profile.Age, Profile.Gender, Profile.Height, Profile.Weight, Profile.DELETED FROM Account INNER JOIN Profile ON Profile.AccountID=Account.AccountID where Gender = @Gender;";

        //        List<ProfileInfo> profiles = new List<ProfileInfo>();
        //        using (SqlCommand sqlCmd = new SqlCommand(query, con))
        //        {
        //            sqlCmd.CommandType = System.Data.CommandType.Text;

        //            //sqlCmd.Parameters.AddWithValue("@Gender", sGender);
        //            SqlDataReader reader = sqlCmd.ExecuteReader();

        //            while (reader.Read())
        //            {
        //                for (int i = 0; i <= reader.FieldCount - 12; i++)
        //                {
        //                    ProfileInfo profileName = new ProfileInfo();

        //                    profileName.Firstname = reader.GetString(reader.GetOrdinal("Firstname"));
        //                    profileName.Description = reader.GetString(reader.GetOrdinal("Description"));
        //                    profileName.Age = reader.GetDateTime(reader.GetOrdinal("Age"));
        //                    profileName.City = reader.GetString(reader.GetOrdinal("Area"));
        //                    profileName.Weight = reader.GetInt32(reader.GetOrdinal("Weight"));
        //                    profileName.Height = reader.GetInt32(reader.GetOrdinal("Height"));
        //                    profileName.Gender = reader.GetString(reader.GetOrdinal("Gender"));
        //                    profileName.isDeleted = reader.GetByte(reader.GetOrdinal("DELETED"));

        //                    profiles.Add(profileName);
        //                }

        //            }
        //        }
        //        return profiles;
        //    }
        //}
    }
}


