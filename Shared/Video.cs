public class Video {
    public string Src {get; set; } = "/videos/sample.mp4";
    public string PreviewImg {get; set; } = "/imgs/Repl.jpg";
    public string Title {get; set; } = "Title";
    public string SubTitle {get; set; } = "SubTitle";
    public string Href {get; set; } = "";

    public Video() {
        
    }

    public Video(string s, string p, string t, string sub, string h) {
        Src = s;
        PreviewImg = p;
        Title = t;
        SubTitle = sub;
        Href = h;
    }
}