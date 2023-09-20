using Hotel_Booking_System.Data;
using Microsoft.EntityFrameworkCore;
using System;

namespace Hotel_Booking_System
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            string connectionString = Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");

            string serverName = Environment.GetEnvironmentVariable("AZURE_SQL_SERVER_NAME");
            string dbName = Environment.GetEnvironmentVariable("AZURE_SQL_DB_NAME");
            string userId = Environment.GetEnvironmentVariable("AZURE_SQL_USER_ID");
            string password = Environment.GetEnvironmentVariable("AZURE_SQL_PASSWORD");

            connectionString = connectionString.Replace("{ServerName}", serverName)
                                                .Replace("{DbName}", dbName)
                                                .Replace("{UserId}", userId)
                                                .Replace("{Password}", password);

            services.AddDbContext<DataContext>(options =>
                options.UseSqlServer(connectionString));
        }
    }
}