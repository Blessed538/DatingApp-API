namespace DatingApp.API.Controllers
{

 [Authorize]
 [Route("api/conroller")]
 [ApiController]
  public class UserController : ControllerBase
   {

     private readonly IDatingRepository _repo;

     public UserController(IDatingRepository repo)
     {
         _repo = repo;
     }

     [HttpGet]
     public async Task<IActionResult> GetUsers()
     {
         var users = await _repo.GetUsers();
         return Ok(users);
     }

     [HttpGet("{id")]

     public async Task<IActionResult> GetUser(int id)
     {
         var user = await _repo.GetUser(id);
         return Ok(user);
     }
        }
    }
 