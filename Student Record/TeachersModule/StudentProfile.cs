using Student_Record.DataSets.UserDataSetTableAdapters;
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
using Student_Record.Loaders;
using System.Xml.Linq;
using OfficeOpenXml;
using Student_Record.Firebase;
using Google.Cloud.Firestore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using Student_Record.Firebase.Model;
using Student_Record.AdminModule.Student;
using System.Security.Cryptography;
using Google.Cloud.Firestore.V1;
using Student_Record.TeachersModule.GradingSheetPrint;
using System.IO;
using Student_Record.TeachersModule.Docs;

namespace Student_Record.TeachersModule
{
    public partial class StudentProfile : Form
    {
        private bool isSecondColumnVisible = false;
        private string? faculty_id, faculty_name, student_id;
        private Guid uid = Guid.NewGuid();

        public StudentProfile(string? id, string? name)
        {
            InitializeComponent();
            faculty_id = id;
            faculty_name = name;
        }

        void Wait()
        {
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(5);
            }
        }

        public static string ImageIntoBase64String(PictureBox image)
        {
            MemoryStream ms = new MemoryStream();
            image.Image.Save(ms, image.Image.RawFormat);
            return Convert.ToBase64String(ms.ToArray());
        }

        public static Image Base64StringIntoImage(string imageStr)
        {
            byte[] img = Convert.FromBase64String(imageStr);
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        public async void loadData()
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("faculty_id", faculty_id);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool dataFound = false;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        student_dtg.Rows.Insert(
                                0,
                                students.id,
                                capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ".",
                                students.lrn_number,
                                students.gender,
                                students.grade_level,
                                students.section,
                                Properties.Resources.test,
                                Properties.Resources.edit_green
                            );

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
                                cell.ToolTipText = "Edit";
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

                        dataFound = true;
                    }
                }

                // Check the flag to determine whether any data is found
                if (!dataFound)
                {
                    no_data_panel.Visible = true;
                    no_data_anim.Visible = true;
                    no_data_text.Visible = true;
                    student_dtg.Visible = false;
                    generate_btn.Enabled = false;
                }
            }

        }

        private void clearField()
        {
            firstname_tb.Text = "";
            middlename_tb.Text = "";
            lastname_tb.Text = "";
            suffix_tb.Text = "";
            lrn_tb.Text = "";
            date_of_birth_dt.Value = DateTime.Now;
            address_tb.Text = "";
            student_contactNo_tb.Text = "";
            father_name_tb.Text = "";
            father_contactNo_tb.Text = "";
            mother_name_tb.Text = "";
            mother_contactNo_tb.Text = "";
            guardian_name_tb.Text = "";
            guardian_contactNo_tb.Text = "";
            last_school_attended_tb.Text = "";
            major_tb.Text = "";
            section_cbx.Text = "";
            grade_level_cbx.Text = "";
            gender_cbx.Text = "";
            student_pic.Image = Properties.Resources.gallery;
            fileName_tb.Text = "";
        }

        private void StudentProfile_Load(object sender, EventArgs e)
        {
            loadData();
            lastname_tb.Focus();
            section_cbx.Enabled = false;

            update_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void grade_level_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            section_cbx.Items.Clear(); // Clear existing items

            string selectedGrade = grade_level_cbx.SelectedItem.ToString();

            // Populate ComboBoxSection based on the selected grade
            if (selectedGrade == "11")
            {
                section_cbx.Items.AddRange(new string[] { "Canary", "Flamingo", "Falcon", "Skylark", "Pelican" }); // Add grade 11 sections
            }
            else if (selectedGrade == "12")
            {
                section_cbx.Items.AddRange(new string[] { "Apollo", "Artemis", "Athena", "Kairos", "Sol Invictus" }); // Add grade 12 sections
            }

            if (selectedGrade != "")
            {
                section_cbx.Enabled = true;
            }
            else
            {
                section_cbx.Enabled = false;
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            string first_name = firstname_tb.Text;
            string middle_name = middlename_tb.Text;
            string last_name = lastname_tb.Text;
            string suffix = suffix_tb.Text;
            string lrn_no = lrn_tb.Text;
            string dob = date_of_birth_dt.Value.ToString();
            string address = address_tb.Text;
            string student_contact = student_contactNo_tb.Text;
            string father_name = father_name_tb.Text;
            string father_contact = father_contactNo_tb.Text;
            string mother_name = mother_name_tb.Text;
            string mother_contact = mother_contactNo_tb.Text;
            string guardian_name = guardian_name_tb.Text;
            string guardian_contact = guardian_contactNo_tb.Text;
            string last_school_attended = last_school_attended_tb.Text;
            string major = major_tb.Text;
            string section = section_cbx.Text;
            string grade_level = grade_level_cbx.Text;
            string gender = gender_cbx.Text;

            if (String.IsNullOrEmpty(first_name))
            {
                MessageBox.Show("First Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstname_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(middle_name))
            {
                MessageBox.Show("Middle Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                middlename_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(last_name))
            {
                MessageBox.Show("Last Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lastname_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lrn_no))
            {
                MessageBox.Show("LRN Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lrn_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                address_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(student_contact))
            {
                MessageBox.Show("Student Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                student_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(father_name))
            {
                MessageBox.Show("Father's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                father_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(father_contact))
            {
                MessageBox.Show("Father's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                father_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(mother_name))
            {
                MessageBox.Show("Mother's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mother_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(mother_contact))
            {
                MessageBox.Show("Mother's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mother_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(guardian_name))
            {
                MessageBox.Show("Guardian's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardian_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(guardian_contact))
            {
                MessageBox.Show("Guardian's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardian_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(last_school_attended))
            {
                MessageBox.Show("Last School Attended is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                last_school_attended_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(major))
            {
                MessageBox.Show("Major is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                major_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(grade_level))
            {
                MessageBox.Show("Grade Level is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade_level_cbx.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(section))
            {
                MessageBox.Show("Section is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                section_cbx.Focus();
                return;
            }
            else if (student_pic.Image == null)
            {
                MessageBox.Show("Please select student Photo", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                setStudent(
                    first_name,
                    middle_name,
                    last_name,
                    suffix,
                    lrn_no,
                    dob,
                    address,
                    student_contact,
                    father_name,
                    father_contact,
                    mother_name,
                    mother_contact,
                    guardian_name,
                    guardian_contact,
                    last_school_attended,
                    major,
                    grade_level,
                    section,
                    gender,
                    ImageIntoBase64String(student_pic)
                    );
            }
        }

        private async void setStudent(string first_name, string middle_name, string last_name, string suffix, string lrn_no, string dob, string address, string student_contact, string father_name, string father_contact, string mother_name, string mother_contact, string guardian_name, string guardian_contact, string last_school_attended, string major, string grade_level, string section, string gender, string imageStr)
        {
            int grade_lvl = int.Parse(grade_level);
            string? name;

            if (!suffix.Equals(""))
            {
                name = first_name + " " + middle_name + " " + last_name + " " + suffix;
            }
            else
            {
                name = first_name + " " + middle_name + " " + last_name;
            }

            try
            {
                var db = FirestoreHelper.database;

                string new_uid = uid.ToString();

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Query q = colRef.WhereEqualTo("faculty_id", faculty_id).WhereEqualTo("name", name);

                    try
                    {
                        // Execute the query asynchronously
                        QuerySnapshot querySnapshot = await q.GetSnapshotAsync();

                        // Check if any documents match the query
                        if (querySnapshot.Count > 0)
                        {
                            MessageBox.Show("Data with this name already exists in the database.");
                        }
                        else
                        {
                            Dictionary<string, object> data = new Dictionary<string, object>()
                            {
                                {"id", new_uid },
                                {"name", name },
                                {"first_name", first_name },
                                {"middle_name", middle_name },
                                {"last_name", last_name },
                                {"suffix", suffix },
                                {"lrn_number", lrn_no },
                                {"dob", dob },
                                {"address", address },
                                {"contact_number", student_contact },
                                {"father_contact", father_contact },
                                {"mother_contact", mother_contact },
                                {"guardian_contact", guardian_contact },
                                {"father_name", father_name },
                                {"mother_name", mother_name },
                                {"guardian_name", guardian_name },
                                {"last_school_attended", last_school_attended },
                                {"major", major },
                                {"grade_level", grade_lvl },
                                {"section", section },
                                {"gender", gender },
                                {"ImageStr", imageStr },
                                {"faculty_id", faculty_id },
                                {"adviser", faculty_name },
                                {"hasGrade", false },
                                {"hasHonor", false }
                            };

                            var info = await colRef.Document(new_uid).CreateAsync(data);

                            DocumentReference collectionRef = db.Collection("students").Document(new_uid);

                            CollectionReference other_docs_ref = collectionRef.Collection("other_docs");

                            if(AddNewDocs.data != null)
                            {
                                foreach (var item in AddNewDocs.data)
                                {
                                    Guid uid = Guid.NewGuid();
                                    string docs_uid = uid.ToString();

                                    Dictionary<string, object> docs_data = new Dictionary<string, object>()
                                    {
                                        { "docs_name", item.fileName },
                                        { "docs_path", item.filePath },
                                        { "docs_url", item.fileURL },
                                        { "docs_id", docs_uid }
                                    };

                                    await other_docs_ref.Document(new_uid).SetAsync(docs_data);
                                }
                                AddNewDocs.data.Clear();
                            }

                            MessageBox.Show(first_name + " " + middle_name + " " + last_name + " " + suffix + " registered successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            loadData();
                            clearField();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the query
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void generate_btn_Click(object sender, EventArgs e)
        {
            if (generate_btn.Text == "Cancel Edit")
            {
                clearField();
                update_btn.Enabled = false;
                delete_btn.Enabled = false;
                lrn_tb.Enabled = true;
                save_btn.Enabled = true;
                generate_btn.Text = "Generate";
                generate_btn.Normalcolor = Color.FromArgb(129, 142, 254);
                generate_btn.OnHovercolor = Color.FromArgb(171, 180, 254);
            }
            else
            {
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                generateExcel();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // User clicked "Yes," perform the delete operation
                // Add your delete code here
                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }

                removedStudent();
            }
        }

        private async void removedStudent()
        {
            var db = FirestoreHelper.database;

            if (db != null)
            {
                DocumentReference docRef = db.Collection("students").Document(student_id);
                await docRef.DeleteAsync();
                MessageBox.Show("Removed successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                clearField();
                update_btn.Enabled = false;
                delete_btn.Enabled = false;
                lrn_tb.Enabled = true;
                save_btn.Enabled = true;
                generate_btn.Text = "Generate";
                generate_btn.Normalcolor = Color.FromArgb(129, 142, 254);
                generate_btn.OnHovercolor = Color.FromArgb(171, 180, 254);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string first_name = firstname_tb.Text;
            string middle_name = middlename_tb.Text;
            string last_name = lastname_tb.Text;
            string suffix = suffix_tb.Text;
            string lrn_no = lrn_tb.Text;
            string dob = date_of_birth_dt.Value.ToString();
            string address = address_tb.Text;
            string student_contact = student_contactNo_tb.Text;
            string father_name = father_name_tb.Text;
            string father_contact = father_contactNo_tb.Text;
            string mother_name = mother_name_tb.Text;
            string mother_contact = mother_contactNo_tb.Text;
            string guardian_name = guardian_name_tb.Text;
            string guardian_contact = guardian_contactNo_tb.Text;
            string last_school_attended = last_school_attended_tb.Text;
            string major = major_tb.Text;
            string section = section_cbx.Text;
            string grade_level = grade_level_cbx.Text;

            if (String.IsNullOrEmpty(first_name))
            {
                MessageBox.Show("First Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                firstname_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(middle_name))
            {
                MessageBox.Show("Middle Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                middlename_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(last_name))
            {
                MessageBox.Show("Last Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lastname_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(lrn_no))
            {
                MessageBox.Show("LRN Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lrn_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                address_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(student_contact))
            {
                MessageBox.Show("Student Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                student_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(father_name))
            {
                MessageBox.Show("Father's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                father_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(father_contact))
            {
                MessageBox.Show("Father's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                father_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(mother_name))
            {
                MessageBox.Show("Mother's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mother_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(mother_contact))
            {
                MessageBox.Show("Mother's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mother_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(guardian_name))
            {
                MessageBox.Show("Guardian's Name is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardian_name_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(guardian_contact))
            {
                MessageBox.Show("Guardian's Contact Number is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                guardian_contactNo_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(last_school_attended))
            {
                MessageBox.Show("Last School Attended is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                last_school_attended_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(major))
            {
                MessageBox.Show("Major is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                major_tb.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(grade_level))
            {
                MessageBox.Show("Grade Level is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grade_level_cbx.Focus();
                return;
            }
            else if (String.IsNullOrEmpty(section))
            {
                MessageBox.Show("Section is required.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                section_cbx.Focus();
                return;
            }
            else
            {
                string gender = gender_cbx.Text;

                using (FRM_Wait frm_wait = new FRM_Wait(Wait))
                {
                    frm_wait.ShowDialog(this);
                }
                updateStudent(
                    first_name,
                    middle_name,
                    last_name,
                    suffix,
                    lrn_no,
                    dob,
                    address,
                    student_contact,
                    father_name,
                    father_contact,
                    mother_name,
                    mother_contact,
                    guardian_name,
                    guardian_contact,
                    last_school_attended,
                    major,
                    grade_level,
                    section,
                    gender,
                    ImageIntoBase64String(student_pic)
                    );
            }
        }

        private async void updateStudent(string first_name, string middle_name, string last_name, string suffix, string lrn_no, string dob, string address, string student_contact, string father_name, string father_contact, string mother_name, string mother_contact, string guardian_name, string guardian_contact, string last_school_attended, string major, string grade_level, string section, string gender, string imageStr)
        {
            int grade_lvl = int.Parse(grade_level);

            string? name;

            if (!suffix.Equals(""))
            {
                name = first_name + " " + middle_name + " " + last_name + " " + suffix;
            }
            else
            {
                name = first_name + " " + middle_name + " " + last_name;
            }

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    CollectionReference colRef = db.Collection("students");

                    Dictionary<string, object> data = new Dictionary<string, object>()
                            {
                                {"name", name },
                                {"first_name", first_name },
                                {"middle_name", middle_name },
                                {"last_name", last_name },
                                {"suffix", suffix },
                                {"lrn_number", lrn_no },
                                {"dob", dob },
                                {"address", address },
                                {"contact_number", student_contact },
                                {"father_contact", father_contact },
                                {"mother_contact", mother_contact },
                                {"guardian_contact", guardian_contact },
                                {"father_name", father_name },
                                {"mother_name", mother_name },
                                {"guardian_name", guardian_name },
                                {"last_school_attended", last_school_attended },
                                {"major", major },
                                {"grade_level", grade_lvl },
                                {"section", section },
                                {"gender", gender },
                                {"ImageStr", imageStr }
                            };

                    var info = await colRef.Document(student_id).UpdateAsync(data);
                    MessageBox.Show("Student updated successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lastname_tb.Focus();
                    loadData();
                    clearField();
                    update_btn.Enabled = false;
                    delete_btn.Enabled = false;
                    lrn_tb.Enabled = true;
                    save_btn.Enabled = true;
                    generate_btn.Text = "Generate";
                    generate_btn.Normalcolor = Color.FromArgb(129, 142, 254);
                    generate_btn.OnHovercolor = Color.FromArgb(171, 180, 254);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void generateExcel()
        {
            // Allow the user to choose the template file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select Excel Template",
                Filter = "Excel Files|*.xlsx;*.xls",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string templateFilePath = openFileDialog.FileName;

                // Specify the path to save the generated Excel file
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Title = "Save Generated Excel File",
                    Filter = "Excel Files|*.xlsx;*.xls",
                    FileName = "Generated_Student_Profile.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string saveFilePath = saveFileDialog.FileName;

                    using (var package = new ExcelPackage(new FileInfo(templateFilePath)))
                    {
                        // Get the worksheet in your Excel template (by name or index)
                        var worksheet = package.Workbook.Worksheets[0]; // Adjust the index or name as needed

                        int excelRowMale = 14, excelRowFemale = 38; // Start at row 15 in Excel (B15)
                                                                    // Assuming you have student names in a DataGridView

                        var db = FirestoreHelper.database;

                        if (db != null)
                        {
                            CollectionReference colRef = db.Collection("students");

                            Query q = colRef.WhereEqualTo("faculty_id", faculty_id);

                            QuerySnapshot snap = await q.GetSnapshotAsync();

                            foreach (DocumentSnapshot snapshot in snap.Documents)
                            {
                                if (snapshot.Exists)
                                {
                                    Students students = snapshot.ConvertTo<Students>();

                                    int currentExcelRow;

                                    if (students.gender.ToLower() == "male")
                                    {
                                        currentExcelRow = excelRowMale;
                                    }
                                    else if (students.gender.ToLower() == "female")
                                    {
                                        currentExcelRow = excelRowFemale;
                                    }
                                    else
                                    {
                                        // Handle other genders or unknown cases
                                        continue; // Skip to the next iteration
                                    }

                                    // Capitalize the first letter of last_name
                                    string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                                    // Capitalize the first letter of last_name
                                    string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                                    worksheet.Cells[currentExcelRow, 3].Value = capitalizedLastName + ", " + capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + students.suffix; // Assuming the student name should be in column B
                                    worksheet.Cells[currentExcelRow, 4].Value = students.lrn_number;
                                    worksheet.Cells[currentExcelRow, 5].Value = students.address;
                                    worksheet.Cells[currentExcelRow, 6].Value = students.dob;
                                    worksheet.Cells[currentExcelRow, 7].Value = students.father_name;
                                    worksheet.Cells[currentExcelRow, 8].Value = students.mother_name;
                                    worksheet.Cells[currentExcelRow, 9].Value = students.guardian_name;
                                    worksheet.Cells[currentExcelRow, 10].Value = students.last_school_attended;
                                    worksheet.Cells[currentExcelRow, 11].Value = students.major;
                                    worksheet.Cells[currentExcelRow, 12].Value = students.contact_number;


                                    // Increment the excelRow for the next student of the respective gender
                                    if (students.gender.ToLower() == "male")
                                    {
                                        excelRowMale++;
                                    }
                                    else if (students.gender.ToLower() == "female")
                                    {
                                        excelRowFemale++;
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No data found!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }

                            // Save the Excel file with the updated data
                            //var saveFilePath = "C:\\Users\\adrle\\source\\repos\\Student Record\\Student Record\\ExcelTemplate\\STUDENT-PROFILE.xlsx"; // Specify the path for the updated file
                            package.SaveAs(new FileInfo(saveFilePath));
                            MessageBox.Show("Student Profile generated and saved.");
                        }
                    }
                }
            }
        }

        private void show_data_btn_Click(object sender, EventArgs e)
        {
            // Toggle the visibility of the second column
            isSecondColumnVisible = !isSecondColumnVisible;

            if (isSecondColumnVisible)
            {
                // Show the second column
                tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 0);
                tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
                show_data_btn.Text = "Back";
            }
            else
            {
                // Hide the second column
                tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
                tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 0);
                show_data_btn.Text = "View Students";
            }
        }

        private void student_dtg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Perform the "Edit" action
                DataGridViewRow selectedRow = student_dtg.Rows[e.RowIndex];
                string? id = selectedRow.Cells["id"].Value.ToString();

                if (student_dtg.Columns[e.ColumnIndex].Name == "action")
                {
                    Details details = new Details(id);
                    details.ShowDialog(this);
                }
                if (student_dtg.Columns[e.ColumnIndex].Name == "edit")
                {
                    var db = FirestoreHelper.database;

                    if (db != null)
                    {
                        DocumentReference docRef = db.Collection("students").Document(id);
                        Students data = docRef.GetSnapshotAsync().Result.ConvertTo<Students>();

                        student_id = id;

                        //string? full_name = data.name;

                        //string[] nameParts = full_name.Split(' ');
                        //
                        //string first_name = nameParts[0];
                        //string middle_name = nameParts.Length > 2 ? nameParts[1] : string.Empty;
                        //string last_name = nameParts.Length > 2 ? nameParts[2] : nameParts[1];
                        //string suffix = nameParts.Length > 3 ? nameParts[3] : string.Empty;

                        firstname_tb.Text = data.first_name;
                        middlename_tb.Text = data.middle_name;
                        lastname_tb.Text = data.last_name;
                        suffix_tb.Text = data.suffix;

                        lrn_tb.Text = data.lrn_number;

                        string dateOfBirthString = data.dob;

                        // Convert the date string to a DateTime object
                        DateTime dateOfBirth;

                        if (DateTime.TryParse(dateOfBirthString, out dateOfBirth))
                        {
                            // Set the value of your DateTimePicker control
                            date_of_birth_dt.Value = dateOfBirth;
                        }
                        else
                        {
                            // Handle the case where the string cannot be parsed as a valid date
                            MessageBox.Show("Invalid date format");
                        }

                        address_tb.Text = data.address;
                        student_contactNo_tb.Text = data.contact_number;
                        father_name_tb.Text = data.father_name;
                        father_contactNo_tb.Text = data.father_contact;
                        mother_name_tb.Text = data.mother_name;
                        mother_contactNo_tb.Text = data.mother_contact;
                        guardian_name_tb.Text = data.guardian_name;
                        guardian_contactNo_tb.Text = data.guardian_contact;
                        last_school_attended_tb.Text = data.last_school_attended;
                        major_tb.Text = data.major;
                        section_cbx.Text = data.section;
                        gender_cbx.Text = data.gender;
                        string? gradeCellValue = data.grade_level.ToString();
                        string numericGrade = new string(gradeCellValue.Where(char.IsDigit).ToArray());

                        if (!string.IsNullOrEmpty(numericGrade))
                        {
                            grade_level_cbx.Text = numericGrade;
                        }
                        else
                        {
                            // Handle the case where there's no numeric grade, such as displaying an error message.
                            grade_level_cbx.Text = "";
                        }

                        update_btn.Enabled = true;
                        delete_btn.Enabled = true;
                        save_btn.Enabled = false;
                        lrn_tb.Enabled = false;
                        generate_btn.Text = "Cancel Edit";
                        generate_btn.Normalcolor = Color.FromArgb(191, 64, 64);
                        generate_btn.OnHovercolor = Color.FromArgb(203, 102, 102);
                        if (data.ImageStr != null)
                        {
                            student_pic.Image = Base64StringIntoImage(data.ImageStr);
                        }

                        // Toggle the visibility of the second column
                        isSecondColumnVisible = !isSecondColumnVisible;

                        if (isSecondColumnVisible)
                        {
                            // Show the second column
                            tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, 0);
                            tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 100F);
                            show_data_btn.Text = "Back";
                        }
                        else
                        {
                            // Hide the second column
                            tableLayoutPanel1.ColumnStyles[0] = new ColumnStyle(SizeType.Percent, 100F);
                            tableLayoutPanel1.ColumnStyles[1] = new ColumnStyle(SizeType.Absolute, 0);
                            show_data_btn.Text = "View Students";
                        }
                    }
                }
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (faculty_id != null)
            {
                StudentPrintPreview studentPrint = new StudentPrintPreview(faculty_id);
                studentPrint.ShowDialog();
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

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files(*.jpg, *.jpeg, *.bmp, *.png)|*.png;*.jpg;*.bmp;*.jpeg|All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileName = Path.GetFileName(filePath);

                fileName_tb.Text = fileName;
                student_pic.Load(filePath);
            }
        }

        private void addDocsBtn_Click(object sender, EventArgs e)
        {
            AddNewDocs addDocs = new AddNewDocs();
            addDocs.ShowDialog();
        }
    }
}
