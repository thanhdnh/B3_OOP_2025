public class Student
{
    private string name;
    private int age;

  public string Name { get => name; set => name = value; }
  public int Age { get => age; set => age = value; }

  public Student()
    {
        Name = "No Name";
        Age = 0;
    }

    public Student(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    public Student(Student student)
    {
        this.Name = student.Name;
        this.Age = student.Age;
    }
    public void Print()
    {
        System.Console.WriteLine("Student<Name: " + Name + " Age: " + Age + ">");
    }
}
public class Point2D{
    public int X{get;set;}
    public int Y{get;set;}
    public static int count;
    static Point2D(){
        count = 0;
        Console.WriteLine("Count (constructor): " + count);
    }
    public static void CallCounter(){
        count++;
        Console.WriteLine("Count (call): " + count);
    }
}
public class NewPoint2D{
    public int X{get;set;}
    public int Y{get;set;}
    public static int count = 0;
    public NewPoint2D(int x, int y){
        count++;
        this.X = x;
        this.Y = y;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        NewPoint2D point1 = new NewPoint2D(1, 2);
        NewPoint2D point2 = new NewPoint2D(3, 4);
        NewPoint2D point3 = new NewPoint2D(5, 6);
        Console.WriteLine("Number of Points: " + NewPoint2D.count);

        /*Point2D.CallCounter();
        Point2D.CallCounter();
        Point2D.CallCounter();
        Point2D.CallCounter();
        Point2D.CallCounter();*/

        /*Student student = new Student();
        student.Print();

        Student student2 = new Student("John", 20);
        student2.Print();

        Student student3 = new Student(student2);
        student3.Name = "Jane";
        
        student2.Print();
        student3.Print();*/
    }
}