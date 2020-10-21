using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Helpers
{
    public class DatabaseTypeModel
    {
        public string DbConnection { get; set; }
        public DBTypeENum DBType { get; set; }
    }

    public enum  DBTypeENum{
        SQL,
        COSMOS
    }
}
