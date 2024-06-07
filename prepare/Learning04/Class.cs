public class Assignment {
    // This is the base class; Assignment
    // Attribues:
    protected string _studentName;
    protected string _topic;
    // protected string _subject;

    // Constructers:

    public Assignment() {   //string Subject) {
        Console.Write("What is the name of the student? ");
        _studentName = Console.ReadLine();
        // _subject = Subject;
        Console.Write("What is the topic of study? ");
        _topic = Console.ReadLine();
    }

    public void GetSummary() {
        Console.WriteLine($"Report for {_studentName}");
        Console.WriteLine($"{_topic}");
    }
}

public class MathAssignment : Assignment {
    private string _bookSection;
    private string _problems;
    public MathAssignment() : base() {
        Console.Write("What is the section of the math book that the problems are sourced from? ");
        _bookSection = Console.ReadLine();

        Console.Write("Please list the problems attempted: ");
        _problems = Console.ReadLine();
    }
    public void GetHomeworkList() {
        GetSummary();
        Console.WriteLine($"{_bookSection}");
        Console.WriteLine($"Problems {_problems}");

        // return _problems;
    }
}

public class WritingAssignment : Assignment {
    protected string _title;

    public WritingAssignment() : base() {
        Console.Write("What is the title of the assignment? ");
        _title = Console.ReadLine();
        // Console.Write("");
    }

    public void GetWritingInformation() {
        GetSummary();
        Console.WriteLine($"{_title}");
    }
}