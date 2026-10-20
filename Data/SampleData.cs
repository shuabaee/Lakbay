using Template.Models;
using Template.Models.Entities;

namespace Template.Data;

public static class SampleData
{
    // All editable content is model-backed; no database is needed for the lab.
    public static IReadOnlyList<Destination> Destinations { get; } = new List<Destination>
    {
        new() { Id=1, Name="El Nido", Province="Palawan", IslandGroup=IslandGroup.Luzon,
            Mood=TravelMood.Coast, ImagePath="/images/palawan.webp", ImageAlt="Turquoise lagoon and limestone cliffs with an outrigger boat",
            Tagline="Where the sea keeps secrets", Description="Kayak between limestone walls, find tiny coves and spend long afternoons chasing the color blue.",
            SignatureExperience="Island-hop through Bacuit Bay", BestTime="November to May", InsiderTip="Start your lagoon tour early. The quiet water is worth the alarm.",
            SuggestedDays=4, DailyBudgetPerPerson=3800, Featured=true, Latitude=11.20, Longitude=119.41,
            Highlights=new[] { "Kayak into the Big Lagoon at high tide", "Walk the long curve of Nacpan Beach", "Watch the sunset from Las Cabañas Beach" } },
        new() { Id=2, Name="Bohol", Province="Bohol", IslandGroup=IslandGroup.Visayas,
            Mood=TravelMood.SlowTravel, ImagePath="/images/bohol.webp", ImageAlt="Rounded Chocolate Hills rising out of a green landscape",
            Tagline="A different kind of island time", Description="The Chocolate Hills, old stone churches and an easygoing rhythm that makes the days feel longer.",
            SignatureExperience="Watch the hills change with the light", BestTime="December to May", InsiderTip="Visit the Chocolate Hills viewpoint early, before the midday heat.",
            SuggestedDays=3, DailyBudgetPerPerson=3000, Featured=true, Latitude=9.83, Longitude=124.17,
            Highlights=new[] { "The Chocolate Hills viewing deck in Carmen", "Meet the Philippine tarsier, quietly, in Corella", "Float down the Loboc River", "Step inside the coral-stone Baclayon Church" } },
        new() { Id=3, Name="Siargao", Province="Surigao del Norte", IslandGroup=IslandGroup.Mindanao,
            Mood=TravelMood.Coast, ImagePath="/images/siargao.webp", ImageAlt="A surfer riding waves beside a palm-lined Siargao coast",
            Tagline="Salt hair, no hurry", Description="An island shaped by waves, coconut roads, friendly cafés and spontaneous detours.",
            SignatureExperience="Watch the surf break at Cloud 9", BestTime="March to November", InsiderTip="Leave a day with no itinerary. Your favorite corner may be the unexpected one.",
            SuggestedDays=5, DailyBudgetPerPerson=3400, Featured=true, Latitude=9.81, Longitude=126.17,
            Highlights=new[] { "Watch the surfers from the Cloud 9 boardwalk", "Swim the Magpupungko rock pools at low tide", "Paddle through Sugba Lagoon", "Hop between Naked, Daku and Guyam islands" } },
        new() { Id=4, Name="Banaue", Province="Ifugao", IslandGroup=IslandGroup.Luzon,
            Mood=TravelMood.Nature, ImagePath="/images/banaue.webp", ImageAlt="Ancient green rice terraces cascading down Philippine highlands",
            Tagline="Stories carved into mountains", Description="Walk beside living rice terraces and learn how mountain communities shaped an extraordinary landscape.",
            SignatureExperience="Explore terraces with a local guide", BestTime="November to April", InsiderTip="Bring comfortable walking shoes and ask your guide about respectful village visits.",
            SuggestedDays=3, DailyBudgetPerPerson=2500, Latitude=16.92, Longitude=121.06,
            Highlights=new[] { "Sunrise at the Banaue viewpoint", "Hike to the Batad amphitheatre terraces", "Cool off at Tappiyah Falls" } },
        new() { Id=5, Name="Vigan", Province="Ilocos Sur", IslandGroup=IslandGroup.Luzon,
            Mood=TravelMood.Culture, ImagePath="/images/vigan.webp", ImageAlt="Vigan's cobbled street with old houses and a horse-drawn carriage",
            Tagline="A little walk through time", Description="Cobbled lanes, ancestral homes and a living heritage best experienced on foot, slowly.",
            SignatureExperience="Stroll Calle Crisologo at dusk", BestTime="December to April", InsiderTip="Visit at sunrise for softer light and fewer crowds on the old streets.",
            SuggestedDays=2, DailyBudgetPerPerson=2200, Latitude=17.57, Longitude=120.39,
            Highlights=new[] { "Walk Calle Crisologo at dusk", "Ride a kalesa through the old town", "Watch clay jars made by hand at Pagburnayan", "Catch the evening fountain show at Plaza Salcedo" } },
        new() { Id=6, Name="Kawasan Falls", Province="Cebu", IslandGroup=IslandGroup.Visayas,
            Mood=TravelMood.Nature, ImagePath="/images/cebu.webp", ImageAlt="Waterfall pouring into a clear pool surrounded by tropical jungle",
            Tagline="Take the road to the water", Description="Cool blue-green pools and lush jungle scenery in southern Cebu, made for a refreshing escape.",
            SignatureExperience="Discover the waterfalls near Badian", BestTime="January to May", InsiderTip="Check current local access rules and use accredited guides for adventure activities.",
            SuggestedDays=3, DailyBudgetPerPerson=2800, Latitude=9.81, Longitude=123.37,
            Highlights=new[] { "Swim the turquoise tiers of Kawasan Falls", "Go canyoneering with an accredited local guide", "Snorkel with the sardine run off Moalboal" } }
    };

