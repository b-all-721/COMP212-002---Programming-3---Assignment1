namespace PublisherApp
{
    partial class FormSubscription
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
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.checkBox_sentByPhone = new System.Windows.Forms.CheckBox();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_unsubscribe = new System.Windows.Forms.Button();
            this.button_subscribe = new System.Windows.Forms.Button();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.checkBox_sentByMail = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(316, 106);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_phone.TabIndex = 18;
            // 
            // checkBox_sentByPhone
            // 
            this.checkBox_sentByPhone.AutoSize = true;
            this.checkBox_sentByPhone.Location = new System.Drawing.Point(163, 106);
            this.checkBox_sentByPhone.Name = "checkBox_sentByPhone";
            this.checkBox_sentByPhone.Size = new System.Drawing.Size(142, 17);
            this.checkBox_sentByPhone.TabIndex = 17;
            this.checkBox_sentByPhone.Text = "Message Sent by Phone";
            this.checkBox_sentByPhone.UseVisualStyleBackColor = true;
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(482, 201);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 16;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            // 
            // button_unsubscribe
            // 
            this.button_unsubscribe.Location = new System.Drawing.Point(300, 201);
            this.button_unsubscribe.Name = "button_unsubscribe";
            this.button_unsubscribe.Size = new System.Drawing.Size(75, 23);
            this.button_unsubscribe.TabIndex = 15;
            this.button_unsubscribe.Text = "Unsubscribe";
            this.button_unsubscribe.UseVisualStyleBackColor = true;
            // 
            // button_subscribe
            // 
            this.button_subscribe.Location = new System.Drawing.Point(138, 201);
            this.button_subscribe.Name = "button_subscribe";
            this.button_subscribe.Size = new System.Drawing.Size(75, 23);
            this.button_subscribe.TabIndex = 14;
            this.button_subscribe.Text = "Subscribe";
            this.button_subscribe.UseVisualStyleBackColor = true;
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(316, 80);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(100, 20);
            this.textBox_email.TabIndex = 13;
            // 
            // checkBox_sentByMail
            // 
            this.checkBox_sentByMail.AutoSize = true;
            this.checkBox_sentByMail.Location = new System.Drawing.Point(163, 80);
            this.checkBox_sentByMail.Name = "checkBox_sentByMail";
            this.checkBox_sentByMail.Size = new System.Drawing.Size(136, 17);
            this.checkBox_sentByMail.TabIndex = 12;
            this.checkBox_sentByMail.Text = "Message Sent by Email";
            this.checkBox_sentByMail.UseVisualStyleBackColor = true;
            // 
            // FormSubscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 348);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.checkBox_sentByPhone);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_unsubscribe);
            this.Controls.Add(this.button_subscribe);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.checkBox_sentByMail);
            this.Name = "FormSubscription";
            this.Text = "FormSubscription";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.CheckBox checkBox_sentByPhone;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_unsubscribe;
        private System.Windows.Forms.Button button_subscribe;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.CheckBox checkBox_sentByMail;
    }
}