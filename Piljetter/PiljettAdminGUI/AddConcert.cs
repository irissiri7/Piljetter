using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace PiljettAdminGUI
{
    public partial class AddConcert : Form
    {
        public AddConcert(List<AvailableArtistsView> availableArtistsList, List<AvailableScenesView> availableScenesList)
        {
            InitializeComponent();
            concertDateSelect.CustomFormat = "yyyy-mm-dd";
            availableArtistsView.DataSource = availableArtistsList;
            availableScenesView.DataSource = availableScenesList;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int artistId = Convert.ToInt32(availableArtistsView.CurrentRow.Cells[2].Value);
            int sceneId = Convert.ToInt32(availableScenesView.CurrentRow.Cells[2].Value);
            DateTime concertDate = concertDateSelect.Value;
            bool success = false;
            string message;

            success = AdminEngine.AddConcert(concertDate, sceneId, artistId, out message);
            if (success)
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show(message);
            }

        }

        private void backToMainPage_Click(object sender, EventArgs e)
        {
            AdminStartPage start = new AdminStartPage();
            this.Close();
            start.Show();
        }
    }
}
