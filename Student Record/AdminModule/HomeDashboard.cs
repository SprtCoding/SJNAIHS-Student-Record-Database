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
            // Example usage in your form's method
            if (!InternetConnectionChecker.IsInternetAvailable())
            {
                MessageBox.Show("No internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void getTotalFaculty()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("users");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    Query query = collectionRef.WhereEqualTo("account_type", "faculty");

                    // Fetch the documents
                    QuerySnapshot snapshot = await query.GetSnapshotAsync();

                    int facultyCount = snapshot.Documents.Count;
                    faculty_text_value.Text = facultyCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getTotalStudent()
        {
            try
            {
                var db = FirestoreHelper.database;
                if (db != null)
                {
                    // Reference to your Firestore collection
                    CollectionReference collectionRef = db.Collection("students");

                    // Create a query to filter documents with "sms_type" equal to "emergency"
                    //Query query = collectionRef.WhereEqualTo("account_type", "faculty");

                    // Fetch the documents
                    QuerySnapshot snapshot = await collectionRef.GetSnapshotAsync();

                    int studentCount = snapshot.Documents.Count;
                    total_student_lbl.Text = studentCount.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HomeDashboard_Load(object sender, EventArgs e)
        {
            getTotalFaculty();
            getTotalStudent();
        }
    }
}
