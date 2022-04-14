namespace LINQex
{
  class Program
  {
    static void Main(string[] args)
    {
        char courseFirstLetter = Console.ReadLine()[0];
        HighScores(0, 90, courseFirstLetter);

        string course = Console.ReadLine();
        StudentGeneralInfos(course);
    }

    // The following query returns the students who received a score of 90 or
    // greater on their first exam.
    static void HighScores(int exam, int score, char courseFirstLetter)
    {
        var students = Student.students
        //Trying random Where clauses, just to gain confidence with the syntax
        //TODO: check if there's a less redundant way to add multiple Where clauses
            .Where(student => student.ExamScores[exam] > 90)
            .Where(student => student.Year > GradeLevel.FirstYear)
            .Where(student => student.Course.CourseName.StartsWith(courseFirstLetter))
            .Select(
                student => new
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Score = student.ExamScores[exam]
                }
            )
            .OrderBy(student => student.LastName);

        foreach(var student in students)
        {
            Console.WriteLine($"{student.LastName} {student.FirstName} -- {student.Score}");
        }
    }
    
    //The following query returns the student's first name, last name, year, course name
    //ordered by the students enrolling the course
    //TODO: Find a better method name (I will)
    static void StudentGeneralInfos(string course)
    {
        var students = Student.students
            .Where(student => student.Course.CourseName == course)
            .Select(
                student => new
                {
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    Year = student.Year,
                    CourseName = student.Course.CourseName,
                    StNum = student.Course.Students
                }
            )
            .OrderBy(student => student.StNum);

            foreach(var student in students)
            {
                Console.WriteLine($"{student}");
            }
    }
  }
}