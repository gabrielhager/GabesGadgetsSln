# GabesGadgetsSln
This is a build of the demo MVC App from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purposes

## Build Script
    dotnet new globaljson --sdk-version 5.0.201 --output GabesGadgetsSln/GadgetEmporium
    dotnet new web --no-https --output GabesGadgetsSln/GadgetEmporium --framework net5.0
    dotnet new sln -o GabesGadgetsSln
    dotnet sln GabesGadgetsSln add GabesGadgetsSln/GadgetEmporium
    dotnet new xunit -o GabesGadgetsSln/GadgetEmporium.Tests --framework net5.0
    dotnet sln  GabesGadgetsSln add GabesGadgetsSln/GadgetEmporium.Tests
    dotnet add GabesGadgetsSln/GadgetEmporium.Tests reference GabesGadgetsSln/GadgetEmporium
