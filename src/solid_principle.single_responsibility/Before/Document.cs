namespace solid_principle.single_responsibility.Before
{
    public class Document
    {
        public required string Title { get; set; }
        public required string Content { get; set; }

        public void SaveToFile(string filePath)
        {
            // Save to file logic
        }

        public void Print()
        {
            // Print document logic
        }

        public void ConvertToPDF()
        {
            // Convert to PDF logic
        }
    }
}
