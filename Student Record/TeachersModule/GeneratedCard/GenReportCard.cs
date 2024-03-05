using Google.Cloud.Firestore;
using Student_Record.Firebase;
using Student_Record.Firebase.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Record.TeachersModule.GeneratedCard
{
    public partial class GenReportCard : Form
    {
        string? id;
        private Panel? panelToPrint;
        private PrintPreviewDialog? printPrevDialog = new PrintPreviewDialog();
        private PrintDocument? printDoc = new PrintDocument();

        public GenReportCard(string? id)
        {
            InitializeComponent();
            this.id = id;
            getStudent();

            // Set tooltip text for the PictureBox
            toolTip1.SetToolTip(print_btn, "Print");
        }

        private async void getStudent()
        {
            grade_dtg.DataSource = null;
            grade_dtg.Rows.Clear();

            try
            {
                var db = FirestoreHelper.database;

                if (db != null)
                {
                    DocumentReference docRef = db.Collection("students").Document(id);
                    Students students = docRef.GetSnapshotAsync().Result.ConvertTo<Students>();

                    if (students != null)
                    {
                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        string fullname = capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName;

                        name_tb.Text = fullname;
                        level_tb.Text = students.grade_level.ToString();
                        section_tb.Text = students.section;

                        CollectionReference colRef = docRef.Collection("Grades");
                        QuerySnapshot snap = await colRef.GetSnapshotAsync();

                        bool isDataFound = false;

                        foreach (DocumentSnapshot snapshot in snap.Documents)
                        {
                            if (snapshot.Exists)
                            {
                                Students stud_data = snapshot.ConvertTo<Students>(); // Make sure "Users" class is defined correctly

                                //stud_data.mid_grade = snapshot.GetValue<double?>("mid_grade") ?? 0.0;
                                //stud_data.final_grade = snapshot.GetValue<double?>("final_grade") ?? 0.0;
                                //stud_data.average = snapshot.GetValue<double?>("average") ?? 0.0;

                                grade_dtg.Rows.Insert(0,
                                    stud_data.subject,
                                    stud_data.mid_term_grade,
                                    stud_data.final_term_grade,
                                    stud_data.final_grade
                                    );

                                isDataFound = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }

        Bitmap bitmap;

        private void print_btn_Click(object sender, EventArgs e)
        {
            //Graphics graphics = card_panel.CreateGraphics();
            //Size size = this.ClientSize;
            //bitmap = new Bitmap(size.Width - 60, size.Height, graphics);
            //graphics = Graphics.FromImage(bitmap);
            //
            //Point point = PointToScreen(card_panel.Location);
            //graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);
            //
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();
            PrintCard(this.card_panel);
        }

        private void PrintCard(Panel card_panel)
        {
            PrinterSettings ps = new PrinterSettings();
            this.card_panel = card_panel;
            getPrinterArea(card_panel);
            printPrevDialog.Document = printDoc;
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_printpage);
            printPrevDialog.ShowDialog();
        }

        public void printDoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle printArea = e.MarginBounds;

            // Calculate the aspect ratio of the panel content
            float aspectRatio = (float)this.card_panel.Width / this.card_panel.Height;

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
    }
}
