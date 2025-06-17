using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1.Views
{
    public partial class SubMain : Form
    {
        public SubMain()
        {
            InitializeComponent();
        }
       
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
