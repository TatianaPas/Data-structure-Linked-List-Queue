namespace LinkedList_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddDataBtn = new System.Windows.Forms.Button();
            this.InsertFirstBtn = new System.Windows.Forms.Button();
            this.InsertLastBtn = new System.Windows.Forms.Button();
            this.DeleteFirstBtn = new System.Windows.Forms.Button();
            this.DeleteLastBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(330, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Airlines Schedule Program";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 96);
            this.listBox1.TabIndex = 0;
            // 
            // AddDataBtn
            // 
            this.AddDataBtn.Location = new System.Drawing.Point(0, 0);
            this.AddDataBtn.Name = "AddDataBtn";
            this.AddDataBtn.Size = new System.Drawing.Size(75, 23);
            this.AddDataBtn.TabIndex = 0;
            // 
            // InsertFirstBtn
            // 
            this.InsertFirstBtn.Location = new System.Drawing.Point(0, 0);
            this.InsertFirstBtn.Name = "InsertFirstBtn";
            this.InsertFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertFirstBtn.TabIndex = 0;
            // 
            // InsertLastBtn
            // 
            this.InsertLastBtn.Location = new System.Drawing.Point(0, 0);
            this.InsertLastBtn.Name = "InsertLastBtn";
            this.InsertLastBtn.Size = new System.Drawing.Size(75, 23);
            this.InsertLastBtn.TabIndex = 0;
            // 
            // DeleteFirstBtn
            // 
            this.DeleteFirstBtn.Location = new System.Drawing.Point(0, 0);
            this.DeleteFirstBtn.Name = "DeleteFirstBtn";
            this.DeleteFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteFirstBtn.TabIndex = 0;
            // 
            // DeleteLastBtn
            // 
            this.DeleteLastBtn.Location = new System.Drawing.Point(0, 0);
            this.DeleteLastBtn.Name = "DeleteLastBtn";
            this.DeleteLastBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteLastBtn.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(942, 586);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button AddDataBtn;
        private Button InsertFirstBtn;
        private Button InsertLastBtn;
        private Button DeleteFirstBtn;
        private Button DeleteLastBtn;
        private Label label2;
    }
}