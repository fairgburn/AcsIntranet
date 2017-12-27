using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AcsIntranet.Data;
using AcsIntranet.Data.QuoteSystem;

namespace Intranet.Pages.QuoteSystem.BlockEntry
{
    public class EditModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public EditModel(AcsIntranet.Data.QuoteSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Block Block { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Block = await _context.Blocks.SingleOrDefaultAsync(m => m.BlockName == id);

            if (Block == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Block).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlockExists(Block.BlockName))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool BlockExists(string id)
        {
            return _context.Blocks.Any(e => e.BlockName == id);
        }
    }
}
