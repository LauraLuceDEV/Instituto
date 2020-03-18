using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbAccess_v1
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.institutoDataSet.Asignatura);
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.Profesores' Puede moverla o quitarla según sea necesario.
            this.profesoresTableAdapter.Fill(this.institutoDataSet.Profesores);
            // TODO: esta línea de código carga datos en la tabla 'institutoDataSet.Alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.institutoDataSet.Alumnos);


           // this.dataGridView1.FillByAlumnosEdad21(this.institutoDataSet.Alumnos);

        }

        //BOTONES PARA SALIR DE LA APLICACIÓN
        private void btnAlumSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProfSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAsigSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //AGREGAMOS
        //Añadir alumno
        private void btnAddAlum_Click(object sender, EventArgs e)
        {
            alumnosBindingSource.AddNew();
            btnModifAlum.Enabled = false;
            btnElimAlum.Enabled = false;
            dniTextBox.Enabled = true;
            panel1.Enabled = true;

            btnGuardarAlum.Enabled = true;
            btnCancelarAlum.Visible = true;

            dniTextBox.Focus();
        }

        //Añadir profesor
        private void btnAddProf_Click(object sender, EventArgs e)
        {
            profesoresBindingSource.AddNew();
            btnModifProf.Enabled = false;
            btnElimProf.Enabled = false;
            dniProfesorTb.Enabled = true;
            panel2.Enabled = true;

            btnGuardarProfe.Enabled = true;
            btnCancelProfe.Visible = true;

            dniProfesorTb.Focus();
        }

        //Añadir asignaturas
        private void btnAddAsig_Click(object sender, EventArgs e)
        {
            asignaturaBindingSource.AddNew();
            btnModifAsig.Enabled = false;
            btnElimAsig.Enabled = false;
            idAsigTextBox.Enabled = true;
            panel3.Enabled = true;

            btnGuardarAsig.Enabled = true;
            btnCacelAsig.Enabled = true;

            idAsigTextBox.Focus();
        }

        //MODIFICAMOS
        private void btnModifAlum_Click(object sender, EventArgs e)
        {
            dniTextBox.Enabled = false;
            btnAddAlum.Enabled = false;
            btnElimAlum.Enabled = false;

            panel1.Enabled = true;
            btnGuardarAlum.Enabled = true;
            btnCancelarAlum.Visible = true;
        }

        private void btnModifProf_Click(object sender, EventArgs e)
        {
            dniProfesorTb.Enabled = false;
            btnAddProf.Enabled = false;
            btnElimProf.Enabled = false;

            panel2.Enabled = true;
            btnGuardarProfe.Enabled = true;
            btnCancelProfe.Visible = true;

        }

        //GUARDAR

        //Guardar Alumno
        private void btnGuardarAlum_Click(object sender, EventArgs e)
        {
            if (dniTextBox.Text.Length > 0 && nombreTextBox.Text.Length > 0 && direccionTextBox.Text.Length > 0 && 
                tlfTextBox.Text.Length > 0 && fecha_nacimientoDateTimePicker.Value != null)
            {
                this.alumnosBindingSource.EndEdit();
                this.alumnosTableAdapter.Update(institutoDataSet.Alumnos);
                this.alumnosDataGridView.Refresh();

                btnAddAlum.Enabled = true;
                btnModifAlum.Enabled = true;
                btnElimAlum.Enabled = true;

                panel1.Enabled = false;
                btnGuardarAlum.Enabled = false;
                btnCancelarAlum.Visible = false;

            }else{
                MessageBox.Show("Debes tener todos los campos rellenos", "ERROR");
            }
        }

        //Guardar Profe
        private void btnGuardarProfe_Click(object sender, EventArgs e)
        {
            if (dniProfesorTb.Text.Length > 0 && nombreProfesorTextBox.Text.Length > 0 ||
                departamentoTextBox.Text.Length > 0)
            {
                this.profesoresBindingSource.EndEdit();
                this.profesoresTableAdapter.Update(institutoDataSet.Profesores);
                this.profesoresDataGridView.Refresh();

                btnAddProf.Enabled = true;
                btnModifProf.Enabled = true;
                btnElimProf.Enabled = true;

                panel2.Enabled = false;
                btnGuardarProfe.Enabled = false;
                btnCancelProfe.Visible = false;

            }else { MessageBox.Show("Debes tener todos los campos rellenos", "ERROR"); }
        }


        //Guardar Asignatura
        private void btnGuardarAsig_Click(object sender, EventArgs e)
        {
            if(idAsigTextBox.Text.Length > 0 && nombreAsigtb.Text.Length > 0 && dni_profesorAsigTb.Text.Length > 0)
            {
                this.asignaturaBindingSource.EndEdit();
                this.asignaturaTableAdapter.Update(institutoDataSet.Asignatura);
                this.asignaturaDataGridView.Refresh();

                btnAddAsig.Enabled = true;
                btnModifAsig.Enabled = true;
                btnCacelAsig.Visible = true;

            }else { MessageBox.Show("Debes tener todos los campos rellenos", "ERROR"); }
        }

        // ELIMINAR REGISTROS
        private void btnElimAlum_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea borrar el registro del alumno?", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.alumnosTableAdapter.Delete(dniTextBox.Text, nombreTextBox.Text, direccionTextBox.Text, Convert.ToInt32(tlfTextBox.Text), fecha_nacimientoDateTimePicker.Value);
                this.institutoDataSet.Alumnos.Rows.RemoveAt(this.alumnosDataGridView.CurrentCell.RowIndex);
                this.alumnosTableAdapter.Update(institutoDataSet.Alumnos);
            }
        }

        private void btnElimProf_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el registro del Profesor?", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.profesoresTableAdapter.Delete(dniProfesorTb.Text, nombreProfesorTextBox.Text, departamentoTextBox.Text);
                this.institutoDataSet.Profesores.Rows.RemoveAt(this.profesoresDataGridView.CurrentCell.RowIndex);
                this.profesoresTableAdapter.Update(institutoDataSet.Profesores);
            }
        }

        private void btnElimAsig_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea borrar el registro del Profesor?", "Borrar Registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.asignaturaTableAdapter.Delete( Convert.ToInt32(idAsigTextBox.Text), nombreAsigtb.Text, dni_profesorAsigTb.Text);
                this.institutoDataSet.Asignatura.Rows.RemoveAt(this.asignaturaDataGridView.CurrentCell.RowIndex);
                this.asignaturaTableAdapter.Update(institutoDataSet.Asignatura);
            }

        }

        //CANCELAR
        private void btnCancelarAlum_Click(object sender, EventArgs e)
        {
            btnAddAlum.Enabled = true;
            btnModifAlum.Enabled = true;
            btnElimAlum.Enabled = true;

            dniTextBox.Text = "";
            nombreTextBox.Text = "";
            direccionTextBox.Text = "";
            tlfTextBox.Text = "";
        }


        private void btnCancelProfe_Click_1(object sender, EventArgs e)
        {
            btnAddProf.Enabled = true;
            btnModifProf.Enabled = true;
            btnElimProf.Enabled = true;

            dniProfesorTb.Text = "";
            nombreProfesorTextBox.Text = "";
            departamentoTextBox.Text = "";
        }


        private void btnCacelAsig_Click(object sender, EventArgs e)
        {
            btnAddAsig.Enabled = true;
            btnModifAsig.Enabled = true;
            btnElimAsig.Enabled = true;

            idAsigTextBox.Text = "";
            nombreAsigtb.Text = "";
            dni_profesorAsigTb.Text = "";
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Name == "tabPage4")
            {
                try
                {
                    this.alumnosTableAdapter.FillByAlumnosEdad21(this.institutoDataSet.Alumnos);
                    this.profesoresTableAdapter.FillByProfesoresDelDptoLengua(this.institutoDataSet.Profesores);

                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }
            }
            else if (tabControl1.SelectedTab.Name == "tabPage1")
            {
                this.alumnosTableAdapter.Fill(this.institutoDataSet.Alumnos);

            }
            else if (tabControl1.SelectedTab.Name == "tabPage2")
            {
                this.profesoresTableAdapter.Fill(this.institutoDataSet.Profesores);

            }
            else if (tabControl1.SelectedTab.Name == "tabPage5")
            {
                    this.profesoresTableAdapter.Fill(this.institutoDataSet.Profesores);
            }
        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            String AsignaturaSelec = (String)comboBoxDepartamento.SelectedItem;

            if (AsignaturaSelec == "Matemáticas")
            {
                this.profesoresTableAdapter.FillByProfDeptoMates(this.institutoDataSet.Profesores);

            }else if(AsignaturaSelec == "Lengua")
            {
                this.profesoresTableAdapter.FillByProfesoresDelDptoLengua(this.institutoDataSet.Profesores);
            }
            else if (AsignaturaSelec == "Informática")
            {
                this.profesoresTableAdapter.FillByProfesoresDepInfor(this.institutoDataSet.Profesores);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.alumnosTableAdapter.FillByDate(institutoDataSet.Alumnos, dtpFecha1.Value, dtpFecha2.Value);
        }
    }
}
