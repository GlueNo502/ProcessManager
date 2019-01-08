using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace ProcessManager
{
    public partial class SubWindow1 : Form
    {
        private bool AdminFlag = false;
        public SubWindow1()
        {
            InitializeComponent();
        }

        private void SubWindow1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            AdminFlag = !AdminFlag;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo NewTask = new ProcessStartInfo();
                NewTask.FileName = textBox1.Text;
                NewTask.WindowStyle = ProcessWindowStyle.Normal;
                if (AdminFlag)
                {
                    NewTask.Verb = "runas";
                }
                Process pro = Process.Start(NewTask);
            }
            catch
            {
                MessageBox.Show("进程管理器无法打开该文件，请确认文件名是否正确，或访问是否被拒绝。","错误",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
