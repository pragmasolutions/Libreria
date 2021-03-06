﻿using System.Windows.Forms;

namespace LaPaz.Win.Forms.Editorial
{
    partial class FrmCrearEditarEditorial
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.EpvCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMail = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel13 = new Telerik.WinControls.UI.RadLabel();
            this.txtTelefonoAlt = new Telerik.WinControls.UI.RadTextBox();
            this.txtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.txtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtContacto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoAlt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContacto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(426, 278);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 8;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(313, 278);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 7;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // EpvCliente
            // 
            this.EpvCliente.ContainerControl = this;
            // 
            // txtMail
            // 
            this.txtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(161, 223);
            this.txtMail.MaxLength = 50;
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(338, 26);
            this.txtMail.TabIndex = 6;
            this.txtMail.TabStop = false;
            this.txtMail.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel13
            // 
            this.metroLabel13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel13.Location = new System.Drawing.Point(24, 228);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(47, 24);
            this.metroLabel13.TabIndex = 92;
            this.metroLabel13.Text = "Email:";
            this.metroLabel13.ThemeName = "TelerikMetroBlue";
            // 
            // txtTelefonoAlt
            // 
            this.txtTelefonoAlt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefonoAlt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoAlt.Location = new System.Drawing.Point(161, 182);
            this.txtTelefonoAlt.MaxLength = 20;
            this.txtTelefonoAlt.Name = "txtTelefonoAlt";
            this.txtTelefonoAlt.Size = new System.Drawing.Size(277, 26);
            this.txtTelefonoAlt.TabIndex = 5;
            this.txtTelefonoAlt.TabStop = false;
            this.txtTelefonoAlt.ThemeName = "TelerikMetroBlue";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(161, 141);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 26);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.ThemeName = "TelerikMetroBlue";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(161, 57);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(338, 26);
            this.txtDomicilio.TabIndex = 2;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(24, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 24);
            this.metroLabel6.TabIndex = 84;
            this.metroLabel6.Text = "Tel. alternativo:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(24, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(71, 24);
            this.metroLabel5.TabIndex = 83;
            this.metroLabel5.Text = "Teléfono:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(24, 59);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(75, 24);
            this.metroLabel4.TabIndex = 82;
            this.metroLabel4.Text = "Domicilio:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(161, 17);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(338, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TabStop = false;
            this.txtNombre.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(24, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 24);
            this.metroLabel1.TabIndex = 80;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtContacto
            // 
            this.TxtContacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtContacto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtContacto.Location = new System.Drawing.Point(161, 101);
            this.TxtContacto.MaxLength = 50;
            this.TxtContacto.Name = "TxtContacto";
            this.TxtContacto.Size = new System.Drawing.Size(277, 26);
            this.TxtContacto.TabIndex = 3;
            this.TxtContacto.TabStop = false;
            this.TxtContacto.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(24, 103);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(73, 24);
            this.radLabel1.TabIndex = 94;
            this.radLabel1.Text = "Contacto:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // FrmCrearEditarEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 316);
            this.Controls.Add(this.TxtContacto);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.txtTelefonoAlt);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.MaximizeBox = false;
            this.Name = "FrmCrearEditarEditorial";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Editorial";
            this.Load += new System.EventHandler(this.FrmCrearEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefonoAlt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtContacto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private ErrorProvider EpvCliente;
        private Telerik.WinControls.UI.RadTextBox txtMail;
        private Telerik.WinControls.UI.RadLabel metroLabel13;
        private Telerik.WinControls.UI.RadTextBox txtTelefonoAlt;
        private Telerik.WinControls.UI.RadTextBox txtTelefono;
        private Telerik.WinControls.UI.RadTextBox txtDomicilio;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadTextBox txtNombre;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtContacto;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}