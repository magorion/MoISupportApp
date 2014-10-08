using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using MOISupport.Properties;
using NLog;
using Remotion.Mixins.Definitions;
using ServiceStack;
using ServiceStack.Text;

namespace MOISupport.AddressFixer
{
    class Loader
    {
        private string filePath;
        public AddressFixerForm HandledForm { get; set; }

        private List<AddressInformation> GetValue(string filePath)
        {
            var excelQueryFactory = new ExcelQueryFactory(filePath);

            excelQueryFactory.AddMapping<AddressInformation>(x => x.State, "State");
            excelQueryFactory.AddMapping<AddressInformation>(x => x.City, "City");
            excelQueryFactory.AddMapping<AddressInformation>(x => x.Address, "Address");
            excelQueryFactory.AddMapping<AddressInformation>(x => x.PostalCode, "PostalCode");
            excelQueryFactory.AddMapping<AddressInformation>(x => x.Lat, "Lattitude");
            excelQueryFactory.AddMapping<AddressInformation>(x => x.Lng, "longitude");
            var usersToImport = excelQueryFactory.Worksheet<AddressInformation>(0).ToList();

            return usersToImport;
        }

        public void Load()
        {
            

            //if (ShowDialog(OpenFileDialog) != DialogResult.OK) return;

            try
            {
                var loadedRecords = GetValue(OpenFileDialog.FileName);

                filePath = OpenFileDialog.SafeFileName;

                Action actionTextBox = () =>
                {
                    HandledForm.fileInfoTextBox.Text = BuildInfo(loadedRecords);
                };

                Action actionFileButton = () =>
                {
                    HandledForm.loadFileButton.Text = Resources.loadFileButton_Loading;
                };

                if (HandledForm.fileInfoTextBox.InvokeRequired)
                {
                    HandledForm.fileInfoTextBox.Invoke(actionTextBox);
                }
                else
                {
                    actionTextBox();
                }

                if (HandledForm.loadFileButton.InvokeRequired)
                {
                    HandledForm.loadFileButton.Invoke(actionFileButton);
                }
                else
                {
                    actionFileButton();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public OpenFileDialog OpenFileDialog { get; set; }

        public DialogResult ShowDialog(OpenFileDialog openFileDialog)
        {
            return openFileDialog.ShowDialog();
        }

        public string BuildInfo(List<AddressInformation> loadedRecords)
        {
            string info = string.Format
                (
//----------------file info-------------------
@"File Name: {0}
Records Count: {1}
Example_Row: {2}",
//--------------------------------------------
                    filePath, loadedRecords.Count, loadedRecords[0].Dump()
                );
            
            return info;
        }
    }

    class AddressInformation
    {
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }

        public string Lat { get; set; }
        public string Lng { get; set; }

        public string GetCityAndState()
        {
            return string.Join(",", City, State);
        }

        public string GetLatAndLng()
        {
            return string.Join(",", Lat, Lng); 
        }
    }
}

