namespace WindowsFormsApplication1
{
    partial class CompleteBD
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompleteBD));
            this.panel4 = new System.Windows.Forms.Panel();
            this.caan = new System.Windows.Forms.Label();
            this.dv1 = new System.Windows.Forms.DataGridView();
            this.sPRNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssuedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet = new WindowsFormsApplication1.libDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.iRBookTableAdapter = new WindowsFormsApplication1.libDataSetTableAdapters.IRBookTableAdapter();
            this.dv2 = new System.Windows.Forms.DataGridView();
            this.sPRNDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDepDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSemDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sContDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEmailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookReturnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iRBookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libDataSet1 = new WindowsFormsApplication1.libDataSet1();
            this.iRBookTableAdapter1 = new WindowsFormsApplication1.libDataSet1TableAdapters.IRBookTableAdapter();
            this.t2 = new System.Windows.Forms.TextBox();
            this.t1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnrefr = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Aqua;
            this.panel4.Controls.Add(this.caan);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1060, 24);
            this.panel4.TabIndex = 24;
            // 
            // caan
            // 
            this.caan.AutoSize = true;
            this.caan.BackColor = System.Drawing.Color.Aqua;
            this.caan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.caan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caan.ForeColor = System.Drawing.Color.Black;
            this.caan.Location = new System.Drawing.Point(1036, -1);
            this.caan.Name = "caan";
            this.caan.Size = new System.Drawing.Size(24, 24);
            this.caan.TabIndex = 25;
            this.caan.Text = "X";
            this.caan.Click += new System.EventHandler(this.caan_Click);
            this.caan.MouseLeave += new System.EventHandler(this.caan_MouseLeave);
            this.caan.MouseHover += new System.EventHandler(this.caan_MouseHover);
            // 
            // dv1
            // 
            this.dv1.AllowUserToAddRows = false;
            this.dv1.AllowUserToDeleteRows = false;
            this.dv1.AllowUserToResizeColumns = false;
            this.dv1.AllowUserToResizeRows = false;
            this.dv1.AutoGenerateColumns = false;
            this.dv1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dv1.ColumnHeadersHeight = 48;
            this.dv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPRNDataGridViewTextBoxColumn,
            this.sNameDataGridViewTextBoxColumn,
            this.sDepDataGridViewTextBoxColumn,
            this.sSemDataGridViewTextBoxColumn,
            this.sContDataGridViewTextBoxColumn,
            this.sEmailDataGridViewTextBoxColumn,
            this.bNameDataGridViewTextBoxColumn,
            this.bookIssuedDateDataGridViewTextBoxColumn});
            this.dv1.DataSource = this.iRBookBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dv1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dv1.Location = new System.Drawing.Point(15, 61);
            this.dv1.Margin = new System.Windows.Forms.Padding(6);
            this.dv1.Name = "dv1";
            this.dv1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dv1.RowHeadersWidth = 45;
            this.dv1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dv1.Size = new System.Drawing.Size(1030, 243);
            this.dv1.TabIndex = 30;
            // 
            // sPRNDataGridViewTextBoxColumn
            // 
            this.sPRNDataGridViewTextBoxColumn.DataPropertyName = "S_PRN";
            this.sPRNDataGridViewTextBoxColumn.HeaderText = "S_PRN";
            this.sPRNDataGridViewTextBoxColumn.Name = "sPRNDataGridViewTextBoxColumn";
            this.sPRNDataGridViewTextBoxColumn.ReadOnly = true;
            this.sPRNDataGridViewTextBoxColumn.Width = 120;
            // 
            // sNameDataGridViewTextBoxColumn
            // 
            this.sNameDataGridViewTextBoxColumn.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn.Name = "sNameDataGridViewTextBoxColumn";
            this.sNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // sDepDataGridViewTextBoxColumn
            // 
            this.sDepDataGridViewTextBoxColumn.DataPropertyName = "S_Dep";
            this.sDepDataGridViewTextBoxColumn.HeaderText = "S_Dep";
            this.sDepDataGridViewTextBoxColumn.Name = "sDepDataGridViewTextBoxColumn";
            this.sDepDataGridViewTextBoxColumn.ReadOnly = true;
            this.sDepDataGridViewTextBoxColumn.Width = 110;
            // 
            // sSemDataGridViewTextBoxColumn
            // 
            this.sSemDataGridViewTextBoxColumn.DataPropertyName = "S_Sem";
            this.sSemDataGridViewTextBoxColumn.HeaderText = "S_Sem";
            this.sSemDataGridViewTextBoxColumn.Name = "sSemDataGridViewTextBoxColumn";
            this.sSemDataGridViewTextBoxColumn.ReadOnly = true;
            this.sSemDataGridViewTextBoxColumn.Width = 110;
            // 
            // sContDataGridViewTextBoxColumn
            // 
            this.sContDataGridViewTextBoxColumn.DataPropertyName = "S_Cont";
            this.sContDataGridViewTextBoxColumn.HeaderText = "S_Cont";
            this.sContDataGridViewTextBoxColumn.Name = "sContDataGridViewTextBoxColumn";
            this.sContDataGridViewTextBoxColumn.ReadOnly = true;
            this.sContDataGridViewTextBoxColumn.Width = 110;
            // 
            // sEmailDataGridViewTextBoxColumn
            // 
            this.sEmailDataGridViewTextBoxColumn.DataPropertyName = "S_Email";
            this.sEmailDataGridViewTextBoxColumn.HeaderText = "S_Email";
            this.sEmailDataGridViewTextBoxColumn.Name = "sEmailDataGridViewTextBoxColumn";
            this.sEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.sEmailDataGridViewTextBoxColumn.Width = 110;
            // 
            // bNameDataGridViewTextBoxColumn
            // 
            this.bNameDataGridViewTextBoxColumn.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn.HeaderText = "B_Name";
            this.bNameDataGridViewTextBoxColumn.Name = "bNameDataGridViewTextBoxColumn";
            this.bNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.bNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // bookIssuedDateDataGridViewTextBoxColumn
            // 
            this.bookIssuedDateDataGridViewTextBoxColumn.DataPropertyName = "Book_Issued_Date";
            this.bookIssuedDateDataGridViewTextBoxColumn.HeaderText = "Book_Issued_Date";
            this.bookIssuedDateDataGridViewTextBoxColumn.Name = "bookIssuedDateDataGridViewTextBoxColumn";
            this.bookIssuedDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIssuedDateDataGridViewTextBoxColumn.Width = 182;
            // 
            // iRBookBindingSource
            // 
            this.iRBookBindingSource.DataMember = "IRBook";
            this.iRBookBindingSource.DataSource = this.libDataSet;
            // 
            // libDataSet
            // 
            this.libDataSet.DataSetName = "libDataSet";
            this.libDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Issued Books";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeight = 48;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2.Location = new System.Drawing.Point(15, 637);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView2.RowHeadersWidth = 45;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.Size = new System.Drawing.Size(1030, 243);
            this.dataGridView2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(34, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 28);
            this.label2.TabIndex = 31;
            this.label2.Text = "Returned Book";
            // 
            // iRBookTableAdapter
            // 
            this.iRBookTableAdapter.ClearBeforeFill = true;
            // 
            // dv2
            // 
            this.dv2.AllowUserToAddRows = false;
            this.dv2.AllowUserToDeleteRows = false;
            this.dv2.AllowUserToResizeColumns = false;
            this.dv2.AllowUserToResizeRows = false;
            this.dv2.AutoGenerateColumns = false;
            this.dv2.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.MediumTurquoise;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Indigo;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dv2.ColumnHeadersHeight = 48;
            this.dv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dv2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sPRNDataGridViewTextBoxColumn1,
            this.sNameDataGridViewTextBoxColumn1,
            this.sDepDataGridViewTextBoxColumn1,
            this.sSemDataGridViewTextBoxColumn1,
            this.sContDataGridViewTextBoxColumn1,
            this.sEmailDataGridViewTextBoxColumn1,
            this.bNameDataGridViewTextBoxColumn1,
            this.bookReturnDateDataGridViewTextBoxColumn});
            this.dv2.DataSource = this.iRBookBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dv2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dv2.Location = new System.Drawing.Point(15, 355);
            this.dv2.Margin = new System.Windows.Forms.Padding(6);
            this.dv2.Name = "dv2";
            this.dv2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dv2.RowHeadersWidth = 45;
            this.dv2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dv2.Size = new System.Drawing.Size(1030, 243);
            this.dv2.TabIndex = 30;
            // 
            // sPRNDataGridViewTextBoxColumn1
            // 
            this.sPRNDataGridViewTextBoxColumn1.DataPropertyName = "S_PRN";
            this.sPRNDataGridViewTextBoxColumn1.HeaderText = "S_PRN";
            this.sPRNDataGridViewTextBoxColumn1.Name = "sPRNDataGridViewTextBoxColumn1";
            this.sPRNDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sPRNDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sNameDataGridViewTextBoxColumn1
            // 
            this.sNameDataGridViewTextBoxColumn1.DataPropertyName = "S_Name";
            this.sNameDataGridViewTextBoxColumn1.HeaderText = "S_Name";
            this.sNameDataGridViewTextBoxColumn1.Name = "sNameDataGridViewTextBoxColumn1";
            this.sNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sNameDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sDepDataGridViewTextBoxColumn1
            // 
            this.sDepDataGridViewTextBoxColumn1.DataPropertyName = "S_Dep";
            this.sDepDataGridViewTextBoxColumn1.HeaderText = "S_Dep";
            this.sDepDataGridViewTextBoxColumn1.Name = "sDepDataGridViewTextBoxColumn1";
            this.sDepDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sDepDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sSemDataGridViewTextBoxColumn1
            // 
            this.sSemDataGridViewTextBoxColumn1.DataPropertyName = "S_Sem";
            this.sSemDataGridViewTextBoxColumn1.HeaderText = "S_Sem";
            this.sSemDataGridViewTextBoxColumn1.Name = "sSemDataGridViewTextBoxColumn1";
            this.sSemDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sSemDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sContDataGridViewTextBoxColumn1
            // 
            this.sContDataGridViewTextBoxColumn1.DataPropertyName = "S_Cont";
            this.sContDataGridViewTextBoxColumn1.HeaderText = "S_Cont";
            this.sContDataGridViewTextBoxColumn1.Name = "sContDataGridViewTextBoxColumn1";
            this.sContDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sContDataGridViewTextBoxColumn1.Width = 110;
            // 
            // sEmailDataGridViewTextBoxColumn1
            // 
            this.sEmailDataGridViewTextBoxColumn1.DataPropertyName = "S_Email";
            this.sEmailDataGridViewTextBoxColumn1.HeaderText = "S_Email";
            this.sEmailDataGridViewTextBoxColumn1.Name = "sEmailDataGridViewTextBoxColumn1";
            this.sEmailDataGridViewTextBoxColumn1.ReadOnly = true;
            this.sEmailDataGridViewTextBoxColumn1.Width = 110;
            // 
            // bNameDataGridViewTextBoxColumn1
            // 
            this.bNameDataGridViewTextBoxColumn1.DataPropertyName = "B_Name";
            this.bNameDataGridViewTextBoxColumn1.HeaderText = "B_Name";
            this.bNameDataGridViewTextBoxColumn1.Name = "bNameDataGridViewTextBoxColumn1";
            this.bNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bNameDataGridViewTextBoxColumn1.Width = 110;
            // 
            // bookReturnDateDataGridViewTextBoxColumn
            // 
            this.bookReturnDateDataGridViewTextBoxColumn.DataPropertyName = "Book_Return_Date";
            this.bookReturnDateDataGridViewTextBoxColumn.HeaderText = "Book_Return_Date";
            this.bookReturnDateDataGridViewTextBoxColumn.Name = "bookReturnDateDataGridViewTextBoxColumn";
            this.bookReturnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookReturnDateDataGridViewTextBoxColumn.Width = 182;
            // 
            // iRBookBindingSource1
            // 
            this.iRBookBindingSource1.DataMember = "IRBook";
            this.iRBookBindingSource1.DataSource = this.libDataSet1;
            // 
            // libDataSet1
            // 
            this.libDataSet1.DataSetName = "libDataSet1";
            this.libDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iRBookTableAdapter1
            // 
            this.iRBookTableAdapter1.ClearBeforeFill = true;
            // 
            // t2
            // 
            this.t2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t2.Location = new System.Drawing.Point(650, 321);
            this.t2.Name = "t2";
            this.t2.Size = new System.Drawing.Size(250, 27);
            this.t2.TabIndex = 32;
            this.t2.TextChanged += new System.EventHandler(this.t2_TextChanged);
            // 
            // t1
            // 
            this.t1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t1.Location = new System.Drawing.Point(650, 27);
            this.t1.Name = "t1";
            this.t1.Size = new System.Drawing.Size(250, 27);
            this.t1.TabIndex = 32;
            this.t1.TextChanged += new System.EventHandler(this.t1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Search PRN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 33;
            this.label4.Text = "Search PRN";
            // 
            // btnrefr
            // 
            this.btnrefr.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnrefr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrefr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnrefr.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrefr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnrefr.Location = new System.Drawing.Point(958, 28);
            this.btnrefr.Name = "btnrefr";
            this.btnrefr.Size = new System.Drawing.Size(73, 26);
            this.btnrefr.TabIndex = 34;
            this.btnrefr.Text = "Refresh";
            this.btnrefr.UseVisualStyleBackColor = false;
            this.btnrefr.Click += new System.EventHandler(this.btnrefr_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(958, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 26);
            this.button1.TabIndex = 34;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompleteBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnrefr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t1);
            this.Controls.Add(this.t2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dv2);
            this.Controls.Add(this.dv1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CompleteBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CompleteBD";
            this.Load += new System.EventHandler(this.CompleteBD_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iRBookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label caan;
        private System.Windows.Forms.DataGridView dv1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private libDataSet libDataSet;
        private System.Windows.Forms.BindingSource iRBookBindingSource;
        private libDataSetTableAdapters.IRBookTableAdapter iRBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPRNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIssuedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dv2;
        private libDataSet1 libDataSet1;
        private System.Windows.Forms.BindingSource iRBookBindingSource1;
        private libDataSet1TableAdapters.IRBookTableAdapter iRBookTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPRNDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDepDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSemDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sContDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEmailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookReturnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox t2;
        private System.Windows.Forms.TextBox t1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnrefr;
        private System.Windows.Forms.Button button1;
    }
}