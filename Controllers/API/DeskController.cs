using ResturantUsingMvcEtLts.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ResturantUsingMvcEtLts.Controllers.API
{
    public class DeskController : ApiController
    {
        string connectionString = "Data Source=DESKTOP-IGIOI52;Initial Catalog=ResturantDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";
        List<Desk> desksList = new List<Desk>();
        // GET: api/Desk
        public IHttpActionResult Get()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string getQuery = $@"SELECT * FROM Desk";
                    SqlCommand cmd = new SqlCommand(getQuery, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            desksList.Add(new Desk(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetBoolean(3), reader.GetInt32(4)));
                        }
                    }
                    connection.Close();
                    return Ok(desksList);
                }
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // GET: api/Desk/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = $@"SELECT * FROM Desk WHERE Id = {id}";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Desk waiter = new Desk(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetBoolean(3), reader.GetInt32(4));
                            return Ok(new { waiter });
                        }
                    }
                    connection.Close();
                }
                return NotFound();
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // POST: api/Desk
        public IHttpActionResult Post([FromBody] Desk userDesk)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string postQuery = $@"INSERT INTO Desk(Number,Size,IsFree,NumberOfSeet) values({userDesk.Number},{userDesk.Size},'{userDesk.IsFree}',{userDesk.NumberOfSeet})";
                    SqlCommand cmd = new SqlCommand(postQuery, connection);
                    int rows = cmd.ExecuteNonQuery();
                    connection.Close();
                    return Ok("Desk was Added");
                }
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/Desk/5
        public IHttpActionResult Put(int id, [FromBody] Desk userDesk)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string putQuery = $@"UPDATE Desk SET Number = {userDesk.Number},Size={userDesk.Size},'{userDesk.IsFree}',{userDesk.NumberOfSeet} WHERE Id={id}";
                    SqlCommand cmd = new SqlCommand(putQuery, connection);
                    int rowsEffected = cmd.ExecuteNonQuery();
                    connection.Close();
                    return Ok("Desk was Update");
                }

            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE: api/Desk/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string deleteQuery = $@"DELETE FROM Desk WHERE Id = {id}";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    int deleteEffected = deleteCommand.ExecuteNonQuery();
                    connection.Close();
                    return Ok("Desk was Deleted");
                }
            }
            catch (SqlException err)
            {
                return BadRequest(err.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
