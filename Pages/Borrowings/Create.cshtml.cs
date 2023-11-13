﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pinzar_Adriana_Lab2.Data;
using Pinzar_Adriana_Lab2.Models;

namespace Pinzar_Adriana_Lab2.Pages.Borrowings
{
    public class CreateModel : PageModel
    {
        private readonly Pinzar_Adriana_Lab2.Data.Pinzar_Adriana_Lab2Context _context;

        public CreateModel(Pinzar_Adriana_Lab2.Data.Pinzar_Adriana_Lab2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
           
            {
                var bookList = _context.Book
                .Include(b => b.Author)
                .Select(x => new
                {
                    x.ID,
                    BookFullName = x.Title + " - " + x.Author.LastName + " " +
               x.Author.FirstName
                });
                ViewData["BookID"] = new SelectList(bookList, "ID","BookFullName");
                ViewData["MemberID"] = new SelectList(_context.Member, "ID", "FullName");
                return Page();
            }
        }

        } } 
