using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SilverNBTLibrary;
using SilverNBTLibrary.World;

namespace ハルのコマンド抽出ツール.Lib
{
    class DataConvert
    {
        public void SaveNBT(string savepath, TreeNodeCollection nodes)
        {

            var compound = new NBTTagCompound(nodes[0].Text);
            var list = new NBTTagList("Commands");
            NodeToNBT(nodes, ref list);
            compound.Add(list);
            NBTFile.SaveToFile(savepath, compound);
        }

        private void NodeToNBT(TreeNodeCollection tns, ref NBTTagList list)
        {
            foreach (TreeNode tn in tns)
            {
                if (tn.ImageIndex == 3)
                {
                    var compound = (NBTTagCompound)tn.Tag;
                    list.Add(compound);
                }
                if (tn.Nodes != null)
                {
                    NodeToNBT(tn.Nodes,ref list);
                }
            }
        }

        public TreeNode OpenNBT(string filename)
        {
            var nbt = NBTFile.LoadFromFile(filename);
            var list = (NBTTagList)nbt.GetTag("Commands");
            var worldopen = new worldOpen();
            var node = worldopen.Load(filename, list);
            node.Text = nbt.Name;
            return node;
        }

        public void SaveText(string savepath, TreeNodeCollection nodes)
        {
            var compound = new NBTTagCompound();
            var list = new NBTTagList("Commands");
            NodeToNBT(nodes, ref list);
            compound.Add(list);
            var json = NBTFile.ToJson(compound, new SilverNBTLibrary.Serialization.JsonOptions() { Quotation = "\"" });
            System.IO.StreamWriter sw = new System.IO.StreamWriter(savepath,false,System.Text.Encoding.GetEncoding("utf-8"));
            //TextBox1.Textの内容を書き込む
            sw.Write(json);
            //閉じる
            sw.Close();
        }

        public TreeNode OpenText(string filename)
        {
            System.IO.StreamReader sr = new System.IO.StreamReader(filename,System.Text.Encoding.GetEncoding("utf-8"));
            //内容をすべて読み込む
            string json = sr.ReadToEnd();
            //閉じる
            sr.Close();

            var nbt = NBTFile.FromJson(json,SilverNBTLibrary.Serialization.JsonEngine.Accurate);
            var list = (NBTTagList)nbt.GetTag("Commands");
            var worldopen = new worldOpen();
            var node = worldopen.Load(filename, list);
            return node;
        }
    }
}
