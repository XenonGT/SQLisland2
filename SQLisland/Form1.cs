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
        string[] missions = new string[6];
        int count = 0;
        MySqlConnection connection = new MySqlConnection("server=116.203.21.248;database=FM_SQLisland;uid=FM_Admin;password=Passwort#123");
        public Form1()
        {
            InitializeComponent();
            generateMissions();
            // 2 Städte: CityA, CityB
            // Jede Stadt hat 5 Bewohner
            // Bewohner haben Name, Beruf, Item und Alter
        }

        void generateMissions()
        {
            missions[1] = "Finde alles von den Bewohnern in CityA heraus!";
            missions[2] = "Finde die Bewohner mit Beruf Detektiv";
            missions[3] = "Finde die Bewohner mit Notizbüchern";
            missions[4] = "Nimm das Notizbuch von Bewohner Light";
            missions[5] = "";
            missions[0] = "Tutorial: \nNutze die Textbox unten rechts um deine SQL-Befehle zu benuten.";
            tb_mission.Text = missions[0];
            lbl_mission.Visible = false;
            lbl_mIndex.Visible = false;
            btn_exec.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
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
            if(count == 1)
            {
                if(tb_exec.Text != "Select * from Bewohner where Wohnort = 1")
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 2)
            {
                if(tb_exec.Text != "Select * from Bewohner where Beruf = Detektiv")
                {
                    MessageBox.Show("Diese SQL-Abfrage ist falsch!");
                    return;
                }
            }
            else if(count == 3)
            {
                if(tb_exec.Text != "Select * from Bewohner where Item = Notizbuch")
                {
                    MessageBox.Show("Falsch");
                    return;
                }
            }
            else if(count == 4)
            {
                if(tb_exec.Text != "")
                {
                    MessageBox.Show("Falsch");
                    return;
                }
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
                connection.Open();
                MessageBox.Show("Verbindung erfolgreich");
                string Query = "select * from Staedte";
                MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);

                MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
                MyAdapter.SelectCommand = MyCommand2;
                DataTable dTable = new DataTable();
                MyAdapter.Fill(dTable);
                dataGridView1.DataSource = dTable; 
            }
            catch
            {
                MessageBox.Show("Verbindung fehlgeschlagen");
                Environment.Exit(0);
            }      
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }
    }
}
