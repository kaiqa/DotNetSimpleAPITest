
Create your main solution directory: SimpleAPI
Create 2 sub directories in here, named “src” and “test”
 “src” directory
-   dotnet new webapi -n SimpleAPI

“test” directory 
-   dotnet new xunit -n SimpleAPI.Tests


Solution Directory Listing

-   create a solution file SimpleAPI.sln,reasons)
-    dotnet new sln --name SimpleAPI

 Associate both our “child” projects to our solution

-   dotnet sln SimpleAPI.sln add src/SimpleAPI/SimpleAPI.csproj test/SimpleAPI.Tests/SimpleAPI.Tests.csproj
-   dotnet add test/SimpleAPI.Tests/SimpleAPI.Tests.csproj reference src/SimpleAPI/SimpleAPI.csproj

Verify the contents of the SimpleAPI.Tests .csproj file to ensure the reference is there, also notice the package references to xunit.
SimpleAPI.Tests .csproj file

-   dotnet build
-   dotnet run
-   dotnet test

Browse to:

https://localhost:5001/api/values
-   dotnet dev-certs https --trust

Run a os x build agent:

Set attributes to allow the setup script to run.
-   xattr -c vsts-agent-osx-x64-V.v.v.tar.gz  ## replace V.v.v with the version in the filename downloaded.
-   tar xvfz vsts-agent-osx-x64-V.v.v.tar.gz
-   ~/myagent$ 
-   ./config.sh
 -  ./run.sh