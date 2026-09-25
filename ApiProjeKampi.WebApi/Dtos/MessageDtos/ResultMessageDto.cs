namespace ApiProjeKampi.WebApi.Dtos.MessageDtos
{
    public class ResultMessageDto
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public DateTime Senddate { get; set; }
        public bool isRead { get; set; }
    }
}
