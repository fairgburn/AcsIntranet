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
    public class IndexModel : PageModel
    {
        private readonly AcsIntranet.Data.QuoteSystemContext _context;

        public IndexModel(AcsIntranet.Data.QuoteSystemContext context)
        {
            _context = context;
        }

        public IList<BlockModel> BlockModel { get;set; }

        public async Task OnGetAsync()
        {
            BlockModel = await _context.Blocks.ToListAsync();
        }
    }
}
