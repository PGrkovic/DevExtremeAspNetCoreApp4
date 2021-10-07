using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;

using DevExtremeAspNetCoreApp4.Models;
using DevExtremeAspNetCoreApp4.Models.Gantt;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DevExtremeAspNetCoreApp4.Controllers
{

    [Route("api/[controller]")]
    public class GanttController : Controller {

        [HttpGet]
        public async Task<IEnumerable<GanttTask>> Get(DataSourceLoadOptions loadOptions) {
            Thread.Sleep(15000);
            return (IEnumerable<GanttTask>)DataSourceLoader.Load(SampleData.GanttTasks, loadOptions);
        }
    }
}