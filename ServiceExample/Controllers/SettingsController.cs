using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace ServiceExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SettingsController : ControllerBase
    {
        private readonly IConfiguration _config;
        private readonly SomeDbContext _dbContext;

        public SettingsController(IConfiguration config, SomeDbContext dbContext)
        {
            _config = config;
            _dbContext = dbContext;
        }

        [HttpGet("getkey/{key}")]
        public string Get(string key)
        {
            return _config[key];
        }

        [HttpGet("getconnectionstring")]
        public string GetConnectionString()
        {
            return _dbContext.Database.GetDbConnection().ConnectionString;
        }

        [HttpGet("getconfig")]
        public string GetConfig()
        {
            return JsonConvert.SerializeObject(_config);
        }
    }
}
