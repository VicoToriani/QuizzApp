using System.Collections.Generic;
using System.Windows.Forms.VisualStyles;
using IniParser;
using IniParser.Model;

namespace QuizzApp
{
    public class QuestionData
    {
        private string challenge;
        private string hint;
        private string answer;

        public QuestionData(string challenge, string hint, string answer)
        {
            this.challenge = challenge;
            this.hint = hint;
            this.answer = answer;
        }

        public QuestionData(IniData ini, int roundNr, int questionNr)
        {
            string round = string.Format("round{0}", roundNr.ToString("00"));
            string challenge = String.Format("q{0}_challenge", questionNr);
            string hint = String.Format("q{0}_hint", questionNr);
            string answer = String.Format("q{0}_answer", questionNr);

            this.challenge = ini[round][challenge];
            this.hint = ini[round][hint];
            this.answer = ini[round][answer];

        }

        public string getChallenge() { return challenge; }
        public string getHint() { return hint; }
        public string getAnswer() { return answer; }

    }

    // every round has 6 challenges, a category and a category-question
    public class RoundData
    {
        private Dictionary<int, QuestionData> questions = new Dictionary<int, QuestionData>();
        private string category; //zB. Sport
        private string categoryQuestion; //zB. österreichische Tennisspieler
        private string logo;

        public RoundData(string category, string categoryQuestion, string  logo)
        {
            this.category = category;
            this.categoryQuestion = categoryQuestion;
            this.logo = logo;
        }

        public RoundData(IniData ini, int roundNr)
        {
            // string round = String.Format("round{0}", roundNr);
            string round = string.Format("round{0}", roundNr.ToString("00"));
            this.category= ini[round]["category"] ;
            this.categoryQuestion = ini[round]["categoryQuestion"];
            this.logo = ini[round]["logo"];

            for (int i = 1; i < 7; i++)
            {
                QuestionData question = new QuestionData(ini, roundNr, i);
                questions.Add(i,question);
            }
        }

        public string getCategory() { return category; }
        public string getCategoryQuestion() { return categoryQuestion; }
        public string getLogo() { return logo; }


        public QuestionData GetQuestion(int questionNr) { 
            return questions[questionNr];
        }

    }

    public class QuizzData
    {
        private IniData ini;
        private int round_count = 0;
        // private List<RoundData> rounds = [];
        private Dictionary<int, RoundData> rounds = new Dictionary<int, RoundData>();

        public QuizzData(IniData ini)
        {
            this.ini = ini;
        }

        public void Load()
        {
            round_count = Int32.Parse(ini["configuration"]["round_count"]);
            for (int i = 1; i <= round_count ; i++)
            {                
                RoundData round = new RoundData(ini, i);
                rounds.Add(i,round);
                // TODO: Sort by round_nr
                // rounds.Sort();
            }
        }

        public RoundData GetRoundData(int roundNr) { 
        return rounds[roundNr];
        }

        public int getRoundCount() { return round_count; }
    }
}
