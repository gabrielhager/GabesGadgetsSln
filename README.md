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

## Link to Author
[Adam Freeman](https://www.apress.com/gp/book/9781484254394)

# Chapter 7 Screenshots
## Step 2
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_Step1_GabrielHagerSD9.JPG)

(22 March 2021) Initial View Created.

## Step 3
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_EFConnected_GabrielHagerSD9.JPG)

(27 March 2021) Seeded the database via Entity Framework, Pagination and Bootstrap styling not yet applied.

## Step 4
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_FinalStepBootstrap_GabrielHagerSD9.JPG)

(27 March 2021) Completion of the Chapter 7 portion of the lab. Pagination and Bootstrap styling applied.

# Chapter 8 Screenshots
