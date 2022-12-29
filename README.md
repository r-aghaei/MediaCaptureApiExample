# Using MediaCapture in Windows Forms

In this example, I've created a Windows Forms application which uses MediaCapture class to capture a photo using your laptop camera. you can extend the applictaion to capture video as well.

The example contains two projects, one for .NET 6 and one for .NET Framework 4.8.  

The basic trick to use MediaCapture api in a WinForms or a WPF application, is setting up the project to target the right windows versions:

- For .NET 6, you can set the Target OS in properties to 10.0.17763.0 or above (or set the TargetFramrwork in project file to net6.0-windows10.0.17763.0)
- For .NET 4.8, you can enable PackageReference for package manager, and install Microsoft.Windows.SDK.Contracts package. (10.0.17763.0 or above).

More information:

- [Basic photo, video, and audio capture with MediaCapture](https://learn.microsoft.com/en-us/windows/uwp/audio-video-camera/basic-photo-video-and-audio-capture-with-mediacapture?WT.mc_id=DT-MVP-5003235)
- [MediaCapture](https://learn.microsoft.com/en-us/uwp/api/windows.media.capture.mediacapture?view=winrt-22621&WT.mc_id=DT-MVP-5003235) class
- [Call Windows Runtime APIs in desktop apps](https://learn.microsoft.com/en-us/windows/apps/desktop/modernize/desktop-to-uwp-enhance?WT.mc_id=DT-MVP-5003235)