using Ynov.QuizzYnov.Business;
using Ynov.QuizzYnov.Business.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// builder.Services.AddScoped<IQuizService, QuizService>();
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

app.UseCors(policy => policy.AllowAnyOrigin().AllowAnyHeader());
app.MapControllers();
app.UseHttpsRedirection();

app.Run();