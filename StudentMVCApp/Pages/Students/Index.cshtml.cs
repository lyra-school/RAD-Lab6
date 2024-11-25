using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentClassLibrary;
using StudentMVCApp.Data;

namespace StudentMVCApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly StudentMVCApp.Data.StudentMVCAppContext _context;

        public IndexModel(StudentMVCApp.Data.StudentMVCAppContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student.ToListAsync();
        }
    }
}
