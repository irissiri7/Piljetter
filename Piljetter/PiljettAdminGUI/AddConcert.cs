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
            availableArtistsView.DataSource = availableArtistsList;
            availableScenesView.DataSource = availableScenesList;
        }
    }
}
