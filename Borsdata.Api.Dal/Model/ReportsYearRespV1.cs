

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Borsdata.Api.Dal.Model
{
  

    public partial class ReportsYearRespV1 
    {
      
        public long? Instrument { get; set; }
        public List<ReportYearV1> Reports { get; set; }

        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}