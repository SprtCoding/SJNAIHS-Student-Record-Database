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
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;
using System.IO;

namespace Student_Record.TeachersModule.GradingSheetPrint
{
    public partial class StudentPrintPreview : Form
    {
        string? my_id;
        private PrintPreviewDialog? printPrevDialog = new PrintPreviewDialog();
        private PrintDocument? printDoc = new PrintDocument();
        Bitmap? bitmap;
        public StudentPrintPreview(string id)
        {
            InitializeComponent();
            this.my_id = id;

            loadData();
            print_tp.SetToolTip(printBtn, "Print");
        }

        public async void loadData()
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("faculty_id", this.my_id);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool dataFound = false;
                int count = 1;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        //DateTime dateOfBirth = DateTime.Parse(students.dob);
                        string date = students.dob.ToString("MM/dd/yyyy");

                        student_dtg.Rows.Add(
                                students.id,
                                count,
                                capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName,
                                students.lrn_number,
                                students.address,
                                date,
                                students.father_name,
                                students.mother_name,
                                students.guardian_name,
                                students.last_school_attended,
                                students.strand,
                                students.contact_number
                            );
                        count++;

                        dataFound = true;
                    }
                }
            }
        }

        public async void getFilterStudent(string filter)
        {
            student_dtg.DataSource = null;
            student_dtg.Rows.Clear();

            var db = FirestoreHelper.database;
            if (db != null)
            {
                CollectionReference studentRef = db.Collection("students");

                Query q = studentRef.WhereEqualTo("faculty_id", this.my_id).WhereEqualTo("section", filter);

                QuerySnapshot snap = await q.GetSnapshotAsync();

                bool dataFound = false;
                int count = 1;

                foreach (DocumentSnapshot snapshot in snap.Documents)
                {
                    if (snapshot.Exists)
                    {
                        Students students = snapshot.ConvertTo<Students>();

                        // Capitalize the first letter of last_name
                        string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                        // Capitalize the first letter of last_name
                        string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                        //DateTime dateOfBirth = DateTime.Parse(students.dob);
                        string date = students.dob.ToString("MM/dd/yyyy");

                        student_dtg.Rows.Add(
                                students.id,
                                count,
                                capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName,
                                students.lrn_number,
                                students.address,
                                date,
                                students.father_name,
                                students.mother_name,
                                students.guardian_name,
                                students.last_school_attended,
                                students.strand,
                                students.contact_number
                            );
                        count++;

                        dataFound = true;
                    }
                }
            }
        }

        private void grade_lvl_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            section_cbx.Items.Clear(); // Clear existing items

            string selectedGrade = grade_lvl_cbx.SelectedItem.ToString();

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

        private void section_cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            string section = section_cbx.SelectedItem.ToString();
            section_lbl.Text = section;
            if (section != null)
            {
                getFilterStudent(section);
            }
            else
            {
                loadData();
            }
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
            //int y = printArea.Top + (printArea.Height - height) / 2;
            int y = printArea.Top; // Set y to the top margin of the print area

            // Draw the scaled image
            e.Graphics.DrawImage(bitmap, x, y, width, height);
        }

        private void getPrinterArea(Panel card_panel)
        {
            bitmap = new Bitmap(card_panel.Width, card_panel.Height);
            card_panel.DrawToBitmap(bitmap, new Rectangle(0, 0, card_panel.Width, card_panel.Height));
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintCard(this.print_panel);
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
    }
}
