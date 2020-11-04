using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_in_Database__MDI_
{
    public partial class Form1 : Form
    {
        //Declaration des Childs 
        PassengerForm PassangerForm;
        PiloteForm PiloteForm;
        //Declaration des Connection est la command qu'il va etre execute
        string connection_String = ConfigurationManager.ConnectionStrings["mon_connection"].ConnectionString;
        SqlConnection connection;
        SqlCommand command;
        //declarer un pointer pour holder une method qu'il va gerer la connection est les command
        Action<string> Inserer_Info;

        public Form1()
        {
            InitializeComponent();
            Inserer_Info = query =>
            {
                try
                {
                    using (connection)
                    {
                        connection = new SqlConnection(connection_String);
                        command = new SqlCommand(query, connection);
                        connection.Open();
                        int nombre_lignes_affecte = command.ExecuteNonQuery();
                        MessageBox.Show(nombre_lignes_affecte + " lignes a ete affecte.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            };
        }

        private void PassagerItem_Click(object sender, EventArgs e)
        {
            PassangerForm = new PassengerForm(Inserer_Info);
            Changer_Form(PassangerForm);
        }

        private void PiloteItem_Click(object sender, EventArgs e)
        {
            PiloteForm = new PiloteForm(Inserer_Info);
            Changer_Form(PiloteForm);
        }

        void Changer_Form(Form NewForm)
        {
            if (this.ActiveMdiChild != null) this.ActiveMdiChild.Close();
            NewForm.MdiParent = this;
            NewForm.Dock = DockStyle.Fill;
            NewForm.Show();
        }
    }
}
