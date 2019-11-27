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
    public class DriverTeamsController : ApiController
    {
        private IDriverTeamsService driverTeamsService;
        public DriverTeamsController(IDriverTeamsService driverTeamsService)
        {
            this.driverTeamsService = driverTeamsService;
        }

        [HttpGet]
        [Route("teams")]
        public IEnumerable<DriverTeam> GetDriverTeams()
        {
            return driverTeamsService.GetDriverTeams().ToList();
        }

        [HttpGet]
        [Route("teams/{id}")]
        [ResponseType(typeof(DriverTeam))]
        public IHttpActionResult GetDriverTeams(int id)
        {
            DriverTeam driverTeam = driverTeamsService.GetDriverTeam(id);

            if (driverTeam == null)
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
                var message = string.Format("your search id is not availabe. try again with a valid driver team id.", id);
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }

            return Ok(driverTeam);
        }


        [NotImplExceptionFilter]
        [HttpPost]
        [Route("teams")]
        [ResponseType(typeof(DriverTeam))]
        public IHttpActionResult CreateDriverTeam(DriverTeam driverTeam)
        {
            if (!ModelState.IsValid)
            {
                //return BadRequest(ModelState);

                // exception handling using HttpError with HttpResponseException..
                var message = string.Format("please try again with valid properties");
                throw new HttpResponseException(
                    Request.CreateErrorResponse(HttpStatusCode.NotFound, message));

            }
            driverTeamsService.CreateDriverTeam(driverTeam);
            driverTeamsService.SaveDriverTeam();
            //db.Commit();

            return Created(new Uri(Request.RequestUri + "/" + driverTeam.Team_id), driverTeam);
        }


        [HttpPut]
        [Route("teams")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutDriverTeam(int id, DriverTeam driverTeam)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //db.Entry(driver).State = EntityState.Modified;
            driverTeam.Team_id = id;
            string msg = driverTeamsService.PutDriverTeam(driverTeam);
            driverTeamsService.SaveDriverTeam();
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
        [Route("teams")]
        [ResponseType(typeof(DriverTeam))]
        public IHttpActionResult DeleteDriverTeam(int id)
        {
            DriverTeam driverTeam = driverTeamsService.GetDriverTeam(id);
            if (driverTeam == null)
            {
                return NotFound();
            }

            driverTeamsService.DeleteDriverTeam(driverTeam);
            driverTeamsService.SaveDriverTeam();
            
            return Ok(driverTeam);
        }
    }
}
