namespace PatientLIst
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
            this.patient_list = new System.Windows.Forms.GroupBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gender_box = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.address_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.waitingList = new System.Windows.Forms.ListBox();
            this.NextBt = new System.Windows.Forms.Button();
            this.DoctorViewBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.patient_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // patient_list
            // 
            this.patient_list.Controls.Add(this.add_btn);
            this.patient_list.Controls.Add(this.label3);
            this.patient_list.Controls.Add(this.gender_box);
            this.patient_list.Controls.Add(this.label2);
            this.patient_list.Controls.Add(this.address_box);
            this.patient_list.Controls.Add(this.label1);
            this.patient_list.Controls.Add(this.name_textBox);
            this.patient_list.Location = new System.Drawing.Point(161, 72);
            this.patient_list.Name = "patient_list";
            this.patient_list.Size = new System.Drawing.Size(359, 199);
            this.patient_list.TabIndex = 0;
            this.patient_list.TabStop = false;
            this.patient_list.Text = "Add Patient to the waiting list";
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(254, 163);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 6;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "gender";
            // 
            // gender_box
            // 
            this.gender_box.FormattingEnabled = true;
            this.gender_box.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender_box.Location = new System.Drawing.Point(210, 104);
            this.gender_box.Name = "gender_box";
            this.gender_box.Size = new System.Drawing.Size(121, 23);
            this.gender_box.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "address";
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(204, 66);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(129, 23);
            this.address_box.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "name";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(204, 26);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(129, 23);
            this.name_textBox.TabIndex = 0;
            // 
            // waitingList
            // 
            this.waitingList.FormattingEnabled = true;
            this.waitingList.ItemHeight = 15;
            this.waitingList.Location = new System.Drawing.Point(36, 297);
            this.waitingList.Name = "waitingList";
            this.waitingList.Size = new System.Drawing.Size(164, 139);
            this.waitingList.TabIndex = 1;
            // 
            // NextBt
            // 
            this.NextBt.Location = new System.Drawing.Point(243, 350);
            this.NextBt.Name = "NextBt";
            this.NextBt.Size = new System.Drawing.Size(142, 23);
            this.NextBt.TabIndex = 2;
            this.NextBt.Text = "Next";
            this.NextBt.UseVisualStyleBackColor = true;
            this.NextBt.Click += new System.EventHandler(this.NextBt_Click);
            // 
            // DoctorViewBox
            // 
            this.DoctorViewBox.FormattingEnabled = true;
            this.DoctorViewBox.ItemHeight = 15;
            this.DoctorViewBox.Location = new System.Drawing.Point(428, 297);
            this.DoctorViewBox.Name = "DoctorViewBox";
            this.DoctorViewBox.Size = new System.Drawing.Size(165, 139);
            this.DoctorViewBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Waiting List";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Seen by Doctor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DoctorViewBox);
            this.Controls.Add(this.NextBt);
            this.Controls.Add(this.waitingList);
            this.Controls.Add(this.patient_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.patient_list.ResumeLayout(false);
            this.patient_list.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox patient_list;
        private Label label2;
        private TextBox address_box;
        private Label label1;
        private TextBox name_textBox;
        private Button add_btn;
        private Label label3;
        private ComboBox gender_box;
        private ListBox waitingList;
        private Button NextBt;
        private ListBox DoctorViewBox;
        private Label label4;
        private Label label5;
    }
}