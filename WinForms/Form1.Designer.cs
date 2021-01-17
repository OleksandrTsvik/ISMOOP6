namespace WinForms
{
    partial class FormStudents
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPatronymic = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelCourse = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.numericUpDownCourse = new System.Windows.Forms.NumericUpDown();
            this.listBoxInformationAboutAllStudents = new System.Windows.Forms.ListBox();
            this.labelInformationAboutAllStudents = new System.Windows.Forms.Label();
            this.labelRemovalStudent = new System.Windows.Forms.Label();
            this.numericUpDownStudentNumberDelete = new System.Windows.Forms.NumericUpDown();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelStudentsNumber = new System.Windows.Forms.Label();
            this.labelResultsExams = new System.Windows.Forms.Label();
            this.labelLesson = new System.Windows.Forms.Label();
            this.textBoxLesson = new System.Windows.Forms.TextBox();
            this.numericUpDownPoint = new System.Windows.Forms.NumericUpDown();
            this.listBoxLessonAndPoint = new System.Windows.Forms.ListBox();
            this.labelPoint = new System.Windows.Forms.Label();
            this.buttonAddLessonAndPoint = new System.Windows.Forms.Button();
            this.labelEvent = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelDemonstrationOfWork = new System.Windows.Forms.Label();
            this.pictureBoxDemonstrationOfWork = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentNumberDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDemonstrationOfWork)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStudent.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddStudent.Location = new System.Drawing.Point(12, 523);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(592, 43);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Додати студента";
            this.buttonAddStudent.UseVisualStyleBackColor = false;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(12, 18);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(47, 24);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Ім\'я:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(12, 56);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(97, 24);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Прізвище:";
            // 
            // labelPatronymic
            // 
            this.labelPatronymic.AutoSize = true;
            this.labelPatronymic.Location = new System.Drawing.Point(12, 94);
            this.labelPatronymic.Name = "labelPatronymic";
            this.labelPatronymic.Size = new System.Drawing.Size(116, 24);
            this.labelPatronymic.TabIndex = 3;
            this.labelPatronymic.Text = "По батькові:";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 132);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(63, 24);
            this.labelGroup.TabIndex = 4;
            this.labelGroup.Text = "Група:";
            // 
            // labelCourse
            // 
            this.labelCourse.AutoSize = true;
            this.labelCourse.Location = new System.Drawing.Point(12, 170);
            this.labelCourse.Name = "labelCourse";
            this.labelCourse.Size = new System.Drawing.Size(54, 24);
            this.labelCourse.TabIndex = 5;
            this.labelCourse.Text = "Курс:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(134, 15);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(294, 32);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(134, 53);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(294, 32);
            this.textBoxLastName.TabIndex = 8;
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.Location = new System.Drawing.Point(134, 91);
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(294, 32);
            this.textBoxPatronymic.TabIndex = 9;
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(134, 130);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(294, 32);
            this.textBoxGroup.TabIndex = 10;
            // 
            // numericUpDownCourse
            // 
            this.numericUpDownCourse.Location = new System.Drawing.Point(134, 168);
            this.numericUpDownCourse.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownCourse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCourse.Name = "numericUpDownCourse";
            this.numericUpDownCourse.Size = new System.Drawing.Size(294, 32);
            this.numericUpDownCourse.TabIndex = 11;
            this.numericUpDownCourse.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // listBoxInformationAboutAllStudents
            // 
            this.listBoxInformationAboutAllStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxInformationAboutAllStudents.FormattingEnabled = true;
            this.listBoxInformationAboutAllStudents.HorizontalScrollbar = true;
            this.listBoxInformationAboutAllStudents.ItemHeight = 24;
            this.listBoxInformationAboutAllStudents.Location = new System.Drawing.Point(631, 40);
            this.listBoxInformationAboutAllStudents.Name = "listBoxInformationAboutAllStudents";
            this.listBoxInformationAboutAllStudents.Size = new System.Drawing.Size(674, 508);
            this.listBoxInformationAboutAllStudents.TabIndex = 12;
            // 
            // labelInformationAboutAllStudents
            // 
            this.labelInformationAboutAllStudents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInformationAboutAllStudents.AutoSize = true;
            this.labelInformationAboutAllStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelInformationAboutAllStudents.Location = new System.Drawing.Point(627, 13);
            this.labelInformationAboutAllStudents.Name = "labelInformationAboutAllStudents";
            this.labelInformationAboutAllStudents.Size = new System.Drawing.Size(267, 24);
            this.labelInformationAboutAllStudents.TabIndex = 13;
            this.labelInformationAboutAllStudents.Text = "Інформація про всіх студентів";
            // 
            // labelRemovalStudent
            // 
            this.labelRemovalStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelRemovalStudent.AutoSize = true;
            this.labelRemovalStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelRemovalStudent.Location = new System.Drawing.Point(12, 588);
            this.labelRemovalStudent.Name = "labelRemovalStudent";
            this.labelRemovalStudent.Size = new System.Drawing.Size(183, 24);
            this.labelRemovalStudent.TabIndex = 14;
            this.labelRemovalStudent.Text = "Видалення студента";
            // 
            // numericUpDownStudentNumberDelete
            // 
            this.numericUpDownStudentNumberDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numericUpDownStudentNumberDelete.Location = new System.Drawing.Point(170, 615);
            this.numericUpDownStudentNumberDelete.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStudentNumberDelete.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStudentNumberDelete.Name = "numericUpDownStudentNumberDelete";
            this.numericUpDownStudentNumberDelete.Size = new System.Drawing.Size(111, 32);
            this.numericUpDownStudentNumberDelete.TabIndex = 15;
            this.numericUpDownStudentNumberDelete.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonRemove
            // 
            this.buttonRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonRemove.Location = new System.Drawing.Point(299, 615);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(144, 32);
            this.buttonRemove.TabIndex = 16;
            this.buttonRemove.Text = "Видалити";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(1227, 611);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(78, 35);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelStudentsNumber
            // 
            this.labelStudentsNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStudentsNumber.AutoSize = true;
            this.labelStudentsNumber.Location = new System.Drawing.Point(12, 617);
            this.labelStudentsNumber.Name = "labelStudentsNumber";
            this.labelStudentsNumber.Size = new System.Drawing.Size(152, 24);
            this.labelStudentsNumber.TabIndex = 18;
            this.labelStudentsNumber.Text = "Номер студента:";
            // 
            // labelResultsExams
            // 
            this.labelResultsExams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultsExams.AutoSize = true;
            this.labelResultsExams.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelResultsExams.Location = new System.Drawing.Point(12, 317);
            this.labelResultsExams.Name = "labelResultsExams";
            this.labelResultsExams.Size = new System.Drawing.Size(514, 24);
            this.labelResultsExams.TabIndex = 19;
            this.labelResultsExams.Text = "Результати здачі заліків та екзаменів по 100-бальній шкалі";
            // 
            // labelLesson
            // 
            this.labelLesson.AutoSize = true;
            this.labelLesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelLesson.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLesson.Location = new System.Drawing.Point(12, 209);
            this.labelLesson.Name = "labelLesson";
            this.labelLesson.Size = new System.Drawing.Size(80, 21);
            this.labelLesson.TabIndex = 20;
            this.labelLesson.Text = "Предмет";
            // 
            // textBoxLesson
            // 
            this.textBoxLesson.Location = new System.Drawing.Point(12, 233);
            this.textBoxLesson.Name = "textBoxLesson";
            this.textBoxLesson.Size = new System.Drawing.Size(416, 32);
            this.textBoxLesson.TabIndex = 22;
            // 
            // numericUpDownPoint
            // 
            this.numericUpDownPoint.Location = new System.Drawing.Point(438, 233);
            this.numericUpDownPoint.Name = "numericUpDownPoint";
            this.numericUpDownPoint.Size = new System.Drawing.Size(120, 32);
            this.numericUpDownPoint.TabIndex = 23;
            // 
            // listBoxLessonAndPoint
            // 
            this.listBoxLessonAndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxLessonAndPoint.FormattingEnabled = true;
            this.listBoxLessonAndPoint.ItemHeight = 24;
            this.listBoxLessonAndPoint.Location = new System.Drawing.Point(12, 344);
            this.listBoxLessonAndPoint.Name = "listBoxLessonAndPoint";
            this.listBoxLessonAndPoint.Size = new System.Drawing.Size(592, 172);
            this.listBoxLessonAndPoint.TabIndex = 24;
            // 
            // labelPoint
            // 
            this.labelPoint.AutoSize = true;
            this.labelPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.labelPoint.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPoint.Location = new System.Drawing.Point(434, 209);
            this.labelPoint.Name = "labelPoint";
            this.labelPoint.Size = new System.Drawing.Size(37, 21);
            this.labelPoint.TabIndex = 25;
            this.labelPoint.Text = "Бал";
            // 
            // buttonAddLessonAndPoint
            // 
            this.buttonAddLessonAndPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonAddLessonAndPoint.Location = new System.Drawing.Point(12, 271);
            this.buttonAddLessonAndPoint.Name = "buttonAddLessonAndPoint";
            this.buttonAddLessonAndPoint.Size = new System.Drawing.Size(543, 34);
            this.buttonAddLessonAndPoint.TabIndex = 26;
            this.buttonAddLessonAndPoint.Text = "Додати предмет та бал";
            this.buttonAddLessonAndPoint.UseVisualStyleBackColor = false;
            this.buttonAddLessonAndPoint.Click += new System.EventHandler(this.buttonAddLessonAndPoint_Click);
            // 
            // labelEvent
            // 
            this.labelEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEvent.AutoSize = true;
            this.labelEvent.BackColor = System.Drawing.Color.Silver;
            this.labelEvent.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEvent.Location = new System.Drawing.Point(625, 561);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(105, 31);
            this.labelEvent.TabIndex = 27;
            this.labelEvent.Text = "Подія: ...";
            // 
            // labelDemonstrationOfWork
            // 
            this.labelDemonstrationOfWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDemonstrationOfWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.labelDemonstrationOfWork.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDemonstrationOfWork.Location = new System.Drawing.Point(628, 602);
            this.labelDemonstrationOfWork.Name = "labelDemonstrationOfWork";
            this.labelDemonstrationOfWork.Size = new System.Drawing.Size(499, 44);
            this.labelDemonstrationOfWork.TabIndex = 29;
            this.labelDemonstrationOfWork.Text = "Фото-інструкція до програми: натисніть на картинку щоб збільшити, натисніть ще ра" +
    "з на картинку щоб зменшити.  --->";
            // 
            // pictureBoxDemonstrationOfWork
            // 
            this.pictureBoxDemonstrationOfWork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDemonstrationOfWork.BackColor = System.Drawing.Color.Black;
            this.pictureBoxDemonstrationOfWork.Image = global::WinForms.Properties.Resources.demonstration_of_work1;
            this.pictureBoxDemonstrationOfWork.Location = new System.Drawing.Point(1136, 602);
            this.pictureBoxDemonstrationOfWork.Name = "pictureBoxDemonstrationOfWork";
            this.pictureBoxDemonstrationOfWork.Padding = new System.Windows.Forms.Padding(2);
            this.pictureBoxDemonstrationOfWork.Size = new System.Drawing.Size(64, 44);
            this.pictureBoxDemonstrationOfWork.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDemonstrationOfWork.TabIndex = 28;
            this.pictureBoxDemonstrationOfWork.TabStop = false;
            this.pictureBoxDemonstrationOfWork.Click += new System.EventHandler(this.pictureBoxDemonstrationOfWork_Click);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 658);
            this.Controls.Add(this.labelDemonstrationOfWork);
            this.Controls.Add(this.pictureBoxDemonstrationOfWork);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.buttonAddLessonAndPoint);
            this.Controls.Add(this.labelPoint);
            this.Controls.Add(this.listBoxLessonAndPoint);
            this.Controls.Add(this.numericUpDownPoint);
            this.Controls.Add(this.textBoxLesson);
            this.Controls.Add(this.labelLesson);
            this.Controls.Add(this.labelResultsExams);
            this.Controls.Add(this.labelStudentsNumber);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.numericUpDownStudentNumberDelete);
            this.Controls.Add(this.labelRemovalStudent);
            this.Controls.Add(this.labelInformationAboutAllStudents);
            this.Controls.Add(this.listBoxInformationAboutAllStudents);
            this.Controls.Add(this.numericUpDownCourse);
            this.Controls.Add(this.textBoxGroup);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelCourse);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.labelPatronymic);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.buttonAddStudent);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1335, 705);
            this.Name = "FormStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCourse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStudentNumberDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDemonstrationOfWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPatronymic;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelCourse;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPatronymic;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.NumericUpDown numericUpDownCourse;
        private System.Windows.Forms.ListBox listBoxInformationAboutAllStudents;
        private System.Windows.Forms.Label labelInformationAboutAllStudents;
        private System.Windows.Forms.Label labelRemovalStudent;
        private System.Windows.Forms.NumericUpDown numericUpDownStudentNumberDelete;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelStudentsNumber;
        private System.Windows.Forms.Label labelResultsExams;
        private System.Windows.Forms.Label labelLesson;
        private System.Windows.Forms.TextBox textBoxLesson;
        private System.Windows.Forms.NumericUpDown numericUpDownPoint;
        private System.Windows.Forms.ListBox listBoxLessonAndPoint;
        private System.Windows.Forms.Label labelPoint;
        private System.Windows.Forms.Button buttonAddLessonAndPoint;
        private System.Windows.Forms.Label labelEvent;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBoxDemonstrationOfWork;
        private System.Windows.Forms.Label labelDemonstrationOfWork;
    }
}

