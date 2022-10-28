using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SchoolOfFineArtsDB;
using SchoolOfFineArtsModels;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace SchoolOfFineArts
{
    public partial class Form1 : Form
    {
        private BindingList<Teacher> teachers = new BindingList<Teacher>();
        //use readonly as they are only set at form creation
        private readonly string _cnstr;
        private readonly DbContextOptionsBuilder _optionsBuilder;

        public Form1()
        {
            InitializeComponent();
            dgvResults.DataSource = teachers;
            _cnstr = Program._configuration["ConnectionStrings:SchoolOfFineArtsDB"];
            _optionsBuilder = new DbContextOptionsBuilder<SchoolOfFineArtsDBContext>().UseSqlServer(_cnstr);
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            bool modified = false;
            if (rdoTeacher.Checked)
            {
                var teacher = new Teacher();
                teacher.Id = Convert.ToInt32(Math.Round(numId.Value));
                teacher.FirstName = txtFirstName.Text;
                teacher.LastName = txtLastName.Text;
                teacher.Age = (int)numTeacherAge.Value;
                //Ensure teacher not in database
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (teacher.Id > 0)
                    {
                        var existingTeacher = context.Teachers.SingleOrDefault(t => t.Id == teacher.Id);
                        if (existingTeacher is not null)
                        {
                            existingTeacher.FirstName = teacher.FirstName;
                            existingTeacher.LastName = teacher.LastName;
                            existingTeacher.Age = teacher.Age;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher not found, could not update.");
                        }
                    }
                    else
                    {
                        var existingTeacher = context.Teachers.SingleOrDefault(t => t.FirstName.ToLower() == teacher.FirstName.ToLower()
                                                                 && t.LastName.ToLower() == teacher.LastName.ToLower()
                                                                 && t.Age == teacher.Age);
                        //if not add teacher
                        if (existingTeacher is null)
                        {
                            context.Teachers.Add(teacher);
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Teacher already exists, did you mean to update?");
                        }
                    }
                    if (modified)
                    {
                        ResetForm();
                        //var dbTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                        //dgvResults.DataSource = dbTeachers;
                        //dgvResults.Refresh();
                        LoadTeachers();
                    }
                }
            }
            else if (rdoStudent.Checked)
            {
                var s = new Student();
                s.Id = Convert.ToInt32(Math.Round(numId.Value));
                s.FirstName = txtFirstName.Text;
                s.LastName = txtLastName.Text;
                s.DateOfBirth = dtStudentDateOfBirth.Value.Date;
                //Ensure teacher not in database
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    if (s.Id > 0)
                    {
                        var existingStudent = context.Students.SingleOrDefault(t => t.Id == s.Id);
                        if (existingStudent is not null)
                        {
                            existingStudent.FirstName = s.FirstName;
                            existingStudent.LastName = s.LastName;
                            existingStudent.DateOfBirth = s.DateOfBirth;
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Student not found, could not update.");
                        }
                    }
                    else
                    {
                        var existingStudent = context.Students.SingleOrDefault(t => t.FirstName.ToLower() == s.FirstName.ToLower()
                                                                 && t.LastName.ToLower() == s.LastName.ToLower()
                                                                 && t.DateOfBirth == s.DateOfBirth);
                        //if not add teacher
                        if (existingStudent is null)
                        {
                            context.Students.Add(s);
                            context.SaveChanges();
                            modified = true;
                        }
                        else
                        {
                            MessageBox.Show("Student already exists, did you mean to update?");
                        }
                    }
                    if (modified)
                    {
                        ResetForm();
                        //var dbStudents = new BindingList<Student>(context.Students.ToList());
                        //dgvResults.DataSource = dbStudents;
                        //dgvResults.Refresh();
                        LoadStudents();
                    }
                }
            }
        }

        private void btnLoadTeachers_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }

        private void LoadTeachers(bool isSearch = false)
        {
            //take advantage of disposability of the connection and context:
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var databaseTeachers = new BindingList<Teacher>(context.Teachers.ToList());
                dgvResults.DataSource = databaseTeachers;
                dgvResults.Refresh();
            }
            if (!isSearch)
            {
                cbxInstructor.SelectedIndex = -1;
                cbxInstructor.Items.Clear();
                var data = dgvResults.DataSource as BindingList<Teacher>;
                cbxInstructor.Items.AddRange(data.ToArray <Teacher>());
                cbxInstructor.DisplayMember = "FriendlyName";
                cbxInstructor.ValueMember = "Id";

            }
        }

        private void btnLoadStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void LoadStudents()
        {
            //take advantage of disposability of the connection and context:
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var dbStudents = new BindingList<Student>(context.Students.ToList());
                dgvResults.DataSource = dbStudents;
                dgvResults.Refresh();
            }
        }

        private void rdoTeacher_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
            if (rdoTeacher.Checked)
            {
                LoadTeachers();
                ResetForm();
            }
        }

        private void ToggleControlVisibility()
        {
            lblAge.Visible = rdoTeacher.Checked;
            numTeacherAge.Visible = rdoTeacher.Checked;
            lblDateOfBirth.Visible = rdoStudent.Checked;
            dtStudentDateOfBirth.Visible = rdoStudent.Checked;
        }

        private void rdoStudent_CheckedChanged(object sender, EventArgs e)
        {
            ToggleControlVisibility();
            if (rdoStudent.Checked)
            {
                LoadStudents();
                ResetForm();
            }

        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvResults_CellClick(sender, e);
        }

        private void dgvResults_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var theRow = dgvResults.Rows[e.RowIndex];
            int dataId = 0;
            bool isTeacher = false;
            bool isStudent = false;
            foreach (DataGridViewTextBoxCell cell in theRow.Cells)
            {
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = (int)cell.Value;
                    if (dataId == 0)
                    {
                        MessageBox.Show("Bad row clicked");
                        ResetForm();
                        return;
                    }
                }
                if (cell.OwningColumn.Name.Equals("Age", StringComparison.OrdinalIgnoreCase))
                {
                    isTeacher = true;
                }

                if (cell.OwningColumn.Name.Equals("DateOfBirth", StringComparison.OrdinalIgnoreCase))
                {
                    isStudent = true;
                }
            }

            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                if (isTeacher)
                {
                    var d = context.Teachers.SingleOrDefault(x => x.Id == dataId);
                    if (d is not null)
                    {
                        numId.Value = d.Id;
                        txtFirstName.Text = d.FirstName;
                        txtLastName.Text = d.LastName;
                        numTeacherAge.Value = d.Age;

                        rdoTeacher.Checked = true;
                        rdoStudent.Checked = false;
                        ToggleControlVisibility();
                    }
                }
                else if (isStudent)
                {
                    var d = context.Students.SingleOrDefault(x => x.Id == dataId);
                    if (d is not null)
                    {
                        numId.Value = d.Id;
                        txtFirstName.Text = d.FirstName;
                        txtLastName.Text = d.LastName;
                        dtStudentDateOfBirth.Value = d.DateOfBirth;

                        rdoTeacher.Checked = false;
                        rdoStudent.Checked = true;
                        ToggleControlVisibility();
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var Id = (int)numId.Value;
            var confirmDelete = MessageBox.Show("Are you sure you want to delete this item?"
                , "Are you sure?"
                , MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.No)
            {
                return;
            }
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                if (rdoTeacher.Checked)
                {
                    var d = context.Teachers.SingleOrDefault(t => t.Id == Id);
                    if (d != null)
                    {
                        context.Teachers.Remove(d);
                        context.SaveChanges();
                        LoadTeachers();
                    }
                    else
                    {
                        MessageBox.Show("Teacher not found, couldn't delete!");
                    }
                }
                else if (rdoStudent.Checked)
                {
                    var d = context.Students.SingleOrDefault(s => s.Id == Id);
                    if (d != null)
                    {
                        context.Students.Remove(d);
                        context.SaveChanges();
                        LoadStudents();
                    }
                    else
                    {
                        MessageBox.Show("Student not found, couldn't delete!");
                    }
                }
                dgvResults.Refresh();
                ResetForm();
            }
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            numId.Value = 0;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            dgvResults.ClearSelection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadTeachers();
            ResetForm();
            ResetCourseForm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoTeacher.Checked)
            {
                LoadTeachers(true);
                var tList = dgvResults.DataSource as BindingList<Teacher>;
                var fList = tList.Where(x => x.LastName.ToLower().Contains(txtLastName.Text.ToLower())
                                            && x.FirstName.ToLower().Contains(txtFirstName.Text.ToLower())).ToList();
                dgvResults.DataSource = new BindingList<Teacher>(fList);
                dgvResults.ClearSelection();
            }
            else if (rdoStudent.Checked)
            {
                LoadStudents();
                var sList = dgvResults.DataSource as BindingList<Student>;
                var fList = sList.Where(x => x.LastName.ToLower().Contains(txtLastName.Text.ToLower())
                                            && x.FirstName.ToLower().Contains(txtFirstName.Text.ToLower())).ToList();
                dgvResults.DataSource = new BindingList<Student>(fList);
                dgvResults.ClearSelection();
            }
        }

        //Add courses:
        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            var teacher = (Teacher)cbxInstructor.SelectedItem;
            var teacherId = teacher.Id;
            var teacherIdOneLine = ((Teacher)cbxInstructor.SelectedItem).Id;
        }

        private void btnAddUpdate_Click(object sender, EventArgs e)
        {
            //var teacher = ((Teacher)cbxInstructor.SelectedItem).Id;
            //var teacher = new Teacher();
            //var teacher = (Teacher)cboxInstructor.SelectedItem;
            //var teacherId = teacher.Id;
            //var teacher = ((Teacher)cboxInstructor.SelectedItem).Id;
            bool modified = false;

            var course = new Course();
            course.Id = Convert.ToInt32(txtId.Text ?? "0");
            course.NumCredits = Convert.ToInt32(cbxNumberOfCredits.SelectedItem);
            course.Abbreviation = txtAbbreviation.Text;
            course.Department = txtDepartment.Text;
            course.TeacherId = ((Teacher)cbxInstructor.SelectedItem).Id;
            course.Name = txtCourseName.Text;

            //Ensure course is not in the database
            //using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))

            if (course.Id > 0)
            {
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var existingCourse = context.Courses.SingleOrDefault(t => t.Id == course.Id);

                    if (existingCourse != null)
                    {
                        existingCourse.NumCredits = course.NumCredits;
                        existingCourse.Abbreviation = course.Abbreviation;
                        existingCourse.Department = course.Department;
                        existingCourse.TeacherId = course.TeacherId;
                        existingCourse.Name = course.Name;
                        context.SaveChanges();
                        modified = true;
                    }
                    else
                    {
                        MessageBox.Show("Course not found, could not update.");
                    }
                }

            }
            else
            {
                using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
                {
                    var existingCourse = context.Courses.SingleOrDefault(c => c.Name.ToLower() == course.Name.ToLower()
                                                             && c.Abbreviation.ToLower() == course.Abbreviation.ToLower()
                                                             && c.TeacherId == course.TeacherId);
                    //if not add teacher
                    if (existingCourse == null)
                    {
                        context.Courses.Add(course);
                        context.SaveChanges();
                        modified = true;
                    }
                    else
                    {
                        MessageBox.Show("Course already exists, did you mean to update?");
                    }
                }

            }
            if (modified)
            {
                //reload teachers
                ResetCourseForm();
                LoadCourses();
            }
        }

        private void LoadCourses()
        {
            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var Courses = new BindingList<Course>(context.Courses.ToList());
                dgvCourses.DataSource = Courses;
                dgvCourses.Refresh();
            }
        }

        private void ResetCourseForm()
        {
            txtId.Text = "0";
            txtAbbreviation.Text = string.Empty;
            txtCourseName.Text = string.Empty;
            txtDepartment.Text = string.Empty;
            cbxInstructor.SelectedIndex = -1;
            cbxNumberOfCredits.SelectedIndex = 2;
        }

        private void btnResetCourseForm_Click(object sender, EventArgs e)
        {
            ResetCourseForm();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selIndex = ((TabControl)sender).SelectedIndex;
            switch (selIndex)
            {
                case 0:
                    //MessageBox.Show("Index 0");
                    break;
                case 1:
                    LoadCourses();
                    ResetCourseForm();
                    break;
                case 2:
                    //MessageBox.Show("Index 2");
                    break;
                default:
                    break;
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var theRow = dgvResults.Rows[e.RowIndex];
            int dataId = 0;

            foreach (DataGridViewTextBoxCell cell in theRow.Cells)
            {
                if (cell.OwningColumn.Name.Equals("Id", StringComparison.OrdinalIgnoreCase))
                {
                    dataId = (int)cell.Value;
                    if (dataId == 0)
                    {
                        MessageBox.Show("Bad row clicked");
                        ResetForm();
                        return;
                    }
                }
            }

            using (var context = new SchoolOfFineArtsDBContext(_optionsBuilder.Options))
            {
                var d = context.Courses.SingleOrDefault(x => x.Id == dataId);
                if (d is not null)
                {
                    txtId.Text = d.Id.ToString();
                    txtCourseName.Text = d.Name;
                    txtAbbreviation.Text = d.Abbreviation;
                    txtDepartment.Text = d.Department;
                    foreach(var item in cbxNumberOfCredits.Items)
                    {
                        if (Convert.ToInt32(item) == d.NumCredits)
                        {
                            cbxNumberOfCredits.SelectedItem = item;
                        }

                    }
                    foreach (var item in cbxInstructor.Items)
                    {
                        var t = (Teacher)item;
                        if (t.Id == d.TeacherId)
                        {
                            cbxInstructor.SelectedItem = item;
                        }

                    }

                }

            }
            
        }
    }

}