namespace LabExer
{
    partial class FrmLab1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(55, 62);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(311, 53);
            this.txtInput.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCreate.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreate.Location = new System.Drawing.Point(146, 134);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(128, 44);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistration.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistration.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegistration.Location = new System.Drawing.Point(163, 193);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(93, 30);
            this.btnRegistration.TabIndex = 2;
            this.btnRegistration.Text = "Registration";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(48, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create File";
            // 
            // FrmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(418, 245);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmLab1";
            this.Text = "FrmLab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Label label1;
    }
}

