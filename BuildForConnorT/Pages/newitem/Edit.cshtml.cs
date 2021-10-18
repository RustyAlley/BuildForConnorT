using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuildForConnorT.Data;
using BuildForConnorT.Models;

namespace BuildForConnorT.Pages.newitem
{
    public class EditModel : PageModel
    {
        private readonly BuildForConnorT.Data.BuildForConnorTContext _context;

        public EditModel(BuildForConnorT.Data.BuildForConnorTContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ItemModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemModelExists(ItemModel.ID))
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

        private bool ItemModelExists(int id)
        {
            return _context.ItemModel.Any(e => e.ID == id);
        }
    }
}
