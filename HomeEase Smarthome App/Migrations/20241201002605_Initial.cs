using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeEase_Smarthome_App.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "NotificationMethod",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "Recurrence",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Reminders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Reminders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Reminders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NotificationMethod",
                table: "Reminders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Reminders",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Recurrence",
                table: "Reminders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Reminders",
                type: "int",
                nullable: true);
        }
    }
}
