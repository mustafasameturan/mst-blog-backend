using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MstBlog.Repository.Migrations
{
    public partial class postlink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7200),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6140),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6040),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5710),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5560),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Posts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7560));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(7200));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6140));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(6040));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5710));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 14, 14, 15, 51, 57, DateTimeKind.Utc).AddTicks(5560));
        }
    }
}
