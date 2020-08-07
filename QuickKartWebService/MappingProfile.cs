using AutoMapper;
using QuickKartDataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickKartWebService
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Products, Models.Product>();
            CreateMap<Models.Product, Products>();
            CreateMap<Categories, Models.Category>();
            CreateMap<Models.Category, Categories>();
        }
    }
}
