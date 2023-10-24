namespace Victorina.Core
{
    public class Quiz
    {

        public string _question { get; set; }
        public Dictionary<bool, string> _answers = new Dictionary<bool, string>();

        public Quiz(string question, Dictionary<bool, string> answers)
        {
            _question = question;
            _answers = answers;

        }
    }

}