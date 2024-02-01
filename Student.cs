namespace PersonStudentProfessor;

public class Student:Person {

    public string Study(){
        return "I am studying on the screen";
    }

    public void showAge(int age){
        
        setAge(age);
        int studentAge = getAge();
        Console.WriteLine($"I am {studentAge} years old");
    }
}