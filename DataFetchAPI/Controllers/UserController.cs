using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Data;
using System.Net.Http;
using System.Data.SqlClient;
using Newtonsoft.Json;
using DataFetchAPI.DataLayer;
using DataFetchAPI.Models;

namespace DataFetchAPI.Controllers
{
    public class UserController : ApiController
    {


        DataLayer.UserAccess usermodel = new DataLayer.UserAccess();
        // GET api/values
        public DataSet Getrecord()
        {
            DataSet ds = usermodel.GetRecords();


            return ds;
        }


        [HttpPost]
        public IHttpActionResult AddUser([FromBody]User cs)

        {
            try

            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                usermodel.Add_User(cs);

                return Ok("Success");
            }

            catch (Exception)

            {
                return Ok("Something went wrong, try later");

            }

        }



        [HttpDelete]
        public IHttpActionResult DeleteUser([FromUri]int id)

        {
            try

            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                usermodel.Delete_User(id);

                return Ok("Deleted");
            }

            catch (Exception)

            {
                return Ok("Something went wrong, try later");

            }

        }

        [HttpPut]
        public IHttpActionResult UpdateUser([FromUri]int id, [FromBody] User user)

        {
            try

            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                usermodel.Update_User(user, id);

                return Ok("Updated");
            }

            catch (Exception)

            {
                return Ok("Something went wrong, try later");

            }

        }


    }
}