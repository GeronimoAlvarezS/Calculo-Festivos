using CalculoFeSstivos.Servicios;

namespace CalculoFeSstivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            nupAño.Value = DateTime.Now.Year;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime domingoRamos = ServicioFechas.ObtenerInicioSemanaSanta((int)nupAño.Value);
            dgvFechas.Columns.Clear();
            dgvFechas.Rows.Clear();

            dgvFechas.Columns.Add("Festivo", "Festivo");
            dgvFechas.Columns.Add("Fecha", "Fecha");

            dgvFechas.Rows.Add();
            dgvFechas.Rows[0].Cells[0].Value = "Domingo de Ramos";
            dgvFechas.Rows[0].Cells[1].Value = domingoRamos.ToString();
            DateTime domingoPascua = ServicioFechas.AgregarDias(domingoRamos, 7);

            dgvFechas.Rows.Add();
            dgvFechas.Rows[1].Cells[0].Value = "Domingo de Pascua";
            dgvFechas.Rows[1].Cells[1].Value = domingoPascua.ToString();

            var ReyesMagos = ServicioFechas.SiguienteLunes(new DateTime((int)nupAño.Value, 1, 6));

            dgvFechas.Rows.Add();
            dgvFechas.Rows[2].Cells[0].Value = "Reyes Magos";
            dgvFechas.Rows[2].Cells[1].Value = ReyesMagos.ToString();

            var JuevesSanto = ServicioFechas.AgregarDias(domingoPascua, -3);

            dgvFechas.Rows.Add();
            dgvFechas.Rows[3].Cells[0].Value = "Jueves Santo";
            dgvFechas.Rows[3].Cells[1].Value = JuevesSanto.ToString();

            var ViernesSanto = ServicioFechas.AgregarDias(domingoPascua, -2);

            dgvFechas.Rows.Add();
            dgvFechas.Rows[4].Cells[0].Value = "Viernes Santo";
            dgvFechas.Rows[4].Cells[1].Value = ViernesSanto.ToString();

            var AscenciondelSeñor = ServicioFechas.SiguienteLunes(ServicioFechas.AgregarDias(domingoPascua, 40));

            dgvFechas.Rows.Add();
            dgvFechas.Rows[5].Cells[0].Value = "Ascención del Señor";
            dgvFechas.Rows[5].Cells[1].Value = AscenciondelSeñor.ToString();

            var SagradoCorazon = ServicioFechas.SiguienteLunes(ServicioFechas.AgregarDias(domingoPascua, 68));

            dgvFechas.Rows.Add();
            dgvFechas.Rows[6].Cells[0].Value = "Sagrado Corazón de Jesús";
            dgvFechas.Rows[6].Cells[1].Value = SagradoCorazon.ToString();
        }
    }
}
