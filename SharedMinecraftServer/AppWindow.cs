using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using SharedMinecraftServer.Utils;
using SharedMinecraftServer.Sources;

namespace SharedMinecraftServer
{
    public partial class AppWindow : Form
    {
        //Variables globales (compartidas entre hilos)
        public static Logger logger = null;
        public static int frequency = 0;

        //Builder
        public AppWindow()
        {
            //Instanciación
            logger = new Logger();

            //Carga el archivo de logs
            if (!logger.LoadLogFile())
            {
                MessageBox.Show("Error al acceder al archivo logs. Deteniendo el servicio. Contactese con soporte de Xerox Argentina.", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }

            //Crea el formulario
            InitializeComponent();
        }

        #region Eventos

        //Valores de carga
        private void AppWindow_Load(object sender, EventArgs e)
        {
            //Carga del archivo de configuracion
            if (!Configuration.ReadConfigFile())
            {
                logger.LogError(Errno.msg);
                Environment.Exit(1);
            }
            this.txtbox_user.Text = Configuration.user;
            this.txtbox_port.Text = Configuration.port;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        //Cierra el logger
        private void AppWindow_Close(object sender, FormClosingEventArgs e)
        {
            //Cierra el archivo de logs
            if (!logger.UnloadLogFile())
            {
                MessageBox.Show("Error al cerrar el archivo logs. Es posible que queden eventos sin logear.", "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool started = false;
        private void button_appStartStop_Click(object sender, EventArgs e)
        {
            if (!started)
            {
                this.button_appStartStop.Text = "Detener";
                started = true;
            }
            else
            {
                this.button_appStartStop.Text = "Levantar";
                started = false;
            }
        }

        private void button_commit_Click(object sender, EventArgs e)
        {

        }

        private void button_revert_Click(object sender, EventArgs e)
        {

        }

        private void button_configSave_Click(object sender, EventArgs e)
        {
            //Guarda del archivo de configuracion
            if (!Configuration.SaveConfigFile())
            {
                logger.LogError(Errno.msg);
                Environment.Exit(1);
            }
        }

        private void button_configLoad_Click(object sender, EventArgs e)
        {
            //Carga del archivo de configuracion
            if (!Configuration.ReadConfigFile())
            {
                logger.LogError(Errno.msg);
                Environment.Exit(1);
            }
            this.txtbox_user.Text = Configuration.user;
            this.txtbox_port.Text = Configuration.port;
        }

        private void txtbox_User_Change(object sender, EventArgs e)
        {
            Configuration.user = txtbox_user.Text;
        }

        private void txtbox_Port_Change(object sender, EventArgs e)
        {
            Configuration.port = txtbox_port.Text;
        }

        #endregion

        #region Setters/Getters

        #endregion
    }
}
