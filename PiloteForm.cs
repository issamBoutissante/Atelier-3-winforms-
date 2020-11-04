using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Insert_in_Database__MDI_
{
    public partial class PiloteForm : Form
    {
        Action<string> Insert_Info;
        public PiloteForm(Action<string> insert_Info)
        {
            InitializeComponent();
            Insert_Info = insert_Info;
        }
        private void Inserer_Pilote_Click(object sender, EventArgs e)
        {
            string query = string.Format("insert into pilote(nom,CodePostal,ville) values('{0}','{1}','{2}')",
                                     Pilote_Nom.Text, Pilote_Code_Postal.Text, Pilote_ville.Text);
            Insert_Info(query);

        }
    }
}
