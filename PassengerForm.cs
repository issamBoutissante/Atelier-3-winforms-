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
    public partial class PassengerForm : Form
    {
        Action<string> Insert_Info;
        public PassengerForm(Action<string> insert_Info)
        {
            InitializeComponent();
            this.Insert_Info = insert_Info;
        }

        private void Inserer_Passanger_Click(object sender, EventArgs e)
        {      
            string ma_query = string.Format("insert into passager values('{0}','{1}','{2}','{3}')",Passager_Pass.Text, Passager_Nom.Text, Passager_Prenom.Text, Passager_ville.Text);
            Insert_Info(ma_query);
        }
    }
}
