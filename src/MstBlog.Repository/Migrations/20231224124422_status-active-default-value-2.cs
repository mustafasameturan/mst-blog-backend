using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MstBlog.Repository.Migrations
{
    public partial class statusactivedefaultvalue2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7600));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7180));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7060));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5910));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(6550));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(6420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4150));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7600),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(7060),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(6550),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(6420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(5150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 37, 12, 54, DateTimeKind.Utc).AddTicks(4150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7030));
        }
    }
}
