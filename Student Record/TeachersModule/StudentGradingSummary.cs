using Student_Record.DataSets.StudentGradeDataSetTableAdapters;
using Student_Record.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Record.DataSets.StudentDataSetTableAdapters;
using Student_Record.Firebase;
using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Bunifu.Framework.UI;
using Student_Record.TeachersModule.ReportSubmit;
using Student_Record.TeachersModule.GradingSheetPrint;
using static Google.Cloud.Firestore.V1.StructuredAggregationQuery.Types.Aggregation.Types;
using Student_Record.Loaders;
using Microsoft.Office.Interop.Word;
using System.Globalization;
using DataTable = System.Data.DataTable;
using Task = System.Threading.Tasks.Task;

namespace Student_Record.TeachersModule
{
    public partial class StudentGradingSummary : Form
    {
        string? faculty_id, faculty_name;
        private BunifuFlatButton? currentBtn;
        private Color activeColor = Color.FromArgb(129, 142, 254);
        private Color originalColor = Color.FromArgb(43, 47, 84);
        int progressPercentage;

        public static string studentSection = "";

        public static string[] g11_1st_subject = new string[] {
                "ID",
                "Name",
                "Oral Communication",
                "Komunikasyon at Pananaliksik sa Wika at Kulturang Pilipino",
                "21st Century Literature from the Philippines and the World",
                "General Mathematics",
                "Introduction to the Philosophy of the Human Person/Pambungad sa Pilosopiya ng Tao",
                "Physical Education and Health",
                "TVE",
                "Average",
                "Remarks"
        };

        public static string[] g11_2nd_subject = new string[] {
                "ID",
                "Name",
                "Reading and Writing",
                "Pagbasa at Pagsusuri ng Ibat ibang teksto tungo sa pananaliksik",
                "Understanding Culture, Society and Politics",
                "Statistics and Probability",
                "Physical Education and Health",
                "Practical Research 1",
                "TVE",
                "Average",
                "Remarks"
        };

        public static string[] g12_1st_subject = new string[] {
                "ID",
                "Name",
                "Personal Development/Pansariling Kaunlaran",
                "Earth and Life Science",
                "Media and Information Literacy",
                "Physical Education and Health",
                "English for Academic and Professional Purposes",
                "Practical Research 2",
                "TVE",
                "Average",
                "Remarks"
        };

        public static string[] g12_2nd_subject = new string[] {
                "ID",
                "Name",
                "Contemporary Philippine Arts from the Regions",
                "Physical Science",
                "Physical Education and Health",
                "Filipino sa Piling Larang",
                "Empowerment Technologies",
                "Inquiries, Investigations and Immersion",
                "Entrepreneurship",
                "TVE",
                "Average",
                "Remarks"
        };

        public static string[] section_of_11 = new string[] {
            "Any",
            "Canary",
            "Flamingo",
            "Falcon",
            "Skylark",
            "Pelican"
        };

        public static string[] section_of_12 = new string[] {
            "Any",
            "Apollo",
            "Artemis",
            "Athena",
            "Kairos",
            "Sol Invictus"
        };

        public StudentGradingSummary(string? id, string? name)
        {
            InitializeComponent();
            this.faculty_id = id;
            this.faculty_name = name;
            activeButton(mid_grade_filter);
            IsButtonActive(mid_grade_filter);

            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";
        }

        private void activeButton(BunifuFlatButton btn)
        {
            if (currentBtn != null)
            {
                currentBtn.Normalcolor = originalColor;
            }
            currentBtn = btn;

            currentBtn.Normalcolor = activeColor;
        }

        // Method to check if a button is active
        private bool IsButtonActive(BunifuFlatButton btn)
        {
            return currentBtn == btn;
        }

        // Method to get the text of the active button
        public string GetActiveButtonText()
        {
            if (currentBtn != null)
            {
                return currentBtn.Text;
            }
            else
            {
                // Return null or throw an exception based on your requirement
                throw new InvalidOperationException("No button is currently active.");
            }
        }

