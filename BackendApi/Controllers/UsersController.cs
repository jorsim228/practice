using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Online_shop_database.Models;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        public PracticeShop100423Context Context { get; }

        public UsersController(PracticeShop100423Context context)
        {
            Context = context;
        }


    }
}
