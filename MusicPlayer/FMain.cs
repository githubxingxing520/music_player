using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MusicPlayer
{
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }
        List<double> listLrcTime = new List<double>();//存放歌词时间
        List<string> listLrc = new List<string>();//存放歌词
        #region 初始化窗体
        private void FMain_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = @"skin\Wave.ssk";
            picBoxfengmian.Image = Image.FromFile(@"image\封面.jpg");
            picHengf.Image = Image.FromFile(@"image\hengfu.jpg");
            picBoxfengmian.SizeMode = PictureBoxSizeMode.Zoom;

        }
        #endregion

        #region 一键换肤
        int i = 0;
        private void btnChangeSkin_Click(object sender, EventArgs e)
        {
            string[] dir = Directory.GetFiles(@"skin");
            i++;
            if (i == dir.Length)
            {
                i = 0;
            }
            skinEngine1.SkinFile = dir[i];
        } 
        #endregion

        #region 暂停or播放
        private void btnStartOrPause_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                MessageBox.Show("请选择音乐文件", "提示");
                return;
            }
            //如果是播放状态就暂停，如果是暂停状态就播放
            if (btnStartOrPause.Text == "播放")
            {
                MediaPlayer.Ctlcontrols.play();
                btnStartOrPause.Text = "暂停";
            }
            else
            {
                MediaPlayer.Ctlcontrols.pause();
                btnStartOrPause.Text = "播放";
            }
        }
        #endregion

        #region 导入歌曲
        List<string> listFilePath = new List<string>();//存放所有导入歌曲的完整路径
        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Title = "请选择音乐文件";
            ofd.Filter = "MP3文件|*.mp3|MP4文件|*.mp4|所有文件|*.*";
            ofd.InitialDirectory = @"C:\Users\Administrator\Desktop";
            ofd.ShowDialog();
            string[] filePath = ofd.FileNames;//获取用户选择的文件
            for (int i = 0; i < filePath.Length; i++)
            {
                listFilePath.Add(filePath[i]); //把文件全路径存放到list集合里面
                if(listBoxMusic.Items.Contains(Path.GetFileName(filePath[i])))
                {
                    return;
                }
                listBoxMusic.Items.Add(Path.GetFileName(filePath[i]));
            }
        } 
        #endregion

        #region 双击列表歌曲播放
        private void listBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                return;
            }
            string ext=Path.GetExtension(listFilePath[listBoxMusic.SelectedIndex]);
            if (ext==".mp4")
            {
                picBoxfengmian.Visible = false;
            }
            if(ext==".mp3")
            {
                picBoxfengmian.Visible = true;
            }
            btnStartOrPause.Text = "暂停";
            MediaPlayer.URL = listFilePath[listBoxMusic.SelectedIndex];
            MediaPlayer.Ctlcontrols.play();
            LoadLrc();//加载歌词

        } 
        #endregion

        #region 停止播放
        private void btnStop_Click(object sender, EventArgs e)
        {
            MediaPlayer.Ctlcontrols.stop();
            btnStartOrPause.Text = "播放";
        }
        #endregion

        #region 上一曲
        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                return;
            }
            int index = listBoxMusic.SelectedIndex;//获取当前选中的索引
            index--;
            listBoxMusic.SelectedIndices.Clear();//清空所有选中项
            if (index < 0)
            {
                index = listBoxMusic.Items.Count - 1;
            }
            listBoxMusic.SelectedIndex = index;
            MediaPlayer.URL = listFilePath[index];
            LoadLrc();
        }
        #endregion

        #region 下一曲
        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                return;
            }
            int index = listBoxMusic.SelectedIndex;//获取当前选中的索引
            index++;
            listBoxMusic.SelectedIndices.Clear();
            if (index >listBoxMusic.Items.Count-1)
            {
                index = 0;
            }
            listBoxMusic.SelectedIndex = index;
            MediaPlayer.URL = listFilePath[index];
            LoadLrc();
        }
        #endregion

        #region 多选删除
        private void contextMenuStrip_Click(object sender, EventArgs e)
        {
            int count = listBoxMusic.SelectedItems.Count;//获取所有选中项数量
            for (int i=0;i<count;i++)
            {
                listFilePath.RemoveAt(listBoxMusic.SelectedIndex);
                listBoxMusic.Items.RemoveAt(listBoxMusic.SelectedIndex);
            }
        }
        #endregion

        #region 自动下一曲
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MediaPlayer.playState==WMPLib.WMPPlayState.wmppsPlaying)//如果当前播放器正在播放状态
            {
                timerAutoPic.Enabled = true;
                labTotalTime.Text = MediaPlayer.currentMedia.durationString;//总时长
                labNowTime.Text = MediaPlayer.Ctlcontrols.currentPositionString;//当前播放时间
                //如果歌曲总时长-当前播放时长小于1就自动播放下一曲
                if (MediaPlayer.currentMedia.duration-MediaPlayer.Ctlcontrols.currentPosition<=1)
                {
                    int index = listBoxMusic.SelectedIndex;//获取当前选中的索引
                    index++;
                    listBoxMusic.SelectedIndices.Clear();//清空选择项
                    if (index > listBoxMusic.Items.Count - 1)
                    {
                        index = 0;
                    }
                    listBoxMusic.SelectedIndex = index;
                    MediaPlayer.URL = listFilePath[index];
                    LoadLrc();
                }
            }
        }
        #endregion

        #region 快进
        private void btnSpeed_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                return;
            }
            MediaPlayer.Ctlcontrols.currentPosition += 2;
        }
        #endregion

        #region 快退
        private void btnRewind_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedIndex < 0)
            {
                return;
            }
            MediaPlayer.Ctlcontrols.currentPosition -= 2;
        }
        #endregion

        #region 加载歌词
        private void LoadLrc()
        {
            listLrcTime.Clear();//清空前首歌词时间
            listLrc.Clear();//清空前首歌词
            string songPath = listFilePath[listBoxMusic.SelectedIndex];
            string lrcPath = Path.GetDirectoryName(songPath) + "\\" + Path.GetFileNameWithoutExtension(songPath) + ".lrc";
            if (File.Exists(lrcPath))
            {
                //[00:01.93]画风
                string[] lrcAllLines = File.ReadAllLines(lrcPath, Encoding.UTF8);
                for (int i = 0; i < lrcAllLines.Length; i++)
                {
                    try
                    {
                        //00:01.93 画风
                        string[] lrc = lrcAllLines[i].Split(new char[] { '[', ']' }, StringSplitOptions.None);
                        listLrc.Add(lrc[2]);//把歌词存进集合
                                            //00 01.93
                        string[] lrcTemp = lrc[1].Split(new char[] { ':' }, StringSplitOptions.None);
                        double time = double.Parse(lrcTemp[0]) * 60 + double.Parse(lrcTemp[1]);
                        listLrcTime.Add(time);//把歌词时间存入集合
                    }
                    catch { }
                }
            }
            else
            {
                labLrc.Text = "*********未找到歌词文件*********";
            }
        }

        #endregion

        #region 播放歌词
        private void timerLrc_Tick(object sender, EventArgs e)
        {
            //如果集合中没有数据就不执行后面的
            if(listLrcTime.Count==0)
            {
                return;
            }
            double timeNow = MediaPlayer.Ctlcontrols.currentPosition;//当前播放时长
            for (int i = 0; i < listLrcTime.Count-1; i++)
            {
                //如果当前播放时长>=集合中第一项<第二项就播放第一条歌词
                if (timeNow >= listLrcTime[i] && timeNow < listLrcTime[i + 1])
                {
                    labLrc.Text = listLrc[i];
                }
            }
        }

        #endregion

        #region 音量控制
        private void trbChange_ValueChanged(object sender, EventArgs e)
        {
            MediaPlayer.settings.volume = trbChange.Value;
        }
        #endregion
        #region 轮播图
        int j = 0;
        private void timerAutoPic_Tick(object sender, EventArgs e)
        {
            string[] imagePath = Directory.GetFiles(@"image");
            picBoxfengmian.Image = Image.FromFile(imagePath[j]);
            picBoxfengmian.SizeMode = PictureBoxSizeMode.StretchImage;
            j++;
            if (j == imagePath.Length)
            {
                j = 0;
            }

        }
        #endregion

        #region 窗体最小化到托盘
        private void FMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized) //窗体是否最小化
            {
                this.ShowInTaskbar = false; //不显示在任务栏
                notifyIcon.Visible = true;  //通知栏显示
            }
        }
        #endregion

        #region 双击托盘图标最大化
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState== FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Normal;//恢复默认窗口
                this.Activate();//激活窗体
                notifyIcon.Visible = false; //托盘图标隐藏
                this.ShowInTaskbar = true;//任务栏可见
            }
        }
        #endregion

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result= MessageBox.Show("是否确认退出程序?", "退出", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result== DialogResult.OK)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;//取消事件
            }
        }

        #region 显示窗体
        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
        #endregion

        #region 退出
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        } 
        #endregion
    }
}
