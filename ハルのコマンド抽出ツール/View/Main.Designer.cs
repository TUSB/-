namespace ハルのコマンド抽出ツール
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ワールドを開くToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ワールドを保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.読み込みToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.出力ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データ編集ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.検索ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.置換ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWorldDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenWorldWorker = new System.ComponentModel.BackgroundWorker();
            this.SaveWorldWorker = new System.ComponentModel.BackgroundWorker();
            this.SaveTextDialog = new System.Windows.Forms.SaveFileDialog();
            this.SaveNBTDialog = new System.Windows.Forms.SaveFileDialog();
            this.OpenNBTDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.テキストToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.テキストToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 27);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(478, 341);
            this.treeView1.TabIndex = 7;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Nether_Quartz_Ore.png");
            this.imageList1.Images.SetKeyName(1, "Grass.png");
            this.imageList1.Images.SetKeyName(2, "End_Gateway_(block).png");
            this.imageList1.Images.SetKeyName(3, "Command_Block.png");
            this.imageList1.Images.SetKeyName(4, "Wall_Sign.png");
            this.imageList1.Images.SetKeyName(5, "folder-open.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.編集ToolStripMenuItem,
            this.検索ToolStripMenuItem,
            this.設定ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(478, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ワールドを開くToolStripMenuItem,
            this.ワールドを保存ToolStripMenuItem,
            this.toolStripSeparator1,
            this.読み込みToolStripMenuItem,
            this.出力ToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ファイルToolStripMenuItem.Text = "ファイル";
            // 
            // ワールドを開くToolStripMenuItem
            // 
            this.ワールドを開くToolStripMenuItem.Name = "ワールドを開くToolStripMenuItem";
            this.ワールドを開くToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.ワールドを開くToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.ワールドを開くToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ワールドを開くToolStripMenuItem.Text = "ワールドを開く";
            this.ワールドを開くToolStripMenuItem.Click += new System.EventHandler(this.ワールドを開くToolStripMenuItem_Click);
            // 
            // ワールドを保存ToolStripMenuItem
            // 
            this.ワールドを保存ToolStripMenuItem.Name = "ワールドを保存ToolStripMenuItem";
            this.ワールドを保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.ワールドを保存ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ワールドを保存ToolStripMenuItem.Text = "ワールドを保存";
            this.ワールドを保存ToolStripMenuItem.Click += new System.EventHandler(this.ワールドを保存ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // 読み込みToolStripMenuItem
            // 
            this.読み込みToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem1,
            this.テキストToolStripMenuItem1});
            this.読み込みToolStripMenuItem.Name = "読み込みToolStripMenuItem";
            this.読み込みToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.読み込みToolStripMenuItem.Text = "読み込み";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem1.Text = "NBT";
            this.xMLToolStripMenuItem1.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // 出力ToolStripMenuItem
            // 
            this.出力ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.テキストToolStripMenuItem});
            this.出力ToolStripMenuItem.Name = "出力ToolStripMenuItem";
            this.出力ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.出力ToolStripMenuItem.Text = "出力";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xMLToolStripMenuItem.Text = "NBT";
            this.xMLToolStripMenuItem.Click += new System.EventHandler(this.xMLToolStripMenuItem_Click);
            // 
            // 編集ToolStripMenuItem
            // 
            this.編集ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データ編集ToolStripMenuItem});
            this.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem";
            this.編集ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編集ToolStripMenuItem.Text = "編集";
            // 
            // データ編集ToolStripMenuItem
            // 
            this.データ編集ToolStripMenuItem.Name = "データ編集ToolStripMenuItem";
            this.データ編集ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.データ編集ToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.データ編集ToolStripMenuItem.Text = "データ編集";
            this.データ編集ToolStripMenuItem.Click += new System.EventHandler(this.データ編集ToolStripMenuItem_Click);
            // 
            // 検索ToolStripMenuItem
            // 
            this.検索ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.検索ToolStripMenuItem1,
            this.toolStripSeparator2,
            this.置換ToolStripMenuItem});
            this.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem";
            this.検索ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.検索ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.検索ToolStripMenuItem.Text = "検索";
            // 
            // 検索ToolStripMenuItem1
            // 
            this.検索ToolStripMenuItem1.Name = "検索ToolStripMenuItem1";
            this.検索ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.検索ToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.検索ToolStripMenuItem1.Text = "検索";
            this.検索ToolStripMenuItem1.Click += new System.EventHandler(this.検索ToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(134, 6);
            // 
            // 置換ToolStripMenuItem
            // 
            this.置換ToolStripMenuItem.Name = "置換ToolStripMenuItem";
            this.置換ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.置換ToolStripMenuItem.Text = "一括置換";
            this.置換ToolStripMenuItem.Click += new System.EventHandler(this.置換ToolStripMenuItem_Click);
            // 
            // 設定ToolStripMenuItem
            // 
            this.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem";
            this.設定ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.設定ToolStripMenuItem.Text = "設定";
            this.設定ToolStripMenuItem.Click += new System.EventHandler(this.設定ToolStripMenuItem_Click);
            // 
            // OpenWorldDialog
            // 
            this.OpenWorldDialog.Filter = "ワールドファイル(level.dat)|level.dat";
            // 
            // OpenWorldWorker
            // 
            this.OpenWorldWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.OpenWorldWorker_DoWork);
            this.OpenWorldWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.OpenWorldWorker_RunWorkerCompleted);
            // 
            // SaveWorldWorker
            // 
            this.SaveWorldWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveWorldWorker_DoWork);
            this.SaveWorldWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SaveWorldWorker_RunWorkerCompleted);
            // 
            // SaveTextDialog
            // 
            this.SaveTextDialog.Filter = "コマンドファイル(*.txt)|*.txt";
            // 
            // SaveNBTDialog
            // 
            this.SaveNBTDialog.Filter = "コマンドファイル(*.nbt)|*.nbt";
            // 
            // OpenNBTDialog
            // 
            this.OpenNBTDialog.Filter = "コマンドファイル(*.nbt)|*.nbt";
            // 
            // OpenTextDialog
            // 
            this.OpenTextDialog.Filter = "コマンドファイル(*.txt)|*.txt";
            // 
            // テキストToolStripMenuItem
            // 
            this.テキストToolStripMenuItem.Name = "テキストToolStripMenuItem";
            this.テキストToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.テキストToolStripMenuItem.Text = "テキスト";
            this.テキストToolStripMenuItem.Click += new System.EventHandler(this.テキストToolStripMenuItem_Click);
            // 
            // テキストToolStripMenuItem1
            // 
            this.テキストToolStripMenuItem1.Name = "テキストToolStripMenuItem1";
            this.テキストToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.テキストToolStripMenuItem1.Text = "テキスト";
            this.テキストToolStripMenuItem1.Click += new System.EventHandler(this.テキストToolStripMenuItem1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 369);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "ハルのコマンド抽出ツール";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ワールドを開くToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ワールドを保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem 読み込みToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出力ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem データ編集ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 検索ToolStripMenuItem1;
        internal System.Windows.Forms.OpenFileDialog OpenWorldDialog;
        internal System.ComponentModel.BackgroundWorker OpenWorldWorker;
        internal System.ComponentModel.BackgroundWorker SaveWorldWorker;
        private System.Windows.Forms.SaveFileDialog SaveTextDialog;
        private System.Windows.Forms.SaveFileDialog SaveNBTDialog;
        internal System.Windows.Forms.OpenFileDialog OpenNBTDialog;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 置換ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenTextDialog;
        private System.Windows.Forms.ToolStripMenuItem 設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem テキストToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem テキストToolStripMenuItem;
    }
}

