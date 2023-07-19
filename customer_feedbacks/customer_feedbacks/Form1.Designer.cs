namespace customer_feedbacks
{
	partial class Form1
	{
		/// <summary>
		///Gerekli tasarımcı değişkeni.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///Kullanılan tüm kaynakları temizleyin.
		/// </summary>
		///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer üretilen kod

		/// <summary>
		/// Tasarımcı desteği için gerekli metot - bu metodun 
		///içeriğini kod düzenleyici ile değiştirmeyin.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.FirstName = new System.Windows.Forms.Label();
			this.txtfirst = new System.Windows.Forms.TextBox();
			this.txtlast = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mskage = new System.Windows.Forms.MaskedTextBox();
			this.buttonsave = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.customerinfosDataSet = new customer_feedbacks.customerinfosDataSet();
			this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.table_1TableAdapter = new customer_feedbacks.customerinfosDataSetTableAdapters.Table_1TableAdapter();
			this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.complaintDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonrefresh = new System.Windows.Forms.Button();
			this.txtgen = new System.Windows.Forms.TextBox();
			this.txtcom = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerinfosDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// FirstName
			// 
			this.FirstName.AutoSize = true;
			this.FirstName.Location = new System.Drawing.Point(141, 52);
			this.FirstName.Name = "FirstName";
			this.FirstName.Size = new System.Drawing.Size(54, 13);
			this.FirstName.TabIndex = 0;
			this.FirstName.Text = "FirstName";
			// 
			// txtfirst
			// 
			this.txtfirst.Location = new System.Drawing.Point(215, 49);
			this.txtfirst.Name = "txtfirst";
			this.txtfirst.Size = new System.Drawing.Size(190, 20);
			this.txtfirst.TabIndex = 1;
			// 
			// txtlast
			// 
			this.txtlast.Location = new System.Drawing.Point(215, 98);
			this.txtlast.Name = "txtlast";
			this.txtlast.Size = new System.Drawing.Size(190, 20);
			this.txtlast.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(141, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "LastName";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(141, 149);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Age";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(141, 197);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(42, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Gender";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(141, 249);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Complaint";
			// 
			// mskage
			// 
			this.mskage.Location = new System.Drawing.Point(215, 142);
			this.mskage.Mask = "000";
			this.mskage.Name = "mskage";
			this.mskage.Size = new System.Drawing.Size(25, 20);
			this.mskage.TabIndex = 13;
			this.mskage.ValidatingType = typeof(int);
			// 
			// buttonsave
			// 
			this.buttonsave.Location = new System.Drawing.Point(224, 281);
			this.buttonsave.Name = "buttonsave";
			this.buttonsave.Size = new System.Drawing.Size(153, 36);
			this.buttonsave.TabIndex = 14;
			this.buttonsave.Text = "Save";
			this.buttonsave.UseVisualStyleBackColor = true;
			this.buttonsave.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dataGridView1);
			this.groupBox1.Location = new System.Drawing.Point(12, 333);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(557, 138);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Data";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.complaintDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.table1BindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 16);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(551, 119);
			this.dataGridView1.TabIndex = 0;
			// 
			// customerinfosDataSet
			// 
			this.customerinfosDataSet.DataSetName = "customerinfosDataSet";
			this.customerinfosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// table1BindingSource
			// 
			this.table1BindingSource.DataMember = "Table_1";
			this.table1BindingSource.DataSource = this.customerinfosDataSet;
			// 
			// table_1TableAdapter
			// 
			this.table_1TableAdapter.ClearBeforeFill = true;
			// 
			// firstNameDataGridViewTextBoxColumn
			// 
			this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
			this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
			// 
			// lastNameDataGridViewTextBoxColumn
			// 
			this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
			this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
			this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			// 
			// genderDataGridViewTextBoxColumn
			// 
			this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
			this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
			this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
			// 
			// complaintDataGridViewTextBoxColumn
			// 
			this.complaintDataGridViewTextBoxColumn.DataPropertyName = "Complaint";
			this.complaintDataGridViewTextBoxColumn.HeaderText = "Complaint";
			this.complaintDataGridViewTextBoxColumn.Name = "complaintDataGridViewTextBoxColumn";
			// 
			// buttonrefresh
			// 
			this.buttonrefresh.Location = new System.Drawing.Point(493, 281);
			this.buttonrefresh.Name = "buttonrefresh";
			this.buttonrefresh.Size = new System.Drawing.Size(73, 36);
			this.buttonrefresh.TabIndex = 16;
			this.buttonrefresh.Text = "Refresh";
			this.buttonrefresh.UseVisualStyleBackColor = true;
			this.buttonrefresh.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtgen
			// 
			this.txtgen.Location = new System.Drawing.Point(215, 197);
			this.txtgen.Name = "txtgen";
			this.txtgen.Size = new System.Drawing.Size(190, 20);
			this.txtgen.TabIndex = 17;
			// 
			// txtcom
			// 
			this.txtcom.Location = new System.Drawing.Point(215, 242);
			this.txtcom.Name = "txtcom";
			this.txtcom.Size = new System.Drawing.Size(190, 20);
			this.txtcom.TabIndex = 18;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 483);
			this.Controls.Add(this.txtcom);
			this.Controls.Add(this.txtgen);
			this.Controls.Add(this.buttonrefresh);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonsave);
			this.Controls.Add(this.mskage);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtlast);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtfirst);
			this.Controls.Add(this.FirstName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerinfosDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label FirstName;
		private System.Windows.Forms.TextBox txtfirst;
		private System.Windows.Forms.TextBox txtlast;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mskage;
		private System.Windows.Forms.Button buttonsave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private customerinfosDataSet customerinfosDataSet;
		private System.Windows.Forms.BindingSource table1BindingSource;
		private customerinfosDataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn complaintDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button buttonrefresh;
		private System.Windows.Forms.TextBox txtgen;
		private System.Windows.Forms.TextBox txtcom;
	}
}

