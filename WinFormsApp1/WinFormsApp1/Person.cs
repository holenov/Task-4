using System;

public class Person
{
    public string name;
    public int age;
    public string profession;

    public Person(string name, int age, string profession)
    {
        this.name = name;
        this.age = age;
        this.profession = profession;
    }

    public string GetInformation()
    {
        string information;
        information = "Ім'я: " + this.name + "; Вік: " + this.age.ToString() + "; Професія: " + this.profession;
        return information;
    }
}