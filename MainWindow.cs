using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Management;

namespace ProcessManager
{
    public partial class MainWindow : Form
    {
        Timer RefreshWatch = new Timer
        {
            Interval = 30000
        };
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            RefreshWatch.Start();
            GetProcessInfo();
            RefreshWatch.Tick += new EventHandler(refresh);
        }
        private void MainWindow_SizeChanged(object sender,EventArgs e)
        {
            ProcessListView.Columns[5].Width = ProcessListView.ClientSize.Width -
                                               ProcessListView.Columns[4].Width -
                                               ProcessListView.Columns[3].Width -
                                               ProcessListView.Columns[2].Width -
                                               ProcessListView.Columns[1].Width -
                                               ProcessListView.Columns[0].Width;
        }
        private void GetProcessInfo()
        {
            try
            {
                ProcessListView.Items.Clear();
                ProcessImageList.Images.Clear();
                int ProcessCounter = 0;
                Process[] TotalProcesses = Process.GetProcesses();
                this.ProcessListView.BeginUpdate();
                foreach (Process ProcessPointer in TotalProcesses)
                {
                    PerformanceCounter PCProcessCPU = new PerformanceCounter("Process", "% Processor Time", ProcessPointer.ProcessName);
                    PCProcessCPU.NextValue();
                    ListViewItem ProcessListViewItem = new ListViewItem(ProcessPointer.ProcessName, 0);
                    Icon ProcessIcon = SystemIcons.Question;
                    try
                    {
                        ProcessIcon = Icon.ExtractAssociatedIcon(ProcessPointer.MainModule.FileName);
                        //ProcessIcon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);   using System.Reflection;    test reuslt is bad
                    }
                    catch
                    {
                        ProcessIcon = SystemIcons.Application;
                    }
                    ProcessImageList.Images.Add(ProcessIcon);
                    ProcessListViewItem.ImageIndex = ProcessCounter;
                    ProcessListViewItem.SubItems.Add(ProcessPointer.Id.ToString());
                    ProcessListViewItem.SubItems.Add((ProcessPointer.Responding) ?"正在运行":"已挂起");
                    ProcessListViewItem.SubItems.Add(ProcessPointer.BasePriority.ToString());
                    ProcessListViewItem.SubItems.Add((ProcessPointer.WorkingSet64 / 1024).ToString() + " K");
                    ProcessListViewItem.SubItems.Add((PCProcessCPU.NextValue() / Environment.ProcessorCount).ToString() + " %");
                    ProcessListView.Items.Add(ProcessListViewItem);
                    ProcessCounter++;
                }
                this.ProcessListView.EndUpdate();
                this.toolStripStatusLabel1.Text = "进程数: " + ProcessCounter;
            }
            catch
            {
                MessageBox.Show("进程管理器无法正常启动。", "错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                this.Close();
            }
        }
        private void 立即刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            refresh(sender,e);
        }

        private void refresh(object sender,EventArgs e)
        {
            if (sender == RefreshWatch || sender.ToString() == "立即刷新")
            {
                ProcessListView.Refresh();
            }
        }

