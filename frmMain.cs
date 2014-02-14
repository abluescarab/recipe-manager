// Rating Control from http://www.codeproject.com/Articles/9117/C-Star-Rating-Control
// Modified by Abluescarab Designs
using RatingControl;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * TODO: Save splitter width
 */

namespace recipe_manager {
	public partial class frmMain : Form {
		private frmError frmError = new frmError();

		private StarRatingControl ctlViewRating = new StarRatingControl(),
			ctlEditRating = new StarRatingControl(),
			ctlAddRating = new StarRatingControl();

		private int largestId = 0;
		private bool checkForUpdatesClicked = false;
		public static string downloadVersion = null;

		public frmMain() {
			InitializeComponent();

			// Star rating controls
			// Top
			ctlViewRating.Top = 28;
			ctlEditRating.Top = 
				ctlAddRating.Top = 94;
			// Left
			ctlEditRating.Left =
				ctlAddRating.Left = 111;
			// Height
			ctlViewRating.Height =
				ctlEditRating.Height =
				ctlAddRating.Height = 18;
			// Width
			ctlViewRating.Width =
				ctlEditRating.Width =
				ctlAddRating.Width = 100;
			// Star spacing
			ctlViewRating.StarSpacing =
				ctlEditRating.StarSpacing =
				ctlAddRating.StarSpacing = 5;

			// Gradient background
			ctlViewRating.GradientBackground =
				ctlEditRating.GradientBackground =
				ctlAddRating.GradientBackground = false;
			// Back color
			ctlViewRating.BackColor =
				ctlEditRating.BackColor =
				ctlAddRating.BackColor = Color.FromName("Window");
			// Selected star color
			ctlViewRating.SelectedColor =
				ctlEditRating.SelectedColor =
				ctlAddRating.SelectedColor = Color.FromArgb(255, 255, 208, 0);
			// Hover color
			ctlViewRating.HoverColor =
				ctlEditRating.HoverColor =
				ctlAddRating.HoverColor = Color.Yellow;

			// Add EventHandler for Click event
			ctlViewRating.Click += new EventHandler(ctlViewRating_Click);

			// Tab indices
			ctlEditRating.TabIndex =
				ctlAddRating.TabIndex = 3;

			// Add to the form
			tabView.Controls.Add(ctlViewRating);
			tabEdit.Controls.Add(ctlEditRating);
			tabAdd.Controls.Add(ctlAddRating);

			// Bring controls to the front
			ctlViewRating.BringToFront();
			ctlEditRating.BringToFront();
			ctlAddRating.BringToFront();
		}

