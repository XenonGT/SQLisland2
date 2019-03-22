using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SQLisland
{
    public partial class Form1 : Form
    {
        // Mission-Array
        string[] missions = new string[6];
        string solution1;
        string solution2;
        string solution3;
        string solution4;
        string solution5;
        // Counter for Missions
        int count = 0;
        // Connection to database
        MySqlConnection connection = new MySqlConnection("server=116.203.21.248;database=FM_SQLisland;uid=FM_Admin;password=Passwort#123");
        // exMode for independent SQL operations
        bool exMode = false;
        public Form1()
        {
            InitializeComponent();
            // Generate the missions and possible solutions
            generateMissions();
        }

        // Missions and Solutions are generated
        void generateMissions()
        {
            missions[1] = "Finde alles von den Bewohnern in CityA heraus!";
            missions[2] = "Finde die Bewohner mit dem Beruf 'Detektiv' und ihrem dazugehörigen Namen.";
            missions[3] = "Finde die Bewohner mit Notizbüchern und ihrem dazugehörigen Namen. \n\nHinweis: Items sind immer im Singular angegeben!";
            missions[4] = "Wie viele Bewohner leben in CityB?";
            missions[5] = "Sortiere alle Bewohner nach Alter.";
            missions[0] = "Tutorial: \nNutze die Textbox unten rechts um deine SQL-Befehle zu benutzen." +
                          "\n\nBeispiel: SELECT * FROM Staedte";
            tb_mission.Text = missions[0];
            lbl_mission.Visible = false;
            lbl_mIndex.Visible = false;
            btn_exec.Enabled = false;

            solution1 = "SELECT * FROM Bewohner WHERE Wohnort = 1";
            solution2 = "SELECT Name FROM Bewohner WHERE Beruf = 'Detektiv'";
            solution3 = "SELECT Name FROM Bewohner WHERE Item = 'Notizbuch'";
            solution4 = "SELECT COUNT(ID) FROM Bewohner WHERE Wohnort = 2";
            solution5 = "SELECT * FROM Bewohner ORDER BY B_alter";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(exMode)
            {
                lbl_continue.Visible = false;
                lbl_mIndex.Text = "/";
                btn_exec.Enabled = true;
                tb_exec.Text = "Freier Modus";
                return;
            }
            count++;
            lbl_mIndex.Text = count.ToString();
            if (tb_mission.Text == missions[0])
            {
                tb_mission.Text = missions[1];
                lbl_mIndex.Visible = true;
                lbl_mission.Visible = true;
            }
            else if(tb_mission.Text == missions[1])
            {
                tb_mission.Text = missions[2];
            }
            else if(tb_mission.Text == missions[2])
            {
                tb_mission.Text = missions[3];
            }
            else if(tb_mission.Text == missions[3])
            {
                tb_mission.Text = missions[4];
            }
            else if(tb_mission.Text == missions[4])
            {
                tb_mission.Text = missions[5];
            }
            btn_exec.Enabled = true;
            lbl_continue.Visible = false;
        }

        private void btn_exec_Click(object sender, EventArgs e)
        {
            if(exMode)
            {
                try
                {
                    string exCommand = tb_exec.Text;
                    MySqlCommand exExecute = new MySqlCommand(exCommand, connection);
                    MySqlDataAdapter exAdapter = new MySqlDataAdapter();
                    exAdapter.SelectCommand = exExecute;
                    DataTable exTable = new DataTable();
                    exAdapter.Fill(exTable);

                    dataGridView1.Controls.Clear();
                    dataGridView1.DataSource = exTable;
                }
                catch
                {
                    MessageBox.Show("Fehler bei der SQL-Abfrage"); 
                }
                return;
            }

            if(count == 1)
            {
                if(tb_exec.Text != solution1)
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 2)
            {
                if(tb_exec.Text != solution2)
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 3)
            {
                if(tb_exec.Text != solution3)
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 4)
            {
                if(tb_exec.Text != solution4)
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 5)
            {
                if(tb_exec.Text != solution5)
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
                exMode = true;
            }
            string Command = tb_exec.Text;
            MySqlCommand execute = new MySqlCommand(Command, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = execute;
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView1.Controls.Clear();
            dataGridView1.DataSource = table;

            MessageBox.Show("Aufgabe " + count.ToString() + " erfüllt");
            lbl_continue.Visible = true;
            btn_exec.Enabled = false;
            tb_exec.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //open the connection
                connection.Open();
                MessageBox.Show("Verbindung erfolgreich");

                //Test-Query
                string Query = "select * from Staedte";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);

                //Save the Data in the GridView
                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch
            {
                //Connection failed
                DialogResult result = MessageBox.Show("Verbindung fehlgeschlagen", "Error", MessageBoxButtons.OK);
                if(result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //When the form is closed, the connection will be stopped
            connection.Close();
        }
    }
}
