namespace immutableID
{
    internal class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        // parameterized constructor that accepts a value for ID only
        public Student(int i)
        {
            Id = i;
            FirstName = string.Empty;
            LastName = string.Empty;
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }

    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student1 = new(1)
            {
                FirstName = "George",
                LastName = "Burns"
            };
            Console.WriteLine($"Student 1: ");
            Console.WriteLine($"ID: {student1.Id}");
            Console.WriteLine($"Name: {student1.FirstName} {student1.LastName}");
            Console.WriteLine();
            Student student2 = new(2, "Gracie", "Allen");
            Console.WriteLine($"Student 2: ");
            Console.WriteLine($"ID: {student2.Id}");
            Console.WriteLine($"Name: {student2.FirstName} {student2.LastName}");
        }
    }
}