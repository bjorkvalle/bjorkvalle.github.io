namespace bjorkvalle.client.Models
{
    public class TrainingWeek
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }
        //public DateTime EndsOn { get; set; }
        //public TrainingDay[] Days { get; set; }
    }

    public class TrainingDay
    {
        public string Title { get; set; }
        public TrainingBlock Block { get; set; }
    }

    public class TrainingBlock
    {
        public string Title { get; set; }
        public Exercise[] Exercises { get; set; }
    }

    public class Exercise
    {
        public string Title { get; set; }
        public string ImgUrl { get; set; }
    }

}