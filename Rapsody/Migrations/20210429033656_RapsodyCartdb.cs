﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Rapsody.Migrations
{
    public partial class RapsodyCartdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RapsodyFoodItems");

            migrationBuilder.CreateTable(
                name: "RapsodyCartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RapsodyCartId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapsodyCartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RapsodyCartItem_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RapsodyCartItem_FoodId",
                table: "RapsodyCartItem",
                column: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RapsodyCartItem");

            migrationBuilder.CreateTable(
                name: "RapsodyFoodItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    RapsodyFoodId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RapsodyFoodItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RapsodyFoodItems_Food_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Food",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RapsodyFoodItems_FoodId",
                table: "RapsodyFoodItems",
                column: "FoodId");
        }
    }
}
