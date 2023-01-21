using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StateParksApi.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParkId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Location = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "Description", "ImageUrl", "Location", "Name", "ParkId", "Rating" },
                values: new object[,]
                {
                    { 1, "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.", "../pdp.jpg", "Tacoma, WA", "Point Defiance Park", "TACWA-S0001", 5 },
                    { 2, "Dash Point State Park is a 398-acre Washington state park on Puget Sound that straddles the line between King and Pierce counties", "../dashpoint.jpg", "Federal Way, WA", "Dash Point State Park", "FEDWA-S0001", 4 },
                    { 3, "Kopachuck State Park is a publicly owned recreation area situated on Henderson Bay in Puget Sound, about 6 miles west of the city of Gig Harbor, Washington. The state park's 109 acres encompass over a mile of saltwater shoreline. The park provides sweeping views of sunsets, the Olympic Mountains and Puget Sound", "../kopachuck.jpg", "Gig Harbor, WA", "Kopachuck State Park", "GIGWA-S0001", 4 },
                    { 4, "Saltwater State Park is a 137 acres plot of second-growth timber on Puget Sound in the city of Des Moines, Washington, United States. The park is operated by the Washington State Parks and Recreation Commission", "../saltwater.jpg", "Des Moines, WA", "Saltwater State Park", "DESWA-S0001", 3 },
                    { 5, "Joemma Beach State Park is a 122-acre Washington state park on Puget Sound in Pierce County. The park offers 3,000 feet of saltwater shoreline on southeast Key Peninsula and opportunities for picnicking, camping, boating, fishing, waterskiing, crabbing, and beachcombing", "../joemma.jpg", "Long Beach, WA", "Joemma Beach Park", "LONWA-S0001", 4 },
                    { 6, "a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier. Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams. The park’s 5,400-ft.-high Paradise overlook offers mountain views, summertime wildflower meadows and hiking trailheads.", "../rainier.jpg", "Ashford, WA", "Mt. Rainier National Park", "ASHWA-N0001", 5 },
                    { 7, "Olympic National Park is on Washington's Olympic Peninsula in the Pacific Northwest. The park sprawls across several different ecosystems, from the dramatic peaks of the Olympic Mountains to old-growth forests. The summit of glacier-clad Mt. Olympus is popular with climbers, and hiking and backpacking trails cut through the park's rainforests and along its Pacific coastline", "../olympic.jpg", "Port Angeles, WA", "Olympic National Park", "PORWA-N0002", 4 },
                    { 8, "North Cascades National Park is in northern Washington State. It’s a vast wilderness of conifer-clad mountains, glaciers and lakes. The North Cascades Highway passes viewpoints and leads to trails such as the steep Thunder Creek Trail. Boats dot Ross Lake. The remote community of Stehekin lies at the northern tip of deep Lake Chelan. The park shelters grizzly bears and gray wolves, plus more than 200 bird species.", "../cascades.jpg", "Snohomish, WA", "North Cascades National Park", "SNOWA-N0003", 4 },
                    { 9, "Crater Lake National Park is in the Cascade Mountains of southern Oregon. It’s known for its namesake Crater Lake, formed by the now-collapsed volcano, Mount Mazama. Wizard Island is a cinder cone near the western edge of the lake. The Rim Drive, a road surrounding the lake, offers views of the park’s volcanic formations. The park’s numerous trails include Sun Notch, with views of the Phantom Ship, a small island", "../craterlake.jpg", "Oregon", "Crater Lake National Park", "OREOR-N0004", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
