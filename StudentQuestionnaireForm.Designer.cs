
namespace sem3_lab1
{
    partial class StudentQuestionnaireForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuestionsQuantity = new System.Windows.Forms.Label();
            this.radioButtonQuestionsComplexityHard = new System.Windows.Forms.RadioButton();
            this.radioButtonQuestionsComplexityEasy = new System.Windows.Forms.RadioButton();
            this.numericUpDownQuestionsQuantity = new System.Windows.Forms.NumericUpDown();
            this.buttonStartTest = new System.Windows.Forms.Button();
            this.groupBoxStudent = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelStudentInformation = new System.Windows.Forms.TableLayoutPanel();
            this.labelStudentFirstName = new System.Windows.Forms.Label();
            this.labelStudentMiddleName = new System.Windows.Forms.Label();
            this.labelStudentClass = new System.Windows.Forms.Label();
            this.labelStudentLastName = new System.Windows.Forms.Label();
            this.textBoxStudentLastName = new System.Windows.Forms.TextBox();
            this.textBoxStudentFirstName = new System.Windows.Forms.TextBox();
            this.textBoxStudentMiddleName = new System.Windows.Forms.TextBox();
            this.comboBoxStudentClass = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestionsQuantity)).BeginInit();
            this.groupBoxStudent.SuspendLayout();
            this.tableLayoutPanelStudentInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStudent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.labelQuestionsQuantity, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonQuestionsComplexityHard, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonQuestionsComplexityEasy, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownQuestionsQuantity, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonStartTest, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 136);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 127);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelQuestionsQuantity
            // 
            this.labelQuestionsQuantity.AutoSize = true;
            this.labelQuestionsQuantity.Location = new System.Drawing.Point(3, 0);
            this.labelQuestionsQuantity.Name = "labelQuestionsQuantity";
            this.labelQuestionsQuantity.Size = new System.Drawing.Size(75, 15);
            this.labelQuestionsQuantity.TabIndex = 0;
            this.labelQuestionsQuantity.Text = "Количество:";
            // 
            // radioButtonQuestionsComplexityHard
            // 
            this.radioButtonQuestionsComplexityHard.AutoSize = true;
            this.radioButtonQuestionsComplexityHard.Location = new System.Drawing.Point(3, 45);
            this.radioButtonQuestionsComplexityHard.Name = "radioButtonQuestionsComplexityHard";
            this.radioButtonQuestionsComplexityHard.Size = new System.Drawing.Size(70, 19);
            this.radioButtonQuestionsComplexityHard.TabIndex = 1;
            this.radioButtonQuestionsComplexityHard.TabStop = true;
            this.radioButtonQuestionsComplexityHard.Text = "Сложно";
            this.radioButtonQuestionsComplexityHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestionsComplexityEasy
            // 
            this.radioButtonQuestionsComplexityEasy.AutoSize = true;
            this.radioButtonQuestionsComplexityEasy.Location = new System.Drawing.Point(400, 45);
            this.radioButtonQuestionsComplexityEasy.Name = "radioButtonQuestionsComplexityEasy";
            this.radioButtonQuestionsComplexityEasy.Size = new System.Drawing.Size(57, 19);
            this.radioButtonQuestionsComplexityEasy.TabIndex = 2;
            this.radioButtonQuestionsComplexityEasy.TabStop = true;
            this.radioButtonQuestionsComplexityEasy.Text = "Легко";
            this.radioButtonQuestionsComplexityEasy.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuestionsQuantity
            // 
            this.numericUpDownQuestionsQuantity.Location = new System.Drawing.Point(400, 3);
            this.numericUpDownQuestionsQuantity.Name = "numericUpDownQuestionsQuantity";
            this.numericUpDownQuestionsQuantity.Size = new System.Drawing.Size(120, 23);
            this.numericUpDownQuestionsQuantity.TabIndex = 3;
            // 
            // buttonStartTest
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonStartTest, 2);
            this.buttonStartTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartTest.Location = new System.Drawing.Point(3, 87);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(788, 37);
            this.buttonStartTest.TabIndex = 4;
            this.buttonStartTest.Text = "Начать тестирование";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.tableLayoutPanelStudentInformation);
            this.groupBoxStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStudent.Location = new System.Drawing.Point(3, 3);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Size = new System.Drawing.Size(794, 127);
            this.groupBoxStudent.TabIndex = 1;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Студент";
            // 
            // tableLayoutPanelStudentInformation
            // 
            this.tableLayoutPanelStudentInformation.ColumnCount = 2;
            this.tableLayoutPanelStudentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanelStudentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentFirstName, 0, 1);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentMiddleName, 0, 2);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentClass, 0, 3);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentLastName, 0, 0);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.textBoxStudentLastName, 1, 0);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.textBoxStudentFirstName, 1, 1);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.textBoxStudentMiddleName, 1, 2);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.comboBoxStudentClass, 1, 3);
            this.tableLayoutPanelStudentInformation.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanelStudentInformation.Name = "tableLayoutPanelStudentInformation";
            this.tableLayoutPanelStudentInformation.RowCount = 4;
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelStudentInformation.Size = new System.Drawing.Size(788, 105);
            this.tableLayoutPanelStudentInformation.TabIndex = 0;
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.AutoSize = true;
            this.labelStudentFirstName.Location = new System.Drawing.Point(3, 26);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(34, 15);
            this.labelStudentFirstName.TabIndex = 1;
            this.labelStudentFirstName.Text = "Имя:";
            // 
            // labelStudentMiddleName
            // 
            this.labelStudentMiddleName.AutoSize = true;
            this.labelStudentMiddleName.Location = new System.Drawing.Point(3, 52);
            this.labelStudentMiddleName.Name = "labelStudentMiddleName";
            this.labelStudentMiddleName.Size = new System.Drawing.Size(61, 15);
            this.labelStudentMiddleName.TabIndex = 2;
            this.labelStudentMiddleName.Text = "Отчество:";
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.AutoSize = true;
            this.labelStudentClass.Location = new System.Drawing.Point(3, 78);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(42, 15);
            this.labelStudentClass.TabIndex = 3;
            this.labelStudentClass.Text = "Класс:";
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.AutoSize = true;
            this.labelStudentLastName.Location = new System.Drawing.Point(3, 0);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(61, 15);
            this.labelStudentLastName.TabIndex = 0;
            this.labelStudentLastName.Text = "Фамилия:";
            // 
            // textBoxStudentLastName
            // 
            this.textBoxStudentLastName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentLastName.Location = new System.Drawing.Point(133, 3);
            this.textBoxStudentLastName.Name = "textBoxStudentLastName";
            this.textBoxStudentLastName.Size = new System.Drawing.Size(652, 23);
            this.textBoxStudentLastName.TabIndex = 4;
            // 
            // textBoxStudentFirstName
            // 
            this.textBoxStudentFirstName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentFirstName.Location = new System.Drawing.Point(133, 29);
            this.textBoxStudentFirstName.Name = "textBoxStudentFirstName";
            this.textBoxStudentFirstName.Size = new System.Drawing.Size(652, 23);
            this.textBoxStudentFirstName.TabIndex = 5;
            // 
            // textBoxStudentMiddleName
            // 
            this.textBoxStudentMiddleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxStudentMiddleName.Location = new System.Drawing.Point(133, 55);
            this.textBoxStudentMiddleName.Name = "textBoxStudentMiddleName";
            this.textBoxStudentMiddleName.Size = new System.Drawing.Size(652, 23);
            this.textBoxStudentMiddleName.TabIndex = 6;
            // 
            // comboBoxStudentClass
            // 
            this.comboBoxStudentClass.FormattingEnabled = true;
            this.comboBoxStudentClass.Location = new System.Drawing.Point(133, 81);
            this.comboBoxStudentClass.Name = "comboBoxStudentClass";
            this.comboBoxStudentClass.Size = new System.Drawing.Size(121, 23);
            this.comboBoxStudentClass.TabIndex = 7;
            // 
            // StudentQuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "StudentQuestionnaireForm";
            this.Text = "Анкета студента";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestionsQuantity)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.tableLayoutPanelStudentInformation.ResumeLayout(false);
            this.tableLayoutPanelStudentInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStudentInformation;
        private System.Windows.Forms.Label labelStudentLastName;
        private System.Windows.Forms.Label labelStudentFirstName;
        private System.Windows.Forms.Label labelStudentMiddleName;
        private System.Windows.Forms.Label labelStudentClass;
        private System.Windows.Forms.TextBox textBoxStudentLastName;
        private System.Windows.Forms.TextBox textBoxStudentFirstName;
        private System.Windows.Forms.TextBox textBoxStudentMiddleName;
        private System.Windows.Forms.ComboBox comboBoxStudentClass;
        private System.Windows.Forms.Label labelQuestionsQuantity;
        private System.Windows.Forms.RadioButton radioButtonQuestionsComplexityHard;
        private System.Windows.Forms.RadioButton radioButtonQuestionsComplexityEasy;
        private System.Windows.Forms.NumericUpDown numericUpDownQuestionsQuantity;
        private System.Windows.Forms.Button buttonStartTest;
    }
}

