using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Areas.Identity.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class ItemsController : Controller
    {
        private readonly ArtEquipmentContext _context;
        private readonly IWebHostEnvironment _hostenv;

        public ItemsController(ArtEquipmentContext context, IWebHostEnvironment hostenv)
        {
            _context = context;
            _hostenv = hostenv;
        }

        // GET: Items
        public async Task<IActionResult> Index()
        {
            return View(await _context.Item.ToListAsync());
        }

        // GET: Items/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // GET: Items/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ItemID,ItemName,Attachment,Category")] Item item)
        {
            if (ModelState.IsValid)
            {
                string img = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                img += Path.GetExtension(item.Attachment!.FileName);

                string imgpath = _hostenv.WebRootPath + "/img/" + img;
                using (var stream = System.IO.File.Create(imgpath))
                {
                    item.Attachment.CopyTo(stream);
                }

                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(item);
        }

        // GET: Items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item.FindAsync(id);
            if (item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ItemID,ItemName,Attachment,Category")] Item item)
        {
            if (id != item.ItemID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string img = item.ItemName;
                    if (item.Attachment != null)
                    {
                        img = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                        img += Path.GetExtension(item.Attachment.FileName);

                        string imgpath = _hostenv.WebRootPath + "/img/" + img;
                        using(var stream = System.IO.File.Create(img))
                        {
                            item.Attachment.CopyTo(stream);
                        }
                    }

                    string oldimgpath = _hostenv.WebRootPath + "/img/" + item.ItemName;
                    System.IO.File.Delete(oldimgpath);


                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ItemID))
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
            return View(item);
        }

        // GET: Items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var item = await _context.Item
                .FirstOrDefaultAsync(m => m.ItemID == id);
            if (item == null)
            {
                return NotFound();
            }

            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var item = await _context.Item.FindAsync(id);

            string imgpath = _hostenv.WebRootPath + "/img/" + item.ItemName;
            System.IO.File.Delete(imgpath);

            if (item != null)
            {
                _context.Item.Remove(item);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ItemExists(int id)
        {
            return _context.Item.Any(e => e.ItemID == id);
        }
    }
}
