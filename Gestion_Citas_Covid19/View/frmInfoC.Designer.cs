
namespace Gestion_Citas_Covid19.View
{
    partial class frmInfoC
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
            this.dgvCabin = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCabin
            // 
            this.dgvCabin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCabin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCabin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabin.Location = new System.Drawing.Point(8, 58);
            this.dgvCabin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCabin.MultiSelect = false;
            this.dgvCabin.Name = "dgvCabin";
            this.dgvCabin.ReadOnly = true;
            this.dgvCabin.RowHeadersWidth = 51;
            this.dgvCabin.RowTemplate.Height = 29;
            this.dgvCabin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCabin.Size = new System.Drawing.Size(1055, 616);
            this.dgvCabin.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "> Información de cabina";
            // 
            // frmInfoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1072, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCabin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmInfoC";
            this.Text = "frmInfoC";
            this.Load += new System.EventHandler(this.frmInfoC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCabin;
        private System.Windows.Forms.Label label1;
    }
}