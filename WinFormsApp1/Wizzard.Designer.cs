namespace QuizzApp
{
    partial class Wizzard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnForward = new Button();
            btnBack = new Button();
            logo = new PictureBox();
            question1 = new Question();
            question4 = new Question();
            question5 = new Question();
            question2 = new Question();
            question6 = new Question();
            question3 = new Question();
            tableLayoutPanelQuestions = new TableLayoutPanel();
            categorie = new Label();
            categorieQuestion = new Label();
            tableLayoutPanelTop = new TableLayoutPanel();
            panelTop = new Panel();
            tableLayoutPanelBottom = new TableLayoutPanel();
            tableLayoutPanelMain = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tableLayoutPanelQuestions.SuspendLayout();
            tableLayoutPanelTop.SuspendLayout();
            tableLayoutPanelBottom.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnForward
            // 
            btnForward.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnForward.BackColor = SystemColors.ControlLight;
            btnForward.BackgroundImage = Properties.Resources.Microsoft_Fluentui_Emoji_Mono_Play_Button_512;
            btnForward.BackgroundImageLayout = ImageLayout.Zoom;
            btnForward.Location = new Point(2042, 3);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(222, 57);
            btnForward.TabIndex = 1;
            btnForward.UseMnemonic = false;
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += Forward;
            // 
            // btnBack
            // 
            btnBack.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBack.BackColor = SystemColors.ControlLight;
            btnBack.BackgroundImage = Properties.Resources.Microsoft_Fluentui_Emoji_Mono_Reverse_Button_512;
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(3, 3);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(220, 57);
            btnBack.TabIndex = 2;
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += Back;
            // 
            // logo
            // 
            logo.BackColor = SystemColors.Window;
            logo.BackgroundImageLayout = ImageLayout.Zoom;
            logo.Dock = DockStyle.Fill;
            logo.Location = new Point(3, 3);
            logo.Name = "logo";
            logo.Size = new Size(220, 190);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 3;
            logo.TabStop = false;
            // 
            // question1
            // 
            question1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            question1.BackColor = SystemColors.ControlLight;
            question1.Location = new Point(3, 3);
            question1.Name = "question1";
            question1.Size = new Size(749, 531);
            question1.TabIndex = 6;
            // 
            // question4
            // 
            question4.BackColor = SystemColors.ControlLight;
            question4.Dock = DockStyle.Fill;
            question4.Location = new Point(3, 540);
            question4.Name = "question4";
            question4.Size = new Size(749, 531);
            question4.TabIndex = 7;
            // 
            // question5
            // 
            question5.BackColor = SystemColors.ControlLight;
            question5.Dock = DockStyle.Fill;
            question5.Location = new Point(758, 540);
            question5.Name = "question5";
            question5.Size = new Size(749, 531);
            question5.TabIndex = 9;
            // 
            // question2
            // 
            question2.BackColor = SystemColors.ControlLight;
            question2.Dock = DockStyle.Fill;
            question2.Location = new Point(758, 3);
            question2.Name = "question2";
            question2.Size = new Size(749, 531);
            question2.TabIndex = 8;
            // 
            // question6
            // 
            question6.BackColor = SystemColors.ControlLight;
            question6.Dock = DockStyle.Fill;
            question6.Location = new Point(1513, 540);
            question6.Name = "question6";
            question6.Size = new Size(751, 531);
            question6.TabIndex = 11;
            // 
            // question3
            // 
            question3.BackColor = SystemColors.ControlLight;
            question3.Dock = DockStyle.Fill;
            question3.Location = new Point(1513, 3);
            question3.Name = "question3";
            question3.Size = new Size(751, 531);
            question3.TabIndex = 10;
            // 
            // tableLayoutPanelQuestions
            // 
            tableLayoutPanelQuestions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelQuestions.ColumnCount = 3;
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelQuestions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanelQuestions.Controls.Add(question1, 0, 0);
            tableLayoutPanelQuestions.Controls.Add(question6, 2, 1);
            tableLayoutPanelQuestions.Controls.Add(question2, 1, 0);
            tableLayoutPanelQuestions.Controls.Add(question5, 1, 1);
            tableLayoutPanelQuestions.Controls.Add(question3, 2, 0);
            tableLayoutPanelQuestions.Controls.Add(question4, 0, 1);
            tableLayoutPanelQuestions.Location = new Point(3, 205);
            tableLayoutPanelQuestions.Name = "tableLayoutPanelQuestions";
            tableLayoutPanelQuestions.RowCount = 2;
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelQuestions.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelQuestions.Size = new Size(2267, 1074);
            tableLayoutPanelQuestions.TabIndex = 12;
            // 
            // categorie
            // 
            categorie.AutoSize = true;
            categorie.Dock = DockStyle.Fill;
            categorie.FlatStyle = FlatStyle.Flat;
            categorie.Font = new Font("Segoe UI Variable Display Semib", 32F, FontStyle.Bold);
            categorie.Location = new Point(229, 0);
            categorie.Name = "categorie";
            categorie.Size = new Size(787, 196);
            categorie.TabIndex = 0;
            categorie.Text = "Categorie";
            categorie.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // categorieQuestion
            // 
            categorieQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            categorieQuestion.AutoSize = true;
            categorieQuestion.CausesValidation = false;
            categorieQuestion.FlatStyle = FlatStyle.Flat;
            categorieQuestion.Font = new Font("Segoe UI Variable Display Semib", 32F, FontStyle.Bold);
            categorieQuestion.Location = new Point(1022, 0);
            categorieQuestion.Name = "categorieQuestion";
            categorieQuestion.Size = new Size(1242, 196);
            categorieQuestion.TabIndex = 4;
            categorieQuestion.Text = "categorieQuestion";
            categorieQuestion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanelTop
            // 
            tableLayoutPanelTop.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelTop.BackColor = SystemColors.Control;
            tableLayoutPanelTop.ColumnCount = 3;
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelTop.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableLayoutPanelTop.Controls.Add(logo, 0, 0);
            tableLayoutPanelTop.Controls.Add(categorieQuestion, 2, 0);
            tableLayoutPanelTop.Controls.Add(categorie, 1, 0);
            tableLayoutPanelTop.Location = new Point(3, 3);
            tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            tableLayoutPanelTop.RowCount = 1;
            tableLayoutPanelTop.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelTop.Size = new Size(2267, 196);
            tableLayoutPanelTop.TabIndex = 13;
            // 
            // panelTop
            // 
            panelTop.BackColor = SystemColors.ControlLight;
            panelTop.Dock = DockStyle.Fill;
            panelTop.Location = new Point(229, 3);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1807, 57);
            panelTop.TabIndex = 4;
            // 
            // tableLayoutPanelBottom
            // 
            tableLayoutPanelBottom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelBottom.ColumnCount = 3;
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanelBottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanelBottom.Controls.Add(btnBack, 0, 0);
            tableLayoutPanelBottom.Controls.Add(btnForward, 2, 0);
            tableLayoutPanelBottom.Controls.Add(panelTop, 1, 0);
            tableLayoutPanelBottom.Location = new Point(3, 1285);
            tableLayoutPanelBottom.Name = "tableLayoutPanelBottom";
            tableLayoutPanelBottom.RowCount = 1;
            tableLayoutPanelBottom.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelBottom.Size = new Size(2267, 63);
            tableLayoutPanelBottom.TabIndex = 14;
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelTop, 0, 0);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelBottom, 0, 2);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelQuestions, 0, 1);
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 3;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanelMain.Size = new Size(2273, 1351);
            tableLayoutPanelMain.TabIndex = 15;
            // 
            // Wizzard
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(2273, 1351);
            Controls.Add(tableLayoutPanelMain);
            Name = "Wizzard";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Österreich Quizz";
            Load += OnLoad;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tableLayoutPanelQuestions.ResumeLayout(false);
            tableLayoutPanelTop.ResumeLayout(false);
            tableLayoutPanelTop.PerformLayout();
            tableLayoutPanelBottom.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnForward;
        private Button btnBack;
        private PictureBox logo;
        private Question question1;
        private Question question2;
        private Question question3;
        private Question question4;
        private Question question5;
        private Question question6;
        private TableLayoutPanel tableLayoutPanelQuestions;
        private Label categorie;
        private Label categorieQuestion;
        private TableLayoutPanel tableLayoutPanelTop;
        private Panel panelTop;
        private TableLayoutPanel tableLayoutPanelBottom;
        private TableLayoutPanel tableLayoutPanelMain;
    }
}