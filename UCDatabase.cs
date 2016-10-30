using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace VmsClientDemo
{
    public partial class UCDatabase : UserControl
    {
        private Form1.dbCallbackFun pDBSQLFun = null;
        private string []dirString = { "南", "西南", "西", "西北", "北", "东北", "东", "东南"};

        public UCDatabase(Form1.dbCallbackFun SQLFun)
        {
            this.pDBSQLFun = SQLFun;
            InitializeComponent();
            initBT();
            initCOMB(roadCOMB);
        }

        public void initBT()
        {
            ModifyCAM.Enabled = false;
            ADDCamera.Enabled = false;
        }

        public void initCOMB(ComboBox comb)
        {
            posCOMB.Items.Clear();
            posCOMB.Tag = -1;
            posName.Text = "";
            posCode.Text = "";
            if (comb.Equals(posCOMB))
                return;

            secCOMB.Items.Clear();
            secCOMB.Tag = -1;
            secName.Text = "";
            secCode.Text = "";
            if (comb.Equals(secCOMB))
                return;

            roadCOMB.Items.Clear();
            roadCOMB.Tag = -1;
            roadName.Text = "";
            roadCode.Text = "";
            if (comb.Equals(roadCOMB))
                return;
        }

        public bool fillDevDir(string strCAMCode)
        {
            devDirCMB.Items.Clear();
            devDirCMB.Text = "";
            DelDirBT.Enabled = false;

            DataRowCollection drc = null;
            string strSQL = "select 方向ID, 预置位ID from 设备方向映射表 where 设备CODE = '" + strCAMCode + "' order by 预置位ID";
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                //Fill Info to UI
                foreach (DataRow DR in drc)
                {
                    int iDir = int.Parse(DR[0].ToString());
                    int iPrePOS = int.Parse(DR[1].ToString());
                    devDirCMB.Items.Add("预置位:" + iPrePOS.ToString() + ", 方向:" + dirString[iDir]);
                }

                devDirCMB.SelectedIndex = 0;
                DelDirBT.Enabled = true;
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool fillDatabaseUI(string strCAMCode, string strCAMName)
        {
            CamNameBox.Text = strCAMName;
            CamNameBox.Tag = strCAMCode;

            initBT();
            initCOMB(roadCOMB);

            DataRowCollection drc = null;

            string strSQL = "select 设备编码, 路口ID from 设备路口映射表 where 设备Code = '" + strCAMCode + "'";

            int iposID = 0;
            int isecID = 0;
            int iroadID = 0;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if(iRow > 0)
            {
                //Fill Info to UI
                ModifyCAM.Enabled = true;

                string strCAMID = (string)drc[0][0];
                iposID = (int)drc[0][1];
                CAMCodeBox.Text = strCAMID;

                strSQL = "select 地点编码, 道路ID, 路段ID from 设备及地点 where 设备编码 = '" + strCAMID + "'";
                iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow < 1) return false;

                posCodeBox.Text = (string)drc[0][0];
                iroadID = (int)drc[0][1];
                isecID = (int)drc[0][2];
                
                strSQL = "select 道路名称 from 道路编码表 where ID = " + iroadID.ToString();
                iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow < 1) return false;

                string strRoadName = (string)drc[0][0];
                FillRoadInfo(strRoadName);
                
                strSQL = "select 路段名称 from 路段编码表 where ID = " + isecID.ToString();
                iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow < 1) return false;

                string strSecName = (string)drc[0][0];
                FillSecInfo(strSecName);
                
                strSQL = "select 路口名称 from 路口编码表 where ID = " + iposID.ToString();
                iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow < 1) return false;

                string strPosName = (string)drc[0][0];
                FillPosInfo(strPosName);
                
                return true;
            }
            else
            {
                ADDCamera.Enabled = true;
                //Fill road info
                strSQL = "select 道路名称 from 道路编码表";
                iRow = pDBSQLFun(strSQL, ref drc);
                if(iRow > 0)
                {
                    foreach (DataRow DR in drc)
                    {
                        roadCOMB.Items.Add((string)(DR[0]));
                    }
                    roadCOMB.SelectedIndex = 0;
                }
                //Input Camera ID
                //Insert info to DB
                //string SQLInsertDev = "Insert into 设备路口映射表(设备Code, 设备名称, 设备编码) values('" + strCAMCode + "', '" + strCAMName + "', '" + "')";
                return false;
            }
        }

        private void UCDatabase_MouseEnter(object sender, EventArgs e)
        {
        }

        private void FillRoadInfo(string strRoadName)
        {
            initCOMB(roadCOMB);     //reset combbox

            if (strRoadName == null || strRoadName == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            //Fill road info
            string strSQL = "select 道路名称 from 道路编码表";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                foreach (DataRow DR in drc)
                {
                    roadCOMB.Items.Add((string)(DR[0]));
                }
            }
            roadCOMB.SelectedIndex = roadCOMB.Items.IndexOf(strRoadName);
        }

        private void FillSecInfo(string strSecName)
        {
            initCOMB(secCOMB);     //reset combbox

            int iRoadID = (int)roadCOMB.Tag;

            if(iRoadID == -1 || strSecName == null || strSecName == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }
            string strSQL = "select 路段名称 from 路段编码表 where 道路ID = " + iRoadID.ToString();

            DataRowCollection drc = null;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                //Fill Info to UI
                foreach (DataRow DR in drc)
                {
                    secCOMB.Items.Add((string)(DR[0]));
                }
            }
            secCOMB.SelectedIndex = secCOMB.Items.IndexOf(strSecName);  //Triger the select changed event
        }

        private void FillPosInfo(string strPosName)
        {
            initCOMB(posCOMB);     //reset combbox

            int iSecID = (int)secCOMB.Tag;

            if (iSecID == -1 || strPosName == null || strPosName == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "select 路口名称 from 路口编码表 where 路段ID = " + iSecID.ToString();

            DataRowCollection drc = null;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                foreach (DataRow DR in drc)
                {
                    posCOMB.Items.Add((string)(DR[0]));
                }
            }

            posCOMB.SelectedIndex = posCOMB.Items.IndexOf(strPosName);
        }

        private void addRoad_Click(object sender, EventArgs e)
        {
            string strName = roadName.Text;
            string strCode = roadCode.Text;
            if (strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "insert into 道路编码表(道路名称, 道路代码) values('" + strName + "', " + strCode + ")";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillRoadInfo(strName);
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void delRoad_Click(object sender, EventArgs e)
        {
            int iID = (int)roadCOMB.Tag;
            if (iID == -1)
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "select count(ID) from 路段编码表 where 道路ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                MessageBox.Show("数据被关联，无法删除，请删除关联的路段再试！");
                return;
            }

            strSQL = "delete from 道路编码表 where ID = " + iID.ToString();

            iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                initCOMB(roadCOMB);
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void modRoad_Click(object sender, EventArgs e)
        {
            string strName = roadName.Text;
            string strCode = roadCode.Text;
            int iRoadID = (int)roadCOMB.Tag;
            if (iRoadID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "update 道路编码表 set 道路名称 = '" + strName + "', 道路代码 = " + strCode + " where ID = " + iRoadID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillRoadInfo(strName);
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void addSection_Click(object sender, EventArgs e)
        {
            string strName = secName.Text;
            string strCode = secCode.Text;
            int iRoadID = (int)roadCOMB.Tag;
            if (iRoadID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "insert into 路段编码表(路段名称, 路段代码, 道路ID) values('" + strName + "', " + strCode + ", " + iRoadID.ToString() + ")";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillSecInfo(strName);
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void delSection_Click(object sender, EventArgs e)
        {
            int iID = (int)secCOMB.Tag;
            if (iID == -1)
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "select count(ID) from 路口编码表 where 路段ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                MessageBox.Show("数据被关联，无法删除，请删除关联的路口再试！");
                return;
            }

            strSQL = "delete from 路段编码表 where ID = " + iID.ToString();

            iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                initCOMB(secCOMB);
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void modSection_Click(object sender, EventArgs e)
        {
            string strName = secName.Text;
            string strCode = secCode.Text;
            int iSecID = (int)secCOMB.Tag;
            if (iSecID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "update 路段编码表 set 路段名称 = '" + strName + "', 路段代码 = " + strCode + " where ID = " + iSecID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillSecInfo(strName);
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void addPos_Click(object sender, EventArgs e)
        {
            string strName = posName.Text;
            string strCode = posCode.Text;
            int iSecID = (int)secCOMB.Tag;
            if (iSecID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "insert into 路口编码表(路口名称, 路口代码, 路段ID) values('" + strName + "', " + strCode + ", " + iSecID.ToString() + ")";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillPosInfo(strName);
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void delPos_Click(object sender, EventArgs e)
        {
            int iID = (int)posCOMB.Tag;
            if (iID == -1)
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "delete from 路口编码表 where ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                initCOMB(secCOMB);
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void modPos_Click(object sender, EventArgs e)
        {
            string strName = posName.Text;
            string strCode = posCode.Text;
            int iPosID = (int)posCOMB.Tag;
            if (iPosID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "update 路口编码表 set 路口名称 = '" + strName + "', 路口代码 = " + strCode + " where ID = " + iPosID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                FillPosInfo(strName);
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void roadCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            secCOMB.Items.Clear();
            secCOMB.Text = "";
            secCOMB.Tag = -1;

            posCOMB.Items.Clear();
            posCOMB.Text = "";
            posCOMB.Tag = -1;

            string strRoadName = roadCOMB.Text;

            if (strRoadName != null && strRoadName != "")
            {
                string strSQL = "select 道路名称, 道路代码, ID from 道路编码表 where 道路名称 = '" + strRoadName + "'";
                int iRoadID = -1;

                DataRowCollection drc = null;
                int iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow > 0)
                {
                    //Fill Info to UI
                    roadName.Text = (string)drc[0][0];
                    roadCode.Text = ((int)drc[0][1]).ToString();
                    iRoadID = (int)drc[0][2];

                    //Insert info to section
                    strSQL = "select 路段名称 from 路段编码表 where 道路ID = " + iRoadID.ToString();
                    iRow = pDBSQLFun(strSQL, ref drc);
                    if (iRow > 0)
                    {
                        foreach (DataRow DR in drc)
                        {
                            secCOMB.Items.Add((string)(DR[0]));
                        }
                    }
                }
                roadCOMB.Tag = iRoadID;
            }
        }

        private void secCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            posCOMB.Items.Clear();
            posCOMB.Text = "";
            posCOMB.Tag = -1;

            string strSecName = secCOMB.Text;

            if (strSecName != null && strSecName != "")
            {
                string strSQL = "select 路段名称, 路段代码, ID from 路段编码表 where 路段名称 = '" + strSecName + "'";
                int isecID = -1;

                DataRowCollection drc = null;
                int iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow > 0)
                {
                    //Fill Info to UI
                    secName.Text = (string)drc[0][0];
                    secCode.Text = ((int)drc[0][1]).ToString();
                    isecID = (int)drc[0][2];

                    //Insert info to positon
                    strSQL = "select 路口名称 from 路口编码表 where 路段ID = " + isecID.ToString();
                    iRow = pDBSQLFun(strSQL, ref drc);
                    if (iRow > 0)
                    {
                        foreach (DataRow DR in drc)
                        {
                            posCOMB.Items.Add((string)(DR[0]));
                        }
                    }
                }
                secCOMB.Tag = isecID;
            }
        }

        private void posCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strPosName = posCOMB.Text;
            if (strPosName != null || strPosName != "")
            {
                string strSQL = "select 路口名称, 路口代码, ID from 路口编码表 where 路口名称 = '" + strPosName + "'";
                int iposID = -1;

                DataRowCollection drc = null;
                int iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow > 0)
                {
                    posName.Text = (string)drc[0][0];
                    posCode.Text = ((int)drc[0][1]).ToString();
                    iposID = (int)drc[0][2];
                }
                posCOMB.Tag = iposID;
            }
        }

        private void ADDCamera_Click(object sender, EventArgs e)
        {
            int iRoadID = (int)roadCOMB.Tag;
            int iSecID = (int)secCOMB.Tag;
            int iPosID = (int)posCOMB.Tag;

            string strCAMID = (string)CamNameBox.Tag;   //摄像机编码——来自摄像机硬件标号
            string strCAMCode = CAMCodeBox.Text;        //摄像机编码——来自人工编码
            string strCAMName = CamNameBox.Text;

            if (iRoadID == -1 || iSecID == -1 || iPosID == -1
                || strCAMID == "" || strCAMName == "" || strCAMCode == "")
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "insert into 设备路口映射表(设备CODE, 设备编码, 设备名称, 路口ID) values('" 
                + strCAMID + "', '" + strCAMCode + "', '" + strCAMName + "', " + iPosID.ToString() + ")";

            DataRowCollection drc = null;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                MessageBox.Show("插入成功");
            }
            else
            {
                MessageBox.Show("插入失败，请检查是否摄像机编码重复");
            }
        }

        private void ModifyCAM_Click(object sender, EventArgs e)
        {
            int iPosID = (int)posCOMB.Tag;
            string strCamCode = (string)CamNameBox.Tag; //Code from camera device
            string strCAMCode = CAMCodeBox.Text;        //摄像机编码——来自人工编码

            string strSQL = "update 设备路口映射表 set 路口ID = " + iPosID.ToString() + ", 设备编码 = '" + strCAMCode + "'  where 设备CODE = '" + strCamCode + "'";

            DataRowCollection drc = null;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失败，请核对数据有效性");
            }
        }

        public int getPostitionID(ref int iP, ref string CAMCode, ref string POSCode)
        {
            if (posCOMB.Tag == null || CAMCodeBox.Text == null || posCodeBox.Text == null)
            {
                return -1;
            }

            iP = (int)posCOMB.Tag;
            CAMCode = CAMCodeBox.Text;
            POSCode = posCodeBox.Text;

            if (iP == -1 || CAMCode == "" || POSCode == "")
            {
                return 1;
            }

            return 0;
        }

        private void AddDirBT_Click(object sender, EventArgs e)
        {
            string strDevCode = (string)CamNameBox.Tag;
            int prePosID = prePosCMB.SelectedIndex;
            int dirID = dirCMB.SelectedIndex;

            if (prePosID == -1 || strDevCode == null || strDevCode == "" || dirID == -1)
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }
            string strSQL = "select 方向ID, 预置位ID from 设备方向映射表 where 设备CODE = '" + strDevCode + "' and 预置位ID = " + prePosID.ToString();
            DataRowCollection drc = null;
            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                MessageBox.Show("预置位已经设置方向，请删除后重新插入！");
                return;
            }

            strSQL = "insert into 设备方向映射表(设备CODE, 预置位ID, 方向ID) values('" + strDevCode + "', " + prePosID + ", " + dirID + ")";
            iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                fillDevDir(strDevCode);
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void DelDirBT_Click(object sender, EventArgs e)
        {
            string strDevCode = (string)CamNameBox.Tag;
            int prePosID = prePosCMB.SelectedIndex;
            int dirID = dirCMB.SelectedIndex;

            if (prePosID == -1 || strDevCode == null || strDevCode == "" || dirID == -1)
            {
                MessageBox.Show("信息不完整，请检查！");
                return;
            }

            string strSQL = "delete from 设备方向映射表 where 设备CODE = '" + strDevCode + "' and 预置位ID = " + prePosID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow >= 0)
            {
                fillDevDir(strDevCode);
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }
    }
}
