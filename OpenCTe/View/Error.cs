﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenCTe.View {
    public partial class Error : Form {
        public Error() {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) {
            System.Windows.Forms.Application.Restart();
        }
    }
}