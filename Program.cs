namespace PersonStudentProfessor;

class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Console.WriteLine("===Creating person====");
        Console.WriteLine("what is this person's name? ");
        string PersonName = Console.ReadLine();
        Person newPerson = new Person();

        string greetingMessage = newPerson.Greet(PersonName);

        Console.WriteLine(greetingMessage);

        Console.WriteLine("==Creating new student==");
        Console.WriteLine("what is this student's name? ");
        string StudentName = Console.ReadLine();
        Console.WriteLine("what is this student's age? ");
        int Studentage = Convert.ToInt32(Console.ReadLine()) ;

        Student newStudent = new Student();

       string studentGreeting =  newStudent.Greet(StudentName);

       Console.WriteLine(studentGreeting);

        newStudent.showAge(Studentage);


        Console.WriteLine("==Creating new Teacher==");

        Console.WriteLine("what is this Teacher's name? ");
        string TeacherName = Console.ReadLine();
        Console.WriteLine("what is this Teacher's age? ");
        int Teacherage = Convert.ToInt32(Console.ReadLine()) ;

        Teacher newTeacher = new Teacher();
        string teacherGreeting =  newTeacher.Greet(TeacherName);
        Console.WriteLine(teacherGreeting);
        newTeacher.setAge(Teacherage);
        Console.WriteLine(newTeacher.Explain());
    }
}
