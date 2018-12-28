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
            if (txt_SelectPath.Text != "" && txt_SelectPath.Text != null)
                path.SelectedPath = txt_SelectPath.Text;

            if (path.ShowDialog() == DialogResult.OK)
            {
                txt_SelectPath.Text = path.SelectedPath;
                if (!CheckPathAndShow()) return;
                FinalFormat();
            }
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
                MessageBox.Show("資料夾內沒有檔案!", "錯誤");
                return;
            }

            var alertMsg = $"{lbl_Total.Text}\n{lbl_FormatView_Final.Text}\n確定要輸出嗎?";
            if (MessageBox.Show(alertMsg, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                var seq = 1;
                var paddingNum = files.Count().ToString().Length;

                foreach (var file in files)
                {
                    var ext = Path.GetExtension(file);
                    var serialNum = seq.ToString().PadLeft(paddingNum, '0');
                    var newFilename = txt_Format.Text;

                    //有*就取代換成流水號，反之加在最後面
                    if (txt_Format.Text.IndexOf("*") >= 0)
                        newFilename = $"{txt_Format.Text.Replace("*", serialNum)}{ext}";
                    else
                        newFilename = $"{txt_Format.Text}{serialNum}{ext}";

                    if (ck_ParentPath.Checked)
                    {
                        var paths = txt_SelectPath.Text.Split('\\');
                        var parentPath = paths[paths.Length - 1];
                        newFilename = $"{parentPath}_{newFilename}";
                    }

                    File.Move(file, Path.Combine(txt_SelectPath.Text, newFilename));
                    seq = seq + 1;
                }
                this.lbl_Total.Text = $"總共有{files.Count()}個檔案，完成!";
            }
        }

        /// <summary>
        /// 檢查路徑是否合法且秀出路徑底下檔案數量
        /// </summary>
        /// <returns></returns>
        private bool CheckPathAndShow()
        {
            if (txt_SelectPath.Text == "" || txt_SelectPath.Text == null)
            {
                MessageBox.Show("路徑不得為空!", "錯誤");
                return false;
            }
            else
            {
                var files = Directory.GetFiles(txt_SelectPath.Text);
                this.lbl_Total.Text = $"總共有{files.Count()}個檔案";
                return true;
            }
        }

        /// <summary>
        /// 命名格式輸入內容時，改變輸出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_Format_TextChanged(object sender, EventArgs e)
        {
            if (!CheckPathAndShow()) return;
            FinalFormat();
        }

        /// <summary>
        /// 打勾狀態改變時，改變輸出格式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ck_ParentPath_CheckedChanged(object sender, EventArgs e)
        {
            if (!CheckPathAndShow()) return;
            FinalFormat();
        }

        private void FinalFormat()
        {
            lbl_FormatView_Final.Text = "輸出格式：";
            if (ck_ParentPath.Checked)
            {
                var paths = txt_SelectPath.Text.Split('\\');
                var parentPath = paths[paths.Length - 1];
                lbl_FormatView_Final.Text += $"{parentPath}_";
            }

            if (txt_Format.Text != "" && txt_Format.Text != null)
            {
                if (txt_Format.Text.IndexOf('*') >= 0)
                    lbl_FormatView_Final.Text += $"{txt_Format.Text}";
                else
                    lbl_FormatView_Final.Text += $"{txt_Format.Text}*";
            }
            else
                lbl_FormatView_Final.Text += "*";

            lbl_FormatView_Final.Text += "\n若有*則是用流水號取代";
        }
    }
}
