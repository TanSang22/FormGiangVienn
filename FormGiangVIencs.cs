using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormApp;

namespace RunningFromTheDayLight
{
    public partial class FormGiangViencs : Form
    {
        public FormGiangViencs()
        {
            InitializeComponent();
        }

        private void FormGiangViencs_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip_btnTeacher_Click(object sender, EventArgs e)
        {
            CreateExamRandom createExamRandom = new CreateExamRandom();
            createExamRandom.Show();
        }

        private void toolStrip_btnListStudent_Click(object sender, EventArgs e)
        {
            AddSubjeccs addSubjeccs = new AddSubjeccs();
            addSubjeccs.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Readfile readfile = new Readfile();
            readfile.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Add_Fix_Del_Qestions add_Fix_Del_Qestions = new Add_Fix_Del_Qestions();
            add_Fix_Del_Qestions.Show();
        }
    }
}
