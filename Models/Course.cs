class Course
{
    public string ID { get; set; }
    public string CourseName { get; set; }
    public int Students { get; set; }
    
    //TODO (maybe): add more props

    public Course(string ID, string CourseName, int Students = 10)
    {
        this.ID = ID;
        this.CourseName = CourseName;
        this.Students = Students;
    }

    public static List<Course> courses = new()
    {
        new(
            ID: "CS0101",
            CourseName: "Computer Science",
            Students: 50
        ),
        new(
            ID: "PH0202",
            CourseName: "Medicine",
            Students: 75
        ),
        new(
            ID: "EC0303",
            CourseName: "Economics",
            Students: 150
        )

    };
}