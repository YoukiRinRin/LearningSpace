@echo off
net start OracleRemExecService 2>nul
net start OracleMTSRecoveryService 2>nul
net start OracleServiceORCLTESTDB 2>nul
net start OracleDBConsoleOrclTestDB 2>nul
net start OracleOraDb11g_home1TNSListener 2>nul
net start MSSQL$TOASQL 2>nul
net start MSSQLFDLauncher$TOASQL 2>nul
net start SQLWriter 2>nul
net start SQLBrowser 2>nul
net start ReportServer$TOASQL 2>nul
net start LSPSERVICE_MR 2>nul
@oradim -startup -sid XE -starttype inst > nul 2>&1
