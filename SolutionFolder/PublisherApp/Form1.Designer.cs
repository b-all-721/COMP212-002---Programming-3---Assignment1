namespace PublisherApp
{
    partial class Form1
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
            this.button_manageSubscription = new System.Windows.Forms.Button();
            this.button_publishNotification = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_manageSubscription
            // 
            this.button_manageSubscription.Location = new System.Drawing.Point(57, 93);
            this.button_manageSubscription.Name = "button_manageSubscription";
            this.button_manageSubscription.Size = new System.Drawing.Size(147, 23);
            this.button_manageSubscription.TabIndex = 0;
            this.button_manageSubscription.Text = "Manage Subscription";
            this.button_manageSubscription.UseVisualStyleBackColor = true;
            this.button_manageSubscription.Click += new System.EventHandler(this.button_manageSubscription_Click);
            // 
            // button_publishNotification
            // 
            this.button_publishNotification.Location = new System.Drawing.Point(243, 93);
            this.button_publishNotification.Name = "button_publishNotification";
            this.button_publishNotification.Size = new System.Drawing.Size(125, 23);
            this.button_publishNotification.TabIndex = 1;
            this.button_publishNotification.Text = "Publish Notification";
            this.button_publishNotification.UseVisualStyleBackColor = true;
            this.button_publishNotification.Click += new System.EventHandler(this.button_publishNotification_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(422, 93);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 252);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_publishNotification);
            this.Controls.Add(this.button_manageSubscription);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_manageSubscription;
        private System.Windows.Forms.Button button_publishNotification;
        private System.Windows.Forms.Button button_exit;
    }
}

