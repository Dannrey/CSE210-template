public class YouTubeVideo{
    // Attributes:
    private int _videoLengthMinutes;
    private int _videoLengthSeconds;
    private int _totalLengthInSeconds;
    private string _videoName;
    private string _author;
    private List<Comment> _comments = new List<Comment>();
    // These list items are meant to randomize the video information, excluding video length.
    private List<string> _authors = new List<string>(["Albert Einstein","Emily Elizabeth","Ferb Fletcher","Jason Walker","George Washington","D3WWY","Michael the Archangel","Toni Di Capelli","Taylor Swift","Keith Urban","Alessio Bernabei","Peter Rabbit","Kai the Ninja"]);
    private List<string> _videoNameList = new List<string>(["How to Play Dungeons and Dragons","Space Flight for Dummies.","No Man's Sky, the Voyager Update","Music"]);

    // Constructors:
    public YouTubeVideo(){
        StockComments();
    }

    // Methods:
    public void GetVideoStats(){
        // string Character = "--->";
        string Stats = $"Video title --> {_videoName} \nVideo author --> {_author}\nVideo length (in seconds) --> {_totalLengthInSeconds} \nVideo length --> {_videoLengthMinutes}:{_videoLengthSeconds}\n";
        
        // Console.Write($"Video title {Character:26<} {_videoName}");
        // Console.Write
    }
    public int GetNumberOfComments(){
        return _comments.Count;
    }
    public void DisplayComments(){
        foreach (Comment comment in _comments){
            Console.WriteLine($"Author: {comment.GetAuthor}");
            Console.WriteLine($"{comment.GetContent}");
        }
        // return 
    }
    private void StockComments(){
        Random random = new Random();
        int Range = random.Next(1,5);
        int iteration = 0;
        while (iteration != Range){
            Comment comment = new Comment();
            iteration += 1;
        }
    }
}