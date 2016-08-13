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
            listViewPICs.Items.Add("缩略图");

            System.Drawing.Image myImage =
                Image.FromFile(@"C:\Users\dutao\Source\Repos\vmsClient\1454046538594.jpg");

            PICsList.Images.Add(myImage);
        }

        public void LoadImageList()
        {

            return;
        }
    }
}
