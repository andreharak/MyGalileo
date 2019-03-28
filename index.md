### Welcome to MyGalileo app for MacOS

MyGalileo is a simple Xamarin.Mac Cocoa app that uses the current Geolocation of the user to fetch and display key information using Azure Maps API.

# Ingredients

This app includes:

- C# Xamarin for MacOS (https://docs.microsoft.com/en-us/xamarin/mac/).
- Cocoa app development (using Visual Studio and Xcode).
- using Azure Maps API (http://azure.microsoft.com).
- using RestSharp (Simple REST and HTTP API Client for .NET) (http://restsharp.org).
- using Newtonsoft.Json to dynamicallyx deserialize Json into object (https://www.newtonsoft.com/json).
- using Xam.Plugin.Geolocator plugin (https://www.nuget.org/packages/Xam.Plugin.Geolocator/).

# User Interface

### Welcome window:

<img src="https://github.com/AndreaDaVinci/MyGalileo/raw/master/MyGalileoMac/Resources/MyGalileo1_empty_form.png" alt="hi" class="inline"/>

### Requesting permission to locate device:

<img src="https://github.com/AndreaDaVinci/MyGalileo/raw/master/MyGalileoMac/Resources/MyGalileo2_request_permission.png" alt="hi" class="inline"/>

### Results window:

<img src="https://github.com/AndreaDaVinci/MyGalileo/raw/master/MyGalileoMac/Resources/MyGalileo4_results.png" alt="hi" class="inline"/>

# Install on MacOS

You can download the [MacOS application](https://github.com/AndreaDaVinci/MyGalileo/raw/master/Download/My%20Galileo.app.zip) that you can unarchive and then copy to your applications folder.


# Notes

If you try the application and it does not work, please replace the variable AzureMapsKey with your own Azure Maps API key from Microsoft after subscribing to the free service.
