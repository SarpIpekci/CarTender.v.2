using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace APIDataAccess.Migrations
{
    public partial class initial_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authorazition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AutherizationPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorazition", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDetailName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetail", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CorporateRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MessageContent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessageContent", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Modification",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModificationComponentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modification", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Package",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BidCount = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Package", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PageAuthorization",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PageAuthorizationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageAuthorization", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CarDetailValue",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarDetailValueName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarDetailID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarDetailValue", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarDetailValue_CarDetail_CarDetailID",
                        column: x => x.CarDetailID,
                        principalTable: "CarDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Town_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleAutherization",
                columns: table => new
                {
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    AuthorizationID = table.Column<int>(type: "int", nullable: false),
                    PageAuthorizationID = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAutherization", x => new { x.RoleID, x.AuthorizationID, x.PageAuthorizationID });
                    table.ForeignKey(
                        name: "FK_RoleAutherization_Authorazition_AuthorizationID",
                        column: x => x.AuthorizationID,
                        principalTable: "Authorazition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAutherization_PageAuthorization_PageAuthorizationID",
                        column: x => x.PageAuthorizationID,
                        principalTable: "PageAuthorization",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleAutherization_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstAndLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorporate = table.Column<bool>(type: "bit", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleID",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_User_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TownID = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.ID);
                    table.ForeignKey(
                        name: "FK_District_Town_TownID",
                        column: x => x.TownID,
                        principalTable: "Town",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BidInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BidName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCorporate = table.Column<bool>(type: "bit", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false),
                    FinishedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ApprovedBy = table.Column<int>(type: "int", nullable: true),
                    FinishedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BidInformation_User_ApprovedBy",
                        column: x => x.ApprovedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidInformation_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidInformation_User_FinishedBy",
                        column: x => x.FinishedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidInformation_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidInformation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Car_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Car_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MessageContentID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Message_MessageContent_MessageContentID",
                        column: x => x.MessageContentID,
                        principalTable: "MessageContent",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TramerComponent",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerComponentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerComponent", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TramerComponent_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhood",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhood", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Neighborhood_District_DistrictID",
                        column: x => x.DistrictID,
                        principalTable: "District",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BidStatusHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    BidID = table.Column<int>(type: "int", nullable: false),
                    StatuID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidStatusHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BidStatusHistory_BidInformation_BidID",
                        column: x => x.BidID,
                        principalTable: "BidInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BidStatusHistory_Status_StatuID",
                        column: x => x.StatuID,
                        principalTable: "Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Advert",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advert", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Advert_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Advert_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BidCar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BidID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    StartPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidCar", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BidCar_BidInformation_BidID",
                        column: x => x.BidID,
                        principalTable: "BidInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BidCar_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BidCar_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidCar_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CarBuyerInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBuyerInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarBuyerInformation_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CarBuyerInformation_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CarImage",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarImage", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarImage_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarModification",
                columns: table => new
                {
                    ModificationID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModification", x => new { x.ModificationID, x.CarID });
                    table.ForeignKey(
                        name: "FK_CarModification_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarModification_Modification_ModificationID",
                        column: x => x.ModificationID,
                        principalTable: "Modification",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarStatusHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CarStatuID = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatusHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarStatusHistory_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarStatusHistory_Status_CarStatuID",
                        column: x => x.CarStatuID,
                        principalTable: "Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CarStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CarStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CarValue",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CarValueID = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarValue", x => new { x.CarID, x.CarValueID });
                    table.ForeignKey(
                        name: "FK_CarValue_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CarValue_CarDetailValue_CarValueID",
                        column: x => x.CarValueID,
                        principalTable: "CarDetailValue",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TramerInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TramerInformation_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TramerInformation_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TramerInformation_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserCar",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCar", x => new { x.CarID, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserCar_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserCar_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "UserFavoriteCar",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFavoriteCar", x => new { x.UserID, x.CarID });
                    table.ForeignKey(
                        name: "FK_UserFavoriteCar_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_UserFavoriteCar_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "AddressInformation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NeighborhoodID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressInformation", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AddressInformation_Neighborhood_NeighborhoodID",
                        column: x => x.NeighborhoodID,
                        principalTable: "Neighborhood",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdvertStatusHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertID = table.Column<int>(type: "int", nullable: false),
                    StatuID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdvertStatusHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_AdvertStatusHistory_Advert_AdvertID",
                        column: x => x.AdvertID,
                        principalTable: "Advert",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AdvertStatusHistory_Status_StatuID",
                        column: x => x.StatuID,
                        principalTable: "Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AdvertStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_AdvertStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "TramerInformationComponent",
                columns: table => new
                {
                    TramerComponentID = table.Column<int>(type: "int", nullable: false),
                    TramerInformationID = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerInformationComponent", x => new { x.TramerInformationID, x.TramerComponentID });
                    table.ForeignKey(
                        name: "FK_TramerInformationComponent_TramerComponent_TramerComponentID",
                        column: x => x.TramerComponentID,
                        principalTable: "TramerComponent",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TramerInformationComponent_TramerInformation_TramerInformationID",
                        column: x => x.TramerInformationID,
                        principalTable: "TramerInformation",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Corporate",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorporateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporatePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressInformationID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporate", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Corporate_AddressInformation_AddressInformationID",
                        column: x => x.AddressInformationID,
                        principalTable: "AddressInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corporate_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expertise",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpertiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressInformationID = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expertise", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Expertise_AddressInformation_AddressInformationID",
                        column: x => x.AddressInformationID,
                        principalTable: "AddressInformation",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TramerStatusHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TramerInformationComponentID = table.Column<int>(type: "int", nullable: false),
                    TramerInformationComponentTramerInformationID = table.Column<int>(type: "int", nullable: true),
                    TramerInformationComponentTramerComponentID = table.Column<int>(type: "int", nullable: true),
                    StatuID = table.Column<int>(type: "int", nullable: false),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TramerStatusHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TramerStatusHistory_Status_StatuID",
                        column: x => x.StatuID,
                        principalTable: "Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TramerStatusHistory_TramerInformationComponent_TramerInformationComponentTramerInformationID_TramerInformationComponentTrame~",
                        columns: x => new { x.TramerInformationComponentTramerInformationID, x.TramerInformationComponentTramerComponentID },
                        principalTable: "TramerInformationComponent",
                        principalColumns: new[] { "TramerInformationID", "TramerComponentID" },
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TramerStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_TramerStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BidCorporateUser",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BidID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CorporateID = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidCorporateUser", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BidCorporateUser_BidInformation_BidID",
                        column: x => x.BidID,
                        principalTable: "BidInformation",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidCorporateUser_Corporate_CorporateID",
                        column: x => x.CorporateID,
                        principalTable: "Corporate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidCorporateUser_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidCorporateUser_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_BidCorporateUser_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CorporateStatusHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Information = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorporateID = table.Column<int>(type: "int", nullable: false),
                    StatuID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateStatusHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CorporateStatusHistory_Corporate_CorporateID",
                        column: x => x.CorporateID,
                        principalTable: "Corporate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CorporateStatusHistory_Status_StatuID",
                        column: x => x.StatuID,
                        principalTable: "Status",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CorporateStatusHistory_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CorporateStatusHistory_User_ModifiedBy",
                        column: x => x.ModifiedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "CorporateUser",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false),
                    CorporateID = table.Column<int>(type: "int", nullable: false),
                    CorporateRoleID = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorporateUser", x => new { x.CorporateID, x.UserID });
                    table.ForeignKey(
                        name: "FK_CorporateUser_Corporate_CorporateID",
                        column: x => x.CorporateID,
                        principalTable: "Corporate",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CorporateUser_CorporateRole_CorporateRoleID",
                        column: x => x.CorporateRoleID,
                        principalTable: "CorporateRole",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_CorporateUser_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PackageCorporate",
                columns: table => new
                {
                    CorporateID = table.Column<int>(type: "int", nullable: false),
                    PackageID = table.Column<int>(type: "int", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PackageCorporate", x => new { x.PackageID, x.CorporateID });
                    table.ForeignKey(
                        name: "FK_PackageCorporate_Corporate_CorporateID",
                        column: x => x.CorporateID,
                        principalTable: "Corporate",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PackageCorporate_Package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "Package",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BidUserOffer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BidCorporateUserID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidUserOffer", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BidUserOffer_BidCorporateUser_BidCorporateUserID",
                        column: x => x.BidCorporateUserID,
                        principalTable: "BidCorporateUser",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "BidOfferDetail",
                columns: table => new
                {
                    BidCarID = table.Column<int>(type: "int", nullable: false),
                    BidUserOfferID = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Version = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BidOfferDetail", x => new { x.BidCarID, x.BidUserOfferID });
                    table.ForeignKey(
                        name: "FK_BidOfferDetail_BidCar_BidCarID",
                        column: x => x.BidCarID,
                        principalTable: "BidCar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BidOfferDetail_BidUserOffer_BidUserOfferID",
                        column: x => x.BidUserOfferID,
                        principalTable: "BidUserOffer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddressInformation_NeighborhoodID",
                table: "AddressInformation",
                column: "NeighborhoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Advert_CarID",
                table: "Advert",
                column: "CarID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Advert_CreatedBy",
                table: "Advert",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatusHistory_AdvertID",
                table: "AdvertStatusHistory",
                column: "AdvertID");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatusHistory_CreatedBy",
                table: "AdvertStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatusHistory_ModifiedBy",
                table: "AdvertStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AdvertStatusHistory_StatuID",
                table: "AdvertStatusHistory",
                column: "StatuID");

            migrationBuilder.CreateIndex(
                name: "IX_BidCar_BidID",
                table: "BidCar",
                column: "BidID");

            migrationBuilder.CreateIndex(
                name: "IX_BidCar_CarID",
                table: "BidCar",
                column: "CarID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BidCar_CreatedBy",
                table: "BidCar",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidCar_ModifiedBy",
                table: "BidCar",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidCorporateUser_BidID",
                table: "BidCorporateUser",
                column: "BidID");

            migrationBuilder.CreateIndex(
                name: "IX_BidCorporateUser_CorporateID",
                table: "BidCorporateUser",
                column: "CorporateID");

            migrationBuilder.CreateIndex(
                name: "IX_BidCorporateUser_CreatedBy",
                table: "BidCorporateUser",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidCorporateUser_ModifiedBy",
                table: "BidCorporateUser",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidCorporateUser_UserID",
                table: "BidCorporateUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BidInformation_ApprovedBy",
                table: "BidInformation",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidInformation_CreatedBy",
                table: "BidInformation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidInformation_FinishedBy",
                table: "BidInformation",
                column: "FinishedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidInformation_ModifiedBy",
                table: "BidInformation",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidInformation_UserID",
                table: "BidInformation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BidOfferDetail_BidUserOfferID",
                table: "BidOfferDetail",
                column: "BidUserOfferID");

            migrationBuilder.CreateIndex(
                name: "IX_BidStatusHistory_BidID",
                table: "BidStatusHistory",
                column: "BidID");

            migrationBuilder.CreateIndex(
                name: "IX_BidStatusHistory_CreatedBy",
                table: "BidStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidStatusHistory_ModifiedBy",
                table: "BidStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BidStatusHistory_StatuID",
                table: "BidStatusHistory",
                column: "StatuID");

            migrationBuilder.CreateIndex(
                name: "IX_BidUserOffer_BidCorporateUserID",
                table: "BidUserOffer",
                column: "BidCorporateUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Car_CreatedBy",
                table: "Car",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Car_ModifiedBy",
                table: "Car",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CarBuyerInformation_CarID",
                table: "CarBuyerInformation",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarBuyerInformation_UserID",
                table: "CarBuyerInformation",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CarDetailValue_CarDetailID",
                table: "CarDetailValue",
                column: "CarDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_CarImage_CarID",
                table: "CarImage",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarModification_CarID",
                table: "CarModification",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatusHistory_CarID",
                table: "CarStatusHistory",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatusHistory_CarStatuID",
                table: "CarStatusHistory",
                column: "CarStatuID");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatusHistory_CreatedBy",
                table: "CarStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CarStatusHistory_ModifiedBy",
                table: "CarStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CarValue_CarValueID",
                table: "CarValue",
                column: "CarValueID");

            migrationBuilder.CreateIndex(
                name: "IX_Corporate_AddressInformationID",
                table: "Corporate",
                column: "AddressInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Corporate_CreatedBy",
                table: "Corporate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateStatusHistory_CorporateID",
                table: "CorporateStatusHistory",
                column: "CorporateID");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateStatusHistory_CreatedBy",
                table: "CorporateStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateStatusHistory_ModifiedBy",
                table: "CorporateStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateStatusHistory_StatuID",
                table: "CorporateStatusHistory",
                column: "StatuID");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateUser_CorporateRoleID",
                table: "CorporateUser",
                column: "CorporateRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_CorporateUser_UserID",
                table: "CorporateUser",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_District_TownID",
                table: "District",
                column: "TownID");

            migrationBuilder.CreateIndex(
                name: "IX_Expertise_AddressInformationID",
                table: "Expertise",
                column: "AddressInformationID");

            migrationBuilder.CreateIndex(
                name: "IX_Message_MessageContentID",
                table: "Message",
                column: "MessageContentID");

            migrationBuilder.CreateIndex(
                name: "IX_Message_UserID",
                table: "Message",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhood_DistrictID",
                table: "Neighborhood",
                column: "DistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_PackageCorporate_CorporateID",
                table: "PackageCorporate",
                column: "CorporateID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleAutherization_AuthorizationID",
                table: "RoleAutherization",
                column: "AuthorizationID");

            migrationBuilder.CreateIndex(
                name: "IX_RoleAutherization_PageAuthorizationID",
                table: "RoleAutherization",
                column: "PageAuthorizationID");

            migrationBuilder.CreateIndex(
                name: "IX_Town_CityID",
                table: "Town",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_TramerComponent_CreatedBy",
                table: "TramerComponent",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TramerInformation_CarID",
                table: "TramerInformation",
                column: "CarID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TramerInformation_CreatedBy",
                table: "TramerInformation",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TramerInformation_ModifiedBy",
                table: "TramerInformation",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TramerInformationComponent_TramerComponentID",
                table: "TramerInformationComponent",
                column: "TramerComponentID");

            migrationBuilder.CreateIndex(
                name: "IX_TramerStatusHistory_CreatedBy",
                table: "TramerStatusHistory",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TramerStatusHistory_ModifiedBy",
                table: "TramerStatusHistory",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_TramerStatusHistory_StatuID",
                table: "TramerStatusHistory",
                column: "StatuID");

            migrationBuilder.CreateIndex(
                name: "IX_TramerStatusHistory_TramerInformationComponentTramerInformationID_TramerInformationComponentTramerComponentID",
                table: "TramerStatusHistory",
                columns: new[] { "TramerInformationComponentTramerInformationID", "TramerInformationComponentTramerComponentID" });

            migrationBuilder.CreateIndex(
                name: "IX_User_ApprovedBy",
                table: "User",
                column: "ApprovedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCar_UserID",
                table: "UserCar",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFavoriteCar_CarID",
                table: "UserFavoriteCar",
                column: "CarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdvertStatusHistory");

            migrationBuilder.DropTable(
                name: "BidOfferDetail");

            migrationBuilder.DropTable(
                name: "BidStatusHistory");

            migrationBuilder.DropTable(
                name: "CarBuyerInformation");

            migrationBuilder.DropTable(
                name: "CarImage");

            migrationBuilder.DropTable(
                name: "CarModification");

            migrationBuilder.DropTable(
                name: "CarStatusHistory");

            migrationBuilder.DropTable(
                name: "CarValue");

            migrationBuilder.DropTable(
                name: "CorporateStatusHistory");

            migrationBuilder.DropTable(
                name: "CorporateUser");

            migrationBuilder.DropTable(
                name: "Expertise");

            migrationBuilder.DropTable(
                name: "Message");

            migrationBuilder.DropTable(
                name: "PackageCorporate");

            migrationBuilder.DropTable(
                name: "RoleAutherization");

            migrationBuilder.DropTable(
                name: "TramerStatusHistory");

            migrationBuilder.DropTable(
                name: "UserCar");

            migrationBuilder.DropTable(
                name: "UserFavoriteCar");

            migrationBuilder.DropTable(
                name: "Advert");

            migrationBuilder.DropTable(
                name: "BidCar");

            migrationBuilder.DropTable(
                name: "BidUserOffer");

            migrationBuilder.DropTable(
                name: "Modification");

            migrationBuilder.DropTable(
                name: "CarDetailValue");

            migrationBuilder.DropTable(
                name: "CorporateRole");

            migrationBuilder.DropTable(
                name: "MessageContent");

            migrationBuilder.DropTable(
                name: "Package");

            migrationBuilder.DropTable(
                name: "Authorazition");

            migrationBuilder.DropTable(
                name: "PageAuthorization");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "TramerInformationComponent");

            migrationBuilder.DropTable(
                name: "BidCorporateUser");

            migrationBuilder.DropTable(
                name: "CarDetail");

            migrationBuilder.DropTable(
                name: "TramerComponent");

            migrationBuilder.DropTable(
                name: "TramerInformation");

            migrationBuilder.DropTable(
                name: "BidInformation");

            migrationBuilder.DropTable(
                name: "Corporate");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "AddressInformation");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Neighborhood");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
