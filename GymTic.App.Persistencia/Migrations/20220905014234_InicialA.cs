using Microsoft.EntityFrameworkCore.Migrations;

namespace GymTic.App.Persistencia.Migrations
{
    public partial class InicialA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Alimentacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desayuno = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Almuerzo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiasSemana = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaEjercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntosSaludables = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaEjercicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriaNutricion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCategoria = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntosSaludables = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaNutricion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Teléfono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dirección = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<float>(type: "real", nullable: false),
                    Altura = table.Column<float>(type: "real", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ejercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZonaCuerpo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Repeticiones = table.Column<int>(type: "int", nullable: false),
                    Series = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    PuntosSaludables = table.Column<int>(type: "int", nullable: false),
                    CaloriasConsumidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ejercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ejercicios_CategoriaEjercicios_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaEjercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dieta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlimentacionId = table.Column<int>(type: "int", nullable: true),
                    Duracion = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    Verificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dieta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dieta_Alimentacion_AlimentacionId",
                        column: x => x.AlimentacionId,
                        principalTable: "Alimentacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dieta_CategoriaNutricion_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "CategoriaNutricion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rutina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EjerciciosId = table.Column<int>(type: "int", nullable: true),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutina", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rutina_Ejercicios_EjerciciosId",
                        column: x => x.EjerciciosId,
                        principalTable: "Ejercicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Nutricion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DietaId = table.Column<int>(type: "int", nullable: true),
                    PuntosVerificacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nutricion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nutricion_Dieta_DietaId",
                        column: x => x.DietaId,
                        principalTable: "Dieta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlanSaludable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RutinaId = table.Column<int>(type: "int", nullable: true),
                    NutricionId = table.Column<int>(type: "int", nullable: true),
                    ClienteId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanSaludable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanSaludable_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanSaludable_Nutricion_NutricionId",
                        column: x => x.NutricionId,
                        principalTable: "Nutricion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlanSaludable_Rutina_RutinaId",
                        column: x => x.RutinaId,
                        principalTable: "Rutina",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dieta_AlimentacionId",
                table: "Dieta",
                column: "AlimentacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dieta_CategoriaId",
                table: "Dieta",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Ejercicios_CategoriaId",
                table: "Ejercicios",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nutricion_DietaId",
                table: "Nutricion",
                column: "DietaId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanSaludable_ClienteId",
                table: "PlanSaludable",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanSaludable_NutricionId",
                table: "PlanSaludable",
                column: "NutricionId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanSaludable_RutinaId",
                table: "PlanSaludable",
                column: "RutinaId");

            migrationBuilder.CreateIndex(
                name: "IX_Rutina_EjerciciosId",
                table: "Rutina",
                column: "EjerciciosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanSaludable");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Nutricion");

            migrationBuilder.DropTable(
                name: "Rutina");

            migrationBuilder.DropTable(
                name: "Dieta");

            migrationBuilder.DropTable(
                name: "Ejercicios");

            migrationBuilder.DropTable(
                name: "Alimentacion");

            migrationBuilder.DropTable(
                name: "CategoriaNutricion");

            migrationBuilder.DropTable(
                name: "CategoriaEjercicios");
        }
    }
}
