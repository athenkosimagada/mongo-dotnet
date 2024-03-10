using Mango.Website.Models;

namespace Mango.Website.Service.IService
{
    public interface ICartService
    {
        Task<ResponseDto?> GetCartBuUserIdAsync(string userId);
        Task<ResponseDto?> UpsertCartAsync(CartDto cartDto);
        Task<ResponseDto?> RemoveFromCartAsync(int cartDetailsId);
        Task<ResponseDto?> ApplyCouponAsync(CartDto cartDto);
    }
}
