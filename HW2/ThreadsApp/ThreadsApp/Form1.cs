using System;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThreadsApp
{
    public partial class Form1 : Form
    {
        Thread primeThread;
        Thread fibThread;

        bool isPrimeRunning = false;
        bool isFibRunning = false;

        public Form1()
        {
            InitializeComponent();
        }

        bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        void GeneratePrimes()
        {
            int start = 2;
            int end = int.MaxValue;

            this.Invoke((Action)(() =>
            {
                if (!string.IsNullOrEmpty(textBoxFrom.Text))
                    start = int.Parse(textBoxFrom.Text);

                if (!string.IsNullOrEmpty(textBoxTo.Text))
                    end = int.Parse(textBoxTo.Text);
            }));

            for (int i = start; i <= end && isPrimeRunning; i++)
            {
                if (IsPrime(i))
                {
                    int num = i;

                    this.Invoke((Action)(() =>
                    {
                        listBoxPrimes.Items.Add(num);
                    }));

                    Thread.Sleep(100);
                }
            }
        }

        void GenerateFibonacci()
        {
            long a = 0, b = 1;

            while (isFibRunning)
            {
                long temp = a;

                this.Invoke((Action)(() =>
                {
                    listBoxFib.Items.Add(temp);
                }));

                a = b;
                b = temp + b;

                Thread.Sleep(100);
            }
        }

        private void btnStartPrimes_Click(object sender, EventArgs e)
        {
            isPrimeRunning = true;
            listBoxPrimes.Items.Clear();

            primeThread = new Thread(GeneratePrimes);
            primeThread.Start();
        }

        private void btnStopPrimes_Click(object sender, EventArgs e)
        {
            isPrimeRunning = false;
        }

        private void btnStartFib_Click(object sender, EventArgs e)
        {
            isFibRunning = true;
            listBoxFib.Items.Clear();

            fibThread = new Thread(GenerateFibonacci);
            fibThread.Start();
        }

        private void btnStopFib_Click(object sender, EventArgs e)
        {
            isFibRunning = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            textBoxFrom.Text = "2";
            textBoxTo.Text = "100";

            listBoxPrimes.Items.Clear();
            listBoxFib.Items.Clear();

            isPrimeRunning = false;
            isFibRunning = false;
        }
    }

}