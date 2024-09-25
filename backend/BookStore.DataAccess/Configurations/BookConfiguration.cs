using BookStore.Core.Models;
using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStore.DataAccess.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<BookEntity>

    {
        public void Configure(EntityTypeBuilder<BookEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title)
                .HasMaxLength(Book.MAX_TITLE_LENGTH)
                .IsRequired();
            builder.Property(x => x.Description)
                .IsRequired();
            builder.Property(x => x.Price)
                .IsRequired();
        }
    }
}
