using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student___CRUD.Data;
using Student___CRUD.Models;

namespace Student___CRUD.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Student___CRUD.Data.Student___CRUDContext _context;

        public IndexModel(Student___CRUD.Data.Student___CRUDContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
