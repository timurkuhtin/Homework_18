using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Homework_18.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name:"ClientId",
                table:"Project",
                type: "integer",
                nullable: false
                );

            migrationBuilder.CreateTable(
               name: "Client",
               columns: table => new
               {
                   ClientId = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                   SecondName = table.Column<string>(type: "int", nullable: false),
                   StartedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   PhoneNumber = table.Column<int>(type: "int", nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Client", x => x.ClientId);
                   table.ForeignKey(
                        name: "FK_Client_Project_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Project",
                        principalColumn: "ClientId",
                        onDelete: ReferentialAction.Cascade);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
