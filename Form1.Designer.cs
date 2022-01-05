
namespace NBT_Maker
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
            this.components = new System.ComponentModel.Container();
            this.siticoneButton1 = new Siticone.UI.WinForms.SiticoneButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneButton8 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneButton7 = new Siticone.UI.WinForms.SiticoneButton();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.SuspendLayout();
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Location = new System.Drawing.Point(313, 264);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(180, 45);
            this.siticoneButton1.TabIndex = 0;
            this.siticoneButton1.Text = "Start";
            this.siticoneButton1.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 421);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dannyg82#6969";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(334, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Easy File Opener";
            // 
            // siticoneButton8
            // 
            this.siticoneButton8.CheckedState.Parent = this.siticoneButton8;
            this.siticoneButton8.CustomImages.Parent = this.siticoneButton8;
            this.siticoneButton8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton8.ForeColor = System.Drawing.Color.White;
            this.siticoneButton8.HoveredState.Parent = this.siticoneButton8;
            this.siticoneButton8.Location = new System.Drawing.Point(722, 12);
            this.siticoneButton8.Name = "siticoneButton8";
            this.siticoneButton8.ShadowDecoration.Parent = this.siticoneButton8;
            this.siticoneButton8.Size = new System.Drawing.Size(30, 32);
            this.siticoneButton8.TabIndex = 12;
            this.siticoneButton8.Text = "~";
            this.siticoneButton8.Click += new System.EventHandler(this.siticoneButton8_Click);
            // 
            // siticoneButton7
            // 
            this.siticoneButton7.CheckedState.Parent = this.siticoneButton7;
            this.siticoneButton7.CustomImages.Parent = this.siticoneButton7;
            this.siticoneButton7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneButton7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton7.ForeColor = System.Drawing.Color.White;
            this.siticoneButton7.HoveredState.Parent = this.siticoneButton7;
            this.siticoneButton7.Location = new System.Drawing.Point(758, 12);
            this.siticoneButton7.Name = "siticoneButton7";
            this.siticoneButton7.ShadowDecoration.Parent = this.siticoneButton7;
            this.siticoneButton7.Size = new System.Drawing.Size(30, 32);
            this.siticoneButton7.TabIndex = 11;
            this.siticoneButton7.Text = "X";
            this.siticoneButton7.Click += new System.EventHandler(this.siticoneButton7_Click);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siticoneButton8);
            this.Controls.Add(this.siticoneButton7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticoneButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticoneButton siticoneButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton8;
        private Siticone.UI.WinForms.SiticoneButton siticoneButton7;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
    }
}

