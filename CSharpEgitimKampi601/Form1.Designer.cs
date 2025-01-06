namespace CSharpEgitimKampi601
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerCity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerShoppingCount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.btnCustomerCreate = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetByCustomerId = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(51, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri ID:";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(135, 12);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(135, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Adı:";
            // 
            // txtCustomerSurname
            // 
            this.txtCustomerSurname.Location = new System.Drawing.Point(135, 64);
            this.txtCustomerSurname.Name = "txtCustomerSurname";
            this.txtCustomerSurname.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(25, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Müşteri Soyadı:";
            // 
            // txtCustomerCity
            // 
            this.txtCustomerCity.Location = new System.Drawing.Point(135, 90);
            this.txtCustomerCity.Name = "txtCustomerCity";
            this.txtCustomerCity.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerCity.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(36, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Müşteri Şehir:";
            // 
            // txtCustomerBalance
            // 
            this.txtCustomerBalance.Location = new System.Drawing.Point(135, 116);
            this.txtCustomerBalance.Name = "txtCustomerBalance";
            this.txtCustomerBalance.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerBalance.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bakiye:";
            // 
            // txtCustomerShoppingCount
            // 
            this.txtCustomerShoppingCount.Location = new System.Drawing.Point(135, 142);
            this.txtCustomerShoppingCount.Name = "txtCustomerShoppingCount";
            this.txtCustomerShoppingCount.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerShoppingCount.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(28, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Alışveriş Tutarı:";
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Location = new System.Drawing.Point(135, 168);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(100, 23);
            this.btnCustomerList.TabIndex = 12;
            this.btnCustomerList.Text = "Listele";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // btnCustomerCreate
            // 
            this.btnCustomerCreate.Location = new System.Drawing.Point(135, 197);
            this.btnCustomerCreate.Name = "btnCustomerCreate";
            this.btnCustomerCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCustomerCreate.TabIndex = 13;
            this.btnCustomerCreate.Text = "Ekle";
            this.btnCustomerCreate.UseVisualStyleBackColor = true;
            this.btnCustomerCreate.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(135, 226);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(100, 23);
            this.btnCustomerDelete.TabIndex = 14;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(135, 255);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnCustomerUpdate.TabIndex = 15;
            this.btnCustomerUpdate.Text = "Güncelle";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            this.btnCustomerUpdate.Click += new System.EventHandler(this.btnCustomerUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(830, 293);
            this.dataGridView1.TabIndex = 16;
            // 
            // btnGetByCustomerId
            // 
            this.btnGetByCustomerId.Location = new System.Drawing.Point(135, 282);
            this.btnGetByCustomerId.Name = "btnGetByCustomerId";
            this.btnGetByCustomerId.Size = new System.Drawing.Size(100, 23);
            this.btnGetByCustomerId.TabIndex = 17;
            this.btnGetByCustomerId.Text = "Id\'ye Göre Getir";
            this.btnGetByCustomerId.UseVisualStyleBackColor = true;
            this.btnGetByCustomerId.Click += new System.EventHandler(this.btnGetByCustomerId_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 320);
            this.Controls.Add(this.btnGetByCustomerId);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerCreate);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.txtCustomerShoppingCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCustomerBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCustomerCity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCustomerSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerCity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerBalance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerShoppingCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetByCustomerId;
    }
}

