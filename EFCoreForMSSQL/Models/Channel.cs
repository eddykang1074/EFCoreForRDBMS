namespace EFCoreForMSSQL.Models
{
    public class Channel
    {
        public int ChannelIdx { get; set; }

        public string ChannelName { get; set; }
        public string? ChannelDesc { get; set; }

        public int ChannelTypeCode { get; set; }

        public string? ServiceDomain { get; set; }

        public int LimitCnt { get; set; }

        public string? ChannelImgPath { get; set; }

        public int StateCode { get; set; }

        public int RegistMemberIdx { get; set; }
        public DateTime RegistDate { get; set; }

        public int? ModifyMemberIdx { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
