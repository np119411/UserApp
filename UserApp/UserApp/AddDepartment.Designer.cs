namespace UserApp
{
    partial class AddDepartment
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
            this.did = new System.Windows.Forms.TextBox();
            this.dname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btexit = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.btrefresh = new System.Windows.Forms.Button();
            this.btcheck = new System.Windows.Forms.Button();
            this.redep = new System.Windows.Forms.Button();
            this.ListDept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Bộ Phận:";
            // 
            // did
            // 
            this.did.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.did.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.did.Location = new System.Drawing.Point(162, 16);
            this.did.MaxLength = 6;
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(196, 33);
            this.did.TabIndex = 1;
            this.did.MouseClick += new System.Windows.Forms.MouseEventHandler(this.did_MouseClick);
            this.did.TextChanged += new System.EventHandler(this.did_TextChanged);
            this.did.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // dname
            // 
            this.dname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.dname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dname.Location = new System.Drawing.Point(164, 64);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(328, 33);
            this.dname.TabIndex = 3;
            this.dname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.did_MouseClick);
            this.dname.TextChanged += new System.EventHandler(this.dname_TextChanged);
            this.dname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckTabKeyPress);
            this.dname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckTabKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Bộ Phận:";
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.ForeColor = System.Drawing.Color.Red;
            this.btexit.Location = new System.Drawing.Point(43, 121);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(124, 52);
            this.btexit.TabIndex = 4;
            this.btexit.Text = "Thoát";
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btadd
            // 
            this.btadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btadd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Location = new System.Drawing.Point(433, 123);
            this.btadd.Name = "btadd";
            this.btadd.Size = new System.Drawing.Size(124, 52);
            this.btadd.TabIndex = 5;
            this.btadd.Text = "Thêm Mới";
            this.btadd.UseVisualStyleBackColor = false;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btrefresh
            // 
            this.btrefresh.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrefresh.Location = new System.Drawing.Point(234, 121);
            this.btrefresh.Name = "btrefresh";
            this.btrefresh.Size = new System.Drawing.Size(124, 52);
            this.btrefresh.TabIndex = 6;
            this.btrefresh.Text = "Refresh";
            this.btrefresh.UseVisualStyleBackColor = true;
            this.btrefresh.Click += new System.EventHandler(this.btrefresh_Click);
            // 
            // btcheck
            // 
            this.btcheck.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcheck.Location = new System.Drawing.Point(391, 16);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(101, 33);
            this.btcheck.TabIndex = 7;
            this.btcheck.Text = "Tra Cứu";
            this.btcheck.UseVisualStyleBackColor = true;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // redep
            // 
            this.redep.BackColor = System.Drawing.Color.IndianRed;
            this.redep.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redep.Location = new System.Drawing.Point(517, 16);
            this.redep.Name = "redep";
            this.redep.Size = new System.Drawing.Size(104, 34);
            this.redep.TabIndex = 10;
            this.redep.Text = "Xóa Bộ Phận";
            this.redep.UseVisualStyleBackColor = false;
            this.redep.Click += new System.EventHandler(this.redep_Click);
            // 
            // ListDept
            // 
            this.ListDept.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListDept.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListDept.Location = new System.Drawing.Point(517, 68);
            this.ListDept.Name = "ListDept";
            this.ListDept.Size = new System.Drawing.Size(104, 29);
            this.ListDept.TabIndex = 11;
            this.ListDept.Text = "Danh Sách";
            this.ListDept.UseVisualStyleBackColor = false;
            this.ListDept.Click += new System.EventHandler(this.ListDept_Click);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 187);
            this.Controls.Add(this.ListDept);
            this.Controls.Add(this.redep);
            this.Controls.Add(this.btcheck);
            this.Controls.Add(this.btrefresh);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.btexit);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.did);
            this.Controls.Add(this.label1);
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox did;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btrefresh;
        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.Button redep;
        private System.Windows.Forms.Button ListDept;
    }
}