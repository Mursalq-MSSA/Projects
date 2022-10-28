namespace SchoolOfFineArts
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoTeacher = new System.Windows.Forms.RadioButton();
            this.rdoStudent = new System.Windows.Forms.RadioButton();
            this.btnLoadTeachers = new System.Windows.Forms.Button();
            this.numTeacherAge = new System.Windows.Forms.NumericUpDown();
            this.lblAge = new System.Windows.Forms.Label();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.dtStudentDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.btnResetCourseForm = new System.Windows.Forms.Button();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.btnLoadCourse = new System.Windows.Forms.Button();
            this.cbxInstructor = new System.Windows.Forms.ComboBox();
            this.cbxNumberOfCredits = new System.Windows.Forms.ComboBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtAbbreviation = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.seedTeacherTableDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedTeacherTableDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(541, 197);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(164, 38);
            this.btnResetForm.TabIndex = 47;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(203, 323);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(166, 38);
            this.btnDelete.TabIndex = 46;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLoadStudents
            // 
            this.btnLoadStudents.Location = new System.Drawing.Point(539, 137);
            this.btnLoadStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(166, 38);
            this.btnLoadStudents.TabIndex = 45;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoTeacher);
            this.panel1.Controls.Add(this.rdoStudent);
            this.panel1.Location = new System.Drawing.Point(76, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 48);
            this.panel1.TabIndex = 44;
            // 
            // rdoTeacher
            // 
            this.rdoTeacher.AutoSize = true;
            this.rdoTeacher.Checked = true;
            this.rdoTeacher.Location = new System.Drawing.Point(21, 12);
            this.rdoTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoTeacher.Name = "rdoTeacher";
            this.rdoTeacher.Size = new System.Drawing.Size(95, 29);
            this.rdoTeacher.TabIndex = 25;
            this.rdoTeacher.TabStop = true;
            this.rdoTeacher.Text = "Teacher";
            this.rdoTeacher.UseVisualStyleBackColor = true;
            this.rdoTeacher.CheckedChanged += new System.EventHandler(this.rdoTeacher_CheckedChanged);
            // 
            // rdoStudent
            // 
            this.rdoStudent.AutoSize = true;
            this.rdoStudent.Location = new System.Drawing.Point(123, 12);
            this.rdoStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoStudent.Name = "rdoStudent";
            this.rdoStudent.Size = new System.Drawing.Size(98, 29);
            this.rdoStudent.TabIndex = 26;
            this.rdoStudent.Text = "Student";
            this.rdoStudent.UseVisualStyleBackColor = true;
            this.rdoStudent.CheckedChanged += new System.EventHandler(this.rdoStudent_CheckedChanged);
            // 
            // btnLoadTeachers
            // 
            this.btnLoadTeachers.Location = new System.Drawing.Point(539, 83);
            this.btnLoadTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadTeachers.Name = "btnLoadTeachers";
            this.btnLoadTeachers.Size = new System.Drawing.Size(166, 38);
            this.btnLoadTeachers.TabIndex = 43;
            this.btnLoadTeachers.Text = "Load Teachers";
            this.btnLoadTeachers.UseVisualStyleBackColor = true;
            this.btnLoadTeachers.Click += new System.EventHandler(this.btnLoadTeachers_Click);
            // 
            // numTeacherAge
            // 
            this.numTeacherAge.Location = new System.Drawing.Point(169, 263);
            this.numTeacherAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numTeacherAge.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.numTeacherAge.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTeacherAge.Name = "numTeacherAge";
            this.numTeacherAge.Size = new System.Drawing.Size(236, 31);
            this.numTeacherAge.TabIndex = 42;
            this.numTeacherAge.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(24, 268);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(48, 25);
            this.lblAge.TabIndex = 41;
            this.lblAge.Text = "Age:";
            // 
            // dgvResults
            // 
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(23, 388);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.RowHeadersWidth = 62;
            this.dgvResults.RowTemplate.Height = 25;
            this.dgvResults.Size = new System.Drawing.Size(683, 237);
            this.dgvResults.TabIndex = 40;
            this.dgvResults.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResults_CellClick);
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(166, 92);
            this.numId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numId.Maximum = new decimal(new int[] {
            2147000000,
            0,
            0,
            0});
            this.numId.Name = "numId";
            this.numId.ReadOnly = true;
            this.numId.Size = new System.Drawing.Size(236, 31);
            this.numId.TabIndex = 39;
            // 
            // dtStudentDateOfBirth
            // 
            this.dtStudentDateOfBirth.Location = new System.Drawing.Point(169, 263);
            this.dtStudentDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtStudentDateOfBirth.Name = "dtStudentDateOfBirth";
            this.dtStudentDateOfBirth.Size = new System.Drawing.Size(284, 31);
            this.dtStudentDateOfBirth.TabIndex = 38;
            this.dtStudentDateOfBirth.Visible = false;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(23, 323);
            this.btnAddTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(166, 38);
            this.btnAddTeacher.TabIndex = 37;
            this.btnAddTeacher.Text = "Add or Update";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 200);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(237, 31);
            this.txtLastName.TabIndex = 36;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 142);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(237, 31);
            this.txtFirstName.TabIndex = 35;
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(24, 268);
            this.lblDateOfBirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(119, 25);
            this.lblDateOfBirth.TabIndex = 34;
            this.lblDateOfBirth.Text = "Date Of Birth:";
            this.lblDateOfBirth.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Id:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(541, 255);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(164, 38);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(909, 700);
            this.tabControl1.TabIndex = 49;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvResults);
            this.tabPage1.Controls.Add(this.btnSearch);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnResetForm);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnLoadStudents);
            this.tabPage1.Controls.Add(this.lblDateOfBirth);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.btnLoadTeachers);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.numTeacherAge);
            this.tabPage1.Controls.Add(this.btnAddTeacher);
            this.tabPage1.Controls.Add(this.lblAge);
            this.tabPage1.Controls.Add(this.dtStudentDateOfBirth);
            this.tabPage1.Controls.Add(this.numId);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(901, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student & Teachers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddUpdate);
            this.tabPage2.Controls.Add(this.dgvCourses);
            this.tabPage2.Controls.Add(this.btnResetCourseForm);
            this.tabPage2.Controls.Add(this.btnRemoveCourse);
            this.tabPage2.Controls.Add(this.btnLoadCourse);
            this.tabPage2.Controls.Add(this.cbxInstructor);
            this.tabPage2.Controls.Add(this.cbxNumberOfCredits);
            this.tabPage2.Controls.Add(this.txtDepartment);
            this.tabPage2.Controls.Add(this.txtAbbreviation);
            this.tabPage2.Controls.Add(this.txtCourseName);
            this.tabPage2.Controls.Add(this.txtId);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(901, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(23, 304);
            this.btnAddUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(200, 38);
            this.btnAddUpdate.TabIndex = 17;
            this.btnAddUpdate.Text = "Add/Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // dgvCourses
            // 
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Location = new System.Drawing.Point(457, 75);
            this.dgvCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.RowHeadersWidth = 62;
            this.dgvCourses.RowTemplate.Height = 25;
            this.dgvCourses.Size = new System.Drawing.Size(343, 250);
            this.dgvCourses.TabIndex = 16;
            this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
            // 
            // btnResetCourseForm
            // 
            this.btnResetCourseForm.Location = new System.Drawing.Point(23, 503);
            this.btnResetCourseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResetCourseForm.Name = "btnResetCourseForm";
            this.btnResetCourseForm.Size = new System.Drawing.Size(200, 38);
            this.btnResetCourseForm.TabIndex = 15;
            this.btnResetCourseForm.Text = "Reset Course Form";
            this.btnResetCourseForm.UseVisualStyleBackColor = true;
            this.btnResetCourseForm.Click += new System.EventHandler(this.btnResetCourseForm_Click);
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(23, 437);
            this.btnRemoveCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(200, 38);
            this.btnRemoveCourse.TabIndex = 14;
            this.btnRemoveCourse.Text = "Remove Course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            // 
            // btnLoadCourse
            // 
            this.btnLoadCourse.Location = new System.Drawing.Point(23, 370);
            this.btnLoadCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLoadCourse.Name = "btnLoadCourse";
            this.btnLoadCourse.Size = new System.Drawing.Size(200, 38);
            this.btnLoadCourse.TabIndex = 13;
            this.btnLoadCourse.Text = "Load Course";
            this.btnLoadCourse.UseVisualStyleBackColor = true;
            // 
            // cbxInstructor
            // 
            this.cbxInstructor.FormattingEnabled = true;
            this.cbxInstructor.Location = new System.Drawing.Point(197, 235);
            this.cbxInstructor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxInstructor.Name = "cbxInstructor";
            this.cbxInstructor.Size = new System.Drawing.Size(171, 33);
            this.cbxInstructor.TabIndex = 11;
            // 
            // cbxNumberOfCredits
            // 
            this.cbxNumberOfCredits.FormattingEnabled = true;
            this.cbxNumberOfCredits.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxNumberOfCredits.Location = new System.Drawing.Point(197, 188);
            this.cbxNumberOfCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxNumberOfCredits.Name = "cbxNumberOfCredits";
            this.cbxNumberOfCredits.Size = new System.Drawing.Size(171, 33);
            this.cbxNumberOfCredits.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(197, 142);
            this.txtDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(141, 31);
            this.txtDepartment.TabIndex = 9;
            // 
            // txtAbbreviation
            // 
            this.txtAbbreviation.Location = new System.Drawing.Point(197, 97);
            this.txtAbbreviation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAbbreviation.Name = "txtAbbreviation";
            this.txtAbbreviation.Size = new System.Drawing.Size(141, 31);
            this.txtAbbreviation.TabIndex = 8;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(197, 53);
            this.txtCourseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(141, 31);
            this.txtCourseName.TabIndex = 7;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(197, 10);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 31);
            this.txtId.TabIndex = 6;
            this.txtId.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 248);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Instructor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 202);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Credits:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 25);
            this.label7.TabIndex = 3;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Abbreviation:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Course Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID:";
            // 
            // seedTeacherTableDataBindingSource
            // 
            this.seedTeacherTableDataBindingSource.DataSource = typeof(SchoolOfFineArtsDB.Migrations.SeedTeacherTableData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 685);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTeacherAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedTeacherTableDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnResetForm;
        private Button btnDelete;
        private Button btnLoadStudents;
        private Panel panel1;
        private RadioButton rdoTeacher;
        private RadioButton rdoStudent;
        private Button btnLoadTeachers;
        private NumericUpDown numTeacherAge;
        private Label lblAge;
        private DataGridView dgvResults;
        private NumericUpDown numId;
        private DateTimePicker dtStudentDateOfBirth;
        private Button btnAddTeacher;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblDateOfBirth;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSearch;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView dgvCourses;
        private Button btnResetCourseForm;
        private Button btnRemoveCourse;
        private Button btnLoadCourse;
        private ComboBox cbxInstructor;
        private ComboBox cbxNumberOfCredits;
        private TextBox txtDepartment;
        private TextBox txtAbbreviation;
        private TextBox txtCourseName;
        private TextBox txtId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private BindingSource seedTeacherTableDataBindingSource;
        private Button btnAddUpdate;
    }
}