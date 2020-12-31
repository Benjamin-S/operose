using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operose
{
    public class BatchModel
    {
        public string BatchSource { get; set; }
        public string BatchNumber { get; set; }
        public int MarkedToPost { get; set; }
        public int BatchStatus { get; set; }
        public bool Selected { get; set; }

        public BatchModel() { }

        public BatchModel(string batchSource, string batchNumber, int markedToPost, int batchStatus, bool selected = false)
        {
            BatchSource = batchSource;
            BatchNumber = batchNumber;
            MarkedToPost = markedToPost;
            BatchStatus = batchStatus;
            Selected = selected;
        }
    }
}
