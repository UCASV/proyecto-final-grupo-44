namespace Gestion_Citas_Covid19.View
{
    partial class FrmVaccinationProcess
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_WaitingRoom = new System.Windows.Forms.DateTimePicker();
            this.DT_WaitingRoom = new System.Windows.Forms.Label();
            this.lbl_DateTime_WaitingRoom = new System.Windows.Forms.Label();
            this.DTP_Vaccination = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateTime_Vaccination = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel_SideEffects = new System.Windows.Forms.Panel();
            this.btn_Yes = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_No = new System.Windows.Forms.Button();
            this.panel_Ef = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_Ef.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(233, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proceso de Vacunacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(59, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sala de Espera";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(287, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vacunacion";
            // 
            // DTP_WaitingRoom
            // 
            this.DTP_WaitingRoom.CalendarForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_WaitingRoom.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_WaitingRoom.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_WaitingRoom.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_WaitingRoom.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.DTP_WaitingRoom.CustomFormat = "dd/mm/yyyy";
            this.DTP_WaitingRoom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_WaitingRoom.Location = new System.Drawing.Point(59, 80);
            this.DTP_WaitingRoom.Name = "DTP_WaitingRoom";
            this.DTP_WaitingRoom.Size = new System.Drawing.Size(168, 23);
            this.DTP_WaitingRoom.TabIndex = 3;
            this.DTP_WaitingRoom.ValueChanged += new System.EventHandler(this.DTP_WaitingRoom_ValueChanged);
            // 
            // DT_WaitingRoom
            // 
            this.DT_WaitingRoom.AutoSize = true;
            this.DT_WaitingRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DT_WaitingRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.DT_WaitingRoom.Location = new System.Drawing.Point(59, 106);
            this.DT_WaitingRoom.Name = "DT_WaitingRoom";
            this.DT_WaitingRoom.Size = new System.Drawing.Size(0, 15);
            this.DT_WaitingRoom.TabIndex = 4;
            // 
            // lbl_DateTime_WaitingRoom
            // 
            this.lbl_DateTime_WaitingRoom.AutoSize = true;
            this.lbl_DateTime_WaitingRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateTime_WaitingRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.lbl_DateTime_WaitingRoom.Location = new System.Drawing.Point(59, 106);
            this.lbl_DateTime_WaitingRoom.Name = "lbl_DateTime_WaitingRoom";
            this.lbl_DateTime_WaitingRoom.Size = new System.Drawing.Size(10, 15);
            this.lbl_DateTime_WaitingRoom.TabIndex = 5;
            this.lbl_DateTime_WaitingRoom.Text = ":";
            // 
            // DTP_Vaccination
            // 
            this.DTP_Vaccination.CalendarForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_Vaccination.CalendarMonthBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_Vaccination.CalendarTitleBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DTP_Vaccination.CalendarTitleForeColor = System.Drawing.Color.White;
            this.DTP_Vaccination.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.DTP_Vaccination.CustomFormat = "dd/mm/yyyy";
            this.DTP_Vaccination.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Vaccination.Location = new System.Drawing.Point(287, 80);
            this.DTP_Vaccination.Name = "DTP_Vaccination";
            this.DTP_Vaccination.Size = new System.Drawing.Size(168, 23);
            this.DTP_Vaccination.TabIndex = 6;
            this.DTP_Vaccination.ValueChanged += new System.EventHandler(this.DTP_Vaccination_ValueChanged);
            // 
            // lbl_DateTime_Vaccination
            // 
            this.lbl_DateTime_Vaccination.AutoSize = true;
            this.lbl_DateTime_Vaccination.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_DateTime_Vaccination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.lbl_DateTime_Vaccination.Location = new System.Drawing.Point(287, 106);
            this.lbl_DateTime_Vaccination.Name = "lbl_DateTime_Vaccination";
            this.lbl_DateTime_Vaccination.Size = new System.Drawing.Size(10, 15);
            this.lbl_DateTime_Vaccination.TabIndex = 7;
            this.lbl_DateTime_Vaccination.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(508, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha: Segunda Dosis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(508, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Aqui va la segunda fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label7.Location = new System.Drawing.Point(3, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Efectos Secundarios";
            // 
            // panel_SideEffects
            // 
            this.panel_SideEffects.Location = new System.Drawing.Point(508, 212);
            this.panel_SideEffects.Name = "panel_SideEffects";
            this.panel_SideEffects.Size = new System.Drawing.Size(537, 216);
            this.panel_SideEffects.TabIndex = 12;
            // 
            // btn_Yes
            // 
            this.btn_Yes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Yes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Yes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_Yes.Location = new System.Drawing.Point(7, 78);
            this.btn_Yes.Name = "btn_Yes";
            this.btn_Yes.Size = new System.Drawing.Size(76, 29);
            this.btn_Yes.TabIndex = 13;
            this.btn_Yes.Text = "Si";
            this.btn_Yes.UseVisualStyleBackColor = false;
            this.btn_Yes.Click += new System.EventHandler(this.btn_Yes_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label8.Location = new System.Drawing.Point(3, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Presenta Sintomas?";
            // 
            // btn_No
            // 
            this.btn_No.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_No.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.btn_No.Location = new System.Drawing.Point(89, 78);
            this.btn_No.Name = "btn_No";
            this.btn_No.Size = new System.Drawing.Size(76, 29);
            this.btn_No.TabIndex = 15;
            this.btn_No.Text = "No";
            this.btn_No.UseVisualStyleBackColor = false;
            this.btn_No.Click += new System.EventHandler(this.btn_No_Click);
            // 
            // panel_Ef
            // 
            this.panel_Ef.Controls.Add(this.button1);
            this.panel_Ef.Controls.Add(this.btn_No);
            this.panel_Ef.Controls.Add(this.label7);
            this.panel_Ef.Controls.Add(this.btn_Yes);
            this.panel_Ef.Controls.Add(this.label8);
            this.panel_Ef.Location = new System.Drawing.Point(287, 147);
            this.panel_Ef.Name = "panel_Ef";
            this.panel_Ef.Size = new System.Drawing.Size(168, 178);
            this.panel_Ef.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.button1.Location = new System.Drawing.Point(7, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 30);
            this.button1.TabIndex = 17;
            this.button1.Text = "Guardar Datos";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FrmVaccinationProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 371);
            this.Controls.Add(this.panel_Ef);
            this.Controls.Add(this.panel_SideEffects);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_DateTime_Vaccination);
            this.Controls.Add(this.DTP_Vaccination);
            this.Controls.Add(this.lbl_DateTime_WaitingRoom);
            this.Controls.Add(this.DT_WaitingRoom);
            this.Controls.Add(this.DTP_WaitingRoom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmVaccinationProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVaccinationProcess";
            this.panel_Ef.ResumeLayout(false);
            this.panel_Ef.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_WaitingRoom;
        private System.Windows.Forms.Label DT_WaitingRoom;
        private System.Windows.Forms.Label lbl_DateTime_WaitingRoom;
        private System.Windows.Forms.DateTimePicker DTP_Vaccination;
        private System.Windows.Forms.Label lbl_DateTime_Vaccination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel_SideEffects;
        private System.Windows.Forms.Button btn_Yes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_No;
        private System.Windows.Forms.Panel panel_Ef;
        private System.Windows.Forms.Button button1;
    }
}