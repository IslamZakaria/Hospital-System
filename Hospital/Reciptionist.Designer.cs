namespace Hospital
{
    partial class Reciptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reciptionist));
            this.update_rooms = new System.Windows.Forms.TabPage();
            this.name = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.patient_namee = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namee = new System.Windows.Forms.Label();
            this.searchh = new System.Windows.Forms.Button();
            this.dead_people = new System.Windows.Forms.RadioButton();
            this.patient = new System.Windows.Forms.RadioButton();
            this.rooms = new System.Windows.Forms.TabPage();
            this.typ = new System.Windows.Forms.TextBox();
            this.name_ = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookDoctor = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.special = new System.Windows.Forms.TextBox();
            this.display = new System.Windows.Forms.Button();
            this.speciality = new System.Windows.Forms.Label();
            this.reciption = new System.Windows.Forms.TabControl();
            this.button3 = new System.Windows.Forms.Button();
            this.update_rooms.SuspendLayout();
            this.search.SuspendLayout();
            this.rooms.SuspendLayout();
            this.bookDoctor.SuspendLayout();
            this.reciption.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_rooms
            // 
            this.update_rooms.BackgroundImage = global::Hospital.Properties.Resources.adli_sicil_kaydi_570x370;
            this.update_rooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.update_rooms.Controls.Add(this.name);
            this.update_rooms.Controls.Add(this.update);
            this.update_rooms.Controls.Add(this.patient_namee);
            this.update_rooms.Location = new System.Drawing.Point(4, 52);
            this.update_rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_rooms.Name = "update_rooms";
            this.update_rooms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_rooms.Size = new System.Drawing.Size(881, 436);
            this.update_rooms.TabIndex = 4;
            this.update_rooms.Text = "Update Rooms";
            this.update_rooms.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(239, 92);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(254, 28);
            this.name.TabIndex = 2;
            // 
            // update
            // 
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.Location = new System.Drawing.Point(284, 280);
            this.update.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(251, 50);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // patient_namee
            // 
            this.patient_namee.AutoSize = true;
            this.patient_namee.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_namee.Location = new System.Drawing.Point(6, 92);
            this.patient_namee.Name = "patient_namee";
            this.patient_namee.Size = new System.Drawing.Size(227, 27);
            this.patient_namee.TabIndex = 0;
            this.patient_namee.Text = "Enter Patient\'s Name :";
            // 
            // search
            // 
            this.search.BackgroundImage = global::Hospital.Properties.Resources.adli_sicil_kaydi_570x370;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.search.Controls.Add(this.richTextBox2);
            this.search.Controls.Add(this.textBox2);
            this.search.Controls.Add(this.label4);
            this.search.Controls.Add(this.label3);
            this.search.Controls.Add(this.namee);
            this.search.Controls.Add(this.searchh);
            this.search.Controls.Add(this.dead_people);
            this.search.Controls.Add(this.patient);
            this.search.Location = new System.Drawing.Point(4, 52);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Size = new System.Drawing.Size(881, 436);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(552, 33);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(305, 281);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 198);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 28);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter The Name Please :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(344, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please choose wich statue You Want :";
            // 
            // namee
            // 
            this.namee.AutoSize = true;
            this.namee.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namee.Location = new System.Drawing.Point(36, 204);
            this.namee.Name = "namee";
            this.namee.Size = new System.Drawing.Size(53, 21);
            this.namee.TabIndex = 6;
            this.namee.Text = "Name";
            // 
            // searchh
            // 
            this.searchh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchh.Location = new System.Drawing.Point(256, 375);
            this.searchh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchh.Name = "searchh";
            this.searchh.Size = new System.Drawing.Size(280, 41);
            this.searchh.TabIndex = 4;
            this.searchh.Text = "Search ";
            this.searchh.UseVisualStyleBackColor = true;
            this.searchh.Click += new System.EventHandler(this.searchh_Click);
            // 
            // dead_people
            // 
            this.dead_people.AutoSize = true;
            this.dead_people.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dead_people.Location = new System.Drawing.Point(42, 84);
            this.dead_people.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dead_people.Name = "dead_people";
            this.dead_people.Size = new System.Drawing.Size(122, 25);
            this.dead_people.TabIndex = 1;
            this.dead_people.TabStop = true;
            this.dead_people.Text = "Dead people";
            this.dead_people.UseVisualStyleBackColor = true;
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.Location = new System.Drawing.Point(43, 57);
            this.patient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(78, 25);
            this.patient.TabIndex = 0;
            this.patient.TabStop = true;
            this.patient.Text = "Patient";
            this.patient.UseVisualStyleBackColor = true;
            // 
            // rooms
            // 
            this.rooms.BackgroundImage = global::Hospital.Properties.Resources.adli_sicil_kaydi_570x370;
            this.rooms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rooms.Controls.Add(this.button3);
            this.rooms.Controls.Add(this.typ);
            this.rooms.Controls.Add(this.name_);
            this.rooms.Controls.Add(this.button2);
            this.rooms.Controls.Add(this.label2);
            this.rooms.Controls.Add(this.label1);
            this.rooms.Location = new System.Drawing.Point(4, 52);
            this.rooms.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rooms.Name = "rooms";
            this.rooms.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rooms.Size = new System.Drawing.Size(881, 436);
            this.rooms.TabIndex = 2;
            this.rooms.Text = "Rooms";
            this.rooms.UseVisualStyleBackColor = true;
            // 
            // typ
            // 
            this.typ.Location = new System.Drawing.Point(171, 162);
            this.typ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typ.Multiline = true;
            this.typ.Name = "typ";
            this.typ.Size = new System.Drawing.Size(193, 28);
            this.typ.TabIndex = 5;
            // 
            // name_
            // 
            this.name_.Location = new System.Drawing.Point(171, 107);
            this.name_.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_.Multiline = true;
            this.name_.Name = "name_";
            this.name_.Size = new System.Drawing.Size(193, 28);
            this.name_.TabIndex = 2;
            this.name_.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(333, 289);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(268, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "Book Room";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name";
            // 
            // bookDoctor
            // 
            this.bookDoctor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bookDoctor.BackgroundImage")));
            this.bookDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookDoctor.Controls.Add(this.button1);
            this.bookDoctor.Controls.Add(this.richTextBox1);
            this.bookDoctor.Controls.Add(this.special);
            this.bookDoctor.Controls.Add(this.display);
            this.bookDoctor.Controls.Add(this.speciality);
            this.bookDoctor.Font = new System.Drawing.Font("Tahoma", 10F);
            this.bookDoctor.Location = new System.Drawing.Point(4, 52);
            this.bookDoctor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookDoctor.Name = "bookDoctor";
            this.bookDoctor.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bookDoctor.Size = new System.Drawing.Size(881, 436);
            this.bookDoctor.TabIndex = 0;
            this.bookDoctor.Text = "Book Doctor";
            this.bookDoctor.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "log out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(155, 123);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(508, 184);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // special
            // 
            this.special.Location = new System.Drawing.Point(272, 62);
            this.special.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.special.Name = "special";
            this.special.Size = new System.Drawing.Size(167, 24);
            this.special.TabIndex = 2;
            // 
            // display
            // 
            this.display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.display.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display.Location = new System.Drawing.Point(466, 52);
            this.display.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(149, 34);
            this.display.TabIndex = 5;
            this.display.Text = "Display";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // speciality
            // 
            this.speciality.AutoSize = true;
            this.speciality.BackColor = System.Drawing.Color.Transparent;
            this.speciality.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speciality.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.speciality.Location = new System.Drawing.Point(150, 58);
            this.speciality.Name = "speciality";
            this.speciality.Size = new System.Drawing.Size(100, 25);
            this.speciality.TabIndex = 0;
            this.speciality.Text = "Speciality";
            // 
            // reciption
            // 
            this.reciption.Controls.Add(this.bookDoctor);
            this.reciption.Controls.Add(this.rooms);
            this.reciption.Controls.Add(this.search);
            this.reciption.Controls.Add(this.update_rooms);
            this.reciption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reciption.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciption.Location = new System.Drawing.Point(0, 0);
            this.reciption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reciption.Name = "reciption";
            this.reciption.Padding = new System.Drawing.Point(6, 12);
            this.reciption.SelectedIndex = 0;
            this.reciption.Size = new System.Drawing.Size(889, 492);
            this.reciption.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(30, 383);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "log out";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Reciptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 492);
            this.Controls.Add(this.reciption);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Reciptionist";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reciptionist";
            this.Load += new System.EventHandler(this.Reciptionist_Load);
            this.update_rooms.ResumeLayout(false);
            this.update_rooms.PerformLayout();
            this.search.ResumeLayout(false);
            this.search.PerformLayout();
            this.rooms.ResumeLayout(false);
            this.rooms.PerformLayout();
            this.bookDoctor.ResumeLayout(false);
            this.bookDoctor.PerformLayout();
            this.reciption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage update_rooms;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label patient_namee;
        private System.Windows.Forms.TabPage search;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namee;
        private System.Windows.Forms.Button searchh;
        private System.Windows.Forms.RadioButton dead_people;
        private System.Windows.Forms.RadioButton patient;
        private System.Windows.Forms.TabPage rooms;
        private System.Windows.Forms.TextBox typ;
        private System.Windows.Forms.TextBox name_;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage bookDoctor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox special;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Label speciality;
        private System.Windows.Forms.TabControl reciption;
        private System.Windows.Forms.Button button3;


    }
}