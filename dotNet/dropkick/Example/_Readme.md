# DropkicK Hands on Lab
  
DropkicK is part of the ChuckNorris Framework, a suite of tools that are really meant to help developers be more productive by automating development tasks. Each of the tools can be used independently, but as you will see from the lab, the pieces fit really well together when the applications work together.  
  
1. Create two shares (web & service) on your local machine.  
1. Give read/write permissions to the share for everyone so the share permissions are handled by the ACLs.  
1. Run build.bat - it should run successfully.  
1. Open the solution, add a new class library project called Deployment.   
1. In the Deployment project, use nuget to install [dropkick.settings.templates](http://nuget.org/packages/dropkick.settings.templates).   
1. Update the \_REPLACE\_ text in TheDeployment.cs. The name of the website folder is _PublishedWebsites\WebApp.  
1. Right click on the .template files and under the properties for Visual Studio set  \[Copy to Output Directory\] to **Copy always**. 
1.  Run build.bat.  
1. Go to the code_drop\deployment folder. Run the LOCAL.All.Deploy.bat file.  
1. Watch the output. If everything works, you won't have any red text. Otherwise you will need to work with it.  
1. There is another branch named dropkick_completed that has the completed code from the presentation you can build and run if you get stuck.  
1. Also have a look at the [wiki](https://github.com/chucknorris/dropkick/wiki) to start seeing what you can do.
1. Feel free to look around, there are a few technologies used in the example.
  * [DropkicK](https://github.com/chucknorris/dropkick/wiki) - tool of the hour, fluent deployment tool  
  * [UppercuT](https://github.com/chucknorris/uppercut) - conventional build tool  
  * [RoundhousE](https://github.com/chucknorris/roundhouse/wiki) - database migrations tool  
  * RoundhousE.RefreshDatabase.EF - early preview of the tool that takes your Entity Framework Code Migrations and preps them as .sql files for use by the roundhouse migrations engine.  
  * Entity Framework w/Migrations - code migrations  
  * Entity Framework Code First Entity setup - take a look at a good way of setting up your domain entities  
  * [NuGet](http://nuget.org) - .NET library package manager  
  * NuGet Package Restore - checking in packages not necessary, everything is downloaded when you build the project, even in Visual Studio.  
  * Ninject - shows container registration with multiple registration points
  * WebActivator - shows how to register a module (ninject as a http module)
  * log4net 
