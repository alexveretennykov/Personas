﻿using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para DialogoNacionalidad.xaml
    /// </summary>
    public partial class DialogoNacionalidad : Window
    {
        public RelayCommand Cerrar { get; }

        public DialogoNacionalidad()
        {
            InitializeComponent();
            Cerrar = new RelayCommand(CerrarDialogo);
            this.DataContext = this;
        }

        private void CerrarDialogo()
        {
            this.Close();
        }
    }
}
