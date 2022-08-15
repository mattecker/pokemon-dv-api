using Microsoft.EntityFrameworkCore.Migrations;

namespace PokémonDV.Api.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseStats",
                columns: table => new
                {
                    PokédexId = table.Column<byte>(type: "tinyint", nullable: false),
                    Species = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HP = table.Column<byte>(type: "tinyint", nullable: false),
                    Attack = table.Column<byte>(type: "tinyint", nullable: false),
                    Defense = table.Column<byte>(type: "tinyint", nullable: false),
                    Speed = table.Column<byte>(type: "tinyint", nullable: false),
                    Special = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseStats", x => x.PokédexId);
                });

            migrationBuilder.InsertData(
                table: "BaseStats",
                columns: new[] { "PokédexId", "Attack", "Defense", "HP", "Special", "Species", "Speed" },
                values: new object[,]
                {
                    { (byte)1, (byte)49, (byte)49, (byte)45, (byte)65, "Bulbasaur", (byte)45 },
                    { (byte)97, (byte)73, (byte)70, (byte)85, (byte)115, "Hypno", (byte)67 },
                    { (byte)98, (byte)105, (byte)90, (byte)30, (byte)25, "Krabby", (byte)50 },
                    { (byte)99, (byte)130, (byte)115, (byte)55, (byte)50, "Kingler", (byte)75 },
                    { (byte)100, (byte)30, (byte)50, (byte)40, (byte)55, "Voltorb", (byte)100 },
                    { (byte)101, (byte)50, (byte)70, (byte)60, (byte)80, "Electrode", (byte)140 },
                    { (byte)102, (byte)40, (byte)80, (byte)60, (byte)60, "Exeggcute", (byte)40 },
                    { (byte)103, (byte)95, (byte)85, (byte)95, (byte)125, "Exeggutor", (byte)55 },
                    { (byte)104, (byte)50, (byte)95, (byte)50, (byte)40, "Cubone", (byte)35 },
                    { (byte)105, (byte)80, (byte)110, (byte)60, (byte)50, "Marowak", (byte)45 },
                    { (byte)106, (byte)120, (byte)53, (byte)50, (byte)35, "Hitmonlee", (byte)87 },
                    { (byte)107, (byte)105, (byte)79, (byte)50, (byte)35, "Hitmonchan", (byte)76 },
                    { (byte)108, (byte)55, (byte)75, (byte)90, (byte)60, "Lickitung", (byte)30 },
                    { (byte)109, (byte)65, (byte)95, (byte)40, (byte)60, "Koffing", (byte)35 },
                    { (byte)110, (byte)90, (byte)120, (byte)65, (byte)85, "Weezing", (byte)60 },
                    { (byte)111, (byte)85, (byte)95, (byte)80, (byte)30, "Rhyhorn", (byte)25 },
                    { (byte)96, (byte)48, (byte)45, (byte)60, (byte)90, "Drowzee", (byte)42 },
                    { (byte)112, (byte)130, (byte)120, (byte)105, (byte)45, "Rhydon", (byte)40 },
                    { (byte)95, (byte)45, (byte)160, (byte)35, (byte)30, "Onix", (byte)70 },
                    { (byte)93, (byte)50, (byte)45, (byte)45, (byte)115, "Haunter", (byte)95 },
                    { (byte)78, (byte)100, (byte)70, (byte)65, (byte)80, "Rapidash", (byte)105 },
                    { (byte)79, (byte)65, (byte)65, (byte)90, (byte)40, "Slowpoke", (byte)15 },
                    { (byte)80, (byte)75, (byte)110, (byte)95, (byte)80, "Slowbro", (byte)30 },
                    { (byte)81, (byte)35, (byte)70, (byte)25, (byte)95, "Magnemite", (byte)45 },
                    { (byte)82, (byte)60, (byte)95, (byte)50, (byte)120, "Magneton", (byte)70 },
                    { (byte)83, (byte)65, (byte)55, (byte)52, (byte)58, "Farfetch'd", (byte)60 },
                    { (byte)84, (byte)85, (byte)45, (byte)35, (byte)35, "Doduo", (byte)75 },
                    { (byte)85, (byte)110, (byte)70, (byte)60, (byte)60, "Dodrio", (byte)100 },
                    { (byte)86, (byte)45, (byte)55, (byte)65, (byte)70, "Seel", (byte)45 },
                    { (byte)87, (byte)70, (byte)80, (byte)90, (byte)95, "Dewgong", (byte)70 },
                    { (byte)88, (byte)80, (byte)50, (byte)80, (byte)40, "Grimer", (byte)25 },
                    { (byte)89, (byte)105, (byte)75, (byte)105, (byte)65, "Muk", (byte)50 },
                    { (byte)90, (byte)65, (byte)100, (byte)30, (byte)45, "Shellder", (byte)40 },
                    { (byte)91, (byte)95, (byte)180, (byte)50, (byte)85, "Cloyster", (byte)70 },
                    { (byte)92, (byte)35, (byte)30, (byte)30, (byte)100, "Gastly", (byte)80 },
                    { (byte)94, (byte)65, (byte)60, (byte)60, (byte)130, "Gengar", (byte)110 },
                    { (byte)77, (byte)85, (byte)55, (byte)50, (byte)65, "Ponyta", (byte)90 },
                    { (byte)113, (byte)5, (byte)5, (byte)250, (byte)105, "Chansey", (byte)50 },
                    { (byte)115, (byte)95, (byte)80, (byte)105, (byte)40, "Kangaskhan", (byte)90 },
                    { (byte)135, (byte)65, (byte)60, (byte)65, (byte)110, "Jolteon", (byte)130 },
                    { (byte)136, (byte)130, (byte)60, (byte)65, (byte)110, "Flareon", (byte)65 },
                    { (byte)137, (byte)60, (byte)70, (byte)65, (byte)75, "Porygon", (byte)40 }
                });

            migrationBuilder.InsertData(
                table: "BaseStats",
                columns: new[] { "PokédexId", "Attack", "Defense", "HP", "Special", "Species", "Speed" },
                values: new object[,]
                {
                    { (byte)138, (byte)40, (byte)100, (byte)35, (byte)90, "Omanyte", (byte)35 },
                    { (byte)139, (byte)60, (byte)125, (byte)70, (byte)115, "Omastar", (byte)55 },
                    { (byte)140, (byte)80, (byte)90, (byte)30, (byte)45, "Kabuto", (byte)55 },
                    { (byte)141, (byte)115, (byte)105, (byte)60, (byte)70, "Kabutops", (byte)80 },
                    { (byte)142, (byte)105, (byte)65, (byte)80, (byte)60, "Aerodactyl", (byte)130 },
                    { (byte)143, (byte)110, (byte)65, (byte)160, (byte)65, "Snorlax", (byte)30 },
                    { (byte)144, (byte)85, (byte)100, (byte)90, (byte)125, "Articuno", (byte)85 },
                    { (byte)145, (byte)90, (byte)85, (byte)90, (byte)125, "Zapdos", (byte)100 },
                    { (byte)146, (byte)100, (byte)90, (byte)90, (byte)125, "Moltres", (byte)90 },
                    { (byte)147, (byte)64, (byte)45, (byte)41, (byte)50, "Dratini", (byte)50 },
                    { (byte)148, (byte)84, (byte)65, (byte)61, (byte)70, "Dragonair", (byte)70 },
                    { (byte)149, (byte)134, (byte)95, (byte)91, (byte)100, "Dragonite", (byte)80 },
                    { (byte)134, (byte)65, (byte)60, (byte)130, (byte)110, "Vaporeon", (byte)65 },
                    { (byte)114, (byte)55, (byte)115, (byte)65, (byte)100, "Tangela", (byte)60 },
                    { (byte)133, (byte)55, (byte)50, (byte)55, (byte)65, "Eevee", (byte)55 },
                    { (byte)131, (byte)85, (byte)80, (byte)130, (byte)95, "Lapras", (byte)60 },
                    { (byte)116, (byte)40, (byte)70, (byte)30, (byte)70, "Horsea", (byte)60 },
                    { (byte)117, (byte)65, (byte)95, (byte)55, (byte)95, "Seadra", (byte)85 },
                    { (byte)118, (byte)67, (byte)60, (byte)45, (byte)50, "Goldeen", (byte)63 },
                    { (byte)119, (byte)92, (byte)65, (byte)80, (byte)80, "Seaking", (byte)68 },
                    { (byte)120, (byte)45, (byte)55, (byte)30, (byte)70, "Staryu", (byte)85 },
                    { (byte)121, (byte)75, (byte)85, (byte)60, (byte)100, "Starmie", (byte)115 },
                    { (byte)122, (byte)45, (byte)65, (byte)40, (byte)100, "Mr. Mime", (byte)90 },
                    { (byte)123, (byte)110, (byte)80, (byte)70, (byte)55, "Scyther", (byte)105 },
                    { (byte)124, (byte)50, (byte)35, (byte)65, (byte)95, "Jynx", (byte)95 },
                    { (byte)125, (byte)83, (byte)57, (byte)65, (byte)85, "Electabuzz", (byte)105 },
                    { (byte)126, (byte)95, (byte)57, (byte)65, (byte)85, "Magmar", (byte)93 },
                    { (byte)127, (byte)125, (byte)100, (byte)65, (byte)55, "Pinsir", (byte)85 },
                    { (byte)128, (byte)100, (byte)95, (byte)75, (byte)70, "Tauros", (byte)110 },
                    { (byte)129, (byte)10, (byte)55, (byte)20, (byte)20, "Magikarp", (byte)80 },
                    { (byte)130, (byte)125, (byte)79, (byte)95, (byte)100, "Gyarados", (byte)81 },
                    { (byte)132, (byte)48, (byte)48, (byte)48, (byte)48, "Ditto", (byte)48 },
                    { (byte)150, (byte)110, (byte)90, (byte)106, (byte)154, "Mewtwo", (byte)130 },
                    { (byte)76, (byte)110, (byte)130, (byte)80, (byte)55, "Golem", (byte)45 },
                    { (byte)74, (byte)80, (byte)100, (byte)40, (byte)30, "Geodude", (byte)20 },
                    { (byte)21, (byte)60, (byte)30, (byte)40, (byte)31, "Spearow", (byte)70 },
                    { (byte)22, (byte)90, (byte)65, (byte)65, (byte)61, "Fearow", (byte)100 },
                    { (byte)23, (byte)60, (byte)44, (byte)35, (byte)40, "Ekans", (byte)55 },
                    { (byte)24, (byte)85, (byte)69, (byte)60, (byte)65, "Arbok", (byte)80 },
                    { (byte)25, (byte)55, (byte)30, (byte)35, (byte)50, "Pikachu", (byte)90 },
                    { (byte)26, (byte)90, (byte)55, (byte)60, (byte)90, "Raichu", (byte)100 },
                    { (byte)27, (byte)75, (byte)85, (byte)50, (byte)30, "Sandshrew", (byte)40 }
                });

            migrationBuilder.InsertData(
                table: "BaseStats",
                columns: new[] { "PokédexId", "Attack", "Defense", "HP", "Special", "Species", "Speed" },
                values: new object[,]
                {
                    { (byte)28, (byte)100, (byte)110, (byte)75, (byte)55, "Sandslash", (byte)65 },
                    { (byte)29, (byte)47, (byte)52, (byte)55, (byte)40, "Nidoran♀", (byte)41 },
                    { (byte)30, (byte)62, (byte)67, (byte)70, (byte)55, "Nidorina", (byte)56 },
                    { (byte)31, (byte)82, (byte)87, (byte)90, (byte)75, "Nidoqueen", (byte)76 },
                    { (byte)32, (byte)57, (byte)40, (byte)46, (byte)40, "Nidoran♂", (byte)50 },
                    { (byte)33, (byte)72, (byte)57, (byte)61, (byte)55, "Nidorino", (byte)65 },
                    { (byte)34, (byte)92, (byte)77, (byte)81, (byte)75, "Nidoking", (byte)85 },
                    { (byte)35, (byte)45, (byte)48, (byte)70, (byte)60, "Clefairy", (byte)35 },
                    { (byte)20, (byte)81, (byte)60, (byte)55, (byte)50, "Raticate", (byte)97 },
                    { (byte)36, (byte)70, (byte)73, (byte)95, (byte)85, "Clefable", (byte)60 },
                    { (byte)19, (byte)56, (byte)35, (byte)30, (byte)25, "Rattata", (byte)72 },
                    { (byte)17, (byte)60, (byte)55, (byte)63, (byte)50, "Pidgeotto", (byte)71 },
                    { (byte)2, (byte)62, (byte)63, (byte)60, (byte)80, "Ivysaur", (byte)60 },
                    { (byte)3, (byte)82, (byte)83, (byte)80, (byte)100, "Venusaur", (byte)80 },
                    { (byte)4, (byte)52, (byte)43, (byte)39, (byte)50, "Charmander", (byte)65 },
                    { (byte)5, (byte)64, (byte)58, (byte)58, (byte)65, "Charmeleon", (byte)80 },
                    { (byte)6, (byte)84, (byte)78, (byte)78, (byte)85, "Charizard", (byte)100 },
                    { (byte)7, (byte)48, (byte)65, (byte)44, (byte)50, "Squirtle", (byte)43 },
                    { (byte)8, (byte)63, (byte)80, (byte)59, (byte)65, "Wartortle", (byte)58 },
                    { (byte)9, (byte)83, (byte)100, (byte)79, (byte)85, "Blastoise", (byte)78 },
                    { (byte)10, (byte)30, (byte)35, (byte)45, (byte)20, "Caterpie", (byte)45 },
                    { (byte)11, (byte)20, (byte)55, (byte)50, (byte)25, "Metapod", (byte)30 },
                    { (byte)12, (byte)45, (byte)50, (byte)60, (byte)80, "Butterfree", (byte)70 },
                    { (byte)13, (byte)35, (byte)30, (byte)40, (byte)20, "Weedle", (byte)50 },
                    { (byte)14, (byte)25, (byte)50, (byte)45, (byte)25, "Kakuna", (byte)35 },
                    { (byte)15, (byte)80, (byte)40, (byte)65, (byte)45, "Beedrill", (byte)75 },
                    { (byte)16, (byte)45, (byte)40, (byte)40, (byte)35, "Pidgey", (byte)56 },
                    { (byte)18, (byte)80, (byte)75, (byte)83, (byte)70, "Pidgeot", (byte)91 },
                    { (byte)75, (byte)95, (byte)115, (byte)55, (byte)45, "Graveler", (byte)35 },
                    { (byte)37, (byte)41, (byte)40, (byte)38, (byte)65, "Vulpix", (byte)65 },
                    { (byte)39, (byte)45, (byte)20, (byte)115, (byte)25, "Jigglypuff", (byte)20 },
                    { (byte)59, (byte)110, (byte)80, (byte)90, (byte)80, "Arcanine", (byte)95 },
                    { (byte)60, (byte)50, (byte)40, (byte)40, (byte)40, "Poliwag", (byte)90 },
                    { (byte)61, (byte)65, (byte)65, (byte)65, (byte)50, "Poliwhirl", (byte)90 },
                    { (byte)62, (byte)85, (byte)95, (byte)90, (byte)70, "Poliwrath", (byte)70 },
                    { (byte)63, (byte)20, (byte)15, (byte)25, (byte)105, "Abra", (byte)90 },
                    { (byte)64, (byte)35, (byte)30, (byte)40, (byte)120, "Kadabra", (byte)105 },
                    { (byte)65, (byte)50, (byte)45, (byte)55, (byte)135, "Alakazam", (byte)120 },
                    { (byte)66, (byte)80, (byte)50, (byte)70, (byte)35, "Machop", (byte)35 },
                    { (byte)67, (byte)100, (byte)70, (byte)80, (byte)50, "Machoke", (byte)45 },
                    { (byte)68, (byte)130, (byte)80, (byte)90, (byte)65, "Machamp", (byte)55 },
                    { (byte)69, (byte)75, (byte)35, (byte)50, (byte)70, "Bellsprout", (byte)40 }
                });

            migrationBuilder.InsertData(
                table: "BaseStats",
                columns: new[] { "PokédexId", "Attack", "Defense", "HP", "Special", "Species", "Speed" },
                values: new object[,]
                {
                    { (byte)70, (byte)90, (byte)50, (byte)65, (byte)85, "Weepinbell", (byte)55 },
                    { (byte)71, (byte)105, (byte)65, (byte)80, (byte)100, "Victreebel", (byte)70 },
                    { (byte)72, (byte)40, (byte)35, (byte)40, (byte)100, "Tentacool", (byte)70 },
                    { (byte)73, (byte)70, (byte)65, (byte)80, (byte)120, "Tentacruel", (byte)100 },
                    { (byte)58, (byte)70, (byte)45, (byte)55, (byte)50, "Growlithe", (byte)60 },
                    { (byte)38, (byte)76, (byte)75, (byte)73, (byte)100, "Ninetales", (byte)100 },
                    { (byte)57, (byte)105, (byte)60, (byte)65, (byte)60, "Primeape", (byte)95 },
                    { (byte)55, (byte)82, (byte)78, (byte)80, (byte)80, "Golduck", (byte)85 },
                    { (byte)40, (byte)70, (byte)45, (byte)140, (byte)50, "Wigglytuff", (byte)45 },
                    { (byte)41, (byte)45, (byte)35, (byte)40, (byte)40, "Zubat", (byte)55 },
                    { (byte)42, (byte)80, (byte)70, (byte)75, (byte)75, "Golbat", (byte)90 },
                    { (byte)43, (byte)50, (byte)55, (byte)45, (byte)75, "Oddish", (byte)30 },
                    { (byte)44, (byte)65, (byte)70, (byte)60, (byte)85, "Gloom", (byte)40 },
                    { (byte)45, (byte)80, (byte)85, (byte)75, (byte)100, "Vileplume", (byte)50 },
                    { (byte)46, (byte)70, (byte)55, (byte)35, (byte)55, "Paras", (byte)25 },
                    { (byte)47, (byte)95, (byte)80, (byte)60, (byte)80, "Parasect", (byte)30 },
                    { (byte)48, (byte)55, (byte)50, (byte)60, (byte)40, "Venonat", (byte)45 },
                    { (byte)49, (byte)65, (byte)60, (byte)70, (byte)90, "Venomoth", (byte)90 },
                    { (byte)50, (byte)55, (byte)25, (byte)10, (byte)45, "Diglett", (byte)95 },
                    { (byte)51, (byte)80, (byte)50, (byte)35, (byte)70, "Dugtrio", (byte)120 },
                    { (byte)52, (byte)45, (byte)35, (byte)40, (byte)40, "Meowth", (byte)90 },
                    { (byte)53, (byte)70, (byte)60, (byte)65, (byte)65, "Persian", (byte)115 },
                    { (byte)54, (byte)52, (byte)48, (byte)50, (byte)50, "Psyduck", (byte)55 },
                    { (byte)56, (byte)80, (byte)35, (byte)40, (byte)35, "Mankey", (byte)70 },
                    { (byte)151, (byte)100, (byte)100, (byte)100, (byte)100, "Mew", (byte)100 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseStats");
        }
    }
}
