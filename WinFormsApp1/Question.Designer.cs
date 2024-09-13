namespace QuizzApp
{
    partial class Question
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            content = new Label();
            SuspendLayout();
            // 
            // content
            // 
            content.Anchor = AnchorStyles.None;
            content.CausesValidation = false;
            content.Font = new Font("Arial", 30F, FontStyle.Bold);
            content.Location = new Point(156, 108);
            content.Name = "content";
            content.Size = new Size(261, 93);
            content.TabIndex = 0;
            content.Text = "label1";
            content.TextAlign = ContentAlignment.MiddleCenter;
            content.UseMnemonic = false;
            content.Click += OnClick;
            // 
            // Question
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(content);
            Name = "Question";
            Size = new Size(573, 309);
            Click += OnClick;
            ResumeLayout(false);
        }

        #endregion

        private Label content;
    }
}
