namespace WindowsFormsApplication1
{
    partial class RetunB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetunB));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sser = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.Button();
            this.bref = new System.Windows.Forms.Button();
            this.tP = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpR = new System.Windows.Forms.DateTimePicker();
            this.cbb = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.caan = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DV = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.sser);
            this.panel1.Controls.Add(this.cb);
            this.panel1.Controls.Add(this.bref);
            this.panel1.Controls.Add(this.tP);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 398);
            this.panel1.TabIndex = 0;
            // 
            // sser
            // 
            this.sser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.sser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sser.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sser.Location = new System.Drawing.Point(55, 243);
            this.sser.Name = "sser";
            this.sser.Size = new System.Drawing.Size(159, 37);
            this.sser.TabIndex = 1;
            this.sser.Text = "Search Student";
            this.sser.UseVisualStyleBackColor = false;
            this.sser.Click += new System.EventHandler(this.sser_Click);
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Red;
            this.cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb.Location = new System.Drawing.Point(142, 326);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(96, 30);
            this.cb.TabIndex = 3;
            this.cb.Text = "Cancel";
            this.cb.UseVisualStyleBackColor = false;
            this.cb.Click += new System.EventHandler(this.cb_Click);
            // 
            // bref
            // 
            this.bref.BackColor = System.Drawing.Color.LightSeaGreen;
            this.bref.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bref.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bref.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bref.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bref.Location = new System.Drawing.Point(27, 326);
            this.bref.Name = "bref";
            this.bref.Size = new System.Drawing.Size(96, 30);
            this.bref.TabIndex = 2;
            this.bref.Text = "Refresh";
            this.bref.UseVisualStyleBackColor = false;
            this.bref.Click += new System.EventHandler(this.bref_Click);
            // 
            // tP
            // 
            this.tP.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tP.Location = new System.Drawing.Point(31, 190);
            this.tP.Name = "tP";
            this.tP.Size = new System.Drawing.Size(211, 27);
            this.tP.TabIndex = 0;
            this.tP.TextChanged += new System.EventHandler(this.tP_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.icons8_student_male_100;
            this.pictureBox1.Location = new System.Drawing.Point(65, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PeachPuff;
            this.panel3.Controls.Add(this.dtpR);
            this.panel3.Controls.Add(this.cbb);
            this.panel3.Controls.Add(this.re);
            this.panel3.Controls.Add(this.txtI);
            this.panel3.Controls.Add(this.txtN);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(281, 426);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(720, 170);
            this.panel3.TabIndex = 3;
            // 
            // dtpR
            // 
            this.dtpR.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpR.Location = new System.Drawing.Point(256, 130);
            this.dtpR.Name = "dtpR";
            this.dtpR.Size = new System.Drawing.Size(221, 24);
            this.dtpR.TabIndex = 2;
            // 
            // cbb
            // 
            this.cbb.BackColor = System.Drawing.Color.Red;
            this.cbb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbb.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbb.Location = new System.Drawing.Point(526, 107);
            this.cbb.Name = "cbb";
            this.cbb.Size = new System.Drawing.Size(106, 30);
            this.cbb.TabIndex = 4;
            this.cbb.Text = "Cancel";
            this.cbb.UseVisualStyleBackColor = false;
            this.cbb.Click += new System.EventHandler(this.cbb_Click);
            // 
            // re
            // 
            this.re.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.re.BackColor = System.Drawing.Color.DarkOrange;
            this.re.Cursor = System.Windows.Forms.Cursors.Hand;
            this.re.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.re.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.re.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.re.Location = new System.Drawing.Point(526, 48);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(106, 30);
            this.re.TabIndex = 3;
            this.re.Text = "Retun ";
            this.re.UseVisualStyleBackColor = false;
            this.re.Click += new System.EventHandler(this.re_Click);
            // 
            // txtI
            // 
            this.txtI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtI.Location = new System.Drawing.Point(256, 75);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(221, 24);
            this.txtI.TabIndex = 1;
            // 
            // txtN
            // 
            this.txtN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN.Location = new System.Drawing.Point(256, 23);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(221, 24);
            this.txtN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Book Return Date";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(49, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Book Issue Date";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 26);
            this.label8.TabIndex = 15;
            this.label8.Text = "Book Name";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Controls.Add(this.caan);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(999, 24);
            this.panel4.TabIndex = 23;
            // 
            // caan
            // 
            this.caan.AutoSize = true;
            this.caan.BackColor = System.Drawing.Color.Aqua;
            this.caan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.caan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caan.ForeColor = System.Drawing.Color.Black;
            this.caan.Location = new System.Drawing.Point(975, 0);
            this.caan.Name = "caan";
            this.caan.Size = new System.Drawing.Size(24, 24);
            this.caan.TabIndex = 21;
            this.caan.Text = "X";
            this.caan.Click += new System.EventHandler(this.caan_Click);
            this.caan.MouseLeave += new System.EventHandler(this.caan_MouseLeave);
            this.caan.MouseHover += new System.EventHandler(this.caan_MouseHover);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Aqua;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(1048, -3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "X";
            // 
            // DV
            // 
            this.DV.AllowUserToAddRows = false;
            this.DV.AllowUserToDeleteRows = false;
            this.DV.AllowUserToResizeColumns = false;
            this.DV.AllowUserToResizeRows = false;
            this.DV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DV.ColumnHeadersHeight = 48;
            this.DV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DV.DefaultCellStyle = dataGridViewCellStyle2;
            this.DV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DV.Location = new System.Drawing.Point(281, 24);
            this.DV.Margin = new System.Windows.Forms.Padding(6);
            this.DV.Name = "DV";
            this.DV.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DV.RowHeadersWidth = 45;
            this.DV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DV.Size = new System.Drawing.Size(720, 398);
            this.DV.TabIndex = 29;
            this.DV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DV_CellClick);
            this.DV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DV_CellContentClick);
            // 
            // RetunB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1008, 435);
            this.Controls.Add(this.DV);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RetunB";
            this.Text = "RetunB";
            this.Load += new System.EventHandler(this.RetunB_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tP;
        private System.Windows.Forms.Button cb;
        private System.Windows.Forms.Button bref;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Button re;
        private System.Windows.Forms.Button cbb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label caan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpR;
        private System.Windows.Forms.Button sser;
        private System.Windows.Forms.DataGridView DV;
    }
}