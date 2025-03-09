using Mango.Web.Models;


namespace Mango.Web.Service.IService
{
  public interface ICouponService{
    Task<ResponseDto?> GetCouponAsync(string CouponCode);
    Task<ResponseDto?> GetAllCouponsAsync();
    Task<ResponseDto?> GetCouponByIdAsync(int id);
    Task<ResponseDto?> UpdateCouponAsync(CouponDto couponDto);
    Task<ResponseDto?> DeleteCouponAsync(int id);
    Task<ResponseDto?> CreateCouponAsync(CouponDto couponDto);
  }
}