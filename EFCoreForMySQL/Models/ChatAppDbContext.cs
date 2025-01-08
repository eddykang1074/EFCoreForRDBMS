using Microsoft.EntityFrameworkCore;

namespace EFCoreForMySQL.Models
{
    public class ChatAppDbContext : DbContext
    {

        public ChatAppDbContext(DbContextOptions<ChatAppDbContext> options) : base(options)
        {
        }
        public DbSet<Channel> Channels { get; set; }

        public DbSet<ChannelMember> ChannelMembers { get; set; }

        public DbSet<ChannelLog> ChannelLogs { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //string connectionString = @"Server=(EDDYKANG)\.;Database=sample;Trusted_Connection=True";
                //optionsBuilder.UseSqlServer(connectionString);
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //channel 테이블 정의
            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("channels");

                entity.Property(e => e.ChannelIdx).UseMySqlIdentityColumn();
                entity.Property(e => e.ChannelIdx).HasColumnName("channel_idx");
                entity.HasKey(e => e.ChannelIdx).HasName("channel_pk");

                entity.Property(e => e.ChannelName).HasColumnName("channel_name").HasMaxLength(100);
                entity.Property(e => e.ChannelDesc).HasColumnName("channel_desc").HasMaxLength(500).IsRequired(false);
                entity.Property(e => e.ChannelTypeCode).HasColumnName("channel_type_code").IsRequired(true);
                entity.Property(e => e.ServiceDomain).HasColumnName("service_domain").HasMaxLength(100).IsRequired(false);
                entity.Property(e => e.LimitCnt).HasColumnName("limit_cnt");
                entity.Property(e => e.ChannelImgPath).HasColumnName("channel_img_path").HasMaxLength(100).IsRequired(false);
                entity.Property(e => e.StateCode).HasColumnName("state_code").IsRequired(true);

                entity.Property(e => e.RegistMemberIdx).HasColumnName("regist_member_idx").IsRequired(true);
                entity.Property(e => e.RegistDate).HasColumnName("regist_date").IsRequired(true);
                entity.Property(e => e.ModifyMemberIdx).HasColumnName("modify_member_idx").IsRequired(false);
                entity.Property(e => e.ModifyDate).HasColumnName("modify_date").IsRequired(false);

            });


            //channel_members 테이블 정의
            modelBuilder.Entity<ChannelMember>(entity =>
            {
                entity.ToTable("channel_members");

                entity.Property(e => e.ChannelIdx).HasColumnName("channel_idx");
                entity.Property(e => e.MemberIdx).HasColumnName("member_idx");
                entity.HasKey(["ChannelIdx", "MemberIdx"]).HasName("channel_members_pk");


                entity.Property(e => e.NickName).HasColumnName("nick_name").HasMaxLength(20).IsRequired(true);
                entity.Property(e => e.ProfileImgPath).HasColumnName("profile_img_path").HasMaxLength(100).IsRequired(false);
                entity.Property(e => e.MemberTypeCode).HasColumnName("member_type_code").IsRequired(true);
                entity.Property(e => e.ActiveCode).HasColumnName("active_code").IsRequired(true);
                entity.Property(e => e.MemberIpAddress).HasColumnName("member_ip_address").HasMaxLength(20).IsRequired(false);
                entity.Property(e => e.ServerIp).HasColumnName("server_ip").HasMaxLength(20).IsRequired(false);
                entity.Property(e => e.ConnectionId).HasColumnName("connection_id").HasMaxLength(100).IsRequired(true);
                entity.Property(e => e.LastEntryDate).HasColumnName("last_entry_date").IsRequired(false);
                entity.Property(e => e.LastOutDate).HasColumnName("last_out_date").IsRequired(false);
                entity.Property(e => e.StateCode).HasColumnName("state_code").IsRequired(true);

                entity.Property(e => e.RegistMemberIdx).HasColumnName("regist_member_idx").IsRequired(true);
                entity.Property(e => e.RegistDate).HasColumnName("regist_date").IsRequired(true);
                entity.Property(e => e.ModifyMemberIdx).HasColumnName("modify_member_idx").IsRequired(false);
                entity.Property(e => e.ModifyDate).HasColumnName("modify_date").IsRequired(false);

            });


            //channel_logs 테이블 정의
            modelBuilder.Entity<ChannelLog>(entity =>
            {
                entity.ToTable("channel_logs");

                entity.Property(e => e.ChannelLogIdx).UseMySqlIdentityColumn();
                entity.Property(e => e.ChannelLogIdx).HasColumnName("channel_log_idx");
                entity.HasKey(e => e.ChannelLogIdx).HasName("channel_logs_pk");

                entity.Property(e => e.ChannelIdx).HasColumnName("channel_idx").IsRequired(true);
                entity.Property(e => e.MemberIdx).HasColumnName("member_idx").IsRequired(true);
                entity.Property(e => e.LoggingTypeCode).HasColumnName("logging_type_code").IsRequired(true);
                entity.Property(e => e.ConnectionId).HasColumnName("connection_id").HasMaxLength(100).IsRequired(true);
                entity.Property(e => e.Message).HasColumnName("message").HasMaxLength(1000).IsRequired(false);
                entity.Property(e => e.IPAddress).HasColumnName("ip_address").HasMaxLength(20).IsRequired(false);
                entity.Property(e => e.BrowserType).HasColumnName("browser_type").HasMaxLength(50).IsRequired(false);
                entity.Property(e => e.DeviceType).HasColumnName("device_type").HasMaxLength(50).IsRequired(false);
                entity.Property(e => e.LoggingDate).HasColumnName("logging_date").IsRequired(true);

            });

        }


    }
}
