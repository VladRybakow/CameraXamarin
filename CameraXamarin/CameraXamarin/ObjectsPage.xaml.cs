﻿using CameraXamarin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CameraXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ObjectsPage : ContentPage
    {
        public ObjectsPage(ProjectPhoto im)
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            name.Text = im.Name;
            img.Source = im.Image;
        }
    }
}