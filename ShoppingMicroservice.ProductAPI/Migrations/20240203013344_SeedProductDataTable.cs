using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShoppingMicroservice.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "CAMISETA", "A camiseta Nike Sportswear coloca você em um macio tecido jersey de algodão e um logotipo clássico no peito.", "https://imgnike-a.akamaihd.net/768x768/01638851.jpg", "Camiseta Nike Sportswear Icon Futura Masculina", 79.99m },
                    { 4L, "CAMISETA", "A Coleção da Seleção Brasileira de 2022 combina a icônica estampa da onça-pintada com design inovador que mantém seu corpo seco mesmo no auge da empolgação.", "https://imgnike-a.akamaihd.net/768x768/0226290L.jpg", "Camisa Nike Brasil I 2022/23 Jogador Masculina", 699.99m },
                    { 5L, "TENIS", "O Invincible Run 3 possui amortecimento espesso para ajudar você a ficar atento e ativo hoje, amanhã e sempre.", "https://imgnike-a.akamaihd.net/768x768/02523151.jpg", "Tênis Nike Invincible 3 Masculino", 899.99m },
                    { 6L, "MOCHILA", "Carregue seu equipamento com a mochila Nike Heritage.", "https://imgnike-a.akamaihd.net/768x768/012822O6A1.jpg", "Mochila Nike Heritage Unissex\r\n", 279.99m },
                    { 7L, "BLUSA", "Comece e termine sua aventura ao ar livre com este moletom confortável para corrida em trilha.", "https://imgnike-a.akamaihd.net/768x768/024982NX.jpg", "Blusão Nike Dri-FIT Magic Hour Masculino\r\n", 599.99m },
                    { 8L, "TENIS", "Camadas sobre camadas de estilo e conforto - essa é uma força a ser reconhecida.", "https://imgnike-a.akamaihd.net/768x768/02567551.jpg", "Tênis Nike Gamma Force Feminino\r\n", 699.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);
        }
    }
}
