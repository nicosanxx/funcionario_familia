using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace funcionario_familia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_hora.Text =="" || txt_kid.Text =="" || txt_per_hr.Text =="")
            {

                MessageBox.Show("FAVOR PREENCHER CORRETAMENTE OS CAMPOS", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                decimal horas = Convert.ToDecimal(txt_hora.Text);
                decimal per_hr = Convert.ToDecimal(txt_per_hr.Text);
                int filhos = Convert.ToInt32(txt_kid.Text);
                decimal salario_bruto;
                decimal salario_final;
                decimal per_kid;

                //CALCULOS
                per_kid =(decimal)(filhos * 1.03);
                salario_bruto = horas * per_hr;
                salario_final = salario_bruto + per_kid;
                txt_result.Text = salario_final.ToString();




                















            }















        }
    }
}
