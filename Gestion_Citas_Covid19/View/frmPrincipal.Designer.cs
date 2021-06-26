
using System;
using System.Windows.Forms;

namespace Gestion_Citas_Covid19
{
    partial class FrmPrincipal
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
            this.Sidebar = new System.Windows.Forms.Panel();
            this.btn_SignOff = new System.Windows.Forms.Button();
            this.btn_CabinInformation = new System.Windows.Forms.Button();
            this.btn_HideSidebar = new System.Windows.Forms.Button();
            this.btn_PersonnelInformation = new System.Windows.Forms.Button();
            this.btn_AddAppointment = new System.Windows.Forms.Button();
            this.btn_ShowAppointment = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel_WorkArea = new System.Windows.Forms.Panel();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.Sidebar.Controls.Add(this.btn_SignOff);
            this.Sidebar.Controls.Add(this.btn_CabinInformation);
            this.Sidebar.Controls.Add(this.btn_HideSidebar);
            this.Sidebar.Controls.Add(this.btn_PersonnelInformation);
            this.Sidebar.Controls.Add(this.btn_AddAppointment);
            this.Sidebar.Controls.Add(this.btn_ShowAppointment);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sidebar.ForeColor = System.Drawing.Color.White;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(205, 668);
            this.Sidebar.TabIndex = 0;
            // 
            // btn_SignOff
            // 
            this.btn_SignOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SignOff.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_SignOff.BackColor = System.Drawing.Color.White;
            this.btn_SignOff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_SignOff.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_SignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SignOff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_SignOff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_SignOff.Location = new System.Drawing.Point(14, 317);
            this.btn_SignOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_SignOff.Name = "btn_SignOff";
            this.btn_SignOff.Size = new System.Drawing.Size(167, 45);
            this.btn_SignOff.TabIndex = 5;
            this.btn_SignOff.Text = "Cerrar Sesion";
            this.btn_SignOff.UseVisualStyleBackColor = false;
            this.btn_SignOff.Click += new System.EventHandler(this.btn_SignOff_Click);
            // 
            // btn_CabinInformation
            // 
            this.btn_CabinInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CabinInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CabinInformation.BackColor = System.Drawing.Color.White;
            this.btn_CabinInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_CabinInformation.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CabinInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CabinInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_CabinInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CabinInformation.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_CabinInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_CabinInformation.Location = new System.Drawing.Point(14, 264);
            this.btn_CabinInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_CabinInformation.Name = "btn_CabinInformation";
            this.btn_CabinInformation.Size = new System.Drawing.Size(167, 45);
            this.btn_CabinInformation.TabIndex = 4;
            this.btn_CabinInformation.Text = "Informacion de Cabina";
            this.btn_CabinInformation.UseVisualStyleBackColor = false;
            // 
            // btn_HideSidebar
            // 
            this.btn_HideSidebar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_HideSidebar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_HideSidebar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HideSidebar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_HideSidebar.ForeColor = System.Drawing.Color.White;
            this.btn_HideSidebar.Location = new System.Drawing.Point(14, 43);
            this.btn_HideSidebar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_HideSidebar.Name = "btn_HideSidebar";
            this.btn_HideSidebar.Size = new System.Drawing.Size(29, 53);
            this.btn_HideSidebar.TabIndex = 0;
            this.btn_HideSidebar.Text = "=";
            this.btn_HideSidebar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_HideSidebar.UseVisualStyleBackColor = true;
            this.btn_HideSidebar.Click += new System.EventHandler(this.btn_HideSidebar_Click);
            // 
            // btn_PersonnelInformation
            // 
            this.btn_PersonnelInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PersonnelInformation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_PersonnelInformation.BackColor = System.Drawing.Color.White;
            this.btn_PersonnelInformation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_PersonnelInformation.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_PersonnelInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_PersonnelInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_PersonnelInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PersonnelInformation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_PersonnelInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_PersonnelInformation.Location = new System.Drawing.Point(14, 211);
            this.btn_PersonnelInformation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_PersonnelInformation.Name = "btn_PersonnelInformation";
            this.btn_PersonnelInformation.Size = new System.Drawing.Size(167, 45);
            this.btn_PersonnelInformation.TabIndex = 3;
            this.btn_PersonnelInformation.Text = "Informacion de Personal";
            this.btn_PersonnelInformation.UseVisualStyleBackColor = false;
            // 
            // btn_AddAppointment
            // 
            this.btn_AddAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_AddAppointment.BackColor = System.Drawing.Color.White;
            this.btn_AddAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_AddAppointment.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AddAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AddAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_AddAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddAppointment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AddAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_AddAppointment.Location = new System.Drawing.Point(14, 157);
            this.btn_AddAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_AddAppointment.Name = "btn_AddAppointment";
            this.btn_AddAppointment.Size = new System.Drawing.Size(167, 45);
            this.btn_AddAppointment.TabIndex = 2;
            this.btn_AddAppointment.Text = "Agentar Cita";
            this.btn_AddAppointment.UseVisualStyleBackColor = false;
            this.btn_AddAppointment.Click += new System.EventHandler(this.btn_AddAppointment_Click);
            // 
            // btn_ShowAppointment
            // 
            this.btn_ShowAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ShowAppointment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ShowAppointment.BackColor = System.Drawing.Color.White;
            this.btn_ShowAppointment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_ShowAppointment.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ShowAppointment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ShowAppointment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_ShowAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ShowAppointment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_ShowAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_ShowAppointment.Location = new System.Drawing.Point(14, 104);
            this.btn_ShowAppointment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ShowAppointment.Name = "btn_ShowAppointment";
            this.btn_ShowAppointment.Size = new System.Drawing.Size(167, 45);
            this.btn_ShowAppointment.TabIndex = 1;
            this.btn_ShowAppointment.Text = "Mostrar Citas";
            this.btn_ShowAppointment.UseVisualStyleBackColor = false;
            this.btn_ShowAppointment.Click += new System.EventHandler(this.btn_ShowAppointment_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Gestion_Citas_Covid19.Properties.Resources.Logo_Gobierno_SV_white;
            this.Logo.Location = new System.Drawing.Point(7, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(121, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // panel_Header
            // 
            this.panel_Header.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.panel_Header.Controls.Add(this.pictureBox1);
            this.panel_Header.Controls.Add(this.Logo);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(205, 0);
            this.panel_Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(874, 104);
            this.panel_Header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestion_Citas_Covid19.Properties.Resources.logo_covid_SD;
            this.pictureBox1.Location = new System.Drawing.Point(135, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.168831F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.83117F));
            this.tableLayoutPanel1.Controls.Add(this.panel_WorkArea, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 104);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.814059F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 98.18594F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(874, 564);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel_WorkArea
            // 
            this.panel_WorkArea.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_WorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_WorkArea.Location = new System.Drawing.Point(13, 14);
            this.panel_WorkArea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_WorkArea.Name = "panel_WorkArea";
            this.panel_WorkArea.Size = new System.Drawing.Size(858, 546);
            this.panel_WorkArea.TabIndex = 0;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel_Header);
            this.Controls.Add(this.Sidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Button btn_ShowAppointment;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button btn_SignOff;
        private System.Windows.Forms.Button btn_CabinInformation;
        private System.Windows.Forms.Button btn_PersonnelInformation;
        private System.Windows.Forms.Button btn_AddAppointment;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_WorkArea;
        private System.Windows.Forms.Button btn_HideSidebar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}