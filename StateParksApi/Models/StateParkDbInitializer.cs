using Microsoft.EntityFrameworkCore;

namespace StateParksApi.Models;

public class StateParkDbInitializer 
{

  private readonly ModelBuilder modelBuilder;

  public StateParkDbInitializer(ModelBuilder modelBuilder)
  {
    this.modelBuilder = modelBuilder;
  }

  public void Seed()
  {
    modelBuilder.Entity<Park>()
      .HasData(
        new Park { Id=1, ParkId = "TACWA-S0001", Name = "Point Defiance Park", Location = "Tacoma, WA", Description = "Point Defiance Park is a 760-acre park in Tacoma, Washington, United States. It is located on the tip of the peninsula that separates Commencement Bay from Puget Sound. The park is operated by the City of Tacoma and is the largest park in the city.", ImageUrl = "../pdp.jpg", Rating = 5 },
        new Park { Id=2, ParkId = "FEDWA-S0001", Name = "Dash Point State Park", Location = "Federal Way, WA", Description = "Dash Point State Park is a 398-acre Washington state park on Puget Sound that straddles the line between King and Pierce counties", ImageUrl = "../dashpoint.jpg", Rating = 4 },
        new Park { Id=3, ParkId = "GIGWA-S0001", Name = "Kopachuck State Park", Location = "Gig Harbor, WA", Description = "Kopachuck State Park is a publicly owned recreation area situated on Henderson Bay in Puget Sound, about 6 miles west of the city of Gig Harbor, Washington. The state park's 109 acres encompass over a mile of saltwater shoreline. The park provides sweeping views of sunsets, the Olympic Mountains and Puget Sound", ImageUrl = "../kopachuck.jpg", Rating = 4 },
        new Park { Id=4, ParkId = "DESWA-S0001", Name = "Saltwater State Park", Location = "Des Moines, WA", Description = "Saltwater State Park is a 137 acres plot of second-growth timber on Puget Sound in the city of Des Moines, Washington, United States. The park is operated by the Washington State Parks and Recreation Commission", ImageUrl = "../saltwater.jpg", Rating = 3 },
        new Park { Id=5, ParkId = "LONWA-S0001", Name = "Joemma Beach Park", Location = "Long Beach, WA", Description = "Joemma Beach State Park is a 122-acre Washington state park on Puget Sound in Pierce County. The park offers 3,000 feet of saltwater shoreline on southeast Key Peninsula and opportunities for picnicking, camping, boating, fishing, waterskiing, crabbing, and beachcombing", ImageUrl = "../joemma.jpg", Rating = 4},
        new Park { Id=6, ParkId = "ASHWA-N0001", Name = "Mt. Rainier National Park", Location = "Ashford, WA", Description = "a 369-sq.-mile Washington state reserve southeast of Seattle, surrounds glacier-capped, 14,410-ft. Mount Rainier. Atop 6,400-ft.-high Sunrise, the highest point in the park reachable by car, visitors can admire Rainier and other nearby volcanoes, including Mount Adams. The park’s 5,400-ft.-high Paradise overlook offers mountain views, summertime wildflower meadows and hiking trailheads.", ImageUrl = "../rainier.jpg", Rating = 5 },
        new Park { Id=7, ParkId = "PORWA-N0002", Name = "Olympic National Park", Location = "Port Angeles, WA", Description = "Olympic National Park is on Washington's Olympic Peninsula in the Pacific Northwest. The park sprawls across several different ecosystems, from the dramatic peaks of the Olympic Mountains to old-growth forests. The summit of glacier-clad Mt. Olympus is popular with climbers, and hiking and backpacking trails cut through the park's rainforests and along its Pacific coastline", ImageUrl = "../olympic.jpg", Rating = 4 },
        new Park { Id=8, ParkId = "SNOWA-N0003", Name = "North Cascades National Park", Location = "Snohomish, WA", Description = "North Cascades National Park is in northern Washington State. It’s a vast wilderness of conifer-clad mountains, glaciers and lakes. The North Cascades Highway passes viewpoints and leads to trails such as the steep Thunder Creek Trail. Boats dot Ross Lake. The remote community of Stehekin lies at the northern tip of deep Lake Chelan. The park shelters grizzly bears and gray wolves, plus more than 200 bird species.", ImageUrl = "../cascades.jpg", Rating = 4 },
        new Park { Id=9, ParkId = "OREOR-N0004", Name = "Crater Lake National Park", Location = "Oregon", Description = "Crater Lake National Park is in the Cascade Mountains of southern Oregon. It’s known for its namesake Crater Lake, formed by the now-collapsed volcano, Mount Mazama. Wizard Island is a cinder cone near the western edge of the lake. The Rim Drive, a road surrounding the lake, offers views of the park’s volcanic formations. The park’s numerous trails include Sun Notch, with views of the Phantom Ship, a small island", ImageUrl = "../craterlake.jpg", Rating = 4 }
    );
  }

}