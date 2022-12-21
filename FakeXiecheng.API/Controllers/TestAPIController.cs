using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FakeXiecheng.API.Controllers
{
    // #region 方式一 class+Controller
    // ///api/Testapi
    // [Route("api/[controller]")]
    // public class TestAPIController 
    // {
    //     [HttpGet]
    //     public IEnumerable<string> Get()
    //     {
    //         return new string[] {"value1", "value2"};
    //     }
    // }
    //
    //
    //         #endregion

    #region 方式二 增加[ApiController]

    ///api/Testapi

    // [Route("api/TestAPI")]
    // [ApiController]
    // public class TestAPI
    // {
    //     [HttpGet]
    //     public IEnumerable<string> Get()
    //     {
    //         return new string[] {"value1", "value2"};
    //     }
    // }

    #endregion 繼承Controller

    #region MyRegion

    [Route("api/TestAPI")]
    public class TestAPI : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"value1", "value2"};
        }
    }

    #endregion
}