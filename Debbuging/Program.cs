string[] students = new string[] {"Sophia", "Nicolas", "Zahirah", "Jeong"};

int studentCount = students.Length;


try {
    Console.WriteLine("The final name is: " + students[studentCount]);
} catch(IndexOutOfRangeException x) {
    Console.WriteLine($"{x.Message}");
}
