namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Person Information Program!");
            // Create an instance of the Person class
            Person person = new Person(1, "John", "Doe");
            // Display the person's information
            person.vorstellen();

            Teacher teacher = new Teacher(2, "Jane", "Smith", "Mathematics");
            Student student = new Student(3, "Alice", "Johnson", "123456");

            student.vorstellen();

            teacher.vorstellen();

        }
    }
}