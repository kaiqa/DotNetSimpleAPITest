<h1API mini project hosted on Azure DevOps</h1>
<b>Task:</b> Execute tests on commits to the github repro and if successful trigger deployment to production.

![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/1.png)

<b>The problems:</b>
The most tricky part was to integrate my local mac to build the project and to understand the related terms that Microsoft uses. 
At first I was under the assumption that you can do everything online using microsoft’s free hosting and services. This is what I was told from the tutorials I have watched on Linkedin learning, but sadly that is not the case anymore. So in order to trial anything you have to use your own machine. It was also claimed that it has tobe a public project. The agent that I create always and still is shown as self hosted in the private projects section. I am using this agent in my public project just fine. It is very confusing to say the least. Maybe a bug. It took me quite awhile to figure everything out.

![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/2.png)
In the end the Mac agent accepted the jobs.
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/15.png)
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/3.png)
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/4.png)
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/5.png)

<b>Creating and configuring the pipeline:</b>
It takes some getting used to as you can switch between using a yaml file or the GUI designer.

![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/6.png)

It’s pretty cool to see the pipeline running with every code change:
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/7.png)

And passing tests.
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/8.png)

And then the release pipeline:
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/9.png)
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/14.png)

<b>Testing with postman:</b>
Local
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/10.png)

Production:
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/11.png)

<b>Starting production:</b>
Be aware the Production site can cost money when you run the server:
For passing unit test’s and deploying the code changes there is never a need to start the server manual.
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/12.png)

If you do start the server (Button:Start) then make sure to stop the server when you are done.
![project](https://github.com/kaiqa/DotNetSimpleAPITest/blob/master/img/13.png)



<b>Roll your own: </b>

Create your main solution directory: SimpleAPI 

Create 2 sub directories in here, named src and test directory
Inside the src directory.
-   dotnet new webapi -n SimpleAPI

Inside the test directory 
-   dotnet new xunit -n SimpleAPI.Tests


Solution Directory:

-    create a solution file SimpleAPI.sln
-    dotnet new sln --name SimpleAPI

 <b>Associate both “child” projects to the solution </b>
 (you could also create the references in Visual Studio)

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

<b>Run a os x build agent:</b>

Set attributes to allow the setup script to run.
-   xattr -c vsts-agent-osx-x64-V.v.v.tar.gz  ## replace V.v.v with the version in the filename downloaded.
-   tar xvfz vsts-agent-osx-x64-V.v.v.tar.gz
-   ~/myagent$ 
-   ./config.sh
-  ./run.sh
