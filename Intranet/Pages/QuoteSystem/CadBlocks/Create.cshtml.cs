using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AcsIntranet.Data;
using AcsIntranet.Data.QuoteSystem;

namespace Intranet.Pages.QuoteSystem.BlockEntry
{
    public class CreateModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public CreateModel(AcsIntranet.Data.QuoteSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Block Block { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Block.Date = DateTime.Now;

            _context.Blocks.Add(Block);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}