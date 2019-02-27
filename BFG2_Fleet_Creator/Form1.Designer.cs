namespace BFG2_Fleet_Creator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxAdMech = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCorsair = new System.Windows.Forms.PictureBox();
            this.pictureBoxCraftworld = new System.Windows.Forms.PictureBox();
            this.pictureBoxDruk = new System.Windows.Forms.PictureBox();
            this.pictureBoxImperial = new System.Windows.Forms.PictureBox();
            this.pictureBoxTauM = new System.Windows.Forms.PictureBox();
            this.pictureBoxNecron = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrk = new System.Windows.Forms.PictureBox();
            this.pictureBoxMarines = new System.Windows.Forms.PictureBox();
            this.pictureBoxChaos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdMech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorsair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCraftworld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDruk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImperial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTauM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNecron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChaos)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(12, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 310);
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(188, 30);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(375, 572);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ship";
            this.columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cost";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 50;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6});
            this.listView2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.Location = new System.Drawing.Point(569, 30);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(375, 572);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
            this.listView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ship";
            this.columnHeader3.Width = 250;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Cost";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Type";
            this.columnHeader6.Width = 50;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(265, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear Fleet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Faction";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(185, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Available Ships";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(574, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fleet List";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(569, 626);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(586, 605);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fleet Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(475, 605);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Points Left";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(463, 626);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(793, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fleet Builder by Bosie v190227";
            // 
            // pictureBoxAdMech
            // 
            this.pictureBoxAdMech.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAdMech.Image = global::BFG2_Fleet_Creator.Properties.Resources.AM_Mars;
            this.pictureBoxAdMech.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxAdMech.Name = "pictureBoxAdMech";
            this.pictureBoxAdMech.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxAdMech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAdMech.TabIndex = 13;
            this.pictureBoxAdMech.TabStop = false;
            this.pictureBoxAdMech.Visible = false;
            this.pictureBoxAdMech.Click += new System.EventHandler(this.pictureBoxAdMech_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BFG2_Fleet_Creator.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 579);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBoxCorsair
            // 
            this.pictureBoxCorsair.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCorsair.Image = global::BFG2_Fleet_Creator.Properties.Resources.CORSAIR_EldritchRaiders;
            this.pictureBoxCorsair.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxCorsair.Name = "pictureBoxCorsair";
            this.pictureBoxCorsair.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxCorsair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCorsair.TabIndex = 14;
            this.pictureBoxCorsair.TabStop = false;
            this.pictureBoxCorsair.Visible = false;
            // 
            // pictureBoxCraftworld
            // 
            this.pictureBoxCraftworld.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCraftworld.Image = global::BFG2_Fleet_Creator.Properties.Resources.CRAFTWORLDER_Altoic;
            this.pictureBoxCraftworld.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxCraftworld.Name = "pictureBoxCraftworld";
            this.pictureBoxCraftworld.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxCraftworld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCraftworld.TabIndex = 15;
            this.pictureBoxCraftworld.TabStop = false;
            this.pictureBoxCraftworld.Visible = false;
            // 
            // pictureBoxDruk
            // 
            this.pictureBoxDruk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDruk.Image = global::BFG2_Fleet_Creator.Properties.Resources.DRUKHARI_BlackHeart;
            this.pictureBoxDruk.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxDruk.Name = "pictureBoxDruk";
            this.pictureBoxDruk.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxDruk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDruk.TabIndex = 16;
            this.pictureBoxDruk.TabStop = false;
            this.pictureBoxDruk.Visible = false;
            // 
            // pictureBoxImperial
            // 
            this.pictureBoxImperial.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxImperial.Image = global::BFG2_Fleet_Creator.Properties.Resources.IMP_Solar;
            this.pictureBoxImperial.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxImperial.Name = "pictureBoxImperial";
            this.pictureBoxImperial.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxImperial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImperial.TabIndex = 17;
            this.pictureBoxImperial.TabStop = false;
            this.pictureBoxImperial.Visible = false;
            // 
            // pictureBoxTauM
            // 
            this.pictureBoxTauM.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTauM.Image = global::BFG2_Fleet_Creator.Properties.Resources.MF_Tau;
            this.pictureBoxTauM.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxTauM.Name = "pictureBoxTauM";
            this.pictureBoxTauM.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxTauM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxTauM.TabIndex = 18;
            this.pictureBoxTauM.TabStop = false;
            this.pictureBoxTauM.Visible = false;
            // 
            // pictureBoxNecron
            // 
            this.pictureBoxNecron.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxNecron.Image = global::BFG2_Fleet_Creator.Properties.Resources.NECRON_Nepheru;
            this.pictureBoxNecron.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxNecron.Name = "pictureBoxNecron";
            this.pictureBoxNecron.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxNecron.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxNecron.TabIndex = 19;
            this.pictureBoxNecron.TabStop = false;
            this.pictureBoxNecron.Visible = false;
            // 
            // pictureBoxOrk
            // 
            this.pictureBoxOrk.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOrk.Image = global::BFG2_Fleet_Creator.Properties.Resources.ORK_Goffs;
            this.pictureBoxOrk.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxOrk.Name = "pictureBoxOrk";
            this.pictureBoxOrk.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxOrk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOrk.TabIndex = 20;
            this.pictureBoxOrk.TabStop = false;
            this.pictureBoxOrk.Visible = false;
            // 
            // pictureBoxMarines
            // 
            this.pictureBoxMarines.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMarines.Image = global::BFG2_Fleet_Creator.Properties.Resources.SM_WhiteScars;
            this.pictureBoxMarines.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxMarines.Name = "pictureBoxMarines";
            this.pictureBoxMarines.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxMarines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMarines.TabIndex = 21;
            this.pictureBoxMarines.TabStop = false;
            this.pictureBoxMarines.Visible = false;
            // 
            // pictureBoxChaos
            // 
            this.pictureBoxChaos.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChaos.Image = global::BFG2_Fleet_Creator.Properties.Resources.SMC_BlackLegion;
            this.pictureBoxChaos.Location = new System.Drawing.Point(12, 344);
            this.pictureBoxChaos.Name = "pictureBoxChaos";
            this.pictureBoxChaos.Size = new System.Drawing.Size(159, 159);
            this.pictureBoxChaos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxChaos.TabIndex = 22;
            this.pictureBoxChaos.TabStop = false;
            this.pictureBoxChaos.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BFG2_Fleet_Creator.Properties.Resources.Screenshot_Chaos_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(968, 666);
            this.Controls.Add(this.pictureBoxChaos);
            this.Controls.Add(this.pictureBoxMarines);
            this.Controls.Add(this.pictureBoxOrk);
            this.Controls.Add(this.pictureBoxNecron);
            this.Controls.Add(this.pictureBoxTauM);
            this.Controls.Add(this.pictureBoxImperial);
            this.Controls.Add(this.pictureBoxDruk);
            this.Controls.Add(this.pictureBoxCraftworld);
            this.Controls.Add(this.pictureBoxCorsair);
            this.Controls.Add(this.pictureBoxAdMech);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Battlefleet Gothic Armada II Fleet Builder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdMech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCorsair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCraftworld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDruk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImperial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTauM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNecron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMarines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChaos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBoxAdMech;
        private System.Windows.Forms.PictureBox pictureBoxCorsair;
        private System.Windows.Forms.PictureBox pictureBoxCraftworld;
        private System.Windows.Forms.PictureBox pictureBoxDruk;
        private System.Windows.Forms.PictureBox pictureBoxImperial;
        private System.Windows.Forms.PictureBox pictureBoxTauM;
        private System.Windows.Forms.PictureBox pictureBoxNecron;
        private System.Windows.Forms.PictureBox pictureBoxOrk;
        private System.Windows.Forms.PictureBox pictureBoxMarines;
        private System.Windows.Forms.PictureBox pictureBoxChaos;
    }
}

