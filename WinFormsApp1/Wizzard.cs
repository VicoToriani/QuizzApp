using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace QuizzApp
{
    public partial class Wizzard : Form
    {
        private QuizzData quizzData;
        private int roundNr = 1;
        private Dictionary<string, Bitmap> logoMap = new Dictionary<string, Bitmap>() {
            { "Politik" , Properties.Resources.Politik }  ,
            { "Sport" , Properties.Resources.Sport }  ,
            { "Geschichte" , Properties.Resources.Geschichte }  ,
            { "Geographie" , Properties.Resources.Georgrafie }  ,
            { "Kultur" , Properties.Resources.Kultur } ,
            { "Natur" , Properties.Resources.Natur }
        };

        public Wizzard()
        {
            InitializeComponent();
            var parser = new FileIniDataParser();

            string strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string strWorkPath = System.IO.Path.GetDirectoryName(strExeFilePath);
            string strIniPath = System.IO.Path.Combine(strWorkPath, "quizzApp.ini");
            IniData data = parser.ReadFile(strIniPath, Encoding.UTF8);
            
            quizzData = new QuizzData(data);
            quizzData.Load();                   
        }

        private void OnLoad(object sender, EventArgs e)
        {
            updateWizzard(1);            
        }

        private void updateWizzard(int roundNr) {           
            RoundData roundData = quizzData.GetRoundData(roundNr);
            this.categorie.Text = roundData.getCategory();
            this.categorieQuestion.Text = roundData.getCategoryQuestion();
            UpdateLogo(roundData);
            
            question1.InitContent(roundData.GetQuestion(1));
            question2.InitContent(roundData.GetQuestion(2));
            question3.InitContent(roundData.GetQuestion(3));
            question4.InitContent(roundData.GetQuestion(4));
            question5.InitContent(roundData.GetQuestion(5));
            question6.InitContent(roundData.GetQuestion(6));   
            
            btnForward.Visible = (roundNr < quizzData.getRoundCount());
            btnBack.Visible = (roundNr != 1);
        }

        private void Forward(object sender, EventArgs e)
        {
            roundNr++;
            updateWizzard(roundNr);
        }

        private void Back(object sender, EventArgs e)
        {
            roundNr--;
            updateWizzard(roundNr);
        }

        private void UpdateLogo(RoundData roundData)
        {
            string logoName = roundData.getLogo();
            if (logoMap.ContainsKey(logoName)) 
                this.logo.Image = logoMap[logoName];
        }
    }
}
