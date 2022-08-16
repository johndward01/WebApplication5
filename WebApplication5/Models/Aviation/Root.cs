using System.Collections.Generic;

namespace WebApplication5.Models.Aviation
{
    public class Root
    {
        public Pagination pagination { get; set; }
        public List<DataItem> data { get; set; }
    }
}