        private void 运行新任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubWindow1 RunNewTask = new SubWindow1();
            RunNewTask.ShowDialog();
        }
        
        private void 高ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWatch.Interval = 10000;
            RefreshModeCheck(sender);
        }

        private void 正常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWatch.Interval = 30000;
            RefreshModeCheck(sender);
        }

        private void 低ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshWatch.Interval = 60000;
            RefreshModeCheck(sender);
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefreshModeCheck(sender);
        }

        private void RefreshModeCheck(object sender)
        {
            高ToolStripMenuItem.Checked = false;
            正常ToolStripMenuItem.Checked = false;
            低ToolStripMenuItem.Checked = false;
            暂停ToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;
            if(sender.ToString() == "暂停")
            {
                RefreshWatch.Enabled = false;
            }
            else
                RefreshWatch.Enabled = true;
        }

        private void CloseProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems[0].Index < 0)
                return;
            ListViewItem CloseItem = ProcessListView.SelectedItems[0];
            string CloseName = CloseItem.Text;
            int ClosePID = int.Parse(CloseItem.SubItems[1].Text);
            Process CloseProcess = new Process();
            try
            {
                CloseProcess = Process.GetProcessById(ClosePID);
                CloseProcess.Kill();
                MessageBox.Show("进程名为"+ CloseName + "，PID为" + ClosePID + "的进程已被关闭！");
                GetProcessInfo();
            }
            catch(Win32Exception WE)
            {
                MessageBox.Show(WE.Message,"Win32Exception");
            }
            catch(InvalidOperationException IOE)
            {
                MessageBox.Show(IOE.Message,"InvalidOperationException");
            }
        }

        private void 实时ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem ChangePrioityItem = ProcessListView.SelectedItems[0];
                int ChangePrioityPID = int.Parse(ChangePrioityItem.SubItems[1].Text);
                Process ChangePrioityProcess = new Process();
                ChangePrioityProcess = Process.GetProcessById(ChangePrioityPID);
                ChangePrioityProcess.PriorityClass = ProcessPriorityClass.RealTime;
            }
            catch (Win32Exception WE)
            {
                MessageBox.Show("Sorry,process priority information could not be set or retrieved from the associated process resource.\n" +
                                "Or this process has not been started.\n\n" +
                                WE.Message
                    );
            }
        }

        private void 高ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem ChangePrioityItem = ProcessListView.SelectedItems[0];
                int ChangePrioityPID = int.Parse(ChangePrioityItem.SubItems[1].Text);
                Process ChangePrioityProcess = new Process();
                ChangePrioityProcess = Process.GetProcessById(ChangePrioityPID);
                ChangePrioityProcess.PriorityClass = ProcessPriorityClass.High;
            }
            catch (Win32Exception WE)
            {
                MessageBox.Show("Sorry,process priority information could not be set or retrieved from the associated process resource.\n" +
                                "Or this process has not been started.\n\n" +
                                WE.Message
                    );
            }
        }

        private void 正常ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem ChangePrioityItem = ProcessListView.SelectedItems[0];
                int ChangePrioityPID = int.Parse(ChangePrioityItem.SubItems[1].Text);
                Process ChangePrioityProcess = new Process();
                ChangePrioityProcess = Process.GetProcessById(ChangePrioityPID);
                ChangePrioityProcess.PriorityClass = ProcessPriorityClass.Normal;
            }
            catch (Win32Exception WE)
            {
                MessageBox.Show("Sorry,process priority information could not be set or retrieved from the associated process resource.\n" +
                                "Or this process has not been started.\n\n" +
                                WE.Message
                    );
            }
        }

        private void 低ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem ChangePrioityItem = ProcessListView.SelectedItems[0];
                int ChangePrioityPID = int.Parse(ChangePrioityItem.SubItems[1].Text);
                Process ChangePrioityProcess = new Process();
                ChangePrioityProcess = Process.GetProcessById(ChangePrioityPID);
                ChangePrioityProcess.PriorityClass = ProcessPriorityClass.Idle;
            }
            catch (Win32Exception WE)
            {
                MessageBox.Show("Sorry,process priority information could not be set or retrieved from the associated process resource.\n" +
                                "Or this process has not been started.\n\n" +
                                WE.Message
                    );
            }
        }

        // https://www.codeproject.com/Articles/23330/Handling-Right-Click-Events-in-ListView-Column-Hea
        // Many Thanks!
        private Rectangle _headerRect;
        private delegate bool EnumWinCallBack(IntPtr hwnd, IntPtr lParam);
        [DllImport("user32.Dll")]
        private static extern int EnumChildWindows(
            IntPtr hWndParent,
            EnumWinCallBack callBackFunc,
            IntPtr lParam);
        [DllImport("user32.Dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
        private bool EnumWindowCallBack(IntPtr hwnd, IntPtr lParam)
        {
            RECT rct;
            if (!GetWindowRect(hwnd, out rct))
            {
                _headerRect = Rectangle.Empty;
            }
            else
            {
                _headerRect = new Rectangle(
                rct.Left, rct.Top, rct.Right - rct.Left, rct.Bottom - rct.Top);
            }
            return false; // Stop the enum
        }

        private void ProcessListRightClickMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // This call indirectly calls EnumWindowCallBack which sets _headerRect
            // to the area occupied by the ListView's header bar.
            EnumChildWindows(
                ProcessListView.Handle, new EnumWinCallBack(EnumWindowCallBack), IntPtr.Zero);
            // If the mouse position is in the header bar, cancel the display
            // of the context menu.
            if (_headerRect.Contains(Control.MousePosition))
            {
                e.Cancel = true;
                /*
                if (ProcessListView.Sorting == SortOrder.Descending)
                {
                    ProcessListView.Sorting = SortOrder.None;
                    toolStripStatusLabel2.Text = "排序方式: 无序";
                    refresh();
                }
                else if(ProcessListView.Sorting == SortOrder.Ascending)
                {
                    ProcessListView.Sorting = SortOrder.Descending;
                    toolStripStatusLabel2.Text = "排序方式: 降序";
                    refresh();
                }
                else
                {
                    ProcessListView.Sorting = SortOrder.Ascending;
                    toolStripStatusLabel2.Text = "排序方式: 升序";
                    refresh();
                }
                */
            }
        }

        private void 无序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessListView.Sorting = SortOrder.None;
            toolStripStatusLabel2.Text = "排序方式: 无序";
            SortModeCheck(sender);
            ProcessListView.Refresh();
        }

        private void 升序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessListView.Sorting = SortOrder.Ascending;
            toolStripStatusLabel2.Text = "排序方式: 升序";
            SortModeCheck(sender);
            ProcessListView.Refresh();
        }

        private void 降序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessListView.Sorting = SortOrder.Descending;
            toolStripStatusLabel2.Text = "排序方式: 降序";
            SortModeCheck(sender);
            ProcessListView.Refresh();
        }

        private void SortModeCheck(object sender)
        {
            无序ToolStripMenuItem.Checked = false;
            升序ToolStripMenuItem.Checked = false;
            降序ToolStripMenuItem.Checked = false;
            ((ToolStripMenuItem)sender).Checked = true;
            ((ToolStripMenuItem)sender).CheckState = CheckState.Checked;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //PROCESS_BASIC_INFORMATION struct in p/invoke
        [StructLayout(LayoutKind.Sequential)]
        public struct ParentProcessUtilities
        {
            internal IntPtr ExitStatus;
            internal IntPtr PebBaseAddress;
            internal IntPtr AffinityMask;
            internal IntPtr BasePriority;
            internal UIntPtr UniqueProcessId;
            internal IntPtr InheritedFromUniqueProcessId;
            public int Size
            {
                get
                {
                    return (int)Marshal.SizeOf(typeof(ParentProcessUtilities));
                }
            }
            [DllImport("ntdll.dll")]
            private static extern int NtQueryInformationProcess(IntPtr ProcessHandle,
                int ProcessInformationClass,
                ref ParentProcessUtilities ProcessInformation,
                int ProcessInformationLength,
                out int ReturnLength);
            public static Process GetParentProcess(IntPtr handle)
            {
                ParentProcessUtilities ParentBasicInformation = new ParentProcessUtilities();
                int ReturnLength;
                int status = NtQueryInformationProcess(handle,0,ref ParentBasicInformation,
                    Marshal.SizeOf(ParentBasicInformation),out ReturnLength);
                if (status != 0)
                    throw new Win32Exception(status);
                try
                {
                    return Process.GetProcessById(ParentBasicInformation.InheritedFromUniqueProcessId.ToInt32());
                }
                catch(ArgumentException)
                {
                    return null;
                }
            }
            public static Process GetParentProcess()
            {
                return GetParentProcess(Process.GetCurrentProcess().Handle);
            }
            public static Process GetParentProcess(int Pid)
            {
                Process process = Process.GetProcessById(Pid);
                return GetParentProcess(process.Handle);
            }
        }
        //uses pinvoke,fast but may be a troublemaker
        private void 查看父进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems[0].Index < 0)
                return;
            ListViewItem CurrentItem = ProcessListView.SelectedItems[0];
            string CurrentName = CurrentItem.Text;
            int CurrentPID = int.Parse(CurrentItem.SubItems[1].Text);
            try
            {
                Process ParentProcess = ParentProcessUtilities.GetParentProcess(CurrentPID);
                if(ParentProcess == null)
                {
                    MessageBox.Show("无父进程。", "查找结果");
                }
                else
                    MessageBox.Show("父进程名： " + ParentProcess.ProcessName+"\nPID: "+ParentProcess.Id.ToString()+"\n","查找结果");
            }
            catch
            {
                MessageBox.Show("查找失败。","错误");
            }
        }

        //use WMI,super slow
        private void 查看子进程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ProcessListView.SelectedItems[0].Index < 0)
                return;
            ListViewItem CurrentItem = ProcessListView.SelectedItems[0];
            string CurrentName = CurrentItem.Text;
            int CurrentPID = int.Parse(CurrentItem.SubItems[1].Text);
            try
            {
                ManagementObjectSearcher ChildProcessSearch = new ManagementObjectSearcher(
                    "select * from win32_process where ParentProcessId=" + CurrentPID);
                ManagementObjectCollection ChildProcessCollection = ChildProcessSearch.Get();
                if(ChildProcessCollection.Count > 0)
                {
                    string output = null;
                    foreach (var ChildProcess in ChildProcessCollection)
                    {
                        output += "子进程名： ";
                        output += ChildProcess["Name"].ToString();
                        output += "\nPID: ";
                        output += ((UInt32)ChildProcess["ProcessId"]).ToString();
                        output += "\n";
                    }
                    MessageBox.Show(output, "查找结果");
                }
                else
                {
                    MessageBox.Show("无子进程。", "查找结果");
                }
            }
            catch
            {
                MessageBox.Show("查找失败。", "错误");
            }
        }
    }
}
