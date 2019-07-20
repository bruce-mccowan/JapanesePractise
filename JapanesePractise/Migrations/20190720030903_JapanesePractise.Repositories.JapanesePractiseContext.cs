using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JapanesePractise.Migrations
{
    public partial class JapanesePractiseRepositoriesJapanesePractiseContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    IdWord = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    English = table.Column<string>(nullable: true),
                    Romanji = table.Column<string>(nullable: true),
                    HiraganaKatakana = table.Column<string>(nullable: true),
                    Kanji = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Affirmative = table.Column<string>(nullable: true),
                    Negative = table.Column<string>(nullable: true),
                    CanBeTopic = table.Column<bool>(nullable: true),
                    CanBeSubject = table.Column<bool>(nullable: true),
                    CanBeLocation = table.Column<bool>(nullable: true),
                    PoliteFormAffirmative = table.Column<string>(nullable: true),
                    PoliteFormNegative = table.Column<string>(nullable: true),
                    PoliteFormQuestionDo = table.Column<string>(nullable: true),
                    PoliteFormQuestionWill = table.Column<string>(nullable: true),
                    CasualFormAffirmative = table.Column<string>(nullable: true),
                    CasualFormNegative = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.IdWord);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");
        }
    }
}
