﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_Hotel_Booking.Details
{
    public partial class CommentItem : UserControl
    {
        public CommentItem(string name, string com)
        {
            InitializeComponent();
            label1.Text = name;
            descriptionTb.Text = com;
        }
    }
}
