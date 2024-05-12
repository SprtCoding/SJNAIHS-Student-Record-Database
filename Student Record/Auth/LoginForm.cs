using Google.Cloud.Firestore;
using Student_Record.AdminModule;
using Student_Record.DataSets;
using Student_Record.DataSets.UserDataSetTableAdapters;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using Student_Record.Internet;
using Student_Record.Loaders;
using Student_Record.TeachersModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ProgressBar = System.Windows.Forms.ProgressBar;

namespace Student_Record.Auth
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void login_btn_Click(object sender, EventArgs e)
        {
            // Example usage in your form's method
            if (!InternetConnectionChecker.IsInternetAvailable())
            {
                MessageBox.Show("Please check your internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string loginCode = loginCodeTB.Text;

                if (String.IsNullOrEmpty(loginCode) || loginCode.Equals("Enter Login Code") || loginCode.Equals(""))
                {
                    MessageBox.Show("Please enter your login code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    login_code_tb.Focus();
                    return;
                }
                else
                {
                    // Show message indicating authentication is in progress
                    authLabel.Text = "Authenticating, This may take a while, be patient...";
                    authLabel.Visible = true;
                    // Show progress bar
                    loadingProgress.Visible = true;

                    // Disable login button and text box during authentication
                    login_btn.Enabled = false;
                    loginCodeTB.Enabled = false;

                    // Start the authentication process with progress reporting
                    await signIn(loginCode, loadingProgress);

                    // Enable login button and text box after authentication is completed
                    login_btn.Enabled = true;
                    loginCodeTB.Enabled = true;

                    // Hide progress bar and status label
                    loadingProgress.Visible = false;
                    authLabel.Visible = false;
                }
            }
        }

        private async Task signIn(string loginCode, ProgressBar progressBar)
        {
            try
            {
                var db = FirestoreHelper.database;
                bool success = false;
                bool accountFound = false, correctCredentials = false;
                int retryCount = 0;

                while (!success) // Retry up to 3 times
                {
                    try
                    {
                        if (db != null)
                        {
                            // Report progress: Step 1
                            progressBar.Value = 25;

                            DocumentReference userDocRef = db.Collection("users").Document(loginCode);
                            DocumentSnapshot documentSnapshot = await userDocRef.GetSnapshotAsync();

                            if (documentSnapshot.Exists)
                            {
                                // Report progress: Step 2
                                progressBar.Value = 50;

                                accountFound = true;

                                Users data = documentSnapshot.ConvertTo<Users>();

                                if (data != null && loginCode == data.login_code)
                                {
                                    correctCredentials = true;

                                    string? account_type = data.account_type;
                                    string? name = data.name;
                                    string? email = data.email;

                                    progressBar.Value = 75;

                                    if (account_type != null && name != null && email != null)
                                    {
                                        if (account_type.Equals("admin"))
                                        {
                                            AdminDashboard adminDashboard = new AdminDashboard(
                                                    data.login_code,
                                                    name,
                                                    email
                                                );
                                            adminDashboard.Show();
                                            Hide();
                                        }
                                        else
                                        {
                                            FacultyDashboard facultyDashboard = new FacultyDashboard(
                                                    data.login_code,
                                                    name,
                                                    email
                                                );
                                            facultyDashboard.Show();
                                            Hide();
                                        }
                                        progressBar.Value = 100;
                                        success = true; // Set success to true if everything goes well
                                        break; // Stop the loop since success is achieved
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect username and password.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    // Enable login button and text box after authentication is completed
                                    login_btn.Enabled = true;
                                    loginCodeTB.Enabled = true;

                                    // Hide progress bar and status label
                                    loadingProgress.Visible = false;
                                    authLabel.Visible = false;
                                    // Report progress: Step 3
                                    progressBar.Value = 0;
                                    break;
                                }
                            }
                            else
                            {
                                MessageBox.Show("No account found.", "Auth Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                // Enable login button and text box after authentication is completed
                                login_btn.Enabled = true;
                                loginCodeTB.Enabled = true;

                                // Hide progress bar and status label
                                loadingProgress.Visible = false;
                                authLabel.Visible = false;

                                // Report progress: Step 3
                                progressBar.Value = 0;
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("null.", "DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Enable login button and text box after authentication is completed
                            login_btn.Enabled = true;
                            loginCodeTB.Enabled = true;

                            // Hide progress bar and status label
                            loadingProgress.Visible = false;
                            authLabel.Visible = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        // Log the error and retry after a delay
                        Console.WriteLine($"Error occurred: {ex.Message}");
                        retryCount++;
                        await Task.Delay(TimeSpan.FromSeconds(2 * retryCount)); // Exponential backoff
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginCodeTB.Focus();
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //loginCodeTB.Focus();
        }

        private async void loginCodeTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Example usage in your form's method
                if (!InternetConnectionChecker.IsInternetAvailable())
                {
                    MessageBox.Show("Please check your internet connection!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string loginCode = loginCodeTB.Text;

                    if (String.IsNullOrEmpty(loginCode) || loginCode.Equals("Enter Login Code") || loginCode.Equals(""))
                    {
                        MessageBox.Show("Please enter your login code.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        login_code_tb.Focus();
                        return;
                    }
                    else
                    {
                        // Show message indicating authentication is in progress
                        authLabel.Text = "Authenticating, This may take a while, be patient...";
                        authLabel.Visible = true;
                        // Show progress bar
                        loadingProgress.Visible = true;

                        // Disable login button and text box during authentication
                        login_btn.Enabled = false;
                        loginCodeTB.Enabled = false;

                        // Start the authentication process with progress reporting
                        await signIn(loginCode, loadingProgress);

                        // Enable login button and text box after authentication is completed
                        login_btn.Enabled = true;
                        loginCodeTB.Enabled = true;

                        // Hide progress bar and status label
                        loadingProgress.Visible = false;
                        authLabel.Visible = false;
                    }
                }
            }
        }
    }
}
