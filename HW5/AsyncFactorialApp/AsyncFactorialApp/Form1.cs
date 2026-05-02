using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFactorialApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumber.Text, out int number))
            {
                buttonCalculate.Enabled = false;

                long result = await CalculateFactorialAsync(number);

                listBoxResults.Items.Add($"{number}! = {result}");

                buttonCalculate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Введіть коректне число!");
            }
        }

        private async Task<long> CalculateFactorialAsync(int n)
        {
            return await Task.Run(() =>
            {
                long result = 1;

                for (int i = 1; i <= n; i++)
                {
                    result *= i;

                    Thread.Sleep(200);
                }

                return result;
            });
        }
    }
}