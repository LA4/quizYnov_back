using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Ynov.QuizzYnov.Business.EntityFrameWork;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var ConnectionString ="Server=(localdb)\\MSSQLLocalDB;Initial Catalog=QuizYnov;Integrated Security=True;";

        var builder = new DbContextOptionsBuilder<ApplicationDbContext>();

        builder.UseSqlServer(ConnectionString);
        return new ApplicationDbContext(builder.Options);
    }
}