using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MstBlog.Repository.Migrations
{
    public partial class updatereadtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1660),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1540),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1070),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9870));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9720),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8630));

            migrationBuilder.AlterColumn<int>(
                name: "ReadTime",
                table: "Posts",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(440),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(250),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9010),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8850),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7820));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7270));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7030));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1660));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Subscribes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 376, DateTimeKind.Utc).AddTicks(300),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1540));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9870),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(1070));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9750),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8630),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9720));

            migrationBuilder.AlterColumn<double>(
                name: "ReadTime",
                table: "Posts",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Posts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(8490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(440));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostContents",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(9110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 900, DateTimeKind.Utc).AddTicks(250));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(9010));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PostCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7820),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8850));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7270),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 12, 24, 12, 44, 22, 375, DateTimeKind.Utc).AddTicks(7030),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 1, 7, 7, 46, 20, 899, DateTimeKind.Utc).AddTicks(8030));
        }
    }
}
