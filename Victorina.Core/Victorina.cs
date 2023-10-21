namespace Victorina.Core
{
    public class Victorina
    {
       
            public string Name { get; set; }
            public int QuestionCount { get; set; }

            public Victorina(string name, int questionCount)
            {
                Name = name;
                QuestionCount = questionCount;
            }
        }
    
}