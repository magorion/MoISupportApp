using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOISupport.GeocodingApi
{
    public class Result
    {
        public List<AddressComponent> address_components { get; set; }
        public string formatted_address { get; set; }
        public Geometry geometry { get; set; }
        public List<string> types { get; set; }
        public string PostCode
        {
            get
            {
                var postCode = this.address_components.FirstOrDefault(x => x.types.Contains("postal_code"));
                if (postCode == null) return string.Empty;

                return postCode.long_name;
            }
        }
        public string CityName
        {
            get
            {
                var cityName = this.address_components.FirstOrDefault(x => x.types.Contains("political"));
                if (cityName == null) return string.Empty;

                return cityName.long_name;
            }
        }
    }
}
