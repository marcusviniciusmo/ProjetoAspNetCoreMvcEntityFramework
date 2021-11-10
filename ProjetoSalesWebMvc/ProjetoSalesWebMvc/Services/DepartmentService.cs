using ProjetoSalesWebMvc.Data;
using ProjetoSalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly ProjetoSalesWebMvcContext _context;

        public DepartmentService(ProjetoSalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
