#!/bin/bash

# Starte MSSQL Server im Hintergrund
/opt/mssql/bin/sqlservr &

# Warte, bis der MSSQL-Server bereit ist
echo "Warte, bis MSSQL gestartet ist..."
sleep 30

# Datenbank erstellen
echo "Erstelle Datenbank PCKonfigurator..."
/opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P 'YourStrong!Passw0rd' -Q "IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'PCKonfigurator') CREATE DATABASE PCKonfigurator"

# Halte den Container aktiv
wait
