## Delayed Echo Application
##### @author: Matthew Parker
##### @name: DelayedEchoConsoleApp
##

## github.com:
https://github.com/mattp76/DelayedEchoConsoleApp

## How to Run
Clone this repository (let me know if any problems). Please open the solution and build / compile. I have set this solution compile into its bin/debug folder. 
You will see an application appear in this folder - DelayedEchoConsoleApp.exe. Run this.

Alternatively, just run the solution in debug mode and the console application will open up.

## Usage
Type in string in this format.

hello:10

hello being the messsage. 10 being the numbers of seconds before the response from the class library event is seen.

## Packages Information
#Autofac version 4.6.2

#DelayedEcho.MP.AP version 1.0.1  (this is the public nuget package of the DelayedEcho classlibrary)

url: https://www.nuget.org/packages/DelayedEcho.MP.AP/
 
I have used Autofac for dependancy injection. I feel this is always a great approach to passing around the relevant objects, and nice way to seperate the code out into interfaces and services (in this case). 
This also opens the door for unit testing / mocking.






