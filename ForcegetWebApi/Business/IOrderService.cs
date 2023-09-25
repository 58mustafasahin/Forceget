using ForcegetWebApi.Dtos;

namespace ForcegetWebApi.Business
{
    public interface IOrderService
    {
        Task<List<GetOrderDto>> GetOrderList();
        Task<GetOrderDto> GetOrderById(int orderId);
        Task<int> Add(AddOrderDto addOrderDto);
    }
}
