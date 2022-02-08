using MVC_Asp_dot_Net_Feb_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Data.Interfaces
{
    public interface IProductRepo
    {
        void Create(Product input);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Update(Product input);
        void Delete(int id);
    }
}
