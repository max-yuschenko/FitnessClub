using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessClub.Data.Migrations
{
    public partial class UpdatingAppUser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PersonalCards_PersonalCardID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PersonalCardID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PersonalCardID",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "HealthDescription",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HealthDescription",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "PersonalCardID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonalCardID",
                table: "AspNetUsers",
                column: "PersonalCardID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PersonalCards_PersonalCardID",
                table: "AspNetUsers",
                column: "PersonalCardID",
                principalTable: "PersonalCards",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
