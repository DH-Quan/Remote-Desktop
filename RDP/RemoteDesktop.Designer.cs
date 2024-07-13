namespace RDP
{
    partial class RemoteDesktop
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
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KeyGen = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_fullname = new System.Windows.Forms.Label();
            this.txt_firstname = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.pic_Profile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(325, 120);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(104, 23);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(136, 120);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(90, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(136, 65);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(100, 22);
            this.txtKey.TabIndex = 5;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Key";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "KeyGen";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // KeyGen
            // 
            this.KeyGen.Location = new System.Drawing.Point(529, 65);
            this.KeyGen.Name = "KeyGen";
            this.KeyGen.Size = new System.Drawing.Size(102, 22);
            this.KeyGen.TabIndex = 9;
            this.KeyGen.TextChanged += new System.EventHandler(this.KeyGen_TextChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(529, 255);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.btn_KeyGen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(545, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "chat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_fullname
            // 
            this.txt_fullname.AutoSize = true;
            this.txt_fullname.Location = new System.Drawing.Point(308, 195);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(60, 16);
            this.txt_fullname.TabIndex = 14;
            this.txt_fullname.Text = "fullName";
            // 
            // txt_firstname
            // 
            this.txt_firstname.AutoSize = true;
            this.txt_firstname.Location = new System.Drawing.Point(259, 240);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(64, 16);
            this.txt_firstname.TabIndex = 15;
            this.txt_firstname.Text = "firstName";
            // 
            // txt_lastName
            // 
            this.txt_lastName.AutoSize = true;
            this.txt_lastName.Location = new System.Drawing.Point(356, 240);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(65, 16);
            this.txt_lastName.TabIndex = 16;
            this.txt_lastName.Text = "lastName";
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Location = new System.Drawing.Point(308, 289);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(40, 16);
            this.txt_email.TabIndex = 17;
            this.txt_email.Text = "email";
            // 
            // pic_Profile
            // 
            this.pic_Profile.Location = new System.Drawing.Point(86, 195);
            this.pic_Profile.Name = "pic_Profile";
            this.pic_Profile.Size = new System.Drawing.Size(125, 110);
            this.pic_Profile.TabIndex = 18;
            this.pic_Profile.TabStop = false;
            this.pic_Profile.Click += new System.EventHandler(this.pic_Profile_Click);
            // 
            // RemoteDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 390);
            this.Controls.Add(this.pic_Profile);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.txt_fullname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.KeyGen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnDisconnect);
            this.Name = "RemoteDesktop";
            this.Text = "RemoteDesktop";
            this.Load += new System.EventHandler(this.RemoteDesktop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox KeyGen;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label txt_fullname;
        private System.Windows.Forms.Label txt_firstname;
        private System.Windows.Forms.Label txt_lastName;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.PictureBox pic_Profile;
    }
}