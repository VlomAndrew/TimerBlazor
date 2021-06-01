using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebClient.Server.Controllers
{
    [Authorize]
    [ApiController]
    public class BaseController : ControllerBase
    {
        //    public Task<IActionResult> MainAction(Func<Task<IActionResult> _task)
        //    {
        //        IActionResult result;
        //        try
        //        {
        //             result = _task.Invoke();
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e);
        //        }

        //        return result;
        //    }
    }
}
