using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ハルのコマンド抽出ツール.View
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.VersionIndex = comboBox1.SelectedIndex;
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Properties.Settings.Default.CommandBlock = "Control";
                    Properties.Settings.Default.Sign = "Sign";
                    break;
                case 1:
                    Properties.Settings.Default.CommandBlock = "minecraft:command_block";
                    Properties.Settings.Default.Sign = "minecraft:sign";
                    break;
            }

            Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = Properties.Settings.Default.VersionIndex;
        }
    }
}
