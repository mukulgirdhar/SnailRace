namespace SnailRace
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bntStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSnails = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxBetters = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bntStart
            // 
            this.bntStart.Font = new System.Drawing.Font("DrippyPlums", 9.749999F, System.Drawing.FontStyle.Bold);
            this.bntStart.Location = new System.Drawing.Point(95, 106);
            this.bntStart.Margin = new System.Windows.Forms.Padding(4);
            this.bntStart.Name = "bntStart";
            this.bntStart.Size = new System.Drawing.Size(100, 28);
            this.bntStart.TabIndex = 0;
            this.bntStart.Text = "Start";
            this.bntStart.UseVisualStyleBackColor = true;
            this.bntStart.Click += new System.EventHandler(this.bntStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("DrippyPlums", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Snails";
            // 
            // cbxSnails
            // 
            this.cbxSnails.Font = new System.Drawing.Font("DrippyPlums", 8.25F);
            this.cbxSnails.FormattingEnabled = true;
            this.cbxSnails.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.cbxSnails.Location = new System.Drawing.Point(108, 11);
            this.cbxSnails.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSnails.Name = "cbxSnails";
            this.cbxSnails.Size = new System.Drawing.Size(160, 22);
            this.cbxSnails.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("DrippyPlums", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Betters";
            // 
            // cbxBetters
            // 
            this.cbxBetters.Font = new System.Drawing.Font("DrippyPlums", 8.25F);
            this.cbxBetters.FormattingEnabled = true;
            this.cbxBetters.Items.AddRange(new object[] {
            1,
            2,
            3,
            4,
            5,
            6,
            7,
            8,
            9,
            10});
            this.cbxBetters.Location = new System.Drawing.Point(108, 73);
            this.cbxBetters.Margin = new System.Windows.Forms.Padding(4);
            this.cbxBetters.Name = "cbxBetters";
            this.cbxBetters.Size = new System.Drawing.Size(160, 22);
            this.cbxBetters.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 142);
            this.Controls.Add(this.cbxBetters);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxSnails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntStart);
            this.Font = new System.Drawing.Font("DrippyPlums", 9.749999F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Race Conditions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSnails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxBetters;
    }
}