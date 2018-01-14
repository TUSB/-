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
    public partial class ReplaceView : Form
    {
        public string oldcommand { get; set; }
        public string newcommand { get; set; }

        public ReplaceView()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            oldcommand = textBox1.Text.Replace(Environment.NewLine, "");
            newcommand = textBox2.Text.Replace(Environment.NewLine, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ReplaceView_Load(object sender, EventArgs e)
        {

        }
    }
}
