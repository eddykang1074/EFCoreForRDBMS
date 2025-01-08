using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreForMSSQL.Models.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "channel_logs",
                columns: table => new
                {
                    channel_log_idx = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    channel_idx = table.Column<int>(type: "int", nullable: false),
                    member_idx = table.Column<int>(type: "int", nullable: false),
                    logging_type_code = table.Column<int>(type: "int", nullable: false),
                    connection_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    message = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ip_address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    browser_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    device_type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    logging_date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_logs_pk", x => x.channel_log_idx);
                });

            migrationBuilder.CreateTable(
                name: "channel_members",
                columns: table => new
                {
                    channel_idx = table.Column<int>(type: "int", nullable: false),
                    member_idx = table.Column<int>(type: "int", nullable: false),
                    nick_name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    profile_img_path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    member_type_code = table.Column<int>(type: "int", nullable: false),
                    active_code = table.Column<int>(type: "int", nullable: false),
                    member_ip_address = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    server_ip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    connection_id = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    last_entry_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    last_out_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    state_code = table.Column<int>(type: "int", nullable: false),
                    regist_member_idx = table.Column<int>(type: "int", nullable: false),
                    regist_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modify_member_idx = table.Column<int>(type: "int", nullable: true),
                    modify_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_members_pk", x => new { x.channel_idx, x.member_idx });
                });

            migrationBuilder.CreateTable(
                name: "channels",
                columns: table => new
                {
                    channel_idx = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    channel_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    channel_desc = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    channel_type_code = table.Column<int>(type: "int", nullable: false),
                    service_domain = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    limit_cnt = table.Column<int>(type: "int", nullable: false),
                    channel_img_path = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    state_code = table.Column<int>(type: "int", nullable: false),
                    regist_member_idx = table.Column<int>(type: "int", nullable: false),
                    regist_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    modify_member_idx = table.Column<int>(type: "int", nullable: true),
                    modify_date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("channel_pk", x => x.channel_idx);
                });
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
