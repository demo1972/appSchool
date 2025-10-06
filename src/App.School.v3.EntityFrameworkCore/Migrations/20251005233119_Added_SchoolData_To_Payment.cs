using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.School.v3.Migrations
{
    /// <inheritdoc />
    public partial class Added_SchoolData_To_Payment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentTutors_Tutors_TutorsId",
                table: "StudentTutors");

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "Tutors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TaxAddress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaxCode",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaxEmailAdress",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TaxFullName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "StudentPayments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "SchoolYears",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "PaymentConcepts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "GroupSchools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SchoolDataId",
                table: "EducationLevels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Tutors_SchoolDataId",
                table: "Tutors",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_SchoolDataId",
                table: "Teachers",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolDataId",
                table: "Students",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPayments_SchoolDataId",
                table: "StudentPayments",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_SchoolYears_SchoolDataId",
                table: "SchoolYears",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentConcepts_SchoolDataId",
                table: "PaymentConcepts",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupSchools_SchoolDataId",
                table: "GroupSchools",
                column: "SchoolDataId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationLevels_SchoolDataId",
                table: "EducationLevels",
                column: "SchoolDataId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationLevels_SchoolsDatas_SchoolDataId",
                table: "EducationLevels",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupSchools_SchoolsDatas_SchoolDataId",
                table: "GroupSchools",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentConcepts_SchoolsDatas_SchoolDataId",
                table: "PaymentConcepts",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SchoolYears_SchoolsDatas_SchoolDataId",
                table: "SchoolYears",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentPayments_SchoolsDatas_SchoolDataId",
                table: "StudentPayments",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_SchoolsDatas_SchoolDataId",
                table: "Students",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTutors_Tutors_TutorsId",
                table: "StudentTutors",
                column: "TutorsId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_SchoolsDatas_SchoolDataId",
                table: "Teachers",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tutors_SchoolsDatas_SchoolDataId",
                table: "Tutors",
                column: "SchoolDataId",
                principalTable: "SchoolsDatas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationLevels_SchoolsDatas_SchoolDataId",
                table: "EducationLevels");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupSchools_SchoolsDatas_SchoolDataId",
                table: "GroupSchools");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentConcepts_SchoolsDatas_SchoolDataId",
                table: "PaymentConcepts");

            migrationBuilder.DropForeignKey(
                name: "FK_SchoolYears_SchoolsDatas_SchoolDataId",
                table: "SchoolYears");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentPayments_SchoolsDatas_SchoolDataId",
                table: "StudentPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_SchoolsDatas_SchoolDataId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentTutors_Tutors_TutorsId",
                table: "StudentTutors");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_SchoolsDatas_SchoolDataId",
                table: "Teachers");

            migrationBuilder.DropForeignKey(
                name: "FK_Tutors_SchoolsDatas_SchoolDataId",
                table: "Tutors");

            migrationBuilder.DropIndex(
                name: "IX_Tutors_SchoolDataId",
                table: "Tutors");

            migrationBuilder.DropIndex(
                name: "IX_Teachers_SchoolDataId",
                table: "Teachers");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolDataId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_StudentPayments_SchoolDataId",
                table: "StudentPayments");

            migrationBuilder.DropIndex(
                name: "IX_SchoolYears_SchoolDataId",
                table: "SchoolYears");

            migrationBuilder.DropIndex(
                name: "IX_PaymentConcepts_SchoolDataId",
                table: "PaymentConcepts");

            migrationBuilder.DropIndex(
                name: "IX_GroupSchools_SchoolDataId",
                table: "GroupSchools");

            migrationBuilder.DropIndex(
                name: "IX_EducationLevels_SchoolDataId",
                table: "EducationLevels");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "Tutors");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TaxAddress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TaxCode",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TaxEmailAdress",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "TaxFullName",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "StudentPayments");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "SchoolYears");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "PaymentConcepts");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "GroupSchools");

            migrationBuilder.DropColumn(
                name: "SchoolDataId",
                table: "EducationLevels");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentTutors_Tutors_TutorsId",
                table: "StudentTutors",
                column: "TutorsId",
                principalTable: "Tutors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
