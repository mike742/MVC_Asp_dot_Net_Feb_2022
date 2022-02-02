﻿using MVC_Asp_dot_Net_Feb_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Asp_dot_Net_Feb_2022.Data.Interfaces
{
    public interface IVendor
    {
        void Create(Vendor input);
        IEnumerable<Vendor> GetAll();
        Vendor GetById(int id);
        void Update(Vendor input);
        void Delete(int id);
    }
}
