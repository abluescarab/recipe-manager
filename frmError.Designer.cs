namespace recipe_manager {
	partial class frmError {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblError = new System.Windows.Forms.Label();
			this.rtbError = new System.Windows.Forms.RichTextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCopy = new System.Windows.Forms.Button();
			this.lblContact = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.Location = new System.Drawing.Point(12, 9);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(210, 14);
			this.lblError.TabIndex = 1000;
			this.lblError.Text = "The following error has occured:";
			// 
			// rtbError
			// 
			this.rtbError.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.rtbError.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbError.Location = new System.Drawing.Point(12, 26);
			this.rtbError.Name = "rtbError";
			this.rtbError.ReadOnly = true;
			this.rtbError.Size = new System.Drawing.Size(346, 61);
			this.rtbError.TabIndex = 0;
			this.rtbError.Text = "asd\nasda\nsd\nasd\nasd\nas\nda\nsd\nadsa\nd\nasd\nas\nda\nsda\nd\nsa\ndas\nda\nda\ns";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(251, 115);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(107, 27);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCopy
			// 
			this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCopy.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCopy.Location = new System.Drawing.Point(138, 115);
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(107, 27);
			this.btnCopy.TabIndex = 1;
			this.btnCopy.Text = "Copy Error";
			this.btnCopy.UseVisualStyleBackColor = true;
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// lblContact
			// 
			this.lblContact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lblContact.AutoSize = true;
			this.lblContact.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblContact.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.lblContact.Location = new System.Drawing.Point(232, 90);
			this.lblContact.Name = "lblContact";
			this.lblContact.Size = new System.Drawing.Size(126, 14);
			this.lblContact.TabIndex = 1001;
			this.lblContact.Text = "Send me this error.";
			this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
			this.lblContact.MouseEnter += new System.EventHandler(this.lblContact_MouseEnter);
			this.lblContact.MouseLeave += new System.EventHandler(this.lblContact_MouseLeave);
			// 
			// frmError
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(370, 154);
			this.ControlBox = false;
			this.Controls.Add(this.lblContact);
			this.Controls.Add(this.btnCopy);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.rtbError);
			this.Controls.Add(this.lblError);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmError";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Error";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.RichTextBox rtbError;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label lblContact;
	}
}