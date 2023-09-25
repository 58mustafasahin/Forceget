using ForcegetWebApi.Business;
using ForcegetWebApi.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace ForcegetWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _orderService.GetOrderList();
            return Ok(result);
        }

        [HttpGet("getbyid")]
        public async Task<IActionResult> GetById([FromQuery] int id)
        {
            var result = await _orderService.GetOrderById(id);
            if (result.Id != 0)
                return Ok(result);
            return BadRequest();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddOrderDto addOrderDto)
        {
            var result = await _orderService.Add(addOrderDto);
            if (result > 0)
                return Ok("Successful operation");
            return BadRequest("Failed");
        }
    }
}
