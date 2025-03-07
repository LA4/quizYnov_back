using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ynov.QuizzYnov.Business.EntityFrameWork;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var connectionString ="Server=(localdb)\\MSSQLLocalDB;Initial Catalog=QuizYnov;Integrated Security=True;";

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        builder.UseSqlServer(connectionString);
        return new ApplicationDbContext(builder.Options);
    }
}