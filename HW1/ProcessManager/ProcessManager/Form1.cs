using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProcessManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadProcesses()
        {
            dataGridView1.Rows.Clear();

            Process[] processes = Process.GetProcesses();

            foreach (var p in processes)
            {
                try
                {
                    dataGridView1.Rows.Add(
                        p.ProcessName,
                        p.Id,
                        p.TotalProcessorTime,
                        p.PriorityClass,
                        ""
                    );
                }
                catch
                {

                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("5");
            comboBox1.SelectedIndex = 1;

            timer1.Interval = 2000;
            timer1.Start();

            LoadProcesses();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadProcesses();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int seconds = int.Parse(comboBox1.SelectedItem.ToString());
            timer1.Interval = seconds * 1000;
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadProcesses();
        }
        private void buttonKill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int pid = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells[1].Value
                );

                try
                {
                    Process.GetProcessById(pid).Kill();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonDetail_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int pid = Convert.ToInt32(
                    dataGridView1.SelectedRows[0].Cells[1].Value
                );

                try
                {
                    var p = Process.GetProcessById(pid);

                    MessageBox.Show(
                        $"Name: {p.ProcessName}\n" +
                        $"Start: {p.StartTime}\n" +
                        $"CPU: {p.TotalProcessorTime}\n" +
                        $"Memory: {p.WorkingSet64}\n" +
                        $"Priority: {p.PriorityClass}"
                    );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}