using AlifLesson23HW01._04.EFPersonDataContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlifLesson23HW01._04.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonController : BaseController
    {
        public PersonController(EFPersonContext eFPersonContext) : base(eFPersonContext)
        {
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _eFPersonContext.People.ToListAsync());
        }
    }
}
