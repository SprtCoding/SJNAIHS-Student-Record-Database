using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Student_Record.Firebase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Bunifu.Framework.UI;

namespace Student_Record.TeachersModule.GradingSheetPrint
{
    public partial class SummaryPrintPreview : Form
    {
        private string? my_id, term, sem, grade_level;
        private PrintPreviewDialog? printPrevDialog = new PrintPreviewDialog();
        private PrintDocument? printDoc = new PrintDocument();
        Bitmap? bitmap;
        public SummaryPrintPreview(string id, string term, string sem, string grade_level)
        {
            InitializeComponent();
            this.my_id = id;
            this.term = term;
            this.sem = sem;
            this.grade_level = grade_level;

            string semTxt;
            if (sem.Equals("1"))
            {
                semTxt = "First Semester";
                term_lbl.Text = semTxt + " - " + term;
            }
            else if (sem.Equals("2"))
            {
                semTxt = "Second Semester";
                term_lbl.Text = semTxt + " - " + term;
            }

            if(StudentGradingSummary.studentSection.Equals("Any"))
            {
                section_lbl.Text = "All Section";
            }
            else
            {
                section_lbl.Text = StudentGradingSummary.studentSection;
            }

            print_tp.SetToolTip(printBtn, "Print");
        }

        public async Task getSummaryGradeBySection(string term, string sem, string grade_level, string section)
        {
            grading_summary_dtg.DataSource = null;
            grading_summary_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    int gradeLvl = int.Parse(grade_level);
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef
                        .WhereEqualTo("faculty_id", this.my_id)
                        .WhereEqualTo("grade_level", gradeLvl)
                        .WhereEqualTo("section", section);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        foreach (string columnName in StudentGradingSummary.g11_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        foreach (string columnName in StudentGradingSummary.g11_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        foreach (string columnName in StudentGradingSummary.g12_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        foreach (string columnName in StudentGradingSummary.g12_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }

                    bool isDataFound = false;

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                            // Access the "grade" subcollection for the current student
                            CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                            Query gradeQ = gradeRef.WhereEqualTo("sem", sem);

                            QuerySnapshot gradeSnap = await gradeQ.GetSnapshotAsync();

                            double g1 = 0, g2 = 0, g3 = 0, g4 = 0,
                                g5 = 0, g6 = 0, g7 = 0, g8 = 0, grades = 0;

                            int currentProgress = 0;
                            int totalGrade = gradeSnap.Documents.Count;

                            string majSub = "";

                            foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                            {
                                if (gradeDoc.Exists)
                                {
                                    // Access and use data from the "grade" document
                                    // Example:
                                    Students grade = gradeDoc.ConvertTo<Students>();

                                    if (term.Equals("Mid Term"))
                                    {
                                        grades = (double)grade.mid_term_grade;
                                    }
                                    else if (term.Equals("Final Term"))
                                    {
                                        grades = (double)grade.final_term_grade;
                                    }

                                    majSub = grade.subject;

                                    if (grade_level.Equals("11") && sem.Equals("1"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Oral Communication":
                                                g1 += grades;
                                                break;
                                            case "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino":
                                                g2 += grades;
                                                break;
                                            case "21st Century Literature from the Philippines and the World":
                                                g3 += grades;
                                                break;
                                            case "General Mathematics":
                                                g4 += grades;
                                                break;
                                            case "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao":
                                                g5 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("11") && sem.Equals("2"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Reading and Writing":
                                                g1 += grades;
                                                break;
                                            case "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik":
                                                g2 += grades;
                                                break;
                                            case "Understanding Culture, Society and Politics":
                                                g3 += grades;
                                                break;
                                            case "Statistics and Probability":
                                                g4 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g5 += grades;
                                                break;
                                            case "Practical Research 1":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("12") && sem.Equals("1"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Personal Development/Pansariling Kaunlaran":
                                                g1 += grades;
                                                break;
                                            case "Earth and Life Science":
                                                g2 += grades;
                                                break;
                                            case "Media and Information Literacy":
                                                g3 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g4 += grades;
                                                break;
                                            case "English for Academic and Professional Purposes":
                                                g5 += grades;
                                                break;
                                            case "Practical Research 2":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Animal Production NCII":
                                            case "Food Fish Processing NCII":
                                            case "Illustration NCII":
                                            case "Computer Systems Servicing NCII":
                                            case "Agricultural Crops Production NC II":
                                            case "Tailoring NCII":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("12") && sem.Equals("2"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Contemporary Philippine Arts from the Regions":
                                                g1 += grades;
                                                break;
                                            case "Physical Science":
                                                g2 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g3 += grades;
                                                break;
                                            case "Filipino sa Piling Larang":
                                                g4 += grades;
                                                break;
                                            case "Empowerment Technologies":
                                                g5 += grades;
                                                break;
                                            case "Inquiries, Investigations and Immersion":
                                                g6 += grades;
                                                break;
                                            case "Entrepreneurship":
                                                g7 += grades;
                                                break;
                                            case "Work Immersion":
                                                g8 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }

                                    isDataFound = true;
                                }
                                else
                                {
                                    isDataFound = false;
                                    // Handle the case where there is no data in the "grade" subcollection
                                }
                            }

                            string major = "";
                            switch (majSub)
                            {
                                case "Electrical Installation & Maintenance NCII":
                                    major = "Electrical Installation & Maintenance NCII";
                                    break;
                                case "Animal Production NCII":
                                    major = "Animal Production NCII";
                                    break;
                                case "Food Fish Processing NCII":
                                    major = "Food Fish Processing NCII";
                                    break;
                                case "Illustration NCII":
                                    major = "Illustration NCII";
                                    break;
                                case "Computer Systems Servicing NCII":
                                    major = "Computer Systems Servicing NCII";
                                    break;
                                case "Agricultural Crops Production NC II":
                                    major = "Agricultural Crops Production NC II";
                                    break;
                                case "Tailoring NCII":
                                    major = "Tailoring NCII";
                                    break;
                                case "Work Immersion":
                                    major = "Work Immersion";
                                    break;
                                default:
                                    major = "TVE";
                                    break;
                            }

                            if (grade_level.Equals("11") && sem.Equals("1"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Oral Communication", g1);
                                filteredTable.Rows[0].SetField("Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino", g2);
                                filteredTable.Rows[0].SetField("21st Century Literature from the Philippines and the World", g3);
                                filteredTable.Rows[0].SetField("General Mathematics", g4);
                                filteredTable.Rows[0].SetField("Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao", g5);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("11") && sem.Equals("2"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Reading and Writing", g1);
                                filteredTable.Rows[0].SetField("Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik", g2);
                                filteredTable.Rows[0].SetField("Understanding Culture, Society and Politics", g3);
                                filteredTable.Rows[0].SetField("Statistics and Probability", g4);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g5);
                                filteredTable.Rows[0].SetField("Practical Research 1", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("12") && sem.Equals("1"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Personal Development/Pansariling Kaunlaran", g1);
                                filteredTable.Rows[0].SetField("Earth and Life Science", g2);
                                filteredTable.Rows[0].SetField("Media and Information Literacy", g3);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g4);
                                filteredTable.Rows[0].SetField("English for Academic and Professional Purposes", g5);
                                filteredTable.Rows[0].SetField("Practical Research 2", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("12") && sem.Equals("2"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7 + g8;

                                double average = Math.Round(finalGrade / 8, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Contemporary Philippine Arts from the Regions", g1);
                                filteredTable.Rows[0].SetField("Physical Science", g2);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g3);
                                filteredTable.Rows[0].SetField("Filipino sa Piling Larang", g4);
                                filteredTable.Rows[0].SetField("Empowerment Technologies", g5);
                                filteredTable.Rows[0].SetField("Inquiries, Investigations and Immersion", g6);
                                filteredTable.Rows[0].SetField("Entrepreneurship", g7);
                                filteredTable.Rows[0].SetField("TVE", g8);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                        }
                    }

                    grading_summary_dtg.DataSource = filteredTable;

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Oral Communication";
                        grading_summary_dtg.Columns[3].HeaderText = "Komunikasyon at Pananaliksik";
                        grading_summary_dtg.Columns[4].HeaderText = "21st Century Literature";
                        grading_summary_dtg.Columns[5].HeaderText = "General Mathematics";
                        grading_summary_dtg.Columns[6].HeaderText = "Introduction to the Philosophy";
                        grading_summary_dtg.Columns[7].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Reading and Writing";
                        grading_summary_dtg.Columns[3].HeaderText = "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik";
                        grading_summary_dtg.Columns[4].HeaderText = "Understanding Culture, Society and Politics";
                        grading_summary_dtg.Columns[5].HeaderText = "Statistics and Probability";
                        grading_summary_dtg.Columns[6].HeaderText = "Physical Education and Healthy";
                        grading_summary_dtg.Columns[7].HeaderText = "Practical Research 1";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Personal Development/Pansariling Kaunlaran";
                        grading_summary_dtg.Columns[3].HeaderText = "Earth and Life Science";
                        grading_summary_dtg.Columns[4].HeaderText = "Media and Information Literacy";
                        grading_summary_dtg.Columns[5].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[6].HeaderText = "English for Academic and Professional Purposes";
                        grading_summary_dtg.Columns[7].HeaderText = "Practical Research 2";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Contemporary Philippine Arts from the Regions";
                        grading_summary_dtg.Columns[3].HeaderText = "Physical Science";
                        grading_summary_dtg.Columns[4].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[5].HeaderText = "Filipino sa Piling Larang";
                        grading_summary_dtg.Columns[6].HeaderText = "Empowerment Technologies";
                        grading_summary_dtg.Columns[7].HeaderText = "Inquiries, Investigations and Immersion";
                        grading_summary_dtg.Columns[8].HeaderText = "Entrepreneurship";
                        grading_summary_dtg.Columns[9].HeaderText = "TVE";
                        grading_summary_dtg.Columns[10].HeaderText = "Average";
                    }

                    // Set the column widths
                    grading_summary_dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    grading_summary_dtg.Columns[0].Visible = false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task loadData(string term, string sem, string grade_level)
        {
            grading_summary_dtg.DataSource = null;
            grading_summary_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    int gradeLvl = int.Parse(grade_level);
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", this.my_id).WhereEqualTo("grade_level", gradeLvl);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        foreach (string columnName in StudentGradingSummary.g11_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        foreach (string columnName in StudentGradingSummary.g11_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        foreach (string columnName in StudentGradingSummary.g12_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        foreach (string columnName in StudentGradingSummary.g12_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }

                    bool isDataFound = false;

                    foreach (DocumentSnapshot snapshot in qSnap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                            // Access the "grade" subcollection for the current student
                            CollectionReference gradeRef = snapshot.Reference.Collection("Grades");

                            Query gradeQ = gradeRef.WhereEqualTo("sem", sem);

                            QuerySnapshot gradeSnap = await gradeQ.GetSnapshotAsync();

                            double g1 = 0, g2 = 0, g3 = 0, g4 = 0,
                                g5 = 0, g6 = 0, g7 = 0, g8 = 0, grades = 0;

                            int currentProgress = 0;
                            int totalGrade = gradeSnap.Documents.Count;

                            string majSub = "";

                            foreach (DocumentSnapshot gradeDoc in gradeSnap.Documents)
                            {
                                if (gradeDoc.Exists)
                                {
                                    // Access and use data from the "grade" document
                                    // Example:
                                    Students grade = gradeDoc.ConvertTo<Students>();

                                    if (term.Equals("Mid Term"))
                                    {
                                        grades = (double)grade.mid_term_grade;
                                    }
                                    else if (term.Equals("Final Term"))
                                    {
                                        grades = (double)grade.final_term_grade;
                                    }

                                    majSub = grade.subject;

                                    if (grade_level.Equals("11") && sem.Equals("1"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Oral Communication":
                                                g1 += grades;
                                                break;
                                            case "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino":
                                                g2 += grades;
                                                break;
                                            case "21st Century Literature from the Philippines and the World":
                                                g3 += grades;
                                                break;
                                            case "General Mathematics":
                                                g4 += grades;
                                                break;
                                            case "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao":
                                                g5 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("11") && sem.Equals("2"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Reading and Writing":
                                                g1 += grades;
                                                break;
                                            case "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik":
                                                g2 += grades;
                                                break;
                                            case "Understanding Culture, Society and Politics":
                                                g3 += grades;
                                                break;
                                            case "Statistics and Probability":
                                                g4 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g5 += grades;
                                                break;
                                            case "Practical Research 1":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("12") && sem.Equals("1"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Personal Development/Pansariling Kaunlaran":
                                                g1 += grades;
                                                break;
                                            case "Earth and Life Science":
                                                g2 += grades;
                                                break;
                                            case "Media and Information Literacy":
                                                g3 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g4 += grades;
                                                break;
                                            case "English for Academic and Professional Purposes":
                                                g5 += grades;
                                                break;
                                            case "Practical Research 2":
                                                g6 += grades;
                                                break;
                                            case "TVE":
                                            case "Animal Production NCII":
                                            case "Food Fish Processing NCII":
                                            case "Illustration NCII":
                                            case "Computer Systems Servicing NCII":
                                            case "Agricultural Crops Production NC II":
                                            case "Tailoring NCII":
                                            case "Electrical Installation & Maintenance NCII":
                                                g7 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }
                                    if (grade_level.Equals("12") && sem.Equals("2"))
                                    {
                                        // Accumulate grades for each subject
                                        switch (grade.subject)
                                        {
                                            case "Contemporary Philippine Arts from the Regions":
                                                g1 += grades;
                                                break;
                                            case "Physical Science":
                                                g2 += grades;
                                                break;
                                            case "Physical Education and Health":
                                                g3 += grades;
                                                break;
                                            case "Filipino sa Piling Larang":
                                                g4 += grades;
                                                break;
                                            case "Empowerment Technologies":
                                                g5 += grades;
                                                break;
                                            case "Inquiries, Investigations and Immersion":
                                                g6 += grades;
                                                break;
                                            case "Entrepreneurship":
                                                g7 += grades;
                                                break;
                                            case "Work Immersion":
                                                g8 += grades;
                                                break;
                                                // Add more cases for other subjects if needed
                                        }
                                    }

                                    isDataFound = true;
                                }
                                else
                                {
                                    isDataFound = false;
                                    // Handle the case where there is no data in the "grade" subcollection
                                }
                            }

                            string major = "";
                            switch (majSub)
                            {
                                case "Electrical Installation & Maintenance NCII":
                                    major = "Electrical Installation & Maintenance NCII";
                                    break;
                                case "Animal Production NCII":
                                    major = "Animal Production NCII";
                                    break;
                                case "Food Fish Processing NCII":
                                    major = "Food Fish Processing NCII";
                                    break;
                                case "Illustration NCII":
                                    major = "Illustration NCII";
                                    break;
                                case "Computer Systems Servicing NCII":
                                    major = "Computer Systems Servicing NCII";
                                    break;
                                case "Agricultural Crops Production NC II":
                                    major = "Agricultural Crops Production NC II";
                                    break;
                                case "Tailoring NCII":
                                    major = "Tailoring NCII";
                                    break;
                                case "Work Immersion":
                                    major = "Work Immersion";
                                    break;
                                default:
                                    major = "TVE";
                                    break;
                            }

                            if (grade_level.Equals("11") && sem.Equals("1"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Oral Communication", g1);
                                filteredTable.Rows[0].SetField("Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino", g2);
                                filteredTable.Rows[0].SetField("21st Century Literature from the Philippines and the World", g3);
                                filteredTable.Rows[0].SetField("General Mathematics", g4);
                                filteredTable.Rows[0].SetField("Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao", g5);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("11") && sem.Equals("2"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Reading and Writing", g1);
                                filteredTable.Rows[0].SetField("Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik", g2);
                                filteredTable.Rows[0].SetField("Understanding Culture, Society and Politics", g3);
                                filteredTable.Rows[0].SetField("Statistics and Probability", g4);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g5);
                                filteredTable.Rows[0].SetField("Practical Research 1", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("12") && sem.Equals("1"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7;

                                double average = Math.Round(finalGrade / 7, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Personal Development/Pansariling Kaunlaran", g1);
                                filteredTable.Rows[0].SetField("Earth and Life Science", g2);
                                filteredTable.Rows[0].SetField("Media and Information Literacy", g3);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g4);
                                filteredTable.Rows[0].SetField("English for Academic and Professional Purposes", g5);
                                filteredTable.Rows[0].SetField("Practical Research 2", g6);
                                filteredTable.Rows[0].SetField("TVE", g7);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                            else if (grade_level.Equals("12") && sem.Equals("2"))
                            {
                                double finalGrade = g1 + g2 + g3
                                + g4 + g5 + g6 + g7 + g8;

                                double average = Math.Round(finalGrade / 8, 2);

                                string remarks = "";

                                if (average <= 74)
                                {
                                    remarks = "Failed";
                                }
                                if (average >= 75)
                                {
                                    remarks = "Passed";
                                }

                                filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                                filteredTable.Rows[0].SetField("ID", students.id);
                                filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                                filteredTable.Rows[0].SetField("Contemporary Philippine Arts from the Regions", g1);
                                filteredTable.Rows[0].SetField("Physical Science", g2);
                                filteredTable.Rows[0].SetField("Physical Education and Health", g3);
                                filteredTable.Rows[0].SetField("Filipino sa Piling Larang", g4);
                                filteredTable.Rows[0].SetField("Empowerment Technologies", g5);
                                filteredTable.Rows[0].SetField("Inquiries, Investigations and Immersion", g6);
                                filteredTable.Rows[0].SetField("Entrepreneurship", g7);
                                filteredTable.Rows[0].SetField("TVE", g8);
                                filteredTable.Rows[0].SetField("Average", average);
                                filteredTable.Rows[0].SetField("Remarks", remarks);
                            }
                        }
                    }

                    grading_summary_dtg.DataSource = filteredTable;

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Oral Communication";
                        grading_summary_dtg.Columns[3].HeaderText = "Komunikasyon at Pananaliksik";
                        grading_summary_dtg.Columns[4].HeaderText = "21st Century Literature";
                        grading_summary_dtg.Columns[5].HeaderText = "General Mathematics";
                        grading_summary_dtg.Columns[6].HeaderText = "Introduction to the Philosophy";
                        grading_summary_dtg.Columns[7].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Reading and Writing";
                        grading_summary_dtg.Columns[3].HeaderText = "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik";
                        grading_summary_dtg.Columns[4].HeaderText = "Understanding Culture, Society and Politics";
                        grading_summary_dtg.Columns[5].HeaderText = "Statistics and Probability";
                        grading_summary_dtg.Columns[6].HeaderText = "Physical Education and Healthy";
                        grading_summary_dtg.Columns[7].HeaderText = "Practical Research 1";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Personal Development/Pansariling Kaunlaran";
                        grading_summary_dtg.Columns[3].HeaderText = "Earth and Life Science";
                        grading_summary_dtg.Columns[4].HeaderText = "Media and Information Literacy";
                        grading_summary_dtg.Columns[5].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[6].HeaderText = "English for Academic and Professional Purposes";
                        grading_summary_dtg.Columns[7].HeaderText = "Practical Research 2";
                        grading_summary_dtg.Columns[8].HeaderText = "TVE";
                        grading_summary_dtg.Columns[9].HeaderText = "Average";
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        // Set the column headers
                        grading_summary_dtg.Columns[0].HeaderText = "ID";
                        grading_summary_dtg.Columns[1].HeaderText = "Name";
                        grading_summary_dtg.Columns[2].HeaderText = "Contemporary Philippine Arts from the Regions";
                        grading_summary_dtg.Columns[3].HeaderText = "Physical Science";
                        grading_summary_dtg.Columns[4].HeaderText = "Physical Education and Health";
                        grading_summary_dtg.Columns[5].HeaderText = "Filipino sa Piling Larang";
                        grading_summary_dtg.Columns[6].HeaderText = "Empowerment Technologies";
                        grading_summary_dtg.Columns[7].HeaderText = "Inquiries, Investigations and Immersion";
                        grading_summary_dtg.Columns[8].HeaderText = "Entrepreneurship";
                        grading_summary_dtg.Columns[9].HeaderText = "TVE";
                        grading_summary_dtg.Columns[10].HeaderText = "Average";
                    }

                    // Set the column widths
                    grading_summary_dtg.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    grading_summary_dtg.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                    grading_summary_dtg.Columns[0].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintCard(this.print_panel);
        }

        private void PrintCard(Panel card_panel)
        {
            PrinterSettings ps = new PrinterSettings();
            this.print_panel = card_panel;
            getPrinterArea(card_panel);
            printPrevDialog.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_printpage);
            printPrevDialog.ShowDialog();
        }

        public void printDoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle printArea = e.MarginBounds;

            // Calculate the aspect ratio of the panel content
            float aspectRatio = (float)this.print_panel.Width / this.print_panel.Height;

            // Calculate the width and height to fit the content within the printable area
            int width = printArea.Width;
            int height = (int)(width / aspectRatio);

            // If the calculated height exceeds the printable height, adjust the height and width
            if (height > printArea.Height)
            {
                height = printArea.Height;
                width = (int)(height * aspectRatio);
            }

            // Calculate the position to center the scaled content horizontally and vertically
            int x = printArea.Left + (printArea.Width - width) / 2;
            int y = printArea.Top;

            // Draw the scaled image
            e.Graphics.DrawImage(bitmap, x, y, width, height);
        }

        private void getPrinterArea(Panel card_panel)
        {
            bitmap = new Bitmap(card_panel.Width, card_panel.Height);
            card_panel.DrawToBitmap(bitmap, new Rectangle(0, 0, card_panel.Width, card_panel.Height));
        }

        private void download_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document (*.docx)|*.docx";
            saveFileDialog1.Title = "Save Word Document";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                // Create a new Word application
                Word.Application wordApp = new Word.Application();
                wordApp.Visible = false;
                wordApp.WindowState = Word.WdWindowState.wdWindowStateNormal;

                // Create a new document
                Word.Document doc = wordApp.Documents.Add();

                // Capture the content of the panel as an image
                Bitmap panelContentImage = CapturePanelContent(print_panel);

                // Insert the captured image into the Word document
                InsertImageIntoWordDocument(doc, panelContentImage);

                // Save the document
                doc.SaveAs2(saveFileDialog1.FileName);

                // Close the document and Word application
                doc.Close();
                wordApp.Quit();

                MessageBox.Show("Document saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private Bitmap CapturePanelContent(Panel panel)
        {
            // Create a bitmap to hold the image of the panel content
            Bitmap panelImage = new Bitmap(panel.Width, panel.Height);

            // Draw the panel content onto the bitmap
            panel.DrawToBitmap(panelImage, new Rectangle(0, 0, panel.Width, panel.Height));

            return panelImage;
        }

        private void InsertImageIntoWordDocument(Word.Document doc, Bitmap image)
        {
            // Save the image to a temporary file
            string tempImagePath = Path.GetTempFileName();
            image.Save(tempImagePath);

            // Insert the image into the Word document
            doc.InlineShapes.AddPicture(tempImagePath);

            // Delete the temporary file
            File.Delete(tempImagePath);
        }

        private async void SummaryPrintPreview_Load(object sender, EventArgs e)
        {
            if(!StudentGradingSummary.studentSection.Equals("Any"))
            {
                await getSummaryGradeBySection(this.term, this.sem, this.grade_level, StudentGradingSummary.studentSection);
            }
            else
            {
                await loadData(this.term, this.sem, this.grade_level);
            }
        }
    }
}
