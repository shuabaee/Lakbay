# Lakbay: a Philippine travel field guide

Blazor Web App (.NET 8, Interactive Server) styled with Tailwind CSS v4. No database: all content comes
from model classes in `Data/SampleData.cs`.

## Setup

You need the **.NET 8 SDK** (`dotnet --version`) and **Node.js 18+** (`node --version`).

```bash
cd LakbayPhilippines
npm install          # first time only: installs the Tailwind CLI
npm run build:css    # Styles/app.css  ->  wwwroot/css/app.css
dotnet run
```

Open the address shown in the terminal (http://localhost:5xxx). A compiled `wwwroot/css/app.css` is already
included, so the site also runs with just `dotnet run`. While editing styles, run `npm run watch:css` in a
second terminal.

## Pages and interactions

| Page | What you can do |
| --- | --- |
| **Home** `/` | Flip through the postcard stack (arrows, dots, or click a card behind). Pick a travel mood to see where it lives. Save featured places. Hover the island-group rows. Drag the budget sliders to compare trip totals live. |
| **Discover** `/discover` | Search, filter by island group and mood, sort, switch Grid/List view, show saved places only. Open a place in the side drawer, and use ←/→ or Esc. Links like `/discover?region=Luzon` or `?open=3` preset the page. |
| **Field notes** `/journal` | Filter by category and open stories in a reader with previous/next. |
| **Plan a trip** `/plan` | Visual destination picker, date check with a live night count, traveler stepper, pace cards, character counter, a progress bar that fills as you go, a live budget sketch, validation, a loading state and a boarding-pass confirmation. |

The **Saved** counter in the header is shared by every page (`Services/SavedPlaces.cs`).

## Structure

```
Models/TravelTypes.cs          enums (IslandGroup, TravelMood, NoteCategory, TravelPace)
Models/TravelLabels.cs         one place for display text and peso formatting
Models/Entities/               Destination, FieldNote, TripBlueprint
Models/Forms/TripInquiry.cs    form model with DataAnnotations + IValidatableObject
Services/SavedPlaces.cs        scoped shortlist service with a Changed event
Services/Ui.cs                 small display helpers
Data/SampleData.cs             sample content built from the models
Components/Layout/             NavMenu (sticky, mobile menu, saved badge), MainLayout (footer)
Components/Pages/              Home, Discover, Journal, Plan
Components/Shared/HeartIcon    reusable SVG icon
Styles/app.css                 design tokens (@theme) + component styles
wwwroot/js/site.js             header shadow on scroll, overlay focus and scroll lock
```

Budgets are illustrative peso amounts, not booking quotes.
