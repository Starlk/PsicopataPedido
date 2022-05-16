﻿using AutoMapper;
using PsicopataPedido.Application.Dtos;
using PsicopataPedido.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsicopataPedido.Application.Porfiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDto,Product>();
        }
    }
}
