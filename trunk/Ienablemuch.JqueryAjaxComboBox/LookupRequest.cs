using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Ienablemuch.JqueryAjaxComboBox
{
    public class LookupRequest
    {
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string q_word { get; set; }

        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string primary_key { get; set; }
        public int per_page { get; set; }
        public int page_num { get; set; }

        // To facilitate cascading, I modified Jquery Ajax ComboBox and added this property, this is the property being sent by the client
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public string cascaded_word { get; set; }
    }
}
