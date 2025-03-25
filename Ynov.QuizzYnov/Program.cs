using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.EntityFrameWork;
using Ynov.QuizzYnov.Business.EntityFrameWork.AccessData;
using Ynov.QuizzYnov.Business.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.local.json", optional: true);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAuthentication(option =>
    {
        option.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie(option =>
    {
        option.Events.OnRedirectToLogin = context =>
        {
            context.Response.StatusCode = 401;
            return Task.CompletedTask;
        };
    })
    .AddGitHub(
        option =>
        {
            option.ClientId = builder.Configuration["GitHub:ClientId"] ?? string.Empty;
            option.ClientSecret = builder.Configuration["GitHub:ClientSecret"] ?? string.Empty;
            option.Scope.Add("user:email");
            option.SaveTokens = true;
        });
builder.Services.AddAuthorization();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ApplicationDbContextFactory>();
builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.AddScoped<IQuizService, QuizService>();
builder.Services.AddScoped<QuizDataAccess>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserDataAccess, UserDataAccess>();
// builder.Services.AddScoped<ICategoryService, CategoryService>();
// builder.Services.AddScoped<QuizMapper>();
// builder.Services.AddScoped<CategoryMapper>();
// builder.Services.AddScoped<IQuestionService, QuestionService>();
// builder.Services.AddScoped<IResponseService, ResponseService>();
// builder.Services.AddScoped<IQuestionService, QuestionService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
// on ne peut pas authoriser toutes les origines il faut obligatoirement authoriser une url ou les ulrs
app.UseCors(builder =>
{
    builder
        .WithOrigins("http://localhost:4200/")
        .AllowCredentials()
        .AllowAnyHeader()
        .AllowAnyMethod();
});
app.MapControllers();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.Run();