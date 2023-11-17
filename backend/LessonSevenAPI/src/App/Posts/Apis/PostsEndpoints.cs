
namespace App.Posts.Apis;

public static class PostsEndpoints {

    public static void ConfigPostsEndPoints(this WebApplication app) {
        app.MapGet(pattern: "/posts", handler: GetPosts);
    }

    internal static IResult GetPosts(){

        var posts = new [] {
            new {
                    Id = 1,
                    Title = "sunt aut facere repellat provident occaecati excepturi optio reprehenderit",
                    Body= "quia et suscipit\nsuscipit recusandae consequuntur expedita et cum\nreprehenderit molestiae ut ut quas totam\nnostrum rerum est autem sunt rem eveniet architecto"
            },
              new {
                    Id = 2,
                    Title = "qui est esse",
                    Body= "est rerum tempore vitae\nsequi sint nihil reprehenderit dolor beatae ea dolores neque\nfugiat blanditiis voluptate porro vel nihil molestiae ut reiciendis\nqui aperiam non debitis possimus qui neque nisi nulla"
            },
              new {
                    Id = 3,
                    Title = "ea molestias quasi exercitationem repellat qui ipsa sit aut",
                    Body= "et iusto sed quo iure\nvoluptatem occaecati omnis eligendi aut ad\nvoluptatem doloribus vel accusantium quis pariatur\nmolestiae porro eius odio et labore et velit aut"
            },
                new {
                    Id = 4,
                    Title = "um et est occaecati",
                    Body = "ullam et saepe reiciendis voluptatem adipisci\nsit amet autem assumenda provident rerum culpa\nquis hic commodi nesciunt rem tenetur doloremque ipsam iure\nquis sunt voluptatem rerum illo velit"
            },
                new {
                    Id = 5,
                    Title ="nesciunt quas odio",
                    Body = "repudiandae veniam quaerat sunt sed\nalias aut fugiat sit autem sed est\nvoluptatem omnis possimus esse voluptatibus quis\nest aut tenetur dolor neque"
                }
        };

        return Results.Ok(posts);
    }

}