namespace LinkedLists
{
    class Youtube
    {
        public string? ID { get; set; }
        public string? Title { get; set; }
        public TimeSpan Duration { get; set; }

        public string youtubelink { get { return $"https://www.youtube.com/watch?v={this.ID}"; } }
        public override string ToString()
        {
            
            return $"├── \"{this.Title}\" --- [{this.Duration/*.ToString("hh:mm:ss")*/}] \n│\t {youtubelink}";
        }
    }
}