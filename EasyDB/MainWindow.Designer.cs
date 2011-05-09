namespace EasyDB
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.dbGroup = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.saveConnection = new System.Windows.Forms.Button();
            this.newConnection = new System.Windows.Forms.Button();
            this.connections = new System.Windows.Forms.ComboBox();
            this.database = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.host = new System.Windows.Forms.TextBox();
            this.fileGroup = new System.Windows.Forms.GroupBox();
            this.deleteFiles = new System.Windows.Forms.Button();
            this.deactivateAll = new System.Windows.Forms.Button();
            this.activateAll = new System.Windows.Forms.Button();
            this.importFiles = new System.Windows.Forms.Button();
            this.create = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.mysqlNotFoundLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.dbGroup.SuspendLayout();
            this.fileGroup.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedListBox
            // 
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.HorizontalScrollbar = true;
            this.checkedListBox.Location = new System.Drawing.Point(6, 16);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(310, 167);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.ThreeDCheckBoxes = true;
            // 
            // dbGroup
            // 
            this.dbGroup.Controls.Add(this.label5);
            this.dbGroup.Controls.Add(this.name);
            this.dbGroup.Controls.Add(this.saveConnection);
            this.dbGroup.Controls.Add(this.newConnection);
            this.dbGroup.Controls.Add(this.connections);
            this.dbGroup.Controls.Add(this.database);
            this.dbGroup.Controls.Add(this.label4);
            this.dbGroup.Controls.Add(this.label3);
            this.dbGroup.Controls.Add(this.password);
            this.dbGroup.Controls.Add(this.label2);
            this.dbGroup.Controls.Add(this.user);
            this.dbGroup.Controls.Add(this.label1);
            this.dbGroup.Controls.Add(this.host);
            this.dbGroup.Location = new System.Drawing.Point(354, 11);
            this.dbGroup.Name = "dbGroup";
            this.dbGroup.Size = new System.Drawing.Size(268, 189);
            this.dbGroup.TabIndex = 4;
            this.dbGroup.TabStop = false;
            this.dbGroup.Text = "Datenbank-Einstellungen";
            this.dbGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(72, 158);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(109, 20);
            this.name.TabIndex = 60;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // saveConnection
            // 
            this.saveConnection.Enabled = false;
            this.saveConnection.Location = new System.Drawing.Point(186, 156);
            this.saveConnection.Name = "saveConnection";
            this.saveConnection.Size = new System.Drawing.Size(75, 23);
            this.saveConnection.TabIndex = 70;
            this.saveConnection.Text = "Speichern";
            this.saveConnection.UseVisualStyleBackColor = true;
            this.saveConnection.Click += new System.EventHandler(this.saveConnection_Click);
            // 
            // newConnection
            // 
            this.newConnection.Location = new System.Drawing.Point(10, 17);
            this.newConnection.Name = "newConnection";
            this.newConnection.Size = new System.Drawing.Size(56, 23);
            this.newConnection.TabIndex = 30;
            this.newConnection.Text = "Neu";
            this.newConnection.UseVisualStyleBackColor = true;
            this.newConnection.Click += new System.EventHandler(this.newConnection_Click);
            // 
            // connections
            // 
            this.connections.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connections.FormattingEnabled = true;
            this.connections.Location = new System.Drawing.Point(72, 19);
            this.connections.Name = "connections";
            this.connections.Size = new System.Drawing.Size(189, 21);
            this.connections.TabIndex = 35;
            this.connections.SelectedIndexChanged += new System.EventHandler(this.connections_SelectedIndexChanged);
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(72, 130);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(190, 20);
            this.database.TabIndex = 55;
            this.database.TextChanged += new System.EventHandler(this.database_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datenbank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Passwort";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(72, 101);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(190, 20);
            this.password.TabIndex = 50;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Benutzer";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(72, 74);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(190, 20);
            this.user.TabIndex = 45;
            this.user.TextChanged += new System.EventHandler(this.user_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP-Adresse";
            // 
            // host
            // 
            this.host.BackColor = System.Drawing.Color.White;
            this.host.Location = new System.Drawing.Point(72, 47);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(190, 20);
            this.host.TabIndex = 40;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // fileGroup
            // 
            this.fileGroup.Controls.Add(this.deleteFiles);
            this.fileGroup.Controls.Add(this.deactivateAll);
            this.fileGroup.Controls.Add(this.activateAll);
            this.fileGroup.Controls.Add(this.importFiles);
            this.fileGroup.Controls.Add(this.checkedListBox);
            this.fileGroup.Location = new System.Drawing.Point(12, 11);
            this.fileGroup.Name = "fileGroup";
            this.fileGroup.Size = new System.Drawing.Size(322, 222);
            this.fileGroup.TabIndex = 3;
            this.fileGroup.TabStop = false;
            this.fileGroup.Text = "Dateien";
            // 
            // deleteFiles
            // 
            this.deleteFiles.Enabled = false;
            this.deleteFiles.Location = new System.Drawing.Point(249, 189);
            this.deleteFiles.Name = "deleteFiles";
            this.deleteFiles.Size = new System.Drawing.Size(67, 23);
            this.deleteFiles.TabIndex = 20;
            this.deleteFiles.Text = "Leeren";
            this.deleteFiles.UseVisualStyleBackColor = true;
            this.deleteFiles.Click += new System.EventHandler(this.deleteFiles_Click);
            // 
            // deactivateAll
            // 
            this.deactivateAll.Enabled = false;
            this.deactivateAll.Location = new System.Drawing.Point(169, 189);
            this.deactivateAll.Name = "deactivateAll";
            this.deactivateAll.Size = new System.Drawing.Size(74, 23);
            this.deactivateAll.TabIndex = 15;
            this.deactivateAll.Text = "Abwählen";
            this.deactivateAll.UseVisualStyleBackColor = true;
            this.deactivateAll.Click += new System.EventHandler(this.deactivateAll_Click);
            // 
            // activateAll
            // 
            this.activateAll.Enabled = false;
            this.activateAll.Location = new System.Drawing.Point(90, 189);
            this.activateAll.Name = "activateAll";
            this.activateAll.Size = new System.Drawing.Size(72, 23);
            this.activateAll.TabIndex = 10;
            this.activateAll.Text = "Auswählen";
            this.activateAll.UseVisualStyleBackColor = true;
            this.activateAll.Click += new System.EventHandler(this.activateAll_Click);
            // 
            // importFiles
            // 
            this.importFiles.Location = new System.Drawing.Point(6, 189);
            this.importFiles.Name = "importFiles";
            this.importFiles.Size = new System.Drawing.Size(75, 23);
            this.importFiles.TabIndex = 5;
            this.importFiles.Text = "Importieren";
            this.importFiles.UseVisualStyleBackColor = true;
            this.importFiles.Click += new System.EventHandler(this.importFiles_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(354, 205);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(128, 25);
            this.create.TabIndex = 75;
            this.create.Text = "Erstellen";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // run
            // 
            this.run.Enabled = false;
            this.run.Location = new System.Drawing.Point(488, 206);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(131, 25);
            this.run.TabIndex = 80;
            this.run.Text = "Ausführen";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBarLabel,
            this.progressBar,
            this.mysqlNotFoundLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 244);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(631, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip_ItemClicked);
            // 
            // progressBarLabel
            // 
            this.progressBarLabel.Name = "progressBarLabel";
            this.progressBarLabel.Size = new System.Drawing.Size(61, 17);
            this.progressBarLabel.Text = "Fortschritt";
            this.progressBarLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 16);
            this.progressBar.Visible = false;
            // 
            // mysqlNotFoundLabel
            // 
            this.mysqlNotFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.mysqlNotFoundLabel.Name = "mysqlNotFoundLabel";
            this.mysqlNotFoundLabel.Size = new System.Drawing.Size(500, 17);
            this.mysqlNotFoundLabel.Text = "Achtung : mysql.exe konnte in der Path Variable nicht gefunden werden, bitte manu" +
    "ell setzen!";
            this.mysqlNotFoundLabel.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 266);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.run);
            this.Controls.Add(this.create);
            this.Controls.Add(this.fileGroup);
            this.Controls.Add(this.dbGroup);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyDB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.dbGroup.ResumeLayout(false);
            this.dbGroup.PerformLayout();
            this.fileGroup.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.GroupBox dbGroup;
        private System.Windows.Forms.GroupBox fileGroup;
        private System.Windows.Forms.Button importFiles;
        private System.Windows.Forms.TextBox database;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.ComboBox connections;
        private System.Windows.Forms.Button deactivateAll;
        private System.Windows.Forms.Button activateAll;
        private System.Windows.Forms.Button deleteFiles;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button saveConnection;
        private System.Windows.Forms.Button newConnection;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel progressBarLabel;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel mysqlNotFoundLabel;

    }
}