using Google.Cloud.Firestore;
using Microsoft.VisualBasic.ApplicationServices;
using Student_Record.AdminModule.AddForm;
using Student_Record.AdminModule.Student;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Loaders;
using Student_Record.TeachersModule.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Cloud.Firestore.V1.StructuredQuery.Types;

namespace Student_Record.AdminModule
{
    public partial class StudentProfiles : Form
    {
        int pageSize = 5; // Number of records per page
        int currentPage = 1, studentCount = 0; // Current page number
        string genderLbl = "";

        public StudentProfiles()
        {
            InitializeComponent();
            filter_type_cbx.SelectedIndex = 0;

            loadingTxt.Text = "loading students...";
        }

        private async Task<int> getStudentCount()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                QuerySnapshot studentQSnap = await studentColRef.GetSnapshotAsync();

                studentCount = studentQSnap.Count;
            }

            return studentCount;
        }

        private async Task<int> getStudentCountByFilter(string filter)
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                if(filter.Equals("11") || filter.Equals("12"))
                {
                    int grade = int.Parse(filter);

                    QuerySnapshot studentQSnap = await studentColRef
                        .WhereEqualTo("grade_level", grade)
                        .GetSnapshotAsync();

                    studentCount = studentQSnap.Count;
                }
                else
                {
                    QuerySnapshot studentQSnap = await studentColRef
                        .WhereEqualTo("section", filter)
                        .GetSnapshotAsync();

                    studentCount = studentQSnap.Count;
                }
            }

            return studentCount;
        }

        private async Task<int> getStudentCountByGender(string gender)
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                CollectionReference studentColRef = db.Collection("students");

                QuerySnapshot studentQSnap = await studentColRef
                        .WhereEqualTo("gender", gender)
                        .GetSnapshotAsync();

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

        async void LoadNextPageGender(string gender)
        {
            currentPage++; // Increment the current page number
            await getStudentByGender(gender, currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabelByGender(gender);
            UpdatePaginationButtonsGender(gender);
        }

        async void LoadNextPageFilter(string filter)
        {
            currentPage++; // Increment the current page number
            await getStudentFilter(filter, currentPage, pageSize); // Load data for the next page
            UpdatePageNumberLabelFilter(filter);
            UpdatePaginationButtonsFilter(filter);
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

        async void LoadPreviousPageGender(string gender)
        {
            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getStudentByGender(gender, currentPage, pageSize); // Load data for the previous page
                UpdatePageNumberLabelByGender(gender);
                UpdatePaginationButtonsGender(gender);
            }
        }

        async void LoadPreviousPageFilter(string filter)
        {
            if (currentPage > 1)
            {
                currentPage--; // Decrement the current page number
                await getStudentFilter(filter, currentPage, pageSize); // Load data for the next page
                UpdatePageNumberLabelFilter(filter);
                UpdatePaginationButtonsFilter(filter);
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

        async Task loadByGender(string gender)
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudentByGender(gender, currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabelByGender(gender);
            UpdatePaginationButtonsGender(gender);
        }

        async Task loadByFilter(string filter)
        {
            currentPage = 1; // Reset the current page number to the first page
            await getStudentFilter(filter, currentPage, pageSize); // Load data for the first page
            UpdatePageNumberLabelFilter(filter);
            UpdatePaginationButtonsFilter(filter);
        }

        // Method to update the page number label
        async void UpdatePageNumberLabel()
        {
            int studentsCount = await getStudentCount();
            data_count_lbl.Text = "Page " + currentPage + ", Total Student: " + studentsCount; // Assuming pageNumberLabel is the label displaying the page number
        }

        async void UpdatePageNumberLabelFilter(string filter)
        {
            int studentsCount = await getStudentCountByFilter(filter);
            data_count_lbl.Text = "Page " + currentPage + ", Total Student: " + studentsCount; // Assuming pageNumberLabel is the label displaying the page number
        } 

        async void UpdatePageNumberLabelByGender(string gender)
        {
            int studentsCount = await getStudentCountByGender(gender);
            data_count_lbl.Text = "Page " + currentPage + ", Total Student:  " + studentsCount; // Assuming pageNumberLabel is the label displaying the page number
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

        async void UpdatePaginationButtonsGender(string gender)
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int studentsCount = await getStudentCountByGender(gender);

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < studentsCount;
        }

        async void UpdatePaginationButtonsFilter(string filter)
        {
            // Hide previous button if it's the first page
            previous_btn.Visible = currentPage > 1;

            int studentsCount = await getStudentCountByFilter(filter);

            // Disable next button if there are no more pages
            next_btn.Enabled = (currentPage * pageSize) < studentsCount;
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        private async Task getFemaleCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("gender", "Female");

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int femaleCount = snapshot.Documents.Count;
                    female_count.Text = femaleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task getMaleCount()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("gender", "Male");

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int maleCount = snapshot.Documents.Count;
                    male_count.Text = maleCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task getStudents(int pageNumber, int pageSize)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                int offset = (pageNumber - 1) * pageSize;

                Query studentQuery = studentRef.OrderBy("addedOn")  // Assuming you want to order by id
                                                   .Offset(offset)
                                                   .Limit(pageSize);

                student_dtg.Rows.Clear();

                QuerySnapshot snap = await studentQuery.GetSnapshotAsync();

                bool isDataFound = false;

                // Add columns to the DataGridView if they are not already added
                if (student_dtg.Columns.Count == 0)
                {
                    student_dtg.Columns.Add("id", "ID");
                    student_dtg.Columns.Add("name", "Name");
                    student_dtg.Columns.Add("lrn", "Lrn Number");
                    student_dtg.Columns.Add("gender", "Gender");
                    student_dtg.Columns.Add("grade_level", "Grade Level");
                    student_dtg.Columns.Add("section", "Section");
                    student_dtg.Columns.Add("action", "Action");
                    student_dtg.Columns.Add("details", "details");
                }

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        student_dtg.Rows.Add(
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                students.lrn_number,
                                students.gender,
                                students.grade_level,
                                students.section,
                                Properties.Resources.test,
                                Properties.Resources.eye
                            );
                        isDataFound = true;

                    }
                    else
                    {
                        isDataFound = false;
                    }
                }

                // Add the CellFormatting event to set the tooltip for the Warning column
                student_dtg.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cell.ToolTipText = "View Grades";
                    }
                    if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cell.ToolTipText = "View Details";
                    }
                };
                // Add the CellMouseEnter event to change the cursor to a hand cursor
                student_dtg.CellMouseEnter += (sender, e) =>
                {
                    if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        student_dtg.Cursor = Cursors.Hand;
                    }
                    if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        student_dtg.Cursor = Cursors.Hand;
                    }
                };

                // Add the CellMouseLeave event to revert the cursor to the default cursor
                student_dtg.CellMouseLeave += (sender, e) =>
                {
                    student_dtg.Cursor = Cursors.Default;
                };

                if (!isDataFound)
                {
                    loadingPanel.Visible = true;
                    loadingTxt.Text = "No Student found!";
                }
                else
                {
                    loadingPanel.Visible = false;
                }
            }
        }

        private async void filter_type_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "Searching student...";

            if (String.IsNullOrEmpty(filter_type_cbx.Text))
            {
                filter_value_cbx.Enabled = false;
            }
            else
            {
                filter_value_cbx.Enabled = true;
                string filter = filter_type_cbx.Text;
                if (filter.Equals("Grade Level"))
                {
                    filter_value_cbx.Items.Clear();
                    filter_value_cbx.Items.AddRange(new string[] { "Any", "11", "12" });
                    filter_value_cbx.SelectedIndex = 0;
                }
                else if (filter.Equals("Section"))
                {
                    filter_value_cbx.Items.Clear();
                    filter_value_cbx.Items.AddRange(new string[] { "Any", "Canary", "Flamingo", "Falcon", "Skylark", "Pelican", "Apollo", "Artemis", "Athena", "Kairos", "Sol Invictus" });
                    filter_value_cbx.SelectedIndex = 0;
                }
                else if (filter.Equals("Any"))
                {
                    filter_value_cbx.Enabled = false;
                    await LoadFirstPage();
                }
            }
        }

        private void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = student_dtg.Rows[e.RowIndex];
                string id = selectedRow.Cells["id"].Value.ToString();
                if (student_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    Details details = new Details(id);
                    details.ShowDialog(this);
                }
                else if (student_dtg.Columns[e.ColumnIndex].Name == "details")
                {
                    RecordsDetails records = new RecordsDetails(id, "", "admin");
                    records.ShowDialog();
                }
            }
        }

        private async void male_panel_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "Searching student...";

            genderLbl = "Male";
            await loadByGender("Male");
        }

        private async Task getStudentFilter(string filter, int pageNumber, int pageSize)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                int offset = (pageNumber - 1) * pageSize;

                bool isDataFound = false;

                if (filter.Equals("Any"))
                {
                    await LoadFirstPage();
                }
                else if (filter.Equals("11") || filter.Equals("12"))
                {
                    int filterInt = int.Parse(filter);

                    Query q = studentRef
                        .WhereEqualTo("grade_level", filterInt)
                        .OrderBy("addedOn")  // Assuming you want to order by id
                        .Offset(offset)
                        .Limit(pageSize);

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    // Add columns to the DataGridView if they are not already added
                    if (student_dtg.Columns.Count == 0)
                    {
                        student_dtg.Columns.Add("id", "ID");
                        student_dtg.Columns.Add("name", "Name");
                        student_dtg.Columns.Add("lrn", "Lrn Number");
                        student_dtg.Columns.Add("gender", "Gender");
                        student_dtg.Columns.Add("grade_level", "Grade Level");
                        student_dtg.Columns.Add("section", "Section");
                        student_dtg.Columns.Add("action", "Action");
                        student_dtg.Columns.Add("details", "details");
                    }

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);


                            /*filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                            filteredTable.Rows[0].SetField("ID", students.id);
                            filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                            filteredTable.Rows[0].SetField("Lrn", students.lrn_number);
                            filteredTable.Rows[0].SetField("Gender", students.gender);
                            filteredTable.Rows[0].SetField("Grade Level", students.grade_level);
                            filteredTable.Rows[0].SetField("Section", students.section);
                            filteredTable.Rows[0].SetField("Action", Properties.Resources.test);
                            filteredTable.Rows[0].SetField("Details", Properties.Resources.eye);*/

                            student_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    students.lrn_number,
                                    students.gender,
                                    students.grade_level,
                                    students.section,
                                    Properties.Resources.test,
                                    Properties.Resources.eye
                                );
                            isDataFound = true;
                        }
                        else
                        {
                            isDataFound = false;
                        }
                    }

                    // Add the CellFormatting event to set the tooltip for the Warning column
                    student_dtg.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "View Grades";
                        }
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "View Details";
                        }
                    };
                    // Add the CellMouseEnter event to change the cursor to a hand cursor
                    student_dtg.CellMouseEnter += (sender, e) =>
                    {
                        if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            student_dtg.Cursor = Cursors.Hand;
                        }
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            student_dtg.Cursor = Cursors.Hand;
                        }
                    };

                    // Add the CellMouseLeave event to revert the cursor to the default cursor
                    student_dtg.CellMouseLeave += (sender, e) =>
                    {
                        student_dtg.Cursor = Cursors.Default;
                    };

                    if (!isDataFound)
                    {
                        loadingPanel.Visible = true;
                        loadingTxt.Text = "No Student found!";
                    }
                    else
                    {
                        loadingPanel.Visible = false;
                    }
                }
                else
                {
                    Query q = studentRef.WhereEqualTo("section", filter)
                        .OrderBy("addedOn")  // Assuming you want to order by id
                        .Offset(offset)
                        .Limit(pageSize);

                    QuerySnapshot snap = await q.GetSnapshotAsync();

                    // Add columns to the DataGridView if they are not already added
                    if (student_dtg.Columns.Count == 0)
                    {
                        student_dtg.Columns.Add("id", "ID");
                        student_dtg.Columns.Add("name", "Name");
                        student_dtg.Columns.Add("lrn", "Lrn Number");
                        student_dtg.Columns.Add("gender", "Gender");
                        student_dtg.Columns.Add("grade_level", "Grade Level");
                        student_dtg.Columns.Add("section", "Section");
                        student_dtg.Columns.Add("action", "Action");
                        student_dtg.Columns.Add("details", "details");
                    }

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students students = snapshot.ConvertTo<Students>();

                            // Capitalize the first letter of last_name
                            string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                            // Capitalize the first letter of last_name
                            string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);


                            /*filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                            filteredTable.Rows[0].SetField("ID", students.id);
                            filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                            filteredTable.Rows[0].SetField("Lrn", students.lrn_number);
                            filteredTable.Rows[0].SetField("Gender", students.gender);
                            filteredTable.Rows[0].SetField("Grade Level", students.grade_level);
                            filteredTable.Rows[0].SetField("Section", students.section);
                            filteredTable.Rows[0].SetField("Action", Properties.Resources.test);
                            filteredTable.Rows[0].SetField("Details", Properties.Resources.eye);*/

                            student_dtg.Rows.Insert(
                                    0,
                                    students.id,
                                    capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                    students.lrn_number,
                                    students.gender,
                                    students.grade_level,
                                    students.section,
                                    Properties.Resources.test,
                                    Properties.Resources.eye
                                );
                            isDataFound = true;
                        }
                        else
                        {
                            isDataFound = false;
                        }
                    }

                    // Add the CellFormatting event to set the tooltip for the Warning column
                    student_dtg.CellFormatting += (sender, e) =>
                    {
                        if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "View Grades";
                        }
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                            cell.ToolTipText = "View Details";
                        }
                    };
                    // Add the CellMouseEnter event to change the cursor to a hand cursor
                    student_dtg.CellMouseEnter += (sender, e) =>
                    {
                        if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            student_dtg.Cursor = Cursors.Hand;
                        }
                        if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                        {
                            student_dtg.Cursor = Cursors.Hand;
                        }
                    };

                    // Add the CellMouseLeave event to revert the cursor to the default cursor
                    student_dtg.CellMouseLeave += (sender, e) =>
                    {
                        student_dtg.Cursor = Cursors.Default;
                    };

                    if (!isDataFound)
                    {
                        loadingPanel.Visible = true;
                        loadingTxt.Text = "No Student found!";
                    }
                    else
                    {
                        loadingPanel.Visible = false;
                    }
                }
            }
        }

        private async Task getStudentByGender(string gender, int pageNumber, int pageSize)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                // Calculate the offset based on the page number and page size
                int offset = (pageNumber - 1) * pageSize;

                Query q = studentRef.WhereEqualTo("gender", gender)
                                                   .OrderBy("addedOn")  // Assuming you want to order by id
                                                   .Offset(offset)
                                                   .Limit(pageSize);

                student_dtg.Rows.Clear();

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool isDataFound = false;

                // Add columns to the DataGridView if they are not already added
                if (student_dtg.Columns.Count == 0)
                {
                    student_dtg.Columns.Add("id", "ID");
                    student_dtg.Columns.Add("name", "Name");
                    student_dtg.Columns.Add("lrn", "Lrn Number");
                    student_dtg.Columns.Add("gender", "Gender");
                    student_dtg.Columns.Add("grade_level", "Grade Level");
                    student_dtg.Columns.Add("section", "Section");
                    student_dtg.Columns.Add("action", "Action");
                    student_dtg.Columns.Add("details", "details");
                }

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        /*filteredTable.Rows.InsertAt(filteredTable.NewRow(), 0); // Insert new row at index 0

                        filteredTable.Rows[0].SetField("ID", students.id);
                        filteredTable.Rows[0].SetField("Name", capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".");
                        filteredTable.Rows[0].SetField("Lrn", students.lrn_number);
                        filteredTable.Rows[0].SetField("Gender", students.gender);
                        filteredTable.Rows[0].SetField("Grade Level", students.grade_level);
                        filteredTable.Rows[0].SetField("Section", students.section);
                        filteredTable.Rows[0].SetField("Action", Properties.Resources.test);
                        filteredTable.Rows[0].SetField("Details", Properties.Resources.eye);*/

                        student_dtg.Rows.Insert(
                                0,
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                students.lrn_number,
                                students.gender,
                                students.grade_level,
                                students.section,
                                Properties.Resources.test,
                                Properties.Resources.eye
                            );
                        isDataFound = true;
                    }
                    else
                    {
                        isDataFound = false;
                    }
                }

                // Add the CellFormatting event to set the tooltip for the Warning column
                student_dtg.CellFormatting += (sender, e) =>
                {
                    if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cell.ToolTipText = "View Grades";
                    }
                    if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        DataGridViewCell cell = student_dtg.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        cell.ToolTipText = "View Details";
                    }
                };
                // Add the CellMouseEnter event to change the cursor to a hand cursor
                student_dtg.CellMouseEnter += (sender, e) =>
                {
                    if (e.ColumnIndex == 6 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        student_dtg.Cursor = Cursors.Hand;
                    }
                    if (e.ColumnIndex == 7 && e.RowIndex >= 0 && e.RowIndex < student_dtg.Rows.Count)
                    {
                        student_dtg.Cursor = Cursors.Hand;
                    }
                };

                // Add the CellMouseLeave event to revert the cursor to the default cursor
                student_dtg.CellMouseLeave += (sender, e) =>
                {
                    student_dtg.Cursor = Cursors.Default;
                };

                if (!isDataFound)
                {
                    loadingPanel.Visible = true;
                    loadingTxt.Text = "No Student found!";
                }
                else
                {
                    loadingPanel.Visible = false;
                }

            }
        }

        private async void female_panel_Click(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "Searching student...";

            genderLbl = "Female";
            await loadByGender("Female");
        }

        private async void filter_value_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadingPanel.Visible = true;
            loadingTxt.Text = "Searching student...";

            string filter = filter_value_cbx.SelectedItem.ToString();
            studentCount = await getStudentCount();
            await loadByFilter(filter);
        }

        private async void StudentProfiles_Load(object sender, EventArgs e)
        {
            await getMaleCount();
            await getFemaleCount();
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

        private async void next_btn_Click(object sender, EventArgs e)
        {
            string filterType = filter_type_cbx.Text;

            if (!genderLbl.Equals(""))
            {
                LoadNextPageGender(genderLbl);
            }
            else
            {
                if (!filterType.Equals("Any"))
                {
                    string filter = filter_value_cbx.SelectedItem.ToString();

                    if (!filter.Equals("") || filter != null)
                    {
                        if(filter.Equals("Any"))
                        {
                            LoadNextPage();
                        }
                        else
                        {
                           LoadNextPageFilter(filter);
                        }
                    }
                }
                else
                {
                    LoadNextPage();
                }
            }
        }

        private void previous_btn_Click(object sender, EventArgs e)
        {
            string filterType = filter_type_cbx.Text;

            if (!genderLbl.Equals(""))
            {
                LoadPreviousPageGender(genderLbl);
            }
            else
            {
                if (!filterType.Equals("Any"))
                {
                    string filter = filter_value_cbx.SelectedItem.ToString();
                    if (!filter.Equals("") || filter != null)
                    {
                        if (filter.Equals("Any"))
                        {
                            LoadPreviousPage();
                        }
                        else
                        {
                            LoadPreviousPageFilter(filter);
                        }
                    }
                }
                else
                {
                    LoadPreviousPage();
                }
            }
        }
    }
}