		#region Main
		private void frmMain_Load(object sender, EventArgs e) {
			if(!Properties.Settings.Default.FirstRun) {
				// Location of window is screen-dependent, so only set
				// after program has been run once
				string[] windowLoc = Properties.Settings.Default.WindowLocation.Split(',');

				Left = Convert.ToInt32(windowLoc[0]);
				Top = Convert.ToInt32(windowLoc[1]);

				dlgBackup.InitialDirectory = Properties.Settings.Default.BackupDirectory;
				dlgRestore.InitialDirectory = Properties.Settings.Default.RestoreDirectory;
			}
			else {
				// Set initial directory of backup/restore dialogs
				dlgBackup.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
				dlgRestore.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();

				Properties.Settings.Default.FirstRun = false;
			}

			// If program was maximized, maximize again
			if(Properties.Settings.Default.IsMaximized) {
				WindowState = FormWindowState.Maximized;
			}

			// Get column widths
			string[] colWidths = Properties.Settings.Default.ColumnWidths.Split(',');

			dgvRecipes.Columns["RecipeName"].Width = Convert.ToInt32(colWidths[0]);
			dgvRecipes.Columns["RecipeRating"].Width = Convert.ToInt32(colWidths[1]);
			dgvRecipes.Columns["RecipeCategory"].Width = Convert.ToInt32(colWidths[2]);
			dgvRecipes.Columns["RecipeServes"].Width = Convert.ToInt32(colWidths[3]);
			dgvRecipes.Columns["RecipeCountry"].Width = Convert.ToInt32(colWidths[4]);

			// Change window size
			Size = new Size(Properties.Settings.Default.WindowWidth, Properties.Settings.Default.WindowHeight);

			// Change sort order
			string[] sortOrder = Properties.Settings.Default.SortOrder.Split(',');

			if(sortOrder[1] == "0") {
				dgvRecipes.Sort(dgvRecipes.Columns[Convert.ToInt32(sortOrder[0])], ListSortDirection.Ascending);
			}
			else {
				dgvRecipes.Sort(dgvRecipes.Columns[Convert.ToInt32(sortOrder[0])], ListSortDirection.Descending);
			}

			// Load miscellaneous options
			optionsAutoNumber.Checked = Properties.Settings.Default.AutoNumberDirections;
			optionsSwitchTab.Checked = Properties.Settings.Default.SwitchTabAfterAdd;
			cmbSearch.SelectedIndex = Properties.Settings.Default.SearchBy;

			// Change font, colors, and cell alignment
			dgvRecipes.Font = new Font("Arial", 9, FontStyle.Regular);
			dgvRecipes.DefaultCellStyle.SelectionBackColor = Color.Gainsboro;
			dgvRecipes.DefaultCellStyle.SelectionForeColor = Color.Black;
			dgvRecipes.Columns["RecipeRating"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dgvRecipes.Columns["RecipeServes"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

			// Load all the recipes into the datagridview
			LoadRecipes();

			// Keep track of largest ID for adding new recipes
			largestId = GetLargestId();

			// Set default options for creating and restoring backups
			dlgBackup.FileName = "recipes_" + DateTime.Now.ToString("yyyy-MM-dd_hh-mm-sstt") + ".bak";
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e) {
			// Save window state
			if(WindowState == FormWindowState.Maximized) {
				Properties.Settings.Default.IsMaximized = true;
			}
			else {
				Properties.Settings.Default.IsMaximized = false;
			}

			// Save column widths
			Properties.Settings.Default.ColumnWidths =
				dgvRecipes.Columns["RecipeName"].Width.ToString() + "," +
				dgvRecipes.Columns["RecipeRating"].Width.ToString() + "," +
				dgvRecipes.Columns["RecipeCategory"].Width.ToString() + "," +
				dgvRecipes.Columns["RecipeServes"].Width.ToString() + "," +
				dgvRecipes.Columns["RecipeCountry"].Width.ToString();
			
			// Save window location and size
			Properties.Settings.Default.WindowLocation = Left + "," + Top;
			Properties.Settings.Default.WindowWidth = this.Width;
			Properties.Settings.Default.WindowHeight = this.Height;

			// Save sort order
			if(dgvRecipes.SortOrder == System.Windows.Forms.SortOrder.Ascending) {
				Properties.Settings.Default.SortOrder = dgvRecipes.SortedColumn.Index + ",0";
			}
			else {
				Properties.Settings.Default.SortOrder = dgvRecipes.SortedColumn.Index + ",1";
			}

			// Save all settings
			Properties.Settings.Default.Save();
		}

		private void recipesView_SelectionChanged(object sender, EventArgs e) {
			ShowCurrentRecipe();
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
				frmError.ShowDialog(ex);
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

		private void ctlViewRating_Click(object sender, EventArgs e) {
			try {
				using(SqlCeConnection conn = new SqlCeConnection(Properties.Settings.Default.recipesdbConnectionString)) {
					using(SqlCeCommand cmd = new SqlCeCommand()) {
						cmd.Connection = conn;

						cmd.CommandText = "UPDATE Recipes SET RecipeRating=@rating WHERE ID=@id;";
						cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = ctlViewRating.SelectedStar;
						cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = dgvRecipes.CurrentRow.Cells["ID"].Value;

						conn.Open();
						cmd.ExecuteNonQuery();
						conn.Close();
					}
				}

				LoadRecipes();
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		private void dlgBackup_FileOk(object sender, CancelEventArgs e) {
			// +1 is to include the final backslash
			Properties.Settings.Default.BackupDirectory = dlgBackup.FileName.Remove(dlgBackup.FileName.LastIndexOf("\\") + 1);
			BackupRecipes(dlgBackup.FileName);
		}

		private void dlgRestore_FileOk(object sender, CancelEventArgs e) {
			// +1 is to include the final backslash
			Properties.Settings.Default.RestoreDirectory = dlgRestore.FileName.Remove(dlgRestore.FileName.LastIndexOf("\\") + 1);
			RestoreRecipes(dlgRestore.FileName);
		}
		#endregion

		#region View Tab
		private void btnDelete_Click(object sender, EventArgs e) {
			DeleteRecipe();
		}

		private void btnPrint_Click(object sender, EventArgs e) {
			PrintRecipe();
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
						cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = ctlEditRating.SelectedStar;
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
				frmError.ShowDialog(ex);
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
						cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = ++largestId;
						cmd.Parameters.AddWithValue("@name", SqlDbType.Text).Value = txtAddName.Text;
						cmd.Parameters.AddWithValue("@rating", SqlDbType.Int).Value = ctlAddRating.SelectedStar;
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
				frmError.ShowDialog(ex);
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

		private void fileBackup_Click(object sender, EventArgs e) {
			dlgBackup.ShowDialog();
		}

		private void fileRestore_Click(object sender, EventArgs e) {
			dlgRestore.ShowDialog();
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

		private void helpUpdates_Click(object sender, EventArgs e) {
			// TODO: Uncomment when Check for Updates works
			// checkForUpdatesClicked = true;
			// CheckForUpdates();
		}

		private void helpChangelog_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "\\Resources\\changelog.txt");
		}

		private void helpHelp_Click(object sender, EventArgs e) {
			Process.Start(Application.StartupPath + "\\Resources\\Recipe Manager Help.html");
		}

		private void helpAbout_Click(object sender, EventArgs e) {
			frmAbout frmAbout = new frmAbout();

			frmAbout.ShowDialog();
		}
		#endregion

		#region Functions
		/// <summary>
		/// Load the recipes from the database.
		/// </summary>
		private void LoadRecipes() {
			int currentRowId = -1;

			try {
				// if there is a row selected, save the ID column to reselect
				if(dgvRecipes.SelectedRows.Count > 0) {
					currentRowId = Convert.ToInt32(dgvRecipes.SelectedRows[0].Cells["ID"].Value.ToString());
				}

				this.recipesTableAdapter.Fill(this.recipesdbDataSet.Recipes);

				// if there are no rows in the datagridview, reset text
				// and disable controls
				if(dgvRecipes.Rows.Count < 1) {
					btnPrint.Enabled = false;
					filePrint.Enabled = false;

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

					ctlViewRating.SelectedStar = 0;
					ctlEditRating.SelectedStar = 0;

					AlignControls();
				}
				else {
					if(!btnPrint.Enabled && !filePrint.Enabled) {
						btnPrint.Enabled = true;
						filePrint.Enabled = true;
					}

					// if a row was already selected, reselect it
					if(currentRowId > -1) {
						dgvRecipes.ClearSelection();

						DataGridViewRow row = dgvRecipes.Rows
							.Cast<DataGridViewRow>()
							.Where(r => r.Cells["ID"].Value.ToString() == currentRowId.ToString())
							.First();

						dgvRecipes.Rows[row.Index].Selected = true;
						dgvRecipes.CurrentCell = dgvRecipes.SelectedRows[0].Cells["RecipeName"];
					}

					// re-enable all controls in the View and Edit tabs
					if(!lblName.Enabled) {
						foreach(Control c in tabView.Controls) {
							c.Enabled = true;
						}
						foreach(Control c in tabEdit.Controls) {
							c.Enabled = true;
						}
					}

					ShowCurrentRecipe();
				}
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		// TODO: Remove "not implemented" when it's... implemented.
		/// <summary>
		/// Checks for updates to the program. (NOT IMPLEMENTED)
		/// </summary>
		private void CheckForUpdates() {
			try {
				Cursor = Cursors.WaitCursor;

				frmConfirmUpdate frmConfirmUpdate = new frmConfirmUpdate();

				string versionFile = Application.StartupPath + "\\version.txt";
				string readmeFile = Application.StartupPath + "\\update.txt";
				string currentVersion = Application.ProductVersion;

				WebClient webClient = new WebClient();

				if(File.Exists(versionFile)) {
					File.Delete(versionFile);
				}

				webClient.DownloadFile("http://www.abluescarab.us/updates/recipe-manager/version.txt", versionFile);

				downloadVersion = File.ReadAllText(versionFile);

				if(compareVersions(currentVersion, downloadVersion) >= 0) {
					if(checkForUpdatesClicked) {
						MessageBox.Show("There are no updates available at this time.", "No Updates");
					}
				}
				else if(compareVersions(currentVersion, downloadVersion) == -1) {
					webClient.DownloadFile("http://www.abluescarab.us/updates/recipe-manager/" + downloadVersion + ".txt", readmeFile);
					frmConfirmUpdate.ShowDialog();
				}

				File.Delete(versionFile);
				File.Delete(readmeFile);

				checkForUpdatesClicked = false;

				Cursor = Cursors.Default;
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		/// <summary>
		/// Clear all fields in the Add tab.
		/// </summary>
		private void ClearAddFields() {
			foreach(Control c in tabAdd.Controls) {
				if(c is TextBox) {
					c.ResetText();
				}
				else if(c is NumericUpDown) {
					c.Text = "0";
				}
			}

			ctlAddRating.SelectedStar = 0;

			rtbAddDirections.ResetText();
			rtbAddIngredients.ResetText();
		}

		/// <summary>
		/// Show the currently-selected recipe in the View tab.
		/// </summary>
		private void ShowCurrentRecipe() {
			try {
				if(dgvRecipes.SelectedRows.Count > 0) {
					DataGridViewRow row = dgvRecipes.CurrentRow;
					string[] directionsArray = row.Cells["RecipeDirections"].Value.ToString().Split('|');
					string directions;

					// fill in the values in the View and Edit tabs
					lblName.Text = txtEditName.Text = row.Cells["RecipeName"].Value.ToString();
					lblCountry.Text = txtEditCountry.Text = row.Cells["RecipeCountry"].Value.ToString();
					rtbComment.Text = txtEditComment.Text = row.Cells["RecipeComment"].Value.ToString();
					lblCategories.Text = txtEditCategories.Text = row.Cells["RecipeCategory"].Value.ToString();
					rtbIngredients.Text = rtbEditIngredients.Text = row.Cells["RecipeIngredients"].Value.ToString().Replace("|", Environment.NewLine);
					rtbEditDirections.Text = row.Cells["RecipeDirections"].Value.ToString().Replace("|", Environment.NewLine);
					lblServes.Text = row.Cells["RecipeServes"].Value.ToString();
					numEditServes.Value = Convert.ToInt32(row.Cells["RecipeServes"].Value);
					ctlViewRating.SelectedStar = ctlEditRating.SelectedStar = Convert.ToInt32(row.Cells["RecipeRating"].Value);

					if(optionsAutoNumber.Checked) {
						// automatically number the directions steps
						for(int i = 0; i < directionsArray.Length; i++) {
							directionsArray[i] = (i + 1) + ". " + directionsArray[i];
						}
					}

					// combine the directions into one string
					directions = string.Join(Environment.NewLine, directionsArray);
					// and put them in the Directions richtextbox
					rtbDirections.Text = directions;

					// then align the "Country" and "Rating" controls on the View tab
					AlignControls();
				}
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		/// <summary>
		/// Delete a recipe.
		/// </summary>
		private void DeleteRecipe() {
			string name = dgvRecipes.CurrentRow.Cells["RecipeName"].Value.ToString();

			if(MessageBox.Show("Are you sure you want to delete " + name + "?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes) {
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
								// if there are still rows in the datagridview,
								// select the first one
								dgvRecipes.ClearSelection();
								dgvRecipes.Rows[0].Selected = true;
								dgvRecipes.CurrentCell = dgvRecipes.SelectedRows[0].Cells["RecipeName"];
								
								ShowCurrentRecipe();
							}
							else {
								LoadRecipes();

								// get the largest ID in the datagridview again
								largestId = GetLargestId();
							}
						}
					}
				}
				catch(Exception ex) {
					frmError.ShowDialog(ex);
				}
			}
		}

		/// <summary>
		/// Print the recipe.
		/// </summary>
		private void PrintRecipe() {
			string name = lblName.Text, country = lblCountry.Text, comment = rtbComment.Text,
 				serves = lblServes.Text, ingredients = rtbIngredients.Text, directions = rtbDirections.Text;

			Font arial = new Font("Arial", 24, FontStyle.Bold);

			if(dlgPrint.ShowDialog() == DialogResult.OK) {
				using(PrintDocument p = new PrintDocument()) {
					// copy the printer settings from the print dialog
					p.PrinterSettings = dlgPrint.PrinterSettings;

					p.PrintPage += delegate(object sender1, PrintPageEventArgs e) {
						Margins margins = new Margins(100, 100, 100, 100);

						// set the margins of the page
						p.DefaultPageSettings.Margins = margins;
						p.DocumentName = name;

						// create vars for the top, left, width, and height of the draw area
						int left = margins.Left, width = Convert.ToInt32(p.DefaultPageSettings.PrintableArea.Width) - margins.Right,
							top  = margins.Top,  height = Convert.ToInt32(p.DefaultPageSettings.PrintableArea.Height) - margins.Bottom;

						using(SolidBrush brush = new SolidBrush(Color.Black)) {
							e.Graphics.DrawString(name + " (" + country + ")", new Font("Arial", 24, FontStyle.Bold), brush, new RectangleF(left, top, width, height));
							e.Graphics.DrawString(comment, new Font("Arial", 10, FontStyle.Italic), brush, new RectangleF(left, (top += 50), width, height));
							e.Graphics.DrawString("Serves:", new Font("Arial", 12, FontStyle.Bold), brush, new RectangleF(left, (top += 50), width, height));
							e.Graphics.DrawString(serves, new Font("Arial", 12), brush, new RectangleF(left + 65, (top += 1), width, height));
							e.Graphics.DrawString("Ingredients:", new Font("Arial", 12, FontStyle.Bold), brush, new RectangleF(left, (top += 50), width, height));
							e.Graphics.DrawString("Directions:", new Font("Arial", 12, FontStyle.Bold), brush, new RectangleF(left + (width / 2), top, width / 2, height));
							e.Graphics.DrawString(ingredients, new Font("Arial", 12), brush, new RectangleF(left, (top += 25), width / 2, height));
							e.Graphics.DrawString(directions, new Font("Arial", 12), brush, new RectangleF(left + (width / 2), top, width / 2, height));
						}
					};

					try {
						p.Print();
					}
					catch(Exception ex) {
						frmError.ShowDialog(ex);
					}
				}
			}
		}

		/// <summary>
		/// Backup recipe database to specified location.
		/// </summary>
		/// <param name="file">Filename for backup</param>
		private void BackupRecipes(string file) {
			try {
				File.Copy(Application.StartupPath + "\\recipesdb.sdf", file);
				
				MessageBox.Show("Backup successful!", "Backup");
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		/// <summary>
		/// Restore recipe database from specified location.
		/// </summary>
		/// <param name="file">Filename to restore</param>
		private void RestoreRecipes(string file) {
			try {
				if(MessageBox.Show("Are you sure you wish to restore the backup? This cannot be undone!",
					"Restore", MessageBoxButtons.YesNo) == DialogResult.Yes) {
					// if the original database exists, delete it
					if(File.Exists(Application.StartupPath + "\\recipesdb.sdf")) {
						File.Delete(Application.StartupPath + "\\recipesdb.sdf");
					}

					// then copy the backup (rather than moving it)
					File.Copy(file, Application.StartupPath + "\\recipesdb.sdf");

					// reload all the recipes from the new database
					LoadRecipes();

					// change to the View tab
					tabControl.SelectedTab = tabView;
				}
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
			}
		}

		/// <summary>
		/// Align the country and rating labels to the name.
		/// </summary>
		private void AlignControls() {
			lblCountry.Left = lblName.Left + lblName.Width;
			ctlViewRating.Left = lblName.Left + lblName.Width;
		}

		/// <summary>
		/// Get the largest ID in the Recipes table.
		/// </summary>
		/// <returns>Largest ID in Recipes table</returns>
		private int GetLargestId() {
			int Id = 0;

			try {
				foreach(DataGridViewRow row in dgvRecipes.Rows) {
					// if the id of the current row is larger than the Id var
					if(Convert.ToInt32(row.Cells["ID"].Value.ToString()) > Id) {
						// then set it to the new larger value
						Id = Convert.ToInt32(row.Cells["ID"].Value.ToString());
					}
				}
			}
			catch(Exception ex) {
				frmError.ShowDialog(ex);
				Id = -1;
			}

			return Id;
		}

		/// <summary>
		/// Compare version numbers for updating.
		/// </summary>
		/// <param name="versionStart">Current program version</param>
		/// <param name="versionCompare">New program version</param>
		/// <returns></returns>
		private int compareVersions(string versionStart, string versionCompare) {
			Version vStart = new Version(versionStart);
			Version vComp = new Version(versionCompare);

			int answer = vStart.CompareTo(vComp);

			return answer;
		}
		#endregion
	}
}
