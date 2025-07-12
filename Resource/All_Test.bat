@ECHO OFF
ECHO Automation Executation has started.

set summaryPath=C:\Users\muham\source\repos\AutomationSeleniumTesting\TestSummaryReport\

call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"

VSTest.Console.exe C:\Users\muham\source\repos\AutomationSeleniumTesting\bin\Debug\AutomationSeleniumTesting.dll /Logger:"trx;LogFileName=C:\Users\muham\source\repos\AutomationSeleniumTesting\TestSummaryReport\BookHotel_TC005.trx"



PAUSE