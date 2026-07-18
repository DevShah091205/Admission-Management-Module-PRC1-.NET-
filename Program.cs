using System;

namespace AdmissionSystem
{
    class Student
    {
        public string Name;
        public int Age;
        public string Course;
        private string status;

        // These are the student details.
        // Name, Age, and Course are public.
        // Status is private.
        // Private data cannot be accessed directly.
        // It is safer to keep it private.

        public Student(string studentName, int studentAge, string studentCourse)
        {
            Name = studentName;
            Age = studentAge;
            Course = studentCourse;
            status = "Pending";
        }

        // This is a constructor.
        // It runs when an object is created.
        // It gives values to the variables.
        // Every new student starts as Pending.
        // No need to call it manually.

        public void ApproveAdmission()
        {
            status = "Approved";
            Console.WriteLine($"SUCCESS: Admission approved for {Name}!");
        }

        // This method approves admission. It changes the status.Status becomes Approved.It also prints a message.Only this method can change status.

        public void DisplayDetails()
        {
            Console.WriteLine("\n--- Student Details ---");
            Console.WriteLine($"Name:   {Name}");
            Console.WriteLine($"Age:    {Age}");
            Console.WriteLine($"Course: {Course}");
            Console.WriteLine($"Status: {status}");
            Console.WriteLine("-----------------------");
        }

        // This method shows student details.
        // It prints all the information.
        // It displays the current status.
        // It makes the output easy to read.
        // It can be used anytime.
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("DEV SHAH", 21, "Computer Science");

            // Main() is where the program starts.
            // A Student object is created.
            // The constructor runs automatically.
            // The object stores student data.
            // Now we can use its methods.

            Console.WriteLine("=== Checking Initial Details ===");
            student1.DisplayDetails();

            Console.WriteLine("=== Approving Student ===");
            student1.ApproveAdmission();

            // First, student details are shown.
            // Then admission is approved.
            // Status changes to Approved.
            // Methods are called using the object.
            // This updates the student data.

            Console.WriteLine("=== Checking Updated Details ===");
            student1.DisplayDetails();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        // Updated details are shown again.
        // ReadKey() keeps the console open.
        // Press any key to close it.
        // The program ends here.
        // Execution is complete.
    }
}