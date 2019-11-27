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
    public class DriverTasksController : ApiController
    {
        private IDriverTasksService driverTaskService;
        public DriverTasksController(IDriverTasksService driverTaskService)
        {
            this.driverTaskService = driverTaskService;
        }

        // GET all driverTasks.
        [HttpGet]
        [Route("tasks")]
        public IEnumerable<DriverTask> GetDriverTasks()
        {
            return driverTaskService.GetDriverTasks().ToList();
        }


        // GET: api/DriverTask/5
        [HttpGet]
        [Route("tasks/{id}")]
        [ResponseType(typeof(DriverTask))]
        public IHttpActionResult GetDriverTask(int id)
        {
            DriverTask driverTask = driverTaskService.GetDriverTask(id);

            if (driverTask == null)
            {
                //return NotFound();

                // exception handling using HttpResponseException..
                //var msg = new HttpResponseMessage(HttpStatusCode.NotFound)
                //{
                //    Content = new StringContent(string.Format("your search id is not availabe. try again with a valid driver task id.")),
                //    ReasonPhrase = "DriverTask not found"
                //};

                //throw new HttpResponseException(msg);


                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("your search id is not availabe. try again with a valid driver task id.", id);
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }

            return Ok(driverTask);
        }

        // POST: api/DriversTask
        [NotImplExceptionFilter]
        [HttpPost]
        [Route("tasks")]
        [ResponseType(typeof(DriverTask))]
        public IHttpActionResult CreateDriverTask(DriverTask driverTask)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);

                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("please try again with valid properties");
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }
            driverTaskService.CreateDriverTask(driverTask);
            driverTaskService.SaveDriverTask();
            //db.Commit();

            return Created(new Uri(Request.RequestUri + "/" + driverTask.Driver_id), driverTask);
        }

        [HttpPut]
        [Route("tasks")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDriverTask(int id, DriverTask driverTask)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Entry(driver).State = EntityState.Modified;
            driverTask.Task_id = id;
            string msg = driverTaskService.PutDriverTask(driverTask);
            driverTaskService.SaveDriverTask();
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
        [Route("tasks")]
        [ResponseType(typeof(DriverTask))]
        public IHttpActionResult DeleteDriverTask(int id)
        {
            DriverTask driverTask = driverTaskService.GetDriverTask(id);
            if (driverTask == null)
            {
                return NotFound();
            }

            driverTaskService.DeleteDriverTask(driverTask);
            driverTaskService.SaveDriverTask();
            //db.Drivers.Remove(driver);
            //db.SaveChanges();

            return Ok(driverTask);
        }
    }
}
