using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VmsClientDemo
{
    public partial class RulesUI : Form
    {
        private int iPosID = -1;
        private int iDirID = -1;
        private int iRuleID = -1;
        private bool bAddOP = true;

        public RulesUI(int iID, bool bAdd)
        {
            iPosID = iID;
            bAddOP = bAdd;

            InitializeComponent();

            if (bAddOP == true)
            {
                AddDel.Text = "+";
            }
            else
            {
                AddDel.Text = "-";
            }

            fillDIR();
            fillRules();
        }

        private void fillDIR()
        {
            DirCOMB.Items.Clear();

            string strSQL = "select 方向描述 from 方向编码表";
            if (bAddOP == true)
            {
                strSQL = "select 方向描述 from 方向编码表";
            }
            else
            {
                strSQL = "select distinct 方向描述 from 违章种类及方向 where 路口ID = " + iPosID.ToString();
            }

            DataRowCollection drc = null;

            int iRow = Form1.getData(strSQL, ref drc);
            if (iRow >= 0)
            {
                foreach(DataRow dr in drc)
                {
                    DirCOMB.Items.Add((string)dr[0]);
                }

                DirCOMB.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void fillRules()
        {
            rulesCOMB.Items.Clear();

            if (iPosID == -1)
            {
                MessageBox.Show("地址信息错误，请检查！");
                this.Close();
                return;
            }

            string strSQL = "";
            if (bAddOP == true)
            {
                strSQL = "select 违章描述 from 违章种类及方向 where 路口ID = " + iPosID.ToString();
            }
            else
            {
                string strDIR = DirCOMB.Text;
                if (strDIR == null || strDIR == "")
                {
                    MessageBox.Show("方向选择错误，请核实！");
                }

                strSQL = "select 违章描述 from 违章种类及方向 where 路口ID = " + iPosID.ToString() + " and 方向描述 = '" + DirCOMB.Text + "'";
            }

            DataRowCollection drc = null;

            int iRow = Form1.getData(strSQL, ref drc);
            if (iRow >= 0)
            {
                foreach (DataRow dr in drc)
                {
                    DirCOMB.Items.Add((string)dr[0]);
                }

                rulesCOMB.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void DirCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDirID = -1;

            string strDIR = DirCOMB.Text;

            if (strDIR == null || strDIR == "")
            {
                MessageBox.Show("方向选择错误，请核实！");
            }
            string strSQL = "select 方向编码 from 方向编码表 where 方向描述 = '" + strDIR + "'";

            DataRowCollection drc = null;

            int iRow = Form1.getData(strSQL, ref drc);
            if (iRow >= 0)
            {
                iDirID = (int)drc[0][0];
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void rulesCOMB_SelectedIndexChanged(object sender, EventArgs e)
        {
            iRuleID = -1;

            string strRule = rulesCOMB.Text;

            if (strRule == null || strRule == "")
            {
                MessageBox.Show("方向选择错误，请核实！");
            }
            string strSQL = "select 违章编码 from 违章编码表 where 违章描述 = '" + strRule + "'";

            DataRowCollection drc = null;

            int iRow = Form1.getData(strSQL, ref drc);
            if (iRow >= 0)
            {
                iRuleID = (int)drc[0][0];
            }
            else
            {
                MessageBox.Show("SQL Error: " + strSQL);
            }
        }

        private void AddDel_Click(object sender, EventArgs e)
        {
            if (bAddOP == true)
            {
                //找到地点
                //找到方向和描述
                //找到违章编码和描述
                if(iPosID == -1 || iDirID == -1 || iRuleID == -1)
                {
                    MessageBox.Show("新增信息不健全，请检查后重试！");
                    return;
                }

                string strSQL = "insert into 违章类型映射表(路口ID, 方向编码, 违章编码) values(" + iPosID.ToString() + ", " + iDirID.ToString() + ", " + iRuleID.ToString() + ")";

                DataRowCollection drc = null;

                int iRow = Form1.getData(strSQL, ref drc);
                if (iRow < 0)
                {
                    MessageBox.Show("SQL Error: " + strSQL);
                }
            }
            else
            {
                if (iPosID == -1 || iDirID == -1 || iRuleID == -1)
                {
                    MessageBox.Show("无法根据已有信息删除数据，请检查后重试！");
                    return;
                }

                string strSQL = "delete 违章类型映射表 where 路口ID = " + iPosID.ToString() + " and 方向编码 = " + iDirID.ToString() + " and 违章编码 = " + iRuleID.ToString() + ")";

                DataRowCollection drc = null;

                int iRow = Form1.getData(strSQL, ref drc);
                if (iRow < 0)
                {
                    MessageBox.Show("SQL Error: " + strSQL);
                }
            }
        }
    }
}
