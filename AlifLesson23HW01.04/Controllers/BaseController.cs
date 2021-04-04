using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using AlifLesson23HW01.Controllers;
using AlifLesson23HW01._04.EFPersonDataContext;
//using AlifLesson23HW01.EFPersonContext;

namespace AlifLesson23HW01._04.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected readonly EFPersonContext _eFPersonContext;
        public BaseController(EFPersonDataContext.EFPersonContext eFPersonContext)
        {

            _eFPersonContext = eFPersonContext;
        }

        //public EFPersonContext.EFPersonContext EFPersonContext { get; }
    }
}
