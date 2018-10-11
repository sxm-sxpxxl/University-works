namespace ClassesLaboratory
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Your cart", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Dairy products", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Constructors", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Toys", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Video game", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "LEGO Batman Movie",
            "LEGO"}, 0, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Metal constructor Eitech", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Constructor First Builders MEGA BLOKS", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Wood constructor", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Toy \"Lion\"", 4);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Toy \"Bear\"", 5);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Toy \"Crocodile\"", 6);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Counter-Strike Global Offensive", 7);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("Witcher 3: Wild Hunt", 8);
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("Deus Ex: Human Revolution", 9);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem("Sid Meier\'s Civilization VI", 10);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("Milk", 11);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("Cheese", 12);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("Curd", 13);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("Sour cream", 14);
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CountOfGood = new System.Windows.Forms.Label();
            this.MainLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PayButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InfoGoodTextBox = new System.Windows.Forms.TextBox();
            this.OrderListView = new System.Windows.Forms.ListView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.GoodListView = new System.Windows.Forms.ListView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Online store";
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.CountOfGood);
            this.panel.Controls.Add(this.MainLabel);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(3, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1127, 30);
            this.panel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(807, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Count of good:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CountOfGood
            // 
            this.CountOfGood.BackColor = System.Drawing.SystemColors.Control;
            this.CountOfGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfGood.Location = new System.Drawing.Point(1060, 2);
            this.CountOfGood.Name = "CountOfGood";
            this.CountOfGood.Size = new System.Drawing.Size(61, 23);
            this.CountOfGood.TabIndex = 3;
            this.CountOfGood.Text = "0";
            this.CountOfGood.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainLabel
            // 
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainLabel.Location = new System.Drawing.Point(3, 0);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(457, 28);
            this.MainLabel.TabIndex = 2;
            this.MainLabel.Text = "Select products";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PayButton);
            this.groupBox1.Controls.Add(this.panel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1133, 70);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main";
            // 
            // PayButton
            // 
            this.PayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayButton.Location = new System.Drawing.Point(811, 9);
            this.PayButton.Name = "PayButton";
            this.PayButton.Size = new System.Drawing.Size(314, 28);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay for the purchase";
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.InfoGoodTextBox);
            this.groupBox2.Controls.Add(this.OrderListView);
            this.groupBox2.Controls.Add(this.GoodListView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1133, 565);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Goods";
            // 
            // InfoGoodTextBox
            // 
            this.InfoGoodTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoGoodTextBox.Location = new System.Drawing.Point(12, 19);
            this.InfoGoodTextBox.Multiline = true;
            this.InfoGoodTextBox.Name = "InfoGoodTextBox";
            this.InfoGoodTextBox.ReadOnly = true;
            this.InfoGoodTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InfoGoodTextBox.Size = new System.Drawing.Size(298, 534);
            this.InfoGoodTextBox.TabIndex = 2;
            // 
            // OrderListView
            // 
            this.OrderListView.BackColor = System.Drawing.SystemColors.Window;
            this.OrderListView.FullRowSelect = true;
            listViewGroup1.Header = "Your cart";
            listViewGroup1.Name = "OrderListViewGroup";
            this.OrderListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.OrderListView.LargeImageList = this.ImageList;
            this.OrderListView.Location = new System.Drawing.Point(316, 409);
            this.OrderListView.Name = "OrderListView";
            this.OrderListView.ShowItemToolTips = true;
            this.OrderListView.Size = new System.Drawing.Size(805, 144);
            this.OrderListView.TabIndex = 1;
            this.OrderListView.UseCompatibleStateImageBehavior = false;
            this.OrderListView.ItemActivate += new System.EventHandler(this.ListView_ItemActivate);
            this.OrderListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OrderListView_ItemSelectionChanged);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ImageList.Images.SetKeyName(0, "constructorLegoBatman.jpg");
            this.ImageList.Images.SetKeyName(1, "constructorMetal.jpg");
            this.ImageList.Images.SetKeyName(2, "constructorPlastic.jpg");
            this.ImageList.Images.SetKeyName(3, "constructorWood.jpg");
            this.ImageList.Images.SetKeyName(4, "toy.jpg");
            this.ImageList.Images.SetKeyName(5, "panda.jpg");
            this.ImageList.Images.SetKeyName(6, "toy1.jpg");
            this.ImageList.Images.SetKeyName(7, "cs.jpg");
            this.ImageList.Images.SetKeyName(8, "witcher.jpg");
            this.ImageList.Images.SetKeyName(9, "deus.jpg");
            this.ImageList.Images.SetKeyName(10, "civa.jpg");
            this.ImageList.Images.SetKeyName(11, "milk.jpg");
            this.ImageList.Images.SetKeyName(12, "cheese.jpg");
            this.ImageList.Images.SetKeyName(13, "tvorog.jpg");
            this.ImageList.Images.SetKeyName(14, "smetana.jpg");
            // 
            // GoodListView
            // 
            this.GoodListView.BackColor = System.Drawing.SystemColors.Window;
            this.GoodListView.FullRowSelect = true;
            listViewGroup2.Header = "Dairy products";
            listViewGroup2.Name = "MilkProductsListViewGroup";
            listViewGroup3.Header = "Constructors";
            listViewGroup3.Name = "ConstructorsListViewGroup";
            listViewGroup4.Header = "Toys";
            listViewGroup4.Name = "ToysListViewGroup";
            listViewGroup5.Header = "Video game";
            listViewGroup5.Name = "VideoGameListViewGroup";
            this.GoodListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5});
            listViewItem1.Group = listViewGroup3;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "0";
            listViewItem1.ToolTipText = "LEGO Batman Movie - Price: 1500$";
            listViewItem1.UseItemStyleForSubItems = false;
            listViewItem2.Group = listViewGroup3;
            listViewItem2.Tag = "1";
            listViewItem3.Group = listViewGroup3;
            listViewItem3.Tag = "2";
            listViewItem4.Group = listViewGroup3;
            listViewItem4.Tag = "3";
            listViewItem5.Group = listViewGroup4;
            listViewItem5.Tag = "4";
            listViewItem6.Group = listViewGroup4;
            listViewItem6.Tag = "5";
            listViewItem7.Group = listViewGroup4;
            listViewItem7.Tag = "6";
            listViewItem8.Group = listViewGroup5;
            listViewItem8.Tag = "7";
            listViewItem9.Group = listViewGroup5;
            listViewItem9.Tag = "8";
            listViewItem10.Group = listViewGroup5;
            listViewItem10.Tag = "9";
            listViewItem11.Group = listViewGroup5;
            listViewItem11.Tag = "10";
            listViewItem12.Group = listViewGroup2;
            listViewItem13.Group = listViewGroup2;
            listViewItem14.Group = listViewGroup2;
            listViewItem15.Group = listViewGroup2;
            this.GoodListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15});
            this.GoodListView.LargeImageList = this.ImageList;
            this.GoodListView.Location = new System.Drawing.Point(316, 19);
            this.GoodListView.Name = "GoodListView";
            this.GoodListView.ShowItemToolTips = true;
            this.GoodListView.Size = new System.Drawing.Size(805, 384);
            this.GoodListView.TabIndex = 0;
            this.GoodListView.UseCompatibleStateImageBehavior = false;
            this.GoodListView.ItemActivate += new System.EventHandler(this.ListView_ItemActivate);
            this.GoodListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.OrderListView_ItemSelectionChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 635);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Online Store";
            this.panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView GoodListView;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button PayButton;
        private System.Windows.Forms.Label CountOfGood;
        private System.Windows.Forms.ListView OrderListView;
        private System.Windows.Forms.TextBox InfoGoodTextBox;
        private System.Windows.Forms.Label label3;
    }
}

