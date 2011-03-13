using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EasyDB
{
    public partial class MainWindow : Form
    {

        ProgramFile ProgramFile = ProgramFile.Instance;
        Connection Connection = Connection.Instance;

        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void MainWindow_Load(object sender, EventArgs e) { }
        private void database_TextChanged(object sender, EventArgs e) { }
        private void host_TextChanged(object sender, EventArgs e) { }
        private void user_TextChanged(object sender, EventArgs e) { }
        private void password_TextChanged(object sender, EventArgs e) { }
        private void name_TextChanged(object sender, EventArgs e) { }


        public MainWindow()
        {
            InitializeComponent();
            this.refreshConnections();

            if (saveConnection.Enabled == false)
            {
                if (host.Text.Equals("") && user.Text.Equals("") && password.Text.Equals("")
                    && database.Text.Equals("") && name.Text.Equals(""))
                {
                    saveConnection.Enabled = true;
                }
            }
            
        }


        private void importFiles_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.ShowDialog();

            if (ProgramFile.ReadDir(folderBrowserDialog.SelectedPath,true,"SQL",true))
            {
                // dateien abholen
                Hashtable files = ProgramFile.GetSQLHashtable();

                if (files.Count != 0)
                {

                    // dateien als einträge zu der checkbox hinzufügen.
                    foreach (DictionaryEntry file in files)
                    {
                        this.checkedListBox.Items.Add(file.Value);
                    }

                    // all items aktivieren
                    for (int i = 0; i <= this.checkedListBox.Items.Count - 1; i++)
                    {
                        if (!this.checkedListBox.GetItemChecked(i))
                        {
                            this.checkedListBox.SetItemChecked(i, true);
                        }
                    }

                    this.deactivateAll.Enabled = true;
                    this.importFiles.Enabled = false;
                    this.deleteFiles.Enabled = true;
                }
                else
                {
                    MessageBox.Show(importFiles,"Es konnten keine SQL Dateien gefunden werden!");
                }
            }
        }

        private void activateAll_Click(object sender, EventArgs e)
        {
            // all items aktivieren
            for (int i = 0; i <= this.checkedListBox.Items.Count - 1; i++)
            {
                if (!this.checkedListBox.GetItemChecked(i))
                {
                    this.checkedListBox.SetItemChecked(i, true);
                }
            }
            this.deactivateAll.Enabled = true;
            this.activateAll.Enabled = false;
        }

        private void deactivateAll_Click(object sender, EventArgs e)
        {
            // all items deaktivieren
            for (int i = 0; i <= this.checkedListBox.Items.Count - 1; i++)
            {
                if (this.checkedListBox.GetItemChecked(i))
                {
                    this.checkedListBox.SetItemChecked(i, false);
                }
            }

            this.deactivateAll.Enabled = false;
            this.activateAll.Enabled = true;
        }

        private void deleteFiles_Click(object sender, EventArgs e)
        {
    
            ProgramFile.clear("SQL");

            this.checkedListBox.Items.Clear();

            this.deactivateAll.Enabled = false;
            this.activateAll.Enabled = false;
            this.importFiles.Enabled = true;
            this.deleteFiles.Enabled = false;
        }

        private void create_Click(object sender, EventArgs e)
        {

            if (host.Text.Equals("") || user.Text.Equals("") || password.Text.Equals("") ||
                 database.Text.Equals(""))
            {
                MessageBox.Show("Bitte füllen Sie alle Angaben zur Datenbank Verbindung aus!");
            }
            else
            {
                Batch batch = new Batch();
                batch.host = host.Text.ToString();
                batch.user = user.Text.ToString();
                batch.password = password.Text.ToString();
                batch.database = database.Text.ToString();

                if (!this.checkedListBox.Items.Count.Equals(0))
                {
                    Hashtable sqlFiles = ProgramFile.GetSQLHashtable();


                    for (int i = 0; i <= this.checkedListBox.Items.Count - 1; i++)
                    {
                        if (this.checkedListBox.GetItemChecked(i))
                        {
                            //Console.WriteLine(this.checkedListBox.Items[i]);
                            foreach (DictionaryEntry file in sqlFiles)
                            {
                                if (file.Value.ToString().Equals(this.checkedListBox.Items[i].ToString()))
                                {
                                    batch.create(file.Key.ToString(), file.Value.ToString(), i);
                                    break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Es sind keine Dateien ausgewählt!");
                }

            }

        }

        private void newConnection_Click(object sender, EventArgs e)
        {
            //connections.Items.Insert(0,"Neue Verbindung");
            connections.SelectedIndex = 0;
            host.Text = "";
            user.Text = "";
            password.Text = "";
            database.Text = "";
            name.Text = "";
            if (saveConnection.Enabled == false)
            {
                saveConnection.Enabled = true;
            }

        }

        private void saveConnection_Click(object sender, EventArgs e)
        {
            Connection.save(host.Text, user.Text, password.Text, database.Text, name.Text);
            this.refreshConnections();
        }

        private void connections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!connections.Text.Equals(""))
            {
                Hashtable data = Connection.load(connections.Text);
                foreach (DictionaryEntry entry in data)
                {
                    switch (entry.Key.ToString())
                    {
                        case "database":
                            database.Text = entry.Value.ToString();
                            break;
                        case "name":
                            name.Text = entry.Value.ToString();
                            break;
                        case "password":
                            password.Text = entry.Value.ToString();
                            break;
                        case "host":
                            host.Text = entry.Value.ToString();
                            break;
                        case "user":
                            user.Text = entry.Value.ToString();
                            break;
                    }

                }
            }
        }

        private void refreshConnections()
        {
            this.connections.Items.Clear();
            this.Connection.loadAll();
            Hashtable foundConnections = this.Connection.getConnections();
            connections.Items.Insert(0,"");
            int countConnections = 1;
            foreach (DictionaryEntry connection in foundConnections)
            {
                this.connections.Items.Insert(countConnections, connection.Value);
                countConnections++;
            }
        }

        private void configurationOpen_Click(object sender, EventArgs e)
        {
            ConfigWindow configWindow = new ConfigWindow();
            configWindow.Show();
        }
    }
}
