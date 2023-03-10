// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StateParksApi.Models;

#nullable disable

namespace StateParksApi.Solution.Migrations
{
    [DbContext(typeof(StateParkDbContext))]
    partial class StateParkDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("StateParksApi.Models.Park", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ParkId")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.",
                            ImageUrl = "../pdp.jpg",
                            Location = "Tacoma, WA",
                            Name = "Point Defiance Park",
                            ParkId = "TACWA-S0001",
                            Rating = 5
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dash Point State Park is a 398-acre Washington state park on Puget Sound that straddles the line between King and Pierce counties",
                            ImageUrl = "../dashpoint.jpg",
                            Location = "Federal Way, WA",
                            Name = "Dash Point State Park",
                            ParkId = "FEDWA-S0001",
                            Rating = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "Kopachuck State Park is a publicly owned recreation area situated on Henderson Bay in Puget Sound, about 6 miles west of the city of Gig Harbor, Washington. The state park's 109 acres encompass over a mile of saltwater shoreline. The park provides sweeping views of sunsets, the Olympic Mountains and Puget Sound",
                            ImageUrl = "../kopachuck.jpg",
                            Location = "Gig Harbor, WA",
                            Name = "Kopachuck State Park",
                            ParkId = "GIGWA-S0001",
                            Rating = 4
                        },
                        new
                        {
                            Id = 4,
                            Description = "Saltwater State Park is a 137 acres plot of second-growth timber on Puget Sound in the city of Des Moines, Washington, United States. The park is operated by the Washington State Parks and Recreation Commission",
                            ImageUrl = "../saltwater.jpg",
                            Location = "Des Moines, WA",
                            Name = "Saltwater State Park",
                            ParkId = "DESWA-S0001",
                            Rating = 3
                        },
                        new
                        {
                            Id = 5,
                            Description = "Joemma Beach State Park is a 122-acre Washington state park on Puget Sound in Pierce County. The park offers 3,000 feet of saltwater shoreline on southeast Key Peninsula and opportunities for picnicking, camping, boating, fishing, waterskiing, crabbing, and beachcombing",
                            ImageUrl = "../joemma.jpg",
                            Location = "Long Beach, WA",
                            Name = "Joemma Beach Park",
                            ParkId = "LONWA-S0001",
                            Rating = 4
                        },
                        new
                        {
                            Id = 6,
                            Description = "a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier. Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams. The park’s 5,400-ft.-high Paradise overlook offers mountain views, summertime wildflower meadows and hiking trailheads.",
                            ImageUrl = "../rainier.jpg",
                            Location = "Ashford, WA",
                            Name = "Mt. Rainier National Park",
                            ParkId = "ASHWA-N0001",
                            Rating = 5
                        },
                        new
                        {
                            Id = 7,
                            Description = "Olympic National Park is on Washington's Olympic Peninsula in the Pacific Northwest. The park sprawls across several different ecosystems, from the dramatic peaks of the Olympic Mountains to old-growth forests. The summit of glacier-clad Mt. Olympus is popular with climbers, and hiking and backpacking trails cut through the park's rainforests and along its Pacific coastline",
                            ImageUrl = "../olympic.jpg",
                            Location = "Port Angeles, WA",
                            Name = "Olympic National Park",
                            ParkId = "PORWA-N0002",
                            Rating = 4
                        },
                        new
                        {
                            Id = 8,
                            Description = "North Cascades National Park is in northern Washington State. It’s a vast wilderness of conifer-clad mountains, glaciers and lakes. The North Cascades Highway passes viewpoints and leads to trails such as the steep Thunder Creek Trail. Boats dot Ross Lake. The remote community of Stehekin lies at the northern tip of deep Lake Chelan. The park shelters grizzly bears and gray wolves, plus more than 200 bird species.",
                            ImageUrl = "../cascades.jpg",
                            Location = "Snohomish, WA",
                            Name = "North Cascades National Park",
                            ParkId = "SNOWA-N0003",
                            Rating = 4
                        },
                        new
                        {
                            Id = 9,
                            Description = "Crater Lake National Park is in the Cascade Mountains of southern Oregon. It’s known for its namesake Crater Lake, formed by the now-collapsed volcano, Mount Mazama. Wizard Island is a cinder cone near the western edge of the lake. The Rim Drive, a road surrounding the lake, offers views of the park’s volcanic formations. The park’s numerous trails include Sun Notch, with views of the Phantom Ship, a small island",
                            ImageUrl = "../craterlake.jpg",
                            Location = "Oregon",
                            Name = "Crater Lake National Park",
                            ParkId = "OREOR-N0004",
                            Rating = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
