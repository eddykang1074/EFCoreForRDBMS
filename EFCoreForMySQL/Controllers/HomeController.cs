using System.Diagnostics;
using EFCoreForMySQL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreForMySQL.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ChatAppDbContext _db;



        public HomeController(ChatAppDbContext context, ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = context;
        }

        public async Task<IActionResult> Index()
        {
            Channel channel = new Channel() { ChannelName = "»ùÇÃÃ¤³Î1", ChannelTypeCode = 1, LimitCnt = 100, StateCode = 1, RegistMemberIdx = 1, RegistDate = DateTime.Now };
            var registedChannel = await _db.Channels.AddAsync(channel);
            await _db.SaveChangesAsync();


            var channels = await _db.Channels.ToListAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
