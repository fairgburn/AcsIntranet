using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AcsIntranet.Data;
using AcsIntranet.Data.QuoteSystem;

namespace Intranet.Pages.QuoteSystem.CadBlocks
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
        public BlockModel BlockModel { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            BlockModel.Date = DateTime.Now;

            _context.Blocks.Add(BlockModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}