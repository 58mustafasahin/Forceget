using ForcegetWebApi.Dataaccess;
using ForcegetWebApi.Dtos;
using ForcegetWebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace ForcegetWebApi.Business
{
    public class OrderService : IOrderService
    {
        private readonly ForcegetDbContext _dbContext;

        public OrderService(ForcegetDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> Add(AddOrderDto addOrderDto)
        {
            var newOrder = new Order
            {
                CityId = addOrderDto.CityId,
                Currency = addOrderDto.Currency,
                Incoterm = addOrderDto.Incoterm,
                Mode = addOrderDto.Mode,
                MovementType = addOrderDto.MovementType,
                PackageType = addOrderDto.PackageType,
                Unit1 = addOrderDto.Unit1,
                Unit2 = addOrderDto.Unit2,
            };
            _dbContext.Orders.Add(newOrder);
            var result = await _dbContext.SaveChangesAsync();
            return result;
        }

        public async Task<GetOrderDto> GetOrderById(int orderId)
        {
            var order = await _dbContext.Orders.Include(o => o.City).Where(o => o.Id == orderId).FirstOrDefaultAsync();
            if (order == null) return new GetOrderDto();
            return new GetOrderDto
            {
                Id = order.Id,
                CityId = order.CityId,
                CityName = order.City.Name,
                Currency = order.Currency,
                Incoterm = order.Incoterm,
                Mode = order.Mode,
                MovementType = order.MovementType,
                PackageType = order.PackageType,
                Unit1 = order.Unit1,
                Unit2 = order.Unit2,
            };
        }

        public async Task<List<GetOrderDto>> GetOrderList()
        {
            return await _dbContext.Orders.Select(o => new GetOrderDto
            {
                Id = o.Id,
                CityId = o.CityId,
                Currency = o.Currency,
                Incoterm = o.Incoterm,
                Mode = o.Mode,
                MovementType = o.MovementType,
                PackageType = o.PackageType,
                Unit1 = o.Unit1,
                Unit2 = o.Unit2,
            }).ToListAsync();
        }
    }
}
