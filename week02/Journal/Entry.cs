namespace JournalApp
{
    public class Entry
    {
        private string _prompt;
        private string _response;
        private string _date;

        public Entry(string prompt, string response)
        {
            // Empty body for now
        }

        public static Entry FromData(string date, string prompt, string response)
        {
            return new Entry(prompt, response);
        }

        public string FormatForDisplay()
        {
            return "";
        }

        public string Serialize()
        {
            return "";
        }

        public static Entry Deserialize(string line)
        {
            return new Entry("", "");
        }
    }
}
