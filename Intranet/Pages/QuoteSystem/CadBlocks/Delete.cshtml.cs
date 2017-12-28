using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcsIntranet.Data;
using AcsIntranet.Data.QuoteSystem;

namespace Intranet.Pages.QuoteSystem.CadBlocks
{
    public class DeleteModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public DeleteModel(AcsIntranet.Data.QuoteSystemContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            BlockModel = await _context.Blocks.FindAsync(id);

            if (BlockModel != null)
            {
                _context.Blocks.Remove(BlockModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
