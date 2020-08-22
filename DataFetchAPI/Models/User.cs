using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace DataFetchAPI.Models
{
    public class User
    {



        public string name { get; set; }

        public string email { get; set; }

        public string roletype { get; set; }

        public string userstatus { get; set; }

        public string mobile { get; set; }



    }
}