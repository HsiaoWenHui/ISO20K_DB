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
    
    public partial class ci_log
    {
        public int cilog_id { get; set; }
        public int ci_id { get; set; }
        public byte opcode_id { get; set; }
        public int operator_id { get; set; }
        public int department_id { get; set; }
        public System.DateTime opdate { get; set; }
        public string description { get; set; }
    
        public virtual ci ci { get; set; }
        public virtual ci_family_employee ci_family_employee { get; set; }
        public virtual ci_opcode ci_opcode { get; set; }
        public virtual department department { get; set; }
        public virtual @operator @operator { get; set; }
    }
}
