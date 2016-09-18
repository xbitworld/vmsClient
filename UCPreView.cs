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

                if ((iLoop + 1) == listViewPICs.Items.Count)
                {
                    System.IO.DirectoryInfo dirInfo = new DirectoryInfo(strFileName);
                    System.IO.DirectoryInfo tmpDir = new DirectoryInfo(dirInfo.Parent.FullName);
                    tmpDir.Delete(true);
                }
            }

            PICsList.Images.Clear();
            listViewPICs.Items.Clear();
            AmountTextbox.Text = "0";
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

        private void restPictureBoxPos()
        {
            Size OrgSize = pictureBox.Parent.Size;
            OrgSize.Width -= BlockPanel.Width;
            pictureBox.Size = OrgSize;
            pictureBox.Location = new Point(0, 0);
        }

        public void showCurrentSelected(int iIndexPIC)
        {
            if (PICsList.Images.Count < 1)
                return;

            restPictureBoxPos();

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
            if(iAmount < 3 || iAmount > 9)
            {
                MessageBox.Show("截图数不能少于3张或大于10张！");
                return false;
            }

            System.IO.DirectoryInfo dirInfo = new DirectoryInfo(getFiles[0]);
            string fullPathNew = dirInfo.Parent.Parent.FullName;
            string fileNameOld = dirInfo.Name; //Get the first file name, all the others file name base it.
            string[] strsName = fileNameOld.Split('.');

            for (int iLoop = 0; iLoop < iAmount; iLoop ++)
            {
                string orderMark = iAmount.ToString() + (iLoop + 1).ToString();
                string fileNameNew = strsName[0].Substring(0, strsName[0].Length - 4);  //orderMark to instead the last 4 chars
                fileNameNew += orderMark + ".";
                fileNameNew += strsName[1];

                string fullNameNew = fullPathNew + "\\" + fileNameNew;

                System.IO.FileStream fs_old = new System.IO.FileStream(getFiles[iLoop], System.IO.FileMode.Open, System.IO.FileAccess.Read);
                System.IO.FileStream fs_new = new System.IO.FileStream(fullNameNew, System.IO.FileMode.Create, System.IO.FileAccess.Write);
                fs_old.CopyTo(fs_new);

                fs_new.Close();
                fs_old.Close();
            }

            resetList();

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

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button.ToString().Equals("Right"))
            {
                Size OrgSize = pictureBox.Parent.Size;
                OrgSize.Width -= BlockPanel.Width;
                pictureBox.Size = OrgSize;
                pictureBox.Location = new Point(0, 0);
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show("MouseEnter");
            pictureBox.Focus();
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("MouseLeave");
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("MouseMove");
//            pictureBox.Focus();
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            pictureBox.Focus();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Delta.ToString());
            Point mLocation = e.Location;
            Point oldLocation = pictureBox.Location;
            Point newLocation = new Point();

            int iWidth = pictureBox.Size.Width;
            int iHeight = pictureBox.Size.Height;

            Size OrgSize = pictureBox.Parent.Size;
            Size CurSize = pictureBox.Size;
            OrgSize.Width -= BlockPanel.Width;

            if (e.Delta > 0)
            {
                if (OrgSize.Width * 4.0 > CurSize.Width)
                {
                    pictureBox.Invalidate();

                    pictureBox.Scale(new SizeF(1.1F, 1.1F));
                    newLocation.X = oldLocation.X - (int)(mLocation.X * 0.1F);
                    newLocation.Y = oldLocation.Y - (int)(mLocation.Y * 0.1F);
                    pictureBox.Location = newLocation;

                    pictureBox.Update() ;
                }
            }
            else
            {
                if (OrgSize.Width < CurSize.Width)
                {
                    pictureBox.Invalidate();

                    pictureBox.Scale(new SizeF(0.9091F, 0.9091F));
                    newLocation.X = oldLocation.X + (int)(mLocation.X * (1.0F - 0.9091F));
                    newLocation.Y = oldLocation.Y + (int)(mLocation.Y * (1.0F - 0.9091F));
                    pictureBox.Location = newLocation;

                    pictureBox.Update() ;
                }
            }
        }

        private void listViewPICs_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int iCount = 0;
            for (int iLoop = 0; iLoop < listViewPICs.Items.Count; iLoop++)
            {
                if (listViewPICs.Items[iLoop].Checked == true)
                {
                    iCount++;
                }
            }

            AmountTextbox.Text = iCount.ToString();
        }
    }
}
