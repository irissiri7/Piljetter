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
            int artistId = Convert.ToInt32(Math.Round(artistIdUpDown.Value, 0));
            int sceneId = Convert.ToInt32(Math.Round(sceneIdUpDown.Value, 0));
            DateTime concertDate = concertDateSelect.Value;
            bool success = false;

            if(artistId == 0 || sceneId == 0)
            {
                MessageBox.Show("Can' leave any fields empty");
            }
            else
            {
                success = AdminEngine.AddConcert(concertDate, sceneId, artistId);
                if (success)
                {
                    MessageBox.Show("Concert added");
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                }
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
