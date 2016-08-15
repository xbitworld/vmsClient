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
        }

        public void resetList()
        {
            listViewPICs.Items.Clear();
            return;
        }

        public void LoadImageList(string strPath)
        {
            listViewPICs.Items.Clear();
            ShowImages(strPath);

            //PICsList.ImageSize = new Size(255, 255);

            //ShowImages(@"C:\Users\dutao\Pictures\抓取日期_20160813\成都市人民南路三段17号");
            return;
        }

        private void ShowImages(string filePath)
        {
            listViewPICs.View = View.LargeIcon;
            listViewPICs.LargeImageList = PICsList;

            DirectoryInfo di = new DirectoryInfo(filePath);
            FileInfo[] afi = di.GetFiles("*.*");

            string temp;
            int j = 0;
            for (int i = 0; i < afi.Length; i++)
            {
                temp = afi[i].Name.ToLower();
                if (temp.EndsWith(".jpg"))
                {
                    AddImg(ref afi[i], ref j, ".jpg");
                }
                else if (temp.EndsWith(".jpeg"))
                {
                    AddImg(ref afi[i], ref j, ".jpeg");
                }
                else if (temp.EndsWith(".gif"))
                {
                    AddImg(ref afi[i], ref j, ".gif");
                }
                else if (temp.EndsWith(".png"))
                {
                    AddImg(ref afi[i], ref j, ".png");
                }
                else if (temp.EndsWith(".bmp"))
                {
                    AddImg(ref afi[i], ref j, ".bmp");
                }
                else if (temp.EndsWith(".tiff"))
                {
                    AddImg(ref afi[i], ref j, ".tiff");
                }
            }
        }

        private void AddImg(ref FileInfo fi, ref int j, string ex)
        {
            PICsList.Images.Add(Image.FromFile(fi.FullName));
            PICsList.Images.SetKeyName(j, fi.FullName);
            listViewPICs.Items.Add((j+1).ToString(), j);
            j++;
        }

        private void showCurrentSelected(int iIndexPIC)
        {
            string strKey = PICsList.Images.Keys[iIndexPIC];
            //Image currIMG = PICsList.Images[iIndexPIC];
            pictureBox.Image = Image.FromFile(strKey);
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
    }
}
