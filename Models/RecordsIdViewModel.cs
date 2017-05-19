using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcRecords.Models
{
    public class RecordsIdViewModel
    {
        public List<Record> records;
        public SelectList id;
        public string recordId { get; set; }
    }
}
