using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseGasto;



namespace GestorGastos
{
    public partial class Form1 : Form
    {
        double presupuesto;
        ListView listViewGastos;
        List<Gasto> ListaGastos = new List<Gasto>();

        public Form1()
        {
            Gasto si = new Gasto();

            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LimpiarCampos()
        {
            cmbCategoria.SelectedIndex = -1; // Deseleccionar cualquier categoría seleccionada
            txtMonto.Text = string.Empty; // Vaciar el campo de monto
            dtpFecha.Value = DateTime.Today; // Establecer la fecha actual
            lblId.Text = string.Empty; // Vaciar la etiqueta de ID
        }
        private int GetNextId()
        {
            int maxId = 0;

            // Obtener el máximo ID actual en la lista de gastos
            foreach (Gasto gasto in gastos)
            {
                if (gasto.Id > maxId)
                {
                    maxId = gasto.Id;
                }
            }

            // Incrementar el máximo ID para obtener el siguiente ID disponible
            int nextId = maxId + 1;

            return nextId;
        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Gasto NuevoGasto = new Gasto();
            //ComboBox Agregar Categoria
            NuevoGasto.Categoria = cmbCategoria.Text;
            //Agregar Fecha con un CateTimePicker
            NuevoGasto.Fecha = dtpFecha.Value;
            //textbox Agregar Descripcion
            NuevoGasto.Descripcion = txtDescripcion.Text.TrimEnd();
            //textbox monto
            NuevoGasto.Monto = Convert.ToDouble(txtMonto.Text);
            NuevoGasto.ID = GetNextId();
            presupuesto -= NuevoGasto.Monto;
            if (presupuesto >= 0) {

                ListaGastos.Add(NuevoGasto);
                LimpiarCampos();
            }
            else
            {
                //Tus gastos exeden tu presupuesto.
            }



            //Espacio para agregar el texto 

            //Cada vez que se cree un objeto se va a estar restando del presupuesto inicial. 


        }

        private void button1_Click(object sender, EventArgs e)
        {

            int UserId = txtMonto.Text.TrimEnd();

            //Boton eliminar
            //A continuación se va a desplegar todos los datos que se encuentran almacenados, para que de esta forma,se generen los datos que se desean cambiar
            //Se va a utilizar una lisview para mostrar los datos
            //Iterador será la variable del mismo tipo que el opbjeto, el cual nos va a servir para igualar los datos 
            if (listViewGastos.SelectedItems.Count > 0)
            {
                // Obtener el elemento seleccionado y eliminarlo del ListView
                ListViewItem selectedItem = listViewGastos.SelectedItems[0];
                listViewGastos.Items.Remove(selectedItem);

                // Limpiar los controles de edición
                LimpiarCampos();
            }
        }
    }
        }

        private void ButtonInformes_Click(object sender, EventArgs e)
        {
            DateTime fechaFiltro = dtpFechaFiltro.value;
            //Este no debería ser un arreglo.
            string[] categoriaFiltro = cmbCategoriaFiltro.Text;

            List<Gasto> GastosFiltrados = new List<Gasto>;

            foreach (Gasto iterador in ListaGastos)

            {
                //Revisa categoria, no comprendo porque tengo error en iterador
                if (iterador.Categoria = categoriaFiltro.[iterador.Categoria])
                {
                    GastosFiltrados.Add(iterador);
                }
                if (iterador.Fecha.Month == fechaFiltro.Month)
                {
                    GastosFiltrados.Add(iterador);
                }
                if (!string.IsNullOrEmpty(categoriaFiltro))
                {
                    //Solo funciona sin el array
                    GastosFiltrados = GastosFiltrados.Where(g => g.Categoria == categoriaFiltro).ToList();
                }
                listViewGastos.Items.Clear();

    // Agregar los gastos filtrados al ListView
    foreach (Gasto gasto in GastosFiltrados)
    {
        string[] row = {
            gasto.Categoria,
            gasto.Monto.ToString(),
            gasto.Fecha.ToString(),
            gasto.Id.ToString()
        };

        ListViewItem listViewItem = new ListViewItem(row);
        listViewGastos.Items.Add(listViewItem);
    }
}
            }

        }



    }
}


