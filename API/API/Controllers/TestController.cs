using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [RoutePrefix("api/test")]
    public class TestController : ApiController
    {
        public IHttpActionResult Get()
        {
            /*try
            {*/
                var testString = "This is a test of the API";

                return Ok(testString);
            /*}
            catch (Exception exc)
            {
                return InternalServerError(exc);
            }*/
        }

        public IHttpActionResult Get(int id)
        {
            try
            {
                var testString = "This is a test of the API which passes in an ID of: " + id;

                return Ok(testString);
            }
            catch (Exception exc)
            {
                return InternalServerError(exc);
            }
        }
    }
}
