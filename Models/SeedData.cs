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
                    Image = "https://www.bria.com.ph/wp-content/uploads/2021/10/why-you-should-invest-in-cebu-queen-of-the-south-webp.webp",
                    Description = ""

                }, new City
                {
                    Name = "Bohol",
                    State = "Visayas",
                    Image = "https://www.civitatis.com/f/filipinas/bohol/tour-tagbilaran-589x392.jpg",
                    Description = "Bohol is an island province known for its unique attractions such as the Chocolate Hills, tarsiers, and pristine beaches."
                },
                        new City
                        {
                            Name = "Dumaguete",
                            State = "Visayas",
                            Image = "https://gttp.imgix.net/225745/x/0/dumaguete-travel-guide-the-best-place-to-retire-in-the-philippines-1.jpg?auto=compress%2Cformat&ch=Width%2CDPR&dpr=1&ixlib=php-3.3.0&w=883",
                            Description = "Dumaguete is a coastal city known for its relaxed atmosphere, university town vibe, and proximity to popular diving spots."
                        },
                        new City
                        {
                            Name = "Tacloban",
                            State = "Visayas",
                            Image = "https://f7c7358c.rocketcdn.me/wp-content/uploads/2019/08/Philippines-Mangrove-Boardwalk-in-Tacloban-Leyte-690x400.jpg",
                            Description = "Tacloban is the capital of Leyte province and is known for its rich history, vibrant culture, and stunning natural landscapes."
                        },
                new City
                {
                    Name = "Baguio",
                    State = "Luzon",
                    Image = "https://res.klook.com/image/upload/c_fill,w_750,h_560/q_80/w_80,x_15,y_15,g_south_west,l_Klook_water_br_trans_yhcmh3/activities/ajr9gdn0scezbllueayx.jpg",
                    Description = "Baguio, often called the Summer Capital of the Philippines, is known for its cool climate, pine trees, and cultural sites like the Camp John Hay and the Baguio Cathedral."
                },
                new City
                {
                    Name = "Vigan",
                    State = "Luzon",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/0/09/Calle_Crisologo%2C_Vigan%2C_Philippines_-_One_of_The_New_7_Wonder_Cities_of_The_World.jpg",
                    Description = "Vigan is a UNESCO World Heritage Site famous for its well-preserved Spanish colonial and Asian architecture, cobblestone streets, and horse-drawn carriages."
                },
                new City
                {
                    Name = "Batanes",
                    State = "Luzon",
                    Image = "https://ik.imagekit.io/tvlk/blog/2023/07/shutterstock_1201894768.jpg?tr=dpr-2,w-675",
                    Description = "Batanes is an archipelagic province known for its dramatic cliffs, rolling hills, stone houses, and traditional Ivatan culture. It's often referred to as the 'Home of the Winds.'"
                },
                new City
                {
                    Name = "Baler",
                    State = "Luzon",
                    Image = "https://media.philstar.com/images/the-philippine-star/lifestyle/travel-and-tourism/20170709/Baler-1.jpg",
                    Description = "Baler is a coastal town famous for its surfing spots, particularly at Sabang Beach. It also offers historical sites like the Baler Church and Museo de Baler."
                },
                new City
                {
                    Name = "Tagaytay",
                    State = "Luzon",
                    Image = "https://cdn.getyourguide.com/img/tour/5c6fc0ac2ac5e.jpeg/145.jpg",
                    Description = "Tagaytay is a popular weekend destination known for its cool climate, stunning views of Taal Volcano, and attractions like Sky Ranch and Picnic Grove."
                },
                new City
                {
                    Name = "Davao City",
                    State = "Mindanao",
                    Image = "https://www.tripsavvy.com/thmb/tkDrmbWsECyync0rYp3lw9SwGQ8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/GettyImages-931559332-5c7967c0c9e77c0001d19d01.jpg",
                    Description = "Davao City, often called the 'Durian Capital of the Philippines,' is known for its disciplined community, cultural diversity, and landmarks like the People's Park and Mount Apo."
                },
                new City
                {
                    Name = "Cagayan de Oro",
                    State = "Mindanao",
                    Image = "https://www.camella.com.ph/wp-content/uploads/2022/03/Reasons-to-Live-in-Cagayan-De-Oro-City-Photo-from-The-Philippines.jpg",
                    Description = "Cagayan de Oro, dubbed as the 'City of Golden Friendship,' offers adventure activities like whitewater rafting, zip-lining, and scenic spots like Macahambus Hill Cave and Gardens of Malasag Eco-Tourism Village."
                },
                new City
                {
                    Name = "Zamboanga City",
                    State = "Mindanao",
                    Image = "https://www.tourism.gov.ph/PublishingImages/Destinations/Zamboanga_City_2.jpg",
                    Description = "Zamboanga City is known for its colorful vintas (traditional boats), diverse culture influenced by Spanish, Muslim, and indigenous traditions, and landmarks like Fort Pilar and Paseo del Mar."
                },
                new City
                {
                    Name = "Surigao City",
                    State = "Mindanao",
                    Image = "https://farm3.staticflickr.com/2896/14529979189_da22aa31a0_o.jpg",
                    Description = "Surigao City is the capital of Surigao del Norte and is known for its beautiful islands, beaches, and the famous surfing spot Cloud 9 in Siargao Island."
                },
                new City
                {
                    Name = "General Santos City",
                    State = "Mindanao",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/d/db/Gensan.jpg",
                    Description = "General Santos City, often referred to as GenSan, is known as the 'Tuna Capital of the Philippines.' It offers culinary delights, cultural festivals, and access to scenic spots like Sarangani Bay and Lake Sebu."
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
                    Category = "Museum"
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
    Category = "Museum"
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
    Category = "Museum"
},
new Place
{
    CityId = 6,
    Description = "Paoay Church, also known as the Saint Augustine Church, is a UNESCO World Heritage Site located in Paoay, Ilocos Norte. Built in 1710, this stunning example of Baroque architecture features massive buttresses made of coral stones and bricks, designed to withstand earthquakes. Visitors can admire the church's intricate details, including its decorative facade and bell tower, and explore its interior, which houses beautiful religious artifacts and paintings.",
    Name = "Paoay Church",
    Coordinates = "18.0675° N, 120.5463° E",
    Tips = "Tips:\nPhotography: Capture the impressive facade and architectural details of Paoay Church from various angles. Early morning or late afternoon lighting can enhance the beauty of the structure.\nGuided Tours: Join a guided tour of the church to learn about its history, architecture, and significance in Philippine culture and heritage.\nCultural Events: Check the church's schedule for religious ceremonies, festivals, and cultural events celebrating Ilocano traditions and Catholic heritage.\nVisiting Hours: Paoay Church is open daily for visitors, but it may be closed during religious services or events. Plan your visit accordingly to avoid disappointment.\nSouvenirs: Support local artisans by purchasing handmade crafts, religious items, and souvenirs from vendors near the church.",
    Images = new string[]
    {
        "https://source.unsplash.com/400x400/?paoay-church",
        "https://source.unsplash.com/400x400/?baroque-architecture"
    },
    Category = "Historical Landmark"
},
new Place
{
    CityId = 6,
    Description = "Pagudpud is a scenic coastal town located in the province of Ilocos Norte, known for its pristine beaches, crystal-clear waters, and stunning natural landscapes. Popular attractions in Pagudpud include Saud Beach, Maira-ira Point (Blue Lagoon), and Kabigan Falls. Visitors can enjoy a variety of activities such as swimming, snorkeling, surfing, and exploring picturesque rock formations and secluded coves along the coastline.",
    Name = "Pagudpud",
    Coordinates = "18.5733° N, 120.9024° E",
    Tips = "Tips:\nAccommodation: Book accommodations in advance, especially during peak tourist seasons, as Pagudpud can get crowded.\nBeach Safety: Observe safety precautions when swimming or engaging in water activities. Be aware of strong currents, rip tides, and jellyfish.\nLocal Cuisine: Sample delicious Ilocano dishes and seafood specialties at local eateries and beachfront restaurants in Pagudpud.\nSun Protection: Apply sunscreen, wear a hat, and bring protective clothing to shield yourself from the sun's rays, especially during midday.\nExplore Beyond the Beach: Take time to explore Pagudpud's inland attractions, including waterfalls, wind farms, and historical sites showcasing the region's rich cultural heritage.",
    Images = new string[]
    {
        "https://source.unsplash.com/400x400/?pagudpud-beach",
        "https://source.unsplash.com/400x400/?coastal-scenery"
    },
    Category = "Beaches"
},
            new Place
            {
                CityId = 7,
                Description = "Mayon Volcano, known as the 'Perfect Cone,' is an active stratovolcano located in the province of Albay. Renowned for its symmetric conical shape, Mayon is one of the most iconic natural landmarks in the Philippines. Visitors can admire the volcano's beauty from various viewpoints, including Cagsawa Ruins, Lignon Hill, and the Mayon Skyline View Deck. Outdoor enthusiasts can also embark on hiking adventures to reach the volcano's summit and witness breathtaking panoramic views.",
                Name = "Mayon Volcano",
                Coordinates = "13.2571° N, 123.6854° E",
                Tips = "Tips:\nVolcano Viewing: Choose from several viewpoints around Mayon Volcano to capture the perfect photo or simply marvel at its majestic beauty. Consider visiting during sunrise or sunset for stunning light effects.\nHiking Preparations: If planning to hike Mayon Volcano, make sure to prepare adequately with proper gear, water, and supplies. Check weather conditions and consult with local guides for safety recommendations.\nCultural Insights: Learn about the local folklore and legends surrounding Mayon Volcano, including tales of love and tragedy associated with the mythical princess Daragang Magayon.\nVisitor Centers: Visit nearby visitor centers and museums to learn more about Mayon Volcano's geology, ecology, and cultural significance. Interactive exhibits and educational materials provide insights into the region's volcanic activity and history.\nConservation Awareness: Support conservation efforts to preserve Mayon Volcano and its surrounding natural habitats. Follow designated trails, refrain from littering, and respect environmental regulations during your visit.",
                Images = new string[]
                {
                    "https://source.unsplash.com/400x400/?mayon-volcano",
                    "https://source.unsplash.com/400x400/?volcanic-landscape"
                },
                Category = "Natural Landmark"
            },
            new Place
            {
                CityId = 8,
                Description = "Angeles City is a vibrant urban center located in the province of Pampanga, known for its lively entertainment scene, historical sites, and culinary delights. Popular attractions in Angeles City include the Holy Rosary Parish Church (Santo Rosario Church), Museo Ning Angeles, and the Nayong Pilipino Clark. Visitors can explore the city's rich heritage, sample delicious Kapampangan cuisine, and enjoy exciting nightlife experiences.",
                Name = "Angeles City",
                Coordinates = "15.1442° N, 120.5881° E",
                Tips = "Tips:\nHeritage Walking Tour: Take a leisurely stroll through Angeles City's historic district to discover well-preserved heritage buildings, ancestral houses, and landmarks dating back to the Spanish colonial era.\nCulinary Exploration: Indulge in a gastronomic adventure by trying authentic Kapampangan dishes and delicacies at local eateries, carinderias, and specialty restaurants in Angeles City.\nShopping Spree: Shop for souvenirs, handicrafts, and local products at bustling markets like the Angeles City Public Market and Marquee Mall. Don't forget to haggle for the best deals!\nNightlife Excursions: Experience the vibrant nightlife of Angeles City by visiting popular entertainment hubs, bars, clubs, and karaoke joints. Enjoy live music, dancing, and socializing with locals and fellow travelers.\nFestivals and Events: Check the city's calendar for festive celebrations, cultural events, and fiestas showcasing Kapampangan traditions, music, and dance performances throughout the year.",
                Images = new string[]
                {
                    "https://source.unsplash.com/400x400/?angeles-city",
                    "https://source.unsplash.com/400x400/?nightlife"
                },
                Category = "Urban Exploration"
            }
            


                );
                context.SaveChanges();
            }
        }
    }
}