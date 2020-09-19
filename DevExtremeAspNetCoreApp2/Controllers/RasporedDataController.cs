using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using DevExtremeAspNetCoreApp1.Models;

namespace DevExtremeAspNetCoreApp2.Controllers {

    [Route("api/[controller]")]
    public class RasporedDataController : Controller {

        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(RasporediData.Rasporedi, loadOptions);
        }

    }
}