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
    public class IndexModel : PageModel
    {
        private readonly BuildForConnorT.Data.BuildForConnorTContext _context;

        public IndexModel(BuildForConnorT.Data.BuildForConnorTContext context)
        {
            _context = context;
        }

        public IList<ItemModel> ItemModel { get;set; }

        public async Task OnGetAsync()
        {
            ItemModel = await _context.ItemModel.ToListAsync();
        }
    }
}
