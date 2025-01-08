namespace EFCoreForPostgreSQL.Models
{
    public class ChannelMember
    {
        public int ChannelIdx { get; set; }

        public int MemberIdx { get; set; }

        public string NickName { get; set; }

        public string? ProfileImgPath { get; set; }

        public int MemberTypeCode { get; set; }

        public int ActiveCode { get; set; }

        public string MemberIpAddress { get; set; }

        public string ServerIp { get; set; }

        public string ConnectionId { get; set; }

        public DateTime? LastEntryDate { get; set; }

        public DateTime? LastOutDate { get; set; }

        public int StateCode { get; set; }

        public int RegistMemberIdx { get; set; }

        public DateTime RegistDate { get; set; }

        public int? ModifyMemberIdx { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}
