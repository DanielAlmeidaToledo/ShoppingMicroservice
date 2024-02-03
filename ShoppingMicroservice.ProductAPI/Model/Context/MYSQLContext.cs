using Microsoft.EntityFrameworkCore;

namespace ShoppingMicroservice.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() {}
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camiseta Nike Sportswear Icon Futura Masculina",
                Price = new decimal(79.99),
                Description = "A camiseta Nike Sportswear coloca você em um macio tecido jersey de algodão e um logotipo clássico no peito.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/01638851.jpg",
                CategoryName = "CAMISETA"
            });            
            
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa Nike Brasil I 2022/23 Jogador Masculina",
                Price = new decimal(699.99),
                Description = "A Coleção da Seleção Brasileira de 2022 combina a icônica estampa da onça-pintada com design inovador que mantém seu corpo seco mesmo no auge da empolgação.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/0226290L.jpg",
                CategoryName = "CAMISETA"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Tênis Nike Invincible 3 Masculino",
                Price = new decimal(899.99),
                Description = "O Invincible Run 3 possui amortecimento espesso para ajudar você a ficar atento e ativo hoje, amanhã e sempre.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/02523151.jpg",
                CategoryName = "TENIS"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Mochila Nike Heritage Unissex\r\n",
                Price = new decimal(279.99),
                Description = "Carregue seu equipamento com a mochila Nike Heritage.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/012822O6A1.jpg",
                CategoryName = "MOCHILA"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Blusão Nike Dri-FIT Magic Hour Masculino\r\n",
                Price = new decimal(599.99),
                Description = "Comece e termine sua aventura ao ar livre com este moletom confortável para corrida em trilha.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/024982NX.jpg",
                CategoryName = "BLUSA"
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Tênis Nike Gamma Force Feminino\r\n",
                Price = new decimal(699.99),
                Description = "Camadas sobre camadas de estilo e conforto - essa é uma força a ser reconhecida.",
                ImageURL = "https://imgnike-a.akamaihd.net/768x768/02567551.jpg",
                CategoryName = "TENIS"
            });
        }
    }
}
