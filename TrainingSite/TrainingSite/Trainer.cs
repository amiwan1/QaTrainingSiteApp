namespace TrainingSite
{
    public class Trainer
    {
        public string Name { get; set; }
        public string Qualification { get; set; }
        public List<Course> Courses{ get; private set; }

        public Trainer(string name, string qualification)
        {
            Name = name;
            Qualification = qualification;
            Courses = new List<Course>();
        }
    }
}
