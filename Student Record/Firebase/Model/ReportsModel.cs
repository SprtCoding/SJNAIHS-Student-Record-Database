using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.Firebase.Model
{
    [FirestoreData]
    internal class ReportsModel
    {
        [FirestoreProperty]
        public string? report_id { get; set; }
        [FirestoreProperty]
        public string? faculty_id { get; set; }
        [FirestoreProperty]
        public string? faculty_name { get; set; }
        [FirestoreProperty]
        public string? report_type { get; set; }
        [FirestoreProperty]
        public string? status { get; set; }
    }
}
