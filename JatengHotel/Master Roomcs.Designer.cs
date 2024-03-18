namespace JatengHotel
{
    partial class Master_Roomcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_RoomNumber = new System.Windows.Forms.TextBox();
            this.tb_Rflr = new System.Windows.Forms.TextBox();
            this.rtb_Dsc = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Updt = new System.Windows.Forms.Button();
            this.btn_Dlt = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cncl = new System.Windows.Forms.Button();
            this.cb_Rtyp = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room NUmber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Room Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description";
            // 
            // tb_RoomNumber
            // 
            this.tb_RoomNumber.Location = new System.Drawing.Point(254, 46);
            this.tb_RoomNumber.Name = "tb_RoomNumber";
            this.tb_RoomNumber.Size = new System.Drawing.Size(342, 22);
            this.tb_RoomNumber.TabIndex = 4;
            // 
            // tb_Rflr
            // 
            this.tb_Rflr.Location = new System.Drawing.Point(254, 123);
            this.tb_Rflr.Name = "tb_Rflr";
            this.tb_Rflr.Size = new System.Drawing.Size(342, 22);
            this.tb_Rflr.TabIndex = 6;
            // 
            // rtb_Dsc
            // 
            this.rtb_Dsc.Location = new System.Drawing.Point(255, 170);
            this.rtb_Dsc.Name = "rtb_Dsc";
            this.rtb_Dsc.Size = new System.Drawing.Size(340, 111);
            this.rtb_Dsc.TabIndex = 7;
            this.rtb_Dsc.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(133, 303);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(517, 134);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Cncl);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.btn_Dlt);
            this.groupBox1.Controls.Add(this.btn_Updt);
            this.groupBox1.Controls.Add(this.btn_Insert);
            this.groupBox1.Location = new System.Drawing.Point(58, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(18, 18);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(89, 29);
            this.btn_Insert.TabIndex = 0;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            // 
            // btn_Updt
            // 
            this.btn_Updt.Location = new System.Drawing.Point(136, 18);
            this.btn_Updt.Name = "btn_Updt";
            this.btn_Updt.Size = new System.Drawing.Size(89, 29);
            this.btn_Updt.TabIndex = 1;
            this.btn_Updt.Text = "Update";
            this.btn_Updt.UseVisualStyleBackColor = true;
            // 
            // btn_Dlt
            // 
            this.btn_Dlt.Location = new System.Drawing.Point(263, 18);
            this.btn_Dlt.Name = "btn_Dlt";
            this.btn_Dlt.Size = new System.Drawing.Size(89, 29);
            this.btn_Dlt.TabIndex = 2;
            this.btn_Dlt.Text = "Delete";
            this.btn_Dlt.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(396, 18);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(89, 29);
            this.btn_Save.TabIndex = 3;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Cncl
            // 
            this.btn_Cncl.Location = new System.Drawing.Point(544, 18);
            this.btn_Cncl.Name = "btn_Cncl";
            this.btn_Cncl.Size = new System.Drawing.Size(89, 29);
            this.btn_Cncl.TabIndex = 4;
            this.btn_Cncl.Text = "Cancel";
            this.btn_Cncl.UseVisualStyleBackColor = true;
            // 
            // cb_Rtyp
            // 
            this.cb_Rtyp.FormattingEnabled = true;
            this.cb_Rtyp.Location = new System.Drawing.Point(257, 83);
            this.cb_Rtyp.Name = "cb_Rtyp";
            this.cb_Rtyp.Size = new System.Drawing.Size(337, 24);
            this.cb_Rtyp.TabIndex = 10;
            // 
            // Master_Roomcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 515);
            this.Controls.Add(this.cb_Rtyp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rtb_Dsc);
            this.Controls.Add(this.tb_Rflr);
            this.Controls.Add(this.tb_RoomNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Master_Roomcs";
            this.Text = "Master_Roomcs";
            this.Load += new System.EventHandler(this.Master_Roomcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_RoomNumber;
        private System.Windows.Forms.TextBox tb_Rflr;
        private System.Windows.Forms.RichTextBox rtb_Dsc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cncl;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Dlt;
        private System.Windows.Forms.Button btn_Updt;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cb_Rtyp;
    }
}