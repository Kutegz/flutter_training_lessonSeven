
namespace App.Home.Apis;

public static class HomeEndpoints {

    public static void ConfigHomeEndPoints(this WebApplication app) {
        app.MapGet(pattern: "/", handler: () => "welcome to home page");
    }

}