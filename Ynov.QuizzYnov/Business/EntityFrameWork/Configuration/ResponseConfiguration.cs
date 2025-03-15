using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ynov.QuizzYnov.Business.Models;

namespace Ynov.QuizzYnov.Business.EntityFrameWork.Configuration;

public class ResponseConfiguration : IEntityTypeConfiguration<Response>
{
    public void Configure(EntityTypeBuilder<Response> builder)
    {
        builder.HasKey(response => response.Id);
        builder.Property(response => response.IsValid)
            .IsRequired();
    }
}