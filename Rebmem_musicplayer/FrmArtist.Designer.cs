
namespace Rebmem_musicplayer
{
    partial class FrmArtist
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
            this.txt_artistname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_saveartist = new System.Windows.Forms.Button();
            this.dataGridViewartist = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewartist)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_artistname
            // 
            this.txt_artistname.Location = new System.Drawing.Point(227, 121);
            this.txt_artistname.Name = "txt_artistname";
            this.txt_artistname.Size = new System.Drawing.Size(394, 20);
            this.txt_artistname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Artist name";
            // 
            // btn_saveartist
            // 
            this.btn_saveartist.Location = new System.Drawing.Point(271, 163);
            this.btn_saveartist.Name = "btn_saveartist";
            this.btn_saveartist.Size = new System.Drawing.Size(75, 23);
            this.btn_saveartist.TabIndex = 2;
            this.btn_saveartist.Text = "Save";
            this.btn_saveartist.UseVisualStyleBackColor = true;
            this.btn_saveartist.Click += new System.EventHandler(this.btn_saveartist_Click);
            // 
            // dataGridViewartist
            // 
            this.dataGridViewartist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewartist.Location = new System.Drawing.Point(196, 207);
            this.dataGridViewartist.Name = "dataGridViewartist";
            this.dataGridViewartist.Size = new System.Drawing.Size(442, 221);
            this.dataGridViewartist.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(504, 163);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(237, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 37);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rebmem Music Player";
            // 
            // FrmArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridViewartist);
            this.Controls.Add(this.btn_saveartist);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_artistname);
            this.Name = "FrmArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArtist";
            this.Load += new System.EventHandler(this.FrmArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewartist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_artistname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_saveartist;
        private System.Windows.Forms.DataGridView dataGridViewartist;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
    }
}