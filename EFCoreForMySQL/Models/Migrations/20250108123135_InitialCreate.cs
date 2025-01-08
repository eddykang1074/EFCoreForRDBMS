using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreForMySQL.Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "channel_logs",
                columns: table => new
                {
                    channel_log_idx = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    channel_idx = table.Column<int>(type: "int", nullable: false),
                    member_idx = table.Column<int>(type: "int", nullable: false),
                    logging_type_code = table.Column<int>(type: "int", nullable: false),
                    connection_id = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    message = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ip_address = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    browser_type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    device_type = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    logging_date = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_logs_pk", x => x.channel_log_idx);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "channel_members",
                columns: table => new
                {
                    channel_idx = table.Column<int>(type: "int", nullable: false),
                    member_idx = table.Column<int>(type: "int", nullable: false),
                    nick_name = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    profile_img_path = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    member_type_code = table.Column<int>(type: "int", nullable: false),
                    active_code = table.Column<int>(type: "int", nullable: false),
                    member_ip_address = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    server_ip = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    connection_id = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    last_entry_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    last_out_date = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    state_code = table.Column<int>(type: "int", nullable: false),
                    regist_member_idx = table.Column<int>(type: "int", nullable: false),
                    regist_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modify_member_idx = table.Column<int>(type: "int", nullable: true),
                    modify_date = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_members_pk", x => new { x.channel_idx, x.member_idx });
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "channels",
                columns: table => new
                {
                    channel_idx = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    channel_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    channel_desc = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    channel_type_code = table.Column<int>(type: "int", nullable: false),
                    service_domain = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    limit_cnt = table.Column<int>(type: "int", nullable: false),
                    channel_img_path = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state_code = table.Column<int>(type: "int", nullable: false),
                    regist_member_idx = table.Column<int>(type: "int", nullable: false),
                    regist_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    modify_member_idx = table.Column<int>(type: "int", nullable: true),
                    modify_date = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_pk", x => x.channel_idx);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "channel_logs");

            migrationBuilder.DropTable(
                name: "channel_members");

            migrationBuilder.DropTable(
                name: "channels");
        }
    }
}
