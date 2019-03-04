using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrekkShare.Data.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Caves_CaveDescriptions_CaveDescriptionId",
                table: "Caves");

            migrationBuilder.DropForeignKey(
                name: "FK_Caves_CaveCharacteristics_CharacteristicsId",
                table: "Caves");

            migrationBuilder.DropForeignKey(
                name: "FK_Caves_Towns_TownId",
                table: "Caves");

            migrationBuilder.DropForeignKey(
                name: "FK_Cottages_Mountains_MountainId",
                table: "Cottages");

            migrationBuilder.DropForeignKey(
                name: "FK_Mountains_Countries_CountryId",
                table: "Mountains");

            migrationBuilder.DropForeignKey(
                name: "FK_Mountains_Peaks_HighestPeakId",
                table: "Mountains");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipalities_Countries_CountryId",
                table: "Municipalities");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipalities_Provinces_ProvinceId",
                table: "Municipalities");

            migrationBuilder.DropForeignKey(
                name: "FK_Peaks_Countries_CountryId",
                table: "Peaks");

            migrationBuilder.DropForeignKey(
                name: "FK_Peaks_Mountains_PeakId",
                table: "Peaks");

            migrationBuilder.DropForeignKey(
                name: "FK_Rivers_Mountains_MountainId",
                table: "Rivers");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Mountains_MountainId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourists_User_UserId",
                table: "Tourists");

            migrationBuilder.DropForeignKey(
                name: "FK_TouristTrips_Tourists_TouristId",
                table: "TouristTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_TouristTrips_Trips_TripId",
                table: "TouristTrips");

            migrationBuilder.DropForeignKey(
                name: "FK_Towns_Municipalities_MunicipalityId",
                table: "Towns");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Cottages_CottageId",
                table: "Trips");

            migrationBuilder.DropTable(
                name: "CaveCharacteristics");

            migrationBuilder.DropTable(
                name: "CaveDescriptions");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Towns",
                table: "Towns");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TouristTrips",
                table: "TouristTrips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tourists",
                table: "Tourists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rivers",
                table: "Rivers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peaks",
                table: "Peaks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipalities",
                table: "Municipalities");

            migrationBuilder.DropIndex(
                name: "IX_Municipalities_ProvinceId",
                table: "Municipalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mountains",
                table: "Mountains");

            migrationBuilder.DropIndex(
                name: "IX_Mountains_CountryId",
                table: "Mountains");

            migrationBuilder.DropIndex(
                name: "IX_Mountains_HighestPeakId",
                table: "Mountains");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cottages",
                table: "Cottages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Caves",
                table: "Caves");

            migrationBuilder.DropIndex(
                name: "IX_Caves_CaveDescriptionId",
                table: "Caves");

            migrationBuilder.DropIndex(
                name: "IX_Caves_CharacteristicsId",
                table: "Caves");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tourists");

            migrationBuilder.DropColumn(
                name: "ProvinceId",
                table: "Municipalities");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Mountains");

            migrationBuilder.DropColumn(
                name: "HighestPeakId",
                table: "Mountains");

            migrationBuilder.DropColumn(
                name: "CaveDescriptionId",
                table: "Caves");

            migrationBuilder.DropColumn(
                name: "CharacteristicsId",
                table: "Caves");

            migrationBuilder.RenameTable(
                name: "Towns",
                newName: "Town");

            migrationBuilder.RenameTable(
                name: "TouristTrips",
                newName: "TouristTrip");

            migrationBuilder.RenameTable(
                name: "Tourists",
                newName: "Tourist");

            migrationBuilder.RenameTable(
                name: "Rivers",
                newName: "River");

            migrationBuilder.RenameTable(
                name: "Peaks",
                newName: "Peak");

            migrationBuilder.RenameTable(
                name: "Municipalities",
                newName: "Municipality");

            migrationBuilder.RenameTable(
                name: "Mountains",
                newName: "Mountain");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cottages",
                newName: "Cottage");

            migrationBuilder.RenameTable(
                name: "Caves",
                newName: "Cave");

            migrationBuilder.RenameIndex(
                name: "IX_Towns_MunicipalityId",
                table: "Town",
                newName: "IX_Town_MunicipalityId");

            migrationBuilder.RenameIndex(
                name: "IX_TouristTrips_TripId",
                table: "TouristTrip",
                newName: "IX_TouristTrip_TripId");

            migrationBuilder.RenameIndex(
                name: "IX_Tourists_UserId",
                table: "Tourist",
                newName: "IX_Tourist_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Rivers_MountainId",
                table: "River",
                newName: "IX_River_MountainId");

            migrationBuilder.RenameIndex(
                name: "IX_Peaks_CountryId",
                table: "Peak",
                newName: "IX_Peak_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Municipalities_CountryId",
                table: "Municipality",
                newName: "IX_Municipality_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cottages_MountainId",
                table: "Cottage",
                newName: "IX_Cottage_MountainId");

            migrationBuilder.RenameColumn(
                name: "TownId",
                table: "Cave",
                newName: "MountainId");

            migrationBuilder.RenameIndex(
                name: "IX_Caves_TownId",
                table: "Cave",
                newName: "IX_Cave_MountainId");

            migrationBuilder.AddColumn<double>(
                name: "EndLatitude",
                table: "Routes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "EndLongitude",
                table: "Routes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "StartLatitude",
                table: "Routes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "StartLongitude",
                table: "Routes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Cave",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Town",
                table: "Town",
                column: "TownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TouristTrip",
                table: "TouristTrip",
                columns: new[] { "TouristId", "TripId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tourist",
                table: "Tourist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_River",
                table: "River",
                column: "RiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peak",
                table: "Peak",
                column: "PeakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipality",
                table: "Municipality",
                column: "MunicipalityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mountain",
                table: "Mountain",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cottage",
                table: "Cottage",
                column: "CottageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cave",
                table: "Cave",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cave_Mountain_MountainId",
                table: "Cave",
                column: "MountainId",
                principalTable: "Mountain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cottage_Mountain_MountainId",
                table: "Cottage",
                column: "MountainId",
                principalTable: "Mountain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipality_Country_CountryId",
                table: "Municipality",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peak_Country_CountryId",
                table: "Peak",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peak_Mountain_PeakId",
                table: "Peak",
                column: "PeakId",
                principalTable: "Mountain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_River_Mountain_MountainId",
                table: "River",
                column: "MountainId",
                principalTable: "Mountain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Mountain_MountainId",
                table: "Routes",
                column: "MountainId",
                principalTable: "Mountain",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourist_User_UserId",
                table: "Tourist",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TouristTrip_Tourist_TouristId",
                table: "TouristTrip",
                column: "TouristId",
                principalTable: "Tourist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TouristTrip_Trips_TripId",
                table: "TouristTrip",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Town_Municipality_MunicipalityId",
                table: "Town",
                column: "MunicipalityId",
                principalTable: "Municipality",
                principalColumn: "MunicipalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Cottage_CottageId",
                table: "Trips",
                column: "CottageId",
                principalTable: "Cottage",
                principalColumn: "CottageId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cave_Mountain_MountainId",
                table: "Cave");

            migrationBuilder.DropForeignKey(
                name: "FK_Cottage_Mountain_MountainId",
                table: "Cottage");

            migrationBuilder.DropForeignKey(
                name: "FK_Municipality_Country_CountryId",
                table: "Municipality");

            migrationBuilder.DropForeignKey(
                name: "FK_Peak_Country_CountryId",
                table: "Peak");

            migrationBuilder.DropForeignKey(
                name: "FK_Peak_Mountain_PeakId",
                table: "Peak");

            migrationBuilder.DropForeignKey(
                name: "FK_River_Mountain_MountainId",
                table: "River");

            migrationBuilder.DropForeignKey(
                name: "FK_Routes_Mountain_MountainId",
                table: "Routes");

            migrationBuilder.DropForeignKey(
                name: "FK_Tourist_User_UserId",
                table: "Tourist");

            migrationBuilder.DropForeignKey(
                name: "FK_TouristTrip_Tourist_TouristId",
                table: "TouristTrip");

            migrationBuilder.DropForeignKey(
                name: "FK_TouristTrip_Trips_TripId",
                table: "TouristTrip");

            migrationBuilder.DropForeignKey(
                name: "FK_Town_Municipality_MunicipalityId",
                table: "Town");

            migrationBuilder.DropForeignKey(
                name: "FK_Trips_Cottage_CottageId",
                table: "Trips");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Town",
                table: "Town");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TouristTrip",
                table: "TouristTrip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tourist",
                table: "Tourist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_River",
                table: "River");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peak",
                table: "Peak");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Municipality",
                table: "Municipality");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mountain",
                table: "Mountain");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cottage",
                table: "Cottage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cave",
                table: "Cave");

            migrationBuilder.DropColumn(
                name: "EndLatitude",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "EndLongitude",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "StartLatitude",
                table: "Routes");

            migrationBuilder.DropColumn(
                name: "StartLongitude",
                table: "Routes");

            migrationBuilder.RenameTable(
                name: "Town",
                newName: "Towns");

            migrationBuilder.RenameTable(
                name: "TouristTrip",
                newName: "TouristTrips");

            migrationBuilder.RenameTable(
                name: "Tourist",
                newName: "Tourists");

            migrationBuilder.RenameTable(
                name: "River",
                newName: "Rivers");

            migrationBuilder.RenameTable(
                name: "Peak",
                newName: "Peaks");

            migrationBuilder.RenameTable(
                name: "Municipality",
                newName: "Municipalities");

            migrationBuilder.RenameTable(
                name: "Mountain",
                newName: "Mountains");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "Cottage",
                newName: "Cottages");

            migrationBuilder.RenameTable(
                name: "Cave",
                newName: "Caves");

            migrationBuilder.RenameIndex(
                name: "IX_Town_MunicipalityId",
                table: "Towns",
                newName: "IX_Towns_MunicipalityId");

            migrationBuilder.RenameIndex(
                name: "IX_TouristTrip_TripId",
                table: "TouristTrips",
                newName: "IX_TouristTrips_TripId");

            migrationBuilder.RenameIndex(
                name: "IX_Tourist_UserId",
                table: "Tourists",
                newName: "IX_Tourists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_River_MountainId",
                table: "Rivers",
                newName: "IX_Rivers_MountainId");

            migrationBuilder.RenameIndex(
                name: "IX_Peak_CountryId",
                table: "Peaks",
                newName: "IX_Peaks_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Municipality_CountryId",
                table: "Municipalities",
                newName: "IX_Municipalities_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cottage_MountainId",
                table: "Cottages",
                newName: "IX_Cottages_MountainId");

            migrationBuilder.RenameColumn(
                name: "MountainId",
                table: "Caves",
                newName: "TownId");

            migrationBuilder.RenameIndex(
                name: "IX_Cave_MountainId",
                table: "Caves",
                newName: "IX_Caves_TownId");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tourists",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProvinceId",
                table: "Municipalities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Mountains",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HighestPeakId",
                table: "Mountains",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Caves",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaveDescriptionId",
                table: "Caves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CharacteristicsId",
                table: "Caves",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Towns",
                table: "Towns",
                column: "TownId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TouristTrips",
                table: "TouristTrips",
                columns: new[] { "TouristId", "TripId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tourists",
                table: "Tourists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rivers",
                table: "Rivers",
                column: "RiverId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peaks",
                table: "Peaks",
                column: "PeakId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Municipalities",
                table: "Municipalities",
                column: "MunicipalityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mountains",
                table: "Mountains",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cottages",
                table: "Cottages",
                column: "CottageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Caves",
                table: "Caves",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CaveCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Depth = table.Column<double>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Temperature = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaveCharacteristics", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CaveDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "nvarchar(600)", nullable: false),
                    History = table.Column<string>(type: "nvarchar(600)", nullable: false),
                    Legend = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaveDescriptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Municipalities_ProvinceId",
                table: "Municipalities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Mountains_CountryId",
                table: "Mountains",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Mountains_HighestPeakId",
                table: "Mountains",
                column: "HighestPeakId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Caves_CaveDescriptionId",
                table: "Caves",
                column: "CaveDescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Caves_CharacteristicsId",
                table: "Caves",
                column: "CharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_CountryId",
                table: "Provinces",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Caves_CaveDescriptions_CaveDescriptionId",
                table: "Caves",
                column: "CaveDescriptionId",
                principalTable: "CaveDescriptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caves_CaveCharacteristics_CharacteristicsId",
                table: "Caves",
                column: "CharacteristicsId",
                principalTable: "CaveCharacteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Caves_Towns_TownId",
                table: "Caves",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "TownId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cottages_Mountains_MountainId",
                table: "Cottages",
                column: "MountainId",
                principalTable: "Mountains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mountains_Countries_CountryId",
                table: "Mountains",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mountains_Peaks_HighestPeakId",
                table: "Mountains",
                column: "HighestPeakId",
                principalTable: "Peaks",
                principalColumn: "PeakId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipalities_Countries_CountryId",
                table: "Municipalities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Municipalities_Provinces_ProvinceId",
                table: "Municipalities",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "ProvinceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Peaks_Countries_CountryId",
                table: "Peaks",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Peaks_Mountains_PeakId",
                table: "Peaks",
                column: "PeakId",
                principalTable: "Mountains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rivers_Mountains_MountainId",
                table: "Rivers",
                column: "MountainId",
                principalTable: "Mountains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Routes_Mountains_MountainId",
                table: "Routes",
                column: "MountainId",
                principalTable: "Mountains",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tourists_User_UserId",
                table: "Tourists",
                column: "UserId",
                principalTable: "User",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TouristTrips_Tourists_TouristId",
                table: "TouristTrips",
                column: "TouristId",
                principalTable: "Tourists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TouristTrips_Trips_TripId",
                table: "TouristTrips",
                column: "TripId",
                principalTable: "Trips",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Towns_Municipalities_MunicipalityId",
                table: "Towns",
                column: "MunicipalityId",
                principalTable: "Municipalities",
                principalColumn: "MunicipalityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Trips_Cottages_CottageId",
                table: "Trips",
                column: "CottageId",
                principalTable: "Cottages",
                principalColumn: "CottageId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
