﻿// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

static void Main(string[] args)
{

    using (var ctx = new SchoolContext())
    {
        var stud = new Student() { StudentName = "Bill" };

        ctx.Students.Add(stud);
        ctx.SaveChanges();
    }
}