namespace Computer_Science_Project
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
            this.label3 = new System.Windows.Forms.Label();
            this.numOfTrials = new System.Windows.Forms.TextBox();
            this.numOfSucessfulTrials = new System.Windows.Forms.TextBox();
            this.nullHypothesis = new System.Windows.Forms.TextBox();
            this.significenceLevel = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.significenceLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How many trials where there?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "How many sucessful trials where there?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "What should should the probability of sucess been?";
            // 
            // numOfTrials
            // 
            this.numOfTrials.Location = new System.Drawing.Point(356, 30);
            this.numOfTrials.Name = "numOfTrials";
            this.numOfTrials.Size = new System.Drawing.Size(289, 20);
            this.numOfTrials.TabIndex = 3;
            this.numOfTrials.TextChanged += new System.EventHandler(this.numOfTrials_TextChanged);
            // 
            // numOfSucessfulTrials
            // 
            this.numOfSucessfulTrials.Location = new System.Drawing.Point(356, 56);
            this.numOfSucessfulTrials.Name = "numOfSucessfulTrials";
            this.numOfSucessfulTrials.Size = new System.Drawing.Size(289, 20);
            this.numOfSucessfulTrials.TabIndex = 4;
            this.numOfSucessfulTrials.TextChanged += new System.EventHandler(this.numOfSucessfulTrials_TextChanged);
            // 
            // nullHypothesis
            // 
            this.nullHypothesis.Location = new System.Drawing.Point(356, 82);
            this.nullHypothesis.Name = "nullHypothesis";
            this.nullHypothesis.Size = new System.Drawing.Size(289, 20);
            this.nullHypothesis.TabIndex = 5;
            this.nullHypothesis.TextChanged += new System.EventHandler(this.nullHypothesis_TextChanged);
            // 
            // significenceLevel
            // 
            this.significenceLevel.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.significenceLevel.Location = new System.Drawing.Point(356, 108);
            this.significenceLevel.Minimum = 1;
            this.significenceLevel.Name = "significenceLevel";
            this.significenceLevel.Size = new System.Drawing.Size(289, 45);
            this.significenceLevel.TabIndex = 6;
            this.significenceLevel.Value = 1;
            this.significenceLevel.Scroll += new System.EventHandler(this.significenceLevel_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "What significence level should the data be tested?";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(530, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 93);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.significenceLevel);
            this.Controls.Add(this.nullHypothesis);
            this.Controls.Add(this.numOfSucessfulTrials);
            this.Controls.Add(this.numOfTrials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.significenceLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numOfTrials;
        private System.Windows.Forms.TextBox numOfSucessfulTrials;
        private System.Windows.Forms.TextBox nullHypothesis;
        private System.Windows.Forms.TrackBar significenceLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

