using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryEF.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Normal_Room_Rooms_RoomId",
                table: "Normal_Room");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Normal_Room_Normal_NumberId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Suit_SuitId",
                table: "Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Suit_Rooms_RoomId",
                table: "Suit");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_Normal_NumberId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_SuitId",
                table: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suit",
                table: "Suit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Normal_Room",
                table: "Normal_Room");

            migrationBuilder.DropColumn(
                name: "Normal_NumberId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SuitId",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Suit",
                newName: "Suits");

            migrationBuilder.RenameTable(
                name: "Normal_Room",
                newName: "normal_Rooms");

            migrationBuilder.AddColumn<bool>(
                name: "IsNormalRoom",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suits",
                table: "Suits",
                column: "RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_normal_Rooms",
                table: "normal_Rooms",
                column: "RoomId");

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
                        name: "FK_bookingChecks_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_bookingChecks_bookingDates_BookingDateId1",
                        column: x => x.BookingDateId1,
                        principalTable: "bookingDates",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc14c414-7d2a-45f6-bc77-f50447beb88c", "b0ee0895-349c-4439-b420-38d9f7c81bb3" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "City", "ConcurrencyStamp", "Country", "Email", "EmailConfirmed", "ImageId", "IsDeleted", "LockoutEnabled", "LockoutEnd", "NID", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Street", "TwoFactorEnabled", "UserName", "gender" },
                values: new object[,]
                {
                    { "1", 0, "sowhag", "275c4c2e-2e74-4659-bd23-20d58b680f0e", "Egypt", null, false, null, false, false, null, "12345678901234", null, "AHMED", "Ag1234#", null, false, "a148a602-2ecb-4ffd-93fd-4e3526625886", "jijdijdied", false, "ahmed", 0 },
                    { "2", 0, "sowhag", "4d9c13ee-9b32-4def-b5e5-bef8b9867886", "Egypt", null, false, null, false, false, null, "12345678901234", null, "MAHMOD", "Ag1234#", null, false, "cd3caeab-8aa4-4158-b381-b4f8baf14d50", "jijdijdied", false, "Mahmod", 0 }
                });

            migrationBuilder.InsertData(
                table: "bookingDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { new Guid("01715411-3653-4249-9e50-2b1ff1bbf8cc"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("01e2df08-4352-492a-9932-8c739bf3e4a4"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("02462024-7c7a-446b-8041-bb5ffedb61bc"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("032459dd-c5cd-418d-ad43-6d8323736a93"), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("036e0dc7-a3ca-4a6b-8510-6c866496cef9"), new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03d9a241-49ae-4c41-a7f5-7a3fce797c7e"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03e0482d-fcd0-4eee-b5b2-b247368a3150"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03f9a44f-6f6b-45ce-9c32-8a2b2576e956"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04b1701c-1259-4042-b63b-788c2e0eefaa"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04e4c167-45da-482c-8187-e7cdb3e45bdd"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06ac9c56-3a63-4f12-9d68-9c3a1e766fa8"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06cdb305-4c4a-40c8-866c-4f8cfab7c8b8"), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06e6c420-e33c-4e96-b977-54a0b6c7418f"), new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07d86267-f35f-425a-814d-f100ac917461"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a37558e-7957-4d02-896d-8d2b0734dcb8"), new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ad4dee9-a0d9-44d2-bf99-c72c29cf19da"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b73141c-20e4-49cd-9360-93b04570335b"), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cf1425b-d379-4d63-8bb8-a62fd07217f7"), new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d0b0e08-bb28-43c2-955a-0357a5457092"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d55609e-79c5-42f1-9ecf-44df9863bdca"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f6b312e-6a46-4aee-9117-5cedbedbdc16"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10b9779f-e51a-4c59-9769-07340ada85cb"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11c9f91c-79b0-4e6e-8d2c-8d6cda7e812d"), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11e728e6-3993-49f4-b7b6-0ffd1d41092b"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11edd3c7-28df-44d7-99f4-aba0ff5ec2a0"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("149dccb0-9c8e-43d1-b221-1a24f50ec89f"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1527dcfc-3b02-4e1d-9375-f659af5ba31d"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("166e3d01-e648-4bce-bd8d-7e39761b5439"), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1772681b-3b03-40bf-b998-5eeb90015ac3"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("198c1e06-9470-48cd-9d09-d08259625084"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a7b2afa-9477-4a2e-97e0-88742e0b94c7"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ae05ad7-bcf4-437b-8548-cfc91d2c0e6f"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c00321e-d8a8-4fcd-85e6-ccf7233836e0"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c45047d-f8fd-4c0c-8a8d-7f9ebeefc847"), new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e08274b-8561-4d8c-8799-7fa6628814e6"), new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1eb60ad4-bd32-4f4b-85f4-0b7708d2a222"), new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f1af0d0-d90a-466a-beb7-6f5c96ffb101"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1fd1cfa0-9f72-4d3c-b530-aa8c6c6526e4"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20f988c3-bebf-400a-8e70-eda39fefae77"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22a3670e-9236-476e-bb11-a6ef5512b60b"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("23717159-e231-4d58-b6ea-83c2e45db4ac"), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24866197-1c60-41c9-b11f-b8abb5b3a3e9"), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25a5bdd2-f7b1-4865-bbd4-1cb78d4123fe"), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("261d31de-3f73-4ca4-8ab0-11d9cf3cae09"), new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("267b1889-0484-4b65-99f4-620613c35a7b"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("268a7fce-be8a-4d9f-877c-c7ecf442abf1"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("273151fe-ee1c-4361-97a1-96c1e2df86ef"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2769354a-086f-484f-b15b-ee51cce0dea6"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27a7808a-29ce-449b-a8e6-36f3bee2774e"), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27d6557c-ad4a-417d-a5aa-d3a3a43e7b99"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28149bb6-451a-4002-acbc-0c8b2868ecd3"), new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("289b1a15-bbb1-4009-ad8c-214d3eb11976"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29365d21-12c7-4611-ac18-488394066525"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2aa7890e-3e6e-4f81-b174-ac83c50c4742"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2aedad07-1873-41b8-91ef-f5bea2d21d5e"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c980932-9a10-4c0a-9c7e-9f9244485a59"), new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d6d71a0-69b8-4f1a-b175-f1f988e1cd5e"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e2299cb-10dd-4a00-9136-3352172d4753"), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("330eb6a2-1fc8-473c-9b14-e311c056b912"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3325503e-dc24-4f25-8c1c-6fbc270848ec"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33affb3e-6ed3-489c-9b28-dc9ba5f9a73f"), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3440f966-8e94-4eda-b99c-43cba87e03ff"), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34cb829f-791d-47f7-a9a8-b0e6f2a810d7"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3671845d-f26b-48bc-a1fc-d466f3d2b3b8"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3813318d-5ae0-4243-89ff-aee778d48f95"), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("382e825b-ed81-46ee-8034-6bf701feecb5"), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("385075bf-ef04-44d7-8197-7528e9a1ef32"), new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("398af96c-7b8e-4851-8e7f-168e9b8cd8ae"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39b95e3e-83c2-4e1e-8032-f3aebe8169a3"), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a0c0c73-f326-423b-8242-b9da3f21987d"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c211bba-c2ec-4feb-8b28-5bf58cf84418"), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3de81eb4-15c0-4d4c-bd5e-589f2093b056"), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e15a667-c664-4191-8361-6febdf19befd"), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f5e49bb-7abb-46e5-ae05-68f52c6408af"), new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("41143c48-4182-4450-95f8-ebcb19d6251d"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4205b69a-3672-4106-ba6f-4468ebe6e44c"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4224bb16-4803-40f4-8341-7f504ba40d79"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4280056a-c27d-42aa-b115-692bd7164040"), new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42febff0-7a33-44c0-a9dd-f94e2bd63a96"), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("430f8239-e23e-445b-8db7-b8b7fc4fe586"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4369087b-65d1-4295-ab91-c5613d1d43c0"), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("448f32ae-a438-418e-94ed-e7448a60c82c"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("452b0c9b-47ed-4793-871b-4815cae384cc"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4554cc7b-2063-4e74-870d-b4edfe65d3c1"), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45c4ff5a-3d84-4f46-a41c-a238a4ceea47"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45c8ddd9-5c33-42d1-a230-bdbab0fd3d4a"), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4730e465-7897-477f-8946-7c291fc6e780"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("483a945c-4fce-4ff8-98db-34ee6d6f6b84"), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("48ceb188-7378-41c7-a303-e308ad44b442"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("48d05bb9-0d95-4c7d-bbe3-430cd5a8781e"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4937a1de-c0f9-429b-90cb-b5d1afd7f4e9"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49f43885-0636-4251-b658-3aa8ddcd26eb"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a013875-a8d3-417f-bfbc-5fb5137e741f"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a674a6b-8f5c-4561-b4cc-0f275b9dd2fb"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ada84de-bd93-4f82-a8e2-94021c94f655"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4afc7fca-9979-47f7-aa5d-a9f095c128db"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b21f8a0-bbdf-401c-a692-317934b92ee0"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b82f63b-f325-48c5-abcf-b1e7f804fe18"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b8ae5d0-3b82-4c7f-9c39-fe0490310eb0"), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c12ce13-26ad-4f75-96dc-00ca1e9adc32"), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c3a2768-4768-4688-a943-4de6f98ee427"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c610e6c-4e78-41b9-a6f9-61941cb5018d"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d55aa06-e10a-4c83-b98f-83746368a53b"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ed65e01-1b3d-48d6-bd6a-85cbcc7cd586"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f0fd16e-35a2-49e5-90c8-494aaab4886a"), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f2babe9-9a30-4116-bb3e-736a06fa6c5c"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("509eb5e9-4b1e-4925-b7e2-e068e511f96a"), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5151e9d9-1ec9-49d0-93a0-e7f54d6dbe00"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5195636c-8502-4c41-a9bc-2ba5d000fedd"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51a8fdad-aa75-4dfb-890e-c8a7b680edfd"), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("51dc8644-3079-46f4-84a6-b3032303c988"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54c86ebd-0600-4968-8539-ce2028573ecc"), new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54d9621d-54f1-40a5-81c7-17fdc1a7ef7b"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("551ed03b-9793-4e9e-a7a3-72f0a817aa1f"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5520893c-79a1-411e-8bf8-3c3e50431cce"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("562fbaf3-4c7d-4b5e-9753-e8cb28be27e4"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56fd00c2-209d-4750-b3b3-772038f55151"), new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5757bc67-e8ec-4560-b7d9-87a559025314"), new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57bdcf5c-378f-4931-9555-a683e6000224"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57f6b276-fa58-4cad-9bf1-f76d974f6916"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5849e35a-31bd-4601-9664-ef5df838e894"), new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58926577-8c92-4fb5-bc06-c84e70891b0a"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58c22908-db23-40f4-a2dd-4e3e7d3a26ad"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58efb7e0-54c1-45eb-92e6-d8d7b229ab78"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58f49cc1-69f7-4e4e-be69-8f8f10408d42"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a760aac-092a-4074-b6fe-0815e4fd1de1"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ace3fa7-c044-498f-973f-956b4823bcc5"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c61cc70-dc49-4829-b838-6ce3f0b62e08"), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ca2f509-a136-45ca-bea0-9c8d87319020"), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d1cc4a4-6fa4-48fb-9dea-bf400a117dbb"), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d74b641-837b-417b-abdd-25f2cd4b8075"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5da4bd54-c4d0-452e-9d44-b2dc51274bd4"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5dee9438-5df3-4917-87b8-8a51b900ff0d"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e07d964-caab-4913-a5d7-dcd50adbce22"), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e8a351a-4169-4635-a5c4-f1b25ce603ba"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f1d5472-e085-4a7c-8a13-1726b37fcfbc"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f65d0eb-2e0f-48ae-ade6-de51532e2327"), new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("613b1958-8906-4dad-a836-c2d81a9e7c34"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63be5c7c-15a5-420b-b3df-39240e93d397"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63ea9e98-201d-45d1-bd10-7a1aa897378c"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64b4fbb9-0ffd-4cd3-840f-2e7182cb9852"), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("65581e01-4691-4d6f-a484-81a2c549a62b"), new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("661368f6-3ff9-47b8-8079-779ed7a275dd"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("666e8555-5c18-4cfe-bf2f-9de833c042fa"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66882e43-48ec-4461-a9f6-b2371029c5e8"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6713c472-9a07-429d-9018-756658542b9b"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6791be7d-2cda-4952-87ed-5b7ab07b4748"), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67b9559e-6b30-4a9f-a656-c98f313bb1a0"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6867a846-5335-48e0-8f9b-2760e285115e"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("695d68c8-d7cb-4f8b-942a-23d78bc33a4d"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a492efa-fe60-4761-921e-d29768024cfa"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6aa6437a-d03e-4fc0-b8c2-3088ba53fe10"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ab46e09-631c-43b3-bd65-ec5c01ba22f8"), new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c382761-727a-48f2-bf3b-572c7b24cd3e"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e2bc27d-e687-4108-bde0-78b6fcfd9bb7"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e6138d6-2f2a-43ab-ae81-b89290d3de98"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f7cf797-e2b0-4740-b8e0-cfc7980081a5"), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("724dfdf2-c5fb-413e-84de-833d09d1d112"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73156df0-5833-4e96-86a4-7321bfa09b32"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("749cb2f6-46ea-4db7-9bc3-18b1baf5a098"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74de09d6-b3c5-4042-a0f6-0728697f3b70"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7616bc62-0110-47dd-8eab-035f5f2b0f0d"), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("765ca99d-c349-495a-887b-56a87fe6e940"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7769bab6-9d93-44a9-89af-3a28f001daab"), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77ae3ac0-8d5f-4d67-ab47-c2b4fe94a2f5"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77bfc00a-5ad0-4105-a933-68a7cd0092da"), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("782932b2-1d28-4c7c-b14e-310062b99d69"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79730c73-5c0e-4729-aa58-95a77567690a"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bc48b9e-1561-4224-ac1c-865243ba876e"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bca22f8-df60-4731-9b66-af7ba3ecf012"), new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c9b4833-f406-4e51-8458-9b6de7d0fd28"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d0b7090-26a6-46fd-9300-f6f583b351a9"), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ded3b55-6700-41f7-a376-21932be7fb07"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ed3fb8d-7b0b-45bf-a93d-1b5d23ddbc54"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80184ed3-f530-4814-92b9-f743bbd9ee4f"), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("80c0583b-45b4-4ecc-8d76-ef541a570fb9"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("812a3580-5f41-4e1b-892f-ef3496b2572c"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("812ebad0-e01b-4902-b0b0-c55b9fae2660"), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("821f8fed-7d87-49bd-8727-98996075385e"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("832b4b61-41b8-42cc-8328-15beae14c57c"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83f8daa7-e565-4b67-ac34-172e237f5d81"), new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("841df999-8c8e-4a17-8913-13d903ca10f4"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("858ae69c-e190-44b7-8652-d5dea28dc2df"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85b8422e-d208-4149-954e-01235492f803"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85d420ce-a6c0-48e2-b00c-0764f290e511"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86d87f4d-3bd1-4924-b678-6cbb6f393a13"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88aff6df-153c-4004-9952-0678145deb27"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88b86b6a-39d7-439a-9b75-9bb678a4b5bf"), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88f76c09-bc68-4c6c-8b31-6de64cce43c4"), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89ac6320-279f-4672-b020-1a9a6c5349a5"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a123f5e-78a7-4a08-828d-8846252f278c"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a208a08-5d45-4931-923e-647e7e4dca12"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b7c326c-11a7-40a9-ac0d-c550c4c259b7"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d49c098-f369-4708-881b-cefe8846bd24"), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d688f95-7683-41b4-8629-9248d4df245f"), new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d8ac7e7-2e61-48b6-bdf2-94212b771812"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d98d43e-cbd0-4316-8869-ce17a1b27891"), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8df478dd-aceb-43fe-99db-1e45bc57d4e4"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e177c64-9e44-4772-b0a5-67ddb08bc515"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e1c7aa6-155d-43ae-b9a9-fb7e4ee531b6"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e32bd0e-26e3-4fec-99b9-ed16339586ab"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e95a064-eaee-4145-880a-764de0c90f0a"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ee9d9a1-6af8-4e37-98cd-6b46c1928b58"), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f64d6b3-4aaf-4cce-bc9f-8c964cc8673a"), new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("90e2b180-44db-43cf-b984-cccfc7fd038b"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91283ffd-f41e-4681-b325-08c320820676"), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91748dd5-cbb7-483d-a700-39c0c6b7761e"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("917c0749-85fe-4a93-8be1-e2ceb4691cca"), new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92367411-e52a-48a2-9cf3-164e635cd30b"), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92c31417-0849-4eb5-a2ee-98e0edc91ea8"), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9374c45e-e978-4cb8-a55f-997e7a920f92"), new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9469240b-08ad-4f38-b633-a04486e1f923"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("947f49ba-5e63-4d46-8684-ad02bd8c9d63"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9483d2c7-f1ef-4f33-8fbe-6207c1e2f304"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("960172d5-e215-40bb-9571-14b2fc9b577e"), new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("966426c0-feab-4ed6-a477-06636c3d4332"), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("966d8fa4-1121-4395-8056-2c6dae4d4eac"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96a17448-4cf5-4d8c-ac63-de386a570270"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96b4c57a-cf50-46c1-bfb3-cfc38c341a31"), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96eebfcd-29bf-4183-9a8e-6d6efe2f0ee6"), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97ddba82-6b00-4fc5-b824-0ad076806196"), new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98e7c945-17b1-4168-a42a-f1924a936e31"), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99a35473-2279-40d8-bdbb-ff8c652460f4"), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bc4e027-750d-4423-b5f6-720066c17839"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c59f43d-185d-441d-b5ad-f7f76da43df1"), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d535094-745f-43ae-a0c5-1ead46525147"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e9ec38f-d8c8-4564-a22a-8025093dc7cb"), new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9eadf708-8dfb-473c-aad7-42eace8996ac"), new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f7afb4b-baa2-4c65-8ddc-93433f0c9665"), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a10a5b7e-d55c-4a68-a39b-90f3de7808e5"), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1b788d0-c37f-48b1-ba35-f18ccf22a9db"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2bec671-65ab-4b4b-9c0b-14da96f6f5bc"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2cdfb5a-d4c6-4ea2-946e-0a81f76428f9"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5907369-70ea-4ba2-a4e7-bd4b401bea99"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5d3335f-7819-44c3-aef3-5ab8bcd4c497"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a67925b7-c459-4bc7-800c-35e104829104"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6fd1c96-c247-4023-8f0e-9467e52286d7"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a96fb211-ebe2-4b49-bcc3-f374522462e2"), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab84a372-b989-4e31-a80a-392f38b1a1c7"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abfccb3b-3ce0-49b4-be1e-bce9a2ad473c"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac22aec1-18e6-4d4d-a4f8-5eef05a51b03"), new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac26e8fe-668b-44b9-b281-63f2c03e3199"), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac8460d8-5358-4ab0-b39a-b51b18dcca02"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("acd3e3ec-a07e-485b-8730-d15a896a06ee"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad790ed8-0d62-4be6-a83a-c9724543a022"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("adaffe89-023b-4903-a131-ae13f426321f"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae840ab9-98a0-468a-87d0-6f0b176e1e04"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aeab0402-2712-45d5-96fd-7b18f076f287"), new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b03abc4a-839d-4208-a490-b0b50d93a09e"), new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b04b16a6-f045-44a0-902d-1ff15f244c96"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0de8fe4-7151-4699-8803-c338ca9c1c30"), new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b24bfcee-7311-479a-985b-2f8cef30d35a"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b358d6ae-36ee-4af6-8b37-f2cf09662c61"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3c231e4-123f-46de-8d4f-9af4248a3bac"), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b49af0c9-5942-4255-9951-50364bc7f346"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b5989681-c05c-4c3a-ad31-6f6c676f51ed"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b708695e-f92a-4591-81c8-b9bb17994ac1"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7d75f2b-78a4-4c0c-98ed-87cf12eb1954"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8c11cef-f336-4e0b-885b-42d644d02d88"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8c51ec8-132e-4de5-a703-8b91f377f085"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba1df760-683e-4796-a806-41007f06a8a9"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb881279-a356-47c5-a879-a6f923ff310c"), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc35e5fb-fd6e-4527-8776-523553fdc325"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc46347c-9a2a-473f-9c3c-1dbff6142411"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc63742c-72ef-41bb-b8d3-fcdf03f0ed78"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc689593-6cfd-425b-9fd3-08ee3d782847"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd111f77-c8d4-4218-a0b7-849da86ea542"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bddcb8e6-b38a-44d2-b414-37229ce222e2"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("beb81970-3013-434b-901a-ac409f83a70b"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf4259f6-a295-4789-acc4-9a7ca3dbd293"), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c02d7bf9-371b-4325-b470-d601965b128a"), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2a651da-0871-44d4-9d3c-69514122c3fb"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2accd0f-f04f-4df4-91c2-e9890e773dbd"), new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3128e67-3872-469b-8ec9-699aa567681c"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c327db1a-ee30-4032-a797-aee1e4bf0bed"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c350c18d-b03c-4a72-954d-8cdd6a1f622b"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3e0e1b6-73c3-4ede-ab1a-a71337f8cf8e"), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4fa471e-7743-425f-876b-edc1c16bf384"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c53e8fe0-958f-435c-8c82-155c3bf27f76"), new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c56c47a5-3f25-422d-8649-d9bcab5b0631"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5e77d68-41f2-405b-ae9d-c52f741740f2"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c79d858a-d4ad-4852-8b3d-18e7ea7e3f37"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7b41c99-c0ec-4df7-b00e-6c64f8f76d2a"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8c7788b-2372-4e75-b178-9d6e689c645a"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c93d53e7-e9af-4e57-be3b-4015a14565fa"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb2ca011-4231-4496-ab02-53e432c550bb"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb377ed9-e669-469a-9dac-b53e1067d58c"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb3e659a-19d8-4771-9373-872317c8657e"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb7c9cb4-480a-4410-87b8-4c11d10351de"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc151b94-d9f1-4e23-87e4-41d821a0d6f8"), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc1f011a-1413-4a89-9c82-c92f434190f6"), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccb1ab87-3666-4c42-b967-711da3e2ae7c"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccb91696-f5bb-4d85-bc62-73e0943aea88"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce2c19f9-0ec7-47ba-ae40-b75cef928514"), new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce671328-222f-4a32-bd66-94e025249dcd"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ced678b9-c35d-46df-a60e-611645ee17b6"), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf1a66fd-04bd-4bac-9031-3bb194dd38d4"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d22bafa4-e295-4852-b09f-1538c4d02d92"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d32889c6-35f2-4c31-904f-2ecc4e2dd4ff"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d37eaf81-0be3-4407-98d1-d730e80c0785"), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7618d67-9377-463d-ad09-7a9780b8c616"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7877fca-5cc0-4f0a-aa66-ae12c569e9d2"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d916db59-32a0-4db4-a99a-ffbeb385b1c2"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9530ba4-9bdb-46d0-8838-29a9beada96a"), new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9604038-4728-45b8-b597-908ffb6fc83f"), new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d98f3ec7-bb60-44e9-a270-b78aaee319e4"), new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9958a86-3dfc-46d6-9204-9b34bb26cb4a"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9df7f33-e4ea-453b-8bc1-6cc29448c4db"), new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da7dcd65-1d9c-494a-b7a9-fe06965a4bd6"), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db8e2e57-3834-4ca6-ac77-7dde7d25fa41"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dbdbd98c-b61d-49d4-9747-fb955a882bef"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc6e06a9-46f4-47d8-9f8b-a5120bd96b98"), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcb1fa79-900b-4a1b-b68b-2bce00239059"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcc2aaf6-26fa-458a-b986-d8a0a90e0dfc"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcc74434-588a-4e9d-b778-e417a145c401"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcd6c221-6040-48f1-9128-9c72abcd9c17"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dce09ffd-3c65-48f0-899d-a266d46bd9f7"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd39d89e-2e59-4fe2-89d9-e2201cc7e476"), new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd8b7bb8-5c08-49d3-b0f3-680e853c45ec"), new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de392c5b-2cfd-466a-b647-98054ddf85b9"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df00d8ee-9016-4bbf-9c85-a6f99351dd66"), new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1264d91-81e4-40ce-874b-8e89601b900b"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e13f3f3a-5f6f-4fde-ba82-7c1d17d14f50"), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1625d30-6938-418e-96ae-61fcf396df8c"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e261de1b-e0ca-4a63-94da-009ce4b76ca6"), new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e3605861-cb6f-464f-ad0a-1ed946657c2f"), new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e414111d-97e6-4eee-981f-5bcf837747ba"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e418bacc-755b-4032-9544-f1c920048b4b"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e43e1bc0-4645-4e82-9104-81c70ec8a1cc"), new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e45f3e9d-202e-4ce7-80fd-03296d9a77e7"), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e60123e1-74fa-4122-9ed6-b33352bb5ef3"), new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7c0e525-d3ae-4326-aea8-bc0c303ced56"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e981bc16-384e-49cf-af5c-d7c3e1c03f57"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea8d32cf-4833-495f-860c-8b14ec77dc40"), new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaab2f63-cec1-48d6-9a36-58528bf023fb"), new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaabd2e4-e482-4674-bc67-f520b1f412d4"), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eaf90930-41ae-4951-9167-9877e74cadae"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb981e96-791b-43d3-bf75-35995f3a3b51"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed2572aa-529a-4ec2-801d-9b93757e1544"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed6eb6a1-9105-4051-837d-383024dcccd8"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed99bd18-a33a-4e03-af25-2738ea8eb937"), new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("edd0ddd0-f63d-47ee-9343-13351fe541df"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f02f1a7d-4759-4a71-b888-299cd70ff2ce"), new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f4560475-3248-4903-bfa8-d95a43aebc7c"), new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5327ebb-a696-493c-9b5a-a9656c6ae1b8"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f54fae3d-5edb-4d5d-83d8-9e0e480b4d46"), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6d0e387-0774-4311-aaa4-96861121375e"), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7842432-db63-4416-a8ba-5e09bfb4a3f6"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8333ddc-7f84-45a2-bcf6-bfa81d367e7d"), new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f85e4f84-1974-4fdb-8b22-7cbab82f44ac"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f89c4f45-f3ec-4b80-aa74-49ada1385f80"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8f7da82-53fb-46a3-b5a4-d848eb5fd9f3"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8ff1430-2e0f-4d20-9a4f-065a4ef61217"), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f95429aa-4198-4816-b968-f71069d80a1f"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f98f900b-7592-4505-80b4-47fe9f84731a"), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9bf1f3d-a9e0-42a5-8d63-6a87e4e6f8e8"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa00a855-df8b-4ce2-851c-9021242ae8b6"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa8efc55-84dd-4b91-a610-2fda601e60af"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa91f728-8109-4de6-a714-72413b3dd370"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb8c2cf4-1933-4977-8a96-c7f98e14d9d4"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc4c265c-50c9-456d-a5f1-30160985e0e7"), new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd0cc796-1869-44d0-a2b9-044ac6d3cc45"), new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fd60f57c-f036-4105-a990-5fbcdc9f6757"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff137a6c-63d7-4b39-a5f4-a96425f39622"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff95d175-1ed0-452a-ba28-2e0651691a91"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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
                columns: new[] { "RoomId", "Num_Of_Rooms" },
                values: new object[,]
                {
                    { 3, 3 },
                    { 6, 3 }
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
                name: "IX_bookingChecks_BookingDateId1",
                table: "bookingChecks",
                column: "BookingDateId1");

            migrationBuilder.AddForeignKey(
                name: "FK_normal_Rooms_Rooms_RoomId",
                table: "normal_Rooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Suits_Rooms_RoomId",
                table: "Suits",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_normal_Rooms_Rooms_RoomId",
                table: "normal_Rooms");

            migrationBuilder.DropForeignKey(
                name: "FK_Suits_Rooms_RoomId",
                table: "Suits");

            migrationBuilder.DropTable(
                name: "bookingChecks");

            migrationBuilder.DropTable(
                name: "bookingDates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Suits",
                table: "Suits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_normal_Rooms",
                table: "normal_Rooms");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "AppUserId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Suits",
                keyColumn: "RoomId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suits",
                keyColumn: "RoomId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "normal_Rooms",
                keyColumn: "RoomId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "normal_Rooms",
                keyColumn: "RoomId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "normal_Rooms",
                keyColumn: "RoomId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "normal_Rooms",
                keyColumn: "RoomId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotel_Managers",
                keyColumn: "AppUserId",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "Hotel_Managers",
                keyColumn: "AppUserId",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DropColumn(
                name: "IsNormalRoom",
                table: "Rooms");

            migrationBuilder.RenameTable(
                name: "Suits",
                newName: "Suit");

            migrationBuilder.RenameTable(
                name: "normal_Rooms",
                newName: "Normal_Room");

            migrationBuilder.AddColumn<int>(
                name: "Normal_NumberId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SuitId",
                table: "Rooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Suit",
                table: "Suit",
                column: "RoomId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Normal_Room",
                table: "Normal_Room",
                column: "RoomId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f448a04-ed65-4999-97c5-d08da02a00c8", "54eddfde-94d9-4777-91c2-98e422c43c14" });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Normal_NumberId",
                table: "Rooms",
                column: "Normal_NumberId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_SuitId",
                table: "Rooms",
                column: "SuitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Normal_Room_Rooms_RoomId",
                table: "Normal_Room",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Normal_Room_Normal_NumberId",
                table: "Rooms",
                column: "Normal_NumberId",
                principalTable: "Normal_Room",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Suit_SuitId",
                table: "Rooms",
                column: "SuitId",
                principalTable: "Suit",
                principalColumn: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Suit_Rooms_RoomId",
                table: "Suit",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
