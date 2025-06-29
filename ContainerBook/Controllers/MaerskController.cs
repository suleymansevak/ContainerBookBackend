
using ContainerBook.Core.Entities;
using ContainerBook.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ContainerBook.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MaerskController : Controller
    {
        private readonly IMaerskService _maerskService;
        public MaerskController(IMaerskService maerskService)
        {
            _maerskService = maerskService;
        }

        [HttpPost("GetTable")]
        public async Task<BaseResponse<MaerskResponse>> GetTable(MaerskRequest request) =>
             await _maerskService.GetTable(request);
    }
}

