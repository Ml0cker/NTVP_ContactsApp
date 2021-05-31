using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsAppBLL;

namespace ContactsAppUI
{
    public partial class ContctsApp : Form
    {
        public ContctsApp()
        {
            InitializeComponent(); 
            var project = new PhoneNumber();
        }

        private void ContctsApp_Load(object sender, EventArgs e)
        {

        }
    }
}
