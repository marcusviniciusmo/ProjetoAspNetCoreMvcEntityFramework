using ProjetoSalesWebMvc.Data;
using ProjetoSalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoSalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesWebMvcContext _context;

        public DepartmentService(ProjetoSalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
