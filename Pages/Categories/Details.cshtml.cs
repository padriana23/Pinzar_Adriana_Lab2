using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Pinzar_Adriana_Lab2.Data;
using Pinzar_Adriana_Lab2.Models;

namespace Pinzar_Adriana_Lab2.Pages.Categories
{
    public class DetailsModel : PageModel
    {
        private readonly Pinzar_Adriana_Lab2.Data.Pinzar_Adriana_Lab2Context _context;

        public DetailsModel(Pinzar_Adriana_Lab2.Data.Pinzar_Adriana_Lab2Context context)
        {
            _context = context;
        }

      public Category Category { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Category == null)
            {
                return NotFound();
            }

            var category = await _context.Category.FirstOrDefaultAsync(m => m.ID == id);
            if (category == null)
            {
                return NotFound();
            }
            else 
            {
                Category = category;
            }
            return Page();
        }
    }
}
