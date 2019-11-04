# 1 准备工作 #
需要安装PMC工具（仅对于Visual Studio）或CLI工具 
这里使用CLI工具
---

1.1 安装第一个包
`dotnet tool install --global dotnet-ef`
---
1.2 安装最新SDK
---
1.3 安装第二个包
`dotnet add package Microsoft.EntityFrameworkCore.Design`
---
# 2 执行 命令从数据库生成实体#
`dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=efcore3pointOScriptsTest;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"  Microsoft.EntityFrameworkCore.SqlServer -o Models -c consoleAppDbcontext`

-o表示输出到目录 -c指定生成的dbcontext的名称
如果想要生成具体某个表，请使用-t tablename,指定多个表可以反复使用-t tableName来指定多个表
---
# 3 接下来可以使用以下命令生成迁移#

`dotnet ef migrations add Initial`
