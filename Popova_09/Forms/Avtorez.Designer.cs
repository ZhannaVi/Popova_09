namespace Popova_09
{
    partial class Avtorez
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorez));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.btnVxod = new System.Windows.Forms.Button();
            this.btnGost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Popova_09.Properties.Resources._87af068b92ad4e1a6a64329795cc3b911;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 485);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(483, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.SystemColors.Info;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin.ForeColor = System.Drawing.Color.Black;
            this.txtLogin.Location = new System.Drawing.Point(700, 167);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(247, 39);
            this.txtLogin.TabIndex = 2;
            // 
            // txtPas
            // 
            this.txtPas.BackColor = System.Drawing.SystemColors.Info;
            this.txtPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPas.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtPas.Location = new System.Drawing.Point(700, 259);
            this.txtPas.Name = "txtPas";
            this.txtPas.PasswordChar = '❀';
            this.txtPas.Size = new System.Drawing.Size(247, 39);
            this.txtPas.TabIndex = 2;
            // 
            // btnVxod
            // 
            this.btnVxod.BackColor = System.Drawing.Color.BurlyWood;
            this.btnVxod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVxod.Location = new System.Drawing.Point(587, 357);
            this.btnVxod.Name = "btnVxod";
            this.btnVxod.Size = new System.Drawing.Size(214, 56);
            this.btnVxod.TabIndex = 3;
            this.btnVxod.Text = "Войти";
            this.btnVxod.UseVisualStyleBackColor = false;
            this.btnVxod.Click += new System.EventHandler(this.btnVxod_Click);
            // 
            // btnGost
            // 
            this.btnGost.BackColor = System.Drawing.Color.BurlyWood;
            this.btnGost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGost.Location = new System.Drawing.Point(587, 419);
            this.btnGost.Name = "btnGost";
            this.btnGost.Size = new System.Drawing.Size(214, 56);
            this.btnGost.TabIndex = 3;
            this.btnGost.Text = "Войти, как гость";
            this.btnGost.UseVisualStyleBackColor = false;
            this.btnGost.Click += new System.EventHandler(this.btnGost_Click);
            // 
            // Avtorez
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(959, 482);
            this.Controls.Add(this.btnGost);
            this.Controls.Add(this.btnVxod);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Avtorez";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Button btnVxod;
        private System.Windows.Forms.Button btnGost;
    }
}