        void Wait()
        {
            for (int i = 0; i < progressPercentage; i++)
            {
                Thread.Sleep(5);
            }
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
                        .WhereEqualTo("faculty_id", faculty_id)
                        .WhereEqualTo("grade_level", gradeLvl)
                        .WhereEqualTo("section", section);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        foreach (string columnName in g11_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        foreach (string columnName in g11_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        foreach (string columnName in g12_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        foreach (string columnName in g12_2nd_subject)
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

                            studentSection = students.section;

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
                                // Calculate progress
                                currentProgress++;
                                progressPercentage = (int)((double)currentProgress / totalGrade * 100);

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

                    if (!isDataFound)
                    {
                        no_data_panel.Visible = true;
                        loadingLbl.Text = "No data found!";
                        no_data_pb.Visible = true;
                        grading_summary_dtg.Visible = false;
                    }
                    else
                    {
                        no_data_panel.Visible = false;
                        grading_summary_dtg.Visible = true;
                    }
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

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("grade_level", gradeLvl);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    // Create a new DataTable with only the desired columns
                    DataTable filteredTable = new DataTable();

                    if (grade_level.Equals("11") && sem.Equals("1"))
                    {
                        foreach (string columnName in g11_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("11") && sem.Equals("2"))
                    {
                        foreach (string columnName in g11_2nd_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("1"))
                    {
                        foreach (string columnName in g12_1st_subject)
                        {
                            filteredTable.Columns.Add(columnName);
                        }
                    }
                    else if (grade_level.Equals("12") && sem.Equals("2"))
                    {
                        foreach (string columnName in g12_2nd_subject)
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
                                // Calculate progress
                                currentProgress++;
                                progressPercentage = (int)((double)currentProgress / totalGrade * 100);

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

                    if (!isDataFound)
                    {
                        no_data_panel.Visible = true;
                        loadingLbl.Text = "No data found!";
                        no_data_pb.Visible = true;
                        grading_summary_dtg.Visible = false;
                    }
                    else
                    {
                        no_data_panel.Visible = false;
                        grading_summary_dtg.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void mid_grade_filter_Click(object sender, EventArgs e)
        {
            string gradeLevel = grade_level_cbx.Text;

            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            string sem = sem_cbx.Text;
            if (!String.IsNullOrEmpty(sem))
            {
                await loadData(mid_grade_filter.Text, sem, gradeLevel);
                activeButton(mid_grade_filter);
                IsButtonActive(mid_grade_filter);
            }
        }

        private async void final_term_grade_filter_Click(object sender, EventArgs e)
        {
            string gradeLevel = grade_level_cbx.Text;

            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            string sem = sem_cbx.Text;
            if (!String.IsNullOrEmpty(sem))
            {
                await loadData(final_term_grade_filter.Text, sem, gradeLevel);
                activeButton(final_term_grade_filter);
                IsButtonActive(final_term_grade_filter);
            }
        }

        private async void sem_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            string grade_level = grade_level_cbx.Text;

            string sem = sem_cbx.Text;
            if (IsButtonActive(final_term_grade_filter))
            {
                await loadData(final_term_grade_filter.Text, sem, grade_level);
            }
            if (IsButtonActive(mid_grade_filter))
            {
                await loadData(mid_grade_filter.Text, sem, grade_level);
            }
        }

        private void printGradeBtn_Click(object sender, EventArgs e)
        {
            string filter = GetActiveButtonText(), sem = sem_cbx.Text, grade_level = grade_level_cbx.Text;

            if (faculty_id != null && !String.IsNullOrEmpty(sem_cbx.Text) && !String.IsNullOrEmpty(grade_level_cbx.Text))
            {
                SummaryPrintPreview printPrev = new SummaryPrintPreview(faculty_id, filter, sem, grade_level);
                printPrev.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select semester to continue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void submitReportBtn_Click(object sender, EventArgs e)
        {
            SelectReportOption report = new SelectReportOption(faculty_id, faculty_name);
            report.ShowDialog();
        }

        private void printGradeBtn_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(printGradeBtn, "Print");
        }

        private void submitReportBtn_MouseEnter_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(submitReportBtn, "Submit Report");
        }

        private async void grade_level_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string grade_level = grade_level_cbx.SelectedItem.ToString();

            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            sem_cbx.SelectedIndex = 0;

            section_cbx.Items.Clear();

            if (grade_level.Equals("11"))
            {
                section_cbx.Items.AddRange(section_of_11);
                section_cbx.SelectedIndex = 0;
            }
            else if (grade_level.Equals("12"))
            {
                section_cbx.Items.AddRange(section_of_12);
                section_cbx.SelectedIndex = 0;
            }
        }

        private async void section_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            string grade_level = grade_level_cbx.SelectedItem.ToString();
            string selectedSection = section_cbx.SelectedItem.ToString();
            string sem = sem_cbx.Text;

            if (!selectedSection.Equals("Any"))
            {
                if (IsButtonActive(final_term_grade_filter))
                {
                    await getSummaryGradeBySection(final_term_grade_filter.Text, sem, grade_level, selectedSection);
                }
                if (IsButtonActive(mid_grade_filter))
                {
                    await getSummaryGradeBySection(mid_grade_filter.Text, sem, grade_level, selectedSection);
                }
            }
            else
            {
                studentSection = selectedSection;

                if (IsButtonActive(final_term_grade_filter))
                {
                    await loadData(final_term_grade_filter.Text, sem, grade_level);
                }
                if (IsButtonActive(mid_grade_filter))
                {
                    await loadData(mid_grade_filter.Text, sem, grade_level);
                }
            }
        }

        private void StudentGradingSummary_Load(object sender, EventArgs e)
        {
            grade_level_cbx.SelectedIndex = 0;
        }
    }
}
