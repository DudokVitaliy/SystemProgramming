namespace ProcessManager
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
            this.components = new System.ComponentModel.Container();

            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPUTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();

            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ProcessName,
                this.PID,
                this.CPUTime,
                this.Priority,
                this.UserName
            });
            this.dataGridView1.Location = new System.Drawing.Point(0, 138);
            this.dataGridView1.Size = new System.Drawing.Size(528, 183);

            this.ProcessName.HeaderText = "Process Name";
            this.PID.HeaderText = "PID";
            this.CPUTime.HeaderText = "CPU Time";
            this.Priority.HeaderText = "Priority";
            this.UserName.HeaderText = "User Name";

            this.btnRefresh.Location = new System.Drawing.Point(0, 112);
            this.btnRefresh.Size = new System.Drawing.Size(98, 20);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);

            this.btnKill.Location = new System.Drawing.Point(104, 112);
            this.btnKill.Size = new System.Drawing.Size(98, 20);
            this.btnKill.Text = "Kill";
            this.btnKill.Click += new System.EventHandler(this.buttonKill_Click);

            this.btnDetail.Location = new System.Drawing.Point(208, 112);
            this.btnDetail.Size = new System.Drawing.Size(98, 20);
            this.btnDetail.Text = "Show Detail";
            this.btnDetail.Click += new System.EventHandler(this.buttonDetail_Click);

            this.btnStart.Location = new System.Drawing.Point(312, 112);
            this.btnStart.Size = new System.Drawing.Size(98, 20);
            this.btnStart.Text = "Go";
            this.btnStart.Click += new System.EventHandler(this.buttonStart_Click);

            this.textBox1.Location = new System.Drawing.Point(0, 86);
            this.textBox1.Size = new System.Drawing.Size(410, 20);

            this.comboBox1.Location = new System.Drawing.Point(416, 111);
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);

            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnKill);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);

            this.Text = "Process Manager";
            this.Load += new System.EventHandler(this.Form1_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPUTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnStart;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}