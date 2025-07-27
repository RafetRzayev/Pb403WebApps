namespace PodCast.DataContext.Entities
{
    public class Episode : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public int SpeakerId { get; set; }
        public Speaker? Speaker { get; set; }
        public int TopicId { get; set; }
        public Topic? Topic { get; set; }
        public string CoverImagePath { get; set; } = string.Empty;
        public string Mp3FilePath { get; set; } = string.Empty;
        public int DurationMinutes { get; set; }
        public int ListeningCount { get; set; }
        public int DownloadCount { get; set; }
        public int LikeCount { get; set; }
    }
}