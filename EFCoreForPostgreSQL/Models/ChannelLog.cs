namespace EFCoreForPostgreSQL.Models
{
    public class ChannelLog
    {
        public int ChannelLogIdx { get; set; }

        public int ChannelIdx { get; set; }

        public int MemberIdx { get; set; }

        public int LoggingTypeCode { get; set; }

        public string? ConnectionId { get; set; }

        public string? Message { get; set; }

        public string? IPAddress { get; set; }

        public string? BrowserType { get; set; }

        public string? DeviceType { get; set; }

        public DateTime LoggingDate { get; set; }
    }
}
