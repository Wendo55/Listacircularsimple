using System;
using System.Windows.Forms;
using System.IO;

namespace Listacircularsimple
{
    public partial class Form1 : Form
    {
        Nodo n;
        private ListaCircular MiLista;
        public Form1()
        {
            InitializeComponent();
            MiLista = new ListaCircular();
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
      if (MiLista == null)
      {
        MiLista = new ListaCircular();
      }
            try
            {
                if (!MiLista.BuscarDato(int.Parse(txtNodo.Text)))
                {
                    n = new Nodo();
                    n.Dato = int.Parse(txtNodo.Text);
                    MiLista.Agregar(n);
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                }
                else
                {
                    MessageBox.Show("El dato ya existe en la lista.");
                    txtNodo.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ingresa un número válido.");
            }
        }
        private void BtnEliminarNodo_Click(object sender, EventArgs e)
        {
        if (MiLista == null)
        {
            return;
        }
        try
            {
                int dato = int.Parse(txtEliminar.Text);

                if (!MiLista.BuscarDato(dato))
                {
                    MessageBox.Show("Dato no encontrado");
                    lblLista.Text = MiLista.ToString();
                    txtNodo.Clear();
                    return;
                }
                MiLista.Borrar(dato);
                lblLista.Text = MiLista.ToString();
                txtEliminar.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Introduzca un número válido.");
            }
        }
        private void BtnContar_Click(object sender, EventArgs e)
        {
        if (MiLista == null)
        {
          return;
        }
      MessageBox.Show("Número de nodos en la lista:" + MiLista.ContarNodos());
        }
        private void BtnVaciarLista_Click(object sender, EventArgs e)
        {
            MiLista = null;
        }
    }
}