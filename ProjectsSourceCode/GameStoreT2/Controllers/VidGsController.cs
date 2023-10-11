using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStoreT2.Models.DB;
using System.Net.Http;
using Microsoft.AspNetCore.Authorization;

namespace GameStoreT2.Controllers
{
    public class VidGsController : Controller
    {
        private readonly CCQ3_Team2_ProjectContext _context;

        public VidGsController(CCQ3_Team2_ProjectContext context)
        {
            _context = context;
        }

        // GET: VidGs
        [Authorize(Roles = "Admin,Normal")]//Ashav- roles as defined in the database
        public async Task<IActionResult> Index()
        {
            return View(await _context.VidGs.ToListAsync());
        }

        [Authorize(Roles = "Admin,Normal")]//Ashav- redirect method to the game checking view
        public async Task<IActionResult> CheckGame()
        {
            return View(await _context.VidGs.ToListAsync());
        }

        [Authorize(Roles = "Admin")]//Ashav- leads to google auth view, Role given admin because auth not properlly implememnted so not for users.
        public async Task<IActionResult> GoogleAuth()
        {
            return View(await _context.VidGs.ToListAsync());
        }

        // GET: VidGs/Details/5
        [Authorize(Roles = "Admin,Normal")]
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidG = await _context.VidGs
                .FirstOrDefaultAsync(m => m.VidKey == id);
            if (vidG == null)
            {
                return NotFound();
            }

            return View(vidG);
        }

        // GET: VidGs/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: VidGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VidKey,VideoGameName,Ratings,Developer,Price")] VidG vidG)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vidG);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vidG);
        }

        // GET: VidGs/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidG = await _context.VidGs.FindAsync(id);
            if (vidG == null)
            {
                return NotFound();
            }
            return View(vidG);
        }

        // POST: VidGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("VidKey,VideoGameName,Ratings,Developer,Price")] VidG vidG)
        {
            if (id != vidG.VidKey)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vidG);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VidGExists(vidG.VidKey))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(vidG);
        }

        // GET: VidGs/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vidG = await _context.VidGs
                .FirstOrDefaultAsync(m => m.VidKey == id);
            if (vidG == null)
            {
                return NotFound();
            }

            return View(vidG);
        }

        // POST: VidGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var vidG = await _context.VidGs.FindAsync(id);
            _context.VidGs.Remove(vidG);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VidGExists(string id)
        {
            return _context.VidGs.Any(e => e.VidKey == id);
        }



        [Authorize(Roles = "Admin,Normal")]
        [HttpGet]
        public IActionResult SearchRec()
        {
            return View();
        }
        // Ashav- search funcs to find a game in the database from data provided bu user.
        [HttpPost]
        public IActionResult SearchRec(string Vidgame)
        {
            ViewBag.temp = "value";
            VidG vg = new VidG();
            vg = _context.VidGs.Where(x => x.VideoGameName == Vidgame).FirstOrDefault();//Ashav- Useful entity f command found in previous course's db context file where used to search.
            return View(vg);
        }


        string strResult = "";
        string saveValue = "";
        [Authorize(Roles = "Admin,Normal")]
        [HttpPost]
        public async Task<string> checkNew()//Ashav- func to get the result from azure func http trigger
        {

            string newNum = "";
            string azureBaseUrl = "https://cc-as-trigger.azurewebsites.net/api/Function1?code=Tofz/js71LBxIAAl9rbE8XDYRk4RqD4Ko1sknpIhSc021hDy/x8aLw==";

            //http://localhost:7071/api/Function1

            HttpClient client = new();
            HttpResponseMessage response = await client.GetAsync($"{azureBaseUrl}");
            HttpContent content = response.Content;
            strResult = await content.ReadAsStringAsync();
            
            if (strResult != saveValue)
            {
                newNum = ("Yes a new game has been added today.");
                saveValue = strResult;
            }
            else

            {
                newNum = ("Sorry no new game has been added today.");

            }
            return newNum;
        }


    }
}
