namespace cruddb
{
    partial class Add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lnameadd = new System.Windows.Forms.TextBox();
            this.fnameadd = new System.Windows.Forms.TextBox();
            this.mnameadd = new System.Windows.Forms.TextBox();
            this.dobadd = new System.Windows.Forms.TextBox();
            this.gadd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnameadd
            // 
            this.lnameadd.Location = new System.Drawing.Point(252, 90);
            this.lnameadd.Name = "lnameadd";
            this.lnameadd.Size = new System.Drawing.Size(219, 27);
            this.lnameadd.TabIndex = 0;
            // 
            // fnameadd
            // 
            this.fnameadd.Location = new System.Drawing.Point(252, 123);
            this.fnameadd.Name = "fnameadd";
            this.fnameadd.Size = new System.Drawing.Size(219, 27);
            this.fnameadd.TabIndex = 1;
            // 
            // mnameadd
            // 
            this.mnameadd.Location = new System.Drawing.Point(252, 156);
            this.mnameadd.Name = "mnameadd";
            this.mnameadd.Size = new System.Drawing.Size(219, 27);
            this.mnameadd.TabIndex = 2;
            // 
            // dobadd
            // 
            this.dobadd.Location = new System.Drawing.Point(252, 190);
            this.dobadd.Name = "dobadd";
            this.dobadd.Size = new System.Drawing.Size(219, 27);
            this.dobadd.TabIndex = 3;
            // 
            // gadd
            // 
            this.gadd.Location = new System.Drawing.Point(252, 222);
            this.gadd.Name = "gadd";
            this.gadd.Size = new System.Drawing.Size(219, 27);
            this.gadd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "LastName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "MiddleName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "DateOfBirth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(146, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(362, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 364);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gadd);
            this.Controls.Add(this.dobadd);
            this.Controls.Add(this.mnameadd);
            this.Controls.Add(this.fnameadd);
            this.Controls.Add(this.lnameadd);
            this.Name = "Add";
            this.Text = "Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox lnameadd;
        public TextBox fnameadd;
        public TextBox mnameadd;
        public TextBox dobadd;
        public TextBox gadd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}