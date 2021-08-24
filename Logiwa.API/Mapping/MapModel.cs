using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logiwa.API.DTOs;
using Logiwa.Core.Models;

namespace Logiwa.API.Mapping
{
 
    public class MapModel : Profile
    {
        public MapModel()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();


            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();


        }
    }
}
