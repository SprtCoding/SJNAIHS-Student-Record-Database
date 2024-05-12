using Google.Cloud.Firestore;
using Student_Record.Firebase.Model;
using Student_Record.Firebase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student_Record.TeachersModule.GeneratedCard;
using Student_Record.TeachersModule.Records;

namespace Student_Record.TeachersModule
{
    public partial class StudentRecordPage : Form
    {
        private string? faculty_id;
        int pageSize = 10; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number

        public StudentRecordPage(string? faculty_id)
        {
            InitializeComponent();
            this.faculty_id = faculty_id;

            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";
        }

        // Method to handle loading data for the next page
        async void LoadNextPage()
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            currentPage++; // Increment the current page number
            await getStudent(currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to handle loading data for the previous page
        async void LoadPreviousPage()
        {
            no_data_panel.Visible = true;
            no_data_pb.Visible = false;
            loadingLbl.Text = "loading data...";

            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getStudent(currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabel();
                UpdatePaginationButtons();
            }
        }

        // Method to initialize or reload data for the first page
        public async Task LoadFirstPage()
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudent(currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabel();
            UpdatePaginationButtons();
        }

        // Method to update the pagination buttons (previous and next)
        async void UpdatePaginationButtons()
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int totalCount = await getStudentsCount();

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < totalCount;
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int totalCount = await getStudentsCount();
            data_count_lbl.Text = "Page " + currentPage + ", Total Students: " + totalCount; // Assuming pageNumberLabel is the label displaying the page number
        }

        private async Task<int> getStudentsCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                QuerySnapshot studentQSnap = await studentColRef
                    .WhereEqualTo("faculty_id", faculty_id)
                    .GetSnapshotAsync();

                studentCount = studentQSnap.Documents.Count;
            }

            return studentCount;
        }

        private async Task getStudent(int pageNumber, int pageSize)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    // Calculate the offset based on the page number and page size
                    int offset = (pageNumber - 1) * pageSize;

                    Query q = colRef
                        .WhereEqualTo("faculty_id", faculty_id)
                        .OrderBy("addedOn")
                        .Offset(offset)
                        .Limit(pageSize);

                    QuerySnapshot qSnap = await q.GetSnapshotAsync();

                    if (qSnap.Count > 0)
                    {
                        no_data_panel.Visible = false;
                        student_dtg.Visible = true;

                        // Add columns to the DataGridView if they are not already added
                        if (student_dtg.Columns.Count == 0)
                        {
                            student_dtg.Columns.Add("ID", "ID");
                            student_dtg.Columns.Add("Name", "Name");
                            student_dtg.Columns.Add("grade_level", "Grade Level");
                            student_dtg.Columns.Add("section", "Section");
                            student_dtg.Columns.Add("gender", "Gender");
                        }

                        foreach (DocumentSnapshot docSnap in qSnap.Documents)
                        {
                            Students student = docSnap.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(student.last_name[0]) + student.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(student.first_name[0]) + student.first_name.Substring(1);

                            string fullname = capitalizedLastName + ", " + capitalizedFirstName + " " + student.middle_name.Substring(0, 1).ToUpper() + ".";

                            if (student.hasGrade == true)
                            {
                                student_dtg.Rows.Insert(
                                    0,
                                    student.id,
                                    fullname,
                                    student.grade_level,
                                    student.section,
                                    student.gender,
                                    Properties.Resources.add
                                );
                            }
                            else
                            {
                                student_dtg.Rows.Insert(
                                    0,
                                    student.id,
                                    fullname,
                                    student.grade_level,
                                    student.section,
                                    student.gender,
                                    Properties.Resources.ex_mark
                                );
                            }

                            student_dtg.CellFormatting += (sender, e) =>
                            {
                                if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];

                                    cell.ToolTipText = "Generate Card";
                                }
                            };

                            // Add the CellMouseEnter event to change the cursor to a hand cursor
                            student_dtg.CellMouseEnter += (sender, e) =>
                            {
                                if (e.ColumnIndex == 5 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                                {
                                    student_dtg.Cursor = Cursors.Hand;
                                }
                            };

                            // Add the CellMouseLeave event to revert the cursor to the default cursor
                            student_dtg.CellMouseLeave += (sender, e) =>
                            {
                                student_dtg.Cursor = Cursors.Default;
                            };
                        }

                        no_data_panel.Visible = false;
                        student_dtg.Visible = true;
                    }
                    else
                    {
                        no_data_panel.Visible = true;
                        loadingLbl.Text = "No data found!";
                        no_data_pb.Visible = true;
                        student_dtg.Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void student_dtg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = student_dtg.Rows[e.RowIndex];
                string? id = selectedRow.Cells["id"].Value.ToString();

                RecordsDetails records = new RecordsDetails(id, faculty_id, "faculty");
                records.ShowDialog();
            }
        }

        private void search_tb_OnValueChanged(object sender, EventArgs e)
        {
            string searchText = search_tb.Text.ToLower();

            foreach (DataGridViewRow row in student_dtg.Rows)
            {
                // If the row contains the search text, make it visible; otherwise, hide it
                row.Visible = row.Cells.Cast<DataGridViewCell>()
                                       .Any(cell => cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText));
            }
        }

        private async void StudentRecordPage_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadFirstPage();
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
