namespace X_OX
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(211, 143);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(158, 35);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "New Game";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.New_Game_Click);
            this.btn1.MouseEnter += new System.EventHandler(this.Mouse_Enter_Button);
            this.btn1.MouseLeave += new System.EventHandler(this.Mouse_Leave_Button);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(211, 200);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(158, 35);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Settings";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Settings_Click);
            this.btn2.MouseEnter += new System.EventHandler(this.Mouse_Enter_Button);
            this.btn2.MouseLeave += new System.EventHandler(this.Mouse_Leave_Button);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(211, 257);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(158, 35);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "Exit";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Exit_Click);
            this.btn3.MouseEnter += new System.EventHandler(this.Mouse_Enter_Button);
            this.btn3.MouseLeave += new System.EventHandler(this.Mouse_Leave_Button);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::X_OX.Properties.Resources.tic_tac_toe1;
            this.ClientSize = new System.Drawing.Size(562, 346);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

