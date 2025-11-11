namespace Visitor_Management_System.User_Control_VMS
{
    partial class UserControlSectionAddNewVisitor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mySiticoneLicenseSettings1 = new SiticoneNetFrameworkUI.MySiticoneLicenseSettings();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mySiticoneLicenseSettings1
            // 
            this.mySiticoneLicenseSettings1.OpenLicenseSettings = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(793, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Section Add New Visitior";
            // 
            // UserControlAddNewVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Name = "UserControlAddNewVisitor";
            this.Size = new System.Drawing.Size(1171, 744);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SiticoneNetFrameworkUI.MySiticoneLicenseSettings mySiticoneLicenseSettings1;
        private System.Windows.Forms.Label label1;
    }
}
