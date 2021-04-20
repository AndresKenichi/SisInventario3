using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CapaNegocio;
namespace Loggin
{
    public partial class Usuarios : Form
    {
        private bool AñadirPressed = false;
        private bool ModificarPressed = false;
        private bool EliminarPressed = false;

        private bool OneAccount = false;
        private bool ExistAccount = false;

        private ArrayList infoUser = new ArrayList();
        private ArrayList userCred = new ArrayList();
        private int regUser = 0;
        public NUsuarios objU = new NUsuarios();

        

        public Usuarios()
        {
            InitializeComponent();
        }
        private void MensajeOK(String mensaje)
        {
            MessageBox.Show(mensaje, "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void Usuarios_Load(object sender, EventArgs e)
        {
            ShowPrincipalButtons(false,false,false);
            HideItems();
        }

        private void ShowPrincipalButtons(bool a, bool b, bool c) {

            btnAgregarUs.Visible = a;
            btnModifUs.Visible = b;
            btnEliminarUs.Visible = c;

        }
        
        private void ShowItems()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            txtCorreoUs.Visible = true;
            txtClaveUs.Visible = true;
            txtConClaveUs.Visible = true;
            cbTipoUs.Visible = true;
            chMostrar.Visible = true;

            btnAceptarUs.Visible = true;
            btnCancelarUs.Visible = true;
        }

        private void HideItems() {
            
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            
            txtCorreoUs.Visible = false;
            txtClaveUs.Visible = false;
            txtConClaveUs.Visible = false;
            cbTipoUs.Visible = false;
            chMostrar.Visible = false;
            btnAceptarUs.Visible = false;
            btnCancelarUs.Visible = false;
            
        }
        private void EnabledPrincipalButtons(bool a,bool b,bool c) {

            btnAgregarUs.Enabled = a;
            btnModifUs.Enabled = b;
            btnEliminarUs.Enabled = b;
        }
        public void mami() {

            string accept = "";

            if (AñadirPressed == true)
            {

                accept = objU.Insertar(Int32.Parse(this.txtCodigoUs.Text), this.txtCorreoUs.Text.Trim(), this.txtClaveUs.Text, (this.cbTipoUs.SelectedIndex + 1));

                if (accept == "INGRESADO")
                {

                    this.MensajeOK(accept);
                    this.HideItems();
                    EnabledPrincipalButtons(false, true, true);
                    ClearText();
                }
                else
                {
                    this.MensajeOK(accept);
                }

            }
            else if (ModificarPressed == true)
            {

                accept = objU.Modificar(Int32.Parse(this.txtCodigoUs.Text), this.txtCorreoUs.Text.Trim(), this.txtClaveUs.Text, (this.cbTipoUs.SelectedIndex));

                if (accept == "MODIFICADO")
                {
                    this.MensajeOK(accept);
                    this.HideItems();
                    ShowPrincipalButtons(true, true, true);
                    EnabledPrincipalButtons(false, true, true);
                    txtCodigoUs.Text = string.Empty;
                    ClearText();
                    lbCargoUs.Text = "";
                    lbNombreUs.Text = "";
                }
                else
                {
                    this.MensajeOK(accept);
                }

            }
            else if (EliminarPressed == true)
            {

                accept = objU.Eliminar(Int32.Parse(this.txtCodigoUs.Text));

                if (accept == "ELIMINADO")
                {

                    this.MensajeOK(accept);
                    this.HideItems();
                    ShowPrincipalButtons(true, true, true);
                    EnabledPrincipalButtons(false, false, false);
                    ClearText();
                    txtCodigoUs.Text = string.Empty;
                    cbTipoUs.SelectedIndex = -1;
                }
                else
                {
                    this.MensajeOK(accept);
                }

            }
        }
        public void papi() {
            //ArrayList
            infoUser = objU.UsuarioInfo(Int32.Parse(txtCodigoUs.Text));
            regUser = objU.validateUser(Int32.Parse(txtCodigoUs.Text));


            //Si la Array es mayor a 0, significa que existe el usuario
            if (infoUser.Count > 0)
            {
                userCred = objU.UsuarioCredenciales(Int32.Parse(txtCodigoUs.Text));
                //Luego validamos si ya hay un usuario asignado a un usuario para el sistema
                if (regUser == 1)
                {
                    ExistAccount = true;
                    //Si solo hay uno, permitimos Modificar y Eliminar. Deshabilitamos AGREGAR porque ya existe su 
                    //usuario.
                    ShowPrincipalButtons(true, true, true);
                    EnabledPrincipalButtons(false, true, true);
                    lbNombreUs.Text = infoUser[0].ToString();
                    lbCargoUs.Text = infoUser[1].ToString();

                }
                else if (regUser > 1)
                {
                    ShowPrincipalButtons(false, false, false);
                    //Si es uno significa que hay usuario con dicho codigo y esta repetido
                    lbCargoUs.Text = regUser.ToString();
                    //this.MensajeOK("YA EXISTE USUARIO CON ESTE CODIGO");

                }
                else if (regUser < 1)
                {

                    OneAccount = true;
                    //Si es menos a 1, permito poder agregar. Es nuevo.
                    lbNombreUs.Text = infoUser[0].ToString();
                    lbCargoUs.Text = infoUser[1].ToString();
                    //Dejo que use agregarse un USUARIO, ya que no cuenta con una. Por ello solo habilito y
                    //muestro el boton AGREGAR
                    ShowPrincipalButtons(true, true, true);
                    EnabledPrincipalButtons(true, false, false);
                    //ShowPrincipalButtons();
                    //EnabledPrincipalButtons();
                }

            }
            else if (infoUser.Count == 0)
            {
                this.MensajeOK("Empleado No Encontrado");
                lbNombreUs.Text = "";
                lbCargoUs.Text = "";
                HideItems();
                EnabledPrincipalButtons(false, false, false);
            }
        }
        private void btnAceptarUs_Click(object sender, EventArgs e)
        {
            bool a = true;
            if (txtCorreoUs.Text == "")
            {
                errorProvider2.SetError(txtCorreoUs, "Ingrese un Correo");
                a = false;
            }
            else { errorProvider2.SetError(txtCorreoUs, ""); }

            if (txtClaveUs.Text == "")
            {
                a = false;
                errorProvider3.SetError(txtClaveUs, "Ingrese una Contraseña");
            }
            else { errorProvider3.SetError(txtClaveUs, ""); }

            if (txtConClaveUs.Text == "")
            {
                a = false;
                errorProvider4.SetError(txtConClaveUs, "Confirme su contraseña");
            }
            else { errorProvider4.SetError(txtConClaveUs, ""); }
            if (txtClaveUs.Text != txtConClaveUs.Text) {
                a = false;
                errorProvider4.SetError(txtConClaveUs, "Las contraseñas son distintas");
            }
            if (cbTipoUs.SelectedIndex == -1)
            {
                a = false;
                errorProvider5.SetError(cbTipoUs, "Seleccione un Cargo");
            }
            else { errorProvider5.SetError(txtConClaveUs, ""); }

            if (a == true) {

                mami();
                HideItems();
                userCred.Clear();
                EnabledPrincipalButtons(false, false, false);
            }
            
            
        }

        private void btnAgregarUs_Click(object sender, EventArgs e)
        {
            AñadirPressed = true;
            ModificarPressed = false;
            EliminarPressed = false;

            EnabledPrincipalButtons(false,false,false);
            
            ShowItems();
        }

        private void ClearText() {

            txtCorreoUs.Text = string.Empty;
            txtClaveUs.Text = string.Empty;
            txtConClaveUs.Text = string.Empty;
            chMostrar.Checked = false;
            cbTipoUs.SelectedIndex = -1;
        }
        private void fillDates() {

            if (userCred.Count < 1)
            {
                userCred = objU.UsuarioCredenciales(Int32.Parse(txtCodigoUs.Text));

                txtCorreoUs.Text = userCred[0].ToString();
                txtClaveUs.Text = userCred[1].ToString();
                cbTipoUs.SelectedIndex = (Int32.Parse(userCred[2].ToString()) - 1);
            }
            else
            {
                txtCorreoUs.Text = userCred[0].ToString();
                txtClaveUs.Text = userCred[1].ToString();
                lbCargoUs.Text = userCred[2].ToString();
                cbTipoUs.SelectedIndex= Convert.ToInt32(userCred[2].ToString())-3;
            }

        }
        private void btnModifUs_Click(object sender, EventArgs e)
        {
            AñadirPressed = false;
            ModificarPressed = true; 
            EliminarPressed = false;

            fillDates();

            EnabledPrincipalButtons(false,false,false);
            ShowItems();
        }

        private void btnBuscarUs_Click(object sender, EventArgs e)
        {
            
            if (txtCodigoUs.Text == "" || string.IsNullOrWhiteSpace(txtCodigoUs.Text.ToString()))
            {
                EnabledPrincipalButtons(false, false, false);
                lbCargoUs.Text = "";
                lbNombreUs.Text = "";
                errorProvider1.SetError(txtCodigoUs, "Debe Ingresar un Codigo a Buscar");
            }
            else
            {
                papi();
                ClearText();
                HideItems();
                errorProvider1.SetError(txtCodigoUs, "");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            AñadirPressed = false;
            ModificarPressed = false;
            EliminarPressed = true;

            fillDates();

            EnabledPrincipalButtons(false,false,false);
            ShowItems();
        }

        private void btnCancelarUs_Click(object sender, EventArgs e)
        {
            if (OneAccount == true)
            {

                EnabledPrincipalButtons(true, false, false);
                ClearText();

            }
            if (ExistAccount == true) {

                EnabledPrincipalButtons(false, true, true);
                ClearText();
            }

            AñadirPressed = false;
            ModificarPressed = false;
            EliminarPressed = false;

            HideItems();
        }

        private void txtCodigoUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void chMostrar_CheckedChanged(object sender, EventArgs e)
        {
            switch (chMostrar.Checked) {

                case true:
                    txtClaveUs.PasswordChar = '\0';
                    txtConClaveUs.PasswordChar = '\0';
                    break;
                case false:
                    txtClaveUs.PasswordChar = '*';
                    txtConClaveUs.PasswordChar = '*';
                    break;
            }
        }
    }
    
}
