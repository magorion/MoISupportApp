using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOISupport.AddressFixer;
using MOISupport.Properties;

namespace MOISupport
{
    public partial class AddressFixerForm : Form
    {

        private Thread progressThread;
        public AddressFixerForm()
        {
            InitializeComponent();
        }

        private void loadFileButton_Click(object sender, EventArgs e)
        {

            var openFileDialog = new OpenFileDialog
            {
                Filter = @"Excel Files (*.xls, *xlsx)|*.xls;*.xlsx;*.xlsm",
                FilterIndex = 1
            };
            var loader = new Loader {HandledForm = this, OpenFileDialog = openFileDialog};
            if (loader.ShowDialog(openFileDialog) != DialogResult.OK) return;


           
            progressThread = new Thread(new ThreadStart(loader.Load));

            loadFileButton.Enabled = false;

            loadFileButton.Text = Resources.loadFileButton_Loading;

            progressAnimatonBox.Visible = true;

            progressThread.Start();


        }

        private void fileInfoTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!progressAnimatonBox.Visible) return;
            progressThread.Abort();
            progressAnimatonBox.Visible = false;
            loadFileButton.Enabled = true;
            loadFileButton.Text = Resources.loadFileButton_Default;
        }
    }
}
