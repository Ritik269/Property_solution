using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Findpropertymain.Migrations
{
    public partial class ritik : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PropertyType",
                columns: table => new
                {
                    PropTypeId = table.Column<short>(type: "smallint", nullable: false),
                    TypeNmae = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Property__DA74BA7E448B61CC", x => x.PropTypeId);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    TypeId = table.Column<short>(type: "smallint", nullable: false),
                    TypeName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserType__516F03B55AC3B524", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    UserMobileNumber = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    UserEmailId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    UserPassword = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    TypeId = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK__Users__TypeId__3E52440B",
                        column: x => x.TypeId,
                        principalTable: "UserType",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PropertyName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    BHK_Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Floor_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Total_Floor_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PropertyAge = table.Column<short>(type: "smallint", nullable: false),
                    Property_Facing = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Locality = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Street_Area = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    PropertyPrice = table.Column<long>(type: "bigint", nullable: false),
                    Images = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    PropTypeId = table.Column<short>(type: "smallint", nullable: true),
                    OwnerId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyId);
                    table.ForeignKey(
                        name: "FK__Property__OwnerI__403A8C7D",
                        column: x => x.OwnerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Property__PropTy__3F466844",
                        column: x => x.PropTypeId,
                        principalTable: "PropertyType",
                        principalColumn: "PropTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Interested_Customer",
                columns: table => new
                {
                    CustomerId = table.Column<short>(type: "smallint", nullable: false),
                    PropertyId = table.Column<short>(type: "smallint", nullable: false),
                    DateOfInterest = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Interest__E3A2FEAB2AA52DB1", x => new { x.CustomerId, x.PropertyId });
                    table.ForeignKey(
                        name: "FK__Intereste__Custo__4316F928",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Intereste__Prope__440B1D61",
                        column: x => x.PropertyId,
                        principalTable: "Property",
                        principalColumn: "PropertyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interested_Customer_PropertyId",
                table: "Interested_Customer",
                column: "PropertyId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_OwnerId",
                table: "Property",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Property_PropTypeId",
                table: "Property",
                column: "PropTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TypeId",
                table: "Users",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__09C7B32C32D6BA5B",
                table: "Users",
                column: "UserEmailId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__8C28638FF8799D03",
                table: "Users",
                column: "UserMobileNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Interested_Customer");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PropertyType");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
