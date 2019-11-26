using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using DriverApplication.DTOs;
using DriverApplication.Filters;
using DriverApplication.Models;
using DriverApplication.Services;
using DriverApplication.Utilities;

namespace DriverApplication.Controllers
{
    [NotImplExceptionFilter]
    public class DriversController : ApiController
    {
        private DBContext db = new DBContext();

        private IDriverService driverService;
        public DriversController(IDriverService driverService)
        {
            this.driverService = driverService;
        }
        // GET all drivers.
        [HttpGet]
        [Route("drivers")]
        public IEnumerable<Driver> GetDrivers()
        {           
                return  driverService.GetDrivers().ToList();
        }

        // GET: api/Drivers/5
        [HttpGet]
        [Route("drivers/{id}")]
        [ResponseType(typeof(Driver))]
        public IHttpActionResult GetDriver(int id)
        {
            Driver driver = driverService.GetDriver(id);

            //Driver driver = db.Drivers.Find(id);
            if (driver == null)
            {
                //return NotFound();

                // exception handling using HttpResponseException..
                //var msg = new HttpResponseMessage(HttpStatusCode.NotFound)
                //{
                //    Content = new StringContent(string.Format("your search id is not availabe. try again with a valid driver id.")),
                //    ReasonPhrase = "Driver not found"
                //};

                //throw new HttpResponseException(msg);



                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("your search id is not availabe. try again with a valid driver id.", id);
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }

            return Ok(driver);
        }

        // PUT: api/Drivers/5
        [HttpPut]
        [Route("drivers")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDriver(int id, Driver driver)
        {
            if (!ModelState.IsValid)
            {   
                return BadRequest(ModelState);
            }

            //db.Entry(driver).State = EntityState.Modified;
            driver.Driver_id = id;
            string msg = driverService.PutDriver(driver);
            driverService.SaveDriver();
            //try
            //{
            //    //db.SaveChanges();
            //    driverService.SaveDriver();

            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!DriverExists(id))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return Ok(msg);
        }

        // POST: api/Drivers
        [NotImplExceptionFilter]
        [HttpPost]
        [Route("drivers")]
        [ResponseType(typeof(Driver))]
        public IHttpActionResult CreateDriver(Driver driver)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);

                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("please try again with valid properties");
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }
            driver.Ip_address = "192.168.1.1.1.1";      // assign other values which are not sent by client like this..
            driverService.CreateDriver(driver);
            driverService.SaveDriver();
            //db.Commit();

            return Created(new Uri(Request.RequestUri + "/" + driver.Driver_id), driver);
        }

        // DELETE: api/Drivers/5
        [HttpDelete]
        [Route("drivers")]
        [ResponseType(typeof(Driver))]
        public IHttpActionResult DeleteDriver(int id)
        {
            Driver driver = driverService.GetDriver(id);
            if (driver == null)
            {
                return NotFound();
            }

            driverService.DeleteDriver(driver);
            driverService.SaveDriver();
            //db.Drivers.Remove(driver);
            //db.SaveChanges();

            return Ok(driver);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool DriverExists(int id)
        {
            return db.mt_driver.Count(e => e.Driver_id == id) > 0;
        }
    }
}