﻿// <auto-generated />
using System;
using EFCoreForMySQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCoreForMySQL.Models.Migrations
{
    [DbContext(typeof(ChatAppDbContext))]
    [Migration("20250108123135_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("EFCoreForMySQL.Models.Channel", b =>
                {
                    b.Property<int>("ChannelIdx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("channel_idx");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChannelIdx"));

                    b.Property<string>("ChannelDesc")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)")
                        .HasColumnName("channel_desc");

                    b.Property<string>("ChannelImgPath")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("channel_img_path");

                    b.Property<string>("ChannelName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("channel_name");

                    b.Property<int>("ChannelTypeCode")
                        .HasColumnType("int")
                        .HasColumnName("channel_type_code");

                    b.Property<int>("LimitCnt")
                        .HasColumnType("int")
                        .HasColumnName("limit_cnt");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modify_date");

                    b.Property<int?>("ModifyMemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("modify_member_idx");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("regist_date");

                    b.Property<int>("RegistMemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("regist_member_idx");

                    b.Property<string>("ServiceDomain")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("service_domain");

                    b.Property<int>("StateCode")
                        .HasColumnType("int")
                        .HasColumnName("state_code");

                    b.HasKey("ChannelIdx")
                        .HasName("channel_pk");

                    b.ToTable("channels", (string)null);
                });

            modelBuilder.Entity("EFCoreForMySQL.Models.ChannelLog", b =>
                {
                    b.Property<int>("ChannelLogIdx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("channel_log_idx");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ChannelLogIdx"));

                    b.Property<string>("BrowserType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("browser_type");

                    b.Property<int>("ChannelIdx")
                        .HasColumnType("int")
                        .HasColumnName("channel_idx");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("connection_id");

                    b.Property<string>("DeviceType")
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("device_type");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("ip_address");

                    b.Property<DateTime>("LoggingDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("logging_date");

                    b.Property<int>("LoggingTypeCode")
                        .HasColumnType("int")
                        .HasColumnName("logging_type_code");

                    b.Property<int>("MemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("member_idx");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("message");

                    b.HasKey("ChannelLogIdx")
                        .HasName("channel_logs_pk");

                    b.ToTable("channel_logs", (string)null);
                });

            modelBuilder.Entity("EFCoreForMySQL.Models.ChannelMember", b =>
                {
                    b.Property<int>("ChannelIdx")
                        .HasColumnType("int")
                        .HasColumnName("channel_idx");

                    b.Property<int>("MemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("member_idx");

                    b.Property<int>("ActiveCode")
                        .HasColumnType("int")
                        .HasColumnName("active_code");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("connection_id");

                    b.Property<DateTime?>("LastEntryDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("last_entry_date");

                    b.Property<DateTime?>("LastOutDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("last_out_date");

                    b.Property<string>("MemberIpAddress")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("member_ip_address");

                    b.Property<int>("MemberTypeCode")
                        .HasColumnType("int")
                        .HasColumnName("member_type_code");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("modify_date");

                    b.Property<int?>("ModifyMemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("modify_member_idx");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("nick_name");

                    b.Property<string>("ProfileImgPath")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("profile_img_path");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("regist_date");

                    b.Property<int>("RegistMemberIdx")
                        .HasColumnType("int")
                        .HasColumnName("regist_member_idx");

                    b.Property<string>("ServerIp")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)")
                        .HasColumnName("server_ip");

                    b.Property<int>("StateCode")
                        .HasColumnType("int")
                        .HasColumnName("state_code");

                    b.HasKey("ChannelIdx", "MemberIdx")
                        .HasName("channel_members_pk");

                    b.ToTable("channel_members", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
