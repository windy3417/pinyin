namespace pinyin
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsb_query = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chinessNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneShortNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.testDataSet = new pinyin.testDataSet();
            this.addressBookTableAdapter = new pinyin.testDataSetTableAdapters.addressBookTableAdapter();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(371, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_query});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsb_query
            // 
            this.tsb_query.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_query.Image = ((System.Drawing.Image)(resources.GetObject("tsb_query.Image")));
            this.tsb_query.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_query.Name = "tsb_query";
            this.tsb_query.Size = new System.Drawing.Size(36, 22);
            this.tsb_query.Text = "生成";
            this.tsb_query.Click += new System.EventHandler(this.tsb_query_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentDataGridViewTextBoxColumn,
            this.engDepartmentDataGridViewTextBoxColumn,
            this.englishNameDataGridViewTextBoxColumn,
            this.chinessNameDataGridViewTextBoxColumn,
            this.extDataGridViewTextBoxColumn,
            this.mobilePhoneNumberDataGridViewTextBoxColumn,
            this.mobilePhoneShortNumberDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.deptIDDataGridViewTextBoxColumn,
            this.memoryCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.addressBookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(776, 324);
            this.dataGridView1.TabIndex = 2;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // engDepartmentDataGridViewTextBoxColumn
            // 
            this.engDepartmentDataGridViewTextBoxColumn.DataPropertyName = "engDepartment";
            this.engDepartmentDataGridViewTextBoxColumn.HeaderText = "engDepartment";
            this.engDepartmentDataGridViewTextBoxColumn.Name = "engDepartmentDataGridViewTextBoxColumn";
            // 
            // englishNameDataGridViewTextBoxColumn
            // 
            this.englishNameDataGridViewTextBoxColumn.DataPropertyName = "englishName";
            this.englishNameDataGridViewTextBoxColumn.HeaderText = "englishName";
            this.englishNameDataGridViewTextBoxColumn.Name = "englishNameDataGridViewTextBoxColumn";
            // 
            // chinessNameDataGridViewTextBoxColumn
            // 
            this.chinessNameDataGridViewTextBoxColumn.DataPropertyName = "chinessName";
            this.chinessNameDataGridViewTextBoxColumn.HeaderText = "chinessName";
            this.chinessNameDataGridViewTextBoxColumn.Name = "chinessNameDataGridViewTextBoxColumn";
            // 
            // extDataGridViewTextBoxColumn
            // 
            this.extDataGridViewTextBoxColumn.DataPropertyName = "Ext";
            this.extDataGridViewTextBoxColumn.HeaderText = "Ext";
            this.extDataGridViewTextBoxColumn.Name = "extDataGridViewTextBoxColumn";
            // 
            // mobilePhoneNumberDataGridViewTextBoxColumn
            // 
            this.mobilePhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "mobilePhoneNumber";
            this.mobilePhoneNumberDataGridViewTextBoxColumn.HeaderText = "mobilePhoneNumber";
            this.mobilePhoneNumberDataGridViewTextBoxColumn.Name = "mobilePhoneNumberDataGridViewTextBoxColumn";
            // 
            // mobilePhoneShortNumberDataGridViewTextBoxColumn
            // 
            this.mobilePhoneShortNumberDataGridViewTextBoxColumn.DataPropertyName = "MobilePhoneShortNumber";
            this.mobilePhoneShortNumberDataGridViewTextBoxColumn.HeaderText = "MobilePhoneShortNumber";
            this.mobilePhoneShortNumberDataGridViewTextBoxColumn.Name = "mobilePhoneShortNumberDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deptIDDataGridViewTextBoxColumn
            // 
            this.deptIDDataGridViewTextBoxColumn.DataPropertyName = "deptID";
            this.deptIDDataGridViewTextBoxColumn.HeaderText = "deptID";
            this.deptIDDataGridViewTextBoxColumn.Name = "deptIDDataGridViewTextBoxColumn";
            // 
            // memoryCodeDataGridViewTextBoxColumn
            // 
            this.memoryCodeDataGridViewTextBoxColumn.DataPropertyName = "memoryCode";
            this.memoryCodeDataGridViewTextBoxColumn.HeaderText = "memoryCode";
            this.memoryCodeDataGridViewTextBoxColumn.Name = "memoryCodeDataGridViewTextBoxColumn";
            // 
            // addressBookBindingSource
            // 
            this.addressBookBindingSource.DataMember = "addressBook";
            this.addressBookBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.testDataSet;
            this.bindingSource1.Position = 0;
            // 
            // testDataSet
            // 
            this.testDataSet.DataSetName = "testDataSet";
            this.testDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressBookTableAdapter
            // 
            this.addressBookTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "简接生成";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsb_query;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private testDataSet testDataSet;
        private System.Windows.Forms.BindingSource addressBookBindingSource;
        private testDataSetTableAdapters.addressBookTableAdapter addressBookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn engDepartmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chinessNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneShortNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryCodeDataGridViewTextBoxColumn;
    }
}

