namespace Rcon.Api.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Rcon.Core;
    using Rcon.Core.Entities;

    [ApiController]
    [Route("[controller]")]
    public class ExampleController : ControllerBase
    {
        private readonly IUnitOfWork context;

        public ExampleController(IUnitOfWork _unitOfWork)
        {
            this.context = _unitOfWork;
        }

        [HttpGet("{_id}")]
        public async Task<Example> Get(int _id)
        {
            var example = await context.ExampleRepository.GetAsync(_id.ToString());

            return example;
        }
    }
}
