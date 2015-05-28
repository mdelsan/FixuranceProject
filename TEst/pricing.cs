using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace TEst
{
    [DataContract()]
    public class pricing
    {
        [DataMember]
        public string postalCode;

        [DataMember]
        public string address;

        [DataMember]
        public string area;

        [DataMember]
        public string buildYear;

        [DataMember]
        public string insuranceStartDate;

        [DataMember]
        public string houseType;

        [DataMember]
        public string currency;

        [DataMember]
        public string billingPeriod;

        [DataMember]
        public priceDetail price;
        
    }

    public class priceDetail
    {
        [DataMember]
        public string currency;

        [DataMember]
        public string billingPeriod;

        [DataMember]
        public string price;
    }

}
