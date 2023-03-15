using System;

public class Employee
{
    public string Name;
    public int Age;
    public int Salary;
}

public class ProjectManager : Employee
{
    public string ProjectName;
}

public class Developer : Employee
{
    public string ProgrammingLanguage;
}