namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tB_Username = new System.Windows.Forms.TextBox();
            this.btn_LogIn = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.tB_Chat = new System.Windows.Forms.TextBox();
            this.tB_Message = new System.Windows.Forms.TextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.lb_Chat = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя:";
            // 
            // tB_Username
            // 
            this.tB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tB_Username.Location = new System.Drawing.Point(120, 17);
            this.tB_Username.Name = "tB_Username";
            this.tB_Username.Size = new System.Drawing.Size(299, 29);
            this.tB_Username.TabIndex = 1;
            // 
            // btn_LogIn
            // 
            this.btn_LogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LogIn.Location = new System.Drawing.Point(425, 14);
            this.btn_LogIn.Name = "btn_LogIn";
            this.btn_LogIn.Size = new System.Drawing.Size(118, 37);
            this.btn_LogIn.TabIndex = 2;
            this.btn_LogIn.Text = "Log In";
            this.btn_LogIn.UseVisualStyleBackColor = true;
            this.btn_LogIn.Click += new System.EventHandler(this.btn_LogIn_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LogOut.Location = new System.Drawing.Point(549, 14);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(118, 37);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // tB_Chat
            // 
            this.tB_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tB_Chat.Location = new System.Drawing.Point(12, 65);
            this.tB_Chat.Multiline = true;
            this.tB_Chat.Name = "tB_Chat";
            this.tB_Chat.Size = new System.Drawing.Size(318, 292);
            this.tB_Chat.TabIndex = 4;
            // 
            // tB_Message
            // 
            this.tB_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tB_Message.Location = new System.Drawing.Point(12, 363);
            this.tB_Message.Multiline = true;
            this.tB_Message.Name = "tB_Message";
            this.tB_Message.Size = new System.Drawing.Size(531, 81);
            this.tB_Message.TabIndex = 5;
            // 
            // btn_Enter
            // 
            this.btn_Enter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Enter.Location = new System.Drawing.Point(549, 363);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(118, 81);
            this.btn_Enter.TabIndex = 6;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // lb_Chat
            // 
            this.lb_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_Chat.FormattingEnabled = true;
            this.lb_Chat.ItemHeight = 24;
            this.lb_Chat.Location = new System.Drawing.Point(336, 65);
            this.lb_Chat.Name = "lb_Chat";
            this.lb_Chat.Size = new System.Drawing.Size(331, 292);
            this.lb_Chat.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(679, 456);
            this.Controls.Add(this.lb_Chat);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.tB_Message);
            this.Controls.Add(this.tB_Chat);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_LogIn);
            this.Controls.Add(this.tB_Username);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_Username;
        private System.Windows.Forms.Button btn_LogIn;
        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.TextBox tB_Chat;
        private System.Windows.Forms.TextBox tB_Message;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.ListBox lb_Chat;

    }
}

