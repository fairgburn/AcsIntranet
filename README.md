# **ACS Intranet**

**12/18/2017 update**
* Created site layout
* Nothing really functional yet, just an update to the old look
* Scales well on phones
* Hosting the development server on my laptop in ACS office
    * http://bfairburn3:6699

----------------------

## Building and Deploying the Project
**Requires [.NET Core 2.0 or newer](https://docs.microsoft.com/en-us/dotnet/core/)**  
*lines starting with* '**$**' *indicate a command to be run in the terminal*  
*lines starting with* '**\#**' *are comments and should not be run*

Clone repo  

>$ `git clone https://acscode.visualstudio.com/_git/ACS%20Intranet`

or use the site navigation to download code as a .zip. Open solution in Visual Studio 2017 and build/run in debug mode to test. Details on deploying to IIS can be found [here](https://docs.microsoft.com/en-us/aspnet/core/publishing/iis?tabs=aspnetcore2x).

Build output is a cross-platform website, server included, that can run on Windows, Linux (even Raspberry Pi) or Mac.  
Example deployment and run (no IIS):  
Open a command prompt in the project root (directory containing `Intranet.csproj`) and run the following commands

>$ `dotnet publish -c Release -o ./pub`  
>$ `cd pub`  
>$ `dotnet Intranet.dll`

You can deploy to IIS by publishing to the website directory defined in IIS Manager, say `C:\inetpub\Intranet` for example:
>$ `dotnet publish -c Release -o "C:\inetpub\Intranet"`  
>*# note:  quotes are important due to Windows using backslash as a path delimiter*

**If the target (server machine) cannot have the .NET Core runtime installed for any reason:**  
The project can be easily built with the runtime bundled such that an executable (`Intranet.exe` on Windows) can be run on ANY machine with no external dependencies.  
This is achieved by adding `-r <target OS>` to the publish command.  
For example, on Windows 10/Server 2016 on a 64-bit x86 CPU:

>$ `dotnet publish -c Release -o "C:\inetpub\Intranet" -r win10-x64`  
>*# note: order of arguments (*`-c [BUILD_CONFIGURATION]`*,* `-o [OUTPUT_DIR]`*, etc) does not matter*

See [Microsoft docs on runtime identifiers](https://docs.microsoft.com/en-us/dotnet/core/rid-catalog) for a full list of options. Keep in mind this will add about 90 MB to the end product.

The site can be built and started in debug mode with a simple `dotnet run` in the project root.  
Visual Studio also provides tools to do all this graphically if you prefer that to command line tools, but there is a fair amount of configuration required for publishing.

----------------------

## Project Structure

* `wwwroot/`
  - resources for site (images, CSS, JavaScript, etc)

* `Pages/`
  - Razor pages 
    - See Microsoft documentation on [Razor Pages](https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/?tabs=visual-studio) and [MVVM pattern](https://msdn.microsoft.com/en-us/library/hh848246.aspx)
    - Files starting with an underscore are 'resources' like layouts or real-time [form validation](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/validation)
    - `.cshtml` files are the design for pages and include HTML and scripting in C# *(note: in-page scripting ONLY for logic directly responsible for rendering HTML)*
    - "Code-Behind" files (`*.cshtml.cs`) do the heavy-lifting logic for pages, such as database interaction or HTTP request handling

* `Program.cs` is the entry point (`Main` method) for starting the server, and defines which class to use for startup.
  - can define settings like login authentication and URLs/ports to listen on, but when using IIS as a proxy server this is handled externally

* `Startup.cs` contains startup settings and is called automatically by the runtime. 
----------------------

## Screenshots
**Desktop**
>![screenshot](Intranet/wwwroot/images/screenshots/desktop.png)

**Mobile**
>[![screenshot](Intranet/wwwroot/images/screenshots/phone.png)](Intranet/wwwroot/images/screenshots/phone-animated.gif)  
click mobile screenshot for GIF demo
