class Student
{
    //Source: https://docs.microsoft.com/en-us/dotnet/csharp/linq/query-a-collection-of-objects
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int ID { get; set; }
    public GradeLevel? Year { get; set; }
    public List<int> ExamScores { get; set; }
    public Course Course { get; set; }

    public Student(string FirstName, string LastName, int ID, GradeLevel Year, List<int> ExamScores, Course Course)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        this.ID = ID;
        this.Year = Year;
        this.ExamScores = ExamScores;
        this.Course = Course;
    }

    public Student(string FirstName, string LastName, int StudentID, Course Course, List<int>? ExamScores = null)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
        ID = StudentID;
        this.Course = Course;
        this.ExamScores = ExamScores ?? Enumerable.Empty<int>().ToList();
    }

    public static List<Student> students = new()
    {
        new(
            FirstName: "Terry", LastName: "Adams", ID: 120,
            Year: GradeLevel.SecondYear,
            ExamScores: new() { 99, 82, 81, 79 },
            Course: Course.courses[0]
        ),
        new(
            "Fadi", "Fakhouri", 116,
            GradeLevel.ThirdYear,
            new() { 99, 86, 90, 94 },
            Course: Course.courses[0]
        ),
        new(
            "Hanying", "Feng", 117,
            GradeLevel.FirstYear,
            new() { 93, 92, 80, 87 },
            Course: Course.courses[0]
        ),
        new(
            "Cesar", "Garcia", 114,
            GradeLevel.FourthYear,
            new() { 97, 89, 85, 82 },
            Course: Course.courses[1]
        ),
        new(
            "Debra", "Garcia", 115,
            GradeLevel.ThirdYear,
            new() { 35, 72, 91, 70 },
            Course: Course.courses[2]
        ),
        new(
            "Hugo", "Garcia", 118,
            GradeLevel.SecondYear,
            new() { 92, 90, 83, 78 },
            Course: Course.courses[2]
        ),
        new(
            "Sven", "Mortensen", 113,
            GradeLevel.FirstYear,
            new() { 88, 94, 65, 91 },
            Course: Course.courses[0]
        ),
        new(
            "Claire", "O'Donnell", 112,
            GradeLevel.FourthYear,
            new() { 75, 84, 91, 39 },
            Course: Course.courses[0]
        ),
        new(
            "Svetlana", "Omelchenko", 111,
            GradeLevel.SecondYear,
            new() { 97, 92, 81, 60 },
            Course: Course.courses[2]
        ),
        new(
            "Lance", "Tucker", 119,
            GradeLevel.ThirdYear,
            new() { 68, 79, 88, 92 },
            Course: Course.courses[1]
        ),
        new(
            "Michael", "Tucker", 122,
            GradeLevel.FirstYear,
            new() { 94, 92, 91, 91 },
            Course: Course.courses[2]
        ),
        new(
            "Eugene", "Zabokritski", 121,
            GradeLevel.FourthYear,
            new() { 96, 85, 91, 60 },
            Course: Course.courses[1]
        )
    };
}

enum GradeLevel
{
    FirstYear = 1,
    SecondYear,
    ThirdYear,
    FourthYear
};