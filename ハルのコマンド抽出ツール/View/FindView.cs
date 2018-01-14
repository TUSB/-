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
    public partial class FindView : Form
    {
        public string FindStr { get; set; }

        public FindView()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FindStr = textBox1.Text.Replace(Environment.NewLine, "");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
