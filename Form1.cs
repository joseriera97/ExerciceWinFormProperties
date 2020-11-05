using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProperties
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            //Introducir los items para la seleccion de tipo de Borde.
            StyleBorder();
            //Deshabilitar el Focus cuando se da al Tab.
            targetButton.TabStop = false;

            //Para realizar el orden de Tab
            //Esta parte se puede hacer directamente en la propiedad de los botones en el apartado TabIndex.
            borderStyleComboBox.TabIndex = 0;
            visibleButton.TabIndex = 1;
            enabledButton.TabIndex = 2;
            centerButton.TabIndex = 3;
            upButton.TabIndex = 4;
            leftButton.TabIndex = 5;
            rightButton.TabIndex = 6;
            downButton.TabIndex = 7;
        }

        private void visibleButton_Click(object sender, EventArgs e)
        {
            //Para saber el estado leo el texto dependiendo del valor obtenido se realizara una acción.
            if (visibleButton.Text == "Visible = True")
            {//El boton se puede ver, realizaremos las acciones para ocultar-lo.
                visibleButton.Text = "Visible = False";
                targetButton.Visible = false;
            }
            else
            {//Caso contrario
                visibleButton.Text = "Visible = True";
                targetButton.Visible = true;
            }

        }

        private void enabledButton_Click(object sender, EventArgs e)
        {
            //Para saber el estado leo el texto dependiendo del valor obtenido se realizara una acción.
            if (enabledButton.Text == "Enabled = True")
            {//El boton se puede ver, realizaremos las acciones para ocultar-lo.
                enabledButton.Text = "Enabled = False";
                targetButton.Enabled = false;
            }
            else
            {//Caso contrario
                enabledButton.Text = "Enabled = True";
                targetButton.Enabled = true;
            }
        }

        private void centerButton_Click(object sender, EventArgs e)
        {
            targetButton.Anchor = AnchorStyles.None;

            //En el ancho influyen el propio boton y el controlGroup
        targetButton.Location =
                new Point((ActiveForm.Width - controlsGroupBox.Width - targetButton.Width) / 2,
                 (ActiveForm.Height - targetButton.Height) / 2 - 20);
            /*
            targetButton.Left = (ActiveForm.Width - controlsGroupBox.Width - targetButton.Width) / 2;

            targetButton.Top = (ActiveForm.Height - targetButton.Height) / 2;*/
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
             
        }

        //Introduccion de los tipos de bordes
        private void StyleBorder()
        {
            borderStyleComboBox.Items.Add(FormBorderStyle.None);
            borderStyleComboBox.Items.Add(FormBorderStyle.FixedDialog);
            borderStyleComboBox.Items.Add(FormBorderStyle.FixedToolWindow);
            borderStyleComboBox.Items.Add(FormBorderStyle.SizableToolWindow);
            borderStyleComboBox.Items.Add(FormBorderStyle.Fixed3D);
            borderStyleComboBox.Items.Add(FormBorderStyle.FixedSingle);
            borderStyleComboBox.Items.Add(FormBorderStyle.Sizable);
        }

        //Una vez se cambia el item seleccionado se cambia el borde
        private void borderStyleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = borderStyleComboBox.SelectedItem.ToString();
            //formSizeLabel.Text = e.ToString();
            //Comparamos cual ha sido el seleccionado y cambiamos el borde.
            switch (tipo)
            {
                case "None":
                    ActiveForm.FormBorderStyle = FormBorderStyle.None;
                    break;
                case "FixedDialog":
                    ActiveForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    break;
                case "FixedToolWindow":
                    ActiveForm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                    break;
                case "SizableToolWindow":
                    ActiveForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
                    break;
                case "Fixed3D":
                    ActiveForm.FormBorderStyle = FormBorderStyle.Fixed3D;
                    break;
                case "FixedSingle":
                    ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                    break;
                case "Sizable":
                    ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
                    break;
                default:
                    break;
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///    Botones para realizar el movimiento del target.
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
       
        private void upButton_Click(object sender, EventArgs e)
        {
            //  targetButton.Location.Y  = targetButton.Location.Y + 10;
            int posicionAltura = targetButton.Location.Y;

            //Realizo la comprobación antes de mover para no sobrepasar la parte de arriba del Form.
            if (posicionAltura != 0 && posicionAltura > 0)
            {
                 posicionAltura -= 10;//Si no esta en el inicio puede subir.
            }
            //Cambiamos unicamente la posicion para subir.
            targetButton.Top = posicionAltura;

        }

        private void rightButton_Click(object sender, EventArgs e)
        {       
            int posicionAncho = targetButton.Location.X;
            //Se comprueba que no se pueda superar el form derecho ni el GroupBox de Controles.
            int anchoAlcanzable = ActiveForm.Width - controlsGroupBox.Width - 130;
            if (posicionAncho != anchoAlcanzable && posicionAncho < anchoAlcanzable) {
                posicionAncho += 10;
            }
            //Movemos a la derecha.
            targetButton.Left = posicionAncho;

        }

        private void downButton_Click(object sender, EventArgs e)
        {            
            int posicionAltura = targetButton.Location.Y;

            //Realizo la comprobación antes de mover para no sobrepasar la parte de abajo del Form.
            int alturaAlcanzable = ActiveForm.Height - 180;

            if (posicionAltura != alturaAlcanzable && posicionAltura < alturaAlcanzable)
            {
                posicionAltura += 10;//Si no esta en el final.
            }
            //Cambiamos unicamente la posicion para bajar.
            targetButton.Top = posicionAltura;

        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            int posicionAncho = targetButton.Location.X;

            if (posicionAncho  != 0 && posicionAncho > 0)
            {
                posicionAncho -= 10;
            }
            //Movemos a la derecha.
            targetButton.Left = posicionAncho;
        }

        //Se realizara cada vez que se modifique la posicion del TargetButton
        private void posicionTargetButton(object sender, EventArgs e)
        {
            int posicionAltura = targetButton.Location.Y;

            int posicionAncho = targetButton.Location.X;
            targetButton.Text = "Target \n\r" + "X = " + posicionAncho + " \n\rY = " + posicionAltura;

        }

        //Se realizara cada vez que se realize un redimenzion del tamaño de la ventana del Form.
        private void mainForm_SizeChanged(object sender, EventArgs e)
        {
            formSizeLabel.Text = "Form Size : "+ActiveForm.Width+","+ ActiveForm.Height;
        }

        private void formMovido(object sender, EventArgs e)
        {
            //ActiveForm/mainForm = this    intanciamos el formulario de esta forma.
            this.Text = "(" + this.Location.X + ", " + this.Location.Y + ") Winforms Components - Common Controls";
        }
    }
}
