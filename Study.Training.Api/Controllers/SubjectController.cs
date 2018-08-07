using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Study.Training.Application.ApplicationServices.Interface;
using Study.Training.Message.Messages;
using Study.Training.Message.Operations;
using Study.Training.Model.Filters;

namespace Study.Training.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/subject")]
    public class SubjectController : Controller
    {
        private ISubjectApplication application = null;

        public SubjectController(ISubjectApplication application)
        {
            this.application = application;
        }

        
        [HttpGet]
        public PageOperationResponse<SubjectMessage> Get(SubjectFilter filter)
        {
            return this.application.Read(filter);
        }
        
        // POST: api/Subject
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }
        
        // PUT: api/Subject/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
