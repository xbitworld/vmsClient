using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmsClientDemo
{
    public partial class UCPreview : UserControl
    {
        public UCPreview()
        {
            InitializeComponent();

            PICsList.ImageSize = new Size(255, 255);
        }

        public void LoadImageList()
        {
            //listViewPICs.Items.Clear();
            listViewPICs.Items.Add("缩略图");

            listViewPICs.Items[0].ImageIndex = 1;
            //Image myImage =
            //    Image.FromFile(@".\1454046538594.jpg");
            //PICsList.Images.Add(myImage);

            return;
        }
    }
}
