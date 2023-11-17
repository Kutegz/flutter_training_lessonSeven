
using App.Home.Apis;
using App.Patients.Apis;
using App.Posts.Apis;

var builder = WebApplication.CreateBuilder(args);
{
}

var app = builder.Build();
{
    app.ConfigHomeEndPoints();
    app.ConfigPatientsEndPoints();
    app.ConfigPostsEndPoints();
    app.Run();
}
