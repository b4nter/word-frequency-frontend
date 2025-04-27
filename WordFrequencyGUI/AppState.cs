namespace WordFrequencyGUI
{
    public class AppState
    {
        public List<WordFrequency>? GroupedWords { get; set; }
        public List<WordFrequency>? Words { get; set; }

    }

    public class WordFrequency
    {
        public string? Word { get; set; }
        public int Frequency { get; set; }
        public string? NewsOutlet { get; set; }
    }

    public class NewsOutletTitle
    {
        public string NewsOutletName { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
