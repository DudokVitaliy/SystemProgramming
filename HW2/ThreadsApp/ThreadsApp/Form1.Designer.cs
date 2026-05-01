namespace ThreadsApp
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
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();

            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();

            this.listBoxPrimes = new System.Windows.Forms.ListBox();
            this.listBoxFib = new System.Windows.Forms.ListBox();

            this.btnStartPrimes = new System.Windows.Forms.Button();
            this.btnStopPrimes = new System.Windows.Forms.Button();

            this.btnStartFib = new System.Windows.Forms.Button();
            this.btnStopFib = new System.Windows.Forms.Button();

            this.SuspendLayout();

            this.labelFrom.Text = "From:";
            this.labelFrom.Location = new System.Drawing.Point(20, 10);

            this.textBoxFrom.Location = new System.Drawing.Point(20, 30);
            this.textBoxFrom.Size = new System.Drawing.Size(100, 20);

            this.labelTo.Text = "To:";
            this.labelTo.Location = new System.Drawing.Point(150, 10);

            this.textBoxTo.Location = new System.Drawing.Point(150, 30);
            this.textBoxTo.Size = new System.Drawing.Size(100, 20);

            this.listBoxPrimes.Location = new System.Drawing.Point(20, 70);
            this.listBoxPrimes.Size = new System.Drawing.Size(150, 200);

            this.listBoxFib.Location = new System.Drawing.Point(200, 70);
            this.listBoxFib.Size = new System.Drawing.Size(150, 200);

            this.btnStartPrimes.Text = "Start Primes";
            this.btnStartPrimes.Location = new System.Drawing.Point(20, 280);
            this.btnStartPrimes.Click += new System.EventHandler(this.btnStartPrimes_Click);

            this.btnStopPrimes.Text = "Stop Primes";
            this.btnStopPrimes.Location = new System.Drawing.Point(20, 310);
            this.btnStopPrimes.Click += new System.EventHandler(this.btnStopPrimes_Click);

            this.btnStartFib.Text = "Start Fib";
            this.btnStartFib.Location = new System.Drawing.Point(200, 280);
            this.btnStartFib.Click += new System.EventHandler(this.btnStartFib_Click);

            this.btnStopFib.Text = "Stop Fib";
            this.btnStopFib.Location = new System.Drawing.Point(200, 310);
            this.btnStopFib.Click += new System.EventHandler(this.btnStopFib_Click);

            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.labelFrom);
            this.Controls.Add(this.labelTo);

            this.Controls.Add(this.listBoxPrimes);
            this.Controls.Add(this.listBoxFib);

            this.Controls.Add(this.btnStartPrimes);
            this.Controls.Add(this.btnStopPrimes);

            this.Controls.Add(this.btnStartFib);
            this.Controls.Add(this.btnStopFib);

            this.Text = "Threads App";
            this.Load += new System.EventHandler(this.Form1_Load);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;

        private System.Windows.Forms.ListBox listBoxPrimes;
        private System.Windows.Forms.ListBox listBoxFib;

        private System.Windows.Forms.Button btnStartPrimes;
        private System.Windows.Forms.Button btnStopPrimes;

        private System.Windows.Forms.Button btnStartFib;
        private System.Windows.Forms.Button btnStopFib;
    }
}