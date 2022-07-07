namespace TrainingSite
{

    public class Program
    {
        static void Main(string[] args)
        {
            // create students
            var StudentOne = new Student("Thorin", "Java");
            var StudentTwo = new Student("Dwalin", "C#");
            var StudentThree = new Student("Balin", "Networking");
            var StudentFour = new Student("Dori", "Security");
            var StudentFive = new Student("Nori", "Security");
            var StudentSix = new Student("Ori", "C#");

            // store students in array
            Student[] Students = new Student[]
            {
                StudentOne,
                StudentTwo,
                StudentThree,
                StudentFour,
                StudentFive,
                StudentSix
            };

            // create trainers
            var TrainerOne = new Trainer("Phil", "Networking");
            var TrainerTwo = new Trainer("Jetin", "Java");
            var TrainerThree = new Trainer("Jed", "C#");
            var TrainerFour = new Trainer("Grant", "Security");

            //store trainers
            Trainer[] Trainers = new Trainer[]
            {
                TrainerOne,
                TrainerTwo,
                TrainerThree,
                TrainerFour
            };

            // create streams
            var JavaStream = new QaStream("Java");
            var CSharpStream = new QaStream("C#");
            var NetworkingStream = new QaStream("Networking");
            var SecurityStream = new QaStream("Security");

            // store streams
            QaStream[] Streams = new QaStream[]
            {
                JavaStream,
                CSharpStream,
                NetworkingStream,
                SecurityStream
            };

            // create courses
            var JavaCourse = new Course("Java", 10);
            var CSharpCourse = new Course("C#", 5);
            var NetworkingCourse = new Course("Networking", 2);
            var SecurityCourse = new Course("Security", 3);

            // store courses
            Course[] Courses = new Course[]
            {
                JavaCourse,
                CSharpCourse,
                NetworkingCourse,
                SecurityCourse
            };

            //call register method
            JavaStream.Register(StudentOne, JavaCourse);
            CSharpStream.Register(StudentTwo, CSharpCourse);
            NetworkingStream.Register(StudentThree, NetworkingCourse);
            SecurityStream.Register(StudentFour, SecurityCourse);
            SecurityStream.Register(StudentFive, SecurityCourse);
            CSharpStream.Register(StudentSix, CSharpCourse);
            CSharpStream.Register(StudentSix, CSharpCourse);


            // call schedule method
            JavaCourse.Schedule(TrainerOne, DateTime.Now);
            CSharpCourse.Schedule(TrainerTwo, DateTime.Now.AddDays(3));
            NetworkingCourse.Schedule(TrainerThree, DateTime.Now.AddDays(5));
            SecurityCourse.Schedule(TrainerFour, DateTime.Now);

            Console.WriteLine("\n");

            foreach (Student s in Students)
            {
                Console.WriteLine($"Student {s.Name} wants to learn {s.WantsToLearn}.");
            }

            Console.WriteLine("\n");

            foreach(QaStream stream in Streams)
            {
                Console.WriteLine($"Student(s) {string.Join(", ", stream.Students.Select(s => s.Name))} are registered to {stream.Name} Stream. This Stream has {string.Concat( stream.Courses.Select(c => c.Name))} Course.");
            }

            Console.WriteLine("\n");

            foreach (Course c in Courses)
            {
                Console.WriteLine($"{c.Name} Course starts {c.StartDate.ToShortDateString()} lasting {c.Duration} days with trainer {c.Trainer.Name} and student(s) {string.Join(", ", c.Students.Select(s => s.Name))} are enrolled.");
            }

            Console.WriteLine("\n");
            Console.WriteLine("done...");
        }
    }
}
