using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Propiedades_Adjuntas.Resources;
using System.Windows.Shapes;

namespace Propiedades_Adjuntas
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // manejamos el evento tap de la elipse
        private void Ellipse_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            var ellipse = sender as Ellipse; // sender es el objeto que causo la acción

            // obtenemos el valor de las propiedades
            var LeftValue = (double)ellipse.GetValue(Canvas.LeftProperty);
            var TopValue = (double)ellipse.GetValue(Canvas.TopProperty);

            // establecemos las propiedades, por cada tap la elipse movera 10px a la derecha y 20 hacias abajo
            ellipse.SetValue(Canvas.LeftProperty, LeftValue + 10);
            ellipse.SetValue(Canvas.TopProperty, TopValue + 20);
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}