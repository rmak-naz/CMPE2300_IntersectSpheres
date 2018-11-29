namespace ICA7_IntersectSpheres
{
    partial class ICA7_IntersectSpheres
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
            this.B_Distinct = new System.Windows.Forms.Button();
            this.B_Clip = new System.Windows.Forms.Button();
            this.B_Intersect = new System.Windows.Forms.Button();
            this.B_Union = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RB_Salmon = new System.Windows.Forms.RadioButton();
            this.RB_Purple = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // B_Distinct
            // 
            this.B_Distinct.Location = new System.Drawing.Point(13, 13);
            this.B_Distinct.Name = "B_Distinct";
            this.B_Distinct.Size = new System.Drawing.Size(111, 23);
            this.B_Distinct.TabIndex = 0;
            this.B_Distinct.Text = "Distinct Duplicates";
            this.B_Distinct.UseVisualStyleBackColor = true;
            this.B_Distinct.Click += new System.EventHandler(this.B_Distinct_Click);
            // 
            // B_Clip
            // 
            this.B_Clip.Location = new System.Drawing.Point(13, 42);
            this.B_Clip.Name = "B_Clip";
            this.B_Clip.Size = new System.Drawing.Size(111, 23);
            this.B_Clip.TabIndex = 1;
            this.B_Clip.Text = "Remove Clips";
            this.B_Clip.UseVisualStyleBackColor = true;
            this.B_Clip.Click += new System.EventHandler(this.B_Clip_Click);
            // 
            // B_Intersect
            // 
            this.B_Intersect.Location = new System.Drawing.Point(13, 180);
            this.B_Intersect.Name = "B_Intersect";
            this.B_Intersect.Size = new System.Drawing.Size(111, 23);
            this.B_Intersect.TabIndex = 2;
            this.B_Intersect.Text = "Show Ball Intersect";
            this.B_Intersect.UseVisualStyleBackColor = true;
            this.B_Intersect.Click += new System.EventHandler(this.B_Intersect_Click);
            // 
            // B_Union
            // 
            this.B_Union.Location = new System.Drawing.Point(13, 151);
            this.B_Union.Name = "B_Union";
            this.B_Union.Size = new System.Drawing.Size(111, 23);
            this.B_Union.TabIndex = 3;
            this.B_Union.Text = "Show Ball Union";
            this.B_Union.UseVisualStyleBackColor = true;
            this.B_Union.Click += new System.EventHandler(this.B_Union_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RB_Salmon);
            this.groupBox1.Controls.Add(this.RB_Purple);
            this.groupBox1.Location = new System.Drawing.Point(13, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 73);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ball List Color";
            // 
            // RB_Salmon
            // 
            this.RB_Salmon.AutoSize = true;
            this.RB_Salmon.Location = new System.Drawing.Point(7, 43);
            this.RB_Salmon.Name = "RB_Salmon";
            this.RB_Salmon.Size = new System.Drawing.Size(60, 17);
            this.RB_Salmon.TabIndex = 1;
            this.RB_Salmon.Text = "Salmon";
            this.RB_Salmon.UseVisualStyleBackColor = true;
            // 
            // RB_Purple
            // 
            this.RB_Purple.AutoSize = true;
            this.RB_Purple.Checked = true;
            this.RB_Purple.Location = new System.Drawing.Point(7, 20);
            this.RB_Purple.Name = "RB_Purple";
            this.RB_Purple.Size = new System.Drawing.Size(55, 17);
            this.RB_Purple.TabIndex = 0;
            this.RB_Purple.TabStop = true;
            this.RB_Purple.Text = "Purple";
            this.RB_Purple.UseVisualStyleBackColor = true;
            // 
            // ICA7_IntersectSpheres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(143, 221);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_Union);
            this.Controls.Add(this.B_Intersect);
            this.Controls.Add(this.B_Clip);
            this.Controls.Add(this.B_Distinct);
            this.Name = "ICA7_IntersectSpheres";
            this.Text = "ICA 7 Spheres";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Distinct;
        private System.Windows.Forms.Button B_Clip;
        private System.Windows.Forms.Button B_Intersect;
        private System.Windows.Forms.Button B_Union;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RB_Salmon;
        private System.Windows.Forms.RadioButton RB_Purple;
    }
}

