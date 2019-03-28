### Welcome to MyGalileo app for MacOS

MyGalileo is a simple Xamarin.Mac Cocoa app that uses the current Geolocation of the user to fetch and display key information using Azure Maps API.

# Ingredients

This app includes:

- C# Xamarin for MacOS: <a href="https://docs.microsoft.com/en-us/xamarin/mac/">Xamarin.Mac</a>
- Cocoa app development (using Visual Studio and Xcode).
- using Azure Maps API: <a href="http://azure.microsoft.com">Azure-Maps</a>
- using RestSharp (Simple REST and HTTP API Client for .NET): <a href="http://restsharp.org">RestSharp</a>
- using Newtonsoft.Json to dynamicallyx deserialize Json into object: <a href="https://www.newtonsoft.com/json">Newtonsoft.Json</a>
- using Xam.Plugin.Geolocator plugin: <a href="https://www.nuget.org/packages/Xam.Plugin.Geolocator/">Xam.Plugin.Geolocator</a>

# User Interface

<img src="https://github.com/AndreaDaVinci/MyGalileo/raw/master/MyGalileoMac/Resources/sample.gif" alt="hi" class="center"/>

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
