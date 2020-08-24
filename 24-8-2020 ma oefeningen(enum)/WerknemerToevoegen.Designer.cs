namespace _24_8_2020_ma_oefeningen_enum_
{
    partial class WerknemerToevoegen
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
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.cbLandVanHerkomst = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWeekContract = new System.Windows.Forms.RadioButton();
            this.rbMaandContract = new System.Windows.Forms.RadioButton();
            this.nudBrutoSalaris = new System.Windows.Forms.NumericUpDown();
            this.nudPercent = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrutoSalaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(107, 76);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 26);
            this.tbNaam.TabIndex = 0;
            // 
            // cbLandVanHerkomst
            // 
            this.cbLandVanHerkomst.FormattingEnabled = true;
            this.cbLandVanHerkomst.Location = new System.Drawing.Point(269, 76);
            this.cbLandVanHerkomst.Name = "cbLandVanHerkomst";
            this.cbLandVanHerkomst.Size = new System.Drawing.Size(121, 28);
            this.cbLandVanHerkomst.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWeekContract);
            this.groupBox1.Controls.Add(this.rbMaandContract);
            this.groupBox1.Location = new System.Drawing.Point(107, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
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
            this.rbMaandContract.Checked = true;
            this.rbMaandContract.Location = new System.Drawing.Point(6, 37);
            this.rbMaandContract.Name = "rbMaandContract";
            this.rbMaandContract.Size = new System.Drawing.Size(148, 24);
            this.rbMaandContract.TabIndex = 0;
            this.rbMaandContract.TabStop = true;
            this.rbMaandContract.Text = "Maand Contract";
            this.rbMaandContract.UseVisualStyleBackColor = true;
            // 
            // nudBrutoSalaris
            // 
            this.nudBrutoSalaris.DecimalPlaces = 2;
            this.nudBrutoSalaris.Location = new System.Drawing.Point(341, 165);
            this.nudBrutoSalaris.Maximum = new decimal(new int[] {
            1661992959,
            1808227885,
            5,
            0});
            this.nudBrutoSalaris.Name = "nudBrutoSalaris";
            this.nudBrutoSalaris.Size = new System.Drawing.Size(120, 26);
            this.nudBrutoSalaris.TabIndex = 5;
            this.nudBrutoSalaris.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // nudPercent
            // 
            this.nudPercent.Location = new System.Drawing.Point(341, 230);
            this.nudPercent.Name = "nudPercent";
            this.nudPercent.Size = new System.Drawing.Size(120, 26);
            this.nudPercent.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Land Van Herkomst";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Bruto Loon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Percent";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(113, 306);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 38);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(330, 306);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 38);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // WerknemerToevoegen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 356);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPercent);
            this.Controls.Add(this.nudBrutoSalaris);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbLandVanHerkomst);
            this.Controls.Add(this.tbNaam);
            this.Name = "WerknemerToevoegen";
            this.Text = "WerknemerToevoegen";
            this.Load += new System.EventHandler(this.WerknemerToevoegen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrutoSalaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.ComboBox cbLandVanHerkomst;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbWeekContract;
        private System.Windows.Forms.RadioButton rbMaandContract;
        private System.Windows.Forms.NumericUpDown nudBrutoSalaris;
        private System.Windows.Forms.NumericUpDown nudPercent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
    }
}