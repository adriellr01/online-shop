using OnlineShop.Application.Shops.Dto;
using OnlineShop.Core.Repositories;

namespace OnlineShop.Application.Shops
{
    public class ShopAppService
    {
        private readonly IShopRepository _shopRepository;

        public ShopAppService(IShopRepository shopRepository)
        {
            _shopRepository = shopRepository;
        }

        public List<ShopDto> GetAll()
        {
            var shops = _shopRepository.GetAll();
            var shopsDto = new List<ShopDto>();

            foreach (var shop in shops)
            {
                var shopDto = new ShopDto
                {
                    Id = shop.Id,
                    Name = shop.Name,
                    BusinessName = shop.BusinessName
                };

                shopsDto.Add(shopDto);
            }

            return shopsDto;
        }
    }
}
