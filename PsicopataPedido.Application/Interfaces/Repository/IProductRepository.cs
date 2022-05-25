﻿using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PsicopataPedido.Application.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        void discountProductStock(Product product, int count);
    }
}
