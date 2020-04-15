namespace ClientGUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.infoListView = new System.Windows.Forms.ListView();
            this.columnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTags = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.currentTags = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tagsTextBox = new System.Windows.Forms.TextBox();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(955, 407);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(393, 275);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 20;
            this.pictureBox.TabStop = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1216, 377);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 24);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(955, 377);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(132, 24);
            this.editButton.TabIndex = 18;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(797, 9);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(132, 24);
            this.openButton.TabIndex = 17;
            this.openButton.Text = "Open";
            this.openButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click_1);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(279, 12);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(93, 22);
            this.dateTextBox.TabIndex = 16;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // infoListView
            // 
            this.infoListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnId,
            this.columnPath,
            this.columnDate,
            this.columnType,
            this.columnTags});
            this.infoListView.HideSelection = false;
            this.infoListView.Location = new System.Drawing.Point(12, 45);
            this.infoListView.Name = "infoListView";
            this.infoListView.Size = new System.Drawing.Size(917, 637);
            this.infoListView.TabIndex = 15;
            this.infoListView.UseCompatibleStateImageBehavior = false;
            this.infoListView.View = System.Windows.Forms.View.Details;
            // 
            // columnId
            // 
            this.columnId.Text = "id";
            this.columnId.Width = 37;
            // 
            // columnPath
            // 
            this.columnPath.Text = "path";
            this.columnPath.Width = 194;
            // 
            // columnDate
            // 
            this.columnDate.DisplayIndex = 3;
            this.columnDate.Text = "date";
            this.columnDate.Width = 108;
            // 
            // columnType
            // 
            this.columnType.DisplayIndex = 2;
            this.columnType.Text = "type";
            this.columnType.Width = 121;
            // 
            // columnTags
            // 
            this.columnTags.Text = "tags";
            this.columnTags.Width = 184;
            // 
            // searchComboBox
            // 
            this.searchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchComboBox.FormattingEnabled = true;
            this.searchComboBox.Items.AddRange(new object[] {
            "all",
            "photo",
            "video"});
            this.searchComboBox.Location = new System.Drawing.Point(378, 10);
            this.searchComboBox.Name = "searchComboBox";
            this.searchComboBox.Size = new System.Drawing.Size(124, 24);
            this.searchComboBox.TabIndex = 14;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(569, 54);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 24);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchTextBox.Location = new System.Drawing.Point(12, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(261, 22);
            this.searchTextBox.TabIndex = 12;
            this.searchTextBox.Text = "Search by tag";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(508, 10);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 24);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseMnemonic = false;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // currentTags
            // 
            this.currentTags.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.currentTags.Location = new System.Drawing.Point(955, 340);
            this.currentTags.Name = "currentTags";
            this.currentTags.Size = new System.Drawing.Size(393, 22);
            this.currentTags.TabIndex = 21;
            this.currentTags.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(952, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Write tags separte through commas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(952, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tagsTextBox
            // 
            this.tagsTextBox.Location = new System.Drawing.Point(952, 67);
            this.tagsTextBox.Multiline = true;
            this.tagsTextBox.Name = "tagsTextBox";
            this.tagsTextBox.Size = new System.Drawing.Size(393, 68);
            this.tagsTextBox.TabIndex = 24;
            this.tagsTextBox.Text = "tag1, tag2, ... ";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(952, 10);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.ReadOnly = true;
            this.pathTextBox.Size = new System.Drawing.Size(393, 22);
            this.pathTextBox.TabIndex = 23;
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(952, 38);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(233, 23);
            this.selectFileButton.TabIndex = 22;
            this.selectFileButton.Text = "Select File";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 705);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tagsTextBox);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.selectFileButton);
            this.Controls.Add(this.currentTags);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.infoListView);
            this.Controls.Add(this.searchComboBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.ListView infoListView;
        private System.Windows.Forms.ColumnHeader columnId;
        private System.Windows.Forms.ColumnHeader columnPath;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnTags;
        private System.Windows.Forms.ComboBox searchComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox currentTags;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tagsTextBox;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button selectFileButton;
    }
}

