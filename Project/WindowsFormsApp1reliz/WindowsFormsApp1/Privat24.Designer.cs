namespace WindowsFormsApp1
{
    partial class Privat24
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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticket = new WindowsFormsApp1.Ticket();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.abonement = new WindowsFormsApp1.Abonement();
            this.abonementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abonementTableAdapter = new WindowsFormsApp1.AbonementTableAdapters.AbonementTableAdapter();
            this.ticketTableAdapter = new WindowsFormsApp1.TicketTableAdapters.TicketTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сплачено";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Вихід";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(50, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "Сплачено";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ціна до сплати";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.ticketBindingSource;
            this.comboBox4.DisplayMember = "Ticket_price";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(602, 54);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 24);
            this.comboBox4.TabIndex = 21;
            this.comboBox4.ValueMember = "Ticket_price";
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.ticket;
            // 
            // ticket
            // 
            this.ticket.DataSetName = "Ticket";
            this.ticket.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.ticketBindingSource;
            this.comboBox3.DisplayMember = "Ticket_end_date";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(304, 54);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "Ticket_end_date";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ticketBindingSource;
            this.comboBox2.DisplayMember = "Ticket_start_date";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(177, 54);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "Ticket_end_date";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ticketBindingSource;
            this.comboBox1.DisplayMember = "ID_Ticket";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(50, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "ID_Ticket";
            // 
            // abonement
            // 
            this.abonement.DataSetName = "Abonement";
            this.abonement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonementBindingSource
            // 
            this.abonementBindingSource.DataMember = "Abonement";
            this.abonementBindingSource.DataSource = this.abonement;
            // 
            // abonementTableAdapter
            // 
            this.abonementTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // Privat24
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Privat24";
            this.Text = "Privat24";
            this.Load += new System.EventHandler(this.Privat24_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private Abonement abonement;
        private System.Windows.Forms.BindingSource abonementBindingSource;
        private AbonementTableAdapters.AbonementTableAdapter abonementTableAdapter;
        private Ticket ticket;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private TicketTableAdapters.TicketTableAdapter ticketTableAdapter;
    }
}