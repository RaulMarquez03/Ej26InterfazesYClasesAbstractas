using Microsoft.VisualBasic.ApplicationServices;
using System;

namespace Ej26InterfazesYClasesAbstractas
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

        private void CreateScholar_Click(object sender, EventArgs e)
        {
            ListViewItem nuevoItem = new ListViewItem(NameScholar.Text);
            nuevoItem.SubItems.Add(LastNameScholar.Text);
            nuevoItem.SubItems.Add(DniScholar.Text);
            nuevoItem.SubItems.Add(BaseSalary.Text);
            nuevoItem.SubItems.Add(NameScholar.Text);
            nuevoItem.SubItems.Add(NameScholar.Text);
            nuevoItem.SubItems.Add(NameScholar.Text);
            nuevoItem.SubItems.Add(NameScholar.Text);

            listView1.Items.Add(nuevoItem);


        }

        private void CreateQualified_Click(object sender, EventArgs e)
        {

        }
    }
}