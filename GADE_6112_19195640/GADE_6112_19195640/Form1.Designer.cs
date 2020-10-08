namespace GADE_6112_19195640
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
            this.MAPBOX = new System.Windows.Forms.RichTextBox();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnLEFT = new System.Windows.Forms.Button();
            this.btnRIGHT = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.lblMC = new System.Windows.Forms.Label();
            this.STATBOX = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MAPBOX
            // 
            this.MAPBOX.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAPBOX.Location = new System.Drawing.Point(13, 13);
            this.MAPBOX.Name = "MAPBOX";
            this.MAPBOX.Size = new System.Drawing.Size(433, 437);
            this.MAPBOX.TabIndex = 1;
            this.MAPBOX.Text = "";
            // 
            // btnUP
            // 
            this.btnUP.Location = new System.Drawing.Point(534, 77);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(99, 32);
            this.btnUP.TabIndex = 2;
            this.btnUP.Text = "UP";
            this.btnUP.UseVisualStyleBackColor = true;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnLEFT
            // 
            this.btnLEFT.Location = new System.Drawing.Point(467, 128);
            this.btnLEFT.Name = "btnLEFT";
            this.btnLEFT.Size = new System.Drawing.Size(99, 32);
            this.btnLEFT.TabIndex = 3;
            this.btnLEFT.Text = "LEFT";
            this.btnLEFT.UseVisualStyleBackColor = true;
            this.btnLEFT.Click += new System.EventHandler(this.btnLEFT_Click);
            // 
            // btnRIGHT
            // 
            this.btnRIGHT.Location = new System.Drawing.Point(604, 128);
            this.btnRIGHT.Name = "btnRIGHT";
            this.btnRIGHT.Size = new System.Drawing.Size(99, 32);
            this.btnRIGHT.TabIndex = 4;
            this.btnRIGHT.Text = "RIGHT";
            this.btnRIGHT.UseVisualStyleBackColor = true;
            this.btnRIGHT.Click += new System.EventHandler(this.btnRIGHT_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(534, 182);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(99, 32);
            this.btnDown.TabIndex = 5;
            this.btnDown.Text = "DOWN";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Location = new System.Drawing.Point(535, 34);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(98, 13);
            this.lblMC.TabIndex = 6;
            this.lblMC.Text = "Movement Controls";
            // 
            // STATBOX
            // 
            this.STATBOX.Location = new System.Drawing.Point(467, 268);
            this.STATBOX.Name = "STATBOX";
            this.STATBOX.Size = new System.Drawing.Size(236, 182);
            this.STATBOX.TabIndex = 7;
            this.STATBOX.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 462);
            this.Controls.Add(this.STATBOX);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRIGHT);
            this.Controls.Add(this.btnLEFT);
            this.Controls.Add(this.btnUP);
            this.Controls.Add(this.MAPBOX);
            this.Name = "Form1";
            this.Text = "Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox MAPBOX;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.Button btnLEFT;
        private System.Windows.Forms.Button btnRIGHT;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.RichTextBox STATBOX;
        private System.Windows.Forms.Timer timer1;
    }
}

