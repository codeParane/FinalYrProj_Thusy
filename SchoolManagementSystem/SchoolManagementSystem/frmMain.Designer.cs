namespace SchoolManagementSystem
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.rib_Student = new System.Windows.Forms.RibbonTab();
            this.rpan_newStudent = new System.Windows.Forms.RibbonPanel();
            this.rpan_editStudent = new System.Windows.Forms.RibbonPanel();
            this.rpan_findStudents = new System.Windows.Forms.RibbonPanel();
            this.rib_Staff = new System.Windows.Forms.RibbonTab();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel2 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel3 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel4 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel5 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel6 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabel7 = new System.Windows.Forms.RibbonLabel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab2 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.SuspendLayout();
            // 
            // rib_Student
            // 
            this.rib_Student.Name = "rib_Student";
            this.rib_Student.Panels.Add(this.rpan_newStudent);
            this.rib_Student.Panels.Add(this.rpan_editStudent);
            this.rib_Student.Panels.Add(this.rpan_findStudents);
            this.rib_Student.Text = "Student";
            // 
            // rpan_newStudent
            // 
            this.rpan_newStudent.ButtonMoreEnabled = false;
            this.rpan_newStudent.ButtonMoreVisible = false;
            this.rpan_newStudent.Image = ((System.Drawing.Image)(resources.GetObject("rpan_newStudent.Image")));
            this.rpan_newStudent.Name = "rpan_newStudent";
            this.rpan_newStudent.Text = "New Student";
            this.rpan_newStudent.Click += new System.EventHandler(this.rpan_newStudent_Click);
            // 
            // rpan_editStudent
            // 
            this.rpan_editStudent.ButtonMoreEnabled = false;
            this.rpan_editStudent.ButtonMoreVisible = false;
            this.rpan_editStudent.Name = "rpan_editStudent";
            this.rpan_editStudent.Text = "Edit Student";
            // 
            // rpan_findStudents
            // 
            this.rpan_findStudents.ButtonMoreEnabled = false;
            this.rpan_findStudents.ButtonMoreVisible = false;
            this.rpan_findStudents.Name = "rpan_findStudents";
            this.rpan_findStudents.Text = "Find Student";
            // 
            // rib_Staff
            // 
            this.rib_Staff.Name = "rib_Staff";
            this.rib_Staff.Text = "Staffs";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Name = "ribbonLabel2";
            // 
            // ribbonLabel3
            // 
            this.ribbonLabel3.Name = "ribbonLabel3";
            // 
            // ribbonLabel4
            // 
            this.ribbonLabel4.Name = "ribbonLabel4";
            // 
            // ribbonLabel5
            // 
            this.ribbonLabel5.Name = "ribbonLabel5";
            // 
            // ribbonLabel6
            // 
            this.ribbonLabel6.Name = "ribbonLabel6";
            // 
            // ribbonLabel7
            // 
            this.ribbonLabel7.Name = "ribbonLabel7";
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 72);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = ((System.Drawing.Image)(resources.GetObject("ribbon1.OrbImage")));
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.AltKey = "`";
            this.ribbon1.QuickAccessToolbar.Text = "SMS";
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(761, 126);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.rib_Student);
            this.ribbon1.Tabs.Add(this.rib_Staff);
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.Tabs.Add(this.ribbonTab2);
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(6, 26, 20, 0);
            this.ribbon1.TabSpacing = 3;
            this.ribbon1.Text = "ribbon1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Text = "Reports";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Name = "ribbonPanel1";
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Panels.Add(this.ribbonPanel2);
            this.ribbonTab2.Text = "Attandance";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Name = "ribbonPanel2";
            this.ribbonPanel2.Text = "ribbonPanel2";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Panels.Add(this.ribbonPanel3);
            this.ribbonTab3.Panels.Add(this.ribbonPanel4);
            this.ribbonTab3.Text = "TimeTable";
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.ButtonMoreEnabled = false;
            this.ribbonPanel3.ButtonMoreVisible = false;
            this.ribbonPanel3.Name = "ribbonPanel3";
            this.ribbonPanel3.Text = "View Time Table";
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.ButtonMoreEnabled = false;
            this.ribbonPanel4.ButtonMoreVisible = false;
            this.ribbonPanel4.Name = "ribbonPanel4";
            this.ribbonPanel4.Text = "Change Time Table";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 433);
            this.Controls.Add(this.ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frm_Main";
            this.Text = "View";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RibbonTab rib_Student;
        private System.Windows.Forms.RibbonTab rib_Staff;
        private System.Windows.Forms.RibbonPanel rpan_newStudent;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonLabel ribbonLabel2;
        private System.Windows.Forms.RibbonLabel ribbonLabel3;
        private System.Windows.Forms.RibbonLabel ribbonLabel4;
        private System.Windows.Forms.RibbonLabel ribbonLabel5;
        private System.Windows.Forms.RibbonLabel ribbonLabel6;
        private System.Windows.Forms.RibbonLabel ribbonLabel7;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonPanel rpan_editStudent;
        private System.Windows.Forms.RibbonPanel rpan_findStudents;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonTab ribbonTab2;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
    }
}

