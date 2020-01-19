using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace bootstrap_sb_admin_2_aspnet_core.Controllers
{
    [Authorize]
    public abstract class BaseController : Controller
    {
        //abstruct class//
    }
}