namespace ハルのコマンド抽出ツール.View
{
    partial class CommandEditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(289, 90);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "情報";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(131, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(38, 12);
            this.Label3.TabIndex = 4;
            this.Label3.Text = "Label3";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(131, 43);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 12);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Label2";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(131, 18);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 12);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Label1";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(10, 43);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(35, 12);
            this.Label6.TabIndex = 1;
            this.Label6.Text = "0文字";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(10, 18);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(38, 12);
            this.Label5.TabIndex = 0;
            this.Label5.Text = "Label5";
            // 
            // Button2
            // 
            this.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Button2.Location = new System.Drawing.Point(226, 300);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 14;
            this.Button2.Text = "キャンセル";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button1.Location = new System.Drawing.Point(145, 300);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 13;
            this.Button1.Text = "OK";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 116);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(40, 12);
            this.Label4.TabIndex = 12;
            this.Label4.Text = "コマンド";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 151);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // CommandEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 334);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommandEditView";
            this.Text = "コマンド編集";
            this.Load += new System.EventHandler(this.EditView_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button Button2;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}