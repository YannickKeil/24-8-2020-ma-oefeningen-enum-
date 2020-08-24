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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWeekContract = new System.Windows.Forms.RadioButton();
            this.rbMaandContract = new System.Windows.Forms.RadioButton();
            this.cbBedrijf = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbWerknemers
            // 
            this.cbWerknemers.FormattingEnabled = true;
            this.cbWerknemers.Location = new System.Drawing.Point(250, 97);
            this.cbWerknemers.Name = "cbWerknemers";
            this.cbWerknemers.Size = new System.Drawing.Size(121, 28);
            this.cbWerknemers.TabIndex = 0;
            this.cbWerknemers.SelectedIndexChanged += new System.EventHandler(this.cbWerknemers_SelectedIndexChanged);
            // 
            // lSalaris
            // 
            this.lSalaris.AutoSize = true;
            this.lSalaris.Location = new System.Drawing.Point(438, 97);
            this.lSalaris.Name = "lSalaris";
            this.lSalaris.Size = new System.Drawing.Size(54, 20);
            this.lSalaris.TabIndex = 1;
            this.lSalaris.Text = "salaris";
            // 
            // lLandVanHerkomst
            // 
            this.lLandVanHerkomst.AutoSize = true;
            this.lLandVanHerkomst.Location = new System.Drawing.Point(438, 128);
            this.lLandVanHerkomst.Name = "lLandVanHerkomst";
            this.lLandVanHerkomst.Size = new System.Drawing.Size(45, 20);
            this.lLandVanHerkomst.TabIndex = 2;
            this.lLandVanHerkomst.Text = "Land";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWeekContract);
            this.groupBox1.Controls.Add(this.rbMaandContract);
            this.groupBox1.Location = new System.Drawing.Point(442, 167);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "maand of week contract";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbWeekContract
            // 
            this.rbWeekContract.AutoSize = true;
            this.rbWeekContract.Location = new System.Drawing.Point(6, 77);
            this.rbWeekContract.Name = "rbWeekContract";
            this.rbWeekContract.Size = new System.Drawing.Size(140, 24);
            this.rbWeekContract.TabIndex = 1;
            this.rbWeekContract.Text = "Week Contract";
            this.rbWeekContract.UseVisualStyleBackColor = true;
            // 
            // rbMaandContract
            // 
            this.rbMaandContract.AutoSize = true;
            this.rbMaandContract.Location = new System.Drawing.Point(6, 37);
            this.rbMaandContract.Name = "rbMaandContract";
            this.rbMaandContract.Size = new System.Drawing.Size(148, 24);
            this.rbMaandContract.TabIndex = 0;
            this.rbMaandContract.Text = "Maand Contract";
            this.rbMaandContract.UseVisualStyleBackColor = true;
            // 
            // cbBedrijf
            // 
            this.cbBedrijf.FormattingEnabled = true;
            this.cbBedrijf.Location = new System.Drawing.Point(87, 97);
            this.cbBedrijf.Name = "cbBedrijf";
            this.cbBedrijf.Size = new System.Drawing.Size(121, 28);
            this.cbBedrijf.TabIndex = 4;
            this.cbBedrijf.SelectedIndexChanged += new System.EventHandler(this.cbBedrijf_SelectedIndexChanged);
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(250, 144);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(121, 64);
            this.btnToevoegen.TabIndex = 5;
            this.btnToevoegen.Text = "Voeg Persoon Toe";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(250, 229);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(121, 64);
            this.btnVerwijder.TabIndex = 6;
            this.btnVerwijder.Text = "Verwijder persoon";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 450);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnToevoegen);
            this.Controls.Add(this.cbBedrijf);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lLandVanHerkomst);
            this.Controls.Add(this.lSalaris);
            this.Controls.Add(this.cbWerknemers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbWerknemers;
        private System.Windows.Forms.Label lSalaris;
        private System.Windows.Forms.Label lLandVanHerkomst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWeekContract;
        private System.Windows.Forms.RadioButton rbMaandContract;
        private System.Windows.Forms.ComboBox cbBedrijf;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.Button btnVerwijder;
    }
}

