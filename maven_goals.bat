@ECHO OFF
TITLE mavenGoals
ECHO =====================
::First take the plugins whose goals are to be found
::Read the plugins
Echo "Enter plug-in to list out their goals:"
ECHO "The all available goals of the plugin =>$plugin are :"

mvn help:describe -Dplugin=org.apache.maven.plugins:maven-war-plugin\
                  -Ddetail=true
PAUSE

