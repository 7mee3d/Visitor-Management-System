namespace Visitor_Management_System
{
    partial class VMS_Login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VMS_Login));
            this.siticoneShadowPanel1 = new Siticone.Desktop.UI.WinForms.SiticoneShadowPanel();
            this.siticoneBorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // siticoneShadowPanel1
            // 
            this.siticoneShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneShadowPanel1.FillColor = System.Drawing.Color.White;
            this.siticoneShadowPanel1.Location = new System.Drawing.Point(496, 134);
            this.siticoneShadowPanel1.Name = "siticoneShadowPanel1";
            this.siticoneShadowPanel1.Radius = 10;
            this.siticoneShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.siticoneShadowPanel1.ShadowDepth = 25;
            this.siticoneShadowPanel1.ShadowShift = 9;
            this.siticoneShadowPanel1.Size = new System.Drawing.Size(448, 632);
            this.siticoneShadowPanel1.TabIndex = 0;
            // 
            // siticoneBorderlessForm
            // 
            this.siticoneBorderlessForm.AnimateWindow = true;
            this.siticoneBorderlessForm.BorderRadius = 30;
            this.siticoneBorderlessForm.ContainerControl = this;
            this.siticoneBorderlessForm.DockIndicatorColor = System.Drawing.Color.Black;
            this.siticoneBorderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm.TransparentWhileDrag = true;
            // 
            // VMS_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Visitor_Management_System.Properties.Resources.Background_VMS_Login_Screen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1428, 861);
            this.Controls.Add(this.siticoneShadowPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VMS_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMS Login";
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneShadowPanel siticoneShadowPanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm;
    }
}

