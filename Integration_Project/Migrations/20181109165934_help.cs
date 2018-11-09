﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Integration_Project.Migrations
{
    public partial class help : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "1",
                column: "Latitude",
                value: 43.05395f);

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "3",
                column: "Latitude",
                value: 43.05191f);

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "5",
                column: "Latitude",
                value: 42.91303f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "1",
                column: "Latitude",
                value: 43.05395f);

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "3",
                column: "Latitude",
                value: 43.05191f);

            migrationBuilder.UpdateData(
                table: "Venues",
                keyColumn: "Id",
                keyValue: "5",
                column: "Latitude",
                value: 42.91303f);
        }
    }
}