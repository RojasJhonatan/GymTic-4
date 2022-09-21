using Microsoft.EntityFrameworkCore.Migrations;

namespace GymTic.App.Persistencia.Migrations
{
    public partial class Entidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_Alimentacion_AlimentacionId",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_CategoriaNutricion_CategoriaId",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutricion_Dieta_DietaId",
                table: "Nutricion");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Cliente_ClienteId",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Nutricion_NutricionId",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Rutina_RutinaId",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutina_Ejercicios_EjerciciosId",
                table: "Rutina");

            migrationBuilder.DropTable(
                name: "Ejercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rutina",
                table: "Rutina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlanSaludable",
                table: "PlanSaludable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Nutricion",
                table: "Nutricion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dieta",
                table: "Dieta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaNutricion",
                table: "CategoriaNutricion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CategoriaEjercicios",
                table: "CategoriaEjercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Alimentacion",
                table: "Alimentacion");

            migrationBuilder.RenameTable(
                name: "Rutina",
                newName: "rutina");

            migrationBuilder.RenameTable(
                name: "PlanSaludable",
                newName: "planSaludable");

            migrationBuilder.RenameTable(
                name: "Nutricion",
                newName: "nutricion");

            migrationBuilder.RenameTable(
                name: "Dieta",
                newName: "dieta");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "cliente");

            migrationBuilder.RenameTable(
                name: "CategoriaNutricion",
                newName: "categoriaNutricion");

            migrationBuilder.RenameTable(
                name: "CategoriaEjercicios",
                newName: "categoriaEjercicios");

            migrationBuilder.RenameTable(
                name: "Alimentacion",
                newName: "alimentacion");

            migrationBuilder.RenameColumn(
                name: "Horario",
                table: "rutina",
                newName: "horario");

            migrationBuilder.RenameColumn(
                name: "EjerciciosId",
                table: "rutina",
                newName: "ejerciciosid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "rutina",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Rutina_EjerciciosId",
                table: "rutina",
                newName: "IX_rutina_ejerciciosid");

            migrationBuilder.RenameColumn(
                name: "RutinaId",
                table: "planSaludable",
                newName: "rutinaid");

            migrationBuilder.RenameColumn(
                name: "NutricionId",
                table: "planSaludable",
                newName: "nutricionid");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "planSaludable",
                newName: "clienteid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "planSaludable",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_RutinaId",
                table: "planSaludable",
                newName: "IX_planSaludable_rutinaid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_NutricionId",
                table: "planSaludable",
                newName: "IX_planSaludable_nutricionid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_ClienteId",
                table: "planSaludable",
                newName: "IX_planSaludable_clienteid");

            migrationBuilder.RenameColumn(
                name: "PuntosVerificacion",
                table: "nutricion",
                newName: "puntosVerificacion");

            migrationBuilder.RenameColumn(
                name: "DietaId",
                table: "nutricion",
                newName: "dietaid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "nutricion",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Nutricion_DietaId",
                table: "nutricion",
                newName: "IX_nutricion_dietaid");

            migrationBuilder.RenameColumn(
                name: "Verificacion",
                table: "dieta",
                newName: "verificacion");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "dieta",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Duracion",
                table: "dieta",
                newName: "duracion");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "dieta",
                newName: "categoriaid");

            migrationBuilder.RenameColumn(
                name: "AlimentacionId",
                table: "dieta",
                newName: "alimentacionid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "dieta",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Dieta_CategoriaId",
                table: "dieta",
                newName: "IX_dieta_categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_Dieta_AlimentacionId",
                table: "dieta",
                newName: "IX_dieta_alimentacionid");

            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "cliente",
                newName: "peso");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "cliente",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "cliente",
                newName: "genero");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "cliente",
                newName: "eMail");

            migrationBuilder.RenameColumn(
                name: "Contraseña",
                table: "cliente",
                newName: "contraseña");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "cliente",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "Altura",
                table: "cliente",
                newName: "altura");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "cliente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "cliente",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "cliente",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "PuntosSaludables",
                table: "categoriaNutricion",
                newName: "puntosSaludables");

            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "categoriaNutricion",
                newName: "nombreCategoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categoriaNutricion",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "PuntosSaludables",
                table: "categoriaEjercicios",
                newName: "puntosSaludables");

            migrationBuilder.RenameColumn(
                name: "NombreCategoria",
                table: "categoriaEjercicios",
                newName: "nombreCategoria");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "categoriaEjercicios",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "DiasSemana",
                table: "alimentacion",
                newName: "diasSemana");

            migrationBuilder.RenameColumn(
                name: "Desayuno",
                table: "alimentacion",
                newName: "desayuno");

            migrationBuilder.RenameColumn(
                name: "Cena",
                table: "alimentacion",
                newName: "cena");

            migrationBuilder.RenameColumn(
                name: "Almuerzo",
                table: "alimentacion",
                newName: "almuerzo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "alimentacion",
                newName: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_rutina",
                table: "rutina",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_planSaludable",
                table: "planSaludable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_nutricion",
                table: "nutricion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_dieta",
                table: "dieta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_cliente",
                table: "cliente",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoriaNutricion",
                table: "categoriaNutricion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categoriaEjercicios",
                table: "categoriaEjercicios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_alimentacion",
                table: "alimentacion",
                column: "id");

            migrationBuilder.CreateTable(
                name: "ejercicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zonaCuerpo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    repeticiones = table.Column<int>(type: "int", nullable: false),
                    series = table.Column<int>(type: "int", nullable: false),
                    categoriaid = table.Column<int>(type: "int", nullable: true),
                    puntosSaludables = table.Column<int>(type: "int", nullable: false),
                    caloriasConsumidas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ejercicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_ejercicio_categoriaEjercicios_categoriaid",
                        column: x => x.categoriaid,
                        principalTable: "categoriaEjercicios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ejercicio_categoriaid",
                table: "ejercicio",
                column: "categoriaid");

            migrationBuilder.AddForeignKey(
                name: "FK_dieta_alimentacion_alimentacionid",
                table: "dieta",
                column: "alimentacionid",
                principalTable: "alimentacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_dieta_categoriaNutricion_categoriaid",
                table: "dieta",
                column: "categoriaid",
                principalTable: "categoriaNutricion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_nutricion_dieta_dietaid",
                table: "nutricion",
                column: "dietaid",
                principalTable: "dieta",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_planSaludable_cliente_clienteid",
                table: "planSaludable",
                column: "clienteid",
                principalTable: "cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_planSaludable_nutricion_nutricionid",
                table: "planSaludable",
                column: "nutricionid",
                principalTable: "nutricion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_planSaludable_rutina_rutinaid",
                table: "planSaludable",
                column: "rutinaid",
                principalTable: "rutina",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_rutina_ejercicio_ejerciciosid",
                table: "rutina",
                column: "ejerciciosid",
                principalTable: "ejercicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dieta_alimentacion_alimentacionid",
                table: "dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_dieta_categoriaNutricion_categoriaid",
                table: "dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_nutricion_dieta_dietaid",
                table: "nutricion");

            migrationBuilder.DropForeignKey(
                name: "FK_planSaludable_cliente_clienteid",
                table: "planSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_planSaludable_nutricion_nutricionid",
                table: "planSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_planSaludable_rutina_rutinaid",
                table: "planSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_rutina_ejercicio_ejerciciosid",
                table: "rutina");

            migrationBuilder.DropTable(
                name: "ejercicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rutina",
                table: "rutina");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planSaludable",
                table: "planSaludable");

            migrationBuilder.DropPrimaryKey(
                name: "PK_nutricion",
                table: "nutricion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dieta",
                table: "dieta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoriaNutricion",
                table: "categoriaNutricion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categoriaEjercicios",
                table: "categoriaEjercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_alimentacion",
                table: "alimentacion");

            migrationBuilder.RenameTable(
                name: "rutina",
                newName: "Rutina");

            migrationBuilder.RenameTable(
                name: "planSaludable",
                newName: "PlanSaludable");

            migrationBuilder.RenameTable(
                name: "nutricion",
                newName: "Nutricion");

            migrationBuilder.RenameTable(
                name: "dieta",
                newName: "Dieta");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "categoriaNutricion",
                newName: "CategoriaNutricion");

            migrationBuilder.RenameTable(
                name: "categoriaEjercicios",
                newName: "CategoriaEjercicios");

            migrationBuilder.RenameTable(
                name: "alimentacion",
                newName: "Alimentacion");

            migrationBuilder.RenameColumn(
                name: "horario",
                table: "Rutina",
                newName: "Horario");

            migrationBuilder.RenameColumn(
                name: "ejerciciosid",
                table: "Rutina",
                newName: "EjerciciosId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Rutina",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_rutina_ejerciciosid",
                table: "Rutina",
                newName: "IX_Rutina_EjerciciosId");

            migrationBuilder.RenameColumn(
                name: "rutinaid",
                table: "PlanSaludable",
                newName: "RutinaId");

            migrationBuilder.RenameColumn(
                name: "nutricionid",
                table: "PlanSaludable",
                newName: "NutricionId");

            migrationBuilder.RenameColumn(
                name: "clienteid",
                table: "PlanSaludable",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PlanSaludable",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_rutinaid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_RutinaId");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_nutricionid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_NutricionId");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_clienteid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_ClienteId");

            migrationBuilder.RenameColumn(
                name: "puntosVerificacion",
                table: "Nutricion",
                newName: "PuntosVerificacion");

            migrationBuilder.RenameColumn(
                name: "dietaid",
                table: "Nutricion",
                newName: "DietaId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Nutricion",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_nutricion_dietaid",
                table: "Nutricion",
                newName: "IX_Nutricion_DietaId");

            migrationBuilder.RenameColumn(
                name: "verificacion",
                table: "Dieta",
                newName: "Verificacion");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Dieta",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "duracion",
                table: "Dieta",
                newName: "Duracion");

            migrationBuilder.RenameColumn(
                name: "categoriaid",
                table: "Dieta",
                newName: "CategoriaId");

            migrationBuilder.RenameColumn(
                name: "alimentacionid",
                table: "Dieta",
                newName: "AlimentacionId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Dieta",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_dieta_categoriaid",
                table: "Dieta",
                newName: "IX_Dieta_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_dieta_alimentacionid",
                table: "Dieta",
                newName: "IX_Dieta_AlimentacionId");

            migrationBuilder.RenameColumn(
                name: "peso",
                table: "Cliente",
                newName: "Peso");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Cliente",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "genero",
                table: "Cliente",
                newName: "Genero");

            migrationBuilder.RenameColumn(
                name: "eMail",
                table: "Cliente",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "contraseña",
                table: "Cliente",
                newName: "Contraseña");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Cliente",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "altura",
                table: "Cliente",
                newName: "Altura");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Cliente",
                newName: "Teléfono");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Cliente",
                newName: "Dirección");

            migrationBuilder.RenameColumn(
                name: "puntosSaludables",
                table: "CategoriaNutricion",
                newName: "PuntosSaludables");

            migrationBuilder.RenameColumn(
                name: "nombreCategoria",
                table: "CategoriaNutricion",
                newName: "NombreCategoria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CategoriaNutricion",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "puntosSaludables",
                table: "CategoriaEjercicios",
                newName: "PuntosSaludables");

            migrationBuilder.RenameColumn(
                name: "nombreCategoria",
                table: "CategoriaEjercicios",
                newName: "NombreCategoria");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CategoriaEjercicios",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "diasSemana",
                table: "Alimentacion",
                newName: "DiasSemana");

            migrationBuilder.RenameColumn(
                name: "desayuno",
                table: "Alimentacion",
                newName: "Desayuno");

            migrationBuilder.RenameColumn(
                name: "cena",
                table: "Alimentacion",
                newName: "Cena");

            migrationBuilder.RenameColumn(
                name: "almuerzo",
                table: "Alimentacion",
                newName: "Almuerzo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Alimentacion",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rutina",
                table: "Rutina",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanSaludable",
                table: "PlanSaludable",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nutricion",
                table: "Nutricion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dieta",
                table: "Dieta",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaNutricion",
                table: "CategoriaNutricion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CategoriaEjercicios",
                table: "CategoriaEjercicios",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alimentacion",
                table: "Alimentacion",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ejercicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaloriasConsumidas = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PuntosSaludables = table.Column<int>(type: "int", nullable: false),
                    Repeticiones = table.Column<int>(type: "int", nullable: false),
                    Series = table.Column<int>(type: "int", nullable: false),
                    ZonaCuerpo = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateIndex(
                name: "IX_Ejercicios_CategoriaId",
                table: "Ejercicios",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_Alimentacion_AlimentacionId",
                table: "Dieta",
                column: "AlimentacionId",
                principalTable: "Alimentacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_CategoriaNutricion_CategoriaId",
                table: "Dieta",
                column: "CategoriaId",
                principalTable: "CategoriaNutricion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutricion_Dieta_DietaId",
                table: "Nutricion",
                column: "DietaId",
                principalTable: "Dieta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Cliente_ClienteId",
                table: "PlanSaludable",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Nutricion_NutricionId",
                table: "PlanSaludable",
                column: "NutricionId",
                principalTable: "Nutricion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Rutina_RutinaId",
                table: "PlanSaludable",
                column: "RutinaId",
                principalTable: "Rutina",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutina_Ejercicios_EjerciciosId",
                table: "Rutina",
                column: "EjerciciosId",
                principalTable: "Ejercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
