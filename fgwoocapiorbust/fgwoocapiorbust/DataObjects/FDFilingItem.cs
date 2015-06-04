using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Mobile.Service;

namespace fgwoocapiorbust.DataObjects
{
   public class FDFilingItem : EntityData
    {
        public int filingID { get; set; }
        public string docID { get; set; }
        public int profileID { get; set; }
        public Nullable<int> filerID { get; set; }
        public string prefix { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string suffix { get; set; }
        public string agencyCode { get; set; }
        public string officeCode { get; set; }
        public Nullable<int> filingYear { get; set; }
        public string filingType { get; set; }
        public string filerReq { get; set; }
        public string filerType { get; set; }
        public Nullable<System.DateTime> filingDate { get; set; }
        public string docXMLData { get; set; }
        public Nullable<System.DateTime> addTimeStamp { get; set; }
        public Nullable<System.DateTime> terminationDate { get; set; }
        public Nullable<int> electionYear { get; set; }
        public string fecID { get; set; }
        public string bioguideID { get; set; }
        public Nullable<int> staffID { get; set; }
    }
}
