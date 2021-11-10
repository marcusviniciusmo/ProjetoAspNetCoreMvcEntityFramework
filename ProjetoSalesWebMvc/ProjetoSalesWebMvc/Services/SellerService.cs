using ProjetoSalesWebMvc.Data;
using ProjetoSalesWebMvc.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoSalesWebMvc.Services
{
    public class SellerService
    {
        private readonly ProjetoSalesWebMvcContext _context;

        public SellerService(ProjetoSalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
