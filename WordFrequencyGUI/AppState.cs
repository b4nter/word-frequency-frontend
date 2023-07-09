namespace WordFrequencyGUI
{
    public class AppState
    {
        public List<WordFrequency>? GroupedWords {get;set;}
    }

    public class WordFrequency
    {
        public string? Word { get; set; }
        public int Frequency { get; set; }
        public string? NewsOutlet { get; set; }
    }
}
