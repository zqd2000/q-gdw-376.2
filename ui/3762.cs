﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ui
{
    public partial class MainUi : Form
    {
        public MainUi()
        {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e )
        {
            UserNativeCode.DispatchCommand( 1, 0 );
        }

        
    }
}