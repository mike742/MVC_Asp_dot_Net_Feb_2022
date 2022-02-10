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
            _context.Vendors.Add(input);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var vendorToDelete = _context.Vendors.FirstOrDefault(v => v.V_code == id);

            if (vendorToDelete != null)
            {
                _context.Remove(vendorToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Vendor> GetAll()
        {
            return _context.Vendors;
        }

        public Vendor GetById(int id)
        {
            return _context.Vendors.FirstOrDefault(v => v.V_code == id);
        }

        public void Update(int id, Vendor input)
        {
            var vendorInDb = _context.Vendors.FirstOrDefault(v => v.V_code == id);

            if (vendorInDb != null)
            {
                vendorInDb.V_AreaCode = input.V_AreaCode;
                vendorInDb.V_contact = input.V_contact;
                vendorInDb.V_name = input.V_name;
                vendorInDb.V_order = input.V_order;
                vendorInDb.V_phone = input.V_phone;
                vendorInDb.V_state = input.V_state;

                _context.SaveChanges();
            }
        }
    }
}
