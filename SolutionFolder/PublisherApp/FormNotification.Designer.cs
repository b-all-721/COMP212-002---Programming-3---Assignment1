namespace PublisherApp
{
    partial class FormNotification
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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_publish = new System.Windows.Forms.Button();
            this.textBox_notification = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(313, 151);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_publish
            // 
            this.button_publish.Location = new System.Drawing.Point(180, 151);
            this.button_publish.Name = "button_publish";
            this.button_publish.Size = new System.Drawing.Size(75, 23);
            this.button_publish.TabIndex = 6;
            this.button_publish.Text = "Publish";
            this.button_publish.UseVisualStyleBackColor = true;
            this.button_publish.Click += new System.EventHandler(this.button_publish_Click);
            // 
            // textBox_notification
            // 
            this.textBox_notification.Location = new System.Drawing.Point(288, 80);
            this.textBox_notification.Name = "textBox_notification";
            this.textBox_notification.Size = new System.Drawing.Size(100, 20);
            this.textBox_notification.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Notification Content";
            // 
            // FormNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 292);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_publish);
            this.Controls.Add(this.textBox_notification);
            this.Controls.Add(this.label1);
            this.Name = "FormNotification";
            this.Text = "FormNotification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_publish;
        private System.Windows.Forms.TextBox textBox_notification;
        private System.Windows.Forms.Label label1;
    }
}