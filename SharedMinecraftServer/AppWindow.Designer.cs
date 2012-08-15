using SharedMinecraftServer.Sources;
namespace SharedMinecraftServer
{
    partial class AppWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form elements

        private System.Windows.Forms.RichTextBox richTxt_console;
        private System.Windows.Forms.GroupBox groupbox_appStatus;
        private System.Windows.Forms.Label label_appStatus;
        private System.Windows.Forms.GroupBox groupbox_appOwner;
        private System.Windows.Forms.Label label_appOwner;
        private System.Windows.Forms.Button button_appStartStop;
        private System.Windows.Forms.Button button_commit;
        private System.Windows.Forms.Button button_revert;
        private System.Windows.Forms.GroupBox groupbox_appIpOwner;
        private System.Windows.Forms.Label label_appIpOwner;
        private System.Windows.Forms.GroupBox groupbox_changes;
        private System.Windows.Forms.TextBox txtbox_user;
        private System.Windows.Forms.GroupBox groupbox_conf;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox txtbox_port;
        private System.Windows.Forms.Label label_port;

        #endregion

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxt_console = new System.Windows.Forms.RichTextBox();
            this.groupbox_appStatus = new System.Windows.Forms.GroupBox();
            this.label_appStatus = new System.Windows.Forms.Label();
            this.groupbox_appOwner = new System.Windows.Forms.GroupBox();
            this.label_appOwner = new System.Windows.Forms.Label();
            this.button_appStartStop = new System.Windows.Forms.Button();
            this.button_commit = new System.Windows.Forms.Button();
            this.button_revert = new System.Windows.Forms.Button();
            this.groupbox_appIpOwner = new System.Windows.Forms.GroupBox();
            this.label_appIpOwner = new System.Windows.Forms.Label();
            this.groupbox_changes = new System.Windows.Forms.GroupBox();
            this.txtbox_user = new System.Windows.Forms.TextBox();
            this.groupbox_conf = new System.Windows.Forms.GroupBox();
            this.button_configLoad = new System.Windows.Forms.Button();
            this.button_configSave = new System.Windows.Forms.Button();
            this.txtbox_port = new System.Windows.Forms.TextBox();
            this.label_port = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.groupbox_StartStop = new System.Windows.Forms.GroupBox();
            this.groupbox_appStatus.SuspendLayout();
            this.groupbox_appOwner.SuspendLayout();
            this.groupbox_appIpOwner.SuspendLayout();
            this.groupbox_changes.SuspendLayout();
            this.groupbox_conf.SuspendLayout();
            this.groupbox_StartStop.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxt_console
            // 
            this.richTxt_console.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTxt_console.Location = new System.Drawing.Point(12, 222);
            this.richTxt_console.Name = "richTxt_console";
            this.richTxt_console.ReadOnly = true;
            this.richTxt_console.Size = new System.Drawing.Size(367, 238);
            this.richTxt_console.TabIndex = 0;
            this.richTxt_console.Text = "";
            // 
            // groupbox_appStatus
            // 
            this.groupbox_appStatus.Controls.Add(this.label_appStatus);
            this.groupbox_appStatus.Location = new System.Drawing.Point(247, 12);
            this.groupbox_appStatus.Name = "groupbox_appStatus";
            this.groupbox_appStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupbox_appStatus.Size = new System.Drawing.Size(132, 42);
            this.groupbox_appStatus.TabIndex = 1;
            this.groupbox_appStatus.TabStop = false;
            this.groupbox_appStatus.Text = "Estado de la Aplicación";
            // 
            // label_appStatus
            // 
            this.label_appStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appStatus.Location = new System.Drawing.Point(6, 16);
            this.label_appStatus.Name = "label_appStatus";
            this.label_appStatus.Size = new System.Drawing.Size(120, 23);
            this.label_appStatus.TabIndex = 0;
            this.label_appStatus.Text = "status";
            this.label_appStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox_appOwner
            // 
            this.groupbox_appOwner.Controls.Add(this.label_appOwner);
            this.groupbox_appOwner.Location = new System.Drawing.Point(247, 60);
            this.groupbox_appOwner.Name = "groupbox_appOwner";
            this.groupbox_appOwner.Size = new System.Drawing.Size(132, 42);
            this.groupbox_appOwner.TabIndex = 2;
            this.groupbox_appOwner.TabStop = false;
            this.groupbox_appOwner.Text = "Usuario Dueño del App";
            // 
            // label_appOwner
            // 
            this.label_appOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appOwner.Location = new System.Drawing.Point(6, 16);
            this.label_appOwner.Name = "label_appOwner";
            this.label_appOwner.Size = new System.Drawing.Size(120, 23);
            this.label_appOwner.TabIndex = 0;
            this.label_appOwner.Text = "owner";
            this.label_appOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_appStartStop
            // 
            this.button_appStartStop.Location = new System.Drawing.Point(6, 19);
            this.button_appStartStop.Name = "button_appStartStop";
            this.button_appStartStop.Size = new System.Drawing.Size(130, 34);
            this.button_appStartStop.TabIndex = 3;
            this.button_appStartStop.Text = "Levantar";
            this.button_appStartStop.UseVisualStyleBackColor = true;
            this.button_appStartStop.Click += new System.EventHandler(this.button_appStartStop_Click);
            // 
            // button_commit
            // 
            this.button_commit.Location = new System.Drawing.Point(6, 19);
            this.button_commit.Name = "button_commit";
            this.button_commit.Size = new System.Drawing.Size(100, 34);
            this.button_commit.TabIndex = 4;
            this.button_commit.Text = "Subir";
            this.button_commit.UseVisualStyleBackColor = true;
            this.button_commit.Click += new System.EventHandler(this.button_commit_Click);
            // 
            // button_revert
            // 
            this.button_revert.Location = new System.Drawing.Point(112, 19);
            this.button_revert.Name = "button_revert";
            this.button_revert.Size = new System.Drawing.Size(100, 34);
            this.button_revert.TabIndex = 5;
            this.button_revert.Text = "Revertir";
            this.button_revert.UseVisualStyleBackColor = true;
            this.button_revert.Click += new System.EventHandler(this.button_revert_Click);
            // 
            // groupbox_appIpOwner
            // 
            this.groupbox_appIpOwner.Controls.Add(this.label_appIpOwner);
            this.groupbox_appIpOwner.Location = new System.Drawing.Point(247, 108);
            this.groupbox_appIpOwner.Name = "groupbox_appIpOwner";
            this.groupbox_appIpOwner.Size = new System.Drawing.Size(132, 42);
            this.groupbox_appIpOwner.TabIndex = 6;
            this.groupbox_appIpOwner.TabStop = false;
            this.groupbox_appIpOwner.Text = "IP del Usuario Dueño";
            // 
            // label_appIpOwner
            // 
            this.label_appIpOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_appIpOwner.Location = new System.Drawing.Point(8, 16);
            this.label_appIpOwner.Name = "label_appIpOwner";
            this.label_appIpOwner.Size = new System.Drawing.Size(116, 23);
            this.label_appIpOwner.TabIndex = 0;
            this.label_appIpOwner.Text = "ip";
            this.label_appIpOwner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox_changes
            // 
            this.groupbox_changes.Controls.Add(this.button_commit);
            this.groupbox_changes.Controls.Add(this.button_revert);
            this.groupbox_changes.Location = new System.Drawing.Point(161, 156);
            this.groupbox_changes.Name = "groupbox_changes";
            this.groupbox_changes.Size = new System.Drawing.Size(218, 60);
            this.groupbox_changes.TabIndex = 7;
            this.groupbox_changes.TabStop = false;
            this.groupbox_changes.Text = "Cambios";
            // 
            // txtbox_user
            // 
            this.txtbox_user.Location = new System.Drawing.Point(55, 26);
            this.txtbox_user.Name = "txtbox_user";
            this.txtbox_user.Size = new System.Drawing.Size(152, 20);
            this.txtbox_user.TabIndex = 8;
            this.txtbox_user.TextChanged += new System.EventHandler(this.txtbox_User_Change);
            // 
            // groupbox_conf
            // 
            this.groupbox_conf.Controls.Add(this.button_configLoad);
            this.groupbox_conf.Controls.Add(this.button_configSave);
            this.groupbox_conf.Controls.Add(this.txtbox_port);
            this.groupbox_conf.Controls.Add(this.label_port);
            this.groupbox_conf.Controls.Add(this.label_user);
            this.groupbox_conf.Controls.Add(this.txtbox_user);
            this.groupbox_conf.Location = new System.Drawing.Point(12, 12);
            this.groupbox_conf.Name = "groupbox_conf";
            this.groupbox_conf.Size = new System.Drawing.Size(217, 126);
            this.groupbox_conf.TabIndex = 9;
            this.groupbox_conf.TabStop = false;
            this.groupbox_conf.Text = "Configuración";
            // 
            // button_configLoad
            // 
            this.button_configLoad.Location = new System.Drawing.Point(118, 96);
            this.button_configLoad.Name = "button_configLoad";
            this.button_configLoad.Size = new System.Drawing.Size(89, 23);
            this.button_configLoad.TabIndex = 13;
            this.button_configLoad.Text = "Cargar";
            this.button_configLoad.UseVisualStyleBackColor = true;
            this.button_configLoad.Click += new System.EventHandler(this.button_configLoad_Click);
            // 
            // button_configSave
            // 
            this.button_configSave.Location = new System.Drawing.Point(9, 96);
            this.button_configSave.Name = "button_configSave";
            this.button_configSave.Size = new System.Drawing.Size(89, 23);
            this.button_configSave.TabIndex = 12;
            this.button_configSave.Text = "Guardar";
            this.button_configSave.UseVisualStyleBackColor = true;
            this.button_configSave.Click += new System.EventHandler(this.button_configSave_Click);
            // 
            // txtbox_port
            // 
            this.txtbox_port.Location = new System.Drawing.Point(55, 61);
            this.txtbox_port.Name = "txtbox_port";
            this.txtbox_port.Size = new System.Drawing.Size(152, 20);
            this.txtbox_port.TabIndex = 11;
            this.txtbox_port.TextChanged += new System.EventHandler(this.txtbox_Port_Change);
            // 
            // label_port
            // 
            this.label_port.AutoSize = true;
            this.label_port.Location = new System.Drawing.Point(6, 64);
            this.label_port.Name = "label_port";
            this.label_port.Size = new System.Drawing.Size(38, 13);
            this.label_port.TabIndex = 10;
            this.label_port.Text = "Puerto";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(6, 29);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(43, 13);
            this.label_user.TabIndex = 9;
            this.label_user.Text = "Usuario";
            // 
            // groupbox_StartStop
            // 
            this.groupbox_StartStop.Controls.Add(this.button_appStartStop);
            this.groupbox_StartStop.Location = new System.Drawing.Point(13, 157);
            this.groupbox_StartStop.Name = "groupbox_StartStop";
            this.groupbox_StartStop.Size = new System.Drawing.Size(142, 59);
            this.groupbox_StartStop.TabIndex = 10;
            this.groupbox_StartStop.TabStop = false;
            this.groupbox_StartStop.Text = "Aplicación";
            // 
            // AppWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 472);
            this.Controls.Add(this.groupbox_StartStop);
            this.Controls.Add(this.groupbox_conf);
            this.Controls.Add(this.groupbox_changes);
            this.Controls.Add(this.groupbox_appIpOwner);
            this.Controls.Add(this.groupbox_appOwner);
            this.Controls.Add(this.groupbox_appStatus);
            this.Controls.Add(this.richTxt_console);
            this.MaximizeBox = false;
            this.Name = "AppWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Control de Aplicación Compartida";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AppWindow_Close);
            this.Load += new System.EventHandler(this.AppWindow_Load);
            this.groupbox_appStatus.ResumeLayout(false);
            this.groupbox_appOwner.ResumeLayout(false);
            this.groupbox_appIpOwner.ResumeLayout(false);
            this.groupbox_changes.ResumeLayout(false);
            this.groupbox_conf.ResumeLayout(false);
            this.groupbox_conf.PerformLayout();
            this.groupbox_StartStop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_configLoad;
        private System.Windows.Forms.Button button_configSave;
        private System.Windows.Forms.GroupBox groupbox_StartStop;
    }
}

