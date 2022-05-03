net stop OracleServiceXE
@echo off
net start OracleXETNSListener 2>nul
net start OracleServiceXE 2>nul
@oradim -startup -sid XE -starttype inst > nul 2>&1
