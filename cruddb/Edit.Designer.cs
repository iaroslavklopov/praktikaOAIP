namespace cruddb
{
    partial class Edit
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gedit = new System.Windows.Forms.TextBox();
            this.dobedit = new System.Windows.Forms.TextBox();
            this.mnameedit = new System.Windows.Forms.TextBox();
            this.fnameedit = new System.Windows.Forms.TextBox();
            this.lnameedit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(454, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Ok";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(238, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "DateOfBirth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "MiddleName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "FirstName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "LastName";
            // 
            // gedit
            // 
            this.gedit.Location = new System.Drawing.Point(344, 240);
            this.gedit.Name = "gedit";
            this.gedit.Size = new System.Drawing.Size(219, 27);
            this.gedit.TabIndex = 16;
            // 
            // dobedit
            // 
            this.dobedit.Location = new System.Drawing.Point(344, 208);
            this.dobedit.Name = "dobedit";
            this.dobedit.Size = new System.Drawing.Size(219, 27);
            this.dobedit.TabIndex = 15;
            // 
            // mnameedit
            // 
            this.mnameedit.Location = new System.Drawing.Point(344, 174);
            this.mnameedit.Name = "mnameedit";
            this.mnameedit.Size = new System.Drawing.Size(219, 27);
            this.mnameedit.TabIndex = 14;
            // 
            // fnameedit
            // 
            this.fnameedit.Location = new System.Drawing.Point(344, 141);
            this.fnameedit.Name = "fnameedit";
            this.fnameedit.Size = new System.Drawing.Size(219, 27);
            this.fnameedit.TabIndex = 13;
            // 
            // lnameedit
            // 
            this.lnameedit.Location = new System.Drawing.Point(344, 108);
            this.lnameedit.Name = "lnameedit";
            this.lnameedit.Size = new System.Drawing.Size(219, 27);
            this.lnameedit.TabIndex = 12;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gedit);
            this.Controls.Add(this.dobedit);
            this.Controls.Add(this.mnameedit);
            this.Controls.Add(this.fnameedit);
            this.Controls.Add(this.lnameedit);
            this.Name = "Edit";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox gedit;
        public TextBox dobedit;
        public TextBox mnameedit;
        public TextBox fnameedit;
        public TextBox lnameedit;
    }
}