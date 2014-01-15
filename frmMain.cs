﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO: Printing
 * TODO: Add icon
 * TODO: Better rating change form (or just click on rating to change)
 * TODO: Save column widths
 */

namespace recipe_manager {
	public partial class frmMain : Form {
		public frmMain() {
			InitializeComponent();
		}

		#region Main
		private void frmMain_Load(object sender, EventArgs e) {
			this.Size = new Size(Properties.Settings.Default.WindowWidth, Properties.Settings.Default.WindowHeight);
			optionsAutoNumber.Checked = Properties.Settings.Default.AutoNumberDirections;
			optionsSwitchTab.Checked = Properties.Settings.Default.SwitchTabAfterAdd;
			cmbSearch.SelectedIndex = Properties.Settings.Default.SearchBy;

			lblRating.ForeColor = Color.Orange;

			LoadRecipes();

			dgvRecipes.Sort(dgvRecipes.Columns["RecipeName"], ListSortDirection.Ascending);

			dgvRecipes.Font = new Font("Arial", 9, FontStyle.Regular);
			dgvRecipes.Columns["RecipeRating"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvRecipes.Columns["RecipeServes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
		}

		private void frmMain_Resize(object sender, EventArgs e) {
			Properties.Settings.Default.WindowWidth = this.Width;
			Properties.Settings.Default.WindowHeight = this.Height;
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.Default.Save();
		}

		private void recipesView_SelectionChanged(object sender, EventArgs e) {
			try {
				ShowCurrentRecipe();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e) {
			try {
				BindingSource bs = new BindingSource();
				StringBuilder filter = new StringBuilder();
				bs.DataSource = dgvRecipes.DataSource;

				switch(cmbSearch.SelectedIndex) {
					case 0:
						bs.Filter = "RecipeName like '%" + txtSearch.Text + "%' OR " +
									"RecipeCategory like '%" + txtSearch.Text + "%' OR " +
									"RecipeIngredients like '%" + txtSearch.Text + "%' OR " +
									"RecipeCountry like '%" + txtSearch.Text + "%'";
						break;
					case 1:
						bs.Filter = "RecipeName like '%" + txtSearch.Text + "%'";
						break;
					case 2:
						bs.Filter = "RecipeCategory like '%" + txtSearch.Text + "%'";
						break;
					case 3:
						bs.Filter = "RecipeIngredients like '%" + txtSearch.Text.ToString() + "%'";
						break;
					case 4:
						bs.Filter = "RecipeCountry like '%" + txtSearch.Text + "%'";
						break;
					default:
						break;
				}

				dgvRecipes.DataSource = bs;
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void lblRating_Click(object sender, EventArgs e) {
			using(frmRating frmRating = new frmRating(Convert.ToInt32(dgvRecipes.CurrentRow.Cells["RecipeRating"].Value))) {
				DialogResult result = frmRating.ShowDialog();

				if(result == DialogResult.OK) {
					try {
						using(SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.recipesdbConnectionString)) { 
							using(SqlCeCommand cmd = new SqlCeCommand()) {
								cmd.Connection = conn;

								cmd.CommandText = "UPDATE Recipes SET RecipeRating=@rating WHERE ID=@id;";
								cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = frmRating.NewRating;
								cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvRecipes.CurrentRow.Cells["ID"].Value;

								conn.Open();
								cmd.ExecuteNonQuery();
								conn.Close();
							}
						}

						LoadRecipes();
					}
					catch(Exception ex) {
						MessageBox.Show(ex.Message, "Error");
					}
				}
			}
		}

		private void dgvRecipes_KeyDown(object sender, KeyEventArgs e) {
			if(e.KeyCode == Keys.Delete) {
				DeleteRecipe();
			}
		}

		private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e) {
			Properties.Settings.Default.SearchBy = cmbSearch.SelectedIndex;
		}
		#endregion

		#region View Tab
		private void btnDelete_Click(object sender, EventArgs e) {
			DeleteRecipe();
		}

		private void btnPrint_Click(object sender, EventArgs e) {
			try {
				PrintRecipe();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void btnDelete_MouseHover(object sender, EventArgs e) {
			ToolTip tp = new ToolTip();

			tp.SetToolTip(btnDelete, "Delete");
		}

		private void btnPrint_MouseHover(object sender, EventArgs e) {
			ToolTip tp = new ToolTip();

			tp.SetToolTip(btnPrint, "Print");
		}
		#endregion

		#region Edit Tab
		private void btnEdit_Click(object sender, EventArgs e) {
			try {
				string ingredients = rtbEditIngredients.Text, directions = rtbEditDirections.Text;

				ingredients = ingredients.Replace('\n', '|');
				directions = directions.Replace('\n', '|');

				using(SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.recipesdbConnectionString)) {
					using(SqlCeCommand cmd = new SqlCeCommand()) {
						cmd.Connection = conn;

						cmd.CommandText = "UPDATE Recipes SET RecipeName=@name, RecipeRating=@rating, RecipeCategory=@categories, RecipeServes=@serves, RecipeCountry=@country, " +
											"RecipeIngredients=@ingredients, RecipeDirections=@directions, RecipeComment=@comment WHERE ID=@id;";
						cmd.Parameters.AddWithValue("@name", SqlDbType.Text).Value = txtEditName.Text;
						cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = numEditRating.Value.ToString();
						cmd.Parameters.AddWithValue("@categories", SqlDbType.Text).Value = txtEditCategories.Text;
						cmd.Parameters.AddWithValue("@serves", SqlDbType.Int).Value = numEditServes.Value.ToString();
						cmd.Parameters.AddWithValue("@country", SqlDbType.Text).Value = txtEditCountry.Text;
						cmd.Parameters.AddWithValue("@ingredients", SqlDbType.Text).Value = ingredients;
						cmd.Parameters.AddWithValue("@directions", SqlDbType.Text).Value = directions;
						cmd.Parameters.AddWithValue("@comment", SqlDbType.Text).Value = txtEditComment.Text;
						cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvRecipes.CurrentRow.Cells["ID"].Value;

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();
					}
				}

				LoadRecipes();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void btnClearChanges_Click(object sender, EventArgs e) {
			ShowCurrentRecipe();
		}
		#endregion

		#region Add Tab
		private void btnAdd_Click(object sender, EventArgs e) {
			try {
				string ingredients = rtbAddIngredients.Text, directions = rtbAddDirections.Text;

				ingredients = ingredients.Replace('\n', '|');
				directions = directions.Replace('\n', '|');

				using(SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.recipesdbConnectionString)) {
					using(SqlCeCommand cmd = new SqlCeCommand()) {
						cmd.Connection = conn;

						cmd.CommandText = "INSERT INTO Recipes (ID, RecipeName, RecipeRating, RecipeCategory, RecipeServes, RecipeCountry, RecipeIngredients, RecipeDirections, RecipeComment) VALUES " +
											"(@id, @name, @rating, @categories, @serves, @country, @ingredients, @directions, @comment);";
						cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvRecipes.Rows.Count;
						cmd.Parameters.AddWithValue("@name", SqlDbType.Text).Value = txtAddName.Text;
						cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = numAddRating.Value;
						cmd.Parameters.AddWithValue("@categories", SqlDbType.Text).Value = txtAddCategories.Text;
						cmd.Parameters.AddWithValue("@serves", SqlDbType.Int).Value = numAddServes.Value;
						cmd.Parameters.AddWithValue("@country", SqlDbType.Text).Value = txtAddCountry.Text;
						cmd.Parameters.AddWithValue("@ingredients", SqlDbType.Text).Value = ingredients;
						cmd.Parameters.AddWithValue("@directions", SqlDbType.Text).Value = directions;
						cmd.Parameters.AddWithValue("@comment", SqlDbType.Text).Value = txtAddComment.Text;

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();
					}
				}

				LoadRecipes();

				if(optionsSwitchTab.Checked) {
					tabControl.SelectedTab = tabView;
				}

				ClearAddFields();
			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error");
			}
		}

		private void btnClear_Click(object sender, EventArgs e) {
			ClearAddFields();
		}
		#endregion

		#region Menus
		private void filePrint_Click(object sender, EventArgs e) {
			PrintRecipe();
		}

		private void fileRefresh_Click(object sender, EventArgs e) {
			LoadRecipes();
		}

		private void fileExit_Click(object sender, EventArgs e) {
			Application.Exit();
		}

		private void optionsAutoNumber_CheckStateChanged(object sender, EventArgs e) {
			ShowCurrentRecipe();
			Properties.Settings.Default.AutoNumberDirections = optionsAutoNumber.Checked;
		}

		private void optionsSwitchTab_CheckStateChanged(object sender, EventArgs e) {
			Properties.Settings.Default.SwitchTabAfterAdd = optionsSwitchTab.Checked;
		}

		private void helpAbluescarab_Click(object sender, EventArgs e) {
			Process.Start("http://www.abluescarab.us/");
		}

		private void helpGithub_Click(object sender, EventArgs e) {
			Process.Start("https://github.com/abluescarab/recipe-manager/releases");
		}

		private void helpChangelog_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + @"\Resources\changelog.txt");
		}

		private void helpHelp_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + @"\Resources\Recipe Manager Help.html");
		}

		private void helpAbout_Click(object sender, EventArgs e) {
			frmAbout frmAbout = new frmAbout();

			frmAbout.ShowDialog();
		}
		#endregion

		#region Functions
		private void LoadRecipes() {
			int currentRow = -1;

			this.recipesTableAdapter.Fill(this.recipesdbDataSet.Recipes);

			if(dgvRecipes.SelectedRows.Count > 0) {
				currentRow = dgvRecipes.CurrentRow.Index;
			}

			if(currentRow > -1) {
				dgvRecipes.CurrentCell = dgvRecipes.Rows[currentRow].Cells["RecipeName"];
				dgvRecipes.Rows[currentRow].Selected = true;

				if(!lblName.Enabled) {
					foreach(Control c in tabView.Controls) {
						c.Enabled = true;
					}
					foreach(Control c in tabEdit.Controls) {
						c.Enabled = true;
					}
				}

				// TODO: remove when printing is implemented
				btnPrint.Enabled = false;
			}
			else {
				foreach(Control c in tabView.Controls) {
					c.Enabled = false;
				}
				foreach(Control c in tabEdit.Controls) {
					c.Enabled = false;

					if(c is TextBox) {
						c.ResetText();
					}
				}

				lblName.Text = "Recipe Name";
				lblCountry.Text = "None";
				lblCategories.Text = "None";
				lblServes.Text = "0";

				rtbComment.ResetText();
				rtbIngredients.ResetText();
				rtbDirections.ResetText();

				rtbEditIngredients.ResetText();
				rtbEditDirections.ResetText();

				tabControl.SelectedTab = tabAdd;

				AlignLabels();
			}

			ShowCurrentRecipe();
		}

		private void PrintRecipe() {

		}

		private void ClearAddFields() {
			foreach(Control c in tabAdd.Controls) {
				if(c is TextBox) {
					c.ResetText();
				}
				else if(c is NumericUpDown) {
					c.Text = "0";
				}
			}

			rtbAddDirections.ResetText();
			rtbAddIngredients.ResetText();
		}

		private void ShowCurrentRecipe() {
			if(dgvRecipes.SelectedRows.Count > 0) {
				DataGridViewRow row = dgvRecipes.CurrentRow;
				string[] directionsArray = row.Cells["RecipeDirections"].Value.ToString().Split('|');
				string directions;

				lblName.Text           = txtEditName.Text        = row.Cells["RecipeName"].Value.ToString();
				lblCountry.Text        = txtEditCountry.Text     = row.Cells["RecipeCountry"].Value.ToString();
				rtbComment.Text       = txtEditComment.Text     = row.Cells["RecipeComment"].Value.ToString();
				lblCategories.Text     = txtEditCategories.Text  = row.Cells["RecipeCategory"].Value.ToString();
				rtbIngredients.Text    = rtbEditIngredients.Text = row.Cells["RecipeIngredients"].Value.ToString().Replace("|", Environment.NewLine);
				rtbEditDirections.Text = row.Cells["RecipeDirections"].Value.ToString().Replace("|", Environment.NewLine);
				lblServes.Text = row.Cells["RecipeServes"].Value.ToString();
				numEditServes.Value = Convert.ToInt32(row.Cells["RecipeServes"].Value);
				numEditRating.Value = Convert.ToInt32(row.Cells["RecipeRating"].Value);
				lblRating.Text      = "";

				for(int i = 1; i <= 5; i++) {
					if(i <= Convert.ToInt32(row.Cells["RecipeRating"].Value)) {
						lblRating.Text += "★";
					}
					else {
						lblRating.Text += "☆";
					}
				}

				if(optionsAutoNumber.Checked) {
					for(int i = 0; i < directionsArray.Length; i++) {
						directionsArray[i] = (i + 1) + ". " + directionsArray[i];
					}
				}

				directions = string.Join(Environment.NewLine, directionsArray);

				rtbDirections.Text = directions;

				AlignLabels();
			}
		}

		private void DeleteRecipe() {
			string name = dgvRecipes.CurrentRow.Cells["RecipeName"].Value.ToString();

			DialogResult delete = MessageBox.Show("Are you sure you want to delete " + name + "?", "Delete", MessageBoxButtons.YesNo);

			if(delete == DialogResult.Yes) {
				try {
					using(SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.recipesdbConnectionString)) {
						using(SqlCeCommand cmd = new SqlCeCommand()) {
							cmd.Connection = conn;

							cmd.CommandText = "DELETE FROM Recipes WHERE ID IN (" + dgvRecipes.CurrentRow.Cells["ID"].Value + ")";

							conn.Open();
							cmd.ExecuteNonQuery();
							conn.Close();

							dgvRecipes.Rows.Remove(dgvRecipes.CurrentRow);

							if(dgvRecipes.Rows.Count > 0) {
								ShowCurrentRecipe();
							}
							else {
								LoadRecipes();
							}
						}
					}
				}
				catch(Exception ex) {
					MessageBox.Show(ex.Message, "Error");
				}
			}
		}

		private void AlignLabels() {
			lblCountry.Left = lblName.Left + lblName.Width;
			lblRating.Left = lblName.Left + lblName.Width;
		}
		#endregion
	}
}
