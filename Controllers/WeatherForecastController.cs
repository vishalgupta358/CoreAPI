using Contract.Model;
using CoreAPI.FacadeLayer;
using CoreAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace CoreAPI.Controllers
{
    [ApiController]
    [ApiExplorerSettings(IgnoreApi =  false)]
    
    [Route("[controller]")]
   public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly Facade _facade = null;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, Facade facade)
        {
            _logger = logger;
            _facade = facade;
        }


        [HttpGet("GetUsers")]
        public IEnumerable<IUser> GetUsers()
        {
            return _facade.GetUsers();
        }

        [HttpGet]
        public IUser GetUser(int UserId)
        {
            return _facade.GetUser(UserId);
        }
         
        [HttpPost]
        public int CreateUser(User user)
        {
            return _facade.CreateUser(user);
        }
        
        [HttpDelete]
        public int DeleteUser(int UserId)
        {
            return _facade.DeleteUser(UserId);
        }


        [HttpPut]
        public int UpdateUser(User user)
        {
            return _facade.UpdateUser(user);
        }
    }
}
