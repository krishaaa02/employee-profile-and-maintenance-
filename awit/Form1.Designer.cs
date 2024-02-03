namespace awit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.x = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Label();
            this.employee_id = new System.Windows.Forms.Label();
            this.contact_number = new System.Windows.Forms.Label();
            this.job_occupation = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtjo = new System.Windows.Forms.TextBox();
            this.txtcn = new System.Windows.Forms.TextBox();
            this.txtemployeeid = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.employee_profile = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.user_id = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.maintenance = new System.Windows.Forms.Button();
            this.employee = new System.Windows.Forms.Button();
            this.bills = new System.Windows.Forms.Button();
            this.stocks = new System.Windows.Forms.Button();
            this.rooms = new System.Windows.Forms.Button();
            this.profile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(125)))), ((int)(((byte)(177)))));
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.x.Location = new System.Drawing.Point(748, 14);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(26, 23);
            this.x.TabIndex = 44;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(191)))), ((int)(((byte)(207)))));
            this.panel2.Controls.Add(this.remove);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.next);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.gender);
            this.panel2.Controls.Add(this.employee_id);
            this.panel2.Controls.Add(this.contact_number);
            this.panel2.Controls.Add(this.job_occupation);
            this.panel2.Controls.Add(this.age);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.txtgender);
            this.panel2.Controls.Add(this.txtage);
            this.panel2.Controls.Add(this.txtname);
            this.panel2.Controls.Add(this.txtjo);
            this.panel2.Controls.Add(this.txtcn);
            this.panel2.Controls.Add(this.txtemployeeid);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(211, 91);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 308);
            this.panel2.TabIndex = 42;
            // 
            // remove
            // 
            this.remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remove.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.remove.Location = new System.Drawing.Point(341, 232);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(93, 23);
            this.remove.TabIndex = 52;
            this.remove.Text = "REMOVE";
            this.remove.UseVisualStyleBackColor = false;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.save.Location = new System.Drawing.Point(143, 232);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(93, 23);
            this.save.TabIndex = 51;
            this.save.Text = "SAVE";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.update.Location = new System.Drawing.Point(242, 232);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(93, 23);
            this.update.TabIndex = 50;
            this.update.Text = "UPDATE";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.next.Location = new System.Drawing.Point(509, 232);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(25, 23);
            this.next.TabIndex = 48;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.back.Location = new System.Drawing.Point(478, 232);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(25, 23);
            this.back.TabIndex = 47;
            this.back.Text = "<";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gender.Location = new System.Drawing.Point(274, 135);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(106, 20);
            this.gender.TabIndex = 46;
            this.gender.Text = "GENDER:";
            this.gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // employee_id
            // 
            this.employee_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.employee_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.employee_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee_id.ForeColor = System.Drawing.SystemColors.ControlText;
            this.employee_id.Location = new System.Drawing.Point(14, 74);
            this.employee_id.Name = "employee_id";
            this.employee_id.Size = new System.Drawing.Size(123, 20);
            this.employee_id.TabIndex = 45;
            this.employee_id.Text = "EMPLOYEE ID:";
            this.employee_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contact_number
            // 
            this.contact_number.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.contact_number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact_number.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contact_number.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contact_number.Location = new System.Drawing.Point(14, 192);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(123, 20);
            this.contact_number.TabIndex = 44;
            this.contact_number.Text = "CONTACT NUMBER:";
            this.contact_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // job_occupation
            // 
            this.job_occupation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.job_occupation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.job_occupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.job_occupation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.job_occupation.Location = new System.Drawing.Point(14, 166);
            this.job_occupation.Name = "job_occupation";
            this.job_occupation.Size = new System.Drawing.Size(123, 20);
            this.job_occupation.TabIndex = 43;
            this.job_occupation.Text = "JOB OCCUPATION:";
            this.job_occupation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.age.ForeColor = System.Drawing.SystemColors.ControlText;
            this.age.Location = new System.Drawing.Point(14, 135);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(123, 20);
            this.age.TabIndex = 41;
            this.age.Text = "AGE:";
            this.age.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.name.Location = new System.Drawing.Point(14, 106);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(123, 20);
            this.name.TabIndex = 31;
            this.name.Text = "NAME:";
            this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgender
            // 
            this.txtgender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtgender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtgender.Location = new System.Drawing.Point(383, 135);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(151, 20);
            this.txtgender.TabIndex = 38;
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtage.Location = new System.Drawing.Point(143, 135);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(125, 20);
            this.txtage.TabIndex = 37;
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtname.Location = new System.Drawing.Point(143, 106);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(391, 20);
            this.txtname.TabIndex = 36;
            // 
            // txtjo
            // 
            this.txtjo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtjo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtjo.Location = new System.Drawing.Point(143, 166);
            this.txtjo.Name = "txtjo";
            this.txtjo.Size = new System.Drawing.Size(391, 20);
            this.txtjo.TabIndex = 35;
            // 
            // txtcn
            // 
            this.txtcn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtcn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcn.Location = new System.Drawing.Point(143, 192);
            this.txtcn.Name = "txtcn";
            this.txtcn.Size = new System.Drawing.Size(391, 20);
            this.txtcn.TabIndex = 34;
            // 
            // txtemployeeid
            // 
            this.txtemployeeid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtemployeeid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtemployeeid.Location = new System.Drawing.Point(143, 74);
            this.txtemployeeid.Name = "txtemployeeid";
            this.txtemployeeid.Size = new System.Drawing.Size(391, 20);
            this.txtemployeeid.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.panel3.Controls.Add(this.employee_profile);
            this.panel3.Location = new System.Drawing.Point(159, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 47);
            this.panel3.TabIndex = 22;
            // 
            // employee_profile
            // 
            this.employee_profile.AutoSize = true;
            this.employee_profile.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee_profile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee_profile.Location = new System.Drawing.Point(21, 14);
            this.employee_profile.Name = "employee_profile";
            this.employee_profile.Size = new System.Drawing.Size(186, 21);
            this.employee_profile.TabIndex = 12;
            this.employee_profile.Text = "EMPLOYEE\'S PROFILE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(180)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.user_id);
            this.panel1.Controls.Add(this.username);
            this.panel1.Controls.Add(this.welcome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.maintenance);
            this.panel1.Controls.Add(this.employee);
            this.panel1.Controls.Add(this.bills);
            this.panel1.Controls.Add(this.stocks);
            this.panel1.Controls.Add(this.rooms);
            this.panel1.Controls.Add(this.profile);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 450);
            this.panel1.TabIndex = 41;
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.user_id.Location = new System.Drawing.Point(31, 41);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(54, 13);
            this.user_id.TabIndex = 14;
            this.user_id.Text = "USER ID:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.username.Location = new System.Drawing.Point(31, 24);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(71, 13);
            this.username.TabIndex = 13;
            this.username.Text = "USERNAME:";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.welcome.Location = new System.Drawing.Point(54, 9);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(69, 15);
            this.welcome.TabIndex = 12;
            this.welcome.Text = "WELCOME!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "NAVIGATION BAR";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.login.Location = new System.Drawing.Point(22, 396);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(134, 23);
            this.login.TabIndex = 10;
            this.login.Text = "LOGOUT";
            this.login.UseVisualStyleBackColor = false;
            // 
            // maintenance
            // 
            this.maintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.maintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maintenance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.maintenance.Location = new System.Drawing.Point(22, 178);
            this.maintenance.Name = "maintenance";
            this.maintenance.Size = new System.Drawing.Size(134, 23);
            this.maintenance.TabIndex = 4;
            this.maintenance.Text = "MAINTENANCE";
            this.maintenance.UseVisualStyleBackColor = false;
            this.maintenance.Click += new System.EventHandler(this.maintenance_Click);
            // 
            // employee
            // 
            this.employee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.employee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employee.Location = new System.Drawing.Point(22, 236);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(134, 23);
            this.employee.TabIndex = 6;
            this.employee.Text = "EMPLOYEE";
            this.employee.UseVisualStyleBackColor = false;
            this.employee.Click += new System.EventHandler(this.employee_Click);
            // 
            // bills
            // 
            this.bills.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.bills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bills.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bills.Location = new System.Drawing.Point(22, 207);
            this.bills.Name = "bills";
            this.bills.Size = new System.Drawing.Size(134, 23);
            this.bills.TabIndex = 5;
            this.bills.Text = "PAYMENT";
            this.bills.UseVisualStyleBackColor = false;
            // 
            // stocks
            // 
            this.stocks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stocks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stocks.Location = new System.Drawing.Point(22, 149);
            this.stocks.Name = "stocks";
            this.stocks.Size = new System.Drawing.Size(134, 23);
            this.stocks.TabIndex = 2;
            this.stocks.Text = "STOCKS";
            this.stocks.UseVisualStyleBackColor = false;
            // 
            // rooms
            // 
            this.rooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rooms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rooms.Location = new System.Drawing.Point(22, 120);
            this.rooms.Name = "rooms";
            this.rooms.Size = new System.Drawing.Size(134, 23);
            this.rooms.TabIndex = 1;
            this.rooms.Text = "ROOMS";
            this.rooms.UseVisualStyleBackColor = false;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.profile.Location = new System.Drawing.Point(22, 91);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(134, 23);
            this.profile.TabIndex = 0;
            this.profile.Text = "PROFILE";
            this.profile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(193, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 365);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.x);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label gender;
        private System.Windows.Forms.Label employee_id;
        private System.Windows.Forms.Label contact_number;
        private System.Windows.Forms.Label job_occupation;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtjo;
        private System.Windows.Forms.TextBox txtcn;
        private System.Windows.Forms.TextBox txtemployeeid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label employee_profile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button maintenance;
        private System.Windows.Forms.Button employee;
        private System.Windows.Forms.Button bills;
        private System.Windows.Forms.Button stocks;
        private System.Windows.Forms.Button rooms;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

