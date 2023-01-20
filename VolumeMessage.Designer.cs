namespace Koders
{
    partial class VolumeMessage
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
            this.volume_Trackbar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Music_Check = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btn_Close = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // volume_Trackbar
            // 
            this.volume_Trackbar.Location = new System.Drawing.Point(91, 201);
            this.volume_Trackbar.Name = "volume_Trackbar";
            this.volume_Trackbar.Size = new System.Drawing.Size(214, 23);
            this.volume_Trackbar.TabIndex = 18;
            this.volume_Trackbar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(35)))));
            this.volume_Trackbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volume_Trackbar_Scroll);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.TransparentWhileDrag = false;
            // 
            // Music_Check
            // 
            this.Music_Check.AutoSize = true;
            this.Music_Check.Checked = true;
            this.Music_Check.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(35)))));
            this.Music_Check.CheckedState.BorderRadius = 0;
            this.Music_Check.CheckedState.BorderThickness = 0;
            this.Music_Check.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(35)))));
            this.Music_Check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Music_Check.Font = new System.Drawing.Font("ObelixPro", 14.25F);
            this.Music_Check.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Music_Check.Location = new System.Drawing.Point(146, 102);
            this.Music_Check.Name = "Music_Check";
            this.Music_Check.Size = new System.Drawing.Size(104, 27);
            this.Music_Check.TabIndex = 20;
            this.Music_Check.Text = " Music";
            this.Music_Check.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Music_Check.UncheckedState.BorderRadius = 0;
            this.Music_Check.UncheckedState.BorderThickness = 0;
            this.Music_Check.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.Music_Check.CheckedChanged += new System.EventHandler(this.Music_Check_CheckedChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Close.Animated = true;
            this.btn_Close.AutoRoundedCorners = true;
            this.btn_Close.BackColor = System.Drawing.Color.Transparent;
            this.btn_Close.BorderRadius = 18;
            this.btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Close.FillColor = System.Drawing.Color.Chocolate;
            this.btn_Close.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(107)))), ((int)(((byte)(35)))));
            this.btn_Close.Font = new System.Drawing.Font("ObelixPro", 11.25F);
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btn_Close.IndicateFocus = true;
            this.btn_Close.Location = new System.Drawing.Point(336, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(48, 38);
            this.btn_Close.TabIndex = 21;
            this.btn_Close.Text = "X";
            this.btn_Close.UseTransparentBackground = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click_1);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 30;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Chocolate;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // VolumeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(4)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(396, 306);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.Music_Check);
            this.Controls.Add(this.volume_Trackbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VolumeMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VolumeMessage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TrackBar volume_Trackbar;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2CheckBox Music_Check;
        private Guna.UI2.WinForms.Guna2GradientButton btn_Close;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}