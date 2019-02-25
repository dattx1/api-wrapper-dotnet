Using openCover to test Code Coverage.

## Download Tools:
 - Download OpenCover at: https://github.com/opencover/opencover/releases (version 4.7.922, MSI File)
 - Download ReportGenerator at: https://github.com/danielpalme/ReportGenerator/releases

## Setup:
 - Run file opencover.4.7.922.msi to setup OpenCover
 - Extra ReportGenerator
 - Build UizaTest Project
 
## Run test
  1. Open cmd with administrator
  2. copy and paste to cmd 
  ```
  "C:\Users\{UserName}\AppData\Local\Apps\OpenCover\OpenCover.Console.exe" -output:"D:\UnitTestCover\coverage.xml" -target:"C:\Users\tran.xuan.dat\.nuget\packages\xunit.runner.console\2.4.1\tools\net452\xunit.console.exe" -targetargs:"\"D:\Project\api-wrapper-dotnet\src\UizaTest\bin\Debug\net452\UizaTest.dll\" -noshadow " -filter:"+[*]UizaTest.*" -register:user 
  ```
  
| Key               | Value             |
| ----------------- | -------------- |
| C:\Users\{UserName}\AppData\Local\Apps\OpenCover\OpenCover.Console.exe        | This is OpenCover installer folder, we will run OpenCover.Console.exe, |
| -output:"D:\UnitTestCover\coverage.xml"        | This is export Folder where OpenCover export the result |
| -target:"C:\Users\tran.xuan.dat\.nuget\packages\xunit.runner.console\2.4.1\tools\net452\xunit.console.exe"| We call the Xunit control, this direction is Xunit package install, we can install Xunit by Nuget Manage [view here](https://www.nuget.org/packages/xunit) |
| -targetargs:"\"D:\Project\api-wrapper-dotnet\src\UizaTest\bin\Debug\net452\UizaTest.dll\"| direction of UizaTest project build, we run Xunit for UizaTest project, with example is absolute path at my computer |
| -filter:"+[*]UizaTest.*" -register:user| filter module will run code coverage|

## Export Report
After run OpenCover tool We will get the result file at "-output" config (in this example is "D:\UnitTestCover\coverage.xml")

1. Open cmd with administrator
2. cd to extra ReportGenerator folder
3. copy and paste:
	```
	ReportGenerator.exe "-reports: D:/UnitTestCover/coverage.xml" "-targetdir:D:/UnitTestCover/"
	```

| Key               | Value             |
| ----------------- | ----------------- |
|ReportGenerator.exe| call ReportGenerator tool|
|"-reports: D:/UnitTestCover/coverage.xml"|ReportGenerator parameter which tell ReportGenerator will generator report from file, file generator is xml file |
|"-targetdir:D:/UnitTestCover/"| the folder which ReportGenerator will export the result|

