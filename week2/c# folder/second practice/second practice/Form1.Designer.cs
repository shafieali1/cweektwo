namespace second_practice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Frist_name = new System.Windows.Forms.TextBox();
            this.Txt_Second_name = new System.Windows.Forms.TextBox();
            this.btn_concat = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_ouput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Second Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_Frist_name
            // 
            this.Txt_Frist_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Frist_name.Location = new System.Drawing.Point(342, 16);
            this.Txt_Frist_name.Name = "Txt_Frist_name";
            this.Txt_Frist_name.Size = new System.Drawing.Size(255, 62);
            this.Txt_Frist_name.TabIndex = 2;
            // 
            // Txt_Second_name
            // 
            this.Txt_Second_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Second_name.Location = new System.Drawing.Point(342, 84);
            this.Txt_Second_name.Name = "Txt_Second_name";
            this.Txt_Second_name.Size = new System.Drawing.Size(255, 62);
            this.Txt_Second_name.TabIndex = 3;
            // 
            // btn_concat
            // 
            this.btn_concat.Location = new System.Drawing.Point(135, 266);
            this.btn_concat.Name = "btn_concat";
            this.btn_concat.Size = new System.Drawing.Size(221, 103);
            this.btn_concat.TabIndex = 4;
            this.btn_concat.Text = "concatination";
            this.btn_concat.UseVisualStyleBackColor = true;
            this.btn_concat.Click += new System.EventHandler(this.btn_concat_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(411, 266);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(221, 103);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.Text = "clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_ouput
            // 
            this.lbl_ouput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ouput.Location = new System.Drawing.Point(67, 158);
            this.lbl_ouput.Name = "lbl_ouput";
            this.lbl_ouput.Size = new System.Drawing.Size(620, 82);
            this.lbl_ouput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_ouput);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_concat);
            this.Controls.Add(this.Txt_Second_name);
            this.Controls.Add(this.Txt_Frist_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Frist_name;
        private System.Windows.Forms.TextBox Txt_Second_name;
        private System.Windows.Forms.Button btn_concat;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_ouput;
    }
}

