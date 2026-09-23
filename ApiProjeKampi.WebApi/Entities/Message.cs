namespace ApiProjeKampi.WebApi.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime Senddate { get; set; }
        public bool isRead { get; set; }
    }
}
