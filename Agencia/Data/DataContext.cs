using Agencia.Model;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


namespace Agencia.Data
{

public class DataContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Destino> Destinos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    
   protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Destino>().HasData(
        new Destino
        {
            DestinoId = 1,
            Nome = "Rio de Janeiro",
            Descricao = "Cidade maravilhosa com praias incríveis",
            DestinoURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Frevistaazul.voeazul.com.br%2Fdestinos%2Fmuito-alem-da-praia-saiba-o-que-fazer-no-rio-de-janeiro%2F&psig=AOvVaw2Vz42r5MVJ6pxZzbwD12m4&ust=1705015718685000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPCz1NT804MDFQAAAAAdAAAAABAD",
            Preco = 1500.00m
        },
        new Destino
        {
            DestinoId = 2,
            Nome = "São Paulo",
            Descricao = "Maior cidade do Brasil, centro financeiro",
            DestinoURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fviagemeturismo.abril.com.br%2Fcidades%2Fsao-paulo-4&psig=AOvVaw0VzgqXjA2WBQ3nmADup1Yl&ust=1705015754557000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCPj86eX804MDFQAAAAAdAAAAABAD",
            Preco = 1200.00m
        },
        new Destino
        {
            DestinoId = 3,
            Nome = "Minas Gerais",
            Descricao = "Estado com rica história e belas paisagens",
            DestinoURL = "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.direcional.com.br%2Fblog%2Flugares-para-morar%2Fcomo-e-morar-em-minas-gerais%2F&psig=AOvVaw1_aRvu1AqJYIPBGgRbp2Rv&ust=1705015787287000&source=images&cd=vfe&opi=89978449&ved=0CBIQjRxqFwoTCMiuhfX804MDFQAAAAAdAAAAABAD",
            Preco = 1000.00m
        }
    );
}


}



}