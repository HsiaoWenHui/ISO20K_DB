//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISO20K.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ci_family_application
    {
        public int application_id { get; set; }
        public string name { get; set; }
        public int ci_id { get; set; }
        public string manufacturer { get; set; }
        public string version { get; set; }
    
        public virtual ci ci { get; set; }
    }
}
