﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentity.DataAccessLayer.Migrations
{
    public partial class mig_added_appuser_and_customeraccount_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserId",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_AppUserId",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "CustomerAccounts");
        }
    }
}
