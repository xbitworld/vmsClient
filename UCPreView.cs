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

        private void showCurrentSelected(int iIndexPIC)
        {
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

        private void Confirm_Click(object sender, EventArgs e)
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
            if(iAmount < 1)
            {
                return;
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

            //ShowImages(fullPathNew);
        }
    }
}
