using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TRMDataManager.Library.DataAccess;
using TRMDataManager.Library.Models;
using Microsoft.AspNet.Identity;

namespace TRMDataManager.Controllers
{
    [Authorize]
    [RoutePrefix("api/User")]
    public class UserController : ApiController
    {
        public List<UserModel> GetById()
        {
            var userId = RequestContext.Principal.Identity.GetUserId();

            UserData data = new UserData();

            return data.GetUserId(userId);
        }
    }
}
