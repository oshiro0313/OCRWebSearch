
namespace OCRWebSearch
{
    partial class SettingForm
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
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSC3 = new System.Windows.Forms.Label();
            this.labelSC2 = new System.Windows.Forms.Label();
            this.labelSC1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelExplanation = new System.Windows.Forms.Label();
            this.SCdelete1 = new System.Windows.Forms.Button();
            this.SCdelete2 = new System.Windows.Forms.Button();
            this.SCdelete3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(398, 113);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "閉じる";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SCdelete3);
            this.groupBox1.Controls.Add(this.SCdelete2);
            this.groupBox1.Controls.Add(this.SCdelete1);
            this.groupBox1.Controls.Add(this.labelSC3);
            this.groupBox1.Controls.Add(this.labelSC2);
            this.groupBox1.Controls.Add(this.labelSC1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 93);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ショートカットキー";
            // 
            // labelSC3
            // 
            this.labelSC3.AutoSize = true;
            this.labelSC3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSC3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSC3.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSC3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSC3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSC3.Location = new System.Drawing.Point(219, 46);
            this.labelSC3.MaximumSize = new System.Drawing.Size(75, 25);
            this.labelSC3.MinimumSize = new System.Drawing.Size(75, 25);
            this.labelSC3.Name = "labelSC3";
            this.labelSC3.Size = new System.Drawing.Size(75, 25);
            this.labelSC3.TabIndex = 12;
            this.labelSC3.Text = "Shift";
            this.labelSC3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSC3.Click += new System.EventHandler(this.labelSC3_Click);
            // 
            // labelSC2
            // 
            this.labelSC2.AutoSize = true;
            this.labelSC2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSC2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSC2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSC2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSC2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSC2.Location = new System.Drawing.Point(114, 46);
            this.labelSC2.MaximumSize = new System.Drawing.Size(75, 25);
            this.labelSC2.MinimumSize = new System.Drawing.Size(75, 25);
            this.labelSC2.Name = "labelSC2";
            this.labelSC2.Size = new System.Drawing.Size(75, 25);
            this.labelSC2.TabIndex = 11;
            this.labelSC2.Text = "Shift";
            this.labelSC2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSC2.Click += new System.EventHandler(this.labelSC2_Click);
            // 
            // labelSC1
            // 
            this.labelSC1.AutoSize = true;
            this.labelSC1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSC1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSC1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelSC1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelSC1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSC1.Location = new System.Drawing.Point(8, 45);
            this.labelSC1.MaximumSize = new System.Drawing.Size(75, 25);
            this.labelSC1.MinimumSize = new System.Drawing.Size(75, 25);
            this.labelSC1.Name = "labelSC1";
            this.labelSC1.Size = new System.Drawing.Size(75, 25);
            this.labelSC1.TabIndex = 8;
            this.labelSC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSC1.Click += new System.EventHandler(this.labelSC1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(195, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(89, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "+";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(398, 73);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "変更を保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelExplanation
            // 
            this.labelExplanation.AutoSize = true;
            this.labelExplanation.Location = new System.Drawing.Point(26, 93);
            this.labelExplanation.Name = "labelExplanation";
            this.labelExplanation.Size = new System.Drawing.Size(0, 12);
            this.labelExplanation.TabIndex = 9;
            // 
            // SCdelete1
            // 
            this.SCdelete1.BackColor = System.Drawing.Color.Red;
            this.SCdelete1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCdelete1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCdelete1.Location = new System.Drawing.Point(63, 22);
            this.SCdelete1.Name = "SCdelete1";
            this.SCdelete1.Size = new System.Drawing.Size(20, 20);
            this.SCdelete1.TabIndex = 13;
            this.SCdelete1.Text = "X";
            this.SCdelete1.UseVisualStyleBackColor = false;
            this.SCdelete1.Click += new System.EventHandler(this.SCdelete1_Click);
            // 
            // SCdelete2
            // 
            this.SCdelete2.BackColor = System.Drawing.Color.Red;
            this.SCdelete2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCdelete2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCdelete2.Location = new System.Drawing.Point(169, 23);
            this.SCdelete2.Name = "SCdelete2";
            this.SCdelete2.Size = new System.Drawing.Size(20, 20);
            this.SCdelete2.TabIndex = 14;
            this.SCdelete2.Text = "X";
            this.SCdelete2.UseVisualStyleBackColor = false;
            this.SCdelete2.Click += new System.EventHandler(this.SCdelete2_Click);
            // 
            // SCdelete3
            // 
            this.SCdelete3.BackColor = System.Drawing.Color.Red;
            this.SCdelete3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SCdelete3.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SCdelete3.Location = new System.Drawing.Point(274, 22);
            this.SCdelete3.Name = "SCdelete3";
            this.SCdelete3.Size = new System.Drawing.Size(20, 20);
            this.SCdelete3.TabIndex = 15;
            this.SCdelete3.Text = "X";
            this.SCdelete3.UseVisualStyleBackColor = false;
            this.SCdelete3.Click += new System.EventHandler(this.SCdelete3_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 167);
            this.Controls.Add(this.labelExplanation);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonClose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "SettingForm";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSC3;
        private System.Windows.Forms.Label labelSC2;
        private System.Windows.Forms.Label labelSC1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelExplanation;
        private System.Windows.Forms.Button SCdelete1;
        private System.Windows.Forms.Button SCdelete3;
        private System.Windows.Forms.Button SCdelete2;
    }
}