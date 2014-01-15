namespace recipe_manager {
	partial class frmRating {
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
			this.lblRating = new System.Windows.Forms.Label();
			this.cmbRating = new System.Windows.Forms.ComboBox();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblRating
			// 
			this.lblRating.AutoSize = true;
			this.lblRating.Location = new System.Drawing.Point(12, 17);
			this.lblRating.Name = "lblRating";
			this.lblRating.Size = new System.Drawing.Size(41, 13);
			this.lblRating.TabIndex = 0;
			this.lblRating.Text = "Rating:";
			// 
			// cmbRating
			// 
			this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbRating.FormattingEnabled = true;
			this.cmbRating.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
			this.cmbRating.Location = new System.Drawing.Point(59, 13);
			this.cmbRating.Name = "cmbRating";
			this.cmbRating.Size = new System.Drawing.Size(55, 21);
			this.cmbRating.TabIndex = 1;
			// 
			// btnOk
			// 
			this.btnOk.Location = new System.Drawing.Point(12, 49);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(102, 23);
			this.btnOk.TabIndex = 2;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// frmRating
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(126, 84);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.cmbRating);
			this.Controls.Add(this.lblRating);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRating";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Set Rating";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRating;
		private System.Windows.Forms.ComboBox cmbRating;
		private System.Windows.Forms.Button btnOk;
	}
}