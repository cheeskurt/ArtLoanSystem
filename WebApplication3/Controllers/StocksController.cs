
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Areas.Identity.Data;

public class StocksController : Controller
{
    private readonly ArtEquipmentContext _context;

    public StocksController(ArtEquipmentContext context)
    {
        _context = context;
    }

    // GET: STOCKS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Stock.ToListAsync());
    }

    // GET: STOCKS/Details/5
    public async Task<IActionResult> Details(int? stockid)
    {
        if (stockid == null)
        {
            return NotFound();
        }

        var stock = await _context.Stock
            .FirstOrDefaultAsync(m => m.StockID == stockid);
        if (stock == null)
        {
            return NotFound();
        }

        return View(stock);
    }

    // GET: STOCKS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: STOCKS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("StockID,ItemID,StockTag,Item,ItemIssues")] Stock stock)
    {
        if (ModelState.IsValid)
        {
            _context.Add(stock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(stock);
    }

    // GET: STOCKS/Edit/5
    public async Task<IActionResult> Edit(int? stockid)
    {
        if (stockid == null)
        {
            return NotFound();
        }

        var stock = await _context.Stock.FindAsync(stockid);
        if (stock == null)
        {
            return NotFound();
        }
        return View(stock);
    }

    // POST: STOCKS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? stockid, [Bind("StockID,ItemID,StockTag,Item,ItemIssues")] Stock stock)
    {
        if (stockid != stock.StockID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(stock);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockExists(stock.StockID))
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
        return View(stock);
    }

    // GET: STOCKS/Delete/5
    public async Task<IActionResult> Delete(int? stockid)
    {
        if (stockid == null)
        {
            return NotFound();
        }

        var stock = await _context.Stock
            .FirstOrDefaultAsync(m => m.StockID == stockid);
        if (stock == null)
        {
            return NotFound();
        }

        return View(stock);
    }

    // POST: STOCKS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? stockid)
    {
        var stock = await _context.Stock.FindAsync(stockid);
        if (stock != null)
        {
            _context.Stock.Remove(stock);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool StockExists(int? stockid)
    {
        return _context.Stock.Any(e => e.StockID == stockid);
    }
}
