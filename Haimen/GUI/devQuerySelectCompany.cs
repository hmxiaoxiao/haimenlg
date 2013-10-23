using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using Haimen.Qy;
using Haimen.Entity;

using DevExpress.XtraTreeList.Nodes;

namespace Haimen.GUI
{
    public partial class DevQuerySelectCompany : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ID_List { get; set; }
        public Boolean SelectAll { get; set; }

        public DevQuerySelectCompany()
        {
            InitializeComponent();
        }

        private void devQuerySelectCompany_Load(object sender, EventArgs e)
        {
            tree.DataSource = Company.Query(" doc <>  ''");
            tree.ParentFieldName = "ParentID";
            tree.KeyFieldName = "ID";
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SelectAll = true;
            ID_List = new List<string>();

            foreach (TreeListNode node in tree.Nodes)
            {
                if (node.CheckState == CheckState.Checked)
                {
                    ID_List.Add(node.GetValue(tree_id).ToString());
                    GetChildNodeCheck(node);
                }
                else
                    SelectAll = false;
            }
            this.Close();
        }

        private void GetChildNodeCheck(TreeListNode node)
        {
            foreach (TreeListNode n in node.Nodes)
            {
                if (n.CheckState == CheckState.Checked)
                    ID_List.Add(n.GetValue(tree_id).ToString());
                else
                    SelectAll = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tree_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
        }

        /// 设置子节点的状态
        /// </summary>
        /// <param name="node"></param>
        /// <param name="check"></param>
        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
    }
}