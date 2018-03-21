namespace MusicPlayer
{
    partial class FMain
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMain));
            this.skinEngine1 = new Sunisoft.IrisSkin.SkinEngine(((System.ComponentModel.Component)(this)));
            this.btnChangeSkin = new System.Windows.Forms.Button();
            this.picBoxfengmian = new System.Windows.Forms.PictureBox();
            this.btnStartOrPause = new System.Windows.Forms.Button();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除歌曲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerAutoNext = new System.Windows.Forms.Timer(this.components);
            this.labTotalTime = new System.Windows.Forms.Label();
            this.btnSpeed = new System.Windows.Forms.Button();
            this.btnRewind = new System.Windows.Forms.Button();
            this.picHengf = new System.Windows.Forms.PictureBox();
            this.labLrc = new System.Windows.Forms.Label();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.timerLrc = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trbChange = new System.Windows.Forms.TrackBar();
            this.labNowTime = new System.Windows.Forms.Label();
            this.timerAutoPic = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxfengmian)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHengf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbChange)).BeginInit();
            this.notifyMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinEngine1
            // 
            this.skinEngine1.SerialNumber = "";
            this.skinEngine1.SkinFile = null;
            // 
            // btnChangeSkin
            // 
            this.btnChangeSkin.Location = new System.Drawing.Point(23, 68);
            this.btnChangeSkin.Name = "btnChangeSkin";
            this.btnChangeSkin.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSkin.TabIndex = 0;
            this.btnChangeSkin.Text = "一键换肤";
            this.btnChangeSkin.UseVisualStyleBackColor = true;
            this.btnChangeSkin.Click += new System.EventHandler(this.btnChangeSkin_Click);
            // 
            // picBoxfengmian
            // 
            this.picBoxfengmian.Location = new System.Drawing.Point(1, -1);
            this.picBoxfengmian.Name = "picBoxfengmian";
            this.picBoxfengmian.Size = new System.Drawing.Size(354, 255);
            this.picBoxfengmian.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxfengmian.TabIndex = 2;
            this.picBoxfengmian.TabStop = false;
            // 
            // btnStartOrPause
            // 
            this.btnStartOrPause.Location = new System.Drawing.Point(23, 103);
            this.btnStartOrPause.Name = "btnStartOrPause";
            this.btnStartOrPause.Size = new System.Drawing.Size(75, 23);
            this.btnStartOrPause.TabIndex = 3;
            this.btnStartOrPause.Text = "播放";
            this.btnStartOrPause.UseVisualStyleBackColor = true;
            this.btnStartOrPause.Click += new System.EventHandler(this.btnStartOrPause_Click);
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.ContextMenuStrip = this.contextMenuStrip;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.ItemHeight = 12;
            this.listBoxMusic.Location = new System.Drawing.Point(495, -1);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxMusic.Size = new System.Drawing.Size(149, 340);
            this.listBoxMusic.TabIndex = 4;
            this.listBoxMusic.DoubleClick += new System.EventHandler(this.listBoxMusic_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除歌曲ToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(125, 26);
            this.contextMenuStrip.Click += new System.EventHandler(this.contextMenuStrip_Click);
            // 
            // 删除歌曲ToolStripMenuItem
            // 
            this.删除歌曲ToolStripMenuItem.Name = "删除歌曲ToolStripMenuItem";
            this.删除歌曲ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除歌曲ToolStripMenuItem.Text = "删除歌曲";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(23, 33);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 5;
            this.btnImport.Text = "导入音乐";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(23, 173);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(75, 23);
            this.btnUp.TabIndex = 6;
            this.btnUp.Text = "上一曲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(23, 208);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(75, 23);
            this.btnDown.TabIndex = 6;
            this.btnDown.Text = "下一曲";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(23, 138);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerAutoNext
            // 
            this.timerAutoNext.Enabled = true;
            this.timerAutoNext.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labTotalTime
            // 
            this.labTotalTime.AutoSize = true;
            this.labTotalTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labTotalTime.Location = new System.Drawing.Point(274, 306);
            this.labTotalTime.Name = "labTotalTime";
            this.labTotalTime.Size = new System.Drawing.Size(0, 12);
            this.labTotalTime.TabIndex = 9;
            // 
            // btnSpeed
            // 
            this.btnSpeed.Location = new System.Drawing.Point(314, 300);
            this.btnSpeed.Name = "btnSpeed";
            this.btnSpeed.Size = new System.Drawing.Size(37, 23);
            this.btnSpeed.TabIndex = 10;
            this.btnSpeed.Text = "快进";
            this.btnSpeed.UseVisualStyleBackColor = true;
            this.btnSpeed.Click += new System.EventHandler(this.btnSpeed_Click);
            // 
            // btnRewind
            // 
            this.btnRewind.Location = new System.Drawing.Point(8, 300);
            this.btnRewind.Name = "btnRewind";
            this.btnRewind.Size = new System.Drawing.Size(37, 23);
            this.btnRewind.TabIndex = 10;
            this.btnRewind.Text = "快退";
            this.btnRewind.UseVisualStyleBackColor = true;
            this.btnRewind.Click += new System.EventHandler(this.btnRewind_Click);
            // 
            // picHengf
            // 
            this.picHengf.Location = new System.Drawing.Point(1, 269);
            this.picHengf.Name = "picHengf";
            this.picHengf.Size = new System.Drawing.Size(354, 28);
            this.picHengf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHengf.TabIndex = 11;
            this.picHengf.TabStop = false;
            // 
            // labLrc
            // 
            this.labLrc.AutoSize = true;
            this.labLrc.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labLrc.Location = new System.Drawing.Point(97, 273);
            this.labLrc.Name = "labLrc";
            this.labLrc.Size = new System.Drawing.Size(0, 20);
            this.labLrc.TabIndex = 12;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(1, -1);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(354, 299);
            this.MediaPlayer.TabIndex = 1;
            // 
            // timerLrc
            // 
            this.timerLrc.Enabled = true;
            this.timerLrc.Tick += new System.EventHandler(this.timerLrc_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trbChange);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnDown);
            this.groupBox1.Controls.Add(this.btnUp);
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnStartOrPause);
            this.groupBox1.Controls.Add(this.btnChangeSkin);
            this.groupBox1.Location = new System.Drawing.Point(362, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(124, 295);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功能菜单";
            // 
            // trbChange
            // 
            this.trbChange.Location = new System.Drawing.Point(10, 243);
            this.trbChange.Maximum = 100;
            this.trbChange.Name = "trbChange";
            this.trbChange.Size = new System.Drawing.Size(104, 45);
            this.trbChange.TabIndex = 14;
            this.trbChange.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbChange.Value = 20;
            this.trbChange.ValueChanged += new System.EventHandler(this.trbChange_ValueChanged);
            // 
            // labNowTime
            // 
            this.labNowTime.AutoSize = true;
            this.labNowTime.Location = new System.Drawing.Point(56, 306);
            this.labNowTime.Name = "labNowTime";
            this.labNowTime.Size = new System.Drawing.Size(0, 12);
            this.labNowTime.TabIndex = 14;
            // 
            // timerAutoPic
            // 
            this.timerAutoPic.Interval = 10000;
            this.timerAutoPic.Tick += new System.EventHandler(this.timerAutoPic_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "个人音乐播放器";
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(101, 48);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 342);
            this.Controls.Add(this.labNowTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labLrc);
            this.Controls.Add(this.picHengf);
            this.Controls.Add(this.btnRewind);
            this.Controls.Add(this.btnSpeed);
            this.Controls.Add(this.labTotalTime);
            this.Controls.Add(this.listBoxMusic);
            this.Controls.Add(this.picBoxfengmian);
            this.Controls.Add(this.MediaPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音乐播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.SizeChanged += new System.EventHandler(this.FMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxfengmian)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHengf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbChange)).EndInit();
            this.notifyMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Sunisoft.IrisSkin.SkinEngine skinEngine1;
        private System.Windows.Forms.Button btnChangeSkin;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.PictureBox picBoxfengmian;
        private System.Windows.Forms.Button btnStartOrPause;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 删除歌曲ToolStripMenuItem;
        private System.Windows.Forms.Timer timerAutoNext;
        private System.Windows.Forms.Label labTotalTime;
        private System.Windows.Forms.Button btnSpeed;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.PictureBox picHengf;
        private System.Windows.Forms.Label labLrc;
        private System.Windows.Forms.Timer timerLrc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar trbChange;
        private System.Windows.Forms.Label labNowTime;
        private System.Windows.Forms.Timer timerAutoPic;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}

