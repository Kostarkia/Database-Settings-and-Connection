
namespace csharp_sql_connection_settings_via_form
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
            this.textDataSource = new System.Windows.Forms.TextBox();
            this.textInitialCatalog = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.numConnectionTimeout = new System.Windows.Forms.NumericUpDown();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeout)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Source";
            // 
            // textDataSource
            // 
            this.textDataSource.Location = new System.Drawing.Point(147, 20);
            this.textDataSource.Name = "textDataSource";
            this.textDataSource.Size = new System.Drawing.Size(100, 20);
            this.textDataSource.TabIndex = 1;
            // 
            // textInitialCatalog
            // 
            this.textInitialCatalog.Location = new System.Drawing.Point(147, 46);
            this.textInitialCatalog.Name = "textInitialCatalog";
            this.textInitialCatalog.Size = new System.Drawing.Size(100, 20);
            this.textInitialCatalog.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Initial Catalog";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(147, 72);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(100, 20);
            this.textUserID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "User ID";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(147, 98);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(100, 20);
            this.textPassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Integrated Security";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(7, 127);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(119, 13);
            this.label45.TabIndex = 8;
            this.label45.Text = "Connection Timeout(sn)";
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(118, 52);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // checkIntegratedSecurity
            // 
            this.checkIntegratedSecurity.AutoSize = true;
            this.checkIntegratedSecurity.Location = new System.Drawing.Point(147, 153);
            this.checkIntegratedSecurity.Name = "checkIntegratedSecurity";
            this.checkIntegratedSecurity.Size = new System.Drawing.Size(15, 14);
            this.checkIntegratedSecurity.TabIndex = 11;
            this.checkIntegratedSecurity.UseVisualStyleBackColor = true;
            // 
            // numConnectionTimeout
            // 
            this.numConnectionTimeout.Location = new System.Drawing.Point(147, 125);
            this.numConnectionTimeout.Name = "numConnectionTimeout";
            this.numConnectionTimeout.Size = new System.Drawing.Size(100, 20);
            this.numConnectionTimeout.TabIndex = 12;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonConnection.Location = new System.Drawing.Point(145, 0);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(114, 52);
            this.buttonConnection.TabIndex = 13;
            this.buttonConnection.Text = "Connection";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.ButtonConnection_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonConnection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 52);
            this.panel1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 257);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numConnectionTimeout);
            this.Controls.Add(this.checkIntegratedSecurity);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textInitialCatalog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textDataSource);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(275, 296);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 296);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Settings";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numConnectionTimeout)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textDataSource;
        private System.Windows.Forms.TextBox textInitialCatalog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkIntegratedSecurity;
        private System.Windows.Forms.NumericUpDown numConnectionTimeout;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Panel panel1;
    }
}

