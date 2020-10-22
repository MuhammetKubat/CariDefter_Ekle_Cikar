using Microsoft.EntityFrameworkCore.Migrations;

namespace NewCariDefteri.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Parola = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__206D9190E522EAFC", x => x.User_ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Person_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Soyad = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    User_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Person_ID);
                    table.ForeignKey(
                        name: "FK__Person__User_Id__440B1D61",
                        column: x => x.User_Id,
                        principalTable: "Users",
                        principalColumn: "User_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Info",
                columns: table => new
                {
                    info_Id = table.Column<int>(nullable: false),
                    Telephone = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Person_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Info", x => x.info_Id);
                    table.ForeignKey(
                        name: "FK__Info__Person_Id__47DBAE45",
                        column: x => x.Person_Id,
                        principalTable: "Person",
                        principalColumn: "Person_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "UQ__Info__7EABD0AA1BC1B8B9",
                table: "Info",
                column: "Person_Id",
                unique: true,
                filter: "[Person_Id] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Person__206D91718610BC49",
                table: "Person",
                column: "User_Id",
                unique: true,
                filter: "[User_Id] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Info");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
