using Trotels.BL.Abstract;
using Trotels.BL.Concrete;
using Trotels.DAL.Repository.Abstract;
using Trotels.DAL.Repository.Concrete;

namespace Trotels.WebMVC.Extensions
{
    public static class AddTrotelsService
    {
        public static IServiceCollection AddTrotelsServices(this IServiceCollection services)
        {
            services.AddScoped<IGuestRepository, GuestRepository>();
            services.AddScoped<IGuestManager, GuestManager>();

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeManager, EmployeeManager>();

            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IBookingManager, BookingManager>();

            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IHotelManager, HotelManager>();

            services.AddScoped<IRoomRepository, RoomRepository>();
            services.AddScoped<IRoomManager, RoomManager>();

            return services;
        }   
    }
}
