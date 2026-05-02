using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace ResumeAnalyzerApp
{
    public partial class MainWindow : Window
    {
        private List<Resume> resumes = new List<Resume>();

        public MainWindow()
        {
            InitializeComponent();
        }
        private void LoadOne_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == true)
            {
                var r = ResumeParser.Parse(dlg.FileName);
                resumes.Add(r);
                UpdateCities();
            }
        }
        private void LoadFolder_Click(object sender, RoutedEventArgs e)
        {
            var dlg = new FolderBrowserDialog();

            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var files = Directory.GetFiles(dlg.SelectedPath);

                foreach (var file in files)
                {
                    resumes.Add(ResumeParser.Parse(file));
                }

                UpdateCities();
            }
        }

        private void UpdateCities()
        {
            cityBox.ItemsSource = resumes.Select(x => x.City).Distinct().ToList();
        }
        private void CityReport_Click(object sender, RoutedEventArgs e)
        {
            string city = cityBox.SelectedItem?.ToString();

            var list = resumes.Where(x => x.City == city).ToList();

            resultBox.Text = $"Кандидати з {city}:\n" +
                              string.Join("\n", list.Select(x => $"{x.Name} ({x.ExperienceYears} років)"));
        }
        private void MostExperienced_Click(object sender, RoutedEventArgs e)
        {
            var best = resumes.OrderByDescending(x => x.ExperienceYears).FirstOrDefault();

            resultBox.Text = $"Найдосвідченіший:\n{best.Name} ({best.ExperienceYears} років)";
        }
        private void LeastExperienced_Click(object sender, RoutedEventArgs e)
        {
            var worst = resumes.OrderBy(x => x.ExperienceYears).FirstOrDefault();

            resultBox.Text = $"Найменш досвідчений:\n{worst.Name} ({worst.ExperienceYears} років)";
        }
        private void MinSalary_Click(object sender, RoutedEventArgs e)
        {
            var min = resumes.OrderBy(x => x.SalaryMin).FirstOrDefault();

            resultBox.Text = $"Найменша зарплата:\n{min.Name} ({min.SalaryMin})";
        }
        private void MaxSalary_Click(object sender, RoutedEventArgs e)
        {
            var max = resumes.OrderByDescending(x => x.SalaryMax).FirstOrDefault();

            resultBox.Text = $"Найвища зарплата:\n{max.Name} ({max.SalaryMax})";
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "";
        }

    }
}