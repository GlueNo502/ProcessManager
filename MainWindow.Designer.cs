namespace ProcessManager
{
    partial class MainWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.运行新任务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessListView = new System.Windows.Forms.ListView();
            this.ProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RunningStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BasePriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MemoryUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPUUsage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProcessListRightClickMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CloseProcessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置优先级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.实时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.正常ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.低ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.查看父进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看子进程ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.立即刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.高ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.低ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排序方式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.升序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.降序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProcessListRightClickMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 文件ToolStripMenuItem
            // 
            文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.运行新任务ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            文件ToolStripMenuItem.Text = "文件";
            // 
            // 运行新任务ToolStripMenuItem
            // 
            this.运行新任务ToolStripMenuItem.Name = "运行新任务ToolStripMenuItem";
            this.运行新任务ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.运行新任务ToolStripMenuItem.Text = "运行新任务";
            this.运行新任务ToolStripMenuItem.Click += new System.EventHandler(this.运行新任务ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // ProcessListView
            // 
            this.ProcessListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProcessName,
            this.ProcessID,
            this.RunningStatus,
            this.BasePriority,
            this.MemoryUsage,
            this.CPUUsage});
            this.ProcessListView.ContextMenuStrip = this.ProcessListRightClickMenu;
            this.ProcessListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessListView.FullRowSelect = true;
            this.ProcessListView.GridLines = true;
            this.ProcessListView.Location = new System.Drawing.Point(0, 28);
            this.ProcessListView.Name = "ProcessListView";
            this.ProcessListView.Size = new System.Drawing.Size(800, 422);
            this.ProcessListView.SmallImageList = this.ProcessImageList;
            this.ProcessListView.TabIndex = 0;
            this.ProcessListView.UseCompatibleStateImageBehavior = false;
            this.ProcessListView.View = System.Windows.Forms.View.Details;
            // 
            // ProcessName
            // 
            this.ProcessName.Text = "进程名称";
            this.ProcessName.Width = 120;
            // 
            // ProcessID
            // 
            this.ProcessID.Text = "进程编号PID";
            this.ProcessID.Width = 78;
            // 
            // RunningStatus
            // 
            this.RunningStatus.Text = "运行状态";
            // 
            // BasePriority
            // 
            this.BasePriority.Text = "基本优先级";
            this.BasePriority.Width = 72;
            // 
            // MemoryUsage
            // 
            this.MemoryUsage.Text = "物理内存占用";
            this.MemoryUsage.Width = 84;
            // 
            // CPUUsage
            // 
            this.CPUUsage.Text = "CPU利用率";
            this.CPUUsage.Width = 460;
            // 
            // ProcessListRightClickMenu
            // 
            this.ProcessListRightClickMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ProcessListRightClickMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseProcessToolStripMenuItem,
            this.设置优先级ToolStripMenuItem,
            this.查看父进程ToolStripMenuItem,
            this.查看子进程ToolStripMenuItem});
            this.ProcessListRightClickMenu.Name = "ProcessListRightClickMenu";
            this.ProcessListRightClickMenu.Size = new System.Drawing.Size(154, 100);
            this.ProcessListRightClickMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ProcessListRightClickMenu_Opening);
            // 
            // CloseProcessToolStripMenuItem
            // 
            this.CloseProcessToolStripMenuItem.Name = "CloseProcessToolStripMenuItem";
            this.CloseProcessToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.CloseProcessToolStripMenuItem.Text = "关闭进程";
            this.CloseProcessToolStripMenuItem.Click += new System.EventHandler(this.CloseProcessToolStripMenuItem_Click);
            // 
            // 设置优先级ToolStripMenuItem
            // 
            this.设置优先级ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.实时ToolStripMenuItem,
            this.高ToolStripMenuItem1,
            this.正常ToolStripMenuItem1,
            this.低ToolStripMenuItem1});
            this.设置优先级ToolStripMenuItem.Name = "设置优先级ToolStripMenuItem";
            this.设置优先级ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.设置优先级ToolStripMenuItem.Text = "设置优先级";
            // 
            // 实时ToolStripMenuItem
            // 
            this.实时ToolStripMenuItem.Name = "实时ToolStripMenuItem";
            this.实时ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.实时ToolStripMenuItem.Text = "实时";
            // 
            // 高ToolStripMenuItem1
            // 
            this.高ToolStripMenuItem1.Name = "高ToolStripMenuItem1";
            this.高ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.高ToolStripMenuItem1.Text = "高";
            this.高ToolStripMenuItem1.Click += new System.EventHandler(this.高ToolStripMenuItem1_Click);
            // 
            // 正常ToolStripMenuItem1
            // 
            this.正常ToolStripMenuItem1.Name = "正常ToolStripMenuItem1";
            this.正常ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.正常ToolStripMenuItem1.Text = "正常";
            this.正常ToolStripMenuItem1.Click += new System.EventHandler(this.正常ToolStripMenuItem1_Click);
            // 
            // 低ToolStripMenuItem1
            // 
            this.低ToolStripMenuItem1.Name = "低ToolStripMenuItem1";
            this.低ToolStripMenuItem1.Size = new System.Drawing.Size(114, 26);
            this.低ToolStripMenuItem1.Text = "低";
            this.低ToolStripMenuItem1.Click += new System.EventHandler(this.低ToolStripMenuItem1_Click);
            // 
            // 查看父进程ToolStripMenuItem
            // 
            this.查看父进程ToolStripMenuItem.Name = "查看父进程ToolStripMenuItem";
            this.查看父进程ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.查看父进程ToolStripMenuItem.Text = "查看父进程";
            this.查看父进程ToolStripMenuItem.Click += new System.EventHandler(this.查看父进程ToolStripMenuItem_Click);
            // 
            // 查看子进程ToolStripMenuItem
            // 
            this.查看子进程ToolStripMenuItem.Name = "查看子进程ToolStripMenuItem";
            this.查看子进程ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.查看子进程ToolStripMenuItem.Text = "查看子进程";
            this.查看子进程ToolStripMenuItem.Click += new System.EventHandler(this.查看子进程ToolStripMenuItem_Click);
            // 
            // ProcessImageList
            // 
            this.ProcessImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.ProcessImageList.ImageSize = new System.Drawing.Size(16, 16);
            this.ProcessImageList.TransparentColor = System.Drawing.SystemColors.Window;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.立即刷新ToolStripMenuItem,
            this.更新速度ToolStripMenuItem,
            this.排序方式ToolStripMenuItem});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 立即刷新ToolStripMenuItem
            // 
            this.立即刷新ToolStripMenuItem.Name = "立即刷新ToolStripMenuItem";
            this.立即刷新ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.立即刷新ToolStripMenuItem.Text = "立即刷新";
            this.立即刷新ToolStripMenuItem.Click += new System.EventHandler(this.立即刷新ToolStripMenuItem_Click);
            // 
            // 更新速度ToolStripMenuItem
            // 
            this.更新速度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.高ToolStripMenuItem,
            this.正常ToolStripMenuItem,
            this.低ToolStripMenuItem,
            this.暂停ToolStripMenuItem});
            this.更新速度ToolStripMenuItem.Name = "更新速度ToolStripMenuItem";
            this.更新速度ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.更新速度ToolStripMenuItem.Text = "更新频率";
            // 
            // 高ToolStripMenuItem
            // 
            this.高ToolStripMenuItem.Name = "高ToolStripMenuItem";
            this.高ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.高ToolStripMenuItem.Text = "高";
            this.高ToolStripMenuItem.Click += new System.EventHandler(this.高ToolStripMenuItem_Click);
            // 
            // 正常ToolStripMenuItem
            // 
            this.正常ToolStripMenuItem.Checked = true;
            this.正常ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.正常ToolStripMenuItem.Name = "正常ToolStripMenuItem";
            this.正常ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.正常ToolStripMenuItem.Text = "正常";
            this.正常ToolStripMenuItem.Click += new System.EventHandler(this.正常ToolStripMenuItem_Click);
            // 
            // 低ToolStripMenuItem
            // 
            this.低ToolStripMenuItem.Name = "低ToolStripMenuItem";
            this.低ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.低ToolStripMenuItem.Text = "低";
            this.低ToolStripMenuItem.Click += new System.EventHandler(this.低ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 排序方式ToolStripMenuItem
            // 
            this.排序方式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.无序ToolStripMenuItem,
            this.升序ToolStripMenuItem,
            this.降序ToolStripMenuItem});
            this.排序方式ToolStripMenuItem.Name = "排序方式ToolStripMenuItem";
            this.排序方式ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.排序方式ToolStripMenuItem.Text = "排序方式";
            // 
            // 无序ToolStripMenuItem
            // 
            this.无序ToolStripMenuItem.Checked = true;
            this.无序ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.无序ToolStripMenuItem.Name = "无序ToolStripMenuItem";
            this.无序ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.无序ToolStripMenuItem.Text = "无序";
            this.无序ToolStripMenuItem.Click += new System.EventHandler(this.无序ToolStripMenuItem_Click);
            // 
            // 升序ToolStripMenuItem
            // 
            this.升序ToolStripMenuItem.Name = "升序ToolStripMenuItem";
            this.升序ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.升序ToolStripMenuItem.Text = "升序";
            this.升序ToolStripMenuItem.Click += new System.EventHandler(this.升序ToolStripMenuItem_Click);
            // 
            // 降序ToolStripMenuItem
            // 
            this.降序ToolStripMenuItem.Name = "降序ToolStripMenuItem";
            this.降序ToolStripMenuItem.Size = new System.Drawing.Size(114, 26);
            this.降序ToolStripMenuItem.Text = "降序";
            this.降序ToolStripMenuItem.Click += new System.EventHandler(this.降序ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 20);
            this.toolStripStatusLabel1.Text = "进程数: 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(107, 20);
            this.toolStripStatusLabel2.Text = "排序方式: 无序";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProcessListView);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "进程管理器";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SizeChanged += new System.EventHandler(this.MainWindow_SizeChanged);
            this.ProcessListRightClickMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ProcessListView;
        private System.Windows.Forms.ColumnHeader ProcessName;
        private System.Windows.Forms.ColumnHeader ProcessID;
        private System.Windows.Forms.ColumnHeader RunningStatus;
        private System.Windows.Forms.ColumnHeader BasePriority;
        private System.Windows.Forms.ColumnHeader MemoryUsage;
        private System.Windows.Forms.ColumnHeader CPUUsage;
        private System.Windows.Forms.ImageList ProcessImageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 立即刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 运行新任务ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 更新速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 低ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ProcessListRightClickMenu;
        private System.Windows.Forms.ToolStripMenuItem CloseProcessToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置优先级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 正常ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 低ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 实时ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem 排序方式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 升序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 降序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看父进程ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看子进程ToolStripMenuItem;
    }
}