namespace PersonStudentProfessor;

public class Person{

    private int Age;
    public string Name;
    

    public void setAge(int age){
        
        if(age <= 0){
            Console.WriteLine("Invalid Age");
        }else{
            Age = age;
        }

    }

    public int getAge(){
        return Age;
    }

    public string Greet(string name){
        Name = name;
        return $"{Name} says hi";
    }
    
    
    }