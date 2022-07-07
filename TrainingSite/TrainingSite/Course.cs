namespace TrainingSite
{
    public class Course
    {
        public string Name { get; set; }
        public Trainer Trainer;
        public DateTime StartDate { get; set; }
        public int Duration { get; set; }
        public List<Student> Students { get; private set; }

        public Course(string name, int duration)
        {
            Name = name;
            Duration = duration;
            Students = new List<Student>();
        }

        public void Schedule(Trainer trainer, DateTime startDate)
        {
            StartDate = startDate;

            if (trainer.Courses.Any(c => c.Name == Name))
            {
                Console.WriteLine("err: {0} is already assigned to {1} course...", trainer.Name, Name);
            }
            else if (trainer.Courses.Any(c => c.StartDate.AddDays(c.Duration) > startDate))
            {
                Console.WriteLine("err: {0} is not available for {1} course...", trainer.Name, Name);
            }
            else
            {
                Trainer = trainer;
                trainer.Courses.Add(this);
            }
        }
    }
}
