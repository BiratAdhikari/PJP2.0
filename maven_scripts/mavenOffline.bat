@ECHO OFF
TITLE mavenOffline

ECHO ==============
:: this batch file prevents maven from downloading dependencies online.Also help maven perform offline.
mvn dependency:go-offline 
call mvn –o clean package
PAUSE
