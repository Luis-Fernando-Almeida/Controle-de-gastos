using ControleDeGastos.Models;
using ControleDeGastos.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeGastos.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }
        [HttpPost]
        public IActionResult Add(User newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Os dados do usuário não podem ser nulos.");
            }
            _userRepository.Add(newUser);
            return Ok();
        }
        [HttpGet]
        public IActionResult Get()
        {
            var user = _userRepository.Get();
            return Ok(user);
        }

    }
}
