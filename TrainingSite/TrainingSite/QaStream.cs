namespace TrainingSite
{
    public class QaStream
    {
        public string Name { get; set; }
        public List<Student> Students { get; private set; }
        public List<Course> Courses { get; private set; }

        public QaStream(string name)
        {
            Name = name;
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public void Register(Student student, Course course)
        {
            // add student to stream
            if (student.WantsToLearn == Name && student.Stream != Name)
            {
                Students.Add(student);
            }
            else
            {
                Console.WriteLine("err: {0} is not the appropriate stream for Student: {1}, or they are already added to this stream...", Name, student.Name);
            }
            student.Stream = student.WantsToLearn;

            // add course to stream
            if (course.Name != Name)
            {
                Console.WriteLine("err: {0} course is not appropriate for {1} stream...", course.Name, Name);
            }
            else if (Courses.Any(c => c.Name == Name))
            {
                Console.WriteLine("err: {0} course has already been added to {1} stream...", course.Name, Name);
            }
            else
            {
                Courses.Add(course);
            }
            // check if student is already enrolled on this course
            if (student.Courses.Any(c => c.Name == course.Name))
            {
                Console.WriteLine("err: Student {0} is already enrolled on {1} course...", student.Name, course.Name);
            }
            else
            {
                student.Courses.Add(course);
                course.Students.Add(student);
            }
        }
    }
}
