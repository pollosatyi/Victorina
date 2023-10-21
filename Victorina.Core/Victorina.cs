namespace Victorina.Core
{
    public class Quest
    {
       
            public string Name { get; set; }
            public int QuestionCount { get; set; }

            public Quest(string name, int questionCount)
            {
                Name = name;
                QuestionCount = questionCount;
            }
        }
    
}