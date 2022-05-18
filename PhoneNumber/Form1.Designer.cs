
namespace PhoneNumber
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
            if (disposing && (components != null)) {
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
            this.direction = new System.Windows.Forms.Label();
            this.tb_bottom = new System.Windows.Forms.TrackBar();
            this.tb_top = new System.Windows.Forms.TrackBar();
            this.cb_left = new System.Windows.Forms.CheckBox();
            this.cb_right = new System.Windows.Forms.CheckBox();
            this.phone = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.tb_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_top)).BeginInit();
            this.SuspendLayout();
            // 
            // direction
            // 
            this.direction.Location = new System.Drawing.Point(-2, 9);
            this.direction.Name = "direction";
            this.direction.Size = new System.Drawing.Size(279, 23);
            this.direction.TabIndex = 0;
            this.direction.Text = "Please enter your Phone Number.";
            this.direction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_bottom
            // 
            this.tb_bottom.Location = new System.Drawing.Point(13, 109);
            this.tb_bottom.Maximum = 2147483646;
            this.tb_bottom.Name = "tb_bottom";
            this.tb_bottom.Size = new System.Drawing.Size(251, 45);
            this.tb_bottom.TabIndex = 1;
            this.tb_bottom.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_bottom.Scroll += new System.EventHandler(this.tb_bottom_Scroll);
            // 
            // tb_top
            // 
            this.tb_top.Location = new System.Drawing.Point(12, 58);
            this.tb_top.Maximum = 2147483646;
            this.tb_top.Name = "tb_top";
            this.tb_top.Size = new System.Drawing.Size(251, 45);
            this.tb_top.TabIndex = 2;
            this.tb_top.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_top.Scroll += new System.EventHandler(this.tb_top_Scroll);
            // 
            // cb_left
            // 
            this.cb_left.AutoSize = true;
            this.cb_left.Location = new System.Drawing.Point(13, 35);
            this.cb_left.Name = "cb_left";
            this.cb_left.Size = new System.Drawing.Size(60, 17);
            this.cb_left.TabIndex = 3;
            this.cb_left.Text = "A3B4D";
            this.cb_left.UseVisualStyleBackColor = true;
            this.cb_left.CheckedChanged += new System.EventHandler(this.cb_left_CheckedChanged);
            // 
            // cb_right
            // 
            this.cb_right.AutoSize = true;
            this.cb_right.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cb_right.Location = new System.Drawing.Point(200, 35);
            this.cb_right.Name = "cb_right";
            this.cb_right.Size = new System.Drawing.Size(62, 17);
            this.cb_right.TabIndex = 4;
            this.cb_right.Text = "C1PUO";
            this.cb_right.UseVisualStyleBackColor = true;
            this.cb_right.CheckedChanged += new System.EventHandler(this.cb_right_CheckedChanged);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.Location = new System.Drawing.Point(-5, 32);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(282, 23);
            this.phone.TabIndex = 5;
            this.phone.Text = "(000) 000-0000";
            this.phone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(187, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(94, 150);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(87, 23);
            this.submitButton.TabIndex = 8;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 183);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_right);
            this.Controls.Add(this.cb_left);
            this.Controls.Add(this.tb_top);
            this.Controls.Add(this.tb_bottom);
            this.Controls.Add(this.direction);
            this.Controls.Add(this.phone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.helpProvider1.SetHelpString(this, "May god have mercy on you.");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Phone Number";
            ((System.ComponentModel.ISupportInitialize)(this.tb_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_top)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label direction;
        private System.Windows.Forms.TrackBar tb_bottom;
        private System.Windows.Forms.TrackBar tb_top;
        private System.Windows.Forms.CheckBox cb_left;
        private System.Windows.Forms.CheckBox cb_right;
        private System.Windows.Forms.Label phone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

