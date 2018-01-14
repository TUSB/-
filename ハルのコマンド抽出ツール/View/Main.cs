using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilverNBTLibrary;
using SilverNBTLibrary.World;

namespace ハルのコマンド抽出ツール
{
    public partial class Main : Form
    {
        private string filename = "";
        private string findstr;

        private TreeNode node = new TreeNode();
        public Main()
        {
            InitializeComponent();
        }

        private void ワールドを開くToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openWorld();
        }

        private void openWorld()
        {
            if (menuStrip1.Enabled && OpenWorldDialog.ShowDialog() == DialogResult.OK)
            {
                menuStrip1.Enabled = false;
                filename = System.IO.Path.GetDirectoryName(OpenWorldDialog.FileName);
                OpenWorldWorker.RunWorkerAsync();
            }
        }

        private void OpenWorldWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var open = new Lib.worldOpen();
            node = open.Load(filename);
            open = null;
        }

        private void OpenWorldWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(node);
            node = new TreeNode();
            treeView1.Sorted = true;
            menuStrip1.Enabled = true;
            treeView1.Enabled = true;
            MessageBox.Show("読み込みが完了しました", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ワールドを保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Enabled && treeView1.Nodes.Count > 0)
            {
                if (filename == "")
                {
                    if (OpenWorldDialog.ShowDialog() == DialogResult.OK)
                    {
                        filename = System.IO.Path.GetDirectoryName(OpenWorldDialog.FileName);
                    }
                    else
                    {
                        return;
                    }
                }
                menuStrip1.Enabled = false;
                treeView1.Enabled = false;
                node = treeView1.Nodes[0];
                SaveWorldWorker.RunWorkerAsync();
            }
        }

        private void SaveWorldWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var save = new Lib.worldSave();
            save.Save(filename, node);

            save = null;
        }

        private void SaveWorldWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            menuStrip1.Enabled = true;
            treeView1.Enabled = true;
            MessageBox.Show("保存が完了しました", "完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            EditNode();
        }

        private void データ編集ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNode();
        }

        private void EditNode()
        {
            if (treeView1.SelectedNode != null && treeView1.SelectedNode.ImageIndex == 3)
            {
                var nbt = (NBTTagCompound)treeView1.SelectedNode.Tag;
                var edit = new ハルのコマンド抽出ツール.View.CommandEditView();
                edit.nbt = nbt;
                if (edit.ShowDialog() == DialogResult.OK)
                {
                    nbt = edit.nbt;
                    treeView1.SelectedNode.Tag = nbt;
                    treeView1.SelectedNode.Text = nbt.GetTagString("Command").Value;
                }
            }
        }

        private void 検索ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FirstFind();
        }


        private void FirstFind()
        {
            if (treeView1.Nodes.Count > 0)
            {
                var findview = new View.FindView();
                if (findview.ShowDialog() == DialogResult.OK)
                {
                    findstr = findview.FindStr;
                    treeView1.SelectedNode = SearchNode(treeView1.Nodes, findstr);
                }
            }

        }

        private TreeNode SearchNode(TreeNodeCollection tns, string strID)
        {
            foreach (TreeNode tn in tns)
            {
                var compound = (NBTTagCompound)tn.Tag;
                if (tn.ImageIndex == 3 && compound.GetTagString("Command").Value.IndexOf(strID) != -1) return tn;
                if (tn.Nodes != null)
                {
                    TreeNode tnr = SearchNode(tn.Nodes, strID);
                    if (tnr != null) return tnr;
                }
            }
            return null;
        }

        private void 置換ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.Nodes.Count > 0)
            {
                var replaceview = new View.ReplaceView();
                if (replaceview.ShowDialog() == DialogResult.OK)
                {
                    AllReplace(treeView1.Nodes, replaceview.oldcommand, replaceview.newcommand);
                    MessageBox.Show("一括置換が完了しました");
                }
            }
        }

        private void AllReplace(TreeNodeCollection tns, string findstr, string replacestr)
        {
            foreach (TreeNode tn in tns)
            {
                if (tn.ImageIndex == 3 && tn.Text.IndexOf(findstr) != -1)
                {
                    tn.Text = tn.Text.Replace(findstr, replacestr);
                    var tag = (NBTTagCompound)tn.Tag;
                    tag.GetTagString("Command").Value = tag.GetTagString("Command").Value.Replace(findstr, replacestr);
                    treeView1.SelectedNode = tn;
                }
                if (tn.Nodes != null)
                {
                    AllReplace(tn.Nodes, findstr, replacestr);
                }
            }
        }
        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var setting = new View.Setting();
            setting.ShowDialog();
        }

        private void xMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveNBTDialog.ShowDialog() == DialogResult.OK)
            {
                var dataconvert = new Lib.DataConvert();
                dataconvert.SaveNBT(SaveNBTDialog.FileName, treeView1.Nodes);
                MessageBox.Show("保存が完了しました");
            }
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OpenNBTDialog.ShowDialog() == DialogResult.OK)
            {
                var dataconvert = new Lib.DataConvert();
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(dataconvert.OpenNBT(OpenNBTDialog.FileName));
                MessageBox.Show("読み込みが完了しました");
            }
        }

        private void テキストToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (SaveTextDialog.ShowDialog() == DialogResult.OK)
            {
                var dataconvert = new Lib.DataConvert();
                dataconvert.SaveText(SaveTextDialog.FileName, treeView1.Nodes);

                MessageBox.Show("保存が完了しました");
            }
        }

        private void テキストToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (OpenTextDialog.ShowDialog() == DialogResult.OK)
            {
                var dataconvert = new Lib.DataConvert();
                treeView1.Nodes.Clear();
                treeView1.Nodes.Add(dataconvert.OpenText(OpenTextDialog.FileName));
                MessageBox.Show("読み込みが完了しました");
            }
        }
    }
}
