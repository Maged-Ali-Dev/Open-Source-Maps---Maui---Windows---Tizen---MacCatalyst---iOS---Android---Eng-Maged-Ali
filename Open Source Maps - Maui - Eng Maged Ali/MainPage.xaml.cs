namespace Open_Source_Maps___Maui___Eng_Maged_Ali
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            string html = @"<!DOCTYPE html>
          <html>
          <head>
            <title>OpenStreetMap</title>
            <link rel='stylesheet' href='https://unpkg.com/leaflet@1.7.1/dist/leaflet.css' />
            <script src='https://unpkg.com/leaflet@1.7.1/dist/leaflet.js'></script>
            <style>
              #map {
                height: 100%;
                width: 100%;
              }
              html, body {
                height: 100%;
                margin: 0;
                padding: 0;
              }
            </style>
          </head>
          <body>
            <div id='map'></div>
            <script>
              var map = L.map('map').setView([40.712776, -74.005974], 12); // New York City, USA
              L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
                attribution: '&copy; OpenStreetMap contributors'
              }).addTo(map);
            </script>
          </body>
          </html>";

            webView.Source = new HtmlWebViewSource
            {
                Html = html
            };

        }

        
    }

}
