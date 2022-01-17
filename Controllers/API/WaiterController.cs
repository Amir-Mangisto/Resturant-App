using ResturantUsingMvcEtLts.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ResturantUsingMvcEtLts.Controllers.API
{
    public class WaiterController : ApiController
    {
        ResturantContext resturantContext = new ResturantContext();
        // GET: api/Waiter
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(resturantContext.Waiters.ToList());

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

        // GET: api/Waiter/5
        public async Task<IHttpActionResult> Get(int id)
        {
            try
            {
                Waiter waiter = await resturantContext.Waiters.FindAsync(id);
                return Ok(waiter);
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

        // POST: api/Waiter
        public async Task<IHttpActionResult> Post([FromBody] Waiter userWaiter)
        {
            try
            {
                resturantContext.Waiters.Add(userWaiter);
                resturantContext.SaveChanges();
                return Ok("Waiter was Added");

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

        // PUT: api/Waiter/5
        public async Task<IHttpActionResult> Put(int id, [FromBody] Waiter userWaiter)
        {
            try
            {
                Waiter waiterToUpdate = await resturantContext.Waiters.FindAsync(id);
                waiterToUpdate.FirstName = userWaiter.FirstName;
                waiterToUpdate.LastName = userWaiter.LastName;
                waiterToUpdate.Birth = userWaiter.Birth;
                waiterToUpdate.WorkingHours = userWaiter.WorkingHours;
                await resturantContext.SaveChangesAsync();
                return Ok("Waiter has been Update");
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

        // DELETE: api/Waiter/5
        public async Task<IHttpActionResult> Delete(int id)
        {
            try
            {
                Waiter waiterToDelete = await resturantContext.Waiters.FindAsync(id);
                resturantContext.Waiters.Remove(waiterToDelete);
                await resturantContext.SaveChangesAsync();
                return Ok("Waiter has Been Deleted");
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
    }
}
