namespace Project_1
{
    partial class Form3
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
            this.profitUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCPP_ProjecrDataSet = new Project_1.TCPP_ProjecrDataSet();
            this.profitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDSpendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSpendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumSpendingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentSpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spendingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.spendingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profit_UserTableAdapter = new Project_1.TCPP_ProjecrDataSetTableAdapters.Profit_UserTableAdapter();
            this.spendingTableAdapter = new Project_1.TCPP_ProjecrDataSetTableAdapters.SpendingTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profitUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCPP_ProjecrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // profitUserBindingSource
            // 
            this.profitUserBindingSource.DataMember = "Profit_User";
            this.profitUserBindingSource.DataSource = this.tCPP_ProjecrDataSet;
            // 
            // tCPP_ProjecrDataSet
            // 
            this.tCPP_ProjecrDataSet.DataSetName = "TCPP_ProjecrDataSet";
            this.tCPP_ProjecrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSpendingDataGridViewTextBoxColumn,
            this.dateSpendingDataGridViewTextBoxColumn,
            this.sumSpendingDataGridViewTextBoxColumn,
            this.comentSpDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.spendingBindingSource1;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(12, 298);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(776, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDSpendingDataGridViewTextBoxColumn
            // 
            this.iDSpendingDataGridViewTextBoxColumn.DataPropertyName = "ID_Spending";
            this.iDSpendingDataGridViewTextBoxColumn.HeaderText = "ID_Spending";
            this.iDSpendingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDSpendingDataGridViewTextBoxColumn.Name = "iDSpendingDataGridViewTextBoxColumn";
            this.iDSpendingDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSpendingDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateSpendingDataGridViewTextBoxColumn
            // 
            this.dateSpendingDataGridViewTextBoxColumn.DataPropertyName = "Date_Spending";
            this.dateSpendingDataGridViewTextBoxColumn.HeaderText = "Date_Spending";
            this.dateSpendingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateSpendingDataGridViewTextBoxColumn.Name = "dateSpendingDataGridViewTextBoxColumn";
            this.dateSpendingDataGridViewTextBoxColumn.Width = 125;
            // 
            // sumSpendingDataGridViewTextBoxColumn
            // 
            this.sumSpendingDataGridViewTextBoxColumn.DataPropertyName = "SumSpending";
            this.sumSpendingDataGridViewTextBoxColumn.HeaderText = "SumSpending";
            this.sumSpendingDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sumSpendingDataGridViewTextBoxColumn.Name = "sumSpendingDataGridViewTextBoxColumn";
            this.sumSpendingDataGridViewTextBoxColumn.Width = 125;
            // 
            // comentSpDataGridViewTextBoxColumn
            // 
            this.comentSpDataGridViewTextBoxColumn.DataPropertyName = "ComentSp";
            this.comentSpDataGridViewTextBoxColumn.HeaderText = "ComentSp";
            this.comentSpDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.comentSpDataGridViewTextBoxColumn.Name = "comentSpDataGridViewTextBoxColumn";
            this.comentSpDataGridViewTextBoxColumn.Width = 125;
            // 
            // spendingBindingSource1
            // 
            this.spendingBindingSource1.DataMember = "Spending";
            this.spendingBindingSource1.DataSource = this.tCPP_ProjecrDataSet;
            // 
            // profit_UserTableAdapter
            // 
            this.profit_UserTableAdapter.ClearBeforeFill = true;
            // 
            // spendingTableAdapter
            // 
            this.spendingTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Додати профіт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profitUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tCPP_ProjecrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spendingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        //private TCPP_ProjecrDataSet tCPP_ProjecrDataSet;
        private System.Windows.Forms.BindingSource profitBindingSource;
        //private TCPP_ProjecrDataSetTableAdapters.ProfitTableAdapter profitTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource spendingBindingSource;
        private TCPP_ProjecrDataSet tCPP_ProjecrDataSet;
        private System.Windows.Forms.BindingSource profitUserBindingSource;
        private TCPP_ProjecrDataSetTableAdapters.Profit_UserTableAdapter profit_UserTableAdapter;
        private System.Windows.Forms.BindingSource spendingBindingSource1;
        private TCPP_ProjecrDataSetTableAdapters.SpendingTableAdapter spendingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSpendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSpendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumSpendingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentSpDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}