using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Retrieve_from_AccessDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            String ConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source =
                             C:\\Users\\Jack\\Downloads\\FarmInfomation.accdb;
                             Persist Security Info = False";
            String err_Msg = "";
            String q = "";
            OleDbConnection conn = null;
            try
            {
                conn = new OleDbConnection(ConnStr);
                conn.Open();
                q = "select * from " + QueryBox.Text + ";";
                OleDbCommand cmd = new OleDbCommand(q, conn);
                String str = "";
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    int count = reader.FieldCount;
                    while (reader.Read())
                    {
                        for (int i = 0; i < count; i++)
                        {
                            str = str + reader.GetValue(i) + "\t";
                        }
                        ResultBox.Text += str + "\r\n";
                        str = "";
                        QueryBox.Clear();
                    }
                }
                    //ResultBox.Text += str + "\r\n";
                    //str = "";
                    //QueryBox.Clear();

                conn.Close();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }
}
