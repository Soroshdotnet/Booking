﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Booking.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class ChangeKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClass_GymClass_GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GymClass",
                table: "GymClass");

            migrationBuilder.RenameTable(
                name: "GymClass",
                newName: "GymClasses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymClasses",
                table: "GymClasses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClass_GymClasses_GymClassId",
                table: "ApplicationUserGymClass",
                column: "GymClassId",
                principalTable: "GymClasses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationUserGymClass_GymClasses_GymClassId",
                table: "ApplicationUserGymClass");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GymClasses",
                table: "GymClasses");

            migrationBuilder.RenameTable(
                name: "GymClasses",
                newName: "GymClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GymClass",
                table: "GymClass",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationUserGymClass_GymClass_GymClassId",
                table: "ApplicationUserGymClass",
                column: "GymClassId",
                principalTable: "GymClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
