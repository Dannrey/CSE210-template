public class Comment{
    // Attributes:
    private string _author;
    private string _content;
    // These two list items are only useful for the purpose of the assignment and are used to randomly generate comments for each of the videos.
    private List<string> _commentContent = new List<string>(["This is the worst video ever.","That is really cool! I never would have thought of it that way.","This changes everything.","In aw of the magnitude of this achievement, is an absolute magnitude.","I've seen better.","That's the funiest thing I've ever seen!","One word: lame"]);
    private List<string> _authorList = new List<string>(["Albert Einstein","Emily Elizabeth","Ferb Fletcher","Jason Walker","George Washington","D3WWY","Michael the Archangel","Toni Di Capelli","Taylor Swift","Keith Urban","Alessio Bernabei","Peter Rabbit","Kai the Ninja"]);
    // Constructors:
    public Comment(){
        Random random = new Random();
        _author = _authorList[random.Next(0,_authorList.Count - 1)];
        _content = _commentContent[random.Next(0,_commentContent.Count - 1)];
    }

    // Methods:

    public string GetAuthor(){
        return _author;
    }

    public string GetContent(){
        return _content;
    }
}