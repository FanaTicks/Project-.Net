namespace WindowsFormsApp1
{
    partial class BankCart
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonSell = new System.Windows.Forms.Button();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.basketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basketDataSet = new WindowsFormsApp1.BasketDataSet();
            this.basketTableAdapter = new WindowsFormsApp1.BasketDataSetTableAdapters.BasketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вихід";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(73, 121);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(189, 81);
            this.dataGridView3.TabIndex = 4;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(358, 288);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(147, 38);
            this.buttonSell.TabIndex = 12;
            this.buttonSell.Text = "Оплата  проведена";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.basketBindingSource;
            this.comboBox4.DisplayMember = "ID_Product_";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(97, 145);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 15;
            this.comboBox4.ValueMember = "ID_Product_";
            // 
            // basketBindingSource
            // 
            this.basketBindingSource.DataMember = "Basket";
            this.basketBindingSource.DataSource = this.basketDataSet;
            // 
            // basketDataSet
            // 
            this.basketDataSet.DataSetName = "BasketDataSet";
            this.basketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basketTableAdapter
            // 
            this.basketTableAdapter.ClearBeforeFill = true;
            // 
            // BankCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.button1);
            this.Name = "BankCart";
            this.Text = "BankCart";
            this.Load += new System.EventHandler(this.BankCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.ComboBox comboBox4;
        private BasketDataSet basketDataSet;
        private System.Windows.Forms.BindingSource basketBindingSource;
        private BasketDataSetTableAdapters.BasketTableAdapter basketTableAdapter;
    }
}