public class Student
{
    private string name;
    private int grade;
    public int ID { get; }

    public string Name
    {
        get { return name; }
        set { name = value.Length >= 3 ? value : "Unknown"; }
    }

    public int Grade
    {
        set { grade = (value >= 0 && value <= 100) ? value : 0; }
    }

    public Student(int id, string name )
    {
        ID = id;
        Name = name;
    }

    public string GetStudentInfo()
    {
        return $"ID: {ID}, Name: {Name}";
    }

    public bool IsPassed()
    {
        return grade >= 60;
    }
}