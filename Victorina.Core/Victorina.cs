namespace Victorina.Core
{
    public class Quiz
    {

        public string _question { get; set; }
       // public Dictionary<bool, string> _answers = new Dictionary<bool, string>();
        public List<List<string>> _answers { get; set; }

        public Quiz(string question, List<List<string>> answers)
        {
            _question = question;
            _answers = answers;

        }
    }

}