@ECHO OFF
ECHO Automation Executation has started.

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe C:\Users\muham\source\repos\AutomationSeleniumTesting\bin\Debug\AutomationSeleniumTesting.dll

PAUSE