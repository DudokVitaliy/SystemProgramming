namespace TextAnalyzerTask
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.radioScreen = new System.Windows.Forms.RadioButton();
            this.radioFile = new System.Windows.Forms.RadioButton();
            this.labelResult = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // textBoxInput
            this.textBoxInput.Location = new System.Drawing.Point(20, 20);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Size = new System.Drawing.Size(400, 150);

            // btnAnalyze
            this.btnAnalyze.Location = new System.Drawing.Point(20, 180);
            this.btnAnalyze.Size = new System.Drawing.Size(120, 30);
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);

            // radioScreen
            this.radioScreen.Location = new System.Drawing.Point(160, 180);
            this.radioScreen.Text = "Show on screen";
            this.radioScreen.Checked = true;

            // radioFile
            this.radioFile.Location = new System.Drawing.Point(160, 210);
            this.radioFile.Text = "Save to file";

            // labelResult
            this.labelResult.Location = new System.Drawing.Point(20, 250);
            this.labelResult.Size = new System.Drawing.Size(700, 150);
            this.labelResult.AutoSize = true;

            // Form1
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.radioScreen);
            this.Controls.Add(this.radioFile);
            this.Controls.Add(this.labelResult);

            this.Name = "Form1";
            this.Text = "Text Analyzer (Task)";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.RadioButton radioScreen;
        private System.Windows.Forms.RadioButton radioFile;
        private System.Windows.Forms.Label labelResult;
    }
}