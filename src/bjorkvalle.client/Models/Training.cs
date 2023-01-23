namespace bjorkvalle.client.Models
{
    public class TrainingWeek
    {
        public string Title { get; set; }
        public DateTime EndsOn { get; set; }
        public Day[] Days { get; set; }
    }

    public class Day
    {
        public string Title { get; set; }
        public Block Block { get; set; }
    }

    public class Block
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