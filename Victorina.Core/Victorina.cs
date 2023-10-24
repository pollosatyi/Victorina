namespace Victorina.Core
{
    public class Quiz
    {

        public string _question { get; set; }
        public List<List<string>> _answers { get; set; }

        public Quiz(string question, List<List<string>> answers)
        {
            _question = question;
            _answers = answers;

        }
    }

}