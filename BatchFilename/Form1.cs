using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BatchFilename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 選擇資料夾路徑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txt_SelectPath.Text = path.SelectedPath;

            CheckPathAndShow();
        }

        /// <summary>
        /// 依照所需格式重新命名資料夾內所有檔案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Rename_Click(object sender, EventArgs e)
        {
            if (!CheckPathAndShow()) return;

            var files = Directory.GetFiles(txt_SelectPath.Text);
            if (files.Count() == 0)
            {
                MessageBox.Show("資料夾內沒有檔案!","錯誤");
                return;
            }

            var seq = 1;
            var paddingNum = files.Count().ToString().Length;

            foreach (var file in files)
            {
                var ext = Path.GetExtension(file);
                var serialNum = seq.ToString().PadLeft(paddingNum, '0');
                var newFilename = txt_Format.Text;

                //有*就取代換成流水號，反之加在最後面
                if (txt_Format.Text.IndexOf("*") >= 0)
                    newFilename = Path.Combine(txt_SelectPath.Text, $"{txt_Format.Text.Replace("*", serialNum)}{ext}");
                else
                    newFilename = Path.Combine(txt_SelectPath.Text, $"{txt_Format.Text}{seq}{ext}");

                File.Move(file, newFilename);
                seq = seq + 1;
            }
            MessageBox.Show("重新命名完成!","成功");
        }

        /// <summary>
        /// 檢查路徑是否合法且秀出路徑底下檔案數量
        /// </summary>
        /// <returns></returns>
        private bool CheckPathAndShow()
        {
            if (txt_SelectPath.Text == "" || txt_SelectPath.Text == null)
            {
                MessageBox.Show("路徑不得為空!","錯誤");
                return false;
            }
            else
            {
                var files = Directory.GetFiles(txt_SelectPath.Text);
                this.lbl_Total.Text = $"總共有{files.Count()}個檔案";
                return true;
            }
        }
    }
}
