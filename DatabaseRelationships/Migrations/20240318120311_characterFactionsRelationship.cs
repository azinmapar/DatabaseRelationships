using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseRelationships.Migrations
{
    /// <inheritdoc />
    public partial class characterFactionsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_characters_backpacks_BackpackId",
                table: "characters");

            migrationBuilder.DropForeignKey(
                name: "FK_weapons_characters_CharacterId",
                table: "weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_weapons",
                table: "weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_characters",
                table: "characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks");

            migrationBuilder.RenameTable(
                name: "weapons",
                newName: "Weapons");

            migrationBuilder.RenameTable(
                name: "characters",
                newName: "Characters");

            migrationBuilder.RenameTable(
                name: "backpacks",
                newName: "Backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_weapons_CharacterId",
                table: "Weapons",
                newName: "IX_Weapons_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_characters_BackpackId",
                table: "Characters",
                newName: "IX_Characters_BackpackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Characters",
                table: "Characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Factions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFactions",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false),
                    FactionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFactions", x => new { x.CharacterId, x.FactionsId });
                    table.ForeignKey(
                        name: "FK_CharacterFactions_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFactions_Factions_FactionsId",
                        column: x => x.FactionsId,
                        principalTable: "Factions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFactions_FactionsId",
                table: "CharacterFactions",
                column: "FactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Backpacks_BackpackId",
                table: "Characters",
                column: "BackpackId",
                principalTable: "Backpacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons",
                column: "CharacterId",
                principalTable: "Characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Backpacks_BackpackId",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Characters_CharacterId",
                table: "Weapons");

            migrationBuilder.DropTable(
                name: "CharacterFactions");

            migrationBuilder.DropTable(
                name: "Factions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Characters",
                table: "Characters");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Backpacks",
                table: "Backpacks");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "weapons");

            migrationBuilder.RenameTable(
                name: "Characters",
                newName: "characters");

            migrationBuilder.RenameTable(
                name: "Backpacks",
                newName: "backpacks");

            migrationBuilder.RenameIndex(
                name: "IX_Weapons_CharacterId",
                table: "weapons",
                newName: "IX_weapons_CharacterId");

            migrationBuilder.RenameIndex(
                name: "IX_Characters_BackpackId",
                table: "characters",
                newName: "IX_characters_BackpackId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_weapons",
                table: "weapons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_characters",
                table: "characters",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_backpacks",
                table: "backpacks",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_characters_backpacks_BackpackId",
                table: "characters",
                column: "BackpackId",
                principalTable: "backpacks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_weapons_characters_CharacterId",
                table: "weapons",
                column: "CharacterId",
                principalTable: "characters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
