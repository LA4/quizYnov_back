using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Services;
using Ynov.QuizzYnov.Controllers.Mappers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IQuizService, QuizService>();
builder.Services.AddScoped<QuizMapper>();
builder.Services.AddScoped<CategoryMapper>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader());
app.MapControllers();
app.UseHttpsRedirection();

app.Run();

