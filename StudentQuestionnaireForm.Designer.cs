
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
            this.comboBoxStudentClass = new System.Windows.Forms.ComboBox();
            this.customTextBoxStudentLastName = new sem3_lab1.CustomControls.CustomTextBox();
            this.customTextBoxStudentFirstName = new sem3_lab1.CustomControls.CustomTextBox();
            this.customTextBoxStudentMiddleName = new sem3_lab1.CustomControls.CustomTextBox();
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
            this.splitContainer1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1143, 750);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.SplitterWidth = 7;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStudent, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 443);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 292);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1135, 146);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // labelQuestionsQuantity
            // 
            this.labelQuestionsQuantity.AutoSize = true;
            this.labelQuestionsQuantity.Location = new System.Drawing.Point(4, 0);
            this.labelQuestionsQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionsQuantity.Name = "labelQuestionsQuantity";
            this.labelQuestionsQuantity.Size = new System.Drawing.Size(122, 23);
            this.labelQuestionsQuantity.TabIndex = 0;
            this.labelQuestionsQuantity.Text = "Количество:";
            // 
            // radioButtonQuestionsComplexityHard
            // 
            this.radioButtonQuestionsComplexityHard.AutoSize = true;
            this.radioButtonQuestionsComplexityHard.Location = new System.Drawing.Point(4, 53);
            this.radioButtonQuestionsComplexityHard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonQuestionsComplexityHard.Name = "radioButtonQuestionsComplexityHard";
            this.radioButtonQuestionsComplexityHard.Size = new System.Drawing.Size(105, 27);
            this.radioButtonQuestionsComplexityHard.TabIndex = 1;
            this.radioButtonQuestionsComplexityHard.TabStop = true;
            this.radioButtonQuestionsComplexityHard.Text = "Сложно";
            this.radioButtonQuestionsComplexityHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonQuestionsComplexityEasy
            // 
            this.radioButtonQuestionsComplexityEasy.AutoSize = true;
            this.radioButtonQuestionsComplexityEasy.Location = new System.Drawing.Point(571, 53);
            this.radioButtonQuestionsComplexityEasy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButtonQuestionsComplexityEasy.Name = "radioButtonQuestionsComplexityEasy";
            this.radioButtonQuestionsComplexityEasy.Size = new System.Drawing.Size(86, 27);
            this.radioButtonQuestionsComplexityEasy.TabIndex = 2;
            this.radioButtonQuestionsComplexityEasy.TabStop = true;
            this.radioButtonQuestionsComplexityEasy.Text = "Легко";
            this.radioButtonQuestionsComplexityEasy.UseVisualStyleBackColor = true;
            // 
            // numericUpDownQuestionsQuantity
            // 
            this.numericUpDownQuestionsQuantity.Location = new System.Drawing.Point(571, 5);
            this.numericUpDownQuestionsQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownQuestionsQuantity.Name = "numericUpDownQuestionsQuantity";
            this.numericUpDownQuestionsQuantity.Size = new System.Drawing.Size(171, 30);
            this.numericUpDownQuestionsQuantity.TabIndex = 3;
            // 
            // buttonStartTest
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.buttonStartTest, 2);
            this.buttonStartTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartTest.Location = new System.Drawing.Point(4, 101);
            this.buttonStartTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonStartTest.Name = "buttonStartTest";
            this.buttonStartTest.Size = new System.Drawing.Size(1127, 40);
            this.buttonStartTest.TabIndex = 4;
            this.buttonStartTest.Text = "Начать тестирование";
            this.buttonStartTest.UseVisualStyleBackColor = true;
            // 
            // groupBoxStudent
            // 
            this.groupBoxStudent.Controls.Add(this.tableLayoutPanelStudentInformation);
            this.groupBoxStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxStudent.Location = new System.Drawing.Point(4, 5);
            this.groupBoxStudent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStudent.Name = "groupBoxStudent";
            this.groupBoxStudent.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxStudent.Size = new System.Drawing.Size(1135, 277);
            this.groupBoxStudent.TabIndex = 1;
            this.groupBoxStudent.TabStop = false;
            this.groupBoxStudent.Text = "Студент";
            // 
            // tableLayoutPanelStudentInformation
            // 
            this.tableLayoutPanelStudentInformation.ColumnCount = 2;
            this.tableLayoutPanelStudentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tableLayoutPanelStudentInformation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentFirstName, 0, 1);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentMiddleName, 0, 2);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentClass, 0, 3);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.labelStudentLastName, 0, 0);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.comboBoxStudentClass, 1, 3);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.customTextBoxStudentLastName, 1, 0);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.customTextBoxStudentFirstName, 1, 1);
            this.tableLayoutPanelStudentInformation.Controls.Add(this.customTextBoxStudentMiddleName, 1, 2);
            this.tableLayoutPanelStudentInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStudentInformation.Location = new System.Drawing.Point(4, 28);
            this.tableLayoutPanelStudentInformation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelStudentInformation.Name = "tableLayoutPanelStudentInformation";
            this.tableLayoutPanelStudentInformation.RowCount = 4;
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelStudentInformation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanelStudentInformation.Size = new System.Drawing.Size(1127, 244);
            this.tableLayoutPanelStudentInformation.TabIndex = 0;
            // 
            // labelStudentFirstName
            // 
            this.labelStudentFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentFirstName.Location = new System.Drawing.Point(131, 89);
            this.labelStudentFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentFirstName.Name = "labelStudentFirstName";
            this.labelStudentFirstName.Size = new System.Drawing.Size(51, 27);
            this.labelStudentFirstName.TabIndex = 1;
            this.labelStudentFirstName.Text = "Имя:";
            this.labelStudentFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentMiddleName
            // 
            this.labelStudentMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentMiddleName.Location = new System.Drawing.Point(88, 147);
            this.labelStudentMiddleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentMiddleName.Name = "labelStudentMiddleName";
            this.labelStudentMiddleName.Size = new System.Drawing.Size(94, 27);
            this.labelStudentMiddleName.TabIndex = 2;
            this.labelStudentMiddleName.Text = "Отчество:";
            this.labelStudentMiddleName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentClass
            // 
            this.labelStudentClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentClass.Location = new System.Drawing.Point(115, 217);
            this.labelStudentClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentClass.Name = "labelStudentClass";
            this.labelStudentClass.Size = new System.Drawing.Size(67, 27);
            this.labelStudentClass.TabIndex = 3;
            this.labelStudentClass.Text = "Класс:";
            this.labelStudentClass.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelStudentLastName
            // 
            this.labelStudentLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStudentLastName.Location = new System.Drawing.Point(88, 31);
            this.labelStudentLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentLastName.Name = "labelStudentLastName";
            this.labelStudentLastName.Size = new System.Drawing.Size(94, 27);
            this.labelStudentLastName.TabIndex = 0;
            this.labelStudentLastName.Text = "Фамилия:";
            this.labelStudentLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxStudentClass
            // 
            this.comboBoxStudentClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStudentClass.FormattingEnabled = true;
            this.comboBoxStudentClass.Location = new System.Drawing.Point(190, 206);
            this.comboBoxStudentClass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxStudentClass.Name = "comboBoxStudentClass";
            this.comboBoxStudentClass.Size = new System.Drawing.Size(171, 31);
            this.comboBoxStudentClass.TabIndex = 7;
            // 
            // customTextBoxStudentLastName
            // 
            this.customTextBoxStudentLastName.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxStudentLastName.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.customTextBoxStudentLastName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.customTextBoxStudentLastName.BorderFocusedSize = 4;
            this.customTextBoxStudentLastName.BorderRadius = 20;
            this.customTextBoxStudentLastName.BorderSize = 2;
            this.customTextBoxStudentLastName.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTextBoxStudentLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxStudentLastName.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxStudentLastName.Location = new System.Drawing.Point(190, 5);
            this.customTextBoxStudentLastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBoxStudentLastName.Multiline = false;
            this.customTextBoxStudentLastName.Name = "customTextBoxStudentLastName";
            this.customTextBoxStudentLastName.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.customTextBoxStudentLastName.PasswordChar = false;
            this.customTextBoxStudentLastName.Size = new System.Drawing.Size(933, 48);
            this.customTextBoxStudentLastName.TabIndex = 8;
            this.customTextBoxStudentLastName.Texts = "";
            this.customTextBoxStudentLastName.UnderlinedStyle = false;
            // 
            // customTextBoxStudentFirstName
            // 
            this.customTextBoxStudentFirstName.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxStudentFirstName.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.customTextBoxStudentFirstName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.customTextBoxStudentFirstName.BorderFocusedSize = 4;
            this.customTextBoxStudentFirstName.BorderRadius = 20;
            this.customTextBoxStudentFirstName.BorderSize = 2;
            this.customTextBoxStudentFirstName.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTextBoxStudentFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxStudentFirstName.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxStudentFirstName.Location = new System.Drawing.Point(190, 63);
            this.customTextBoxStudentFirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBoxStudentFirstName.Multiline = false;
            this.customTextBoxStudentFirstName.Name = "customTextBoxStudentFirstName";
            this.customTextBoxStudentFirstName.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.customTextBoxStudentFirstName.PasswordChar = false;
            this.customTextBoxStudentFirstName.Size = new System.Drawing.Size(933, 48);
            this.customTextBoxStudentFirstName.TabIndex = 9;
            this.customTextBoxStudentFirstName.Texts = "";
            this.customTextBoxStudentFirstName.UnderlinedStyle = false;
            // 
            // customTextBoxStudentMiddleName
            // 
            this.customTextBoxStudentMiddleName.BackColor = System.Drawing.SystemColors.Window;
            this.customTextBoxStudentMiddleName.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.customTextBoxStudentMiddleName.BorderFocusColor = System.Drawing.Color.Goldenrod;
            this.customTextBoxStudentMiddleName.BorderFocusedSize = 4;
            this.customTextBoxStudentMiddleName.BorderRadius = 20;
            this.customTextBoxStudentMiddleName.BorderSize = 2;
            this.customTextBoxStudentMiddleName.Dock = System.Windows.Forms.DockStyle.Top;
            this.customTextBoxStudentMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customTextBoxStudentMiddleName.ForeColor = System.Drawing.Color.DimGray;
            this.customTextBoxStudentMiddleName.Location = new System.Drawing.Point(190, 121);
            this.customTextBoxStudentMiddleName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customTextBoxStudentMiddleName.Multiline = false;
            this.customTextBoxStudentMiddleName.Name = "customTextBoxStudentMiddleName";
            this.customTextBoxStudentMiddleName.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.customTextBoxStudentMiddleName.PasswordChar = false;
            this.customTextBoxStudentMiddleName.Size = new System.Drawing.Size(933, 48);
            this.customTextBoxStudentMiddleName.TabIndex = 10;
            this.customTextBoxStudentMiddleName.Texts = "";
            this.customTextBoxStudentMiddleName.UnderlinedStyle = false;
            // 
            // StudentQuestionnaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentQuestionnaireForm";
            this.Text = "Тестирование студентов";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuestionsQuantity)).EndInit();
            this.groupBoxStudent.ResumeLayout(false);
            this.tableLayoutPanelStudentInformation.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBoxStudentClass;
        private System.Windows.Forms.Label labelQuestionsQuantity;
        private System.Windows.Forms.RadioButton radioButtonQuestionsComplexityHard;
        private System.Windows.Forms.RadioButton radioButtonQuestionsComplexityEasy;
        private System.Windows.Forms.NumericUpDown numericUpDownQuestionsQuantity;
        private System.Windows.Forms.Button buttonStartTest;
        private CustomControls.CustomTextBox customTextBoxStudentLastName;
        private CustomControls.CustomTextBox customTextBoxStudentFirstName;
        private CustomControls.CustomTextBox customTextBoxStudentMiddleName;
    }
}

