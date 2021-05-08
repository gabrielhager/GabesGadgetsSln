# GabesGadgetsSln
This is a build of the demo MVC App from Adam Freeman's ASP.NET Core 3 textbook. This is for demonstration purposes

## [Table of Contents](#table-of-contents)
1) [Build Script](#Build-Script)
2) [Chapter 7](#Ch7)
3) [Chapter 8](#Ch8)
4) [Chapter 9](#Ch9)
5) [Chapter 10](#Ch10)
6) [Chapter 11] (#Ch11)

# <a name="Build-Script"></a>
#### <div alignt="Left"> Build Script</div> [Return to Table of Contents](#table-of-contents)

    dotnet new globaljson --sdk-version 5.0.201 --output GabesGadgetsSln/GadgetEmporium
    dotnet new web --no-https --output GabesGadgetsSln/GadgetEmporium --framework net5.0
    dotnet new sln -o GabesGadgetsSln
    dotnet sln GabesGadgetsSln add GabesGadgetsSln/GadgetEmporium
    dotnet new xunit -o GabesGadgetsSln/GadgetEmporium.Tests --framework net5.0
    dotnet sln  GabesGadgetsSln add GabesGadgetsSln/GadgetEmporium.Tests
    dotnet add GabesGadgetsSln/GadgetEmporium.Tests reference GabesGadgetsSln/GadgetEmporium

## Link to Author
[Adam Freeman](https://www.apress.com/gp/book/9781484254394)

# <a name="Ch7"></a>
#### <div alignt="Left"> Chapter 7 Screenshots</div> [Return to Table of Contents](#table-of-contents)

## Step 2
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_Step1_GabrielHagerSD9.JPG)

(22 March 2021) Initial View Created.

## Step 3
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_EFConnected_GabrielHagerSD9.JPG)

(27 March 2021) Seeded the database via Entity Framework, Pagination and Bootstrap styling not yet applied.

## Step 4
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/Lab1B_FinalStepBootstrap_GabrielHagerSD9.JPG)

(27 March 2021) Completion of the Chapter 7 portion of the lab. Pagination and Bootstrap styling applied.

# <a name="Ch8"></a>
#### <div alignt="Left"> Chapter 8 Screenshots</div> [Return to Table of Contents](#table-of-contents)

## Step 2
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB2A_Category_GabrielHagerSD9.JPG)

(31 March 2021) Added category buttons to the navigation bar.

## Step 3
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB2A_AddCartButtons_GabrielHagerSD9.JPG)
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB2A_ShoppingCart_GabrielHagerSD9.JPG)

(1 April 2021) Photos desplaying the Add to Cart buttons and the populated Shopping Cart.

## Step 4
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB2A_WorkingTests_GabrielHagerSD9.JPG)

(1 April 2021) Image displaying all 15 Unit Tests passing.

# <a name="Ch9"></a>
#### <div alignt="Left"> Chapter 9 Screenshots</div> [Return to Table of Contents](#table-of-contents)

## Step 2
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB3A_UpdatedCartRemoveBTN_GabrielHagerSD9.JPG)

(5 April 2021) Added the "Remove", and "Checkout" buttons to the Cart page.

## Step 3
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB3A_CartWidget_GabrielHagerSD9.JPG)

(5 April 2021) Added the cart widget to the top right corner.

## Step 4
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB3A_Checkout_GabrielHagerSD9.JPG)

(5 April 2021) Created the Checkout page that includes validation when fields are left blank.

## Step 5
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB3A_Confirmation_GabrielHagerSD9.JPG)

(5 April 2021) Created a confirmation page displaying that your order was successfully recieved.

## Step 6
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB3A_PassingTests_GabrielHagerSD9.JPG)

(5 April 2021) Display all 18 Unit tests passing.


# <a name="Ch10"></a>
#### <div alignt="Left"> Chapter 10 Screenshots</div> [Return to Table of Contents](#table-of-contents)

## Step 2
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Blazor_GabrielHagerSD9.JPG)
(15 April 2021) Created the ADMIN page to manage products and orders.

## Step 3
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Products_GabrielHagerSD9.JPG)
(15 April 2021) Implemented the product view into the Admin page.

## Step 4
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Shipped_GabrielHagerSD9.JPG)
(15 April 2021) Enabled shipping of orders.

## Step 5
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Details_GabrielHagerSD9.JPG)
(15 April 2021) Product details.

## Step 6
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Create_GabrielHagerSD9.JPG)
(15 April 2021) Create a new product.

## Step 7
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Edit_GabrielHagerSD9.JPG)
(15 April 2021) Edit a product.

## Step 8
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB4A_Delete_GabrielHageSD9.JPG)
(15 April 2021) Enabled button to delete products from the list.

# <a name="Ch11"></a>
#### <div alignt="Left"> Chapter 11 Screenshots</div> [Return to Table of Contents](#table-of-contents)

## Step 1
![](https://github.com/gabrielhager/GabesGadgetsSln/blob/master/images/LAB7A_GabrielHagerSD9.JPG)
(7 May 2021) Integrated Microsoft Identity to Admin Page

## Step 2
(7 May 2021) SD9 Class was unable to deploy to Docker due to updates to Azure since writting of the instruction book.

