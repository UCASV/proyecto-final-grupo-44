
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabin)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCabin
            // 
            this.dgvCabin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCabin.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCabin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabin.Location = new System.Drawing.Point(7, 79);
            this.dgvCabin.MultiSelect = false;
            this.dgvCabin.Name = "dgvCabin";
            this.dgvCabin.ReadOnly = true;
            this.dgvCabin.RowHeadersWidth = 51;
            this.dgvCabin.RowTemplate.Height = 29;
            this.dgvCabin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCabin.Size = new System.Drawing.Size(844, 388);
            this.dgvCabin.TabIndex = 1;
            // 
            // frmInfoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(858, 546);
            this.Controls.Add(this.dgvCabin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoC";
            this.Text = "frmInfoC";
            this.Load += new System.EventHandler(this.frmInfoC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCabin;
    }
}