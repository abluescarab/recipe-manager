using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace recipe_manager {
	public partial class frmRating : Form {
		public int NewRating {get; set;}

		public frmRating(int currentRating) {
			InitializeComponent();
			cmbRating.SelectedItem = currentRating.ToString();
		}

		private void btnOk_Click(object sender, EventArgs e) {
			this.NewRating = Convert.ToInt32(cmbRating.SelectedItem);
			this.DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
