namespace TrainingSite
{
    public class Student
    {
        public string Name { get; set; }
        public string WantsToLearn { get; set; }
        public string Stream { get; set; }
        public List<Course> Courses { get; private set; }

        public Student(string name, string wantsToLearn)
        {
            Name = name;
            WantsToLearn = wantsToLearn;
            Courses = new List<Course>();
        }
    }
}
