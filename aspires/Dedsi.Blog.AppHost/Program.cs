var builder = DistributedApplication.CreateBuilder(args);

var dedsiBlogIdentity = builder.AddProject<Projects.Dedsi_Blog_Identity>("dedsi-blog-identity");

var dedsiBlogFile = builder.AddProject<Projects.Dedsi_Blog_File>("dedsi-blog-file");

var dedsiBlogArticle = builder.AddProject<Projects.Dedsi_Blog_Article>("dedsi-blog-article");

var dedsiBlogBackgroundComputing = builder.AddProject<Projects.Dedsi_Blog_BackgroundComputing>("dedsi-blog-backgroundcomputing");

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

builder.Build().Run();