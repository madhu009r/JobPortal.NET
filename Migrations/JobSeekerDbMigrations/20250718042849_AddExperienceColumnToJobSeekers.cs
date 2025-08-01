﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobPortal.Migrations.JobSeekerDbMigrations
{
    /// <inheritdoc />
    public partial class AddExperienceColumnToJobSeekers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Experience",
                table: "JobSeekers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Experience",
                table: "JobSeekers");
        }
    }
}
