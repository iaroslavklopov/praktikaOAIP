using System.ComponentModel;
using System.Data.Entity;

namespace cruddb
{
    public partial class HomePage : Form
    {
        Context db;
        public HomePage()
        {
            InitializeComponent();
            db = new Context();
            db.General.Load();
            dgv.DataSource = db.General.Local.ToBindingList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            DialogResult res = add.ShowDialog(this);
            General general = new General();
            general.FirstName = add.fnameadd.Text;
            general.LastName = add.lnameadd.Text;
            general.MiddleName = add.mnameadd.Text;
            general.DateOfBirth = add.dobadd.Text;
            general.Gender = add.gadd.Text;
            {
                db.General.Add(general);
                db.SaveChanges();
            }


        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            Edit Update = new Edit();
            General general = new General();
            general = db.General.Find(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
            Update.lnameedit.Text = general.LastName;
            Update.fnameedit.Text = general.FirstName;
            Update.mnameedit.Text = general.MiddleName;
            Update.dobedit.Text = general.DateOfBirth;
            Update.gedit.Text = general.Gender;
            DialogResult ress = Update.ShowDialog(this);
            if (ress == DialogResult.Cancel) return;
            general.LastName = Update.lnameedit.Text;
            general.FirstName = Update.fnameedit.Text;
            general.MiddleName = Update.mnameedit.Text;
            general.DateOfBirth = Update.dobedit.Text;
            general.Gender = Update.gedit.Text;

            {
                db.SaveChanges();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            General general = new General();
            general = db.General.Find(Convert.ToInt32(dgv.CurrentRow.Cells[0].Value));
            db.General.Remove(general);
            db.SaveChanges();
        }
    }
}