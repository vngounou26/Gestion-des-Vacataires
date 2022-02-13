﻿using Gestion_des_Vacataires.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_des_Vacataires.Controle_Utlisateur
{
    public partial class UCDashbord : UserControl
    {
        HttpClient httpClient = new HttpClient();
        InfoEmploiDeTemps emploiDeTemps = new InfoEmploiDeTemps(); 
        public UCDashbord()
        {
            InitializeComponent();
        }

        private void UCDashbord_Load(object sender, EventArgs e)
        {
            emploiDeTemps.ShowEmploiDeTemps(dgvList);
        }
    }
}
