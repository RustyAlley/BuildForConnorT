using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BuildForConnorT.Data;
using BuildForConnorT.Models;

namespace BuildForConnorT.Pages.newitem
{
    public class CreateModel : PageModel
    {
        private readonly BuildForConnorT.Data.BuildForConnorTContext _context;

        public CreateModel(BuildForConnorT.Data.BuildForConnorTContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ItemModel ItemModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ItemModel.Add(ItemModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
