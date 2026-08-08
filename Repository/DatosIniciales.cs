using Domain;
using Repository.Context;

namespace Repository;

public static class DatosIniciales
{
    public static async Task CargarAsync(PremierLeagueContext context)
    {
        if (context.Equipos.Any())
            return;

        var equipos = new List<Equipo>
        {
            new Equipo(
                "Arsenal",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1886, 10, 1),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/5/53/Arsenal_FC.svg"
            ),

            new Equipo(
                "Aston Villa",
                "Club de fútbol inglés con sede en Birmingham.",
                new DateOnly(1874, 11, 21),
                "Birmingham",
                "https://upload.wikimedia.org/wikipedia/en/9/9a/Aston_Villa_FC_new_crest.svg"
            ),

            new Equipo(
                "Bournemouth",
                "Club de fútbol inglés con sede en Bournemouth.",
                new DateOnly(1899, 1, 1),
                "Bournemouth",
                "https://upload.wikimedia.org/wikipedia/en/e/e5/AFC_Bournemouth_%282013%29.svg"
            ),

            new Equipo(
                "Brentford",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1889, 10, 10),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/2/2a/Brentford_FC_crest.svg"
            ),

            new Equipo(
                "Brighton & Hove Albion",
                "Club de fútbol inglés con sede en Brighton.",
                new DateOnly(1901, 6, 24),
                "Brighton",
                "https://upload.wikimedia.org/wikipedia/en/c/c9/Brighton_%26_Hove_Albion_FC_crest.svg"
            ),

            new Equipo(
                "Chelsea",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1905, 3, 10),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/c/cc/Chelsea_FC.svg"
            ),

            new Equipo(
                "Coventry City",
                "Club de fútbol inglés con sede en Coventry.",
                new DateOnly(1883, 1, 1),
                "Coventry",
                "https://upload.wikimedia.org/wikipedia/en/6/6c/Coventry_City_FC_logo.svg"
            ),

            new Equipo(
                "Crystal Palace",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1905, 9, 10),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/a/a2/Crystal_Palace_FC_logo_%282022%29.svg"
            ),

            new Equipo(
                "Everton",
                "Club de fútbol inglés con sede en Liverpool.",
                new DateOnly(1878, 1, 1),
                "Liverpool",
                "https://upload.wikimedia.org/wikipedia/en/7/7c/Everton_FC_logo.svg"
            ),

            new Equipo(
                "Fulham",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1879, 1, 1),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/e/e1/Fulham_FC_%28logo%29.svg"
            ),

            new Equipo(
                "Hull City",
                "Club de fútbol inglés con sede en Hull.",
                new DateOnly(1904, 1, 1),
                "Hull",
                "https://upload.wikimedia.org/wikipedia/en/5/54/Hull_City_A.F.C._logo.svg"
            ),

            new Equipo(
                "Ipswich Town",
                "Club de fútbol inglés con sede en Ipswich.",
                new DateOnly(1878, 1, 1),
                "Ipswich",
                "https://upload.wikimedia.org/wikipedia/en/4/43/Ipswich_Town.svg"
            ),

            new Equipo(
                "Leeds United",
                "Club de fútbol inglés con sede en Leeds.",
                new DateOnly(1919, 10, 17),
                "Leeds",
                "https://upload.wikimedia.org/wikipedia/en/0/0e/Leeds_United_F.C._logo.svg"
            ),

            new Equipo(
                "Liverpool",
                "Club de fútbol inglés con sede en Liverpool.",
                new DateOnly(1892, 6, 3),
                "Liverpool",
                "https://upload.wikimedia.org/wikipedia/commons/6/6f/Escudo-Liverpool.png"
            ),

            new Equipo(
                "Manchester City",
                "Club de fútbol inglés con sede en Manchester.",
                new DateOnly(1880, 1, 1),
                "Manchester",
                "https://upload.wikimedia.org/wikipedia/en/e/eb/Manchester_City_FC_badge.svg"
            ),

            new Equipo(
                "Manchester United",
                "Club de fútbol inglés con sede en Manchester.",
                new DateOnly(1878, 1, 1),
                "Manchester",
                "https://upload.wikimedia.org/wikipedia/en/7/7a/Manchester_United_FC_crest.svg"
            ),

            new Equipo(
                "Newcastle United",
                "Club de fútbol inglés con sede en Newcastle upon Tyne.",
                new DateOnly(1892, 12, 9),
                "Newcastle upon Tyne",
                "https://upload.wikimedia.org/wikipedia/en/5/56/Newcastle_United_Logo.svg"
            ),

            new Equipo(
                "Nottingham Forest",
                "Club de fútbol inglés con sede en Nottingham.",
                new DateOnly(1865, 1, 1),
                "Nottingham",
                "https://upload.wikimedia.org/wikipedia/en/4/49/Nottingham_Forest_F.C._logo.svg"
            ),

            new Equipo(
                "Sunderland",
                "Club de fútbol inglés con sede en Sunderland.",
                new DateOnly(1879, 1, 1),
                "Sunderland",
                "https://upload.wikimedia.org/wikipedia/en/7/7a/Sunderland_A.F.C._logo.svg"
            ),

            new Equipo(
                "Tottenham Hotspur",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1882, 9, 5),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/b/b4/Tottenham_Hotspur.svg"
            )
        };

        await context.Equipos.AddRangeAsync(equipos);
        await context.SaveChangesAsync();
    }
}

