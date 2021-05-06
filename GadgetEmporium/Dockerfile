FROM mcr.microsoft.com/dotnet/aspnet:5.0
FROM mcr.microsoft.com/dotnet/sdk:5.0

COPY /bin/Release/net5.0/publish/ GadgetEmporium

ENV ASPNETCORE_ENVIRONMENT Production

EXPOSE 5000
WORKDIR /GadgetEmporium
ENTRYPOINT ["dotnet", "GadgetEmporium.dll", "--urls=http://0.0.0.0:5000"]