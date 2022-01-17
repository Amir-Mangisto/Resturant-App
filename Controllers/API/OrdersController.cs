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
    public class OrdersController : ApiController
    {
        static string connectionstring = "Data Source=DESKTOP-IGIOI52;Initial Catalog=ResturantDB;Integrated Security=True;Pooling=False;MultipleActiveResultSets=True;Application Name=EntityFramework";

        OrdersDataContext DBconnection = new OrdersDataContext(connectionstring);
        // GET: api/Orders
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(DBconnection.Orders.ToList());
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

        // GET: api/Orders/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                Order order = DBconnection.Orders.First(getOrder => getOrder.Id == id);
                if (order.Paid == null) return NotFound();
                else
                {
                    return Ok(order);
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

        // POST: api/Orders
        public IHttpActionResult Post([FromBody] Order addOrder)
        {
            try
            {
                DBconnection.Orders.InsertOnSubmit(addOrder);
                DBconnection.SubmitChanges();
                return Ok("Order was Added");
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

        // PUT: api/Orders/5
        public IHttpActionResult Put(int id, [FromBody] Order updateOrder)
        {
            try
            {
                Order orderToUpdate=DBconnection.Orders.First(order => order.Id == id);
                orderToUpdate.ClientId=updateOrder.ClientId;
                orderToUpdate.EmployeeNumber=updateOrder.EmployeeNumber;
                orderToUpdate.Paid=updateOrder.Paid;
                orderToUpdate.GeneralPrice=updateOrder.GeneralPrice;
                DBconnection.SubmitChanges();
                return Ok("Order has been Update");
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

        // DELETE: api/Orders/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                Order orderToDelete = DBconnection.Orders.First(order => order.Id == id);
                DBconnection.Orders.DeleteOnSubmit(orderToDelete);
                DBconnection.SubmitChanges();
                return Ok("Order has been Deleted");
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
