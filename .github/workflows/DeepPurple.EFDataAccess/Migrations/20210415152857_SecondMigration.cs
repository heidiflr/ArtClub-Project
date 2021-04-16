using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DeepPurple.EFDataAccess.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdminEvent",
                columns: table => new
                {
                    AdminEventID = table.Column<Guid>(nullable: false),
                    AdminID = table.Column<Guid>(nullable: false),
                    EventID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminEvent", x => x.AdminEventID);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<Guid>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceID = table.Column<Guid>(nullable: false),
                    ResourceName = table.Column<string>(nullable: true),
                    ResDescription = table.Column<string>(nullable: true),
                    ResPrice = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceID);
                });

            migrationBuilder.CreateTable(
                name: "ResourceEvent",
                columns: table => new
                {
                    ResourceEventID = table.Column<Guid>(nullable: false),
                    EventID = table.Column<Guid>(nullable: false),
                    ResourceID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResourceEvent", x => x.ResourceEventID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminEvent");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "ResourceEvent");
        }
    }
}
