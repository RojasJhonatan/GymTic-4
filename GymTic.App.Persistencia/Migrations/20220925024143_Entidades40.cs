using Microsoft.EntityFrameworkCore.Migrations;

namespace GymTic.App.Persistencia.Migrations
{
    public partial class Entidades40 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dieta_alimentacion_alimentacionid",
                table: "dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_dieta_categoriaNutricion_categoriaid",
                table: "dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_ejercicio_categoriaEjercicios_categoriaid",
                table: "ejercicio");

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
                name: "PK_ejercicio",
                table: "ejercicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_dieta",
                table: "dieta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_cliente",
                table: "cliente");

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
                name: "ejercicio",
                newName: "Ejercicio");

            migrationBuilder.RenameTable(
                name: "dieta",
                newName: "Dieta");

            migrationBuilder.RenameTable(
                name: "cliente",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "alimentacion",
                newName: "Alimentacion");

            migrationBuilder.RenameIndex(
                name: "IX_rutina_ejerciciosid",
                table: "Rutina",
                newName: "IX_Rutina_ejerciciosid");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_rutinaid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_rutinaid");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_nutricionid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_nutricionid");

            migrationBuilder.RenameIndex(
                name: "IX_planSaludable_clienteid",
                table: "PlanSaludable",
                newName: "IX_PlanSaludable_clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_nutricion_dietaid",
                table: "Nutricion",
                newName: "IX_Nutricion_dietaid");

            migrationBuilder.RenameIndex(
                name: "IX_ejercicio_categoriaid",
                table: "Ejercicio",
                newName: "IX_Ejercicio_categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_dieta_categoriaid",
                table: "Dieta",
                newName: "IX_Dieta_categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_dieta_alimentacionid",
                table: "Dieta",
                newName: "IX_Dieta_alimentacionid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rutina",
                table: "Rutina",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlanSaludable",
                table: "PlanSaludable",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Nutricion",
                table: "Nutricion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ejercicio",
                table: "Ejercicio",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dieta",
                table: "Dieta",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Alimentacion",
                table: "Alimentacion",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_Alimentacion_alimentacionid",
                table: "Dieta",
                column: "alimentacionid",
                principalTable: "Alimentacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_categoriaNutricion_categoriaid",
                table: "Dieta",
                column: "categoriaid",
                principalTable: "categoriaNutricion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ejercicio_categoriaEjercicios_categoriaid",
                table: "Ejercicio",
                column: "categoriaid",
                principalTable: "categoriaEjercicios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nutricion_Dieta_dietaid",
                table: "Nutricion",
                column: "dietaid",
                principalTable: "Dieta",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Cliente_clienteid",
                table: "PlanSaludable",
                column: "clienteid",
                principalTable: "Cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Nutricion_nutricionid",
                table: "PlanSaludable",
                column: "nutricionid",
                principalTable: "Nutricion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlanSaludable_Rutina_rutinaid",
                table: "PlanSaludable",
                column: "rutinaid",
                principalTable: "Rutina",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rutina_Ejercicio_ejerciciosid",
                table: "Rutina",
                column: "ejerciciosid",
                principalTable: "Ejercicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_Alimentacion_alimentacionid",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_categoriaNutricion_categoriaid",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Ejercicio_categoriaEjercicios_categoriaid",
                table: "Ejercicio");

            migrationBuilder.DropForeignKey(
                name: "FK_Nutricion_Dieta_dietaid",
                table: "Nutricion");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Cliente_clienteid",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Nutricion_nutricionid",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_PlanSaludable_Rutina_rutinaid",
                table: "PlanSaludable");

            migrationBuilder.DropForeignKey(
                name: "FK_Rutina_Ejercicio_ejerciciosid",
                table: "Rutina");

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
                name: "PK_Ejercicio",
                table: "Ejercicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dieta",
                table: "Dieta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

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
                name: "Ejercicio",
                newName: "ejercicio");

            migrationBuilder.RenameTable(
                name: "Dieta",
                newName: "dieta");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "cliente");

            migrationBuilder.RenameTable(
                name: "Alimentacion",
                newName: "alimentacion");

            migrationBuilder.RenameIndex(
                name: "IX_Rutina_ejerciciosid",
                table: "rutina",
                newName: "IX_rutina_ejerciciosid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_rutinaid",
                table: "planSaludable",
                newName: "IX_planSaludable_rutinaid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_nutricionid",
                table: "planSaludable",
                newName: "IX_planSaludable_nutricionid");

            migrationBuilder.RenameIndex(
                name: "IX_PlanSaludable_clienteid",
                table: "planSaludable",
                newName: "IX_planSaludable_clienteid");

            migrationBuilder.RenameIndex(
                name: "IX_Nutricion_dietaid",
                table: "nutricion",
                newName: "IX_nutricion_dietaid");

            migrationBuilder.RenameIndex(
                name: "IX_Ejercicio_categoriaid",
                table: "ejercicio",
                newName: "IX_ejercicio_categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_Dieta_categoriaid",
                table: "dieta",
                newName: "IX_dieta_categoriaid");

            migrationBuilder.RenameIndex(
                name: "IX_Dieta_alimentacionid",
                table: "dieta",
                newName: "IX_dieta_alimentacionid");

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
                name: "PK_ejercicio",
                table: "ejercicio",
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
                name: "PK_alimentacion",
                table: "alimentacion",
                column: "id");

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
                name: "FK_ejercicio_categoriaEjercicios_categoriaid",
                table: "ejercicio",
                column: "categoriaid",
                principalTable: "categoriaEjercicios",
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
    }
}
