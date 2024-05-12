using Google.Cloud.Firestore;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.AdminModule.Student
{
    public partial class StudentListFrm : Form
    {
        private string faculty_id, faculty_name;
        int pageSize = 5; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number

        public StudentListFrm(string faculty_id, string faculty_name)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;
            this.faculty_name = faculty_name;
        }

        private async Task<int> getStudentCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                Query studentQuery = studentColRef.WhereEqualTo("faculty_id", this.faculty_id);

                QuerySnapshot studentQSnap = await studentQuery.GetSnapshotAsync();

                studentCount = studentQSnap.Count;
            }

            return studentCount;
        }

        // Method to handle loading data for the next page
        async void LoadNextPage()
        {
            currentPage++; // Increment the current page number
            await getStudents(currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to handle loading data for the previous page
        async void LoadPreviousPage()
        {
            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getStudents(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudents(currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        private async void StudentListFrm_Load(object sender, EventArgs e)
        {
            faculty_name_lbl.Text = "Student List of " + this.faculty_name + ".";
            await LoadFirstPage();
        }

        private string CapitalizeEachWord(string input)
        {
            // Split the input into words
            string[] words = input.Split(' ');

            // Capitalize the first letter of each word
            for (int i = 0; i < words.Length; i++)
            {
                // Ensure the word is not empty before capitalizing
                if (!string.IsNullOrEmpty(words[i]))
                {
                    words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower(); // Capitalize first letter and convert the rest to lowercase
                }
            }

            // Join the words back into a single string
            return string.Join(" ", words);
        }

        private async Task getStudents(int pageNumber, int pageSize)
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                int offset = (pageNumber - 1) * pageSize;

                Query studentQuery = studentColRef.WhereEqualTo("faculty_id", this.faculty_id)
                                                   .OrderBy("addedOn")  // Assuming you want to order by id
                                                   .Offset(offset)
                                                   .Limit(pageSize);

                QuerySnapshot studentQSnap = await studentQuery.GetSnapshotAsync();

                // Clear existing rows from DataGridView
                student_dtg.Rows.Clear();

                // Add columns to the DataGridView if they are not already added
                if (student_dtg.Columns.Count == 0)
                {
                    student_dtg.Columns.Add("id", "ID");
                    student_dtg.Columns.Add("lrn", "Lrn Number");
                    student_dtg.Columns.Add("name", "Student Name");
                    student_dtg.Columns.Add("grade_sec", "Grade/Section");
                    student_dtg.Columns.Add("strand", "Strand");
                    student_dtg.Columns.Add("gender", "Gender");
                    student_dtg.Columns.Add("adviser", "Adviser");
                }

                // Add rows to the DataGridView
                foreach (DocumentSnapshot docSnap in studentQSnap.Documents)
                {
                    if (docSnap.Exists)
                    {
                        Students student = docSnap.ConvertTo<Students>();

                        student_dtg.Rows.Add(
                            student.id,
                            student.lrn_number,
                            CapitalizeEachWord(student.last_name) + ", " + CapitalizeEachWord(student.first_name) + " " + student.middle_name.Substring(0, 1).ToUpper() + ".",
                            student.grade_level + "-" + student.section,
                            student.strand,
                            student.gender,
                            student.adviser
                        );
                    }
                }
            }
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int studentsCount = await getStudentCount();
            data_count_lbl.Text = "Page " + currentPage + " out of " + studentsCount; // Assuming pageNumberLabel is the label displaying the page number
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in student_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
            }
        }

        // Method to update the pagination buttons (previous and next)
        async void UpdatePaginationButtons()
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int studentsCount = await getStudentCount();

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < studentsCount;
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            LoadNextPage();
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            LoadPreviousPage();
        }
    }
}
