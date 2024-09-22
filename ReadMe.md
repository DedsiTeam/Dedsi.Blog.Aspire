Sql Server 2022
```
docker pull mcr.microsoft.com/mssql/server:2022-latest

docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=PAssWoRd@22422024..+" -p 11431:1433 --name dedsi-blog-mssql2022 --restart=on-failure:10 -d mcr.microsoft.com/mssql/server:2022-latest
```