namespace employee
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserSalary = new System.Windows.Forms.TextBox();
            this.txtUserAddr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.displayData = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(489, 289);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSave.Location = new System.Drawing.Point(185, 72);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 41);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Location = new System.Drawing.Point(16, 27);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(158, 23);
            this.txtUserName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address";
            // 
            // txtUserSalary
            // 
            this.txtUserSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserSalary.Location = new System.Drawing.Point(344, 27);
            this.txtUserSalary.Multiline = true;
            this.txtUserSalary.Name = "txtUserSalary";
            this.txtUserSalary.Size = new System.Drawing.Size(158, 23);
            this.txtUserSalary.TabIndex = 6;
            // 
            // txtUserAddr
            // 
            this.txtUserAddr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserAddr.Location = new System.Drawing.Point(180, 27);
            this.txtUserAddr.Multiline = true;
            this.txtUserAddr.Name = "txtUserAddr";
            this.txtUserAddr.Size = new System.Drawing.Size(158, 23);
            this.txtUserAddr.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Salary";
            // 
            // displayData
            // 
            this.displayData.BackColor = System.Drawing.Color.DarkOrange;
            this.displayData.FlatAppearance.BorderSize = 0;
            this.displayData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayData.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayData.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.displayData.Location = new System.Drawing.Point(268, 72);
            this.displayData.Name = "displayData";
            this.displayData.Size = new System.Drawing.Size(75, 41);
            this.displayData.TabIndex = 10;
            this.displayData.Text = "Display";
            this.displayData.UseVisualStyleBackColor = false;
            this.displayData.Click += new System.EventHandler(this.displayData_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUpdate.Location = new System.Drawing.Point(349, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 41);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Location = new System.Drawing.Point(430, 72);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID";
            // 
            // txtUserID
            // 
            this.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserID.Location = new System.Drawing.Point(16, 90);
            this.txtUserID.Multiline = true;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(158, 23);
            this.txtUserID.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(517, 450);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.displayData);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserAddr);
            this.Controls.Add(this.txtUserSalary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button btnSave;
        private TextBox txtUserName;
        private Label label2;
        private TextBox txtUserSalary;
        private TextBox txtUserAddr;
        private Label label3;
        private Button displayData;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label4;
        private TextBox txtUserID;
    }
}