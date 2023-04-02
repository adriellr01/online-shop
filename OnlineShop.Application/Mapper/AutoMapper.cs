using AutoMapper;
using OnlineShop.Application.ShoppingCarts.Dto;
using OnlineShop.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Mapper
{
    public class AutoMapper : Profile
    {
        public AutoMapper() 
        {
            CreateMap<ShoppingCart, ShoppingCartDto>().ReverseMap();
            //CreateMap<ShoppingCartDto, ShoppingCart>();
        }
    }
}
