using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzApp
{

    public enum State
    {
        unknown=-1,
        challenge=0,
        hint = 1,
        answer = 2
    }
    public partial class Question : UserControl
    {
        private string challenge = "";
        private String hint = "";
        private String answer = "";
        private State state = State.challenge;
        
        public Question()
        {
            InitializeComponent();
            Rectangle parentRect = this.ClientRectangle;
            content.Left = parentRect.Left;
            content.Top = parentRect.Top;
            content.Width = parentRect.Width;
            content.Height = parentRect.Height;
            content.TextAlign = ContentAlignment.MiddleCenter;
            content.Text = "";
            state = State.unknown;
            content.Invalidate();
        }

        public void setChallenge(String challenge) { this.challenge  = challenge; }
        public String getChallenge() { return this.challenge; }
        public void setHint(String hint) { this.hint = hint; }
        public String getHint() { return this.hint; }
        public void setAnswer(String answer) { this.answer = answer; }
        public String getAnswer() { return this.answer; }

        private void OnClick(object sender, EventArgs e)
        {
            ToggleContent();
        }

        public void InitContent(QuestionData question)
        {
            if (question != null)
            {
                setChallenge(question.getChallenge());
                setHint(question.getHint());
                setAnswer(question.getAnswer());
                this.state = State.unknown;
                ToggleContent();
            }
        }

        public void ToggleContent()
        {
            switch (state)
            {
                case State.unknown:
                {
                    state = State.challenge;
                    content.Text = getChallenge();
                    break;
                }

                case State.challenge:
                    {
                        state = State.hint;
                        content.Text = getHint();
                        break;
                    }

                case State.hint:
                    state = State.answer;
                    content.Text = getAnswer();
                    break;

                case State.answer:
                    state = State.challenge;
                    content.Text = getChallenge();
                    break;

                default:
                    break;
            }
            
        }

    }




}
