﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstimateTracker.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estimates",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    DateCreated = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    DateUpdated = table.Column<DateOnly>(type: "TEXT", nullable: false),
                    JobType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 20, nullable: false),
                    IsRush = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estimates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estimates");
        }
    }
}
