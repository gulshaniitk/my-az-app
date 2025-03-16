using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using my_az_app.Data;

namespace my_az_app.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly my_az_app.Data.AppDbContext _context;

        public IndexModel(my_az_app.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
