using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuildForConnorT.Data;
using BuildForConnorT.Models;

namespace BuildForConnorT.Pages.newitem
{
    public class DetailsModel : PageModel
    {
        private readonly BuildForConnorT.Data.BuildForConnorTContext _context;

        public DetailsModel(BuildForConnorT.Data.BuildForConnorTContext context)
        {
            _context = context;
        }

        public ItemModel ItemModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ItemModel = await _context.ItemModel.FirstOrDefaultAsync(m => m.ID == id);

            if (ItemModel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
