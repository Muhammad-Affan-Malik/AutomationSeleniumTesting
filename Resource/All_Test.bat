@ECHO OFF
ECHO Automation Execution has started.

:: ========================
:: Configuration
:: ========================
set "projectDir=C:\Users\muham\source\repos\AutomationSeleniumTesting"
set "summaryPath=%projectDir%\TestSummaryReport"
set "testDll=%projectDir%\bin\Debug\AutomationSeleniumTesting.dll"
set "trxFile=%summaryPath%\BookHotel_TC005.trx"
set "htmlReport=%summaryPath%\BookHotel_TC005.html"

:: Create output directory
if not exist "%summaryPath%" mkdir "%summaryPath%"

:: ========================
:: 1. Run Tests
:: ========================
call "C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\Tools\VsDevCmd.bat"
VSTest.Console.exe "%testDll%" /Logger:"trx;LogFileName=%trxFile%"

:: ========================
:: 2. Generate HTML Report
:: ========================
ECHO Generating HTML report...
dotnet tool run trxlog2html -i "%trxFile%" -o "%htmlReport%"

:: ========================
:: 3. Verify and Open Report
:: ========================
if exist "%htmlReport%" (
    ECHO Opening report in browser...
    start "" "%htmlReport%"
) else (
    ECHO ERROR: Failed to generate HTML report
    ECHO Check if TRX file exists: %trxFile%
    dir "%summaryPath%"
)

PAUSE