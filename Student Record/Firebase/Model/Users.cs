using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.Firebase.Model
{
    [FirestoreData]
    internal class Users
    {
        [FirestoreProperty]
        public string? id { get; set; }
        [FirestoreProperty]
        public string? name { get; set; }
        [FirestoreProperty]
        public string? email { get; set; }
        [FirestoreProperty]
        public string? account_type { get; set; }
        [FirestoreProperty]
        public string? login_code { get; set; }
        [FirestoreProperty]
        public string? position { get; set; }
    }
}
