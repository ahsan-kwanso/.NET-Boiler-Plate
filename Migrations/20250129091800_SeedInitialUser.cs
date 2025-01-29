using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyAspNetApp.Migrations
{
    public partial class SeedInitialUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "FirstName", "LastName", "CreatedAt" },
                values: new object[] { 
                    1,  // Id
                    "m.ahsan@kwanso.com",
                    "pass123",  // In production, this should be hashed
                    "M.",
                    "Ahsan",
                    DateTime.UtcNow
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}