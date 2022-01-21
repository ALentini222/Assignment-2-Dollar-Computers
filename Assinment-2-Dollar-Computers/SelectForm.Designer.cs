
namespace Assinment_2_Dollar_Computers
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webCamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.computer_ProductsDataSet = new Assinment_2_Dollar_Computers.Computer_ProductsDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productsTableAdapter = new Assinment_2_Dollar_Computers.Computer_ProductsDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ProductsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Computer Hardware List ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.mFGDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.lCDSizeDataGridViewTextBoxColumn,
            this.cPUBrandDataGridViewTextBoxColumn,
            this.cPUTypeDataGridViewTextBoxColumn,
            this.cPUNumberDataGridViewTextBoxColumn,
            this.cPUSpeedDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.hDDDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.webCamDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.productsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 46);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(892, 414);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // mFGDataGridViewTextBoxColumn
            // 
            this.mFGDataGridViewTextBoxColumn.DataPropertyName = "MFG";
            this.mFGDataGridViewTextBoxColumn.HeaderText = "MFG";
            this.mFGDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mFGDataGridViewTextBoxColumn.Name = "mFGDataGridViewTextBoxColumn";
            this.mFGDataGridViewTextBoxColumn.ReadOnly = true;
            this.mFGDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 125;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.memoryDataGridViewTextBoxColumn.Width = 125;
            // 
            // lCDSizeDataGridViewTextBoxColumn
            // 
            this.lCDSizeDataGridViewTextBoxColumn.DataPropertyName = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.HeaderText = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lCDSizeDataGridViewTextBoxColumn.Name = "lCDSizeDataGridViewTextBoxColumn";
            this.lCDSizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lCDSizeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUBrandDataGridViewTextBoxColumn
            // 
            this.cPUBrandDataGridViewTextBoxColumn.DataPropertyName = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.HeaderText = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUBrandDataGridViewTextBoxColumn.Name = "cPUBrandDataGridViewTextBoxColumn";
            this.cPUBrandDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUBrandDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUTypeDataGridViewTextBoxColumn
            // 
            this.cPUTypeDataGridViewTextBoxColumn.DataPropertyName = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.HeaderText = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUTypeDataGridViewTextBoxColumn.Name = "cPUTypeDataGridViewTextBoxColumn";
            this.cPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUNumberDataGridViewTextBoxColumn
            // 
            this.cPUNumberDataGridViewTextBoxColumn.DataPropertyName = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.HeaderText = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUNumberDataGridViewTextBoxColumn.Name = "cPUNumberDataGridViewTextBoxColumn";
            this.cPUNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // cPUSpeedDataGridViewTextBoxColumn
            // 
            this.cPUSpeedDataGridViewTextBoxColumn.DataPropertyName = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.HeaderText = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cPUSpeedDataGridViewTextBoxColumn.Name = "cPUSpeedDataGridViewTextBoxColumn";
            this.cPUSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            this.cPUSpeedDataGridViewTextBoxColumn.Width = 125;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 125;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformDataGridViewTextBoxColumn.Width = 125;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Width = 125;
            // 
            // hDDDataGridViewTextBoxColumn
            // 
            this.hDDDataGridViewTextBoxColumn.DataPropertyName = "HDD";
            this.hDDDataGridViewTextBoxColumn.HeaderText = "HDD";
            this.hDDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hDDDataGridViewTextBoxColumn.Name = "hDDDataGridViewTextBoxColumn";
            this.hDDDataGridViewTextBoxColumn.ReadOnly = true;
            this.hDDDataGridViewTextBoxColumn.Width = 125;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.gPUTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // webCamDataGridViewTextBoxColumn
            // 
            this.webCamDataGridViewTextBoxColumn.DataPropertyName = "WebCam";
            this.webCamDataGridViewTextBoxColumn.HeaderText = "WebCam";
            this.webCamDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.webCamDataGridViewTextBoxColumn.Name = "webCamDataGridViewTextBoxColumn";
            this.webCamDataGridViewTextBoxColumn.ReadOnly = true;
            this.webCamDataGridViewTextBoxColumn.Width = 125;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.computer_ProductsDataSet;
            // 
            // computer_ProductsDataSet
            // 
            this.computer_ProductsDataSet.DataSetName = "Computer_ProductsDataSet";
            this.computer_ProductsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Computer Hardware List ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 478);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(725, 532);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 591);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select A Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computer_ProductsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Computer_ProductsDataSet computer_ProductsDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private Computer_ProductsDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webCamDataGridViewTextBoxColumn;
    }
}