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
    public partial class Details : Form
    {
        public Details(string id)
        {
            InitializeComponent();
            getStudentInfo(id);
        }

        public static Image Base64StringIntoImage(string imageStr)
        {
            byte[] img = Convert.FromBase64String(imageStr);
            using (MemoryStream ms = new MemoryStream(img))
            {
                return Image.FromStream(ms);
            }
        }

        private async void getStudentInfo(string id)
        {
            var db = FirestoreHelper.database;
            if (db != null)
            {
                DocumentReference docRef = db.Collection("students").Document(id);
                Students students = docRef.GetSnapshotAsync().Result.ConvertTo<Students>();

                if (students != null)
                {
                    string _imageStr = students.ImageStr;
                    img.Image = Base64StringIntoImage(_imageStr);
                    // Capitalize the first letter of last_name
                    string capitalizedLastName = char.ToUpper(students.last_name[0]) + students.last_name.Substring(1);
                    // Capitalize the first letter of last_name
                    string capitalizedFirstName = char.ToUpper(students.first_name[0]) + students.first_name.Substring(1);

                    student_name_lbl.Text = capitalizedFirstName + " " + students.middle_name.Substring(0, 1).ToUpper() + ". " + capitalizedLastName;
                    section_lbl.Text = students.grade_level + "-" + students.section;

                    //if (students.gender != null)
                    //{
                    //    if (students.gender.Equals("Female"))
                    //    {
                    //        img.Image = Properties.Resources.user_female;
                    //    }
                    //    else if (students.gender.Equals("Male"))
                    //    {
                    //        img.Image = Properties.Resources.user_male;
                    //    }
                    //}

                    CollectionReference colRef = docRef.Collection("Grades");
                    QuerySnapshot snap = await colRef.GetSnapshotAsync();

                    bool isDataFound = false;

                    double totalGrade = 0, totalAverage = 0, totalMidGrade = 0, totalFinalGrade = 0,
                        midAverage = 0, finalAverage = 0;

                    foreach (DocumentSnapshot snapshot in snap.Documents)
                    {
                        if (snapshot.Exists)
                        {
                            Students stud_data = snapshot.ConvertTo<Students>(); // Make sure "Users" class is defined correctly

                            //stud_data.mid_grade = snapshot.GetValue<double?>("mid_grade") ?? 0.0;
                            //stud_data.final_grade = snapshot.GetValue<double?>("final_grade") ?? 0.0;
                            //stud_data.average = snapshot.GetValue<double?>("average") ?? 0.0;

                            grade_dtg.Rows.Insert(0,
                                stud_data.grade_id,
                                stud_data.subject,
                                stud_data.mid_term_grade,
                                stud_data.final_term_grade,
                                stud_data.final_grade
                                );

                            totalGrade += (double)stud_data.final_grade;
                            totalMidGrade += (double)stud_data.mid_term_grade;
                            totalFinalGrade += (double)stud_data.final_term_grade;

                            isDataFound = true;
                        }
                    }

                    totalAverage = Math.Round(totalGrade / snap.Documents.Count(), 2);
                    midAverage = Math.Round(totalMidGrade / snap.Documents.Count(), 2);
                    finalAverage = Math.Round(totalFinalGrade / snap.Documents.Count(), 2);

                    mid_term_average_lbl.Text = midAverage.ToString();
                    final_term_average_lbl.Text = finalAverage.ToString();
                    general_average_lbl.Text = totalAverage.ToString();

                    if (totalAverage >= 90 && totalAverage <= 94)
                    {
                        rebon_img.Image = Properties.Resources.medal_3;
                        rebon_img.Visible = true;
                    }
                    else if (totalAverage >= 95 && totalAverage <= 97)
                    {
                        rebon_img.Image = Properties.Resources.medal_2;
                        rebon_img.Visible = true;
                    }
                    else if (totalAverage >= 98 && totalAverage <= 100)
                    {
                        rebon_img.Image = Properties.Resources.medal_1;
                        rebon_img.Visible = true;
                    }


                    if (!isDataFound)
                    {
                        no_data_panel.Visible = true;
                        grade_dtg.Visible = false;
                    }
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
