﻿using Microsoft.EntityFrameworkCore;

namespace CityTourist.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            TouristDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider
                .GetRequiredService<TouristDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Admin.Any())
            {
                context.Admin.AddRange(
                new AdminModel
                {
                    UserName = "admin",
                    Password = "admin",
                    Name = "admin",
            
                });
                context.SaveChanges();
            }
            if (!context.City.Any())
            {
                context.City.AddRange(
                new City
                {
                    Name = "Cebu",
                    State = "Visayas",
                    Image = "https://source.unsplash.com/400x400/?city",
                    Description = ""

                }, new City
                {
                    Name = "Bohol",
                    State = "Visayas",
                    Image = "https://source.unsplash.com/400x400/?city",
                    Description = "Bohol is an island province known for its unique attractions such as the Chocolate Hills, tarsiers, and pristine beaches."
                },
                        new City
                        {
                            Name = "Dumaguete",
                            State = "Visayas",
                            Image = "https://source.unsplash.com/400x400/?city",
                            Description = "Dumaguete is a coastal city known for its relaxed atmosphere, university town vibe, and proximity to popular diving spots."
                        },
                        new City
                        {
                            Name = "Tacloban",
                            State = "Eastern Visayas",
                            Image = "https://source.unsplash.com/400x400/?city",
                            Description = "Tacloban is the capital of Leyte province and is known for its rich history, vibrant culture, and stunning natural landscapes."
                        },
                        new City
                        {
                            Name = "Tagbilaran",
                            State = "Visayas",
                            Image = "https://source.unsplash.com/400x400/?city",
                            Description = "Tagbilaran is the capital city of Bohol province and serves as a gateway to the province's famous tourist destinations, including the Chocolate Hills and Panglao Island."
                        }
                );
                context.SaveChanges();
            }
            if (!context.Place.Any())
            {
                context.Place.AddRange(
                new Place
                {
                    CityId = 1,
                    Description = "Kawasan Falls is a breathtaking natural attraction located in the municipality of Badian, Cebu. It features stunning turquoise-blue waters cascading down three tiers of waterfalls amidst lush tropical greenery. Visitors can enjoy swimming in the cool, clear pools, bamboo rafting, and cliff jumping into the deep pools below. The surrounding jungle offers opportunities for nature walks and birdwatching, making Kawasan Falls a popular destination for both adventure seekers and nature lovers.",
                    Name = "Kawasan Falls",
                    Coordinates= "9.8347° N,123.3635° E",
                    Tips = "Tips:\nArrive Early: To avoid crowds and have the falls to yourself, consider visiting early in the morning before tour groups arrive.\nWear Water Shoes: The trails around Kawasan Falls can be slippery, so wearing proper footwear with good grip is advisable.\nBring Snacks and Water: While there are vendors near the falls, it's a good idea to bring your snacks and plenty of water, especially if you plan to spend the day exploring the area.\nSupport Local Guides: Consider hiring a local guide for activities such as canyoneering, which involves trekking, swimming, and cliff jumping through the Kawasan Canyon.\n\n\nRoutes:\nRoute 1: From Cebu City, take a bus or private car southbound on the Cebu South Road towards Badian. Follow directional signs to Kawasan Falls, which is approximately a 3-hour drive.\nRoute 2: If coming from Moalboal or Oslob, Kawasan Falls is accessible by land via the coastal highway. Follow the main road towards Badian and look for signs directing you to the falls.",
                    Images = ["https://source.unsplash.com/400x400/?nature", "https://source.unsplash.com/400x400/?city"],
                    Category = "Beaches"


                },
                new Place
                {
                    CityId = 1,
                    Description = "Magellan's Cross is a historical landmark located in Cebu City, Philippines. It is a Christian cross planted by Portuguese and Spanish explorers as ordered by Ferdinand Magellan upon arriving in the Philippines in 1521. The cross is housed in a small chapel near the Basilica Minore del Santo Niño and is believed to contain a piece of the original cross planted by Magellan.",
                    Name = "Magellan's Cross",
                    Coordinates = "10.3037° N, 123.9056° E",
                    Tips = "Tips:\nRespectful Behavior: As a religious site, visitors are expected to maintain respectful behavior and attire. Avoid loud noises, littering, and disrespectful behavior.\nPhotography: Feel free to take photos of the cross and its surroundings, but be mindful of other visitors and the sanctity of the site.\nVisiting Hours: The chapel housing Magellan's Cross is open daily from early morning until late afternoon. Plan your visit accordingly to avoid crowds.\nExplore Nearby Attractions: After visiting the cross, take some time to explore the nearby Basilica Minore del Santo Niño and other historical landmarks in the area.",
                    Images = new string[]
    {
        "https://source.unsplash.com/400x400/?magellans-cross",
        "https://source.unsplash.com/400x400/?historical-site"
    },
                    Category = "Historical Landmarks"
                },
new Place
{
    CityId = 1,
    Description = "Tops Lookout is a popular viewpoint located in the hills of Cebu City, offering panoramic views of the cityscape, Mactan Island, and the surrounding islands. It is a favorite destination for tourists and locals alike, especially during sunrise or sunset when the city lights are most spectacular. Visitors can enjoy a leisurely drive or hike to reach the viewpoint, where they can relax, take photos, and marvel at the breathtaking scenery.",
    Name = "Tops Lookout",
    Coordinates = "10.3429° N, 123.8964° E",
    Tips = "Tips:\nTransportation: Tops Lookout is accessible by private vehicle or taxi. Visitors can also hire a motorcycle taxi ('habal-habal') for a more adventurous ride.\nEntrance Fee: There is a small entrance fee to access the viewpoint. Bring cash for the admission fee and any additional expenses.\nTiming: For the best views, plan your visit to coincide with sunrise or sunset. Arrive early to secure a good spot and avoid crowds.\nWeather Considerations: Check the weather forecast before visiting, as fog or rain may obstruct visibility, especially during the rainy season.\nRefreshments: There are food and refreshment stalls near the viewpoint where visitors can purchase snacks, drinks, and souvenirs.",
    Images = new string[]
    {
        "https://source.unsplash.com/400x400/?tops-lookout",
        "https://source.unsplash.com/400x400/?viewpoint"
    },
    Category = "Scenic Views"
},
new Place
{
    CityId = 1,
    Description = "Fort San Pedro is a military defense structure located in Cebu City, Philippines. It is the oldest and smallest triangular bastion fort in the country, built by Spanish conquistadors under the command of Miguel López de Legazpi in 1565. The fort served as a defensive fortress during the Spanish colonial period and was later used as a stronghold by Filipino revolutionaries against American forces. Today, Fort San Pedro is a popular tourist attraction and historical landmark.",
    Name = "Fort San Pedro",
    Coordinates = "10.2928° N, 123.9054° E",
    Tips = "Tips:\nGuided Tours: Join a guided tour of Fort San Pedro to learn about its history, architecture, and significance in Philippine history. Knowledgeable guides provide insights into the fort's role in various historical events.\nExploration: Explore the interior of the fort, including its ramparts, barracks, and exhibits showcasing artifacts and historical information. Don't forget to climb the watchtower for panoramic views of the surrounding area.\nPhotography: Capture the fort's picturesque architecture, cannons, and scenic views as souvenirs of your visit. Respect any signage or restrictions regarding photography.\nVisit Timing: Fort San Pedro is open daily, but it can get crowded during peak hours and weekends. Consider visiting early in the morning or late afternoon for a more peaceful experience.\nCultural Events: Check the fort's schedule for cultural events, exhibitions, and performances celebrating Cebuano heritage and history.",
    Images = new string[]
    {
        "https://source.unsplash.com/400x400/?fort-san-pedro",
        "https://source.unsplash.com/400x400/?historical-site"
    },
    Category = "Historical Landmarks"
}


                );
                context.SaveChanges();
            }
        }
    }
}