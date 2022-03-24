using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebmem_musicplayer
{
    public partial class Frmsearch : Form
    {
        public static int SongId { get; set; }
        
        public Frmsearch()
        {
            InitializeComponent();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                MessageBox.Show("Please enter song name");
            }
            else 
            {
                Song song = new Song();
                //will return all song that match with its fields
                dataGridViewSearch.DataSource = song.GetSongsByTitle(txt_search.Text);
                dataGridViewSearch.Columns["Id"].Visible = false;
                this.dataGridViewSearch.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewSearch_RowPostPaint);
                DataGridViewButtonColumn LoadButtonColumn = new DataGridViewButtonColumn();
                //Creating a new dynamic column
                LoadButtonColumn.Name = "Load";
                LoadButtonColumn.Text = "Play";
                LoadButtonColumn.UseColumnTextForButtonValue = true;
                int columnIndex = 2;
                if (dataGridViewSearch.Columns["Load"] == null)
                {
                    dataGridViewSearch.Columns.Insert(columnIndex, LoadButtonColumn);
                }
            }
        }
        
        private void dataGridViewSearch_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(((DataGridView)sender).RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }
        private void dataGridViewSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //when the cell is clicked, it will fetch the songId
            if (e.ColumnIndex == dataGridViewSearch.Columns["Load"].Index)
            {
                using (var context = new Rebmem_MusicPlayerdbcontext())
                {
                    if (dataGridViewSearch.Rows[e.RowIndex].Cells[0].Value is int)
                    {
                        SongId = Convert.ToInt32(dataGridViewSearch.Rows[e.RowIndex].Cells[0].Value);
                        this.Visible = false;
                        return;

                    }
                    else 
                    {
                        MessageBox.Show(dataGridViewSearch.Rows[e.RowIndex].Cells[0].Value.ToString());
                    }

                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void dataGridViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
