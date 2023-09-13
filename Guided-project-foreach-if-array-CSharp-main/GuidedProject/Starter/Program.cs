using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] {90, 85,87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] {90, 95, 87, 88, 96, 96};

string[] studentNames = new string[] {"sophia", "andrew", "emma", "logan"};

int[] studentScores = new int[10]; //used to hold the scores for the current student 
string currentStudentLetterGrade = "";//used to hold the current student letter grade

Console.WriteLine("Student\t\tGrade\n");

foreach(var name in studentNames) 
{
    string currentStudent = name;

    if (currentStudent == "sophia")
    {
        studentScores = sophiaScores;
    }

    else if (currentStudent == "andrew")
    {
        studentScores = andrewScores;
    }

    else if (currentStudent == "emma")
    {
        studentScores = emmaScores;

    }

    else if (currentStudent == "logan")
    {
        studentScores = loganScores;
    }

    double studentSum = 0;
    int counter = 0;
    double studentScore = 0;
    double examScore = 0;
    double extraCreditScore = 0;

    for(int i = 0; i < studentScores.Length; i++) 
    {
        if (i >= currentAssignments)
        {
            extraCreditScore += studentScores[i] * 0.1;
            counter += 1;
        }
        else 
            examScore += studentScores[i];

    }
    double extraCreditAverage = extraCreditScore * 10 / counter;

    studentSum = examScore + extraCreditScore;

   
    
    studentScore = studentSum / currentAssignments;
    
    if (studentScore >= 97)
        currentStudentLetterGrade = "A+";

    else if (studentScore >= 93)
        currentStudentLetterGrade = "A";

    else if (studentScore >= 90)
        currentStudentLetterGrade = "A-";

    else if (studentScore >= 87)
        currentStudentLetterGrade = "B+";

    else if (studentScore >= 83)
        currentStudentLetterGrade = "B";

    else if (studentScore >= 80)
        currentStudentLetterGrade = "B-";

    else if (studentScore >= 77)
        currentStudentLetterGrade = "C+";

    else if (studentScore >= 73)
        currentStudentLetterGrade = "C";

    else if (studentScore >= 70)
        currentStudentLetterGrade = "C-";

    else if (studentScore >= 67)
        currentStudentLetterGrade = "D+";

    else if (studentScore >= 63)
        currentStudentLetterGrade = "D";

    else if (studentScore >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
         

    Console.WriteLine($"{currentStudent}:\t\t{examScore / 5}\t{studentScore}\t{currentStudentLetterGrade}\t{extraCreditAverage} ({(int)extraCreditScore / counter} pts)");


}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
