public class MockDatabase {
    public Video SophomoreChadwick {get; set;} = new Video("/videos/Sophomore-Chadwick-Highlights-2021.mp4", "/imgs/SophomoreChadwick.png", "Sophomore Year Highlights", "Chadwick School (2020-2021)", "/SophomoreChadwick");
    public Video SophomoreWCE {get; set; } = new Video("/videos/West Coast Elite Sophomore Full AAU highlights(2021) .mp4", "/imgs/SophomoreWCE.png", "Sophomore Year Highlights (AAU)", "West Coast Elite (2020-2021)", "SophomoreWCE");
    public static List<Video> Videos {get; set; } = new();
    static MockDatabase() {
        Videos.Add(new Video("/videos/Sophomore-Chadwick-Highlights-2021.mp4", "/imgs/SophomoreChadwick.png", "Sophomore Year Highlights", "Chadwick School (2020-2021)", "/SophomoreChadwick"));
        Videos.Add(new Video("/videos/West Coast Elite Sophomore Full AAU highlights(2021) .mp4", "/imgs/SophomoreWCE.png", "Sophomore Year Highlights", "West Coast Elite (2020-2021)", "SophomoreWCE"));
    }
}