using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.Configuration;

public class QuizConfiguration : IEntityTypeConfiguration<Quiz>
{
    public void Configure(EntityTypeBuilder<Quiz> builder)
    {
        builder.HasKey(q => q.Id);
        builder.Property(q => q.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(q => q.Description)
            .HasMaxLength(500);
        builder.HasMany(quiz => quiz.Questions)
            .WithOne(question => question.Quiz);
    }
}