using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Open_Source_Maps___Maui___Eng_Maged_Ali
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
