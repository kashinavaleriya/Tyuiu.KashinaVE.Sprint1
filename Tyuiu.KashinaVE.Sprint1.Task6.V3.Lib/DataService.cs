using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KashinaVE.Sprint1.Task6.V3.Lib
{
    public class DataService : ISprint1Task6V3
    {
        public string LastLetterWord(string value)
        {
            string[] words = value.Split(' ');
            string res = "";
            foreach (string word in words)
            {
                if (word.Length > 0)
                {
                    res += word[word.Length - 1];
                }
            }

            return res;
        }
    }
}
