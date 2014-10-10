using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
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
        private List<string> comboBoxItems;
        private List<ComboBox> comboBoxsList;
        private string textFormated;
        public AddressFixerForm()
        {
            InitializeComponent();
            comboBoxItems = new List<string>();
            foreach (var item in comboBox1.Items)
            {
                comboBoxItems.Add(item.ToString());
            }

            comboBoxsList = new List<ComboBox>()
            {
                comboBox1,
                comboBox2,
                comboBox3
            };

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
            panel1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            

            var indexSelected = comboBoxsList.IndexOf((ComboBox) sender);

            if (!button1.Visible)
                button1.Visible = true;

            for (int i = indexSelected + 1; i < 3; i++)
            {
                comboBoxsList[i].Items.Clear();
                comboBoxsList[i].Text = null;
                comboBoxsList[i].Visible = false;
            }

            //Format text box
           
            PrepareTextBox();
            

            if (sender == comboBox3) return;

            var tmpComboBoxItems = (from object item in comboBoxsList[indexSelected].Items select item.ToString()).ToList();

            tmpComboBoxItems.Remove(((ComboBox) sender).SelectedItem.ToString());

            foreach (var tmpComboBoxItem in tmpComboBoxItems)
            {
                comboBoxsList[indexSelected + 1].Items.Add(tmpComboBoxItem);
            }

            comboBoxsList[indexSelected + 1].Visible = true;
        }

        private void PrepareTextBox()
        {
            const string googleRequest = @"Google Maps Request: ";
            textFormated = string.Empty;

            foreach (var comboBox in comboBoxsList)
            {
                if (comboBox.Text != string.Empty)
                    textFormated += string.Format("[{0}],", comboBox.Text);
            }
            textFormated = textFormated.TrimEnd(',');

            formatTextBox.Text = googleRequest + textFormated;
            formatTextBox.SelectionStart = googleRequest.Length;
            formatTextBox.SelectionLength = textFormated.Length;
            formatTextBox.SelectionColor = Color.Green;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            panel1.Visible = true;
        }
    }
}
