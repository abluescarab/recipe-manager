namespace recipe_manager {
	partial class frmMain {
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
			this.components = new System.ComponentModel.Container();
			this.menu = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.filePrint = new System.Windows.Forms.ToolStripMenuItem();
			this.fileRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.fileSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.fileExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOptions = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsAutoNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsSwitchTab = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbluescarab = new System.Windows.Forms.ToolStripMenuItem();
			this.helpGithub = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep1 = new System.Windows.Forms.ToolStripSeparator();
			this.helpChangelog = new System.Windows.Forms.ToolStripMenuItem();
			this.helpSep2 = new System.Windows.Forms.ToolStripSeparator();
			this.helpHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.helpAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dgvRecipes = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeServes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeIngredients = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipeDirections = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.recipesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.recipesdbDataSet = new recipe_manager.recipesdbDataSet();
			this.cmbSearch = new System.Windows.Forms.ComboBox();
			this.lblSearch = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabView = new System.Windows.Forms.TabPage();
			this.lblRating = new System.Windows.Forms.Label();
			this.lblCountry = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.rtbDirections = new System.Windows.Forms.RichTextBox();
			this.rtbIngredients = new System.Windows.Forms.RichTextBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.rtbComment = new System.Windows.Forms.RichTextBox();
			this.lblDirectionsLabel = new System.Windows.Forms.Label();
			this.lblIngredientsLabel = new System.Windows.Forms.Label();
			this.lblServes = new System.Windows.Forms.Label();
			this.lblServesLabel = new System.Windows.Forms.Label();
			this.lblCategories = new System.Windows.Forms.Label();
			this.lblCategoryLabel = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.tabEdit = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnClearChanges = new System.Windows.Forms.Button();
			this.txtEditComment = new System.Windows.Forms.TextBox();
			this.lblEditComment = new System.Windows.Forms.Label();
			this.panelEditDirections = new System.Windows.Forms.Panel();
			this.rtbEditDirections = new System.Windows.Forms.RichTextBox();
			this.lblEditDirections = new System.Windows.Forms.Label();
			this.numEditRating = new System.Windows.Forms.NumericUpDown();
			this.lblEditIngredients = new System.Windows.Forms.Label();
			this.panelEditIngredients = new System.Windows.Forms.Panel();
			this.rtbEditIngredients = new System.Windows.Forms.RichTextBox();
			this.numEditServes = new System.Windows.Forms.NumericUpDown();
			this.txtEditCategories = new System.Windows.Forms.TextBox();
			this.txtEditCountry = new System.Windows.Forms.TextBox();
			this.txtEditName = new System.Windows.Forms.TextBox();
			this.lblEditCountry = new System.Windows.Forms.Label();
			this.lblEditServes = new System.Windows.Forms.Label();
			this.lblEditCategories = new System.Windows.Forms.Label();
			this.lblEditRating = new System.Windows.Forms.Label();
			this.lblEditName = new System.Windows.Forms.Label();
			this.tabAdd = new System.Windows.Forms.TabPage();
			this.tlpAddButtons = new System.Windows.Forms.TableLayoutPanel();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtAddComment = new System.Windows.Forms.TextBox();
			this.lblAddComment = new System.Windows.Forms.Label();
			this.panelAddDirections = new System.Windows.Forms.Panel();
			this.rtbAddDirections = new System.Windows.Forms.RichTextBox();
			this.lblAddDirections = new System.Windows.Forms.Label();
			this.numAddRating = new System.Windows.Forms.NumericUpDown();
			this.lblAddIngredients = new System.Windows.Forms.Label();
			this.panelAddIngredients = new System.Windows.Forms.Panel();
			this.rtbAddIngredients = new System.Windows.Forms.RichTextBox();
			this.numAddServes = new System.Windows.Forms.NumericUpDown();
			this.txtAddCategories = new System.Windows.Forms.TextBox();
			this.txtAddCountry = new System.Windows.Forms.TextBox();
			this.txtAddName = new System.Windows.Forms.TextBox();
			this.lblAddCountry = new System.Windows.Forms.Label();
			this.lblAddServes = new System.Windows.Forms.Label();
			this.lblAddCategory = new System.Windows.Forms.Label();
			this.lblAddRating = new System.Windows.Forms.Label();
			this.lblAddName = new System.Windows.Forms.Label();
			this.recipesTableAdapter = new recipe_manager.recipesdbDataSetTableAdapters.RecipesTableAdapter();
			this.dlgPrint = new System.Windows.Forms.PrintDialog();
			this.menu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesdbDataSet)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabView.SuspendLayout();
			this.tabEdit.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panelEditDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEditRating)).BeginInit();
			this.panelEditIngredients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numEditServes)).BeginInit();
			this.tabAdd.SuspendLayout();
			this.tlpAddButtons.SuspendLayout();
			this.panelAddDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAddRating)).BeginInit();
			this.panelAddIngredients.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAddServes)).BeginInit();
			this.SuspendLayout();
			// 
			// menu
			// 
			this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuOptions,
            this.menuHelp});
			this.menu.Location = new System.Drawing.Point(0, 0);
			this.menu.Name = "menu";
			this.menu.Size = new System.Drawing.Size(915, 24);
			this.menu.TabIndex = 0;
			this.menu.Text = "menuStrip1";
			// 
			// menuFile
			// 
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filePrint,
            this.fileRefresh,
            this.fileSep1,
            this.fileExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "File";
			// 
			// filePrint
			// 
			this.filePrint.Image = global::recipe_manager.Properties.Resources.printer;
			this.filePrint.Name = "filePrint";
			this.filePrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
			this.filePrint.Size = new System.Drawing.Size(175, 22);
			this.filePrint.Text = "Print";
			this.filePrint.Click += new System.EventHandler(this.filePrint_Click);
			// 
			// fileRefresh
			// 
			this.fileRefresh.Image = global::recipe_manager.Properties.Resources.arrow_refresh;
			this.fileRefresh.Name = "fileRefresh";
			this.fileRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.fileRefresh.Size = new System.Drawing.Size(175, 22);
			this.fileRefresh.Text = "Refresh Recipes";
			this.fileRefresh.Click += new System.EventHandler(this.fileRefresh_Click);
			// 
			// fileSep1
			// 
			this.fileSep1.Name = "fileSep1";
			this.fileSep1.Size = new System.Drawing.Size(172, 6);
			// 
			// fileExit
			// 
			this.fileExit.Image = global::recipe_manager.Properties.Resources.cross;
			this.fileExit.Name = "fileExit";
			this.fileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
			this.fileExit.Size = new System.Drawing.Size(175, 22);
			this.fileExit.Text = "Exit";
			this.fileExit.Click += new System.EventHandler(this.fileExit_Click);
			// 
			// menuOptions
			// 
			this.menuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsAutoNumber,
            this.optionsSwitchTab});
			this.menuOptions.Name = "menuOptions";
			this.menuOptions.Size = new System.Drawing.Size(61, 20);
			this.menuOptions.Text = "Options";
			// 
			// optionsAutoNumber
			// 
			this.optionsAutoNumber.Checked = true;
			this.optionsAutoNumber.CheckOnClick = true;
			this.optionsAutoNumber.CheckState = System.Windows.Forms.CheckState.Checked;
			this.optionsAutoNumber.Name = "optionsAutoNumber";
			this.optionsAutoNumber.Size = new System.Drawing.Size(302, 22);
			this.optionsAutoNumber.Text = "Automatically number directions";
			this.optionsAutoNumber.CheckStateChanged += new System.EventHandler(this.optionsAutoNumber_CheckStateChanged);
			// 
			// optionsSwitchTab
			// 
			this.optionsSwitchTab.Checked = true;
			this.optionsSwitchTab.CheckOnClick = true;
			this.optionsSwitchTab.CheckState = System.Windows.Forms.CheckState.Checked;
			this.optionsSwitchTab.Name = "optionsSwitchTab";
			this.optionsSwitchTab.Size = new System.Drawing.Size(302, 22);
			this.optionsSwitchTab.Text = "Switch to the View tab after adding a recipe";
			this.optionsSwitchTab.CheckStateChanged += new System.EventHandler(this.optionsSwitchTab_CheckStateChanged);
			// 
			// menuHelp
			// 
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpAbluescarab,
            this.helpGithub,
            this.helpSep1,
            this.helpChangelog,
            this.helpSep2,
            this.helpHelp,
            this.helpAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 20);
			this.menuHelp.Text = "Help";
			// 
			// helpAbluescarab
			// 
			this.helpAbluescarab.Image = global::recipe_manager.Properties.Resources.scarab;
			this.helpAbluescarab.Name = "helpAbluescarab";
			this.helpAbluescarab.Size = new System.Drawing.Size(208, 22);
			this.helpAbluescarab.Text = "Visit Abluescarab Designs";
			this.helpAbluescarab.Click += new System.EventHandler(this.helpAbluescarab_Click);
			// 
			// helpGithub
			// 
			this.helpGithub.Image = global::recipe_manager.Properties.Resources.github;
			this.helpGithub.Name = "helpGithub";
			this.helpGithub.Size = new System.Drawing.Size(208, 22);
			this.helpGithub.Text = "Visit the GitHub Project";
			this.helpGithub.Click += new System.EventHandler(this.helpGithub_Click);
			// 
			// helpSep1
			// 
			this.helpSep1.Name = "helpSep1";
			this.helpSep1.Size = new System.Drawing.Size(205, 6);
			// 
			// helpChangelog
			// 
			this.helpChangelog.Image = global::recipe_manager.Properties.Resources.page_white_text;
			this.helpChangelog.Name = "helpChangelog";
			this.helpChangelog.Size = new System.Drawing.Size(208, 22);
			this.helpChangelog.Text = "Changelog...";
			this.helpChangelog.Click += new System.EventHandler(this.helpChangelog_Click);
			// 
			// helpSep2
			// 
			this.helpSep2.Name = "helpSep2";
			this.helpSep2.Size = new System.Drawing.Size(205, 6);
			// 
			// helpHelp
			// 
			this.helpHelp.Image = global::recipe_manager.Properties.Resources.help;
			this.helpHelp.Name = "helpHelp";
			this.helpHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
			this.helpHelp.Size = new System.Drawing.Size(208, 22);
			this.helpHelp.Text = "Help Topics";
			this.helpHelp.Click += new System.EventHandler(this.helpHelp_Click);
			// 
			// helpAbout
			// 
			this.helpAbout.Image = global::recipe_manager.Properties.Resources.information;
			this.helpAbout.Name = "helpAbout";
			this.helpAbout.Size = new System.Drawing.Size(208, 22);
			this.helpAbout.Text = "About";
			this.helpAbout.Click += new System.EventHandler(this.helpAbout_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer.Location = new System.Drawing.Point(12, 27);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.txtSearch);
			this.splitContainer.Panel1.Controls.Add(this.dgvRecipes);
			this.splitContainer.Panel1.Controls.Add(this.cmbSearch);
			this.splitContainer.Panel1.Controls.Add(this.lblSearch);
			this.splitContainer.Panel1MinSize = 300;
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.tabControl);
			this.splitContainer.Panel2MinSize = 350;
			this.splitContainer.Size = new System.Drawing.Size(891, 445);
			this.splitContainer.SplitterDistance = 537;
			this.splitContainer.TabIndex = 6;
			// 
			// txtSearch
			// 
			this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSearch.Location = new System.Drawing.Point(200, 1);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(334, 23);
			this.txtSearch.TabIndex = 2;
			this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
			// 
			// dgvRecipes
			// 
			this.dgvRecipes.AllowUserToAddRows = false;
			this.dgvRecipes.AllowUserToDeleteRows = false;
			this.dgvRecipes.AllowUserToOrderColumns = true;
			this.dgvRecipes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvRecipes.AutoGenerateColumns = false;
			this.dgvRecipes.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dgvRecipes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRecipes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.recipeName,
            this.recipeRating,
            this.recipeCategory,
            this.recipeServes,
            this.recipeCountry,
            this.recipeIngredients,
            this.recipeComment,
            this.recipeDirections});
			this.dgvRecipes.DataSource = this.recipesBindingSource;
			this.dgvRecipes.Location = new System.Drawing.Point(0, 30);
			this.dgvRecipes.MultiSelect = false;
			this.dgvRecipes.Name = "dgvRecipes";
			this.dgvRecipes.ReadOnly = true;
			this.dgvRecipes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvRecipes.Size = new System.Drawing.Size(534, 415);
			this.dgvRecipes.TabIndex = 0;
			this.dgvRecipes.SelectionChanged += new System.EventHandler(this.recipesView_SelectionChanged);
			this.dgvRecipes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRecipes_KeyDown);
			// 
			// ID
			// 
			this.ID.DataPropertyName = "ID";
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Visible = false;
			// 
			// recipeName
			// 
			this.recipeName.DataPropertyName = "RecipeName";
			this.recipeName.HeaderText = "Name";
			this.recipeName.Name = "recipeName";
			this.recipeName.ReadOnly = true;
			this.recipeName.Width = 125;
			// 
			// recipeRating
			// 
			this.recipeRating.DataPropertyName = "RecipeRating";
			this.recipeRating.HeaderText = "Rating";
			this.recipeRating.Name = "recipeRating";
			this.recipeRating.ReadOnly = true;
			this.recipeRating.Width = 50;
			// 
			// recipeCategory
			// 
			this.recipeCategory.DataPropertyName = "RecipeCategory";
			this.recipeCategory.HeaderText = "Categories";
			this.recipeCategory.Name = "recipeCategory";
			this.recipeCategory.ReadOnly = true;
			this.recipeCategory.Width = 150;
			// 
			// recipeServes
			// 
			this.recipeServes.DataPropertyName = "RecipeServes";
			this.recipeServes.HeaderText = "Serves";
			this.recipeServes.Name = "recipeServes";
			this.recipeServes.ReadOnly = true;
			this.recipeServes.Width = 50;
			// 
			// recipeCountry
			// 
			this.recipeCountry.DataPropertyName = "RecipeCountry";
			this.recipeCountry.HeaderText = "Country";
			this.recipeCountry.Name = "recipeCountry";
			this.recipeCountry.ReadOnly = true;
			this.recipeCountry.Width = 115;
			// 
			// recipeIngredients
			// 
			this.recipeIngredients.DataPropertyName = "RecipeIngredients";
			this.recipeIngredients.HeaderText = "Ingredients";
			this.recipeIngredients.Name = "recipeIngredients";
			this.recipeIngredients.ReadOnly = true;
			this.recipeIngredients.Visible = false;
			// 
			// recipeComment
			// 
			this.recipeComment.DataPropertyName = "RecipeComment";
			this.recipeComment.HeaderText = "Comment";
			this.recipeComment.Name = "recipeComment";
			this.recipeComment.ReadOnly = true;
			this.recipeComment.Visible = false;
			// 
			// recipeDirections
			// 
			this.recipeDirections.DataPropertyName = "RecipeDirections";
			this.recipeDirections.HeaderText = "Directions";
			this.recipeDirections.Name = "recipeDirections";
			this.recipeDirections.ReadOnly = true;
			this.recipeDirections.Visible = false;
			// 
			// recipesBindingSource
			// 
			this.recipesBindingSource.DataMember = "Recipes";
			this.recipesBindingSource.DataSource = this.recipesdbDataSet;
			// 
			// recipesdbDataSet
			// 
			this.recipesdbDataSet.DataSetName = "recipesdbDataSet";
			this.recipesdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cmbSearch
			// 
			this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbSearch.FormattingEnabled = true;
			this.cmbSearch.Items.AddRange(new object[] {
            "All",
            "Name",
            "Category",
            "Ingredients",
            "Country"});
			this.cmbSearch.Location = new System.Drawing.Point(87, 0);
			this.cmbSearch.Name = "cmbSearch";
			this.cmbSearch.Size = new System.Drawing.Size(107, 24);
			this.cmbSearch.TabIndex = 1;
			this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSearch.Location = new System.Drawing.Point(3, 4);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(81, 16);
			this.lblSearch.TabIndex = 2;
			this.lblSearch.Text = "Search by:";
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabView);
			this.tabControl.Controls.Add(this.tabEdit);
			this.tabControl.Controls.Add(this.tabAdd);
			this.tabControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl.Location = new System.Drawing.Point(3, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(347, 445);
			this.tabControl.TabIndex = 3;
			// 
			// tabView
			// 
			this.tabView.AutoScroll = true;
			this.tabView.Controls.Add(this.lblRating);
			this.tabView.Controls.Add(this.lblCountry);
			this.tabView.Controls.Add(this.btnPrint);
			this.tabView.Controls.Add(this.rtbDirections);
			this.tabView.Controls.Add(this.rtbIngredients);
			this.tabView.Controls.Add(this.btnDelete);
			this.tabView.Controls.Add(this.rtbComment);
			this.tabView.Controls.Add(this.lblDirectionsLabel);
			this.tabView.Controls.Add(this.lblIngredientsLabel);
			this.tabView.Controls.Add(this.lblServes);
			this.tabView.Controls.Add(this.lblServesLabel);
			this.tabView.Controls.Add(this.lblCategories);
			this.tabView.Controls.Add(this.lblCategoryLabel);
			this.tabView.Controls.Add(this.lblName);
			this.tabView.Location = new System.Drawing.Point(4, 25);
			this.tabView.Name = "tabView";
			this.tabView.Size = new System.Drawing.Size(339, 416);
			this.tabView.TabIndex = 0;
			this.tabView.Text = "View";
			this.tabView.UseVisualStyleBackColor = true;
			// 
			// lblRating
			// 
			this.lblRating.AutoSize = true;
			this.lblRating.Font = new System.Drawing.Font("Verdana", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRating.Location = new System.Drawing.Point(187, 21);
			this.lblRating.Name = "lblRating";
			this.lblRating.Size = new System.Drawing.Size(82, 25);
			this.lblRating.TabIndex = 16;
			this.lblRating.Text = "☆☆☆☆☆";
			this.lblRating.Click += new System.EventHandler(this.lblRating_Click);
			// 
			// lblCountry
			// 
			this.lblCountry.AutoSize = true;
			this.lblCountry.Location = new System.Drawing.Point(187, 5);
			this.lblCountry.Name = "lblCountry";
			this.lblCountry.Size = new System.Drawing.Size(41, 16);
			this.lblCountry.TabIndex = 7;
			this.lblCountry.Text = "None";
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.Image = global::recipe_manager.Properties.Resources.printer;
			this.btnPrint.Location = new System.Drawing.Point(311, 36);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(25, 25);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			this.btnPrint.MouseHover += new System.EventHandler(this.btnPrint_MouseHover);
			// 
			// rtbDirections
			// 
			this.rtbDirections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbDirections.BackColor = System.Drawing.SystemColors.Window;
			this.rtbDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbDirections.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbDirections.Location = new System.Drawing.Point(3, 297);
			this.rtbDirections.Name = "rtbDirections";
			this.rtbDirections.ReadOnly = true;
			this.rtbDirections.Size = new System.Drawing.Size(333, 99);
			this.rtbDirections.TabIndex = 4;
			this.rtbDirections.Text = "";
			// 
			// rtbIngredients
			// 
			this.rtbIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbIngredients.BackColor = System.Drawing.SystemColors.Window;
			this.rtbIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbIngredients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbIngredients.Location = new System.Drawing.Point(3, 183);
			this.rtbIngredients.Name = "rtbIngredients";
			this.rtbIngredients.ReadOnly = true;
			this.rtbIngredients.Size = new System.Drawing.Size(333, 95);
			this.rtbIngredients.TabIndex = 3;
			this.rtbIngredients.Text = "";
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDelete.Image = global::recipe_manager.Properties.Resources.cross;
			this.btnDelete.Location = new System.Drawing.Point(311, 5);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(25, 25);
			this.btnDelete.TabIndex = 0;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			this.btnDelete.MouseHover += new System.EventHandler(this.btnDelete_MouseHover);
			// 
			// rtbComment
			// 
			this.rtbComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbComment.BackColor = System.Drawing.SystemColors.Window;
			this.rtbComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbComment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbComment.Location = new System.Drawing.Point(3, 49);
			this.rtbComment.Name = "rtbComment";
			this.rtbComment.ReadOnly = true;
			this.rtbComment.Size = new System.Drawing.Size(302, 66);
			this.rtbComment.TabIndex = 2;
			this.rtbComment.Text = "";
			// 
			// lblDirectionsLabel
			// 
			this.lblDirectionsLabel.AutoSize = true;
			this.lblDirectionsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDirectionsLabel.Location = new System.Drawing.Point(3, 281);
			this.lblDirectionsLabel.Name = "lblDirectionsLabel";
			this.lblDirectionsLabel.Size = new System.Drawing.Size(86, 16);
			this.lblDirectionsLabel.TabIndex = 12;
			this.lblDirectionsLabel.Text = "Directions:";
			// 
			// lblIngredientsLabel
			// 
			this.lblIngredientsLabel.AutoSize = true;
			this.lblIngredientsLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIngredientsLabel.Location = new System.Drawing.Point(3, 167);
			this.lblIngredientsLabel.Name = "lblIngredientsLabel";
			this.lblIngredientsLabel.Size = new System.Drawing.Size(97, 16);
			this.lblIngredientsLabel.TabIndex = 10;
			this.lblIngredientsLabel.Text = "Ingredients:";
			// 
			// lblServes
			// 
			this.lblServes.AutoSize = true;
			this.lblServes.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServes.Location = new System.Drawing.Point(93, 134);
			this.lblServes.Name = "lblServes";
			this.lblServes.Size = new System.Drawing.Size(16, 16);
			this.lblServes.TabIndex = 9;
			this.lblServes.Text = "0";
			// 
			// lblServesLabel
			// 
			this.lblServesLabel.AutoSize = true;
			this.lblServesLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblServesLabel.Location = new System.Drawing.Point(3, 134);
			this.lblServesLabel.Name = "lblServesLabel";
			this.lblServesLabel.Size = new System.Drawing.Size(63, 16);
			this.lblServesLabel.TabIndex = 8;
			this.lblServesLabel.Text = "Serves:";
			// 
			// lblCategories
			// 
			this.lblCategories.AutoSize = true;
			this.lblCategories.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategories.Location = new System.Drawing.Point(93, 118);
			this.lblCategories.Name = "lblCategories";
			this.lblCategories.Size = new System.Drawing.Size(41, 16);
			this.lblCategories.TabIndex = 7;
			this.lblCategories.Text = "None";
			// 
			// lblCategoryLabel
			// 
			this.lblCategoryLabel.AutoSize = true;
			this.lblCategoryLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCategoryLabel.Location = new System.Drawing.Point(3, 118);
			this.lblCategoryLabel.Name = "lblCategoryLabel";
			this.lblCategoryLabel.Size = new System.Drawing.Size(92, 16);
			this.lblCategoryLabel.TabIndex = 6;
			this.lblCategoryLabel.Text = "Categories:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.Location = new System.Drawing.Point(3, 5);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(178, 31);
			this.lblName.TabIndex = 6;
			this.lblName.Text = "Recipe Name";
			// 
			// tabEdit
			// 
			this.tabEdit.AutoScroll = true;
			this.tabEdit.Controls.Add(this.tableLayoutPanel1);
			this.tabEdit.Controls.Add(this.txtEditComment);
			this.tabEdit.Controls.Add(this.lblEditComment);
			this.tabEdit.Controls.Add(this.panelEditDirections);
			this.tabEdit.Controls.Add(this.lblEditDirections);
			this.tabEdit.Controls.Add(this.numEditRating);
			this.tabEdit.Controls.Add(this.lblEditIngredients);
			this.tabEdit.Controls.Add(this.panelEditIngredients);
			this.tabEdit.Controls.Add(this.numEditServes);
			this.tabEdit.Controls.Add(this.txtEditCategories);
			this.tabEdit.Controls.Add(this.txtEditCountry);
			this.tabEdit.Controls.Add(this.txtEditName);
			this.tabEdit.Controls.Add(this.lblEditCountry);
			this.tabEdit.Controls.Add(this.lblEditServes);
			this.tabEdit.Controls.Add(this.lblEditCategories);
			this.tabEdit.Controls.Add(this.lblEditRating);
			this.tabEdit.Controls.Add(this.lblEditName);
			this.tabEdit.Location = new System.Drawing.Point(4, 25);
			this.tabEdit.Name = "tabEdit";
			this.tabEdit.Size = new System.Drawing.Size(339, 416);
			this.tabEdit.TabIndex = 1;
			this.tabEdit.Text = "Edit";
			this.tabEdit.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnEdit, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnClearChanges, 1, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 381);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(333, 32);
			this.tableLayoutPanel1.TabIndex = 29;
			// 
			// btnEdit
			// 
			this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEdit.Location = new System.Drawing.Point(3, 3);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(160, 26);
			this.btnEdit.TabIndex = 0;
			this.btnEdit.Text = "Edit";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnClearChanges
			// 
			this.btnClearChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClearChanges.Location = new System.Drawing.Point(169, 3);
			this.btnClearChanges.Name = "btnClearChanges";
			this.btnClearChanges.Size = new System.Drawing.Size(161, 26);
			this.btnClearChanges.TabIndex = 1;
			this.btnClearChanges.Text = "Clear Changes";
			this.btnClearChanges.UseVisualStyleBackColor = true;
			this.btnClearChanges.Click += new System.EventHandler(this.btnClearChanges_Click);
			// 
			// txtEditComment
			// 
			this.txtEditComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEditComment.Location = new System.Drawing.Point(111, 34);
			this.txtEditComment.Name = "txtEditComment";
			this.txtEditComment.Size = new System.Drawing.Size(225, 23);
			this.txtEditComment.TabIndex = 18;
			// 
			// lblEditComment
			// 
			this.lblEditComment.AutoSize = true;
			this.lblEditComment.Location = new System.Drawing.Point(3, 37);
			this.lblEditComment.Name = "lblEditComment";
			this.lblEditComment.Size = new System.Drawing.Size(75, 16);
			this.lblEditComment.TabIndex = 32;
			this.lblEditComment.Text = "Comment:";
			// 
			// panelEditDirections
			// 
			this.panelEditDirections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelEditDirections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelEditDirections.Controls.Add(this.rtbEditDirections);
			this.panelEditDirections.Location = new System.Drawing.Point(111, 294);
			this.panelEditDirections.Name = "panelEditDirections";
			this.panelEditDirections.Size = new System.Drawing.Size(225, 81);
			this.panelEditDirections.TabIndex = 28;
			// 
			// rtbEditDirections
			// 
			this.rtbEditDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbEditDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbEditDirections.Location = new System.Drawing.Point(-1, -1);
			this.rtbEditDirections.Name = "rtbEditDirections";
			this.rtbEditDirections.Size = new System.Drawing.Size(225, 81);
			this.rtbEditDirections.TabIndex = 0;
			this.rtbEditDirections.Text = "";
			// 
			// lblEditDirections
			// 
			this.lblEditDirections.AutoSize = true;
			this.lblEditDirections.Location = new System.Drawing.Point(3, 294);
			this.lblEditDirections.Name = "lblEditDirections";
			this.lblEditDirections.Size = new System.Drawing.Size(98, 48);
			this.lblEditDirections.TabIndex = 31;
			this.lblEditDirections.Text = "Directions:\r\n(one step per\r\nline)";
			// 
			// numEditRating
			// 
			this.numEditRating.Location = new System.Drawing.Point(111, 92);
			this.numEditRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numEditRating.Name = "numEditRating";
			this.numEditRating.Size = new System.Drawing.Size(53, 23);
			this.numEditRating.TabIndex = 23;
			// 
			// lblEditIngredients
			// 
			this.lblEditIngredients.AutoSize = true;
			this.lblEditIngredients.Location = new System.Drawing.Point(3, 207);
			this.lblEditIngredients.Name = "lblEditIngredients";
			this.lblEditIngredients.Size = new System.Drawing.Size(97, 32);
			this.lblEditIngredients.TabIndex = 30;
			this.lblEditIngredients.Text = "Ingredients:\r\n(one per line)";
			// 
			// panelEditIngredients
			// 
			this.panelEditIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelEditIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelEditIngredients.Controls.Add(this.rtbEditIngredients);
			this.panelEditIngredients.Location = new System.Drawing.Point(111, 207);
			this.panelEditIngredients.Name = "panelEditIngredients";
			this.panelEditIngredients.Size = new System.Drawing.Size(225, 81);
			this.panelEditIngredients.TabIndex = 27;
			// 
			// rtbEditIngredients
			// 
			this.rtbEditIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbEditIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbEditIngredients.Location = new System.Drawing.Point(-1, -1);
			this.rtbEditIngredients.Name = "rtbEditIngredients";
			this.rtbEditIngredients.Size = new System.Drawing.Size(225, 81);
			this.rtbEditIngredients.TabIndex = 0;
			this.rtbEditIngredients.Text = "";
			// 
			// numEditServes
			// 
			this.numEditServes.Location = new System.Drawing.Point(111, 178);
			this.numEditServes.Name = "numEditServes";
			this.numEditServes.Size = new System.Drawing.Size(53, 23);
			this.numEditServes.TabIndex = 26;
			// 
			// txtEditCategories
			// 
			this.txtEditCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEditCategories.Location = new System.Drawing.Point(111, 121);
			this.txtEditCategories.Name = "txtEditCategories";
			this.txtEditCategories.Size = new System.Drawing.Size(225, 23);
			this.txtEditCategories.TabIndex = 25;
			// 
			// txtEditCountry
			// 
			this.txtEditCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEditCountry.Location = new System.Drawing.Point(111, 63);
			this.txtEditCountry.Name = "txtEditCountry";
			this.txtEditCountry.Size = new System.Drawing.Size(225, 23);
			this.txtEditCountry.TabIndex = 21;
			// 
			// txtEditName
			// 
			this.txtEditName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtEditName.Location = new System.Drawing.Point(111, 5);
			this.txtEditName.Name = "txtEditName";
			this.txtEditName.Size = new System.Drawing.Size(225, 23);
			this.txtEditName.TabIndex = 17;
			// 
			// lblEditCountry
			// 
			this.lblEditCountry.AutoSize = true;
			this.lblEditCountry.Location = new System.Drawing.Point(3, 66);
			this.lblEditCountry.Name = "lblEditCountry";
			this.lblEditCountry.Size = new System.Drawing.Size(66, 16);
			this.lblEditCountry.TabIndex = 24;
			this.lblEditCountry.Text = "Country:";
			// 
			// lblEditServes
			// 
			this.lblEditServes.AutoSize = true;
			this.lblEditServes.Location = new System.Drawing.Point(3, 180);
			this.lblEditServes.Name = "lblEditServes";
			this.lblEditServes.Size = new System.Drawing.Size(59, 16);
			this.lblEditServes.TabIndex = 22;
			this.lblEditServes.Text = "Serves:";
			// 
			// lblEditCategories
			// 
			this.lblEditCategories.AutoSize = true;
			this.lblEditCategories.Location = new System.Drawing.Point(3, 124);
			this.lblEditCategories.Name = "lblEditCategories";
			this.lblEditCategories.Size = new System.Drawing.Size(105, 48);
			this.lblEditCategories.TabIndex = 20;
			this.lblEditCategories.Text = "Categories:\r\n(separate with\r\ncommas)";
			// 
			// lblEditRating
			// 
			this.lblEditRating.AutoSize = true;
			this.lblEditRating.Location = new System.Drawing.Point(3, 94);
			this.lblEditRating.Name = "lblEditRating";
			this.lblEditRating.Size = new System.Drawing.Size(55, 16);
			this.lblEditRating.TabIndex = 19;
			this.lblEditRating.Text = "Rating:";
			// 
			// lblEditName
			// 
			this.lblEditName.AutoSize = true;
			this.lblEditName.Location = new System.Drawing.Point(3, 8);
			this.lblEditName.Name = "lblEditName";
			this.lblEditName.Size = new System.Drawing.Size(50, 16);
			this.lblEditName.TabIndex = 16;
			this.lblEditName.Text = "Name:";
			// 
			// tabAdd
			// 
			this.tabAdd.AutoScroll = true;
			this.tabAdd.Controls.Add(this.tlpAddButtons);
			this.tabAdd.Controls.Add(this.txtAddComment);
			this.tabAdd.Controls.Add(this.lblAddComment);
			this.tabAdd.Controls.Add(this.panelAddDirections);
			this.tabAdd.Controls.Add(this.lblAddDirections);
			this.tabAdd.Controls.Add(this.numAddRating);
			this.tabAdd.Controls.Add(this.lblAddIngredients);
			this.tabAdd.Controls.Add(this.panelAddIngredients);
			this.tabAdd.Controls.Add(this.numAddServes);
			this.tabAdd.Controls.Add(this.txtAddCategories);
			this.tabAdd.Controls.Add(this.txtAddCountry);
			this.tabAdd.Controls.Add(this.txtAddName);
			this.tabAdd.Controls.Add(this.lblAddCountry);
			this.tabAdd.Controls.Add(this.lblAddServes);
			this.tabAdd.Controls.Add(this.lblAddCategory);
			this.tabAdd.Controls.Add(this.lblAddRating);
			this.tabAdd.Controls.Add(this.lblAddName);
			this.tabAdd.Location = new System.Drawing.Point(4, 25);
			this.tabAdd.Name = "tabAdd";
			this.tabAdd.Size = new System.Drawing.Size(339, 416);
			this.tabAdd.TabIndex = 2;
			this.tabAdd.Text = "Add";
			this.tabAdd.UseVisualStyleBackColor = true;
			// 
			// tlpAddButtons
			// 
			this.tlpAddButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tlpAddButtons.ColumnCount = 2;
			this.tlpAddButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpAddButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tlpAddButtons.Controls.Add(this.btnAdd, 0, 0);
			this.tlpAddButtons.Controls.Add(this.btnClear, 1, 0);
			this.tlpAddButtons.Location = new System.Drawing.Point(3, 381);
			this.tlpAddButtons.Name = "tlpAddButtons";
			this.tlpAddButtons.RowCount = 1;
			this.tlpAddButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpAddButtons.Size = new System.Drawing.Size(333, 32);
			this.tlpAddButtons.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(160, 26);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.Location = new System.Drawing.Point(169, 3);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(161, 26);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtAddComment
			// 
			this.txtAddComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddComment.Location = new System.Drawing.Point(111, 34);
			this.txtAddComment.Name = "txtAddComment";
			this.txtAddComment.Size = new System.Drawing.Size(225, 23);
			this.txtAddComment.TabIndex = 1;
			// 
			// lblAddComment
			// 
			this.lblAddComment.AutoSize = true;
			this.lblAddComment.Location = new System.Drawing.Point(3, 37);
			this.lblAddComment.Name = "lblAddComment";
			this.lblAddComment.Size = new System.Drawing.Size(75, 16);
			this.lblAddComment.TabIndex = 15;
			this.lblAddComment.Text = "Comment:";
			// 
			// panelAddDirections
			// 
			this.panelAddDirections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAddDirections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAddDirections.Controls.Add(this.rtbAddDirections);
			this.panelAddDirections.Location = new System.Drawing.Point(111, 294);
			this.panelAddDirections.Name = "panelAddDirections";
			this.panelAddDirections.Size = new System.Drawing.Size(225, 81);
			this.panelAddDirections.TabIndex = 8;
			// 
			// rtbAddDirections
			// 
			this.rtbAddDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbAddDirections.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbAddDirections.Location = new System.Drawing.Point(-1, -1);
			this.rtbAddDirections.Name = "rtbAddDirections";
			this.rtbAddDirections.Size = new System.Drawing.Size(225, 81);
			this.rtbAddDirections.TabIndex = 0;
			this.rtbAddDirections.Text = "";
			// 
			// lblAddDirections
			// 
			this.lblAddDirections.AutoSize = true;
			this.lblAddDirections.Location = new System.Drawing.Point(3, 294);
			this.lblAddDirections.Name = "lblAddDirections";
			this.lblAddDirections.Size = new System.Drawing.Size(98, 48);
			this.lblAddDirections.TabIndex = 13;
			this.lblAddDirections.Text = "Directions:\r\n(one step per\r\nline)";
			// 
			// numAddRating
			// 
			this.numAddRating.Location = new System.Drawing.Point(111, 92);
			this.numAddRating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numAddRating.Name = "numAddRating";
			this.numAddRating.Size = new System.Drawing.Size(53, 23);
			this.numAddRating.TabIndex = 3;
			// 
			// lblAddIngredients
			// 
			this.lblAddIngredients.AutoSize = true;
			this.lblAddIngredients.Location = new System.Drawing.Point(3, 207);
			this.lblAddIngredients.Name = "lblAddIngredients";
			this.lblAddIngredients.Size = new System.Drawing.Size(97, 32);
			this.lblAddIngredients.TabIndex = 11;
			this.lblAddIngredients.Text = "Ingredients:\r\n(one per line)";
			// 
			// panelAddIngredients
			// 
			this.panelAddIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelAddIngredients.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelAddIngredients.Controls.Add(this.rtbAddIngredients);
			this.panelAddIngredients.Location = new System.Drawing.Point(111, 207);
			this.panelAddIngredients.Name = "panelAddIngredients";
			this.panelAddIngredients.Size = new System.Drawing.Size(225, 81);
			this.panelAddIngredients.TabIndex = 6;
			// 
			// rtbAddIngredients
			// 
			this.rtbAddIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbAddIngredients.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbAddIngredients.Location = new System.Drawing.Point(-1, -1);
			this.rtbAddIngredients.Name = "rtbAddIngredients";
			this.rtbAddIngredients.Size = new System.Drawing.Size(225, 81);
			this.rtbAddIngredients.TabIndex = 0;
			this.rtbAddIngredients.Text = "";
			// 
			// numAddServes
			// 
			this.numAddServes.Location = new System.Drawing.Point(111, 178);
			this.numAddServes.Name = "numAddServes";
			this.numAddServes.Size = new System.Drawing.Size(53, 23);
			this.numAddServes.TabIndex = 5;
			// 
			// txtAddCategories
			// 
			this.txtAddCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddCategories.Location = new System.Drawing.Point(111, 121);
			this.txtAddCategories.Name = "txtAddCategories";
			this.txtAddCategories.Size = new System.Drawing.Size(225, 23);
			this.txtAddCategories.TabIndex = 4;
			// 
			// txtAddCountry
			// 
			this.txtAddCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddCountry.Location = new System.Drawing.Point(111, 63);
			this.txtAddCountry.Name = "txtAddCountry";
			this.txtAddCountry.Size = new System.Drawing.Size(225, 23);
			this.txtAddCountry.TabIndex = 2;
			// 
			// txtAddName
			// 
			this.txtAddName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAddName.Location = new System.Drawing.Point(111, 5);
			this.txtAddName.Name = "txtAddName";
			this.txtAddName.Size = new System.Drawing.Size(225, 23);
			this.txtAddName.TabIndex = 0;
			// 
			// lblAddCountry
			// 
			this.lblAddCountry.AutoSize = true;
			this.lblAddCountry.Location = new System.Drawing.Point(3, 66);
			this.lblAddCountry.Name = "lblAddCountry";
			this.lblAddCountry.Size = new System.Drawing.Size(66, 16);
			this.lblAddCountry.TabIndex = 4;
			this.lblAddCountry.Text = "Country:";
			// 
			// lblAddServes
			// 
			this.lblAddServes.AutoSize = true;
			this.lblAddServes.Location = new System.Drawing.Point(3, 180);
			this.lblAddServes.Name = "lblAddServes";
			this.lblAddServes.Size = new System.Drawing.Size(59, 16);
			this.lblAddServes.TabIndex = 3;
			this.lblAddServes.Text = "Serves:";
			// 
			// lblAddCategory
			// 
			this.lblAddCategory.AutoSize = true;
			this.lblAddCategory.Location = new System.Drawing.Point(3, 124);
			this.lblAddCategory.Name = "lblAddCategory";
			this.lblAddCategory.Size = new System.Drawing.Size(105, 48);
			this.lblAddCategory.TabIndex = 2;
			this.lblAddCategory.Text = "Categories:\r\n(separate with\r\ncommas)";
			// 
			// lblAddRating
			// 
			this.lblAddRating.AutoSize = true;
			this.lblAddRating.Location = new System.Drawing.Point(3, 94);
			this.lblAddRating.Name = "lblAddRating";
			this.lblAddRating.Size = new System.Drawing.Size(55, 16);
			this.lblAddRating.TabIndex = 1;
			this.lblAddRating.Text = "Rating:";
			// 
			// lblAddName
			// 
			this.lblAddName.AutoSize = true;
			this.lblAddName.Location = new System.Drawing.Point(3, 8);
			this.lblAddName.Name = "lblAddName";
			this.lblAddName.Size = new System.Drawing.Size(50, 16);
			this.lblAddName.TabIndex = 0;
			this.lblAddName.Text = "Name:";
			// 
			// recipesTableAdapter
			// 
			this.recipesTableAdapter.ClearBeforeFill = true;
			// 
			// dlgPrint
			// 
			this.dlgPrint.UseEXDialog = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(915, 484);
			this.Controls.Add(this.menu);
			this.Controls.Add(this.splitContainer);
			this.MainMenuStrip = this.menu;
			this.MinimumSize = new System.Drawing.Size(700, 400);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Recipe Manager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.Resize += new System.EventHandler(this.frmMain_Resize);
			this.menu.ResumeLayout(false);
			this.menu.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvRecipes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.recipesdbDataSet)).EndInit();
			this.tabControl.ResumeLayout(false);
			this.tabView.ResumeLayout(false);
			this.tabView.PerformLayout();
			this.tabEdit.ResumeLayout(false);
			this.tabEdit.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panelEditDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEditRating)).EndInit();
			this.panelEditIngredients.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numEditServes)).EndInit();
			this.tabAdd.ResumeLayout(false);
			this.tabAdd.PerformLayout();
			this.tlpAddButtons.ResumeLayout(false);
			this.panelAddDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numAddRating)).EndInit();
			this.panelAddIngredients.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numAddServes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menu;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem filePrint;
		private System.Windows.Forms.ToolStripSeparator fileSep1;
		private System.Windows.Forms.ToolStripMenuItem fileExit;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem helpAbluescarab;
		private System.Windows.Forms.ToolStripMenuItem helpGithub;
		private System.Windows.Forms.ToolStripSeparator helpSep1;
		private System.Windows.Forms.ToolStripMenuItem helpChangelog;
		private System.Windows.Forms.ToolStripSeparator helpSep2;
		private System.Windows.Forms.ToolStripMenuItem helpHelp;
		private System.Windows.Forms.ToolStripMenuItem helpAbout;
		private System.Windows.Forms.DataGridView dgvRecipes;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.ComboBox cmbSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabView;
		private System.Windows.Forms.TabPage tabEdit;
		private System.Windows.Forms.TabPage tabAdd;
		private System.Windows.Forms.Label lblCategoryLabel;
		private System.Windows.Forms.Label lblCategories;
		private System.Windows.Forms.Label lblServesLabel;
		private System.Windows.Forms.Label lblIngredientsLabel;
		private System.Windows.Forms.Label lblDirectionsLabel;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label lblAddName;
		private System.Windows.Forms.Label lblAddServes;
		private System.Windows.Forms.Label lblAddCategory;
		private System.Windows.Forms.Label lblAddRating;
		private System.Windows.Forms.Label lblRating;
		private System.Windows.Forms.Label lblAddCountry;
		private System.Windows.Forms.TextBox txtAddName;
		private System.Windows.Forms.TextBox txtAddCategories;
		private System.Windows.Forms.TextBox txtAddCountry;
		private System.Windows.Forms.NumericUpDown numAddServes;
		private System.Windows.Forms.RichTextBox rtbAddIngredients;
		private System.Windows.Forms.Panel panelAddIngredients;
		private System.Windows.Forms.Label lblAddIngredients;
		private System.Windows.Forms.NumericUpDown numAddRating;
		private System.Windows.Forms.Panel panelAddDirections;
		private System.Windows.Forms.RichTextBox rtbAddDirections;
		private System.Windows.Forms.Label lblAddDirections;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtAddComment;
		private System.Windows.Forms.Label lblAddComment;
		private System.Windows.Forms.ToolStripMenuItem menuOptions;
		private System.Windows.Forms.TableLayoutPanel tlpAddButtons;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeName;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeRating;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeCategory;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeServes;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeCountry;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeIngredients;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeComment;
		private System.Windows.Forms.DataGridViewTextBoxColumn recipeDirections;
		private System.Windows.Forms.ToolStripMenuItem fileRefresh;
		private System.Windows.Forms.ToolStripMenuItem optionsAutoNumber;
		private System.Windows.Forms.ToolStripMenuItem optionsSwitchTab;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnClearChanges;
		private System.Windows.Forms.TextBox txtEditComment;
		private System.Windows.Forms.Label lblEditComment;
		private System.Windows.Forms.Panel panelEditDirections;
		private System.Windows.Forms.RichTextBox rtbEditDirections;
		private System.Windows.Forms.Label lblEditDirections;
		private System.Windows.Forms.NumericUpDown numEditRating;
		private System.Windows.Forms.Label lblEditIngredients;
		private System.Windows.Forms.Panel panelEditIngredients;
		private System.Windows.Forms.RichTextBox rtbEditIngredients;
		private System.Windows.Forms.NumericUpDown numEditServes;
		private System.Windows.Forms.TextBox txtEditCategories;
		private System.Windows.Forms.TextBox txtEditCountry;
		private System.Windows.Forms.TextBox txtEditName;
		private System.Windows.Forms.Label lblEditCountry;
		private System.Windows.Forms.Label lblEditServes;
		private System.Windows.Forms.Label lblEditCategories;
		private System.Windows.Forms.Label lblEditRating;
		private System.Windows.Forms.Label lblEditName;
		private System.Windows.Forms.BindingSource recipesBindingSource;
		private recipesdbDataSet recipesdbDataSet;
		private recipesdbDataSetTableAdapters.RecipesTableAdapter recipesTableAdapter;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblServes;
		private System.Windows.Forms.RichTextBox rtbComment;
		private System.Windows.Forms.RichTextBox rtbIngredients;
		private System.Windows.Forms.RichTextBox rtbDirections;
		private System.Windows.Forms.Label lblCountry;
		private System.Windows.Forms.PrintDialog dlgPrint;
	}
}

