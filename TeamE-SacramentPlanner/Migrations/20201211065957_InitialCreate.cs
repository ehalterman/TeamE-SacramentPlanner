using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamE_SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MeetingProgram",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Presiding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conducting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpHymnNumber = table.Column<int>(type: "int", nullable: false),
                    Invocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SHymnNumber = table.Column<int>(type: "int", nullable: false),
                    MusicalNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClHymnName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClHymnNumber = table.Column<int>(type: "int", nullable: false),
                    Benediction = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingProgram", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Speaker",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeetingID = table.Column<int>(type: "int", nullable: false),
                    SpeakerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpeakerType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Speaker", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MeetingProgram");

            migrationBuilder.DropTable(
                name: "Speaker");
        }
    }
}
