﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Geolocator
{
    class Address
    {
        public string road { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public string state_district { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }

    }

    public class RootObject

    {
        //Address address = new Address();
            
        public string place_id { get; set; }
        public string licence { get; set; }

        public string osm_type { get; set; }
        public string osm_id { get; set; }

        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
       //public Address address { get; set; }

    }
}
