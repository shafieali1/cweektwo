namespace my_project_c_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblplay = new System.Windows.Forms.Label();
            this.Practice_lanel = new System.Windows.Forms.Button();
            this.pcbxlogo = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblplay
            // 
            this.lblplay.AutoSize = true;
            this.lblplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblplay.Location = new System.Drawing.Point(128, 37);
            this.lblplay.Name = "lblplay";
            this.lblplay.Size = new System.Drawing.Size(53, 22);
            this.lblplay.TabIndex = 2;
            this.lblplay.Text = "label1";
            this.lblplay.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Practice_lanel
            // 
            this.Practice_lanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Practice_lanel.Location = new System.Drawing.Point(87, 98);
            this.Practice_lanel.Name = "Practice_lanel";
            this.Practice_lanel.Size = new System.Drawing.Size(145, 65);
            this.Practice_lanel.TabIndex = 0;
            this.Practice_lanel.Text = "Practice_label";
            this.Practice_lanel.UseVisualStyleBackColor = true;
            this.Practice_lanel.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcbxlogo
            // 
            this.pcbxlogo.Image = ((System.Drawing.Image)(resources.GetObject("pcbxlogo.Image")));
            this.pcbxlogo.Location = new System.Drawing.Point(477, 110);
            this.pcbxlogo.Name = "pcbxlogo";
            this.pcbxlogo.Size = new System.Drawing.Size(323, 210);
            this.pcbxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcbxlogo.TabIndex = 3;
            this.pcbxlogo.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(237, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 60);
            this.button2.TabIndex = 4;
            this.button2.Text = "Btn clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(345, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 60);
            this.button3.TabIndex = 5;
            this.button3.Text = "Btn close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 362);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pcbxlogo);
            this.Controls.Add(this.lblplay);
            this.Controls.Add(this.Practice_lanel);
            this.Name = "Form1";
            this.Text = "             bbm ";
            ((System.ComponentModel.ISupportInitialize)(this.pcbxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblplay;
        private System.Windows.Forms.Button Practice_lanel;
        private System.Windows.Forms.PictureBox pcbxlogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

