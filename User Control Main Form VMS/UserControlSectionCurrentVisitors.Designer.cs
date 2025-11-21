namespace Visitor_Management_System.User_Control_VMS
{
    partial class UserControlSectionCurrentVisitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlSectionCurrentVisitors));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.GGButtonRefresh = new Guna.UI2.WinForms.Guna2GradientButton();
            this.sTextBoxSearch = new SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced();
            this.label2 = new System.Windows.Forms.Label();
            this.GPnaelListDGVandLabelWord = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.DataGridViewCurrentlyActiveVisitors = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDVisitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            this.GPnaelListDGVandLabelWord.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentlyActiveVisitors)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Visitors";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.GGButtonRefresh);
            this.guna2Panel1.Controls.Add(this.sTextBoxSearch);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(107, 136);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1186, 123);
            this.guna2Panel1.TabIndex = 3;
            // 
            // GGButtonRefresh
            // 
            this.GGButtonRefresh.Animated = true;
            this.GGButtonRefresh.AnimatedGIF = true;
            this.GGButtonRefresh.BorderRadius = 10;
            this.GGButtonRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.GGButtonRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.GGButtonRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GGButtonRefresh.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.GGButtonRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.GGButtonRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.GGButtonRefresh.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(244)))));
            this.GGButtonRefresh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.GGButtonRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GGButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.GGButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("GGButtonRefresh.Image")));
            this.GGButtonRefresh.ImageOffset = new System.Drawing.Point(-5, 0);
            this.GGButtonRefresh.Location = new System.Drawing.Point(1057, 59);
            this.GGButtonRefresh.Name = "GGButtonRefresh";
            this.GGButtonRefresh.Size = new System.Drawing.Size(116, 40);
            this.GGButtonRefresh.TabIndex = 6;
            this.GGButtonRefresh.Text = "Refresh";
            this.GGButtonRefresh.Click += new System.EventHandler(this.GGButtonRefresh_Click);
            // 
            // sTextBoxSearch
            // 
            this.sTextBoxSearch.BackColor = System.Drawing.Color.Transparent;
            this.sTextBoxSearch.BackgroundColor = System.Drawing.Color.White;
            this.sTextBoxSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.sTextBoxSearch.BottomLeftCornerRadius = 8;
            this.sTextBoxSearch.BottomRightCornerRadius = 8;
            this.sTextBoxSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sTextBoxSearch.FocusBorderColor = System.Drawing.Color.DodgerBlue;
            this.sTextBoxSearch.FocusImage = null;
            this.sTextBoxSearch.HoverBorderColor = System.Drawing.Color.Gray;
            this.sTextBoxSearch.HoverImage = null;
            this.sTextBoxSearch.IdleImage = ((System.Drawing.Image)(resources.GetObject("sTextBoxSearch.IdleImage")));
            this.sTextBoxSearch.Location = new System.Drawing.Point(33, 59);
            this.sTextBoxSearch.Name = "sTextBoxSearch";
            this.sTextBoxSearch.PlaceholderColor = System.Drawing.Color.Gray;
            this.sTextBoxSearch.PlaceholderFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.sTextBoxSearch.PlaceholderText = "Search by ID or Name....";
            this.sTextBoxSearch.ReadOnlyColors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.sTextBoxSearch.ReadOnlyColors.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.sTextBoxSearch.ReadOnlyColors.PlaceholderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.sTextBoxSearch.ReadOnlyColors.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.sTextBoxSearch.Size = new System.Drawing.Size(1018, 40);
            this.sTextBoxSearch.TabIndex = 3;
            this.sTextBoxSearch.TextColor = System.Drawing.SystemColors.WindowText;
            this.sTextBoxSearch.TextContent = "";
            this.sTextBoxSearch.TopLeftCornerRadius = 8;
            this.sTextBoxSearch.TopRightCornerRadius = 8;
            this.sTextBoxSearch.ValidationPattern = "";
            this.sTextBoxSearch.TextContentChanged += new System.EventHandler(this.sTextBoxSearch_TextContentChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find Current Visitor";
            // 
            // GPnaelListDGVandLabelWord
            // 
            this.GPnaelListDGVandLabelWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.GPnaelListDGVandLabelWord.BorderRadius = 25;
            this.GPnaelListDGVandLabelWord.BorderThickness = 2;
            this.GPnaelListDGVandLabelWord.Controls.Add(this.guna2Panel3);
            this.GPnaelListDGVandLabelWord.Controls.Add(this.DataGridViewCurrentlyActiveVisitors);
            this.GPnaelListDGVandLabelWord.Controls.Add(this.label3);
            this.GPnaelListDGVandLabelWord.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(233)))), ((int)(((byte)(237)))));
            this.GPnaelListDGVandLabelWord.Location = new System.Drawing.Point(107, 284);
            this.GPnaelListDGVandLabelWord.Name = "GPnaelListDGVandLabelWord";
            this.GPnaelListDGVandLabelWord.Size = new System.Drawing.Size(1186, 413);
            this.GPnaelListDGVandLabelWord.TabIndex = 6;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.guna2Panel3.Location = new System.Drawing.Point(18, 57);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1145, 9);
            this.guna2Panel3.TabIndex = 5;
            // 
            // DataGridViewCurrentlyActiveVisitors
            // 
            this.DataGridViewCurrentlyActiveVisitors.AllowUserToAddRows = false;
            this.DataGridViewCurrentlyActiveVisitors.AllowUserToDeleteRows = false;
            this.DataGridViewCurrentlyActiveVisitors.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.DataGridViewCurrentlyActiveVisitors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCurrentlyActiveVisitors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewCurrentlyActiveVisitors.ColumnHeadersHeight = 39;
            this.DataGridViewCurrentlyActiveVisitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCurrentlyActiveVisitors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDVisitor,
            this.NameVisitor,
            this.Department,
            this.CheckInTime,
            this.Purpose});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewCurrentlyActiveVisitors.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewCurrentlyActiveVisitors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.DataGridViewCurrentlyActiveVisitors.Location = new System.Drawing.Point(15, 74);
            this.DataGridViewCurrentlyActiveVisitors.Name = "DataGridViewCurrentlyActiveVisitors";
            this.DataGridViewCurrentlyActiveVisitors.ReadOnly = true;
            this.DataGridViewCurrentlyActiveVisitors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewCurrentlyActiveVisitors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewCurrentlyActiveVisitors.RowHeadersVisible = false;
            this.DataGridViewCurrentlyActiveVisitors.RowTemplate.Height = 41;
            this.DataGridViewCurrentlyActiveVisitors.Size = new System.Drawing.Size(1168, 324);
            this.DataGridViewCurrentlyActiveVisitors.TabIndex = 3;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(225)))), ((int)(((byte)(230)))));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.HeaderStyle.Height = 39;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.ReadOnly = true;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.Height = 41;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.DataGridViewCurrentlyActiveVisitors.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(107)))), ((int)(((byte)(245)))));
            this.label3.Location = new System.Drawing.Point(9, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 1;
            this.label3.Text = "Active Visitors";
            // 
            // Purpose
            // 
            this.Purpose.FillWeight = 120.1177F;
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // CheckInTime
            // 
            this.CheckInTime.FillWeight = 99.17629F;
            this.CheckInTime.HeaderText = "Check-in Time";
            this.CheckInTime.Name = "CheckInTime";
            this.CheckInTime.ReadOnly = true;
            // 
            // Department
            // 
            this.Department.FillWeight = 99.14313F;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            this.Department.ReadOnly = true;
            // 
            // NameVisitor
            // 
            this.NameVisitor.FillWeight = 111.6847F;
            this.NameVisitor.HeaderText = "Name Visitor";
            this.NameVisitor.Name = "NameVisitor";
            this.NameVisitor.ReadOnly = true;
            this.NameVisitor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IDVisitor
            // 
            this.IDVisitor.FillWeight = 38.87817F;
            this.IDVisitor.HeaderText = "ID Visitor";
            this.IDVisitor.Name = "IDVisitor";
            this.IDVisitor.ReadOnly = true;
            // 
            // UserControlSectionCurrentVisitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GPnaelListDGVandLabelWord);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "UserControlSectionCurrentVisitors";
            this.Size = new System.Drawing.Size(1359, 779);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.GPnaelListDGVandLabelWord.ResumeLayout(false);
            this.GPnaelListDGVandLabelWord.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewCurrentlyActiveVisitors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2GradientButton GGButtonRefresh;
        private SiticoneNetFrameworkUI.SiticoneTextBoxAdvanced sTextBoxSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel GPnaelListDGVandLabelWord;
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView DataGridViewCurrentlyActiveVisitors;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameVisitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
    }
}
