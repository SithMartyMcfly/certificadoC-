﻿using System;
using System.ComponentModel.Design;

// initialize variables - graded assignments 
int examAssignments = 5;

//Score arrays
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

//Student names
string[] studentsName = { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
//Student scores
int[] studentScores = new int[10];
//LetterGrade
string currentStudentLetterGrade = "";

//Individual student score 
Console.WriteLine("Student\t\tGrade\n");
foreach (string student in studentsName)
{
    string currentStudent = student;
    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    }
    else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    }
    else if (currentStudent == "Emma")
    {
        studentScores = emmaScores;
    }
    else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    }
    else if (currentStudent == "Becky") {
        studentScores = beckyScores;
    }
    else if (currentStudent == "Chirs") {
        studentScores = chrisScores;
    }
    else if (currentStudent == "Eric") {
        studentScores = ericScores;
    }
    else if (currentStudent == "Gregor") {
        studentScores = gregorScores;
    }
      

    int sumAssignmentScores = 0;

    decimal currentStudentGrade = 0;

    //initalize/reset counter ofr the number of assignments
    int gradedAssignments = 0;

    //Internal foreach to every student
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else {
            sumAssignmentScores += score / 10;
        }
    }
    
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;
    //Letter assignment
    if (currentStudentGrade >= 97)
    {
        currentStudentLetterGrade = "A+";
    }
    else if (currentStudentGrade >= 93)
    {
        currentStudentLetterGrade = "A";
    }
    else if (currentStudentGrade >= 90)
    {
        currentStudentLetterGrade = "A-";
    }
    else if (currentStudentGrade >= 87)
    {
        currentStudentLetterGrade = "B+";
    }
    else if (currentStudentGrade >= 83)
    {
        currentStudentLetterGrade = "B";
    }
    else if (currentStudentGrade >= 80)
    {
        currentStudentLetterGrade = "B-";
    }
    else if (currentStudentGrade >= 77)
    {
        currentStudentLetterGrade = "C+";
    }
    else if (currentStudentGrade >= 73)
    {
        currentStudentLetterGrade = "C";
    }
    else if (currentStudentGrade >= 70)
    {
        currentStudentLetterGrade = "C-";
    }
    else if (currentStudentGrade >= 67)
    {
        currentStudentLetterGrade = "D+";
    }
    else if (currentStudentGrade >= 63)
    {
        currentStudentLetterGrade = "D";
    }
    else if (currentStudentGrade >= 60)
    {
        currentStudentLetterGrade = "D-";
    }
    else
    {
        currentStudentLetterGrade = "F";
    }

    Console.WriteLine($"{currentStudent}:\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

