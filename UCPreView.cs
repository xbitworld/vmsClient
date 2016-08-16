using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VmsClientDemo
{
    public partial class UCPreview : UserControl
    {
        public UCPreview()
        {
            InitializeComponent();

            listViewPICs.View = View.LargeIcon;
            listViewPICs.LargeImageList = PICsList;
        }

        public void resetList()
        {
            pictureBox.Image.Dispose();
            pictureBox.Image = VmsClientDemo.Properties.Resources._1454046538594;

            for (int iLoop = 0; iLoop < listViewPICs.Items.Count; iLoop++)
            {
                string strFileName = PICsList.Images.Keys[iLoop];

                Image currIMG = PICsList.Images[iLoop];
                currIMG.Dispose();
                File.Delete(strFileName);
            }

            PICsList.Images.Clear();
            listViewPICs.Items.Clear();

            return;
        }

        public void LoadImageList(string strPath)
        {
            listViewPICs.Items.Clear();
            ShowImages(strPath);
            return;
        }

        private void ShowImages(string filePath)
        {
            DirectoryInfo di = new DirectoryInfo(filePath);
            FileInfo[] afi = di.GetFiles("*.jpg");

            string temp;
            int j = 0;
            for (int i = 0; i < afi.Length; i++)
            {
                temp = afi[i].Name.ToLower();
                AddImg(afi[i].FullName, j);
                j++;
            }
        }

        public void AddImg(string FullName, int iOrderNumber)
        {
            System.IO.FileStream fs = new System.IO.FileStream(FullName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            PICsList.Images.Add(Image.FromStream(fs));
            fs.Close();
            PICsList.Images.SetKeyName(iOrderNumber, FullName);
            listViewPICs.Items.Add((iOrderNumber + 1).ToString(), iOrderNumber);
        }

        public void showCurrentSelected(int iIndexPIC)
        {
            if (PICsList.Images.Count < 1)
                return;

            string FileName = PICsList.Images.Keys[iIndexPIC];

            System.IO.FileStream fs = new System.IO.FileStream(FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            pictureBox.Image = Image.FromStream(fs);
            fs.Close();

        }

        private void listViewPICs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPICs.SelectedItems.Count < 1)
                return;

            ListViewItem obj = listViewPICs.SelectedItems[0];

            for (int iLoop = 0; iLoop < listViewPICs.Items.Count; iLoop++)
            {
                if (obj.GetHashCode() == listViewPICs.Items[iLoop].GetHashCode())
                {
                    showCurrentSelected(iLoop);
                    break;
                }
            }
        }

        public bool ConfirmSelected()
        {
            List<string> getFiles = new List<string>();

            for (int iLoop = 0; iLoop < listViewPICs.Items.Count; iLoop++)
            {
                if (listViewPICs.Items[iLoop].Checked == true)
                {
                    getFiles.Add(PICsList.Images.Keys[iLoop]);
                }
            }

            int iAmount = getFiles.Count();
            if(iAmount < 3)
            {
                MessageBox.Show("截图数不能少于三张！");
                return false;
            }

            string fullPathOld = "";
            string fullPathNew = "";

            for (int iLoop = 0; iLoop < iAmount; iLoop ++)
            {
                System.IO.DirectoryInfo dirInfo = new DirectoryInfo(getFiles[iLoop]);

                fullPathOld = dirInfo.Parent.FullName;
                fullPathNew = dirInfo.Parent.Parent.FullName;
                string fileNameOld = dirInfo.Name;

                string[] strsName = fileNameOld.Split( '_');

                string orderMark = iAmount.ToString() + (iLoop + 1).ToString();
                string fileNameNew = strsName[0].Substring(0, strsName[0].Length - 4);
                fileNameNew += orderMark + "_";
                fileNameNew += strsName[1] + "_" + strsName[2];

                string fullNameNew = fullPathNew + "\\" + fileNameNew;

                System.IO.FileStream fs_old = new System.IO.FileStream(getFiles[iLoop], System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.FileStream fs_new = new System.IO.FileStream(fullNameNew, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fs_old.CopyTo(fs_new);

                fs_new.Close();
                fs_old.Close();
            }

            resetList();

            System.IO.DirectoryInfo tmpDir = new DirectoryInfo(fullPathOld);
            tmpDir.Delete(true);

            return true;
        }

        private void checkBoxALL_CheckedChanged(object sender, EventArgs e)
        {
            bool bCheck = false;
            List<bool> checkedList = new List<bool>();

            if (checkBoxALL.CheckState == CheckState.Checked)
            {
                bCheck = true;
            }
            else if(checkBoxALL.CheckState == CheckState.Unchecked)
            {
                bCheck = false;
            }

            for (int iLoop = 0; iLoop < listViewPICs.Items.Count; iLoop++)
            {
                listViewPICs.Items[iLoop].Checked = bCheck;
            }
        }
    }
}
