using Google.Cloud.Firestore;
using Student_Record.DataSets.UserDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Internet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Record.AdminModule
{
    public partial class HomeDashboard : Form
    {
        public HomeDashboard()
        {
            InitializeComponent();
        }

        private async Task<int> GetTotalFaculty()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference collectionRef = db.Collection("users");
                    Query query = collectionRef.WhereEqualTo("account_type", "faculty");
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();
                    return snapshot.Documents.Count;
                }
                else
                {
                    MessageBox.Show("Firestore database is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching faculty count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async Task<int> GetTotalStudent()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    CollectionReference collectionRef = db.Collection("students");
                    QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();
                    return snapshot.Documents.Count;
                }
                else
                {
                    MessageBox.Show("Firestore database is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching student count: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        private async void HomeDashboard_Load(object sender, EventArgs e)
        {
            try
            {
                int facultyCount = await GetTotalFaculty();
                faculty_text_value.Text = facultyCount.ToString();

                int studentCount = await GetTotalStudent();
                total_student_lbl.Text = studentCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
