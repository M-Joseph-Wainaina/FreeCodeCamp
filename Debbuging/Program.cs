string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;

sayHello();
try {
    Console.WriteLine("The final name is: " + students[studentCount]);
} catch(IndexOutOfRangeException x) {
    Console.WriteLine($"{x.Message}");
}
void sayHello()
{
    int a ;
    int b; 
    a = 0; 
    Console.WriteLine("Hello ");
}