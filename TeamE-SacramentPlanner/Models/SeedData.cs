using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using TeamE_SacramentPlanner.Data;

namespace TeamE_SacramentPlanner.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TeamE_SacramentPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TeamE_SacramentPlannerContext>>()))
            {
                // Look for any entries.
                if (context.MeetingProgram.Any())
                {
                    return;   // DB has been seeded
                }

                context.MeetingProgram.AddRange(
                    new MeetingProgram
                    {
                        MeetingDate = DateTime.Parse("2020-11-8"),
                        Presiding = "Bishop Quinn Kofford",
                        Conducting = "Brother Russell Liston",
                        OpHymnName = "Now Let Us Rejoice",
                        OpHymnNumber = 3,
                        Invocation = "Sister Rachel Brown",
                        SHymnName = "In Humility, Our Savior",
                        SHymnNumber = 172,
                        MusicalNumber = "Ward Choir",
                        ClHymnName = "Lord, I Would Follow Thee",
                        ClHymnNumber = 220,
                        Benediction = "Brother Jeff Brown"
                    },

                    new MeetingProgram
                    {
                        MeetingDate = DateTime.Parse("2020-11-15"),
                        Presiding = "Bishop Quinn Kofford",
                        Conducting = "Brother Russell Liston",
                        OpHymnName = "High on the Mountain Top",
                        OpHymnNumber = 5,
                        Invocation = "Sister Abby Porter",
                        SHymnName = "In Remembrance of Thy Suffering",
                        SHymnNumber = 183,
                        MusicalNumber = null,
                        ClHymnName = "Because I Have Been Given Much",
                        ClHymnNumber = 219,
                        Benediction = "Brother Doug Porter"
                    },

                    new MeetingProgram
                    {
                        MeetingDate = DateTime.Parse("2020-11-22"),
                        Presiding = "Bishop Quinn Kofford",
                        Conducting = "Brother James Bell",
                        OpHymnName = "How Firm a Foundation",
                        OpHymnNumber = 85,
                        Invocation = "Sister Linda Carlton",
                        SHymnName = "While of These Emblems We Partake",
                        SHymnNumber = 173,
                        MusicalNumber = null,
                        ClHymnName = "I Know That My Redeemer Lives",
                        ClHymnNumber = 136,
                        Benediction = "Brother John Carlton"
                    },

                    new MeetingProgram
                    {
                        MeetingDate = DateTime.Parse("2020-11-29"),
                        Presiding = "Bishop Quinn Kofford",
                        Conducting = "Brother James Bell",
                        OpHymnName = "We Thank Thee, O God, for a Prophet",
                        OpHymnNumber = 19,
                        Invocation = "Sister Robin Brooks",
                        SHymnName = "God, Our Father, Hear Us Pray",
                        SHymnNumber = 170,
                        MusicalNumber = "Youth Choir",
                        ClHymnName = "Sing We Now at Parting",
                        ClHymnNumber = 156,
                        Benediction = "Brother Adam Brooks"
                    }
                );

                context.Speaker.AddRange(
                    new Speaker
                    {
                        ID = 1,
                        MeetingID = 1,
                        SpeakerName = "Brother Ian Van Ry",
                        SpeakerType = "Youth Speaker"
                    },

                    new Speaker
                    {
                        ID = 2,
                        MeetingID = 1,
                        SpeakerName = "Sister Damita Van Ry",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 3,
                        MeetingID = 1,
                        SpeakerName = "Brother Chris Van Ry",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 4,
                        MeetingID = 2,
                        SpeakerName = "Sister Elizabeth Payne",
                        SpeakerType = "Youth Speaker"
                    },

                    new Speaker
                    {
                        ID = 5,
                        MeetingID = 2,
                        SpeakerName = "Sister Julie Payne",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 6,
                        MeetingID = 2,
                        SpeakerName = "Brother Tom Payne",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 7,
                        MeetingID = 3,
                        SpeakerName = "Brother Aiden Bigler",
                        SpeakerType = "Youth Speaker"
                    },

                    new Speaker
                    {
                        ID = 8,
                        MeetingID = 3,
                        SpeakerName = "Sister Tiffany Bigler",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 9,
                        MeetingID = 3,
                        SpeakerName = "Brother Brady Bigler",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 10,
                        MeetingID = 4,
                        SpeakerName = "Sister Norah Euken",
                        SpeakerType = "Youth Speaker"
                    },

                    new Speaker
                    {
                        ID = 11,
                        MeetingID = 4,
                        SpeakerName = "Sister Nicole Euken",
                        SpeakerType = "Speaker"
                    },

                    new Speaker
                    {
                        ID = 12,
                        MeetingID = 4,
                        SpeakerName = "Brother Mike Euken",
                        SpeakerType = "Speaker"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}