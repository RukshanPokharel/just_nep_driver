using DriverApplication.Filters;
using DriverApplication.Models;
using DriverApplication.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DriverApplication.Controllers.APIs
{
    public class DriverAssignmentsController : ApiController
    {
        private IDriverAssignmentService driverAssignmentService;
        public DriverAssignmentsController(IDriverAssignmentService driverAssignmentService)
        {
            this.driverAssignmentService = driverAssignmentService;
        }

        [HttpGet]
        [Route("assignment")]
        public IEnumerable<DriverAssignment> GetDriverAssignments()
        {
            return driverAssignmentService.GetDriverAssignments().ToList();
        }

        [HttpGet]
        [Route("assignment/{id}")]
        [ResponseType(typeof(DriverAssignment))]
        public IHttpActionResult GetDriverAssignment(int id)
        {
            DriverAssignment driverAssignment = driverAssignmentService.GetDriverAssignment(id);

            if (driverAssignment == null)
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
                var message = string.Format("your search id is not availabe. try again with a valid driver assignment id.", id);
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }

            return Ok(driverAssignment);
        }

        [NotImplExceptionFilter]
        [HttpPost]
        [Route("assignment")]
        [ResponseType(typeof(DriverAssignment))]
        public IHttpActionResult CreateDriverAssignment(DriverAssignment driverAssignment)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);

                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("please try again with valid properties");
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }
            driverAssignmentService.CreateDriverAssignment(driverAssignment);
            driverAssignmentService.SaveDriverAssignment();
            //db.Commit();

            return Created(new Uri(Request.RequestUri + "/" + driverAssignment.Assignment_id), driverAssignment);
        }

        [HttpPut]
        [Route("assignment")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDriverAssignment(int id, DriverAssignment driverAssignment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Entry(driver).State = EntityState.Modified;
            driverAssignment.Assignment_id = id;
            string msg = driverAssignmentService.PutDriverAssignment(driverAssignment);
            driverAssignmentService.SaveDriverAssignment();
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

        [HttpDelete]
        [Route("assignment")]
        [ResponseType(typeof(DriverAssignment))]
        public IHttpActionResult DeleteDriverAssignment(int id)
        {
            DriverAssignment driverAssignment = driverAssignmentService.GetDriverAssignment(id);
            if (driverAssignment == null)
            {
                return NotFound();
            }

            driverAssignmentService.DeleteDriverAssignment(driverAssignment);
            driverAssignmentService.SaveDriverAssignment();
            
            return Ok(driverAssignment);
        }
    }
}
