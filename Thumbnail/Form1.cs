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
using System.Drawing.Drawing2D;

namespace Thumbnail
{
    public partial class Form1 : Form
    {
        List<string> fail = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            //計時
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Reset();//碼表歸零
            sw.Start();//碼表開始計時

            if (destinationDir.Text == "" || selectDir.Text == "")
            {
                MessageBox.Show("資料夾路徑不可為空 σ(oдolll)", "[提醒]");
                return;
            }
            else if (destinationDir.Text == selectDir.Text)
            {
                MessageBox.Show("[目地] 與 [開啟] 資料夾不可相同 σ(oдolll)", "[提醒]");
                return;
            }
            else if (pictureListView.Items.Count == 0)
            {
                MessageBox.Show("並沒有取得任何圖片可以轉換，請調整位置 σ(oдolll)", "[提醒]");
                return;
            }
         
            //MSG
            messageList.Items.Clear();
            messageList.Items.Add("檔案數量:" + pictureListView.Items.Count);
            messageList.Items.Add("進行轉換中...");
            //取得正確路徑
            if(destinationDir.Text.Substring(destinationDir.Text.Length-1,1)== @"\")
            {
                destinationDir.Text = destinationDir.Text.Substring(0, destinationDir.Text.Length - 1);
            }
            if (selectDir.Text.Substring(selectDir.Text.Length - 1, 1) == @"\")
            {
                selectDir.Text = selectDir.Text.Substring(0, selectDir.Text.Length - 1);
            }

            string d_Dir = destinationDir.Text;
            string s_Dir = selectDir.Text;
            //清除錯誤清單
            fail.Clear();
            fail.Add("轉換錯誤清單(Fail):");
            fail.Add("日期:"+DateTime.Now.ToShortDateString() + ' ' + DateTime.Now.ToString("HH:mm ss tt"));
            fail.Add("來源資料夾:"+s_Dir);
            fail.Add("目的資料夾:"+d_Dir);
            fail.Add("------------------------------------------------");
            //初始化當前進度條
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = pictureListView.Items.Count;
            //開始轉換
            int successCount = 0, failCount = 0;
            for (int i = 0; i < pictureListView.Items.Count; i++)
            {
                string name = pictureListView.Items[i].SubItems[0].Text;
                string type = pictureListView.Items[i].SubItems[1].Text;
                try
                {
                    progressBar1.Value++;
                    if (rdoScale.Checked && double.Parse(txtboxScale.Text) >= 0)
                    {
                        API.SaveThumbPicScale(s_Dir + "\\" + name + type, double.Parse(txtboxScale.Text), d_Dir + "\\" + name + type);
                    }
                    else if (rdoHeight.Checked && double.Parse(txtboxHegiht.Text) >= 0)
                    {
                        API.SaveThumbPicHeight(s_Dir + "\\" + name + type, (int)double.Parse(txtboxHegiht.Text), d_Dir + "\\" + name + type);
                    }
                    else if (rdoWidth.Checked && double.Parse(txtboxWidth.Text) >= 0)
                    {
                        API.SaveThumbPicWidth(s_Dir + "\\" + name + type, (int)double.Parse(txtboxWidth.Text), d_Dir + "\\" + name + type);
                    }
                    successCount++;
                    
                }
                catch(Exception ex)
                {
                    failCount++;
                    fail.Add(name + type);
                }
                //Avoid Memory Leak
                GC.Collect();
            }
            //碼錶停止
            sw.Stop();
            //MSG
            messageList.Items.Add("轉換成功:"+successCount);
            messageList.Items.Add("轉換失敗:"+failCount);
            messageList.Items.Add("耗時(s):" +  sw.Elapsed.TotalMilliseconds/1000);
   
            if(failCount!=0)
            {
                File.WriteAllLines(d_Dir + @"\"+"轉換失敗清單.txt", fail);
                messageList.Items.Add("[*]失敗清單已建立於");
                messageList.Items.Add("目的資料夾!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            destinationDir.Text = path.SelectedPath;

        }

        private void button3_Click(object sender, EventArgs e)
        {

            //創建目錄
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            selectDir.Text = path.SelectedPath;
            //增加到List裡面
            addTopictureListView(path.SelectedPath);

        }

        private void addTopictureListView(string path)
        {
            try
            {
                //增加到List裡面
                pictureListView.Items.Clear();
                foreach (string fileName in Directory.GetFileSystemEntries(path))
                {

                    try
                    {
                        System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(fileName);
                        pictureListView.Items.Add(new ListViewItem(new String[] { fileName.Replace(path, "").Replace("\\", "").Replace(Path.GetExtension(fileName), ""), Path.GetExtension(fileName).ToLower() }));
                        bitmap = null;
                        GC.Collect();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                GC.Collect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                GC.Collect();
            }
            GC.Collect();
        }

        private void selectDir_Leave(object sender, EventArgs e)
        {
            //增加到List裡面
            addTopictureListView(((TextBox)sender).Text);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/unromanticman");

        }







    }
}