    public static IReadOnlyList<FieldNote> Notes { get; } = new List<FieldNote>
    {
        new() { Id=1, DestinationId=5, Category=NoteCategory.Culture,
            Title="When the streets remember", Excerpt="An early walk through Vigan, before the old town fully wakes.",
            Story="In Vigan, the best way to see the historic center is to slow your stride. Notice the carved windows, cobbled lanes and homes that have held stories for generations. Heritage is not a backdrop: people still live and work here. Go gently, support local makers and let the town set the pace.",
            ImagePath="/images/vigan.webp", ImageAlt="Heritage street in Vigan", ReadMinutes=4 },
        new() { Id=2, DestinationId=2, Category=NoteCategory.LocalLife,
            Title="The art of taking it slow", Excerpt="A Bohol day that leaves room for detours and long conversations.",
            Story="You can fill every hour in Bohol, but you do not have to. See the Chocolate Hills while the air is still cool, share a leisurely lunch and leave space for a roadside stop. An unhurried day can tell you more about a place than a checklist ever will.",
            ImagePath="/images/bohol.webp", ImageAlt="Chocolate Hills at golden hour", ReadMinutes=3 },
        new() { Id=3, DestinationId=3, Category=NoteCategory.Outdoors,
            Title="Follow the tide, not the clock", Excerpt="An island rhythm measured in surf, sunshine and coconut shade.",
            Story="Siargao is famous for its waves, but there is more to explore beyond the surf. Take the coastal roads, meet neighborhood businesses and learn from local guides. Check marine conditions, respect reef habitats and save space in your plans for an unexpectedly good sunset.",
            ImagePath="/images/siargao.webp", ImageAlt="Surfing coast in Siargao", ReadMinutes=5 },
        new() { Id=4, DestinationId=4, Category=NoteCategory.Culture,
            Title="What the terraces teach us", Excerpt="A landscape cared for by generations of Ifugao communities.",
            Story="The terraces are not merely a view. They are part of a working cultural landscape connected to water, farming and community knowledge. Choose knowledgeable local guides, ask before photographing residents and remember that the trails are shared places, not just tourist paths.",
            ImagePath="/images/banaue.webp", ImageAlt="Green rice terraces of Banaue", ReadMinutes=6 },
        new() { Id=5, DestinationId=1, Category=NoteCategory.Food,
            Title="A table by the sea", Excerpt="Sea air, fresh ingredients and why meals taste better after a long swim.",
            Story="After a day on the water in Palawan, seek a small local restaurant and try the day's seafood or vegetable specialties. Ask what is seasonal and sustainably sourced. The memory worth keeping may be a simple meal, a warm welcome and salt still on your skin.",
            ImagePath="/images/palawan.webp", ImageAlt="Palawan's clear blue lagoon", ReadMinutes=3 }
    };

    public static Destination? FindDestination(int id) => Destinations.FirstOrDefault(d => d.Id == id);

    public static FieldNote? FindNote(int id) => Notes.FirstOrDefault(n => n.Id == id);

    public static decimal LowestDailyBudget => Destinations.Min(d => d.DailyBudgetPerPerson);
}
