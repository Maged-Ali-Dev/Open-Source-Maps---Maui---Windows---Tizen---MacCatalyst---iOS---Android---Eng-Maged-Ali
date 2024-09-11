# Open Source Maps - Maui - Eng Maged Ali

OpenStreetMap Integration in .NET MAUI (.NET 8)

This project demonstrates how to integrate OpenStreetMap, using Leaflet.js, into a .NET MAUI (.NET 8) application. By embedding an interactive map inside a WebView, we take advantage of Leaflet.js's powerful mapping features while leveraging the cross-platform capabilities of .NET MAUI for building mobile and desktop applications.

Features

- Cross-Platform: The map can be displayed on iOS, Android, Windows, and macOS using .NET MAUI.
- Leaflet.js Integration: Uses Leaflet.js for rendering the map, a popular open-source JavaScript library for interactive maps.
- OpenStreetMap: Loads map tiles from OpenStreetMap, providing high-quality, open-source map data.

Project Structure

- WebView Control: The `WebView` component of .NET MAUI is used to embed and display the map.
- HTML Content: The HTML and JavaScript for Leaflet.js are embedded directly into the project and loaded into the `WebView`.
- Interactive Map: The map is centered on New York City with zoom and pan functionality provided by Leaflet.js.

How It Works

#1. HTML and JavaScript for Leaflet.js

The project includes a block of HTML with the following key parts:
- Leaflet.js: Leaflet's CSS and JavaScript are included via CDN links.
- Map Container: A `<div>` element is used to define the map container with a specific height and width.
- JavaScript Initialization: Leaflet.js is initialized by setting the map's center and zoom level. Map tiles are loaded from OpenStreetMap, and attribution is added for copyright compliance.

#2. .NET MAUI WebView Integration

The .NET MAUI application uses a `WebView` control to display the HTML content:
- HTMLWebViewSource: This class is used to load the HTML directly into the `WebView`.
- Cross-Platform Compatibility: The same code works on iOS, Android, Windows, and macOS, enabling a single codebase for different platforms.

#3. Rendering the Map

The map is rendered using Leaflet.js inside the `WebView`. By using JavaScript to initialize the map, the project maintains a responsive, interactive map that can be zoomed and panned by the user.

Code Implementation

#XAML (MainPage.xaml)

```xml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="MyMauiApp.MainPage">
    <WebView x:Name="webView"
             VerticalOptions="FillAndExpand"
             HorizontalOptions="FillAndExpand" />
</ContentPage>
```

#C# (MainPage.xaml.cs)

```csharp
public partial class MainPage : ContentPage
{
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
```

#How to Run

1. Clone the repository and open it in Visual Studio 2022 or later.
2. Ensure that you have .NET MAUI set up and installed properly on your machine.
3. Build and run the project on a target platform (iOS, Android, Windows, or macOS).
4. The app will display a WebView containing an interactive map centered on New York City, rendered using OpenStreetMap tiles.

#Dependencies

- .NET MAUI: A cross-platform framework for building native apps using C# and .NET.
- Leaflet.js: A lightweight JavaScript library for interactive maps.
- OpenStreetMap: An open-source map provider.

License

This project is licensed under the MIT License. You are free to use, modify, and distribute the code as long as you comply with the terms of the license.

