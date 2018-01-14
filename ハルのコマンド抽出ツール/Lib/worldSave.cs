using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverNBTLibrary;
using SilverNBTLibrary.World;
using System.Windows.Forms;

namespace ハルのコマンド抽出ツール.Lib
{
    class worldSave
    {
        private NBTTagList list = new NBTTagList();
        public void Save(string worldPath, TreeNode n)
        {
            NodeToTileEntity(n);
            var w = World.FromDirectory(worldPath);

            foreach(NBTTagCompound com in list)
            {
                var d = w.GetDimension(com.GetTagInt("Dimention").Value);
                com.Remove("Dimention");
                var tile = new TileEntity(com);
                var x = com.GetTagInt("x").Value;
                var y = com.GetTagInt("y").Value;
                var z = com.GetTagInt("z").Value;
                tile.XCoord = x;
                tile.YCoord = y;
                tile.ZCoord = z;
                tile.NBTData.GetTagString("id").Value = Properties.Settings.Default.CommandBlock;
                d.SetTileEntity(x, y, z, tile);
            }
            w.Save();
        }

        private void NodeToTileEntity(TreeNode n)
        {
            if (n.ImageIndex == 3 || n.ImageIndex == 4)
            {
                var com = (NBTTagCompound)n.Tag;
                list.Add((NBTTagCompound)com.Clone());
            }
            foreach (TreeNode node in n.Nodes)
            {
                NodeToTileEntity(node);
            }
        }
    }
}
