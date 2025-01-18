using System.Numerics;
using System.Reflection.Metadata;

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
public class Vector2D{
    private float x, y;
    public Vector2D(float x, float y){
        this.x = x;
        this.y = y;
    }
    public void Print(){
        Console.WriteLine("(" + x + ", " + y + ")");
    }
    //Method overloading for Add
    public Vector2D Add(Vector2D other){
        return new Vector2D(this.x + other.x, this.y + other.y);
    }
    public Vector2D Add(Vector2D a, float weight){//c = a + b * weight
        return new Vector2D(this.x + a.x * weight, this.y + a.y * weight);
    }
    public Vector2D Add(float other){//cộng thêm 1 số cho toạ độ x và y
        return new Vector2D(this.x+other, this.y+other);
    }
    public Vector2D AddMultiple(Vector2D a, float x, float y = 0){//default parameter
        return new Vector2D(this.x + a.x + x + y, this.y + a.y + x + y);
    }
    public Vector2D AddMultipleVectors(params Vector2D[] vectors){//rest parameters
        float sumX = this.x;
        float sumY = this.y;
        foreach(Vector2D vector in vectors){
            sumX += vector.x;
            sumY += vector.y;
        }
        return new Vector2D(sumX, sumY);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.Clear();

        Vector2D a = new Vector2D(1, 2);
        Vector2D b = new Vector2D(3, 4);
        Vector2D c = new Vector2D(5, 6);
        Vector2D d = new Vector2D(7, 8);
        a.Print();
        b.Print();
        (a.Add(b)).Print();
        (a.Add(b, 0.5f)).Print();
        (a.Add(0.5f)).Print();

        (a.AddMultiple(b, 0.5f)).Print();//a+b+0.5
        (a.AddMultiple(b, 0.5f, 0.2f)).Print();//a+b+0.5+0.2

        (a.AddMultipleVectors()).Print();//a
        (a.AddMultipleVectors(b)).Print();//a+b
        (a.AddMultipleVectors(b, c)).Print();//a+b+c
        (a.AddMultipleVectors(b, c, d)).Print();//a+b+c+d

        /*NewPoint2D point1 = new NewPoint2D(1, 2);
        NewPoint2D point2 = new NewPoint2D(3, 4);
        NewPoint2D point3 = new NewPoint2D(5, 6);
        Console.WriteLine("Number of Points: " + NewPoint2D.count);*/

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

/* LAB 03: Lớp số phức
Một lớp số phức gồm có 2 thuộc tính: phần thực (real) và phần ảo (imaginary).
Hãy khai báo một lớp số phức với các yêu cầu sau:
- Có 2 phương thức getter và setter cho mỗi field
- Có 3 dạng constructor: không tham số, có 2 tham số và copy constructor
- Khai báo các phép toán cộng, trừ, nhân, chia 2 số phức
- Khai báo phương thức tính module của số phức
- Khai báo phương thức tính argument của số phức
- Khai báo phương thức cộng số phức với một số thực, sử dụng default params (tối đa 3 số thực)
- Khai báo phương thức cộng nhiều số phức, sử dụng rest params
(Lưu ý: phương thức cộng 2 số phức và phương thức cộng số phức với một số thực phải
sử dụng method overloading.)
Hàm Main: test thử các phương thức nói trên. Lưu ý: tạo một mảng các số phức để thực
thi kết quả.
*/