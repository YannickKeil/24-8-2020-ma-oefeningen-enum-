namespace _24_8_2020_ma_oefeningen_enum_
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
            this.cbWerknemers = new System.Windows.Forms.ComboBox();
            this.lSalaris = new System.Windows.Forms.Label();
            this.lLandVanHerkomst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(50, 58);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(121, 28);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // lSalaris
            // 
            this.lSalaris.AutoSize = true;
            this.lSalaris.Location = new System.Drawing.Point(278, 58);
            this.lSalaris.Name = "lSalaris";
            this.lSalaris.Size = new System.Drawing.Size(54, 20);
            this.lSalaris.TabIndex = 1;
            this.lSalaris.Text = "salaris";
            // 
            // lLandVanHerkomst
            // 
            this.lLandVanHerkomst.AutoSize = true;
            this.lLandVanHerkomst.Location = new System.Drawing.Point(278, 89);
            this.lLandVanHerkomst.Name = "lLandVanHerkomst";
            this.lLandVanHerkomst.Size = new System.Drawing.Size(45, 20);
            this.lLandVanHerkomst.TabIndex = 2;
            this.lLandVanHerkomst.Text = "Land";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lLandVanHerkomst);
            this.Controls.Add(this.lSalaris);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label lSalaris;
        private System.Windows.Forms.Label lLandVanHerkomst;
    }
}

