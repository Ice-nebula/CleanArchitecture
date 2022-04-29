# CleanArchitecture

Clean architecture is a template for asp.net core mvc for easy application development and it's faster when you choose to use this template because you don't have to implement the new architecture yourself.

# technologies
1. [asp.net core 6](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core?view=aspnetcore-6.0)
2. [entity framework for data access](https://docs.microsoft.com/en-us/ef/core/)
3. [postgres provider for entity framework](https://github.com/npgsql/efcore.pg)
4. [automapper](https://github.com/AutoMapper/AutoMapper)
5. [webpack](https://webpack.js.org/)
6. [x unit](https://xunit.net/)

# golds
The goal of this project is to provide a basic solution for clean architecture to easy development and don't waste time implementing.

## get started
To use this template, we have two methods for you:
1. method 1: clone this repository to your computer and start development
2. method 2 :  clone this repo to computer and install template with dotnet cli

Note if you use method 2, you can use dotnet new command easily and the project structure we created with this method will look more organized.

### method 1: clone this repository to your computer
You can clone this repository to your computer by doing the following:

Open your favorite terminal and type the following command :

    git clone git@github.com:IceBytes/CleanArchitecture.git
    cd to project directory by command:
    cd   CleanArchitecture/src/CleanArchitecture.Webh

Before running asp.net project ,we need to install flontend dependency as follows :

please make shure You are in the CleanArchitecture.Web directory before typing the command below

    cd webpack && npm install

After successful installation, we need to run webpack to build javascript library before running asp.net core project as follows:

    npm run start

After the build is successful, the next step is to run asp.net project.

Open a new terminal and cd back to CleanArchitecture.Web and then run this command
    dotnet watch run

please wait a few seconds, If everything has no problem or error, our project will be run and browser will be opened automatically.

## method 2 : install this template to dotnet cli

important, you need to make sure you install dotnet sdk before doing this method

If you haven't installed dotnet sdk, please install it first and try this method again.

If you have dotnet sdk installed and it just works, Let's start the installation using the following : 

Step 1 Clone this repository to computer by command :

    git clone git@github.com:Ice-nebula/CleanArchitecture.git
	
step 2 change directory to repo directory by command : 

    cd CleanArchitecture

after you enter repository directory, We will install the template using this command:

    dotnet new --install .\

output

Success: D:\project\asp net project\CleanArchitecture installed the following templates:
Template Name              Short Name                          Language  Tags
-------------------------  ----------------------------------  --------  ----------------------------------------------
asp.net Core Mvc Clean...  asp.net core mvc CleanArchitecture  [C#]      asp.net core CleanArchitecture/web/mvc/webpack

Congratulations, we have successfully installed this template.

Next step, we will create a project.

## create project 

Now to the last step, let's create a project with the following : 

change path to empty directory and create project using the following command :

D:\tester> dotnet new "asp.net core mvc CleanArchitecture"                                                               

output

The template "asp.net Core Mvc CleanArchitecture" was created successfully.

Success, project has been created.

In the directory we created the project there is a folder created by dotnet as follows:

src: all projects will store here

and testes : all test projects will store here.

ok Once the project has been created, let's run the project as follows

cd  src/tester.Web

note, Please replace tester with the name of your project you created by step above.

Once you enter the directory tester.web, before we run the project, we need to run webpack dev  to build javascript library as follows :
in directory tester.web, please type command :

cd webpack && npm install && npm start

when webpack start successfully We will open a new terminal in folder tester.web and run asp.net project by command :

    dotnet watch run

please wait a few seconds, If everything has no problem or error, our project will be run and browser will be opened automatically.
# support
Nothing 100% perfect

If you have a problem, come across a bug, don't forget to let us know.

Or would you like to help us, I'd love to hear your advice or to see your awesome pull request.