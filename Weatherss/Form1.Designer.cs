namespace Weatherss
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
            this.lbl_textCity = new System.Windows.Forms.Label();
            this.lbl_Country = new System.Windows.Forms.Label();
            this.lbl_DoCe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Day = new System.Windows.Forms.Label();
            this.lbl_Conditions = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_speed = new System.Windows.Forms.Label();
            this.lbl_Des2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_textCity
            // 
            this.lbl_textCity.AutoSize = true;
            this.lbl_textCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_textCity.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_textCity.Location = new System.Drawing.Point(12, 19);
            this.lbl_textCity.Name = "lbl_textCity";
            this.lbl_textCity.Size = new System.Drawing.Size(251, 54);
            this.lbl_textCity.TabIndex = 0;
            this.lbl_textCity.Text = "Thành Phố";
            this.lbl_textCity.Click += new System.EventHandler(this.lbl_textCity_Click);
            // 
            // lbl_Country
            // 
            this.lbl_Country.AutoSize = true;
            this.lbl_Country.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Country.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Country.Location = new System.Drawing.Point(12, 92);
            this.lbl_Country.Name = "lbl_Country";
            this.lbl_Country.Size = new System.Drawing.Size(221, 54);
            this.lbl_Country.TabIndex = 1;
            this.lbl_Country.Text = "Quốc Gia";
            // 
            // lbl_DoCe
            // 
            this.lbl_DoCe.AutoSize = true;
            this.lbl_DoCe.Font = new System.Drawing.Font("Microsoft Sans Serif", 46F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoCe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_DoCe.Location = new System.Drawing.Point(12, 166);
            this.lbl_DoCe.Name = "lbl_DoCe";
            this.lbl_DoCe.Size = new System.Drawing.Size(75, 71);
            this.lbl_DoCe.TabIndex = 2;
            this.lbl_DoCe.Text = "C";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Forcast";
            // 
            // lbl_Day
            // 
            this.lbl_Day.AutoSize = true;
            this.lbl_Day.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Day.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Day.Location = new System.Drawing.Point(343, 92);
            this.lbl_Day.Name = "lbl_Day";
            this.lbl_Day.Size = new System.Drawing.Size(131, 54);
            this.lbl_Day.TabIndex = 4;
            this.lbl_Day.Text = "Days";
            // 
            // lbl_Conditions
            // 
            this.lbl_Conditions.AutoSize = true;
            this.lbl_Conditions.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Conditions.ForeColor = System.Drawing.Color.Lime;
            this.lbl_Conditions.Location = new System.Drawing.Point(343, 166);
            this.lbl_Conditions.Name = "lbl_Conditions";
            this.lbl_Conditions.Size = new System.Drawing.Size(244, 54);
            this.lbl_Conditions.TabIndex = 5;
            this.lbl_Conditions.Text = "Conditions";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbl_Description.Location = new System.Drawing.Point(343, 241);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(258, 54);
            this.lbl_Description.TabIndex = 6;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_speed
            // 
            this.lbl_speed.AutoSize = true;
            this.lbl_speed.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_speed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_speed.Location = new System.Drawing.Point(623, 92);
            this.lbl_speed.Name = "lbl_speed";
            this.lbl_speed.Size = new System.Drawing.Size(196, 54);
            this.lbl_speed.TabIndex = 7;
            this.lbl_speed.Text = "12 Km/h";
            // 
            // lbl_Des2
            // 
            this.lbl_Des2.AutoSize = true;
            this.lbl_Des2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Des2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lbl_Des2.Location = new System.Drawing.Point(623, 241);
            this.lbl_Des2.Name = "lbl_Des2";
            this.lbl_Des2.Size = new System.Drawing.Size(75, 54);
            this.lbl_Des2.TabIndex = 8;
            this.lbl_Des2.Text = "26";
            this.lbl_Des2.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Des2);
            this.Controls.Add(this.lbl_speed);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Conditions);
            this.Controls.Add(this.lbl_Day);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_DoCe);
            this.Controls.Add(this.lbl_Country);
            this.Controls.Add(this.lbl_textCity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_textCity;
        private System.Windows.Forms.Label lbl_Country;
        private System.Windows.Forms.Label lbl_DoCe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Day;
        private System.Windows.Forms.Label lbl_Conditions;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_speed;
        private System.Windows.Forms.Label lbl_Des2;
    }
}

