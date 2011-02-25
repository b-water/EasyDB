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
            this.start = new System.Windows.Forms.Button();
            this.dbGroup.SuspendLayout();
            this.fileGroup.SuspendLayout();
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
            this.checkedListBox.TabIndex = 2;
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
            this.dbGroup.Location = new System.Drawing.Point(354, 12);
            this.dbGroup.Name = "dbGroup";
            this.dbGroup.Size = new System.Drawing.Size(268, 191);
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
            this.name.TabIndex = 10;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // saveConnection
            // 
            this.saveConnection.Enabled = false;
            this.saveConnection.Location = new System.Drawing.Point(186, 156);
            this.saveConnection.Name = "saveConnection";
            this.saveConnection.Size = new System.Drawing.Size(75, 23);
            this.saveConnection.TabIndex = 9;
            this.saveConnection.Text = "Speichern";
            this.saveConnection.UseVisualStyleBackColor = true;
            this.saveConnection.Click += new System.EventHandler(this.saveConnection_Click);
            // 
            // newConnection
            // 
            this.newConnection.Location = new System.Drawing.Point(10, 17);
            this.newConnection.Name = "newConnection";
            this.newConnection.Size = new System.Drawing.Size(56, 23);
            this.newConnection.TabIndex = 8;
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
            this.connections.TabIndex = 6;
            this.connections.SelectedIndexChanged += new System.EventHandler(this.connections_SelectedIndexChanged);
            // 
            // database
            // 
            this.database.Location = new System.Drawing.Point(72, 130);
            this.database.Name = "database";
            this.database.Size = new System.Drawing.Size(190, 20);
            this.database.TabIndex = 7;
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
            this.password.TabIndex = 4;
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
            this.user.TabIndex = 2;
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
            this.host.Location = new System.Drawing.Point(72, 47);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(190, 20);
            this.host.TabIndex = 0;
            this.host.TextChanged += new System.EventHandler(this.host_TextChanged);
            // 
            // fileGroup
            // 
            this.fileGroup.Controls.Add(this.deleteFiles);
            this.fileGroup.Controls.Add(this.deactivateAll);
            this.fileGroup.Controls.Add(this.activateAll);
            this.fileGroup.Controls.Add(this.importFiles);
            this.fileGroup.Controls.Add(this.checkedListBox);
            this.fileGroup.Location = new System.Drawing.Point(12, 12);
            this.fileGroup.Name = "fileGroup";
            this.fileGroup.Size = new System.Drawing.Size(322, 222);
            this.fileGroup.TabIndex = 5;
            this.fileGroup.TabStop = false;
            this.fileGroup.Text = "Dateien";
            // 
            // deleteFiles
            // 
            this.deleteFiles.Location = new System.Drawing.Point(249, 189);
            this.deleteFiles.Name = "deleteFiles";
            this.deleteFiles.Size = new System.Drawing.Size(67, 23);
            this.deleteFiles.TabIndex = 4;
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
            this.deactivateAll.TabIndex = 8;
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
            this.activateAll.TabIndex = 7;
            this.activateAll.Text = "Auswählen";
            this.activateAll.UseVisualStyleBackColor = true;
            this.activateAll.Click += new System.EventHandler(this.activateAll_Click);
            // 
            // importFiles
            // 
            this.importFiles.Location = new System.Drawing.Point(6, 189);
            this.importFiles.Name = "importFiles";
            this.importFiles.Size = new System.Drawing.Size(75, 23);
            this.importFiles.TabIndex = 3;
            this.importFiles.Text = "Importieren";
            this.importFiles.UseVisualStyleBackColor = true;
            this.importFiles.Click += new System.EventHandler(this.importFiles_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(354, 209);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(85, 25);
            this.start.TabIndex = 6;
            this.start.Text = "Einspielen";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 244);
            this.Controls.Add(this.start);
            this.Controls.Add(this.fileGroup);
            this.Controls.Add(this.dbGroup);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "EasyDB";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.dbGroup.ResumeLayout(false);
            this.dbGroup.PerformLayout();
            this.fileGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider;
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
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button saveConnection;
        private System.Windows.Forms.Button newConnection;

    }
}