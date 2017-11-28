using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TicketStore.Models.EntityModels;

namespace TicketStore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TicketStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TicketStoreContext context)
        {

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manage = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manage.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manage = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Customer");
                manage.Create(role);
            }

            //context.Places.AddOrUpdate(
            //   
            //   new Place()
            //   {
            //       Id = 1,
            //       Name = "Vasil Levski Stadium",
            //       Prices = new List<int>()
            //       {
            //           20, 30, 35, 40, 45, 55
            //       }
            //   },
            //   new Place()
            //   {
            //       Id = 2,
            //       Name = "Arena Armeec",
            //
            //       Prices = new List<int>()
            //       {
            //         50, 60, 80, 90, 100
            //       }
            //   });

            context.AllCategories.AddOrUpdate(

                new AllCategory()
                {
                    Id = 1,
                    Name = "Concerts",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Rock",
                            Image = "../../Content/images/concerts/Rock.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Guns 'N' Roses",
                                    Image = "../../Content/images/index/guns-n-roses.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Friday, 03 Nov 2017",
                                    Title = "Guns N Roses to Hit New Stadiums During 2017 Tour",
                                    Content = "If you missed the Not In This Lifetime Tour the first time around, take note of a handful of new Guns N’ Roses live dates scheduled for 2017. Though once again taking place at major stadiums in North America, the crop of venues set to put on the legendary band will be completely different from the 2016 leg. Guns N’ Roses will perform overseas before returning to the U.S. to begin the North American stretch from St. Louis’ Dome At America’s Center on July 27. Other new 2017 tour stops include BB&T Field in Winston-Salem, Commonwealth Stadium in Edmonton, and the Gorge Amphitheatre in George, Wash. The final date is scheduled for Sept. 8 at the Alamodome in San Antonio.\r\nThe venture will once again feature the reunited lineup of Axl Rose, Slash, Duff McKagan, and Dizzy Reed, as well as supporting players Richard Fortus, Frank Ferrer, and Melissa Reese.",
                                    CityCountry = "Bulgaria / Sofia",
                                    Hour = "21:45 PM"
                                },

                                new Event()
                                {
                                    Name = "Deep Purple",
                                    Image = "../../Content/images/index/deep-purple.jpg",
                                    Location = "Vasil Levski Stadium",
                                    DateDetails = "Sunday, 05 Dec 2017",
                                    Title = "Deep Purple Tour 2017",
                                    Content = "If you’re wondering why Deep Purple recorded InFinite, their 20th album, it seems that it could have been very different. “Someone in the band suggested we should just put out single songs,” says Glover. “Release something every one or two months, and just keep touring. And while this might make financial sense, it didn’t make any emotional sense to me. It might be old fashioned, but I don’t care: we’re an album band, and I’m proud of that.”\r\n\r\nHe should be. Glover sees InFinite as a state of the union address, and it’s clear the scriptwriters have been working overtime. From furious opener Time For Bedlam — which, sonically speaking, is as good an impersonation of a band in their early 20s as any released by a group whose youngest member is 62 — to the hilarious Ian Gillan monologue that closes On Top Of The World, to the final romp through The Doors’ classic Roadhouse Blues, it might just be the most authentic-sounding Purple album since Perfect Strangers back in 1984.\r\n\r\n“If an album’s not going to achieve anything chart-wise, it still doesn’t matter,” says Glover. “Because we had a great time. I couldn’t wait to do it again.”\r\n\r\nBelow, Roger talks about each of the album’s 10 tracks. InFinite is on sale now.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "22:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Scorpions",
                                    Image = "../../Content/images/index/scorpions.jpg",
                                    Location = "Vasil Levski Stadium",
                                    DateDetails = "Saturday, 06 Dec 2017",
                                    Title = "Scorpions - Born to touch your feelings",
                                    Content = "In 2010, one of rock\'s all-time greats announced they would be willingly bowing out with a farewell tour after the release of Sting in the Tail. Here we are over seven years later as the Scorpions have refused to stand down, realizing their time-honored rock \'n\' roll was just as essential today as it was in the \'70s, \'80s, \'90s and so on. On the second night of their \"Crazy World\" tour with support from thrash icons Megadeth, the German act returned to Madison Square Garden for the first time since 1984, ensuring it would be a raucous big city night.\r\nDisplaying the same wide-eyed passion represented on the cover of World Wide Live, even with Klaus Meine and Rudolf Schenker both aged 69, the Scorpions hit the stage in front of a packed house, opening with the Return to Forever cut, \"Going Out With a Bang.\" With the newly implanted Mikkey Dee perched atop a drum riser resting on a raised platform, LED boards lit up behind the drummer and directly under him as it rotated between stacks of Marshall amplifiers and other digital effects.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "23:00 PM"

                                },

                                new Event()
                                {
                                    Name = "Katy Perry",
                                    Image = "../../Content/images/index/katyperry.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Sunday, 07 Dec 2017",
                                    Title = "Fans Can Now Witness Katy Perry On Tour Starting Winter 2017",
                                    Content = "Katy Perry is back with a new look, new sound and a new North American tour. The pop superstar will hit arenas across the USA on her Witness tour, and fans can purchase tickets for her concerts on Vivid Seats. Fans can expect plenty of eye-popping visuals and unbelievable fashion moments when Perry hits the stage. In addition to older hits like \"California Gurls\" and \"I Kissed a Girl,\" Perry will perform her newest hits like \"Chained to the Rhythm.\" Perry has collaborated with artists like Kanye West, Migos, and Skip Marley, so there\'s a definite possibility some surprise guests could show up for cameos. ",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "21:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Ed Sheeran",
                                    Image = "../../Content/images/index/ed.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Monday, 08 Dec 2017",
                                    Title = "Ed Sheeran Tour 2017",
                                    Content = "ED SHEERAN TOUR 2017Global superstar Ed Sheeran will make his triumphant return to the North American tour circuit this summer for the first time since 2015. Like his last venture, he’ll be touring in support of new music, his third studio album, “÷,” otherwise known as “Divide.”\r\n\r\nUpon the release of “÷,” the album peaked at No. 1 on the charts and has spawned the equally popular singles “Shape of You,” “Castle on the Hill,” and “Galway Girl.”\r\n\r\nSheeran will tour extensively overseas before making his way to Kansas City, Mo., on June 29 for the start of the North American trek that will feature support from James Blunt.\r\n\r\nThe Divide Tour will visit a wide variety of indoor arenas throughout the venture, ultimately wrapping up in the fall with a two-night stint at Bridgestone Arena in Nashville",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "21:00 PM"
                                },
                            },

                        },

                        new Category()
                        {
                            Name = "Pop",
                            Image = "../../Content/images/concerts/Pop.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Bruno Mars",
                                    Image = "../../Content/images/index/BrunoMars.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Friday, 11 Dec 2017",
                                    Title = "Bruno Mars to Support Latest Album with Worldwide Tour 2017",
                                    Content = "Though he’s kept busy with various guest spots, Bruno Mars fans had been waiting since 2012 for a fresh album from the charismatic star, and on Nov. 18, he delivered. As usual, a massive world trek also has been plotted, giving Bruno Mars faithful plenty of opportunities to catch a live performance during the 24k Magic Tour. International cities are first up on the docket, while the opening North American Bruno Mars show will take place on July 15 in Las Vegas. The GRAMMY winner will be on the road until at least mid-November, visiting major indoor arenas in Portland, Detroit, Chicago, Toronto, New York, Brooklyn, Boston, Miami, New Orleans, and many more along the way.\r\nWith his first two Platinum-selling albums in tow, expect to hear plenty of classic Bruno Mars hits during the trek, in addition of course to fresh tracks like “24k Magic,” “Chunky,” and “Versace on the Floor” from his latest effort. The massively popular “Uptown Funk” also is one to keep an eye out for, as it was released after the conclusion of his previous tour, so for many fans, it will be the first chance to hear it performed live.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "22:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Depeche Mode",
                                    Image = "../../Content/images/index/depechemode.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Saturday, 12 Dec 2017",
                                    Title = "DM TO HEADLINE TINDERBOX FESTIVAL!",
                                    Content = "Re-TROS, Pumarosa, EMA, and Blackline to Join Depeche Mode Throughout the Winter\r\nDepeche Mode are excited to announce the support acts for their forthcoming winter European Global Spirit Tour dates. Support duties on the four-month run will be split between four acts: Re-TROS, Pumarosa, EMA, and Blackline.  \r\n\r\n \r\n\r\nFollowing an enormous summer European stadium run, Depeche Mode is currently selling out arenas and amphitheaters acrossNorth America, including a record breaking four consecutive shows at the world-famous Hollywood Bowl. After the North American tour, the band will bring the Global Spirit Tour back to Europe for two separate runs, before and after the New Year.  ",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "22:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Lepa Brena",
                                    Image = "../../Content/images/index/LepaBrena.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Sunday, 13 Dec 2017",
                                    Title = "DM TO HEADLINE TINDERBOX FESTIVAL!",
                                    Content = "Legend of the Serbian musical scene Lepa Brenna will conquer the native audience with the BEST OF concert in Arena Armeec. The large-scale event for which the most popular and beloved South Star prepares a special surprise for everyone present in the hall will be on December 18th. The tickets for the unique show, to which Brenna will fulfill all the favorite hits of generations of Bulgarians, are on sale today and are priced from 20 to 55 leva.\r\n\r\n \r\n\r\nThe singer, who in the 1990s gathered more than 100,000 people at the National Stadium \"Vasil Levski\" in a historical concert, is now returning more luminous and inspired than ever to deliver her infectious energy to the audience in the biggest us. The legendary hits \"Ti si moj greh\", \"Luda ​​za tobom\", \"Jugoslovenka\", \"Bosanac\", \"Mače moje\", \"Ja nemam drugi dom\" will ring again to lift the numerous fans of one of the most famous, the big stars of Balkan music.\r\n\r\n \r\n\r\nBesides favorite songs, it is expected that the Serbian mega-star will perform for the first time in Bulgaria songs from the new album, which is expected to be released soon. Lepa Brenna, who has been on top for 35 years, promises her show at Arena Armeec to be larger, impressive and memorable than ever.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Lara Fabian",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Saturday, 21 Dec 2017",
                                    Title = "LARA FABIAN returns to Sofia to present a new album",
                                    Content = "Lara Fabian\'s long-awaited new album \"CAMOUFLAGE\" is almost ready and is expected to come out in the autumn of 2017, and also to star the world tour of the star singing Je T\'aime, Je suis Malade, Adagio and many others. In Sofia, Lara Fabian will arrive on 27 March 2018, where in Hall 1 of the National Palace of Culture will present her biggest hits and songs from her new album.\r\n\r\nTickets go on sale from May 12, and the singer has prepared several surprises for her faithful Bulgarian audience. The first 100 tickets are at a promotional price and everybody who bought a ticket to the concert will receive the album \'CAMOUFLAGE\' shortly before the concert on March 27, personally by Lara Fabian\'s team.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "21:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Lady Gaga",
                                    Image = "../../Content/images/index/gaga.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Saturday, 21 Dec 2017",
                                    Title = "Lady Gaga Ticket Information",
                                    Content = "Since Lady Gaga made her debut with 2008’s “The Fame,” the music industry has never been the same. Over the years Lady Gaga has built her legacy with a number of anthemic hits and heartfelt ballads, and albums like “Born This Way” and “Cheek to Cheek” have highlighted the brilliance and versatility of this award-winning pop artist. Notorious for her outlandish theatrics, Lady Gaga live performances have impressed audiences around the world through celebrated, highly original tours--like The Monster Ball and Born This Way Ball--and have given fans the chance to see her signature costumes and creative set designs in an intimate setting.\r\n\r\nBrowse our selection of Lady Gaga tickets and find the best seats to see her latest exciting concert venture in person. Armed with her latest pop hits as well as established favorites like “Poker Face” and “Bad Romance,” as well as new songs from her most recent album Joanne, the Lady Gaga tour promises an incredible live show for fans of this GRAMMY-winning entertainer. If you have any questions about shopping for Lady Gaga concert tickets in our marketplace, you can get in touch with a Vivid Seats agent on Live Chat or by calling 866.848.8499. Otherwise, find your ideal Lady Gaga tour tickets for an upcoming show by following the three steps shown below.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Rag'N'Bone Man",
                                    Image = "../../Content/images/index/RagNBone.jpg",
                                    Location = "Arena Armeec",
                                    DateDetails = "Sunday, 22 Dec 2017",
                                    Title = "What's Rag'n'Bone Man's background?",
                                    Content = "Rag\'n\'Bone Man, or Rags, was born Rory Graham in Uckfield, East Sussex, on January 29, 1985.\r\n\r\nHis family later moved to Brighton, where he\'s still based.\r\n\r\nRags says a love of music was instilled in him from a young age, as his parents were big fans of grassroots records and his dad played guitar.\r\n\r\nHowever it wasn\'t until he discovered hip hop in his late teens that he got excited about the prospect of making music himself.\r\n\r\nHe told The Sun: “[Hip hop] really sparked my imagination in my late teens — stuff like Outkast, De La Soul and Pharoahe Monch.\r\n\r\n\"One of my mates used to make me mix tapes.\r\n\r\n“Where I grew up there was only one CD shop and I didn’t really like school, so we’d register, then bunk off, and we would be round my mate’s house making drum-and-bass mix tapes.”\r\n\r\nEventually he started playing guitar and going to jam sessions, singing old blues and soul tunes, before he started writing his own songs.\r\n\r\nHe self-released a vocal EP called Blues Towns, and his girlfriend, Beth, sent promoters clips of him singing — some of them recorded on the toilet.\r\n\r\nSoon he was getting booked for acoustics shows, including a gig supporting Joan Armatrading.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:00 PM"
                                },
                            },
                        },

                        new Category()
                        {
                            Name = "Jazz",
                            Image = "../../Content/images/concerts/Jazz.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Scott Bradlee's Postmodern Jukebox",
                                    Image = "../../Content/images/index/Scott.jpg",
                                    Location = "National Palace of Culture, Hall 1",
                                    DateDetails = "Sunday, 15 May 2018",
                                    Title = "Scott Bradlee's Postmodern Jukebox",
                                    Content = "As jazz spread around the world, it drew on different national, regional, and local musical cultures, which gave rise to many distinctive styles. New Orleans jazz began in the early 1910s, combining earlier brass-band marches, French quadrilles, biguine, ragtime and blues with collective polyphonic improvisation. In the 1930s, heavily arranged dance-oriented swing big bands, Kansas City jazz, a hard-swinging, bluesy, improvisational style and Gypsy jazz (a style that emphasized musette waltzes) were the prominent styles. Bebop emerged in the 1940s, shifting jazz from danceable popular music toward a more challenging \"musician\'s music\" which was played at faster tempos and used more chord-based improvisation. Cool jazz developed in the end of the 1940s, introducing calmer, smoother sounds and long, linear melodic lines.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:00 PM"

                                },

                                new Event()
                                {
                                    Name = "North Sea Jazz Festival",
                                    Image = "../../Content/images/index/NSJ.jpg",
                                    Location = "Port of Rotterdam",
                                    DateDetails = "Saturday, 13 Jul 2018",
                                    Title = "North Sea Jazz Festival",
                                    Content = "As jazz spread around the world, it drew on different national, regional, and local musical cultures, which gave rise to many distinctive styles. New Orleans jazz began in the early 1910s, combining earlier brass-band marches, French quadrilles, biguine, ragtime and blues with collective polyphonic improvisation. In the 1930s, heavily arranged dance-oriented swing big bands, Kansas City jazz, a hard-swinging, bluesy, improvisational style and Gypsy jazz (a style that emphasized musette waltzes) were the prominent styles. Bebop emerged in the 1940s, shifting jazz from danceable popular music toward a more challenging \"musician\'s music\" which was played at faster tempos and used more chord-based improvisation. Cool jazz developed in the end of the 1940s, introducing calmer, smoother sounds and long, linear melodic lines.",
                                    CityCountry = "Port of Rotterdam",
                                    Hour = "20:00 PM"
                                },
                            },
                        },
                        new Category()
                        {
                            Name = "Hard & Heavy",
                            Image = "../../Content/images/concerts/Heavy.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Metallica",
                                    Image = "../../Content/images/index/metallica.jpg",
                                    Location = "Budapest Hall 1",
                                    DateDetails = "Sunday, 05 Apr 2018",
                                    Title = "Metallica tour 2018",
                                    Content = "Biography\r\nBrian Hugh Warner, better known as Marliyn Manson is an American musician, songwriter and multimedia artist from Ohio who has worked in fields including music, film and art.\r\n\r\nManson\'s first exposure to the music industry came whilst he was studying a journalism degree at Broward Community College in Florida, to gain experience he got a job working for 25th Parallel Magazine. He met several musicians including Nine Inch Nails, The Perfect and Trent Reznor who went on to inspire his own musical stylings in the future. Manson began to make music with guitarist Scott Putesky under the name Marilyn Manson & The Spooky Kids, they later shortened it to just Marilyn Manson and continued to create demos and play small gigs.\r\n\r\nIn 1993, the band won the attention of Trent Reznor who agreed to release their first album on his label \'Portrait Of An American Family\', it was not a commercial success at the time but has now sold over 600,000 copies in the US. This album gained the band a cult following when they toured it around the States. The follow up EP Smells Like Children and their first MTV hit in the form of a cover of Eurythmics \'Sweet Dreams (Are Made Of This)\' increased their fan base dramatically ahead of their second album release. \'Antichrist Superstar\' has sold over seven million copies worldwide to date and became the turning point in the band\'s career, the combination of Manson as an eccentric frontman and the warped lyrics found in their discography turned their live shows into a cult phenomena which toured all over the world.",
                                    CityCountry = "Budapest / Hungary",
                                    Hour = "21:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Merilyn Menson",
                                    Image = "../../Content/images/index/manson.jpg",
                                    Location = "Zenith, Die Kulturhalle",
                                    DateDetails = "Sunday, 18 Nov 2017",
                                    Title = "Merilyn Menson 2018",
                                    Content = "Biography\r\nBrian Hugh Warner, better known as Marliyn Manson is an American musician, songwriter and multimedia artist from Ohio who has worked in fields including music, film and art.\r\n\r\nManson\'s first exposure to the music industry came whilst he was studying a journalism degree at Broward Community College in Florida, to gain experience he got a job working for 25th Parallel Magazine. He met several musicians including Nine Inch Nails, The Perfect and Trent Reznor who went on to inspire his own musical stylings in the future. Manson began to make music with guitarist Scott Putesky under the name Marilyn Manson & The Spooky Kids, they later shortened it to just Marilyn Manson and continued to create demos and play small gigs.\r\n\r\nIn 1993, the band won the attention of Trent Reznor who agreed to release their first album on his label \'Portrait Of An American Family\', it was not a commercial success at the time but has now sold over 600,000 copies in the US. This album gained the band a cult following when they toured it around the States. The follow up EP Smells Like Children and their first MTV hit in the form of a cover of Eurythmics \'Sweet Dreams (Are Made Of This)\' increased their fan base dramatically ahead of their second album release. \'Antichrist Superstar\' has sold over seven million copies worldwide to date and became the turning point in the band\'s career, the combination of Manson as an eccentric frontman and the warped lyrics found in their discography turned their live shows into a cult phenomena which toured all over the world.",
                                    CityCountry = "Munich / Germany",
                                    Hour = "21:00 PM"
                                },
                            },
                        },

                        new Category()
                        {
                            Name = "Hip-Hop",
                            Image = "../../Content/images/concerts/Hip-Hop.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Jay-Z and Beyonce",
                                    Image = "../../Content/images/index/jayz.png",
                                    Location = "Bridgestone Arena",
                                    DateDetails = "Sunday, 15 Nov 2017",
                                    Title = "Jay-Z and Beyonce",
                                    Content = "Shawn Carter - or, as you may know him better, Jay-Z - is an American rapper and record producer. A rap superstar he\'s one of - if not THE - most successful men in rap music, selling over fifty million albums and records worldwide and achieving an incredible feat in having each of his fourteen albums (eleven solo, three collaborative) certified as platinum.\r\n\r\nBeyonce Knowles, on the other hand, is an American pop singer hailing from Houston, Texas. Starting her career as a member of R’n’B girl-group Destiny’s Child, Beyonce Knowles has proved herself to be just as successful as a solo star as she was in a group. Altogether, she\'s shifted a hearty seventy five million units of her own.\r\n\r\nTogether, they are known as one of the world’s power couples, like Kanye West and Kim Kardashian, creating a globally renowned brand out of their marriage, which has been one of the most followed relationships in the world.",
                                    CityCountry = "Nashville, TN / US",
                                    Hour = "22:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Rihanna",
                                    Image = "../../Content/images/index/rihanna.jpg",
                                    Location = "Bridgestone Arena",
                                    DateDetails = "Friday, 20 Dec 2017",
                                    Title = "Rihanna",
                                    Content = "Oops, Rihanna isn\'t currently out on tour! CLICK HERE FOR A TOUR ALERT! \r\n\r\nWe don\'t know of any Rihanna tour dates, events or tickets at the current time. If you\'d like to be kept informed when new Rihanna shows are announced, please set up a tour alert above or you can sign up for our FREE weekly tour newsletter here.",
                                    CityCountry = "Nashville, TN / US",
                                    Hour = "22:00 PM"

                                },
                            },
                        },
                        new Category()
                        {
                            Name = "Blues",
                            Image = "../../Content/images/concerts/Blues.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Adele",
                                    Image = "../../Content/images/index/Adele.jpg",
                                    Location = "Wembley Stadium",
                                    DateDetails = "Friday, 29 Jun 2018",
                                    Title = "Adele Tour 2018",
                                    Content = "Adele was born in North London, England, on May 5, 1988, eventually attending the performing arts BRIT School. Her first two albums, 19 and 21, earned her critical praise and a level of commercial success unsurpassed among her peers, with the artist selling millions of albums worldwide and winning multiple Grammys. She also received a songwriting Oscar for the James Bond track \"Skyfall.\" After becoming a mom, Adele returned to the charts in autumn 2015 with the ballad \"Hello,\" the lead single from what was dubbed her comeback album 25. In 2017, she won five Grammys for her work on 25 including album, record and song of the year for \"Hello.\"",
                                    CityCountry = "London / UK",
                                    Hour = "22:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Aretha Franklin",
                                    Image = "../../Content/images/index/aretha.png",
                                    Location = "Sony Centre for the Performing Arts",
                                    DateDetails = "Thursday, 28 Jun 2018",
                                    Title = "Aretha Franklin - Biography",
                                    Content = "Biography\r\nAretha Louise Franklin (born March 25th, 1942) is an American singer from Memphis, Tennessee. In 2008, Rolling Stone magazine named her at number one on their rundown of the 100 Greatest Singers of All Time.\r\n\r\nFranklin is indubitably one of the most iconic musical figures of the twentieth century; she’s synonymous, quite frankly, with R&B, soul, jazz and gospel, and certainly nothing short of an American national treasure. Franklin has an overwhelming number of hugely impressive accolades to her name; she’s won no fewer than 18 Grammy Awards and has sold in excess of 75 million records. In 1987, she became the first woman ever to be inducted to the Rock and Roll Hall of Fame. Her halcyon days can probably be traced to the late sixties, when she was a staple on the U.S. charts with a flurry of now legendary singles. Her version of Otis Redding’s “Respect” probably remains her signature song all these years later - especially in terms of its wider political significance, as it became a civil rights anthem - but it faces stiff competition from the likes of “I Say a Little Prayer”, “(You Make Me Feel Like a) Natural Woman” and “Baby I Love You”. In the early seventies, she chose to move into gospel recordings, with great success; her version of “Amazing Grace” might be the seminal take on that classic song.",
                                    CityCountry = "Toronto, ON / Canada",
                                    Hour = "22:00 PM"
                                },
                            },
                        }
                    }
                },

                new AllCategory()
                {
                    Id = 2,
                    Name = "Culture",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Comedy",
                            Image = "../../Content/images/culture/Comedy.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Shakespeare after dark",
                                    Image = "../../Content/images/index/Shakespeare.png",
                                    Location = "Small City Theatre",
                                    DateDetails = "Monday, 16 Nov 2017",
                                    Title = "Shakespeare after dark",
                                    Content = "Shakespeare After Dark is the highbrow fusion of Shakespeare served with a side of improvisational mischief. In the first half, you’ll witness a scene from the Bard utterly monkey-wrenched by an utterly punch-drunk cast member leaving the rest of the cast to improvise around them. Then, stick around for the second half where the cast lays the booze aside to serve a straight up Shakespearean tragedy – based on your suggestions. With a genuinely drunken professional actor volunteering every night, no two shows are ever the same. Side-splitting, raucous, and completely interactive, Shakespeare After Dark will blow you away.\r\n\r\nShakespeare After Dark seeks to introduce a new generation of theatre-goers to the works of the Bard by reviving the raucous, interactive and vibrant nature of Elizabethan theatre with a very modern twist that only the spirit of improvisation can bring, whilst reminding them to to always enjoy Shakespeare responsibly.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "18:30 PM"
                                },

                                new Event()
                                {
                                    Name = "ComedyErrors",
                                    Image = "../../Content/images/index/Comedyerrors.jpg",
                                    Location = "Small City Theatre",
                                    DateDetails = "Friday, 23 Nov 2017",
                                    Title = "The Comedy of Errors",
                                    Content = "Summary: Act I, Scene i\r\n\r\nThe play opens in the city of Ephesus, with Solinus, the Duke of Ephesus, leading a merchant named Egeon to be executed. Egeon converses with the Duke, and we learn that he is a native of Syracuse, Ephesus\' great commercial rival. Because of strife between the two cities, any Syracusan caught in Ephesus must pay an indemnity of a thousand marks, a price that Egeon is unable to meet, or face execution. He seems resigned to his death and declares that the execution will bring an end to his \"woes.\" Curious, the Duke asks him to relate how he came to travel to Ephesus, and Egeon complies.\r\n\r\n\r\nThe merchant describes how he was born in Syracuse, and a wife, and prospered through trade with the neighboring city of Epidamnum. Eventually, however, his representative in Epidamnum died, leaving the business in disarray, and Egeon was forced to travel there to set his affairs in order. His pregnant wife went with him and gave birth to identical twin sons. At the same time, a poor woman staying in the same inn also gave birth to identical boys, and Egeon bought her newborns, intending to bring them up as slaves for his sons.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:30 PM"
                                },
                            }
                        },

                        new Category()
                        {
                            Name = "Theater",
                            Image = "../../Content/images/culture/Theatre.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Revizor",
                                    Image = "../../Content/images/index/Marius.JPG",
                                    Location = "Ivan Vazov Theatre",
                                    DateDetails = "Monday, 16 Nov 2017",
                                    Title = "Monospectacle Revizor",
                                    Content = "Gogol\'s reviewer is a heavy comedy. The play is multi-layered, followed by a number of storylines. It requires a lot of patience and focused attention from the viewer, otherwise it may seem annoying. The recreation of this wedding, which Gogol describes, is an extremely difficult task with which the director and the actors have done brilliantly. Marius once again did not cheat on his own style and moved absolutely on the plot, not missing any details. Charge yourself with a great deal of patience and focus your attention carefully to get what the show can give you.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "19:00 PM"
                                },

                                new Event()
                                {
                                    Name = "That Jazz",
                                    Image = "../../Content/images/index/thatJazz.jpg",
                                    Location = "Ivan Vazov Theatre",
                                    DateDetails = "Wednesday, 22 Nov 2017",
                                    Title = "That Jazz",
                                    Content = "That Jazz is a 1979 American musical drama film directed by Bob Fosse. The screenplay by Robert Alan Aurthur and Fosse is a semi-autobiographical fantasy based on aspects of Fosse\'s life and career as dancer, choreographer and director. The film was inspired by Fosse\'s manic effort to edit his film Lenny while simultaneously staging the 1975 Broadway musical Chicago. It borrows its title from the Kander and Ebb tune \"All That Jazz\" in that production. The film won the Palme d\'Or at the 1980 Cannes Film Festival.\r\n\r\nIn 2001, All That Jazz was deemed \"culturally, historically, or aesthetically significant\" by the United States Library of Congress and selected for preservation in the National Film Registry",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "18:00 PM"
                                },
                            }
                        },
                          new Category()
                        {
                            Name = "Ballet",
                            Image = "../../Content/images/culture/Balet.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Swan Lake",
                                    Image = "../../Content/images/index/swanLake.jpg",
                                    Location = "Sofia Opera and Ballet",
                                    DateDetails = "Friday, 01 Dec 2017",
                                    Title = "Swan Lake - Tchaikovsky",
                                    Content = "The story of Swan Lake is woven around two girls, Odette and Odile, who resemble each other so closely they can easily be mistaken for the other. Originally their roles were entrusted to two separate dancers, but as there is only one brief fleeting moment when they are seen simultaneously, it has long been customary for a single prima ballerina to perform both parts, differentiating them by characterisation and general style. The action takes place in Germany in the distant past.\r\n\r\nAct I\r\n\r\nAfter a glittering musical introduction, the first scene is set in a splendid park, with a fairy-tale castle in the background. Prince Seigfried and his friends are seated, drinking, and peasants enter to congratulate him on his coming of age; meanwhile, his tutor Wolfgang encourages them to dance for the young Prince\'s entertainment.\r\n\r\nA messanger presages the arrival of the young Prince\'s Mother. She follows to pronounce that her son should now marry, choosing a bride from the young women to be presented to him at a ball the following evening. She leaves and the rustic dancing resumes until darkness suddenly falls and a flock of swans appear. The Prince has an idea of shooting one of the noble birds and, armed with a crossbow, sets off with his friends and heads to where the swans are heading.\r\n\r\nAct II\r\n\r\nBy the banks of a lake by moonlight, a flight of swans glide past, led by their own Queen. The Prince\'s friends are eager for the chase, but he begs them to leave him, and whilst he is alone the Swan Queen comes to him in the human form of Odette and tells her story.\r\n\r\nShe is under the spell of an evil magician, Von Rothbart, and reveals that by day she and her friends are turned into swans. Also persecuted by her stepmother, that subjection will only end when she marries; until then she has only her crown to protect her.\r\n\r\nThe whole swan group arrives and they reproach the Prince for attempting to deprive them of their beloved leader. Odette intercedes and the Prince discards his crossbow. He and Odette dance, professing their love. The entire flock joins in; and the act ends as an owl (the wicked stepmother) flaps heavily above.\r\n\r\nAct III\r\n\r\nIt is the following evening and in a luxurious hall in the Prince\'s castle preparations are underway for the feast. Wolfgang orders the servants around; guests start to materialise; and finally, the Princess-Mother and her entourage. A sequence of turns commences until the Princess asks her son which of the women he favours. \'None\', he replies to her annoyance.\r\n\r\nAt a sudden fanfare Baron Rothbart enters with his daughter Odile, whose resemblance to Odette strikes the Prince. Odile herself dances enticingly, followed by an elaborate sequence of national dances by the company. The Princess-Mother is pleased to see that Odile has caught her son\'s favour. The young couple themselves conjoin together and the Princess-Mother and Rothbart advance to centre-stage to announce a betrothal.\r\n\r\nWith that, the scene ominously darkens, an agitated version of the principal swan theme is heard; a window flies open noisily and through it can be seen a white swan replete with crown. Horrified, the Prince pushes Odile away and rushes out amid general confusion.\r\n\r\nAct IV\r\n\r\nThe girls, including Odette, gather around the lake. Odette is heartbroken. Prince Siegfried finds them consoling each other. He explains to Odette the trickery of Von Rothbart and she grants him her forgiveness. It isn’t long before Von Rothbart appears and tells the prince that he must honour his word and marry his daughter or both he and Odette will die. Prince Siegfried refuses. A fight follows, Odette and Siegfried die in each other’s arms. Von Rothbart’s evil spell is broken by the power of Odette and Siegfried’s love for each other and Von Rothbart is destroyed by the swans, who are released from their enslavement.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "19:00 PM"

                                },

                                new Event()
                                {
                                    Name = "Giselle",
                                    Image = "../../Content/images/index/Giselle.jpg",
                                    Location = "Sofia Opera and Ballet",
                                    DateDetails = "Friday, 01 Dec 2017",
                                    Title = "Giselle, The Story",
                                    Content = "Act 1\r\nA medieval Rhineland village where villagers assemble to dance and celebrate the wine harvest. Hilarion, a besotted gamekeeper, hopes to catch a glimpse of the beautiful Giselle.\r\n\r\nDuke Albrecht too has become enamoured with the peasant girl, Giselle, and in order to pursue her, has disguised himself as a peasant named Loys and rented a cottage opposite her house. His squire, Wilfrid, is wary of Albrecht’s plans as he is already betrothed.\r\n\r\nWhile Albrecht is entertaining Giselle, they are admonished by Hilarion, who is angered by his love rival. He tries to separate them but is sent away by Albrecht.\r\n\r\nThe villagers arrive and encourage Giselle to join in the celebration. They are soon interrupted by the arrival of Giselle’s mother, Berthe, who chastises Giselle for dancing as it threatens her weak health.\r\n\r\nBerthe reminds Giselle of the tale of the Wilis – the spectres of virgin brides who never reached their wedding day and now rise from their graves to kill any men who wander by.\r\n\r\nHunting fanfares are heard in the distance. Albrecht retreats lest his identity should be discovered by the approaching Prince and his daughter Bathilde, whom Albrecht is to marry. Meanwhile Hilarion sneaks into Albrecht’s cottage to find clues of his true identity and discovers that Loys is not a peasant but a nobleman.\r\n\r\nThe harvest festival continues and Albrecht returns to join in the celebration. Hilarion charges in, separating Giselle and Albrecht and reveals Albrecht’s true identity – he is not Loys but the Duke in disguise. Giselle refuses to believe this. To prove his point Hilarion blows a horn to summon the hunt party. They appear and Bathilde wonders at Albrecht’s strange appearance. Albrecht passes it off as a joke and takes Bathilde’s hand. In disbelief Giselle breaks the two apart and declares her love for Albrecht. Bathilde announces that she is betrothed to Albrecht.\r\n\r\nGiselle falls into a state of despair. Her emotional condition descends until a fit of madness causes her weak heart to stop beating and she dies.\r\n\r\nAct 2\r\nA dank and shrouded forest. This is where the Wilis gather. Any man caught here between midnight and dawn will be drawn under their spell and forced to dance until they die. Hilarion is lost in thought by Giselle’s grave. Suddenly, realising it is midnight, he rushes away hoping not to be ensnared by the Wilis.\r\n\r\nThe Queen of the Wilis, Myrtha, appears. She summons her ghostly consorts up into a dance. Myrtha announces the arrival of a new Wili. Giselle rises from her grave and is inaugurated. A sound is heard nearby. The Wilis hide.\r\n\r\nThe grief- and guilt-ridden Albrecht appears and kneels down at Giselle’s grave. Alone Albrecht sees the spectre of Giselle and he follows the vision. He tries to embrace her but his arms pass through her. As Giselle vanishes, Albrecht searches for her in the woods.\r\n\r\nHilarion, ensnared by the power of the Wilis, dances until exhausted and is thrown into the river where he drowns. Albrecht is now in Myrtha’s thrall. Giselle appears suddenly and sends Albrecht to her graveside. The marble cross of her headstone dispels even the malign will of the Wilis and causes Myrtha’s sceptre to break in her hand.\r\n\r\nMyrtha uses Giselle to lure Albrecht away from her grave by compelling her to dance. Albrecht is unable to resist the allure and beauty of Giselle’s dance and is tempted away from the cross. By dancing with Albrecht, Giselle attempts to prolong his ability to survive. They dance together as an expression of their love.\r\n\r\nJust as it seems Albrecht will dance himself to his grave, the first beams of the morning sun appear. Albrecht is saved. The Wilis must depart at daybreak, but so too must Giselle.\r\n\r\nGiselle slowly disappears into the dawn. Albrecht finds himself alone. Heartbroken and shamed, he realises that the true love between himself and Giselle has saved his life.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "19:00 PM"
                                },
                            }
                        },
                           new Category()
                        {
                            Name = "Opera",
                            Image = "../../Content/images/culture/Opera.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Traviata",
                                    Image = "../../Content/images/index/Traviata.jpg",
                                    Location = "Ivan Vazov Theatre",
                                    DateDetails = "Tuesday, 23 Nov 2017",
                                    Title = "Traviata",
                                    Content = "La traviata is an opera in three acts by Giuseppe Verdi set to an Italian libretto by Francesco Maria Piave. It is based on La Dame aux Camélias (1852), a play adapted from the novel by Alexandre Dumas, fils. The opera was originally titled Violetta, after the main character. It was first performed on 6 March 1853 at the La Fenice opera house in Venice.\r\n\r\nPiave and Verdi wanted to follow Dumas in giving the opera a contemporary setting, but the authorities at La Fenice insisted that it be set in the past, \"c. 1700\". It was not until the 1880s that the composer and librettist\'s original wishes were carried out and \"realistic\" productions were staged",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "18:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Boheme",
                                    Image = "../../Content/images/index/boheme.jpg",
                                    Location = "Ivan Vazov Theatre",
                                    DateDetails = "Friday, 25 Nov 2017",
                                    Title = " La Boheme",
                                    Content = "According to its title page, the libretto of La bohème is based on Henri Murger\'s novel, Scènes de la vie de bohème, a collection of vignettes portraying young bohemians living in the Latin Quarter of Paris in the 1840s. Although usually called a novel, it has no unified plot. Like the 1849 play by Murger and Théodore Barrière, the opera\'s libretto focuses on the relationship between Rodolfo and Mimì, ending with her death. Also like the play, the libretto combines two characters from the novel, Mimì and Francine, into a single Mimì character. Early in the composition stage Puccini was in dispute with the composer Leoncavallo, who said that he had offered Puccini a completed libretto and felt that Puccini should defer to him. Puccini responded that he had had no idea of Leoncavallo\'s interest and that having been working on his own version for some time, he felt that he could not oblige him by discontinuing with the opera. Leoncavallo completed his own version in which Marcello was sung by a tenor and Rodolfo by a baritone. It was unsuccessful and is now rarely performed.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "18:00 PM"
                                },
                            }
                        }
                    }
                },
                new AllCategory()
                {
                    Id = 3,
                    Name = "Sport",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Footbal",
                            Image = "../../Content/images/sport/Football.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Africa Cup of Nations",
                                    Image = "../../Content/images/index/Africa.jpg",
                                    Location = "Gabon Stadium",
                                    DateDetails = "Friday, 14 Jan 2018",
                                    Title = "Africa Cup of Nations",
                                    Content = "The Africa Cup of Nations, also known as the AFCON, officially CAN (French for Coupe d’Afrique des Nations), is the main international association football (soccer) competition in Africa.It was founded in 1957, sanctioned by the Confederation of African Football or CAF. It has been held every 2 years since 1968. Back then, there were only three participating countries—Sudan, Ethiopia and Egypt. South Africa was supposed to compete but were disqualified due to apartheid policies of their government. The first tournament was won by Egypt.\r\n\r\nIn 1992, the final tournament participants were expanded to 12. Teams were divided into four groups of three, with the top two teams going to the quarter-finals.\r\n\r\nIn 1996, South Africa hosted the 20th Africa Cup of Nations after their long ban was lifted due to their country’s apartheid. Participants were expanded to 16, into four groups.\r\n\r\nIn the cup’s history, Egypt has been the most successful. They have won 7 times, including their famous match against United Arab Republic from 1958 to 1971. Ghana won 4 titles, also Cameroon.\r\n\r\nThe 2015 event was scheduled to be held in Morocco, but they withdraw as host of the 2015 Africa Cup of Nations because of fears it would lead to a further spread of the Ebola virus. The host country became Equatorial Guinea.\r\n\r\nUpcoming Tournaments\r\n\r\nThe African Cup was switched to odd number years so it will not clash with the FIFA World Cup. This switch only happened in 2013.\r\n\r\nThe next event scheduled was to be held:\r\n\r\n2017 Gabon\r\n2019 Cameroon\r\n2021 Ivory Coast\r\n2023 Guinea",
                                    CityCountry = "Gabon / Africa",
                                    Hour = "20:00 PM"
                                },

                                new Event()
                                {
                                    Name = "FA Cup Final",
                                    Image = "../../Content/images/index/FACup.jpg",
                                    Location = "Wembley Stadium",
                                    DateDetails = "Monday, 14 May 2018",
                                    Title = "Africa Cup of Nations",
                                    Content = "The FA Cup is a culmination between teams belonging to the Football Association in England.\r\n\r\nScottish and Irish teams competed in the early years. Welsh teams frequently take part in the competition. A team from Wales won the 1927 Cup and reached the final in 2008.\r\n\r\nFrom the beginning of the Cup until 1993, when a match finished in a draw, they would replay the match up to a total of six times. In 1993, the Football Association then decided that future finals will be decided on the spot, on that day, putting the Cup Final replays to an end. A draw at the end of normal time will be followed by two 15-minute extra times. If the scores are still on the same level, a penalty shootout settles which team will be victors of the Cup Final.\r\n\r\nMore FA Cup Information\r\n\r\nFA Cup Winners List\r\nFA Cup Venues\r\nFA Cup Trivia",
                                    CityCountry = "London / England",
                                    Hour = "20:00 PM"
                                },
                            }
                        },

                        new Category()
                        {
                            Name = "Tennis",
                            Image = "../../Content/images/sport/Tennis.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Australian Open",
                                    Image = "../../Content/images/index/AustralianOpen.jpg",
                                    Location = "Melbourne Stadium",
                                    DateDetails = "Monday, 16 Jan 2018",
                                    Title = "AUstralian Open",
                                    Content = "The Australian Open is played in the middle of summer time, so often hot days are forecast for this event. The Australian Open Heat Policy may have to come into effect.\r\n\r\nSurfaces\r\n\r\nFor the 2008 event, a new court surface was laid down, changing from theSynpave Rebound Ace, a hardcourt surface composed of polyurethane and synthetic rubber that has been used for the previous few years, to courts made from plexicushion (see more about court surfaces).\r\n\r\nThe court color has also changed from green to blue. The new courts are believed to be faster than previous, but they would still be slower than the court surfaces used at Wimbledon and the US Open. The new surface would also be more durable under heat stress.\r\n\r\nAustralian Open Tennis CourtMore Information\r\n\r\nSee the Lists of the Australian Open Winners\r\nAustralian Open Trivia & History\r\nHeat Policy at the Australian Open.\r\nTicketing Information",
                                    CityCountry = "Melbourne / Australia",
                                    Hour = "20:00 PM"
                                },

                                new Event()
                                {
                                    Name = "French Open",
                                    Image = "../../Content/images/index/FrenchOpen.jpg",
                                    Location = "Paris Stadium",
                                    DateDetails = "Friday, 28 May 2018",
                                    Title = "French Open",
                                    Content = "The French Open (known also as the Tournoi de Roland-Garros) is one of the four Grand Slam Tennis events. A French tournament has been held since 1891 for men and 1897 for women, though up until 1925 entry to the event was restricted to members of French clubs. The tournament became an Open Championship in 1968, though it was closed to contract professionals in 1972.",
                                    CityCountry = "Paris / France",
                                    Hour = "20:00 PM"
                                },
                            }
                        },
                          new Category()
                        {
                            Name = "Other sport events",
                            Image = "../../Content/images/sport/Drugi.png",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Extreme Sports",
                                    Image = "../../Content/images/index/winterX.jpg",
                                    Location = "Aspen",
                                    DateDetails = "Friday, 2 Jan 2018",
                                    Title = "Winter X Games 21",
                                    Content = "Held simultaneously to the X Games is the X Fest which is a sports and music festival that offers live music, autograph sessions and interactive elements.\r\n\r\nThe X Games gained big media exposures due to their big sponsors, top-tier athletes and regular sport fan attendance.\r\n\r\nThe X Games frequently features new tricks like Tony Hawk’s 900 in skateboarding, Travis Pastrana’s double backflip in freestyle motocross, Health Frisby’s first ever snowmobile front flip in Snowmobile Best Trick and Torstein Horgmo’s first landed triple flip in a snowboard competition.",
                                    CityCountry = "Aspen, Colorado / USA",
                                    Hour = "10:00 AM"
                                },

                                new Event()
                                {
                                    Name = "Horse Racing",
                                    Image = "../../Content/images/index/HorseRacing.jpg",
                                    Location = "Louisville",
                                    DateDetails = "Saturday, 8 Apr 2018",
                                    Title = "Grand National",
                                    Content = "Held simultaneously to the X Games is the X Fest which is a sports and music festival that offers live music, autograph sessions and interactive elements.\r\n\r\nThe X Games gained big media exposures due to their big sponsors, top-tier athletes and regular sport fan attendance.\r\n\r\nThe X Games frequently features new tricks like Tony Hawk’s 900 in skateboarding, Travis Pastrana’s double backflip in freestyle motocross, Health Frisby’s first ever snowmobile front flip in Snowmobile Best Trick and Torstein Horgmo’s first landed triple flip in a snowboard competition.",
                                    CityCountry = "Louisville, Kentucky / USA",
                                    Hour = "10:00 AM"
                                },
                            }
                        },
                        
                    }
                },
                new AllCategory()
                {
                    Id = 4,
                    Name = "Other Events",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Exposition",
                            Image = "../../Content/images/others/izlojbi.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Dechko Uzunov",
                                    Image = "../../Content/images/index/DechkoUzunov.jpg",
                                    Location = "Sofia Gallery",
                                    DateDetails = "Friday, 5 Jan 2018",
                                    Title = "Dechko Uzunov Collection",
                                    Content = "After Atanas Yaranov and Vasil Barakov, Boyan Radev takes out from his collection the paintings by Dechko Uzunov to share them with us.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "12:00 AM"
                                },

                                new Event()
                                {
                                    Name = "Snejina Biserova",
                                    Image = "../../Content/images/index/SnejinaBiserova.jpg",
                                    Location = "Sofia Gallery",
                                    DateDetails = "Monday, 8 Nov 2017",
                                    Title = "Snejina Biserova Collection",
                                    Content = "Dr. Snezhina Biserova and a dozen of her students from the High School of Fine Art show us artworks in every graphics technique.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "12:00 AM"
                                },
                            }
                        },

                        new Category()
                        {
                            Name = "Moovie",
                            Image = "../../Content/images/others/kino.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Avatar2",
                                    Image = "../../Content/images/index/Avatar2.jpg",
                                    Location = "Serdica Mall",
                                    DateDetails = "Monday, 14 Feb 2018",
                                    Title = "Avatar - 2 Part",
                                    Content = "When his brother is killed in a robbery, paraplegic Marine Jake Sully decides to take his place in a mission on the distant world of Pandora. There he learns of greedy corporate figurehead Parker Selfridge\'s intentions of driving off the native humanoid \"Na\'vi\" in order to mine for the precious material scattered throughout their rich woodland. In exchange for the spinal surgery that will fix his legs, Jake gathers intel for the cooperating military unit spearheaded by gung-ho Colonel Quaritch, while simultaneously attempting to infiltrate the Na\'vi people with the use of an \"avatar\" identity. While Jake begins to bond with the native tribe and quickly falls in love with the beautiful alien Neytiri, the restless Colonel moves forward with his ruthless extermination tactics, forcing the soldier to take a stand - and fight back in an epic battle for the fate of Pandora.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "18:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Aquaman",
                                    Image = "../../Content/images/index/Aquaman.jpg",
                                    Location = "Serdica Mall",
                                    DateDetails = "Monday, 10 Mar 2018",
                                    Title = "Aquaman - Plot",
                                    Content = "Arthur Curry learns that he is the heir to the underwater kingdom of Atlantis, and must step forward to lead his people and to be a hero to the world.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "20:00 PM"
                                },
                            }
                        },
                          new Category()
                        {
                            Name = "Night club",
                            Image = "../../Content/images/others/night-club.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "All Eyez on you: Bumbo & Jana",
                                    Image = "../../Content/images/index/Carrusel.jpg",
                                    Location = "Carrusel Club",
                                    DateDetails = "Friday, 16 Nov 2018",
                                    Title = "All Eyez on you: Bumbo & Jana",
                                    Content = "A hot spot on the party circuit of Sofia with various music events featuring both Bulgarian and foreign artists in all styles and genres. The two halls are spacious with good acoustics and the bar staff are young and friendly.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "23:00 PM"
                                },

                                new Event()
                                {
                                    Name = "Roller Bounce",
                                    Image = "../../Content/images/index/Studio5.jpg",
                                    Location = "Studio 5",
                                    DateDetails = "Friday, 16 Nov 2018",
                                    Title = "Roller Bounce",
                                    Content = "A hot spot on the party circuit of Sofia with various music events featuring both Bulgarian and foreign artists in all styles and genres. The two halls are spacious with good acoustics and the bar staff are young and friendly.",
                                    CityCountry = "Sofia / Bulgaria",
                                    Hour = "23:00 PM"
                                },
                            }
                        },

                    }
                });
        }
    }
}
