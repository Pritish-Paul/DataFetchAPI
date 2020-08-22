using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using DataFetchAPI.Models;
namespace DataFetchAPI.DataLayer
{
    public class UserAccess
    {


        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public DataSet GetRecords()

        {
            SqlCommand com = new SqlCommand("sp_GetUserData", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public void Add_User(User user)
        {
            SqlCommand com = new SqlCommand("sp_InsertNewUser", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", user.name);
            com.Parameters.AddWithValue("@email", user.email);
            com.Parameters.AddWithValue("@roletype", user.roletype);
            com.Parameters.AddWithValue("@userstatus", user.userstatus);
            com.Parameters.AddWithValue("@mobile", user.mobile);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Delete_User(int sr_no)
        {
            SqlCommand com = new SqlCommand("sp_DeleteUser", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sr_no", sr_no);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void Update_User(User user, int sr_no)
        {
            SqlCommand com = new SqlCommand("sp_UpdateUser", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@sr_no", sr_no);
            com.Parameters.AddWithValue("@name", user.name);
            com.Parameters.AddWithValue("@email", user.email);
            com.Parameters.AddWithValue("@roletype", user.roletype);
            com.Parameters.AddWithValue("@userstatus", user.userstatus);
            com.Parameters.AddWithValue("@mobile", user.mobile);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }


    }
}


