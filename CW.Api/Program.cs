using CW.BusinessLayer;
using CW.DataAccesLayer.EfCrudOperations;
using CW.InterfaceLayer.IBusiness;
using CW.InterfaceLayer.IDataAccess;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CW.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            #region Ajax Request Ayarlarý
            builder.Services.AddCors(i => i.AddPolicy("guvenlisiteler", builder =>
            {
                builder.WithOrigins("*").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
            }));

            #endregion

            #region JWT Token Service ayarlarý
            //JWT Token Service ayarlarý
            var key = Encoding.UTF8.GetBytes("UCi9U2H{53(1RePt{Cwc8H9B>5q%rHkS");

            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(i =>
            {
                i.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = "JWTIssuer",
                    ValidAudience = "JWTAudience",
                    IssuerSigningKey = new SymmetricSecurityKey(key)
                };
            });

            builder.Services.AddAuthorization();

            #endregion

            #region IOC

            //builder. Services.AddTransient == > her kullanýmda yeni nesne oluþturur.
            //builder. Services. AddScoped == >Her request de 1 kez oluþturur.
            //builder. Services.AddSingleton == > Uygulama baþladýðýnda 1 kez oluþturur.

            builder.Services.AddTransient<IAboutUs, AboutUsBL>();
            builder.Services.AddTransient<IProject, ProjectBL>();
            builder.Services.AddTransient<IUserInfo, UserInfoBL>();
            builder.Services.AddTransient<IHome, HomeBL>();
            builder.Services.AddTransient<ITeam, TeamBL>();
            builder.Services.AddTransient<ICareer, CareerBL>();
            builder.Services.AddTransient<IApplication, ApplicationBL>();
            builder.Services.AddTransient<IFeedback, FeedbackBL>();


            builder.Services.AddTransient<IEfAboutUs, EfAboutUs>();
            builder.Services.AddTransient<IEfProject, EfProject>();
            builder.Services.AddTransient<IEfUserInfo, EfUserInfo>();
            builder.Services.AddTransient<IEfHome, EfHome>();
            builder.Services.AddTransient<IEfTeam, EfTeam>();
            builder.Services.AddTransient<IEfCareer, EfCareer>();
            builder.Services.AddTransient<IEfApplication, EfApplication>();
            builder.Services.AddTransient<IEfFeedback, EfFeedback>();




            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.MapControllers();

            app.UseCors("guvenlisiteler");



            #region JWT Token Ayarlarý
            // JWT Token Ayarlarý
            app.UseAuthentication(); //JWT Doðrulama middleware'i
            app.UseAuthorization();//Yetkilendirme middleware'i
            #endregion

            #region Ajax Request Middleware Ayarlarý



            #endregion



            app.Run();
        }
    }
}
