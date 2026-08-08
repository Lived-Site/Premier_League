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
                "/images/escudos/brighton.png"
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
                "/images/escudos/Coventry.png"
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
                "/images/escudos/fullham.png"
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
                "/images/escudos/leeds.png"
                ),

            new Equipo(
                "Liverpool",
                "Club de fútbol inglés con sede en Liverpool.",
                new DateOnly(1892, 6, 3),
                "Liverpool",
                "/images/escudos/Liverpool.png"
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
                "/images/escudos/forest.png"
            ),

            new Equipo(
                "Sunderland",
                "Club de fútbol inglés con sede en Sunderland.",
                new DateOnly(1879, 1, 1),
                "Sunderland",
                "/images/escudos/sunderland.png"
            ),

            new Equipo(
                "Tottenham Hotspur",
                "Club de fútbol inglés con sede en Londres.",
                new DateOnly(1882, 9, 5),
                "Londres",
                "https://upload.wikimedia.org/wikipedia/en/b/b4/Tottenham_Hotspur.svg"
            )
        };

        //Jugadores del Arsenal
        var arsenal = equipos[0];
        arsenal.AgregarJugador(new Jugador("David", "Raya", "España", "Portero", 1));
        arsenal.AgregarJugador(new Jugador("Kepa", "Arrizabalaga", "España", "Portero", 13));
        arsenal.AgregarJugador(new Jugador("William", "Saliba", "Francia", "Defensa", 2));
        arsenal.AgregarJugador(new Jugador("Gabriel", "Magalhães", "Brasil", "Defensa", 6));
        arsenal.AgregarJugador(new Jugador("Ben", "White", "Inglaterra", "Defensa", 4));
        arsenal.AgregarJugador(new Jugador("Cristhian", "Mosquera", "España", "Defensa", 3));
        arsenal.AgregarJugador(new Jugador("Piero", "Hincapie", "Ecuador", "Defensa", 5));
        arsenal.AgregarJugador(new Jugador("Jurriën", "Timber", "Holanda", "Defensa", 12));
        arsenal.AgregarJugador(new Jugador("Riccardo", "Calafiori", "Italia", "Defensa", 33));
        arsenal.AgregarJugador(new Jugador("Bruno", "Guimarães ", "Brasil", "Centrocampista", 39));
        arsenal.AgregarJugador(new Jugador("Declan", "Rice", "Inglaterra", "Centrocampista", 41));
        arsenal.AgregarJugador(new Jugador("Martin", "Ødegaard", "Noruega", "Centrocampista", 8));
        arsenal.AgregarJugador(new Jugador("Mikel", "Merino", "España", "Centrocampista", 23));
        arsenal.AgregarJugador(new Jugador("Martin", "Zubimendi", "España", "Centrocampista", 36));
        arsenal.AgregarJugador(new Jugador("Eberechi", "Eze", "Inglaterra", "Centrocampista", 10));
        arsenal.AgregarJugador(new Jugador("Max", "Dowman", "Inglaterra", "Centrocampista", 10));
        arsenal.AgregarJugador(new Jugador("Bukayo", "Saka", "Inglaterra", "Delantero", 7));
        arsenal.AgregarJugador(new Jugador("Gabriel", "Martinelli", "Brasil", "Delantero", 11));
        arsenal.AgregarJugador(new Jugador("Kai", "Havertz", "Alemania", "Delantero", 29));
        arsenal.AgregarJugador(new Jugador("Christos", "Tzolis", "Grecia", "Delantero", 17));
        arsenal.AgregarJugador(new Jugador("Viktor", "Gyökeres", "Suecia", "Delantero", 14));
        arsenal.AgregarJugador(new Jugador("Gabriel", "Jesus", "Brasil", "Delantero", 9));
        arsenal.AgregarJugador(new Jugador("Noni", "Madueke", "Inglaterra", "Delantero", 20));

        //Jugadores del Aston Villa
        var astonVilla = equipos[1];
        astonVilla.AgregarJugador(new Jugador("Emiliano", "Martínez", "Argentina", "Portero", 23));
        astonVilla.AgregarJugador(new Jugador("Marco", "Bizot", "Holanda", "Portero", 40));
        astonVilla.AgregarJugador(new Jugador("Matty", "Cash", "Polonia", "Defensa", 2));
        astonVilla.AgregarJugador(new Jugador("Ezri", "Konsa", "Inglaterra", "Defensa", 4));
        astonVilla.AgregarJugador(new Jugador("Pau", "Torres", "España", "Defensa", 14));
        astonVilla.AgregarJugador(new Jugador("Ian", "Maatsen", "Holanda", "Defensa", 22));
        astonVilla.AgregarJugador(new Jugador("Lucas", "Digne", "Francia", "Defensa", 12));
        astonVilla.AgregarJugador(new Jugador("Boubacar", "Kamara", "Francia", "Centrocampista", 44));
        astonVilla.AgregarJugador(new Jugador("Youri", "Tielemans", "Bélgica", "Centrocampista", 8));
        astonVilla.AgregarJugador(new Jugador("Amadou", "Onana", "Bélgica", "Centrocampista", 24));
        astonVilla.AgregarJugador(new Jugador("John", "McGinn", "Escocia", "Centrocampista", 7));
        astonVilla.AgregarJugador(new Jugador("Emiliano", "Buendía", "Argentina", "Centrocampista", 10));
        astonVilla.AgregarJugador(new Jugador("Harvey", "Elliott", "Inglaterra", "Centrocampista", 9));
        astonVilla.AgregarJugador(new Jugador("Morgan", "Rogers", "Inglaterra", "Delantero", 27));
        astonVilla.AgregarJugador(new Jugador("Ollie", "Watkins", "Inglaterra", "Delantero", 11));
        astonVilla.AgregarJugador(new Jugador("Leon", "Bailey", "Jamaica", "Delantero", 31));
        astonVilla.AgregarJugador(new Jugador("Jadon", "Sancho", "Inglaterra", "Delantero", 19));

        //Jugadores del Bournemouth
        var bournemouth = equipos[2];
        bournemouth.AgregarJugador(new Jugador("Djordje", "Petrovic", "Serbia", "Portero", 28));
        bournemouth.AgregarJugador(new Jugador("Mark", "Travers", "Irlanda", "Portero", 13));
        bournemouth.AgregarJugador(new Jugador("Adrien", "Truffert", "Francia", "Defensa", 3));
        bournemouth.AgregarJugador(new Jugador("Marcos", "Senesi", "Argentina", "Defensa", 26));
        bournemouth.AgregarJugador(new Jugador("Julian", "Araujo", "México", "Defensa", 2));
        bournemouth.AgregarJugador(new Jugador("Chris", "Mepham", "Gales", "Defensa", 7));
        bournemouth.AgregarJugador(new Jugador("Adam", "Smith", "Inglaterra", "Defensa", 16));
        bournemouth.AgregarJugador(new Jugador("Tyler", "Adams", "Estados Unidos", "Centrocampista", 12));
        bournemouth.AgregarJugador(new Jugador("Alex", "Scott", "Inglaterra", "Centrocampista", 15));
        bournemouth.AgregarJugador(new Jugador("Lewis", "Cook", "Inglaterra", "Centrocampista", 4));
        bournemouth.AgregarJugador(new Jugador("Marcus", "Tavernier", "Inglaterra", "Centrocampista", 17));
        bournemouth.AgregarJugador(new Jugador("Antoine", "Semenyo", "Ghana", "Delantero", 24));
        bournemouth.AgregarJugador(new Jugador("Evanilson", "", "Brasil", "Delantero", 9));
        bournemouth.AgregarJugador(new Jugador("Justin", "Kluivert", "Holanda", "Delantero", 19));
        bournemouth.AgregarJugador(new Jugador("Enes", "Ünal", "Turquía", "Delantero", 26));
        bournemouth.AgregarJugador(new Jugador("Amine", "Adli", "Marruecos", "Delantero", 21));
        bournemouth.AgregarJugador(new Jugador("Ben", "Gannon Doak", "Escocia", "Delantero", 11));

        //Jugadores del Brentford
        var brentford = equipos[3];
        brentford.AgregarJugador(new Jugador("Caoimhín", "Kelleher", "Irlanda", "Portero", 1));
        brentford.AgregarJugador(new Jugador("Hákon Rafn", "Valdimarsson", "Islandia", "Portero", 12));
        brentford.AgregarJugador(new Jugador("Nathan", "Collins", "Irlanda", "Defensa", 22));
        brentford.AgregarJugador(new Jugador("Sepp", "van den Berg", "Holanda", "Defensa", 27));
        brentford.AgregarJugador(new Jugador("Michael", "Kayode", "Italia", "Defensa", 2));
        brentford.AgregarJugador(new Jugador("Rico", "Henry", "Jamaica", "Defensa", 3));
        brentford.AgregarJugador(new Jugador("Ethan", "Pinnock", "Jamaica", "Defensa", 5));
        brentford.AgregarJugador(new Jugador("Kristoffer", "Ajer", "Noruega", "Defensa", 6));
        brentford.AgregarJugador(new Jugador("Jordan", "Henderson", "Inglaterra", "Centrocampista", 15));
        brentford.AgregarJugador(new Jugador("Mathias", "Jensen", "Dinamarca", "Centrocampista", 8));
        brentford.AgregarJugador(new Jugador("Mikkel", "Damsgaard", "Dinamarca", "Centrocampista", 10));
        brentford.AgregarJugador(new Jugador("Vitaly", "Janelt", "Alemania", "Centrocampista", 21));
        brentford.AgregarJugador(new Jugador("Kevin", "Schade", "Alemania", "Delantero", 9));
        brentford.AgregarJugador(new Jugador("Igor", "Thiago", "Brasil", "Delantero", 19));
        brentford.AgregarJugador(new Jugador("Dango", "Ouattara", "Burkina Faso", "Delantero", 7));
        brentford.AgregarJugador(new Jugador("Callum", "Wilson", "Inglaterra", "Delantero", 20));

        //Jugadores del Brighton & Hove Albion
        var brighton = equipos[4];
        brighton.AgregarJugador(new Jugador("Bart", "Verbruggen", "Holanda", "Portero", 1));
        brighton.AgregarJugador(new Jugador("Jason", "Steele", "Inglaterra", "Portero", 23));
        brighton.AgregarJugador(new Jugador("Jan Paul", "van Hecke", "Holanda", "Defensa", 6));
        brighton.AgregarJugador(new Jugador("Lewis", "Dunk", "Inglaterra", "Defensa", 5));
        brighton.AgregarJugador(new Jugador("Ferdi", "Kadıoğlu", "Turquía", "Defensa", 24));
        brighton.AgregarJugador(new Jugador("Maxim", "De Cuyper", "Bélgica", "Defensa", 29));
        brighton.AgregarJugador(new Jugador("Olivier", "Boscagli", "Francia", "Defensa", 21));
        brighton.AgregarJugador(new Jugador("Joel", "Veltman", "Holanda", "Defensa", 34));
        brighton.AgregarJugador(new Jugador("Carlos", "Baleba", "Camerún", "Centrocampista", 17));
        brighton.AgregarJugador(new Jugador("James", "Milner", "Inglaterra", "Centrocampista", 20));
        brighton.AgregarJugador(new Jugador("Jack", "Hinshelwood", "Inglaterra", "Centrocampista", 13));
        brighton.AgregarJugador(new Jugador("Yasin", "Ayari", "Suecia", "Centrocampista", 26));
        brighton.AgregarJugador(new Jugador("Kaoru", "Mitoma", "Japón", "Delantero", 22));
        brighton.AgregarJugador(new Jugador("Georginio", "Rutter", "Francia", "Delantero", 10));
        brighton.AgregarJugador(new Jugador("Yankuba", "Minteh", "Gambia", "Delantero", 11));
        brighton.AgregarJugador(new Jugador("Danny", "Welbeck", "Inglaterra", "Delantero", 18));
        brighton.AgregarJugador(new Jugador("Charalampos", "Kostoulas", "Grecia", "Delantero", 19));

        //Jugadores del Chelsea
        var chelsea = equipos[5];

        chelsea.AgregarJugador(new Jugador("Robert", "Sánchez", "España", "Portero", 1));
        chelsea.AgregarJugador(new Jugador("Filip", "Jörgensen", "Dinamarca", "Portero", 12));
        chelsea.AgregarJugador(new Jugador("Levi", "Colwill", "Inglaterra", "Defensa", 6));
        chelsea.AgregarJugador(new Jugador("Wesley", "Fofana", "Francia", "Defensa", 29));
        chelsea.AgregarJugador(new Jugador("Benoît", "Badiashile", "Francia", "Defensa", 5));
        chelsea.AgregarJugador(new Jugador("Reece", "James", "Inglaterra", "Defensa", 24));
        chelsea.AgregarJugador(new Jugador("Malo", "Gusto", "Francia", "Defensa", 27));
        chelsea.AgregarJugador(new Jugador("Marc", "Cucurella", "España", "Defensa", 3));
        chelsea.AgregarJugador(new Jugador("Moisés", "Caicedo", "Ecuador", "Centrocampista", 25));
        chelsea.AgregarJugador(new Jugador("Enzo", "Fernández", "Argentina", "Centrocampista", 8));
        chelsea.AgregarJugador(new Jugador("Romeo", "Lavia", "Bélgica", "Centrocampista", 45));
        chelsea.AgregarJugador(new Jugador("Cole", "Palmer", "Inglaterra", "Centrocampista", 20));
        chelsea.AgregarJugador(new Jugador("Christopher", "Nkunku", "Francia", "Delantero", 18));
        chelsea.AgregarJugador(new Jugador("Nicolas", "Jackson", "Senegal", "Delantero", 15));
        chelsea.AgregarJugador(new Jugador("Pedro", "Neto", "Portugal", "Delantero", 7));
        chelsea.AgregarJugador(new Jugador("Jadon", "Sancho", "Inglaterra", "Delantero", 19));

        //Jugadores del Coventry City
        var coventry = equipos[6];
        coventry.AgregarJugador(new Jugador("Carl", "Rushworth", "Inglaterra", "Portero", 1));
        coventry.AgregarJugador(new Jugador("Milan", "van Ewijk", "Holanda", "Defensa", 2));
        coventry.AgregarJugador(new Jugador("Bobby", "Thomas", "Inglaterra", "Defensa", 5));
        coventry.AgregarJugador(new Jugador("Liam", "Kitching", "Inglaterra", "Defensa", 4));
        coventry.AgregarJugador(new Jugador("Aurele", "Amenda", "Suiza", "Defensa", 15));
        coventry.AgregarJugador(new Jugador("Jay", "Dasilva", "Inglaterra", "Defensa", 3));
        coventry.AgregarJugador(new Jugador("Victor", "Torp", "Dinamarca", "Centrocampista", 20));
        coventry.AgregarJugador(new Jugador("Matt", "Grimes", "Inglaterra", "Centrocampista", 8));
        coventry.AgregarJugador(new Jugador("Jack", "Rudoni", "Inglaterra", "Centrocampista", 10));
        coventry.AgregarJugador(new Jugador("Josh", "Eccles", "Inglaterra", "Centrocampista", 26));
        coventry.AgregarJugador(new Jugador("Tatsuhiro", "Sakamoto", "Japón", "Delantero", 25));
        coventry.AgregarJugador(new Jugador("Ephron", "Mason-Clark", "Inglaterra", "Delantero", 11));
        coventry.AgregarJugador(new Jugador("Haji", "Wright", "Estados Unidos", "Delantero", 22));
        coventry.AgregarJugador(new Jugador("Brandon", "Thomas-Asante", "Inglaterra", "Delantero", 45));
        coventry.AgregarJugador(new Jugador("Ellis", "Simms", "Inglaterra", "Delantero", 9));

        //Jugadores del Crystal Palace
        var crystalPalace = equipos[7];
        crystalPalace.AgregarJugador(new Jugador("Dean", "Henderson", "Inglaterra", "Portero", 1));
        crystalPalace.AgregarJugador(new Jugador("Maxime", "Lacroix", "Francia", "Defensa", 4));
        crystalPalace.AgregarJugador(new Jugador("Daniel", "Muñoz", "Colombia", "Defensa", 2));
        crystalPalace.AgregarJugador(new Jugador("Jaydee", "Canvot", "Francia", "Defensa", 26));
        crystalPalace.AgregarJugador(new Jugador("Chadi", "Riad", "Marruecos", "Defensa", 5));
        crystalPalace.AgregarJugador(new Jugador("Tyrick", "Mitchell", "Inglaterra", "Defensa", 3));
        crystalPalace.AgregarJugador(new Jugador("Adam", "Wharton", "Inglaterra", "Centrocampista", 20));
        crystalPalace.AgregarJugador(new Jugador("Daichi", "Kamada", "Japón", "Centrocampista", 21));
        crystalPalace.AgregarJugador(new Jugador("Ismaïla", "Sarr", "Senegal", "Delantero", 7));
        crystalPalace.AgregarJugador(new Jugador("Jean-Philippe", "Mateta", "Francia", "Delantero", 14));
        crystalPalace.AgregarJugador(new Jugador("Yeremy", "Pino", "España", "Delantero", 17));
        crystalPalace.AgregarJugador(new Jugador("Brennan", "Johnson", "Gales", "Delantero", 22));

        //Jugadores del Everton
        var everton = equipos[8];
        everton.AgregarJugador(new Jugador("Jordan", "Pickford", "Inglaterra", "Portero", 1));
        everton.AgregarJugador(new Jugador("Mark", "Travers", "Irlanda", "Portero", 12));
        everton.AgregarJugador(new Jugador("James", "Tarkowski", "Inglaterra", "Defensa", 6));
        everton.AgregarJugador(new Jugador("Jarrad", "Branthwaite", "Inglaterra", "Defensa", 32));
        everton.AgregarJugador(new Jugador("Jake", "O'Brien", "Irlanda", "Defensa", 15));
        everton.AgregarJugador(new Jugador("Vitaliy", "Mykolenko", "Ucrania", "Defensa", 16));
        everton.AgregarJugador(new Jugador("Nathan", "Patterson", "Escocia", "Defensa", 2));
        everton.AgregarJugador(new Jugador("James", "Garner", "Inglaterra", "Centrocampista", 37));
        everton.AgregarJugador(new Jugador("Tim", "Iroegbunam", "Inglaterra", "Centrocampista", 42));
        everton.AgregarJugador(new Jugador("Kiernan", "Dewsbury-Hall", "Inglaterra", "Centrocampista", 22));
        everton.AgregarJugador(new Jugador("Jack", "Grealish", "Inglaterra", "Centrocampista", 18));
        everton.AgregarJugador(new Jugador("Idrissa", "Gueye", "Senegal", "Centrocampista", 27));
        everton.AgregarJugador(new Jugador("Iliman", "Ndiaye", "Senegal", "Delantero", 10));
        everton.AgregarJugador(new Jugador("Beto", "", "Guinea-Bisáu", "Delantero", 14));
        everton.AgregarJugador(new Jugador("Dwight", "McNeil", "Inglaterra", "Delantero", 7));
        everton.AgregarJugador(new Jugador("Thierno", "Barry", "Francia", "Delantero", 9));

        //Jugadores del Fulham
        var fulham = equipos[9];
        fulham.AgregarJugador(new Jugador("Bernd", "Leno", "Alemania", "Portero", 1));
        fulham.AgregarJugador(new Jugador("Benjamin", "Lecomte", "Francia", "Portero", 23));
        fulham.AgregarJugador(new Jugador("Calvin", "Bassey", "Nigeria", "Defensa", 3));
        fulham.AgregarJugador(new Jugador("Joachim", "Andersen", "Dinamarca", "Defensa", 5));
        fulham.AgregarJugador(new Jugador("Timothy", "Castagne", "Bélgica", "Defensa", 21));
        fulham.AgregarJugador(new Jugador("Antonee", "Robinson", "Estados Unidos", "Defensa", 33));
        fulham.AgregarJugador(new Jugador("Kenny", "Tete", "Holanda", "Defensa", 2));
        fulham.AgregarJugador(new Jugador("Ryan", "Sessegnon", "Inglaterra", "Defensa", 30));
        fulham.AgregarJugador(new Jugador("Sander", "Berge", "Noruega", "Centrocampista", 16));
        fulham.AgregarJugador(new Jugador("Alex", "Iwobi", "Nigeria", "Centrocampista", 17));
        fulham.AgregarJugador(new Jugador("Emile", "Smith Rowe", "Inglaterra", "Centrocampista", 32));
        fulham.AgregarJugador(new Jugador("Tom", "Cairney", "Escocia", "Centrocampista", 10));
        fulham.AgregarJugador(new Jugador("Rodrigo", "Muniz", "Brasil", "Delantero", 9));
        fulham.AgregarJugador(new Jugador("Harry", "Wilson", "Gales", "Delantero", 8));
        fulham.AgregarJugador(new Jugador("Raúl", "Jiménez", "México", "Delantero", 7));
        fulham.AgregarJugador(new Jugador("Oscar", "Bobb", "Noruega", "Delantero", 14));
        fulham.AgregarJugador(new Jugador("Samuel", "Chukwueze", "Nigeria", "Delantero", 19));

        //Jugadores del Hull City
        var hullCity = equipos[10];
        hullCity.AgregarJugador(new Jugador("Ivor", "Pandur", "Croacia", "Portero", 1));
        hullCity.AgregarJugador(new Jugador("Lewie", "Coyle", "Inglaterra", "Defensa", 2));
        hullCity.AgregarJugador(new Jugador("Ryan", "Giles", "Gales", "Defensa", 3));
        hullCity.AgregarJugador(new Jugador("Charlie", "Hughes", "Inglaterra", "Defensa", 4));
        hullCity.AgregarJugador(new Jugador("John", "Egan", "Irlanda", "Defensa", 15));
        hullCity.AgregarJugador(new Jugador("Cody", "Drameh", "Inglaterra", "Defensa", 18));
        hullCity.AgregarJugador(new Jugador("Paddy", "McNair", "Irlanda del Norte", "Defensa", 37));
        hullCity.AgregarJugador(new Jugador("Regan", "Slater", "Inglaterra", "Centrocampista", 27));
        hullCity.AgregarJugador(new Jugador("Matt", "Crooks", "Inglaterra", "Centrocampista", 25));
        hullCity.AgregarJugador(new Jugador("John", "Lundstram", "Inglaterra", "Centrocampista", 5));
        hullCity.AgregarJugador(new Jugador("Kieran", "Dowell", "Inglaterra", "Centrocampista", 26));
        hullCity.AgregarJugador(new Jugador("Joe", "Gelhardt", "Inglaterra", "Delantero", 45));
        hullCity.AgregarJugador(new Jugador("Oli", "McBurnie", "Escocia", "Delantero", 9));
        hullCity.AgregarJugador(new Jugador("Liam", "Millar", "Canadá", "Delantero", 7));
        hullCity.AgregarJugador(new Jugador("Kyle", "Joseph", "Escocia", "Delantero", 29));

        //Jugadores del Ipswich Town
        var ipswich = equipos[11];
        ipswich.AgregarJugador(new Jugador("Christian", "Walton", "Inglaterra", "Portero", 1));
        ipswich.AgregarJugador(new Jugador("Darnell", "Furlong", "Inglaterra", "Defensa", 2));
        ipswich.AgregarJugador(new Jugador("Dara", "O'Shea", "Irlanda", "Defensa", 20));
        ipswich.AgregarJugador(new Jugador("Cedric", "Kipre", "Costa de Marfil", "Defensa", 26));
        ipswich.AgregarJugador(new Jugador("Leif", "Davis", "Inglaterra", "Defensa", 3));
        ipswich.AgregarJugador(new Jugador("Jacob", "Greaves", "Inglaterra", "Defensa", 17));
        ipswich.AgregarJugador(new Jugador("Azor", "Matusiwa", "Holanda", "Centrocampista", 15));
        ipswich.AgregarJugador(new Jugador("Jack", "Taylor", "Inglaterra", "Centrocampista", 22));
        ipswich.AgregarJugador(new Jugador("Marcelino", "Núñez", "Chile", "Centrocampista", 8));
        ipswich.AgregarJugador(new Jugador("Sindre Walle", "Egeli", "Noruega", "Delantero", 27));
        ipswich.AgregarJugador(new Jugador("Jack", "Clarke", "Inglaterra", "Delantero", 11));
        ipswich.AgregarJugador(new Jugador("Chuba", "Akpom", "Inglaterra", "Delantero", 19));
        ipswich.AgregarJugador(new Jugador("George", "Hirst", "Inglaterra", "Delantero", 32));
        ipswich.AgregarJugador(new Jugador("Iván", "Azón", "España", "Delantero", 25));

        //Jugadores del Leeds United
        var leeds = equipos[12];
        leeds.AgregarJugador(new Jugador("James", "Trafford", "Inglaterra", "Portero", 30));
        leeds.AgregarJugador(new Jugador("Lucas", "Perri", "Brasil", "Portero", 1));
        leeds.AgregarJugador(new Jugador("Ethan", "Ampadu", "Gales", "Defensa", 4));
        leeds.AgregarJugador(new Jugador("Joe", "Rodon", "Gales", "Defensa", 6));
        leeds.AgregarJugador(new Jugador("Jayden", "Bogle", "Inglaterra", "Defensa", 2));
        leeds.AgregarJugador(new Jugador("Gabriel", "Gudmundsson", "Suecia", "Defensa", 3));
        leeds.AgregarJugador(new Jugador("Tarik", "Muharemović", "Bosnia", "Defensa", 5));
        leeds.AgregarJugador(new Jugador("Brenden", "Aaronson", "Estados Unidos", "Centrocampista", 11));
        leeds.AgregarJugador(new Jugador("Anton", "Stach", "Alemania", "Centrocampista", 18));
        leeds.AgregarJugador(new Jugador("Sean", "Longstaff", "Inglaterra", "Centrocampista", 8));
        leeds.AgregarJugador(new Jugador("Ao", "Tanaka", "Japón", "Centrocampista", 22));
        leeds.AgregarJugador(new Jugador("Daniel", "James", "Gales", "Delantero", 13));
        leeds.AgregarJugador(new Jugador("Dominic", "Calvert-Lewin", "Inglaterra", "Delantero", 21));
        leeds.AgregarJugador(new Jugador("Harry", "Wilson", "Gales", "Delantero", 24));
        leeds.AgregarJugador(new Jugador("Joel", "Piroe", "Surinam", "Delantero", 10));

        //Jugadores del Liverpool
        var liverpool = equipos[13];
        liverpool.AgregarJugador(new Jugador("Alisson", "Becker", "Brasil", "Portero", 1));
        liverpool.AgregarJugador(new Jugador("Giorgi", "Mamardashvili", "Georgia", "Portero", 25));
        liverpool.AgregarJugador(new Jugador("Virgil", "van Dijk", "Holanda", "Defensa", 4));
        liverpool.AgregarJugador(new Jugador("Ibrahima", "Konaté", "Francia", "Defensa", 5));
        liverpool.AgregarJugador(new Jugador("Milos", "Kerkez", "Hungría", "Defensa", 6));
        liverpool.AgregarJugador(new Jugador("Conor", "Bradley", "Irlanda del Norte", "Defensa", 12));
        liverpool.AgregarJugador(new Jugador("Jeremie", "Frimpong", "Holanda", "Defensa", 30));
        liverpool.AgregarJugador(new Jugador("Joe", "Gomez", "Inglaterra", "Defensa", 2));
        liverpool.AgregarJugador(new Jugador("Florian", "Wirtz", "Alemania", "Centrocampista", 7));
        liverpool.AgregarJugador(new Jugador("Dominik", "Szoboszlai", "Hungría", "Centrocampista", 8));
        liverpool.AgregarJugador(new Jugador("Alexis", "Mac Allister", "Argentina", "Centrocampista", 10));
        liverpool.AgregarJugador(new Jugador("Ryan", "Gravenberch", "Holanda", "Centrocampista", 38));
        liverpool.AgregarJugador(new Jugador("Curtis", "Jones", "Inglaterra", "Centrocampista", 17));
        liverpool.AgregarJugador(new Jugador("Mohamed", "Salah", "Egipto", "Delantero", 11));
        liverpool.AgregarJugador(new Jugador("Alexander", "Isak", "Suecia", "Delantero", 9));
        liverpool.AgregarJugador(new Jugador("Hugo", "Ekitiké", "Francia", "Delantero", 22));
        liverpool.AgregarJugador(new Jugador("Cody", "Gakpo", "Holanda", "Delantero", 18));
        liverpool.AgregarJugador(new Jugador("Federico", "Chiesa", "Italia", "Delantero", 14));

        //Jugadores del Manchester City
        var manchesterCity = equipos[14];
        manchesterCity.AgregarJugador(new Jugador("Ederson", "", "Brasil", "Portero", 31));
        manchesterCity.AgregarJugador(new Jugador("Rúben", "Dias", "Portugal", "Defensa", 3));
        manchesterCity.AgregarJugador(new Jugador("John", "Stones", "Inglaterra", "Defensa", 5));
        manchesterCity.AgregarJugador(new Jugador("Nathan", "Aké", "Holanda", "Defensa", 6));
        manchesterCity.AgregarJugador(new Jugador("Joško", "Gvardiol", "Croacia", "Defensa", 24));
        manchesterCity.AgregarJugador(new Jugador("Rayan", "Aït-Nouri", "Argelia", "Defensa", 21));
        manchesterCity.AgregarJugador(new Jugador("Rodrigo", "Hernández", "España", "Centrocampista", 16));
        manchesterCity.AgregarJugador(new Jugador("Tijjani", "Reijnders", "Holanda", "Centrocampista", 4));
        manchesterCity.AgregarJugador(new Jugador("Bernardo", "Silva", "Portugal", "Centrocampista", 20));
        manchesterCity.AgregarJugador(new Jugador("Mateo", "Kovačić", "Croacia", "Centrocampista", 8));
        manchesterCity.AgregarJugador(new Jugador("Matheus", "Nunes", "Portugal", "Centrocampista", 27));
        manchesterCity.AgregarJugador(new Jugador("Phil", "Foden", "Inglaterra", "Centrocampista", 47));
        manchesterCity.AgregarJugador(new Jugador("Erling", "Haaland", "Noruega", "Delantero", 9));
        manchesterCity.AgregarJugador(new Jugador("Omar", "Marmoush", "Egipto", "Delantero", 7));
        manchesterCity.AgregarJugador(new Jugador("Jérémy", "Doku", "Bélgica", "Delantero", 11));
        manchesterCity.AgregarJugador(new Jugador("Rayan", "Cherki", "Francia", "Delantero", 10));
        manchesterCity.AgregarJugador(new Jugador("Savinho", "", "Brasil", "Delantero", 26));

        //Jugadores del Manchester United
        var manchesterUnited = equipos[15];
        manchesterUnited.AgregarJugador(new Jugador("Senne", "Lammens", "Bélgica", "Portero", 1));
        manchesterUnited.AgregarJugador(new Jugador("Altay", "Bayındır", "Turquía", "Portero", 24));
        manchesterUnited.AgregarJugador(new Jugador("Matthijs", "de Ligt", "Holanda", "Defensa", 4));
        manchesterUnited.AgregarJugador(new Jugador("Leny", "Yoro", "Francia", "Defensa", 15));
        manchesterUnited.AgregarJugador(new Jugador("Luke", "Shaw", "Inglaterra", "Defensa", 23));
        manchesterUnited.AgregarJugador(new Jugador("Diogo", "Dalot", "Portugal", "Defensa", 20));
        manchesterUnited.AgregarJugador(new Jugador("Patrick", "Dorgu", "Dinamarca", "Defensa", 33));
        manchesterUnited.AgregarJugador(new Jugador("Noussair", "Mazraoui", "Marruecos", "Defensa", 2));
        manchesterUnited.AgregarJugador(new Jugador("Bruno", "Fernandes", "Portugal", "Centrocampista", 8));
        manchesterUnited.AgregarJugador(new Jugador("Casemiro", "", "Brasil", "Centrocampista", 18));
        manchesterUnited.AgregarJugador(new Jugador("Kobbie", "Mainoo", "Inglaterra", "Centrocampista", 37));
        manchesterUnited.AgregarJugador(new Jugador("Andrey", "Santos", "Brasil", "Centrocampista", 17));
        manchesterUnited.AgregarJugador(new Jugador("Bryan", "Mbeumo", "Camerún", "Delantero", 19));
        manchesterUnited.AgregarJugador(new Jugador("Matheus", "Cunha", "Brasil", "Delantero", 10));
        manchesterUnited.AgregarJugador(new Jugador("Benjamin", "Šeško", "Eslovenia", "Delantero", 7));
        manchesterUnited.AgregarJugador(new Jugador("Mason", "Mount", "Inglaterra", "Delantero", 9));
        manchesterUnited.AgregarJugador(new Jugador("Amad", "Diallo", "Costa de Marfil", "Delantero", 16));

        //Jugadores del Newcastle United
        var newcastle = equipos[16];
        newcastle.AgregarJugador(new Jugador("Nick", "Pope", "Inglaterra", "Portero", 1));
        newcastle.AgregarJugador(new Jugador("Tino", "Livramento", "Inglaterra", "Defensa", 2));
        newcastle.AgregarJugador(new Jugador("Lewis", "Hall", "Inglaterra", "Defensa", 3));
        newcastle.AgregarJugador(new Jugador("Sven", "Botman", "Holanda", "Defensa", 4));
        newcastle.AgregarJugador(new Jugador("Fabian", "Schär", "Suiza", "Defensa", 5));
        newcastle.AgregarJugador(new Jugador("Malick", "Thiaw", "Alemania", "Defensa", 12));
        newcastle.AgregarJugador(new Jugador("Dan", "Burn", "Inglaterra", "Defensa", 33));
        newcastle.AgregarJugador(new Jugador("Joelinton", "", "Brasil", "Centrocampista", 7));
        newcastle.AgregarJugador(new Jugador("Bruno", "Guimarães", "Brasil", "Centrocampista", 39));
        newcastle.AgregarJugador(new Jugador("Joe", "Willock", "Inglaterra", "Centrocampista", 28));
        newcastle.AgregarJugador(new Jugador("Jacob", "Ramsey", "Inglaterra", "Centrocampista", 41));
        newcastle.AgregarJugador(new Jugador("Sean", "Steur", "Holanda", "Centrocampista", 14));
        newcastle.AgregarJugador(new Jugador("Yoane", "Wissa", "RD Congo", "Delantero", 9));
        newcastle.AgregarJugador(new Jugador("Will", "Osula", "Dinamarca", "Delantero", 10));
        newcastle.AgregarJugador(new Jugador("Harvey", "Barnes", "Inglaterra", "Delantero", 11));
        newcastle.AgregarJugador(new Jugador("Nick", "Woltemade", "Alemania", "Delantero", 27));
        newcastle.AgregarJugador(new Jugador("Anthony", "Elanga", "Suecia", "Delantero", 19));
        newcastle.AgregarJugador(new Jugador("Jacob", "Murphy", "Inglaterra", "Delantero", 23));

        //Jugadores del Nottingham Forest
        var nottinghamForest = equipos[17];
        nottinghamForest.AgregarJugador(new Jugador("Matz", "Sels", "Bélgica", "Portero", 26));
        nottinghamForest.AgregarJugador(new Jugador("Neco", "Williams", "Gales", "Defensa", 3));
        nottinghamForest.AgregarJugador(new Jugador("Murillo", "", "Brasil", "Defensa", 5));
        nottinghamForest.AgregarJugador(new Jugador("Nikola", "Milenković", "Serbia", "Defensa", 31));
        nottinghamForest.AgregarJugador(new Jugador("Ola", "Aina", "Nigeria", "Defensa", 34));
        nottinghamForest.AgregarJugador(new Jugador("Morato", "", "Brasil", "Defensa", 4));
        nottinghamForest.AgregarJugador(new Jugador("Ibrahim", "Sangaré", "Costa de Marfil", "Centrocampista", 6));
        nottinghamForest.AgregarJugador(new Jugador("Morgan", "Gibbs-White", "Inglaterra", "Centrocampista", 10));
        nottinghamForest.AgregarJugador(new Jugador("Nicolás", "Domínguez", "Argentina", "Centrocampista", 16));
        nottinghamForest.AgregarJugador(new Jugador("James", "McAtee", "Inglaterra", "Centrocampista", 24));
        nottinghamForest.AgregarJugador(new Jugador("Elliot", "Anderson", "Inglaterra", "Centrocampista", 8));
        nottinghamForest.AgregarJugador(new Jugador("Callum", "Hudson-Odoi", "Inglaterra", "Delantero", 7));
        nottinghamForest.AgregarJugador(new Jugador("Chris", "Wood", "Nueva Zelanda", "Delantero", 11));
        nottinghamForest.AgregarJugador(new Jugador("Dan", "Ndoye", "Suiza", "Delantero", 14));
        nottinghamForest.AgregarJugador(new Jugador("Taiwo", "Awoniyi", "Nigeria", "Delantero", 9));
        nottinghamForest.AgregarJugador(new Jugador("Igor", "Jesus", "Brasil", "Delantero", 19));

        //Jugadores del Sunderland
        var sunderland = equipos[18];
        sunderland.AgregarJugador(new Jugador("Robin", "Roefs", "Holanda", "Portero", 31));
        sunderland.AgregarJugador(new Jugador("Trai", "Hume", "Irlanda del Norte", "Defensa", 2));
        sunderland.AgregarJugador(new Jugador("Daniel", "Ballard", "Irlanda del Norte", "Defensa", 5));
        sunderland.AgregarJugador(new Jugador("Omar", "Alderete", "Paraguay", "Defensa", 15));
        sunderland.AgregarJugador(new Jugador("Nordi", "Mukiele", "Francia", "Defensa", 20));
        sunderland.AgregarJugador(new Jugador("Reinildo", "Mandava", "Mozambique", "Defensa", 17));
        sunderland.AgregarJugador(new Jugador("Granit", "Xhaka", "Suiza", "Centrocampista", 34));
        sunderland.AgregarJugador(new Jugador("Enzo", "Le Fée", "Francia", "Centrocampista", 28));
        sunderland.AgregarJugador(new Jugador("Noah", "Sadiki", "Bélgica", "Centrocampista", 27));
        sunderland.AgregarJugador(new Jugador("Chemsdine", "Talbi", "Marruecos", "Delantero", 7));
        sunderland.AgregarJugador(new Jugador("Wilson", "Isidor", "Francia", "Delantero", 9));
        sunderland.AgregarJugador(new Jugador("Eliezer", "Mayenda", "España", "Delantero", 45));
        sunderland.AgregarJugador(new Jugador("Simon", "Adingra", "Costa de Marfil", "Delantero", 23));

        //Jugadores del Tottenham Hotspur
        var tottenham = equipos[19];
        tottenham.AgregarJugador(new Jugador("Guglielmo", "Vicario", "Italia", "Portero", 1));
        tottenham.AgregarJugador(new Jugador("Antonín", "Kinsky", "República Checa", "Portero", 31));
        tottenham.AgregarJugador(new Jugador("Cristian", "Romero", "Argentina", "Defensa", 17));
        tottenham.AgregarJugador(new Jugador("Micky", "van de Ven", "Holanda", "Defensa", 37));
        tottenham.AgregarJugador(new Jugador("Pedro", "Porro", "España", "Defensa", 23));
        tottenham.AgregarJugador(new Jugador("Destiny", "Udogie", "Italia", "Defensa", 13));
        tottenham.AgregarJugador(new Jugador("Djed", "Spence", "Inglaterra", "Defensa", 24));
        tottenham.AgregarJugador(new Jugador("Archie", "Gray", "Inglaterra", "Defensa", 14));
        tottenham.AgregarJugador(new Jugador("Sandro", "Tonali", "Italia", "Centrocampista", 16));
        tottenham.AgregarJugador(new Jugador("James", "Maddison", "Inglaterra", "Centrocampista", 10));
        tottenham.AgregarJugador(new Jugador("Pape Matar", "Sarr", "Senegal", "Centrocampista", 29));
        tottenham.AgregarJugador(new Jugador("Rodrigo", "Bentancur", "Uruguay", "Centrocampista", 30));
        tottenham.AgregarJugador(new Jugador("Xavi", "Simons", "Holanda", "Centrocampista", 7));
        tottenham.AgregarJugador(new Jugador("Dejan", "Kulusevski", "Suecia", "Delantero", 21));
        tottenham.AgregarJugador(new Jugador("Mohammed", "Kudus", "Ghana", "Delantero", 20));
        tottenham.AgregarJugador(new Jugador("Dominic", "Solanke", "Inglaterra", "Delantero", 19));
        tottenham.AgregarJugador(new Jugador("Mathys", "Tel", "Francia", "Delantero", 28));
        tottenham.AgregarJugador(new Jugador("Richarlison", "", "Brasil", "Delantero", 9));

        await context.Equipos.AddRangeAsync(equipos);
        await context.SaveChangesAsync();
    }
}