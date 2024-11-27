﻿using DLWMS.Data;
using DLWMS.Infrastructure;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.WinApp.Studenti
{
    public partial class frmStudentiPretraga : Form
    {
        public frmStudentiPretraga()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmStudentiPretraga_Load(object sender, EventArgs e)
        {
            UcitajStudente();
        }

        private void UcitajStudente(List<Student> studenti = null)
        {
            dgvStudenti.DataSource = null;            
            dgvStudenti.DataSource = studenti ?? InMemoryDB.Studenti;      
        }

        private void btnDodajStudenta_Click(object sender, EventArgs e)
        {
            if (new frmStudentAddEdit().ShowDialog() == DialogResult.OK)
                UcitajStudente();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            //var studenti = InMemoryDB.Studenti.Where(FiltrirajStudente).ToList();
            //UcitajStudente(studenti);

            UcitajStudente(InMemoryDB.Studenti.Where(FiltrirajStudente).ToList());

        }
        private bool FiltrirajStudente(Student student)
        {
            var filter = txtFilter.Text.ToLower();

            return
                student.Ime.ToLower().Contains(filter) ||
                student.Prezime.ToLower().Contains(filter) ||
                student.BrojIndeksa.ToLower().Contains(filter);
        }
    }
}
