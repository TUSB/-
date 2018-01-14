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

namespace ハルのコマンド抽出ツール.View
{
    public partial class CommandEditView : Form
    {
        public NBTTagCompound nbt { set; get; }
        public CommandEditView()
        {
            InitializeComponent();
        }

        private void EditView_Load(object sender, EventArgs e)
        {
            Label1.Text = "X:" + nbt.GetTagInt("x").Value.ToString();
            Label2.Text = "Y:" + nbt.GetTagInt("y").Value.ToString();
            Label3.Text = "Z:" + nbt.GetTagInt("z").Value.ToString();
            Label5.Text = new ハルのコマンド抽出ツール.Lib.DimentionConvert().GetDimentionName(nbt.GetTagInt("Dimention").Value);
            textBox1.Text = nbt.GetTagString("Command").Value;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            nbt.GetTagString("Command").Value = textBox1.Text.Replace(Environment.NewLine, "");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Label6.Text = textBox1.Text.Replace(Environment.NewLine,"").Length.ToString() + "文字";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
                textBox1.SelectAll();
        }
    }
}
