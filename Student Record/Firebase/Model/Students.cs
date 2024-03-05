using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Record.Firebase.Model
{
    [FirestoreData]
    internal class Students
    {
        [FirestoreProperty]
        public string? id { get; set; }
        [FirestoreProperty]
        public string? name { get; set; }
        [FirestoreProperty]
        public string? first_name { get; set; }
        [FirestoreProperty]
        public string? middle_name { get; set; }
        [FirestoreProperty]
        public string? last_name { get; set; }
        [FirestoreProperty]
        public string? suffix { get; set; }
        [FirestoreProperty]
        public string? lrn_number { get; set; }
        [FirestoreProperty]
        public string? dob { get; set; }
        [FirestoreProperty]
        public string? address { get; set; }
        [FirestoreProperty]
        public string? contact_number { get; set; }
        [FirestoreProperty]
        public string? father_contact { get; set; }
        [FirestoreProperty]
        public string? mother_contact { get; set; }
        [FirestoreProperty]
        public string? guardian_contact { get; set; }
        [FirestoreProperty]
        public string? father_name { get; set; }
        [FirestoreProperty]
        public string? mother_name { get; set; }
        [FirestoreProperty]
        public string? guardian_name { get; set; }
        [FirestoreProperty]
        public string? last_school_attended { get; set; }
        [FirestoreProperty]
        public string? major { get; set; }
        [FirestoreProperty]
        public int? grade_level { get; set; }
        [FirestoreProperty]
        public string? gender { get; set; }
        [FirestoreProperty]
        public string? section { get; set; }
        [FirestoreProperty]
        public string? adviser { get; set; }
        [FirestoreProperty]
        public string? faculty_id { get; set; }
        [FirestoreProperty]
        public bool? hasGrade { get; set; }
        [FirestoreProperty]
        public bool? hasHonor { get; set; }
        [FirestoreProperty]
        public string? filePath { get; set; }
        [FirestoreProperty]
        public string? fileName { get; set; }
        [FirestoreProperty]
        public string? ImageStr { get; set; }
        [FirestoreProperty]
        public string? fileUrl { get; set; }
        //with grades, for grading sheet
        [FirestoreProperty]
        public string? subject { get; set; }
        [FirestoreProperty]
        public string? term { get; set; }
        [FirestoreProperty]
        public double? mid_term_grade { get; set; }
        [FirestoreProperty]
        public double? final_term_grade { get; set; }
        [FirestoreProperty]
        public double? final_grade { get; set; }
        //grade id
        [FirestoreProperty]
        public string? grade_id { get; set; }
    }
}
