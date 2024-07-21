public class YouTubeVideo{
    // Attributes:
    private int _minutes = 0;
    private int _seconds = 0;
    // private int _totalLengthInSeconds;
    private string _videoName;
    private string _author;
    private List<Comment> _comments = new List<Comment>();
    // These list items are meant to randomize the video information, excluding video length.
    // private List<string> _authors = new List<string>(["Albert Einstein","Emily Elizabeth","Ferb Fletcher","Jason Walker","George Washington","D3WWY","Michael the Archangel","Toni Di Capelli","Taylor Swift","Keith Urban","Alessio Bernabei","Peter Rabbit","Kai the Ninja","Ham III","Gordan Tracy","Alan Tracy","Virgil Tracy"]);
    // private List<string> _videoNameList = new List<string>(["How to Play Dungeons and Dragons","Space Flight for Dummies.","No Man's Sky, the Voyager Update","Music Over the Ages","Geothermal Hotsprings, Alien Worlds at Home","The Last Mimzy","How It's Made: iPhone","Beyonders, Seeds of Rebellion; Audio Book","The Day the Earth Sttod Still","The Best of SpongeBob","Spinjitzu for Beginners"]);


    // Constructors:
    public YouTubeVideo(){
        StockVideoContent();
        StockComments();
    }


    // Methods:
    public void StockVideoContent(){
        // Random random = new Random();
        // _minutes = random.Next(2,45);
        // _seconds = random.Next(0,59);
        // _totalLengthInSeconds = _minutes*60 + _seconds;
        Console.WriteLine("I will ask you several questions regarding the video.\nPlease follow the onscreen instructions:");
        Console.Write("How many minutes is your video in length? ");
        _minutes = int.Parse(Console.ReadLine());
        Console.Write("How many seconds past the final minute does your video have? ");
        _seconds = int.Parse(Console.ReadLine());
        Console.Write("What is the name of the author of the video? ");
        _author = Console.ReadLine();
        Console.Write("What is the name of the video? ");
        _videoName = Console.ReadLine();

        // _videoName = _videoNameList[random.Next(0,_videoNameList.Count - 1)];
        // _author = _authors[random.Next(0,_authors.Count - 1)];
    }
    public void GetVideoStats(){
        // I'm thinking that I might do something different than the current format of this print statement, but I can't think of it currently.
        // string Stats = $"Video title --> {_videoName} \nVideo author --> {_author}\nVideo length (in seconds) --> {_totalLengthInSeconds} \nVideo length --> {_minutes}:{_seconds}\n";
        Console.Clear();
        Console.WriteLine($"Title: {_videoName}\nAuthor: {_author}\nLength: {_minutes}:{_seconds}\nLength (in seconds): {_minutes*60 + _seconds}");
        // Console.Write("");
        // Console.ReadLine();
        Console.WriteLine();
        // Console.WriteLine("Comments:");
        // foreach (Comment comment in _comments){
            // Console.WriteLine($"{comment.GetContent}");
            // Console.WriteLine($"\t-{comment.GetAuthor}");
            // Console.WriteLine();
        // }
        // Console.WriteLine($"{}");
        // Console.Write($"Video title {Character:26<} {_videoName}");
        // Console.Write
    }
    public int GetNumberOfComments(){
        return _comments.Count;
    }
    private void StockComments(){
        Random random = new Random();
        int Range = random.Next(2,10);  //These need to switch when the program is done testing.
        // int Range = random.Next(1,2);  //These need to switch when the program is done testing.
        int iteration = 0;
        Console.WriteLine($"My sources tell me that there are {Range} comments.\nPlease enter the information corresponding to all of them.");
        while (iteration != Range){
            Comment comment = new Comment();
            _comments.Add(comment);
            iteration += 1;
        }
    }
    public void DisplayComments(){
        Console.WriteLine($"The video, \"{_videoName}\", has {GetNumberOfComments()} comments.");
        Console.WriteLine("Comments:");
        foreach (Comment comment in _comments){
            // comment.GetAuthor();
            Console.WriteLine(comment.GetContent());
            Console.WriteLine($"-{comment.GetAuthor()}");
            Console.WriteLine();
        }
        Console.Write("Hit the neter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();
    }
}