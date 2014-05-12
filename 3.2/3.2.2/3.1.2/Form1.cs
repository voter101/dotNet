using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             for (int i = 0; i <= 100; i++)
            {
                System.Threading.Thread.Sleep(40);
                // ... do analysis ...
                progressBar1.Value = (i);
                progressBar3.Value = (i);
                            
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListViewItem lView = new ListViewItem("Andrzej");
            lView.SubItems.Add("kurzynski");
            lView.SubItems.Add("25");
            lView.SubItems.Add("Mężczyzna");
            lView.SubItems.Add("4700");
            listView2.Items.Add(lView);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count ==0) return;
            listView2.SelectedItems[0].Remove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListViewItem lView = new ListViewItem("Małgorzata");
            lView.SubItems.Add("Sierpińska");
            lView.SubItems.Add("22");
            lView.SubItems.Add("Kobieta");
            lView.SubItems.Add("7800");
            listView2.Items.Add(lView);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            treeView1.BeginUpdate();
            //treeView2.Nodes.Clear();
            string yourParentNode;
            yourParentNode = "parent";
            treeView1.Nodes.Add(yourParentNode);
            treeView1.EndUpdate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string yourChildNode;
                yourChildNode = "child";
                treeView1.SelectedNode.Nodes.Add(yourChildNode);
                treeView1.ExpandAll();
            }

        }
    }
}
