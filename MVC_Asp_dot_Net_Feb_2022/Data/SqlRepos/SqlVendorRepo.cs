using MVC_Asp_dot_Net_Feb_2022.Data.Interfaces;
using MVC_Asp_dot_Net_Feb_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Data.SqlRepos
{
    public class SqlVendorRepo : IVendorRepo
    {
        private readonly AppDbContext _context;

        public SqlVendorRepo(AppDbContext context)
        {
            _context = context;
        }

        public void Create(Vendor input)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors;
        }

        public Vendor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Vendor input)
        {
            throw new NotImplementedException();
        }
    }
}
