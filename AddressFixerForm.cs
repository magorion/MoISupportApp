using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOISupport.AddressFixer;

namespace MOISupport
{
    public partial class AddressFixerForm : Form
    {
        public AddressFixerForm()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {
            var loader = new Loader();
            loader.Load(this);
        }
    }
}
