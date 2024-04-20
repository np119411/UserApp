namespace UserApp
{
    partial class UserInterface
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
            this.uid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.did = new System.Windows.Forms.ComboBox();
            this.adduser = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.bttracuu = new System.Windows.Forms.Button();
            this.bttaddbp = new System.Windows.Forms.Button();
            this.reemp = new System.Windows.Forms.Button();
            this.ListNV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uid
            // 
            this.uid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uid.Location = new System.Drawing.Point(155, 18);
            this.uid.MaxLength = 8;
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(444, 33);
            this.uid.TabIndex = 0;
            this.uid.TextChanged += new System.EventHandler(this.uid_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Nhân Viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // uname
            // 
            this.uname.Location = new System.Drawing.Point(155, 76);
            this.uname.MaxLength = 256;
            this.uname.Name = "uname";
            this.uname.Size = new System.Drawing.Size(444, 33);
            this.uname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã Bộ Phận:";
            // 
            // dname
            // 
            this.dname.Location = new System.Drawing.Point(155, 190);
            this.dname.Name = "dname";
            this.dname.Size = new System.Drawing.Size(444, 33);
            this.dname.TabIndex = 3;
            this.dname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.did_MouseClick);
            this.dname.TextChanged += new System.EventHandler(this.dname_TextChanged);
            this.dname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckTabKeyPress);
            this.dname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CheckTabKeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên Bộ Phận:";
            // 
            // did
            // 
            this.did.FormattingEnabled = true;
            this.did.Location = new System.Drawing.Point(155, 135);
            this.did.Name = "did";
            this.did.Size = new System.Drawing.Size(444, 33);
            this.did.TabIndex = 2;
            this.did.SelectedIndexChanged += new System.EventHandler(this.did_SelectedIndexChanged);
            this.did.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnterKeyPress);
            // 
            // adduser
            // 
            this.adduser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.adduser.Location = new System.Drawing.Point(676, 269);
            this.adduser.Name = "adduser";
            this.adduser.Size = new System.Drawing.Size(131, 49);
            this.adduser.TabIndex = 6;
            this.adduser.Text = "Thêm Mới";
            this.adduser.UseVisualStyleBackColor = false;
            this.adduser.Click += new System.EventHandler(this.adduser_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.refresh.Location = new System.Drawing.Point(232, 269);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(131, 49);
            this.refresh.TabIndex = 7;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.IndianRed;
            this.exit.Location = new System.Drawing.Point(17, 269);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(131, 49);
            this.exit.TabIndex = 8;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // bttracuu
            // 
            this.bttracuu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttracuu.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttracuu.Location = new System.Drawing.Point(615, 16);
            this.bttracuu.Name = "bttracuu";
            this.bttracuu.Size = new System.Drawing.Size(71, 35);
            this.bttracuu.TabIndex = 1;
            this.bttracuu.Text = "Tra cứu";
            this.bttracuu.UseVisualStyleBackColor = false;
            this.bttracuu.Click += new System.EventHandler(this.bttracuu_Click);
            // 
            // bttaddbp
            // 
            this.bttaddbp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.bttaddbp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttaddbp.Location = new System.Drawing.Point(615, 133);
            this.bttaddbp.Name = "bttaddbp";
            this.bttaddbp.Size = new System.Drawing.Size(192, 36);
            this.bttaddbp.TabIndex = 4;
            this.bttaddbp.Text = "Thêm bộ phận mới";
            this.bttaddbp.UseVisualStyleBackColor = false;
            this.bttaddbp.Click += new System.EventHandler(this.bttaddbp_Click);
            // 
            // reemp
            // 
            this.reemp.BackColor = System.Drawing.Color.IndianRed;
            this.reemp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reemp.Location = new System.Drawing.Point(703, 18);
            this.reemp.Name = "reemp";
            this.reemp.Size = new System.Drawing.Size(104, 34);
            this.reemp.TabIndex = 9;
            this.reemp.Text = "Xóa Nhân Viên";
            this.reemp.UseVisualStyleBackColor = false;
            this.reemp.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListNV
            // 
            this.ListNV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListNV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNV.Location = new System.Drawing.Point(462, 271);
            this.ListNV.Name = "ListNV";
            this.ListNV.Size = new System.Drawing.Size(123, 49);
            this.ListNV.TabIndex = 10;
            this.ListNV.Text = "Danh Sách Nhân Viên";
            this.ListNV.UseVisualStyleBackColor = false;
            this.ListNV.Click += new System.EventHandler(this.ListNV_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 351);
            this.Controls.Add(this.ListNV);
            this.Controls.Add(this.reemp);
            this.Controls.Add(this.bttaddbp);
            this.Controls.Add(this.bttracuu);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.adduser);
            this.Controls.Add(this.did);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uid);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UserInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Interface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button adduser;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button bttracuu;
        private System.Windows.Forms.Button bttaddbp;
        private System.Windows.Forms.ComboBox did;
        private System.Windows.Forms.Button reemp;
        private System.Windows.Forms.Button ListNV;
    }
}

