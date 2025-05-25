﻿namespace PostgreSQL_CRUD
{
	partial class FrmEmployee
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnList = new System.Windows.Forms.Button();
			this.txtEmployeeSalary = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmployeeName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cmbEmployeeDepartment = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnGetById.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetById.ForeColor = System.Drawing.Color.Black;
			this.btnGetById.Location = new System.Drawing.Point(49, 480);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(236, 37);
			this.btnGetById.TabIndex = 49;
			this.btnGetById.Text = "Id\'ye Göre Getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(312, 18);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(791, 433);
			this.dataGridView1.TabIndex = 48;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnCreate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.ForeColor = System.Drawing.Color.Black;
			this.btnCreate.Location = new System.Drawing.Point(49, 322);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(236, 37);
			this.btnCreate.TabIndex = 47;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnDelete.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.ForeColor = System.Drawing.Color.Black;
			this.btnDelete.Location = new System.Drawing.Point(49, 375);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(236, 37);
			this.btnDelete.TabIndex = 46;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnUpdate.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.ForeColor = System.Drawing.Color.Black;
			this.btnUpdate.Location = new System.Drawing.Point(49, 428);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(236, 37);
			this.btnUpdate.TabIndex = 45;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnList.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.ForeColor = System.Drawing.Color.Black;
			this.btnList.Location = new System.Drawing.Point(49, 263);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(236, 37);
			this.btnList.TabIndex = 44;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtEmployeeSalary
			// 
			this.txtEmployeeSalary.Location = new System.Drawing.Point(141, 153);
			this.txtEmployeeSalary.Name = "txtEmployeeSalary";
			this.txtEmployeeSalary.Size = new System.Drawing.Size(144, 22);
			this.txtEmployeeSalary.TabIndex = 43;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(5, 153);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(117, 21);
			this.label4.TabIndex = 42;
			this.label4.Text = "Personel Maaş:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtEmployeeSurname
			// 
			this.txtEmployeeSurname.Location = new System.Drawing.Point(141, 113);
			this.txtEmployeeSurname.Name = "txtEmployeeSurname";
			this.txtEmployeeSurname.Size = new System.Drawing.Size(144, 22);
			this.txtEmployeeSurname.TabIndex = 41;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(-3, 113);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(125, 21);
			this.label3.TabIndex = 40;
			this.label3.Text = "Personel Soyadı:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtEmployeeName
			// 
			this.txtEmployeeName.Location = new System.Drawing.Point(141, 69);
			this.txtEmployeeName.Name = "txtEmployeeName";
			this.txtEmployeeName.Size = new System.Drawing.Size(144, 22);
			this.txtEmployeeName.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(20, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 21);
			this.label2.TabIndex = 38;
			this.label2.Text = "Personel Adı:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.Location = new System.Drawing.Point(141, 29);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.Size = new System.Drawing.Size(144, 22);
			this.txtEmployeeId.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(30, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 21);
			this.label1.TabIndex = 36;
			this.label1.Text = "Personel Id:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(29, 197);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 21);
			this.label5.TabIndex = 50;
			this.label5.Text = "Departman:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// cmbEmployeeDepartment
			// 
			this.cmbEmployeeDepartment.FormattingEnabled = true;
			this.cmbEmployeeDepartment.Location = new System.Drawing.Point(141, 197);
			this.cmbEmployeeDepartment.Name = "cmbEmployeeDepartment";
			this.cmbEmployeeDepartment.Size = new System.Drawing.Size(144, 24);
			this.cmbEmployeeDepartment.TabIndex = 51;
			// 
			// FrmEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1115, 529);
			this.Controls.Add(this.cmbEmployeeDepartment);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtEmployeeSalary);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtEmployeeSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtEmployeeName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmployeeId);
			this.Controls.Add(this.label1);
			this.Name = "FrmEmployee";
			this.Text = "FrmEmployee";
			this.Load += new System.EventHandler(this.FrmEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtEmployeeSalary;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtEmployeeSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmployeeName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtEmployeeId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cmbEmployeeDepartment;
	}
}