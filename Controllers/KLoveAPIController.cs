using System;
using System.Threading.Tasks;
using FavoriteVerse.Services.KLoveAPIService;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteVerse.Controllers
{
    [ApiController]
    [Route("k-love")]
    public class KLoveAPIController : ControllerBase
    {
        private readonly IKLoveAPIService _kLoveAPIService;
        public KLoveAPIController(IKLoveAPIService kLoveService)
        {
            _kLoveAPIService = kLoveService;
        }

        [Route("verses")]
        public async Task<IActionResult> Get(DateTime startdate, int PageSize){
            return Ok(await _kLoveAPIService.GetVerseByDate(startdate, PageSize));
        }
    }
}