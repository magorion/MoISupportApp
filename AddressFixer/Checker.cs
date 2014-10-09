using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using MOISupport.GeocodingApi;
using ServiceStack.Text;

namespace MOISupport.AddressFixer
{
    class Checker : AddressType
    {
        public static void Check(List<string> valuesToCheck, string type)
        {
            foreach (var value in valuesToCheck)
            {
                //var result = GeolocationService.GetResult(value, type);
                //if (value.Contains(result.Dump()))
                //{
                //    Action action = 
                //}
            }
        }
    }

    class AddressType
    {
        public string Address
        {
            get
            {
                return "address";
            }
        }

        public string LatLng
        {
            get
            {
                return "latlng";
            }
        }
    }
}