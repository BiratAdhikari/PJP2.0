@ECHO OFF
TITLE leveraging_local_copy



mvn -Dmaven.repo.local=$HOME/.my/other/repository clean install
PAUSE
