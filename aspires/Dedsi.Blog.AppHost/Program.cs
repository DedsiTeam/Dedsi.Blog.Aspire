var builder = DistributedApplication.CreateBuilder(args);

#region 数据库
var identityConnectionString = builder.AddConnectionString("DedsiBlogIdentityDB");
var fileConnectionString = builder.AddConnectionString("DedsiBlogFileDB");
var articleConnectionString = builder.AddConnectionString("DedsiBlogArticleDB");
var backgroundComputingConnectionString = builder.AddConnectionString("DedsiBlogBackgroundComputingDB");
#endregion

#region Api 服务
var dedsiBlogIdentity = builder
    .AddProject<Projects.Dedsi_Blog_Identity>("dedsi-blog-identity")
    .WithReference(identityConnectionString);

var dedsiBlogFile = builder
    .AddProject<Projects.Dedsi_Blog_File>("dedsi-blog-file")
    .WithReference(fileConnectionString);

var dedsiBlogArticle = builder
    .AddProject<Projects.Dedsi_Blog_Article>("dedsi-blog-article")
    .WithReference(articleConnectionString);

var dedsiBlogBackgroundComputing = builder
    .AddProject<Projects.Dedsi_Blog_BackgroundComputing>("dedsi-blog-backgroundcomputing")
    .WithReference(backgroundComputingConnectionString);
#endregion

#region 网关
builder
    .AddProject<Projects.Dedsi_Blog_AdminGateway>("dedsi-blog-admingateway")
    .WithReference(dedsiBlogIdentity)
    .WithReference(dedsiBlogFile)
    .WithReference(dedsiBlogArticle)
    .WithReference(dedsiBlogBackgroundComputing);

builder
    .AddProject<Projects.Dedsi_Blog_PublicGateway>("dedsi-blog-publicgateway")
    .WithReference(dedsiBlogIdentity)
    .WithReference(dedsiBlogFile)
    .WithReference(dedsiBlogArticle)
    .WithReference(dedsiBlogBackgroundComputing);
#endregion

builder.Build().Run();