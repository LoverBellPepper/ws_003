namespace проба
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserLogin = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonGuest = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(752, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(36, 34);
            this.Close.TabIndex = 0;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // UserLogin
            // 
            this.UserLogin.Location = new System.Drawing.Point(409, 152);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(159, 20);
            this.UserLogin.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(409, 218);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(159, 20);
            this.Password.TabIndex = 3;
            // 
            // Loginlabel
            // 
            this.Loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Loginlabel.Location = new System.Drawing.Point(312, 152);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(55, 20);
            this.Loginlabel.TabIndex = 4;
            this.Loginlabel.Text = "Логин";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(312, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(316, 298);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(244, 38);
            this.ButtonLogin.TabIndex = 6;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonGuest
            // 
            this.ButtonGuest.Location = new System.Drawing.Point(316, 353);
            this.ButtonGuest.Name = "ButtonGuest";
            this.ButtonGuest.Size = new System.Drawing.Size(244, 38);
            this.ButtonGuest.TabIndex = 7;
            this.ButtonGuest.Text = "Войти как \"Гость\"";
            this.ButtonGuest.UseVisualStyleBackColor = true;
            this.ButtonGuest.Click += new System.EventHandler(this.ButtonGuest_Click);
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(30, 13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(76, 72);
            this.Logo.TabIndex = 8;
            this.Logo.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ButtonGuest);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Loginlabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLogin;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonGuest;
        private System.Windows.Forms.PictureBox Logo;
    }
}

