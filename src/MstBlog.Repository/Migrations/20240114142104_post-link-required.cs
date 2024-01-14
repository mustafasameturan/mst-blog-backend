using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MstBlog.Repository.Migrations
{
    public partial class postlinkrequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2480),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2390),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2050),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1380),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1670),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(570),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5560));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(2050));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1380));

            migrationBuilder.AlterColumn<string>(
                name: "Link",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(1670));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(570));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 21, 4, 339, DateTimeKind.Utc).AddTicks(400));
        }
    }
}
