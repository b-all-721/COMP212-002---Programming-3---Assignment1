﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PublisherApp
{
    public partial class FormNotification : Form
    {
        public FormNotification()
        {
            InitializeComponent();
        }

        private void button_publish_Click(object sender, EventArgs e)
        {
            Program.publisher.PublishMessage(textBox_notification.Text);
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
