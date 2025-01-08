﻿// <auto-generated />
using System;
using EFCoreForPostgreSQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCoreForPostgreSQL.Models.Migrations
{
    [DbContext(typeof(ChatAppDbContext))]
    [Migration("20250108115154_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFCoreForPostgreSQL.Models.Channel", b =>
                {
                    b.Property<int>("ChannelIdx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("channel_idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChannelIdx"));

                    b.Property<string>("ChannelDesc")
                        .HasMaxLength(500)
                        .HasColumnType("character varying(500)")
                        .HasColumnName("channel_desc");

                    b.Property<string>("ChannelImgPath")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("channel_img_path");

                    b.Property<string>("ChannelName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("channel_name");

                    b.Property<int>("ChannelTypeCode")
                        .HasColumnType("integer")
                        .HasColumnName("channel_type_code");

                    b.Property<int>("LimitCnt")
                        .HasColumnType("integer")
                        .HasColumnName("limit_cnt");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<int?>("ModifyMemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("modify_member_idx");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("regist_date");

                    b.Property<int>("RegistMemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("regist_member_idx");

                    b.Property<string>("ServiceDomain")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("service_domain");

                    b.Property<int>("StateCode")
                        .HasColumnType("integer")
                        .HasColumnName("state_code");

                    b.HasKey("ChannelIdx")
                        .HasName("channel_pk");

                    b.ToTable("channels", (string)null);
                });

            modelBuilder.Entity("EFCoreForPostgreSQL.Models.ChannelLog", b =>
                {
                    b.Property<int>("ChannelLogIdx")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("channel_log_idx");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ChannelLogIdx"));

                    b.Property<string>("BrowserType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("browser_type");

                    b.Property<int>("ChannelIdx")
                        .HasColumnType("integer")
                        .HasColumnName("channel_idx");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("connection_id");

                    b.Property<string>("DeviceType")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("device_type");

                    b.Property<string>("IPAddress")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("ip_address");

                    b.Property<DateTime>("LoggingDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("logging_date");

                    b.Property<int>("LoggingTypeCode")
                        .HasColumnType("integer")
                        .HasColumnName("logging_type_code");

                    b.Property<int>("MemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("member_idx");

                    b.Property<string>("Message")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)")
                        .HasColumnName("message");

                    b.HasKey("ChannelLogIdx")
                        .HasName("channel_logs_pk");

                    b.ToTable("channel_logs", (string)null);
                });

            modelBuilder.Entity("EFCoreForPostgreSQL.Models.ChannelMember", b =>
                {
                    b.Property<int>("ChannelIdx")
                        .HasColumnType("integer")
                        .HasColumnName("channel_idx");

                    b.Property<int>("MemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("member_idx");

                    b.Property<int>("ActiveCode")
                        .HasColumnType("integer")
                        .HasColumnName("active_code");

                    b.Property<string>("ConnectionId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("connection_id");

                    b.Property<DateTime?>("LastEntryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_entry_date");

                    b.Property<DateTime?>("LastOutDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("last_out_date");

                    b.Property<string>("MemberIpAddress")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("member_ip_address");

                    b.Property<int>("MemberTypeCode")
                        .HasColumnType("integer")
                        .HasColumnName("member_type_code");

                    b.Property<DateTime?>("ModifyDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("modify_date");

                    b.Property<int?>("ModifyMemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("modify_member_idx");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("nick_name");

                    b.Property<string>("ProfileImgPath")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("profile_img_path");

                    b.Property<DateTime>("RegistDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("regist_date");

                    b.Property<int>("RegistMemberIdx")
                        .HasColumnType("integer")
                        .HasColumnName("regist_member_idx");

                    b.Property<string>("ServerIp")
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("server_ip");

                    b.Property<int>("StateCode")
                        .HasColumnType("integer")
                        .HasColumnName("state_code");

                    b.HasKey("ChannelIdx", "MemberIdx")
                        .HasName("channel_members_pk");

                    b.ToTable("channel_members", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
