using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using NLog;
using Remotion.Mixins.Definitions;
using ServiceStack.Text;

namespace MOISupport.AddressFixer
{
    class Loader
    {
        private string filePath;

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

        public void Load(AddressFixerForm form)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = @"Excel Files (*.xls, *xlsx)|*.xls;*.xlsx;*.xlsm";
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var loadedRecords = GetValue(openFileDialog.FileName);

                    filePath = openFileDialog.SafeFileName;

                    form.fileInfoTextBox.Text = BuildInfo(loadedRecords);
                }
                catch (Exception)
                {
                    throw;
                }
            }  
        }

        public string BuildInfo(List<AddressInformation> loadedRecords)
        {
            string info = string.Format
                (
@"File Name: {0}
Records Count: {1}",
                    filePath, loadedRecords.Count
                ).Trim('\t');
            

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

        public string CityAndState
        {
            get { return string.Join(",", City, State); }
        }

        public string LatAndLng
        {
            get { return string.Join(",", Lat, Lng); }
        }
    }
}

