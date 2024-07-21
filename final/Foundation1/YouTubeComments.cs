public class Comment{
    // Attributes:
    private string _author;
    private string _content;
    // These two list items are only useful for the purpose of the assignment and are used to randomly generate comments for each of the videos.
    private List<string> _commentContent = new List<string>(["This is the worst video ever.","I never would have thought of it that way.","That is really cool!","This changes everything.","In aw of the magnitude of this achievement, is an absolute magnitude.","I've seen better.","That's the funiest thing I've ever seen!","One word: lame"]);
    private List<string> _authorList = new List<string>(["Albert Einstein","Gordan Tracy","Alan Tracy","Virgil Tracy","Emily Elizabeth","Ferb Fletcher","Jason Walker","George Washington","D3WWY","Michael the Archangel","Toni Di Capelli","Taylor Swift","Keith Urban","Alessio Bernabei","Peter Rabbit","Kai the Ninja"]);


    // Constructors:
    public Comment(){
        Console.Clear();
        Console.Write("Please enter the name of the comment author: ");
        _author = Console.ReadLine();
        // Random random = new Random();
        // _author = _authorList[random.Next(0,_authorList.Count - 1)];
        Console.Clear();

        // _content = _commentContent[random.Next(0,_commentContent.Count - 1)];
        Console.WriteLine("Please enter the content of the comment:");
        _content = Console.ReadLine();
        Console.Clear();
        Console.Write("You have successfully uploaded a new comment.\nHit the enter key when you are ready to continue: ");
        Console.ReadLine();
        Console.Clear();
    }


    // Methods:
    public string GetAuthor(){
        return _author;
    }

    public string GetContent(){
        return _content;
    }
}