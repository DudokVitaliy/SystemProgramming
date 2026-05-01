using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalyzerTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // ✅ ДОДАТИ ОБОВ’ЯЗКОВО (щоб зникла помилка Load)
        private void Form1_Load(object sender, EventArgs e)
        {
            radioScreen.Checked = true;
            labelResult.Text = "";
        }

        // ▶ Аналіз кнопка
        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            string text = textBoxInput.Text;

            Task.Run(() =>
            {
                var result = AnalyzeText(text);

                this.Invoke((Action)(() =>
                {
                    if (radioScreen.Checked)
                    {
                        labelResult.Text = result;
                    }
                    else
                    {
                        File.WriteAllText("report.txt", result);
                        MessageBox.Show("Saved to file report.txt");
                    }
                }));
            });
        }

        // 🧠 Аналіз тексту
        private string AnalyzeText(string text)
        {
            int charCount = text.Length;

            string[] sentences = text.Split(new[] { '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            int sentenceCount = sentences.Length;

            int questionCount = 0;
            int exclamatoryCount = 0;

            foreach (char c in text)
            {
                if (c == '?') questionCount++;
                if (c == '!') exclamatoryCount++;
            }

            string[] words = text.Split(new[] { ' ', '\n', '\t', ',', '.', '!', '?' },
                StringSplitOptions.RemoveEmptyEntries);

            int wordCount = words.Length;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Characters: {charCount}");
            sb.AppendLine($"Words: {wordCount}");
            sb.AppendLine($"Sentences: {sentenceCount}");
            sb.AppendLine($"Questions: {questionCount}");
            sb.AppendLine($"Exclamations: {exclamatoryCount}");

            return sb.ToString();
        }
    }
}