using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AcsIntranet.Data;
using AcsIntranet.Data.QuoteSystem;

namespace Intranet.Pages.QuoteSystem.BlockEntry
{
    public class DeleteModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public DeleteModel(AcsIntranet.Data.QuoteSystemContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Block = await _context.Blocks.FindAsync(id);

            if (Block != null)
            {
                _context.Blocks.Remove(Block);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
