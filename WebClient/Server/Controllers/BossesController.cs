using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebClient.Server.Data;
using WebClient.Server.Models;
using WebClient.Shared.AuxClasses;
using WebClient.Shared.Models;

namespace WebClient.Server.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BossesController : ControllerBase
    {
        private IOptions<AppSettingsModel> _settings;
        private ApplicationDbContext _dbContext;

        public BossesController(ApplicationDbContext dbContext, IOptions<AppSettingsModel> settings)
        {
            _dbContext = dbContext;
            _settings = settings;
        }
        // GET: BossesController

        
        [HttpGet]
        public IEnumerable<BossDetailsModel> GetList()
        {
            
            var res = from boss in _dbContext.Monsters
                select new BossDetailsModel()
                {
                    Id = boss.Id,
                    Name = boss.Name,
                    TimeSpawn = boss.TimeSpawn.ToString(_settings.Value.TimeFormat)
                };
            return res;
        }

        [HttpPost]
        public void Create([FromBody] CreateBossModel model)
        {
            if (ModelState.IsValid)
            {
                TimeSpan obj;
                TimeSpan.TryParse(model.TimeSpawn,out obj);
                var newBoss = new MonsterData(model.Name, obj,model.LogoImage,model.Color);
                _dbContext.Monsters.Add(newBoss);
                _dbContext.SaveChangesAsync().GetAwaiter().GetResult();
                var monster = _dbContext.Monsters.Find(newBoss);
                var server = _dbContext.Servers.Find(model.Server);
                var newServerBoss = new ServerMonster() {Monster = monster, Server = server};
                _dbContext.ServerMonster.Add(newServerBoss);
                _dbContext.SaveChangesAsync().GetAwaiter().GetResult();
                var serverMonster = _dbContext.ServerMonster.Find(newServerBoss);
                var hist = new MonsterHistoryData(model.HistoryAction.Comment)
                {
                    ActionLastDate = DateTime.Now, ServerMonster = serverMonster,
                    UserName = model.HistoryAction.UserName, Action = model.HistoryAction.Action
                };
                _dbContext.History.Add(hist);
                _dbContext.SaveChangesAsync().GetAwaiter().GetResult();
            }
        }
        //// GET: BossesController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: BossesController/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: BossesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: BossesController/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: BossesController/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: BossesController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: BossesController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
