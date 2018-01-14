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
    class worldOpen
    {
        private NBTTagList list = new NBTTagList();
        private int count;

        public TreeNode Load(string filepath, NBTTagList nbtlist = null)
        {
            list.Clear();
            if (nbtlist == null)
            {
                LoadWorld(filepath);
            }
            else
            {
                list = nbtlist;
            }

            var root = new TreeNode(System.IO.Path.GetFileNameWithoutExtension(filepath), 5, 5);

            

            var overworld = new TreeNode("OverWorld", 1, 1);
            int overworldcount = 0;

            var end = new TreeNode("The END", 2, 2);
            int endcount = 0;

            var nether = new TreeNode("Nether", 0, 0);
            int nethercount = 0;

            foreach (NBTTagCompound com in list)
            {
                var dimention = com.GetTagInt("Dimention").Value;
                switch (dimention)
                {
                    case 1:
                        endcount++;
                        AddTree(ref end, com);
                        break;
                    case 0:
                        overworldcount++;
                        AddTree(ref overworld, com);
                        break;
                    case -1:
                        nethercount++;
                        AddTree(ref nether, com);
                        break;
                }
            }

            root.Nodes.Add(overworld);
            root.Nodes.Add(nether);
            root.Nodes.Add(end);
            AddCount(ref root);
            return root;
        }

        private void AddCount(ref TreeNode node)
        {
            if (node.Nodes.Count > 0)
            {
                count = 0;
                recursive(node);
                node.Text += string.Format(" コマンド数:{0}", count);
            }
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes.Count > 0)
                {
                    var next = node.Nodes[i];
                    AddCount(ref next);
                }
            }
        }

        private void recursive(TreeNode node)
        {
            if (node.ImageIndex == 3)
            {
                count++;
            }
            foreach (TreeNode tn in node.Nodes)
            {
                recursive(tn);
            }
        }

        private void AddTree(ref TreeNode node, NBTTagCompound com)
        {

            var addnode = new TreeNode();
            var genrenode = new TreeNode();
            addnode.Tag = com;
            if (com.GetTagString("id").Value == Properties.Settings.Default.CommandBlock)
            {
                addnode.ImageIndex = 3;
                addnode.SelectedImageIndex = 3;
                var command = com.GetTagString("Command").Value;
                addnode.Text = command;
                if (command.IndexOf(" ") != -1)
                {
                    var split = command.Split(' ');
                    var index = GetIndex(node, split[0]);
                    if (index == -1)
                    {
                        genrenode.Nodes.Add(addnode);
                        genrenode.ImageIndex = 5;
                        genrenode.SelectedImageIndex = 5;
                        genrenode.Text = split[0];
                        node.Nodes.Add(genrenode);
                    }
                    else
                    {
                        node.Nodes[index].Nodes.Add(addnode);
                    }
                }
                else
                {
                    var index = GetIndex(node, "その他");
                    if (index == -1)
                    {
                        genrenode.Text = "その他";
                        genrenode.Nodes.Add(addnode);
                        genrenode.ImageIndex = 5;
                        genrenode.SelectedImageIndex = 5;
                        node.Nodes.Add(genrenode);
                    }
                    else
                    {
                        node.Nodes[index].Nodes.Add(addnode);
                    }
                }
            }
            else
            {
                addnode.ImageIndex = 4;
                addnode.SelectedImageIndex = 4;
                var sb = new StringBuilder();
                for (int i = 1; i < 5; i++)
                {
                    if (com.ContainsKey("Text" + i))
                    {
                        sb.Append("Text" + i + ":" + com.GetTagString("Text" + i).Value + " ");
                    }
                }
                addnode.Text = sb.ToString();
                var index = GetIndex(node, "その他");
                if (index == -1)
                {
                    genrenode.Text = "その他";
                    genrenode.Nodes.Add(addnode);
                    genrenode.ImageIndex = 5;
                    genrenode.SelectedImageIndex = 5;
                    node.Nodes.Add(genrenode);
                }
                else
                {
                    node.Nodes[index].Nodes.Add(addnode);
                }
            }
        }

        private int GetIndex(TreeNode node, string name)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                if (node.Nodes[i].Text == name)
                {
                    return i;
                }
            }
            return -1;
        }

        private void LoadWorld(string worldPath)
        {
            var w = World.FromDirectory(worldPath);

            foreach (var d in w.Worlds)
            {
                var world = new NBTTagList();
                foreach (var te in GetAllTileEntities(d))
                {
                    if (te.Id == Properties.Settings.Default.CommandBlock)// || Propeties.Settings.Default.Sign
                    {
                        /*
                        if (te.Id == Properties.Settings.Default.Sign)
                        {
                            bool command = false;
                            for (int i = 1; i < 5; i++)
                            {

                                if (te.NBTData.ContainsKey("Text" + i))
                                {
                                    if (te.NBTData.GetTagString("Text" + i).Value.IndexOf("clickEvent") != -1)
                                    {
                                        command = true;
                                    }
                                }
                            }
                            if (!command)
                                continue;
                        }*/
                        var com = te.NBTData;
                        com.Add(new NBTTagInt("Dimention", d.DimensionID));
                        list.Add(com);
                    }
                }

                d.Dispose();
            }

            w.Dispose();
        }

        private IList<Entity> GetAllEntities(Dimension d)
        {
            List<Entity> entityList = new List<Entity>();
            foreach (Chunk andLoadAllChunk in d.GetAndLoadAllChunks(true))
            {
                foreach (List<Entity> entity in andLoadAllChunk.EntityList)
                    entityList.AddRange((IEnumerable<Entity>)entity);
            }
            return (IList<Entity>)entityList;
        }

        private IList<TileEntity> GetAllTileEntities(Dimension d)
        {
            List<TileEntity> tileEntityList = new List<TileEntity>();
            foreach (Chunk andLoadAllChunk in d.GetAndLoadAllChunks(true))
                tileEntityList.AddRange((IEnumerable<TileEntity>)andLoadAllChunk.GetTileEntities());
            return (IList<TileEntity>)tileEntityList;
        }

    }
}
