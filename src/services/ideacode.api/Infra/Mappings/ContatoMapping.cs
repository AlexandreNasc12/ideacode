using ideacode.api.Domain;
using ideacode.core.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ideacode.api.Infra.Mappings;

public class ContatoMapping : IEntityTypeConfiguration<Contato>
{
    public void Configure(EntityTypeBuilder<Contato> builder)
    {
        builder.ToTable("ContatosWebSite");
        
        builder.HasKey(c => c.Id);

        builder.Property(c => c.Nome).HasMaxLength(50).IsRequired();
        builder.Property(c => c.Assunto).HasMaxLength(50);
        builder.Property(c => c.Empresa).HasMaxLength(100).IsRequired();
        builder.OwnsOne(c => c.Email, email =>
        {
            email.Property(c => c.Endereco).HasMaxLength(Email.EmailMaximo).HasColumnName("Email").IsRequired();
        });
        builder.Property(c => c.Mensagem).HasMaxLength(2000).IsRequired();
    }
}