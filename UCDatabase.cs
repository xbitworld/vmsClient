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
            if (comb.Equals(roadCOMB))
            {
                roadCOMB.Items.Clear();
                secCOMB.Items.Clear();
                posCOMB.Items.Clear();

                roadCOMB.Tag = -1;
                secCOMB.Tag = -1;
                posCOMB.Tag = -1;
            }
            else if(comb.Equals(secCOMB))
            {
                secCOMB.Items.Clear();
                posCOMB.Items.Clear();

                secCOMB.Tag = -1;
                posCOMB.Tag = -1;
            }
            else if(comb.Equals(posCOMB))
            {
                posCOMB.Items.Clear();

                posCOMB.Tag = -1;
            }
        }

        public bool fillDatabaseUI(string strCAMCode, string strCAMName)
        {
            CamNameBox.Text = strCAMName;
            CAMCodeBox.Text = strCAMCode;

            string SQLQueryDev = "select 设备ID, 设备名称, 路口ID from 设备路口映射表 where 设备Code = '" + strCAMCode + "'";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(SQLQueryDev, ref drc);
            if(iRow > 0)
            {
                //Fill Info to UI
                ModifyCAM.Enabled = true;
            }
            else
            {
                //Fill road info
                string strSQL = "select 道路名称 from 道路编码表";
                iRow = pDBSQLFun(strSQL, ref drc);
                if(iRow > 0)
                {
                    foreach (DataRow DR in drc)
                    {
                        roadCOMB.Items.Add((string)(DR[0]));
                    }
                }
                roadCOMB.SelectedIndex = 0;
                //Input Camera ID
                //Insert info to DB
                //string SQLInsertDev = "Insert into 设备路口映射表(设备Code, 设备名称, 设备编码) values('" + strCAMCode + "', '" + strCAMName + "', '" + "')";
            }

            return true;
        }

        private void UCDatabase_MouseEnter(object sender, EventArgs e)
        {
        }

        private void FillRoadInfo(string strRoadName)
        {
            initCOMB(roadCOMB);     //reset combbox

            if (strRoadName == null || strRoadName == "")
            {
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
                return;
            }

            string strSQL = "select 路口名称 from 路口编码表 where 道路ID = " + iSecID.ToString();

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
                return;
            }

            string strSQL = "insert into 道路编码表(道路名称, 道路编码) values('" + strName + "', '" + strCode + "')";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillRoadInfo(strName);
            }
        }

        private void delRoad_Click(object sender, EventArgs e)
        {
            int iID = (int)roadCOMB.Tag;
            if (iID == -1)
            {
                return;
            }

            string strSQL = "delete 道路编码表 where ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                initCOMB(roadCOMB);
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
                return;
            }

            string strSQL = "update 道路编码表 set 道路名称 = '" + strName + "', 道路编码 = '" + strCode + "' where ID = " + iRoadID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillRoadInfo(strName);
            }
        }

        private void addSection_Click(object sender, EventArgs e)
        {
            string strName = secName.Text;
            string strCode = secCode.Text;
            int iRoadID = (int)roadCOMB.Tag;
            if (iRoadID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                return;
            }

            string strSQL = "insert into 路段编码表(路段名称, 路段代码, 道路ID) values('" + strName + "', '" + strCode + "', " + iRoadID.ToString() + ")";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillSecInfo(strName);
            }
        }

        private void delSection_Click(object sender, EventArgs e)
        {
            int iID = (int)secCOMB.Tag;
            if (iID == -1)
            {
                return;
            }

            string strSQL = "delete 路段编码表 where ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                initCOMB(secCOMB);
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
                return;
            }

            string strSQL = "update 路段编码表 set 路段名称 = '" + strName + "', 路段代码 = '" + strCode + "' where ID = " + iSecID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillSecInfo(strName);
            }
        }

        private void addPos_Click(object sender, EventArgs e)
        {
            string strName = posName.Text;
            string strCode = posCode.Text;
            int iSecID = (int)secCOMB.Tag;
            if (iSecID == -1 || strName == null || strName == "" || strCode == null || strCode == "")
            {
                return;
            }

            string strSQL = "insert into 路口编码表(路口名称, 路口编码, 路段ID) values('" + strName + "', '" + strCode + "', " + iSecID.ToString() + ")";
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillPosInfo(strName);
            }
        }

        private void delPos_Click(object sender, EventArgs e)
        {
            int iID = (int)posCOMB.Tag;
            if (iID == -1)
            {
                return;
            }

            string strSQL = "delete 路口编码表 where ID = " + iID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                initCOMB(secCOMB);
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
                return;
            }

            string strSQL = "update 路口编码表 set 路口名称 = '" + strName + "', 路口编码 = '" + strCode + "' where ID = " + iPosID.ToString();
            DataRowCollection drc = null;

            int iRow = pDBSQLFun(strSQL, ref drc);
            if (iRow > 0)
            {
                FillPosInfo(strName);
            }
        }

        private void roadCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    roadCode.Text = (string)drc[0][1];
                    iRoadID = (int)drc[0][2];

                    //Insert info to section
                    strSQL = "select 路段名 from 路段编码表 where 道路ID = " + iRoadID.ToString();
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
                    secCode.Text = (string)drc[0][1];
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
            if (strPosName == null || strPosName == "")
            {
                string strSQL = "select 路口名称, 路口编码, ID from 路口编码表 where 路口名称 = '" + strPosName + "'";
                int iposID = -1;

                DataRowCollection drc = null;
                int iRow = pDBSQLFun(strSQL, ref drc);
                if (iRow > 0)
                {
                    posName.Text = (string)drc[0][0];
                    posCode.Text = (string)drc[0][1];
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

            if(iRoadID == -1 || iSecID == -1 || iPosID == -1)
            {
                return;
            }

            string strSQL = "insert into 设备路口映射表(";
        }

        private void ModifyCAM_Click(object sender, EventArgs e)
        {

        }
    }
}
