using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryEF.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bookingDates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingDates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TotalProfit = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AppUserId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gender = table.Column<int>(type: "int", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageId = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.AppUserId);
                    table.ForeignKey(
                        name: "FK_Customers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "bookingChecks",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    BookingDateId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookingDateId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingChecks", x => new { x.RoomId, x.BookingDateId });
                    table.ForeignKey(
                        name: "FK_bookingChecks_bookingDates_BookingDateId1",
                        column: x => x.BookingDateId1,
                        principalTable: "bookingDates",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<double>(type: "float", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreditCard_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "AppUserId");
                });

            migrationBuilder.CreateTable(
                name: "Hotel_Managers",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel_Managers", x => x.AppUserId);
                    table.ForeignKey(
                        name: "FK_Hotel_Managers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hotel_ManagerId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsConfermed = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hotels_Hotel_Managers_Hotel_ManagerId",
                        column: x => x.Hotel_ManagerId,
                        principalTable: "Hotel_Managers",
                        principalColumn: "AppUserId");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "AppUserId");
                    table.ForeignKey(
                        name: "FK_Reviews_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Room_Num = table.Column<int>(type: "int", nullable: false),
                    NumOfAdults = table.Column<int>(type: "int", nullable: false),
                    Cost_Per_Night = table.Column<double>(type: "float", nullable: false),
                    ISavailable = table.Column<bool>(type: "bit", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    IsNormalRoom = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "image",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_image_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_image_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_image_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "normal_Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Type_Of_Room = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_normal_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_normal_Rooms_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Suits",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Num_Of_Rooms = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suits", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Suits_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "ImageId", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[,]
                {
                    { "1", 0, "sowhag", "864149d2-53fc-4ba2-8225-9678e3cae934", "Egypt", null, false, null, false, false, null, "12345678901234", null, "AHMED", "Ag1234#", null, false, "82dd17e5-f244-4830-9ebb-1c8ceeb0d3a1", "jijdijdied", false, "ahmed", 0 },
                    { "2", 0, "sowhag", "08dffdf6-eced-4c1b-9d56-b5b8643dde8b", "Egypt", null, false, null, false, false, null, "12345678901234", null, "MAHMOD", "Ag1234#", null, false, "907e38c9-f455-4d9e-9c20-5c54ce84ee6a", "jijdijdied", false, "Mahmod", 0 },
                    { "22", 0, "sowhag", "df52c170-653a-49e6-8932-462671a1528a", "Egypt", null, false, null, false, false, null, "12345678901234", null, "SARA", "AQAAAAIAAYagAAAAEI5ZO8VZttKTq1PRDEllj0x48WuBLarQ0WcORmDm+TWdXW5c3c9qygjRRt6FBOOGLQ==", null, false, "174bf12d-9b27-428c-8f08-e9a252f9e3ce", "jijdijdied", false, "sara", 0 }
                });

            migrationBuilder.InsertData(
                table: "bookingDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { new Guid("0118c49c-77fb-49b8-bc00-ac921e34467d"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0324cb46-b549-4d5c-a5d8-c84d91ba05ba"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03710575-6852-4967-92eb-accabb3c8055"), new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0475ffd6-18ec-42a0-8d94-1c0f50dea010"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04dcdd50-5736-482f-b03a-139cff594ae6"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05bc86a6-3c04-464b-ae6b-ef2fcbd13650"), new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05d2db0e-55eb-4bc3-863f-d6b2ab41e1dd"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05d38ec2-0a2b-416f-b703-37e9795978a2"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05f31d8f-c2c1-4492-bd41-261dace73a52"), new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("074700f8-2d3d-4452-b253-36560bf58df0"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0884168d-1980-438f-9969-de81bc263529"), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0909978b-6799-46ab-a721-28a0fbca3328"), new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a0715df-5f76-46b2-99c8-4119f1a7d48e"), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a2d25a5-24a2-4860-a860-f730a80fbe71"), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0af6c8f3-8971-4a80-b973-ba53960c5552"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b586fef-6907-4e13-9fcc-367f3adc5749"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0bde81d1-a9b6-445d-8f67-b3131b60ffd6"), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c47f97d-0a1d-41b7-ae99-a9b88e6590da"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cb5b21f-c770-4b60-9a84-16bc61900ff0"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cc1ebf6-b1fc-40e4-82dd-3c8eda2d3ed5"), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d046ebb-06df-448d-9447-726dd0fa494c"), new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d7c5f79-6e93-4b45-af32-7c83fa01870f"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d9ffd45-b863-4fee-88fb-e5a9dfa44d19"), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e263530-2a76-48ac-a502-7a192c5af61c"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f36c74e-b37a-4e86-8910-19b5d05c833b"), new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ffedeca-5eaf-4132-aad7-e72342cbc45b"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10668445-7aca-4386-b48e-8ad901feb878"), new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("106ec79e-69fa-4f53-9066-31da3612e194"), new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10d4ea03-5b8f-4dad-839a-540cba10a07f"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("117bd323-0486-4924-aa21-36b22a772619"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("123506c6-e06b-4869-9785-bf1a8775c096"), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12964388-4d92-4085-85b5-6796aa93df73"), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("14dd0d7a-2edc-4b68-8189-8e4b906e5974"), new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("151a1bf6-2901-48e9-8a51-a403ec646e26"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1549c0e7-e89c-4bac-9305-31c5eea0294a"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("163d8db9-4dda-4ca5-88df-9b42bfc489b6"), new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("169f497b-9709-4411-8432-b74c8a421a87"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1709d8c2-9076-4c76-b560-e54cca9c62b1"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17130153-3251-4f06-9bf9-058534be1ac7"), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("181f9232-b2f1-4954-b092-ca403f28b678"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("196c66f1-ac06-4410-9af7-fb4d6a0bfd73"), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b082045-402f-43cb-9858-5bb99114273a"), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ce65dfb-adc7-4c6b-870e-e7bd3264f1a1"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1dd7c89e-e3ef-4c15-a8bf-d170d4b4b90b"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e07e842-c4ef-44ba-bf0d-6797a92b8daf"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1efcd2bc-5c08-4bc4-88c7-956bf47889e4"), new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f1c7583-4ed7-49a9-9bf2-b34a561afbd0"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f956bda-55fe-46f4-8827-066a2ab52b93"), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2092f522-663f-4a2f-8d85-1ebc79b32ce4"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20ad64d5-d21d-4010-add6-3cfe3af44008"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2133a1d0-99d2-487d-9d2f-4c87231dffbc"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("219c9a5a-c0ff-4ce1-8b99-c9f80637d588"), new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21fe3012-5caf-41c1-956b-0b93bb81b1ee"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23de3d85-5626-4da5-8dd9-40297b9eea41"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24e05370-bcec-468d-8ecb-a2373acdf00a"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24f8bc06-477b-48b9-9e11-16d3048ead73"), new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2549dc8f-97ee-4a11-976c-572bc39a329f"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("264aec7c-1ebb-44d1-a59c-8bebe37993a5"), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("275c5dcc-7262-4c9b-ba32-b3eb63cf95a9"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("279ff62d-9eb2-4d66-8e40-718c22f3e764"), new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b0aad6d-d4d5-438a-87d1-c33729ed753e"), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d3d50c5-1139-4635-beb9-a2d81a72b249"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d58d830-1c7c-4b41-9e8a-89a2af2f6bb6"), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dd5e749-c9b6-4efd-8064-0faa32bc8948"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2deba158-0d30-4870-ab1b-207755e1484c"), new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e0b0941-06cf-47cb-aee1-de995557f303"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e19689c-549e-4ca5-85cd-ac3a2d5b95a9"), new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e446b1f-9cae-4278-be3c-a481a9456f5f"), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ec05320-e519-489c-bce4-b01a634b3507"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f5dadae-2ef7-47cf-8a81-56cf2dfa3eb7"), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2fe35a15-934f-4622-844b-1ed6cda383a2"), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3063ca31-adaf-4380-b3b5-e2829f562065"), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31234a48-3953-4570-a3cb-6c98465465e0"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("316d0229-8746-4252-827b-27f0ea159d8c"), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31d64887-b8d2-4ecd-8a6c-d03fdc978ab0"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31f3e6f5-74eb-40d4-83d9-16f270dbdf06"), new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3273c4d3-5000-44ae-9d8b-ef8242d66e1c"), new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33143224-7daa-442e-904f-071766a5c0c8"), new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("336b53cf-629a-4247-87a9-7a036cbe4edf"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("336e1f99-faf9-48dc-91da-a027cba6cd8c"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("344b1ce0-0619-4d25-9510-36e695b1ee5f"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("359ecd29-3f9c-441e-bd54-158bb71d2e8d"), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36f5b800-559b-4e9e-bd70-8b3ad3c36177"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3704bdec-25f2-424c-bf09-31d6f5ad0b98"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37ab737c-a798-478d-a230-46246bf4c9c0"), new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37dcfdff-a71a-4ef7-9026-8a97c280082d"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37ffdddf-011f-49e8-bfc9-786e29f9743b"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3819a4b0-9a99-4956-adc4-6d4f579c7e81"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("386f3f0f-eab7-47af-8018-6744a2a3e3c3"), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("38f900fb-ffc2-4847-9d5e-17eabe696a60"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3902eb16-c391-4648-a8d1-de0be197018a"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("399e362a-5e61-4a70-aaa7-9481428c235f"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ad33114-6a50-400d-b176-e9e07af97c00"), new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3bb1e990-cdcd-4ca6-8373-4529bf696717"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c56820f-c4a8-4cc1-a39f-e1a886c9f0a4"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ca4503c-c7f2-4094-9552-75f802af0764"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3df29c05-78e2-4974-87ac-ae0046b34cda"), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f27c113-58b0-4e09-bbf2-41fd84f07b36"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f5a0db1-e4f4-448f-8d42-456ee82bba99"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40934eda-2d7e-452c-bff5-d6ffcaecf52c"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40e1d4fa-0399-45fd-9c52-8714598d1d90"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41cbea45-43c2-4e1e-aaf9-0df467550dcf"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("423e1d7c-ba12-4c5e-8a41-2232caa068b3"), new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("448a31ba-38c6-4cd8-9449-91817ff975d7"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4540211f-0d29-4795-8f9b-9b5ed5b0ecab"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45451b9a-5d90-4f35-847e-27f950dcde2b"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4638a5d1-29ba-4b50-9a8b-ce293839ae9e"), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("477312a6-189a-4e36-bfea-eebd549cd9e1"), new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("48ef4f9c-2aae-4c5a-9ad0-0b02c4784470"), new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49943b99-1e34-4f1a-b7ad-a98dadaa9cd8"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a3a9420-15ca-4aa1-aeb2-0c02829bf1da"), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a86a281-c803-48f4-a3eb-775069ac5a91"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b2747eb-d030-47d4-946d-7d4003fcec37"), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b3faf7d-b11d-4552-a76d-ee53d96b9656"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c193730-6074-4a4d-b42b-910332fc9786"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cde0971-3e55-46c7-b47b-8253a296e06e"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4de642e7-049b-47b7-a2e4-2f14866adabd"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e050aed-fa31-42b6-a66d-0adcfabec603"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ef721e4-d10c-4e51-8966-2ba65a47bbd8"), new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4efe3ecb-138f-4a11-8cff-3cdd5ff263c1"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f7dd53d-8c32-48c1-9c8a-5c19bea7cb9c"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50088187-17fa-4fd1-822d-0eba7f7549e1"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("509a9bed-a274-40e6-bf6a-a4948539c965"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("513b02a3-de84-492f-af53-145eb35b415e"), new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("517d5aa9-5345-41c8-a8fc-5ba837520a88"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("519e5adb-28f0-4c96-8bd9-a1289919b6e0"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52361b6a-7557-4837-9046-a164a759f35b"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5283bac0-6fc9-4fc4-8cef-803432f91e44"), new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52eec533-7ac1-4d48-96f4-e8648492e58a"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("530dc856-7762-4aee-b1e9-e367491dbf11"), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53fd4125-da05-4889-8115-20c2643d01d5"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55e63542-3890-4d85-b7b8-0ab3deb851b1"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5687342c-bef4-4e7e-8d63-f0bc087f17f9"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56d5962d-4e7e-46c6-9c9f-fcdbc0953e6c"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("572c062c-ba77-4d6d-8ea8-c08173095567"), new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5851e689-3ce3-46e4-8367-0d06245543f6"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ad16b61-6dc2-428f-9c75-c45f0054e859"), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5aff68d5-d634-439f-bf61-0f5679f3851a"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e221786-fcdb-4b25-895c-0691f350cc0f"), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f194f5b-5cad-4d13-a3e0-35ad094ab518"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60af7fda-8ce4-4897-a661-060acd8910dd"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62566055-8459-477b-b5e5-ece775d941a4"), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62d0144b-fe2a-44f0-9407-412ed5ac0f8b"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("639193b7-fffa-4e2b-b82a-337381ca9231"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("668763fd-4197-480b-9b94-7b8eeb2980fd"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67205134-2bf7-46c6-a81a-c4864b34df37"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("676e5080-f922-4ae8-901e-3c5eb9863c29"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6821905a-4dbf-4f52-823e-b9effc68e9f4"), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("686bae55-bd55-416a-98c1-135eb67415c2"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68c6bc63-9fbc-49d6-a061-2cb7703935e1"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("691d3afd-ddde-4a0e-812e-735a5be7e063"), new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69996261-3c98-4fa3-b120-c62b2276e0db"), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a1cd8e3-0cfc-4858-ba1e-f1db75b96669"), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a431ab5-03c2-4a22-b0b0-2b42ba4339e3"), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c027133-0152-442d-b74e-48aa5c55ae09"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c3a65c5-e314-41e8-b471-58b791e6ea9b"), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6cffaa61-1e71-4c07-86f4-e6ab12f3ee6a"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d5d9e30-ccc5-4fb9-b3ef-0845b65b7a6f"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6da09231-f27f-4c29-bd3d-843c78d8f544"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dada640-a2d6-4ba0-9e38-869910146807"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e3ffe46-9d43-4d60-b034-142f05e3a3e6"), new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6efc1be6-0989-4fe2-9974-6b1c74251001"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f206f4b-d771-4d8e-b5b8-f72455b29573"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70d40967-94c1-435c-85eb-9f2b11013906"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("710ae51c-992d-407b-b3a4-cca4f845de2e"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71ab654a-612c-4c10-a230-28e3a75faeeb"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71cf725b-cedb-4a84-b6ba-339972771a65"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72429e68-eddb-46ae-98da-3648b9543c76"), new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72aaf50f-7ee8-42f0-87ab-d681c012cde8"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73198cd9-3df5-4898-ad98-68a4090401cf"), new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("738b54e2-70ec-4500-bf95-9dcbe7fc8db3"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("752405b2-3a48-4f98-a061-a7cbd6701469"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76acbf4f-0025-491b-81c7-5240e7be4c3b"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77ca7ff8-de6d-49be-97de-7cea400c4090"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7950c3d2-afa8-44b0-9177-49077b724741"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79638ee2-a268-46f5-a4eb-e1a756ed8596"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a7570f3-fb46-4b66-af16-39c1fa0ec133"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7aca03e5-6b4d-42af-a652-4176f1345601"), new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e2675a5-9db1-463e-8b3f-b41e01ae8676"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e4a7725-ec80-405b-acc5-0185d8acca06"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e831c07-5806-4164-bc92-41ac6a3c9e6a"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f235f02-b743-43e4-beae-bce2e9173fef"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f4d26e1-bb5f-4820-9b54-8d6f3aeacb5b"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fcf4454-7b87-4c9d-bdae-b5a0afedabdd"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80203083-905b-4490-9f8c-a947ec8b957e"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8077e0fa-a77a-44ac-8ee3-ed6f9d4d3379"), new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80e10f87-f068-4da2-af59-cb4d2121e688"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8104c705-4293-475d-87d0-231d02bd12dc"), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("831fc921-f738-4cac-8823-44bba364a864"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("832c2f05-450c-4679-af83-f44c17e7065f"), new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83ceeebc-434b-44de-bc53-c61f4aaaae11"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83dbb549-c33e-4f04-9318-e1576d5b6bc2"), new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84cc11df-08f0-4ade-9480-e61f7dc8803e"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("856ace34-f6d9-4c11-ae90-a2b0bdc3052a"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85d58918-0782-49b7-a738-884284512bdf"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("871c5379-2489-4ceb-8e15-5de7c7e1865c"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("876a236b-0b61-47dc-b493-cbc68a23e4f7"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("876d8546-e332-41c6-b31a-6108a9e771a2"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87ecb115-d435-4e06-8b7f-310865677919"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("886e2ee0-3ce1-4c93-ae0e-ea543c8c33f2"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88842604-32c9-4201-9510-574dcae89465"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89dd4476-118e-4e55-8157-d122aec5ee16"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a4bef13-2424-4b94-8418-40cfc06e1034"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b309ded-ad8e-43a5-b5f6-27a74d17c061"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e3a3f72-7e3e-4e8c-99f3-b4db88ba5aaa"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f612c6d-904f-4434-bf72-6fe5f9e8e1bd"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fec962f-40f5-427b-9336-addb4dd738fb"), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90b8e5e9-6e1b-4c17-88a6-138acb1ddb65"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("913f024e-ca43-4ee7-b864-6d2ff8fb8055"), new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91f82320-73ce-4d3b-99f3-501779b69311"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9243a475-4001-4d8b-a9c1-a64af04395dc"), new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92bdf72a-b6d8-45ea-9ce9-d220c2112a6d"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93321c8c-7dfa-4eed-b7b2-f3d430a5dfb3"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95a66ac5-b990-4eb4-94e7-ce438936b0bd"), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9667830c-0e54-42b2-89e9-12639df1c8b0"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("967d3fae-c490-42aa-856b-50122df1e10b"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96bf949b-b3c7-4074-8955-42c284b9b9a6"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96e313cc-ad88-42f4-a1fd-fcceec759983"), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("975e8e88-d21d-4d6b-9f6e-1031b24d8c3f"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9776fe8e-d865-4546-8e82-6f76416276ab"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9808b706-aa42-400e-a59e-21828b4f600d"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("986357d6-8296-4829-a75f-7723cbe29d0e"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9997cadc-e94c-4ec8-b652-a9cd42c0598b"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9afde1a2-9b81-4377-b03e-f7e1634fc500"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b85a745-4e16-431f-931d-47c8ef53636f"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bbda394-657c-481a-bd8e-29fb86f230b9"), new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cfa9ad7-960a-48f6-b708-087425132a20"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d00d364-f70d-4c19-92ce-0c5f4ad253bd"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d75d35d-51da-43d0-98cc-0f858bf76f07"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e605b39-0a2d-4af0-a8d2-deccb27b1aa1"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ef55ef4-1daf-44b3-88c4-d79f66e07281"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f780275-0b3a-4ad7-a82d-c229d2e878d8"), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f8fc035-4d25-4945-85ad-940b75ca1bed"), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fd5f106-3098-4f7d-a5b3-a1f32a6730d5"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fd74485-adda-49d3-99d9-201fb774b62c"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0244ecf-cc18-4501-a880-05e23362cda0"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a05a35ea-e91f-4448-a590-9c08ea66bb35"), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0cb474b-afdb-44dc-9870-31311f79d08c"), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a27142eb-c283-48a6-a969-dfd15cfd87da"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2729060-e89c-4005-a2b8-c718ceab3152"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a36f9433-203e-44cc-89c6-806ada941433"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a38c5182-e839-416b-8fd2-33f0e86d5545"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4d74b93-2132-4465-bebc-d78be7e8a6a1"), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4d84cc9-0399-42d2-bbc6-4765dca82f4e"), new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4f4bb97-eab6-48e1-8323-1d7c12e7ccd4"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a53fed2c-20fd-46bd-aef3-83f7a320d05a"), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a55d1801-ae33-4227-ae28-4a930f5d9106"), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a58c1261-1d44-4ec8-88fc-d5203cd3a3ef"), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a73f9d59-0302-4682-8e73-4fc29dfb7ddb"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a81c00a0-7ee8-4fa2-bd60-15716a314080"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8dbfb42-dad9-45b7-babd-1894adfa4da2"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa67cb6b-80e1-4616-b20f-8a07d2d7f570"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa6ee487-cb24-4cbf-8dde-8674cc2f7fcf"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab05276e-6b07-46f1-8abc-41d20465743b"), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab96fdc9-d036-43f6-b963-9fc436304443"), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abd785f2-4aa4-49fa-b496-b83e7bcc0a03"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abe7b11f-b7bc-4ab0-a036-006823d6af30"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aced2316-eb87-4a75-a5e4-d9121c2e4f00"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae68a747-39a2-450d-bb7a-e83a2ed302de"), new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b08e416d-6547-4f4b-ba13-be14dcfc99e0"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0ac6c06-a146-4e4e-bad1-4c832026430a"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0ad9ced-ef8e-4c32-877e-1a5001b0af71"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b18518a8-f928-4324-818f-73af39667fca"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1d47d47-8ba6-4516-9cf5-757ae834e493"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1fb1440-5deb-4d08-b709-b0e20e3f09c5"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b284d74f-a5ef-494f-bae7-284e119effd8"), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b32d62ec-6a38-4977-9282-302da08039f6"), new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b349cf63-a8dc-42a2-bc99-cee996a76052"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3753969-cdfd-4f29-a6bb-ed28a68c7b8a"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3a29a2e-d581-4598-8a56-9f64036fa810"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b47d876f-3711-4d42-af45-1b6c2e0aa8f6"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4dc3cc2-0119-4306-9a05-dca05e1fcc5e"), new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b68ee1a1-8f54-4525-a063-66109bd90f34"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6a9e82b-cef6-4b16-ae32-3b0b0b2d0ee1"), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6fbf378-4126-4a53-a842-2f20fe72b227"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b77c8bf1-ff2e-432b-a290-65d6a6b72eaa"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7c857cb-24e2-4c57-ab50-c3e7e163bb97"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7f2e34f-4216-4204-8469-ced4536ce1a8"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b840cd9b-f7b8-4827-a6d4-f1bf16882b23"), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b85acd28-8dd1-4872-8c1a-e06ae5236a07"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8a8e9c0-b697-44e0-a5d8-59d76105fe68"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b93ecb08-a13e-4924-b050-10c19567d3fd"), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba429757-692c-4701-bd40-98bfe72daf9e"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc55f779-4aab-46a7-8fbc-553142badec0"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdfc568c-8c48-4059-a9c3-b8ce3ae347be"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be1b741c-c62d-42fd-b3ba-b2e74dcf18b1"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("be70d4b3-2103-40bb-8523-b3f9be080399"), new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf3c6e2d-fb44-4005-815d-26e2846cdf86"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bff78993-99c3-485e-a4f5-a6dd5c02b734"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c256a79f-6d55-4273-9b86-63cf5332973e"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2a91a11-3e98-4004-a584-305e7480870c"), new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2f6b4fb-7456-4db6-9553-791399452ae6"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c33a0479-06bc-4743-aebf-4933fec9fc43"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c375b4f9-3acb-44ed-bc9a-a19c3d7ae0a6"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c397838e-994f-42fb-a7f0-f43d9807772e"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3d9b2ca-f0e6-44d1-8224-8d16acd68a79"), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c415a5f0-9144-4417-af98-52a26af03a1b"), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4797a21-ae74-4a9a-b528-3ae5fd925e56"), new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c6df1bab-4d7a-4e22-ad9f-96e760de094a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c83eec85-25dc-466d-8046-13aaf7caa03c"), new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c874a623-a563-4062-a2c9-880ac080ff6b"), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8b703bb-31fa-4ae5-ab48-15a2e3c5e370"), new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9b8194d-8ac4-4972-bdd0-78950b3cefad"), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca51fc48-035e-4f3b-9f2c-3a0b77649258"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca8cbd61-5ea7-477d-a71d-668675796549"), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc5fa698-5bad-4b16-9091-c4837cd11551"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd3a0eeb-c9c3-4dbd-89a6-df04be4d3498"), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cda4c0ef-8527-4567-991e-fea51c7b440a"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce97966b-008e-44dc-be41-1ece1950e25c"), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf1ce286-423c-4068-b6c4-715b0a17d4a8"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d08f4993-99f4-4123-8606-29a1d494b812"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0be3b01-2742-4528-958e-c8c58520b822"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d44a9781-88ac-4272-9ec6-59947b374769"), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5143842-2e8b-41c7-bc0a-755a10a77d51"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d517d4d0-4635-40d7-9598-787970d31f31"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5f7d59b-00c4-4788-856d-613c2b29b3c0"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5f93d29-d280-4bcd-abf9-5e048159a996"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6c015ab-7ba2-43bf-b23b-593a7a02f69c"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d709d299-5cf4-421a-a86e-d71e7b82888b"), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8c9dbcf-2519-4481-9c8d-464c314d93ef"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d999d8f9-8100-49a9-8d13-73897c7b05cf"), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da900d6e-e974-4ecc-8b2e-3b71a210561d"), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc4bf74d-47a2-482d-be9d-ff1c9d5d7b25"), new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcb5bcb0-64fd-4df2-bd4c-2defde75bf54"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd32f0fa-b808-4837-843e-d0957d41c7cb"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd64dd74-9c2b-4dbd-8020-3ee66b757cd2"), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ddef2012-617e-4f88-9a8a-2d34faae98a7"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("decb1a79-88b5-4e35-88bf-0dc5065a7135"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dfc99707-4300-4ab3-8376-184b9887b51b"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e03ec1f9-55a5-443d-a054-a57d80ef5058"), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e0bb7c9e-d282-4a3a-80f8-4c747ab66400"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1f01ce4-9edc-440a-83b7-ace33c2f1cd3"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e283c927-ae46-4149-a756-9069187546aa"), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3d0ae89-105e-4304-8aae-a8834beac0a1"), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e488da8a-a0da-480a-a75a-7f5a35026a3a"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e594751e-be9c-4254-afd9-d494d728bea0"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6e722e3-eb8f-469b-a7ca-578c8ad5b525"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e72bb4b9-2cda-42a3-b071-1d011648ec37"), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e82c1e0d-df19-4dfa-b260-08b4e2ad24a6"), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8623a6f-5ed8-4c0f-9192-be382526c701"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea507698-9b70-4467-8b0f-f475f0b96c8f"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea7d3f38-cdd9-4289-aaa5-eaf2247e728e"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaad7609-a987-4b74-ad57-8f52ff71925d"), new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eac6a7b5-e7da-460e-9b7a-ae8c8e877f23"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebfd4d9a-3fc4-42c0-852e-23fd683bdc02"), new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee6737ec-6c9d-4224-8dbc-c17bc887910e"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef8dc83a-938a-4003-a6c4-30cbfcb1f888"), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("efd48e3f-1945-4a96-b6cd-99183a68f5b6"), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("efe26917-bc58-4e8a-90c1-7baa47df9915"), new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0000e1a-c30e-4d42-aa38-56aafc0fccfe"), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f306631a-f63b-462d-8992-7fa47fe191d0"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3cf0c56-ac09-4980-a8ae-dee3d7488a2c"), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f645b5e4-df5c-4dc4-89eb-59daa7e7bc0f"), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f75c0ab9-d55f-4a03-ae6f-fb6ffda230fc"), new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f79904a5-d538-4fbe-a904-4823010b0930"), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f927964a-7a81-46bf-a9da-4c67338f7fda"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9368cbb-d9c8-4abe-9650-8acbee9eb8c8"), new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa413770-a70b-476b-a927-c8bfc06efeb8"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa83c2b9-ce37-402c-aa7a-378416b2ca7f"), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb3d7a02-1dd7-42f6-8d54-f4c8b2fc722e"), new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("feea82ad-7d56-4829-bf15-585c82e32b6b"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff0615f0-8ee1-4268-b5ac-a92f43b66037"), new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff445355-1d5f-448c-a3ca-72296f65241b"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffaafb28-3d1b-4b33-89dd-1bea7f21968f"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ffb9ef9b-4ae3-4524-93cf-067623cbe2ae"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "AppUserId", "TotalProfit" },
                values: new object[] { "22", 0.0 });

            migrationBuilder.InsertData(
                table: "Customers",
                column: "AppUserId",
                value: "1");

            migrationBuilder.InsertData(
                table: "Hotel_Managers",
                columns: new[] { "AppUserId", "HotelId" },
                values: new object[,]
                {
                    { "1", null },
                    { "2", null }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "City", "Country", "Description", "Hotel_ManagerId", "IsConfermed", "IsDeleted", "Name", "Rate", "Street" },
                values: new object[,]
                {
                    { 1, "hurgada", "egypt", "vhmvhhbhggjhjklmkl", "1", true, false, "Haway", 5, "ghghg" },
                    { 2, "hurgada", "egypt", "vhmvhhbhggjhjklmkl", "2", true, false, "Holy", 5, "ghghg" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Cost_Per_Night", "Description", "HotelId", "ISavailable", "IsDeleted", "IsNormalRoom", "NumOfAdults", "Room_Num" },
                values: new object[,]
                {
                    { 1, 900.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 1, true, false, true, 3, 200 },
                    { 2, 700.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 2, true, false, true, 2, 210 },
                    { 3, 1500.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 2, true, false, false, 6, 100 },
                    { 4, 700.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 1, true, false, true, 2, 110 },
                    { 5, 600.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 2, true, false, true, 1, 180 },
                    { 6, 2000.0, "hhuehuehuhdjhskcsndvjvjnjjjjhhduewyromknzvbmxb", 1, true, false, false, 7, 200 }
                });

            migrationBuilder.InsertData(
                table: "Suits",
                columns: new[] { "RoomId", "IsDeleted", "Num_Of_Rooms" },
                values: new object[,]
                {
                    { 3, false, 3 },
                    { 6, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "normal_Rooms",
                columns: new[] { "RoomId", "Type_Of_Room" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 2, 1 },
                    { 4, 1 },
                    { 5, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ImageId",
                table: "AspNetUsers",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_bookingChecks_BookingDateId1",
                table: "bookingChecks",
                column: "BookingDateId1");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_Managers_HotelId",
                table: "Hotel_Managers",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_Hotel_ManagerId",
                table: "Hotels",
                column: "Hotel_ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_image_AppUserId",
                table: "image",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_image_HotelId",
                table: "image",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_image_RoomId",
                table: "image",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CustomerId",
                table: "Reviews",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_HotelId",
                table: "Reviews",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_HotelId",
                table: "Rooms",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admins_AspNetUsers_AppUserId",
                table: "Admins",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_image_ImageId",
                table: "AspNetUsers",
                column: "ImageId",
                principalTable: "image",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingChecks_Rooms_RoomId",
                table: "bookingChecks",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Rooms_RoomId",
                table: "Bookings",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Managers_Hotels_HotelId",
                table: "Hotel_Managers",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Managers_AspNetUsers_AppUserId",
                table: "Hotel_Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_image_AspNetUsers_AppUserId",
                table: "image");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Managers_Hotels_HotelId",
                table: "Hotel_Managers");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "bookingChecks");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "normal_Rooms");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Suits");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "bookingDates");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "image");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Hotel_Managers");
        }
    }
}
