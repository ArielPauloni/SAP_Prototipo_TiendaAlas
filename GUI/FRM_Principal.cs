using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;

namespace GUI
{
    public partial class FRM_Principal : Form
    {
        EvaluacionBLL gestorEvaluacion = new EvaluacionBLL();
        TratamientoBLL gestorTratamiento = new TratamientoBLL();

        public FRM_Principal()
        {
            InitializeComponent();
        }

        private void btn_SimularEvaluaciones_Click(object sender, EventArgs e)
        {
            FRM_Info frm_Info = new FRM_Info("Se generarán, al azar, 10 evaluaciones");
            frm_Info.ShowDialog();

            List<EvaluacionBE> evaluaciones = new List<EvaluacionBE>();
            for (int i = 0; i < 10; i++)
            {
                evaluaciones.Add(gestorEvaluacion.CrearEvaluacionAleatoria());
                System.Threading.Thread.Sleep(10);
            }
            int r = gestorEvaluacion.guardarEvaluacionesJSON(evaluaciones);

            if (r > 0)
            {
                string jsonString = gestorEvaluacion.leerEvaluacionesJSON();
                rtbxEvaluaciones.Text = jsonString;
            }
        }

        private void btn_ConsultarTratamiento_Click(object sender, EventArgs e)
        {
            if (DatosPacienteOk())
            {
                FRM_Info frm_Info = new FRM_Info("Se consultará el tratamiento adecuado, según " +
                    "los parámetros seleccionados y de acuerdo con las evaluaciones ya generardas");
                frm_Info.ShowDialog();

                try
                {
                    PacienteBE paciente = new PacienteBE();
                    paciente.Nombre = "Paciente Prueba";
                    paciente.Genero = cboGenero.SelectedItem.ToString();
                    paciente.Edad = short.Parse(cboEdad.SelectedItem.ToString());
                    if (cboFuma.SelectedItem.ToString() == "Si") { paciente.Fuma = true; }
                    else { paciente.Fuma = false; }
                    paciente.ActividadDeportiva = short.Parse(cboDeporte.SelectedItem.ToString());
                    paciente.TiempoRelax = short.Parse(cboTiempoParaSi.SelectedItem.ToString());

                    PatologiaBE patologia = new PatologiaBE();
                    patologia.Descripcion = cboPatologiaPresentada.SelectedItem.ToString();

                    paciente.Patologias = new List<PatologiaBE>();
                    paciente.Patologias.Add(patologia);

                    try
                    {
                        List<EvaluacionBE> evaluaciones = gestorEvaluacion.leerEvaluacionesJSONToList();
                        TratamientoBE tratamimentoSugerido = gestorTratamiento.SugerirTratamiento(paciente, evaluaciones);

                        MessageBox.Show(string.Format("Tratamiento Sugerido: {0}", tratamimentoSugerido.Descripcion), "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (BLL.PatologiaNoEvaluadaException ex)
                    {
                        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (BLL.PatologiaMalEvaluadaException ex)
                    {
                        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    catch (BLL.PacienteSinCoincidenciasSuficientesException ex)
                    {
                        MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                { MessageBox.Show("Error Inesperado: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Debe completar todos los datos del paciente", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private bool DatosPacienteOk()
        {
            bool ret = true;
            if (cboGenero.SelectedIndex < 0) { ret = false; }
            else if (cboEdad.SelectedIndex < 0) { ret = false; }
            else if (cboFuma.SelectedIndex < 0) { ret = false; }
            else if (cboDeporte.SelectedIndex < 0) { ret = false; }
            else if (cboTiempoParaSi.SelectedIndex < 0) { ret = false; }
            else if (cboPatologiaPresentada.SelectedIndex < 0) { ret = false; }
            return ret;
        }

        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            for (int i = 18; i <= 90; i++)
            {
                string[] numbers = { i.ToString() };
                cboEdad.Items.AddRange(numbers);
            }
            for (int i = 0; i <= 7; i++)
            {
                string[] numbers = { i.ToString() };
                cboDeporte.Items.AddRange(numbers);
            }
            for (int i = 0; i <= 28; i++)
            {
                string[] numbers = { i.ToString() };
                cboTiempoParaSi.Items.AddRange(numbers);
            }

            try
            {
                string jsonString = gestorEvaluacion.leerEvaluacionesJSON();
                rtbxEvaluaciones.Text = jsonString;
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
