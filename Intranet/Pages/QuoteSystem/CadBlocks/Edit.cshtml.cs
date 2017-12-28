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

namespace Intranet.Pages.QuoteSystem.CadBlocks
{
    public class EditModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public EditModel(AcsIntranet.Data.QuoteSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public BlockModel BlockModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlockModel = await _context.Blocks.SingleOrDefaultAsync(m => m.ID == id);

            if (BlockModel == null)
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

            _context.Attach(BlockModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BlockModelExists(BlockModel.ID))
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

        private bool BlockModelExists(int id)
        {
            return _context.Blocks.Any(e => e.ID == id);
        }
    }
}
