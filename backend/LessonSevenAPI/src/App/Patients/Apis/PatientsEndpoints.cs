
namespace App.Patients.Apis;

public static class PatientsEndpoints {

    public static void ConfigPatientsEndPoints(this WebApplication app) {
        app.MapGet(pattern: "/patients", handler: GetPatients);
    }

    internal static IResult GetPatients(){

        var patients = new [] {
            new {
                FirstName = "Pete",
                LastName = "Mukasa",
                Age = 34
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            },
              new {
                FirstName = "Duncan",
                LastName = "Musa",
                Age = 27
            },
              new {
                FirstName = "Mike",
                LastName = "Mute",
                Age = 43
            }
        };

        return Results.Ok(patients);
    }


}