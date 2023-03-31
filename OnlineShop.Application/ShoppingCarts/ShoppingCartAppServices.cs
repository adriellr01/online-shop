using AutoMapper;
using OnlineShop.Application.ShoppingCarts.Dto;
using OnlineShop.Application.ShoppingCarts.Interfaces;
using OnlineShop.Core.Entities;
using OnlineShop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.ShoppingCarts
{
    public class ShoppingCartAppServices : IShoppingCartAppServices
    {
        private readonly IShoppingCartRepository _shoppingCartRepository;
        private readonly IMapper _mapper;

        public ShoppingCartAppServices(IShoppingCartRepository shoppingCartRepository, IMapper mapper ) 
        {
            _shoppingCartRepository = shoppingCartRepository;
            _mapper = mapper;
        }
        

        public async Task Create(ShoppingCartDto shoppingCartDto)
        {
           await _shoppingCartRepository.Create(_mapper.Map<ShoppingCart>(shoppingCartDto));
        }

        public async Task<bool> Delete(long id)
        {
           return await _shoppingCartRepository.Delete(id);
        }

        public async Task<IEnumerable<ShoppingCartDto>> GetAll()
        {
            var shoppingCarts = await _shoppingCartRepository.GetAll();
           /* var resultListDtos = new List<ShoppingCartDto>();
            foreach (var item in shoppingCarts)
            {
                resultListDtos.Add(_mapper.Map<ShoppingCartDto>(shoppingCarts));
            }*/
            return _mapper.Map<List<ShoppingCartDto>>(shoppingCarts);
        }

        public async Task<ShoppingCartDto> GetById(long id)
        {
           var result = await _shoppingCartRepository.GetById(id);
            return _mapper.Map<ShoppingCartDto>(result);
        }

        public async Task<bool> Update(ShoppingCartDto shoppingCartDto)
        {
            return await _shoppingCartRepository.Update(_mapper.Map<ShoppingCart>(shoppingCartDto));
        }
    }
}
