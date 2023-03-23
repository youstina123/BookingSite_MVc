using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RepositoryEF.Migrations
{
    /// <inheritdoc />
    public partial class b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("018763d6-a0c3-4974-80ca-b5006aa7990d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("01c42ba7-857a-4800-92f3-fe738c7afa93"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("03edf409-2c52-4e79-9a87-54a23e8563ef"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("04418be2-cbfb-43dc-8e3b-3402d5416d84"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("047c7ed4-f8dd-41a9-9661-bc6229dffc39"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0553e669-9c83-4add-a752-13011b0e9603"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("055efb4c-8fa9-40b7-ad7f-ec218227e7f3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0583f5f7-9c09-4b43-a9d5-dce1c43aa0d0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0661a3df-6511-4ff5-84c9-3ced883aa872"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("07c5bec2-4de2-4eb0-b105-95681eb17a4e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("092717d0-cd48-477d-966c-eabc1fa4174d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("093d5ff6-9129-4501-9b0f-790a1f43e288"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("09a53396-88b2-46c2-8ad5-1f015b677c80"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0a2c9958-2167-42ed-8689-d109e087e7c7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0ac178c9-85c9-4858-8272-bc56ff4fd6b9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0af07cbe-e1b0-45b9-a01c-0ce9d153fd9f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0c324319-1d67-4ab9-bd63-928ca9b647f0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0c6fb0f7-248b-458e-ada1-b24190fa11f6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0d2d4720-8b9a-4064-a131-5da9e6bef3f2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0dfaf0ca-c0c0-4d03-8150-60c342ecde5c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0e19d310-55b8-49f9-9523-6b7a65dd6761"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0f2bdc38-3603-4455-be77-b32e7a337297"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0f7259b7-c68f-402d-9b32-29973b705a45"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1125afea-dbfe-4c4e-9d46-8963bcaac290"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1281ef69-f11b-42c4-bc06-09782a0ce2d0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("131f6ffb-8225-4bd1-b09e-045194e4d4df"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1417c3db-c920-4514-b5b6-609faa3e8acf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("155a5f43-5c63-4852-8675-8df4b5ea04e9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1573813c-43a9-4cb5-8368-79cdf93d73b1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("15ee8c15-f5ba-4baa-8b1e-775b8494ee06"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("16353d35-78ec-49e0-9029-98f6b95f7b7d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("16dc7053-45b8-46ff-a0e1-43d8f51c1474"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("17ff8a48-8694-4707-9345-571be68b8288"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("18f4c18f-d5c8-41f8-b52f-0150c5f2774a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("195a48a1-bf53-4b39-a928-e9b2af7ace7b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("197c5436-89e3-4089-bfe5-843579a957c0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1a4f4b49-cff3-49c1-b68f-2e61baad2a6f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1b428ba7-6c1d-4bba-af3e-54ae3b67ed51"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1b9d8a39-0897-43b2-8778-06edf614e678"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1bbc7707-415b-402d-8b8b-d842a3c1a631"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1c4a09a6-1f35-4e01-889d-ba9e4ffad4c9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1c7bd806-5637-4931-9a7e-217505d20832"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1d3ca668-c9a2-4ed2-bea5-91b2f6d4a52e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1d3ddb0e-ddf5-449a-94f1-500ea3c2a045"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1dcdaee1-53bd-4797-9e43-6bb425bdb2fa"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1e3443ed-7a4f-4fc8-a67b-0353dc1ec5b7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1f9acadb-72d4-4cf1-85a1-6dafe9ffbdff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1f9dae5d-3b6b-4aac-9c90-bf57427e1efc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("208db32a-8ae3-4083-80cf-7f6620094561"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("20ef1ed8-8933-42e9-9f41-2f1c66319d36"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("21082e12-3825-44b6-b39c-1ea06e0de3fe"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("21cf2174-e379-4933-b647-b9f8a95b960e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("21eb2d15-34a9-4644-b29d-74de8787b88c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("21f6b633-1a9b-47ac-a1da-aadbbad17e98"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("220dbe40-1fb9-42cf-8728-d103bf6f451c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("22233a6f-3cdc-4bf7-a9de-af757025ca12"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("24d38da3-fe1b-4035-a985-0ca06e52fefc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("24e0a5d3-af33-46ae-bd3d-9c0c180857c2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("25314ade-d92d-4225-8e94-1b4663c51069"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("26adf7bf-32bb-4951-b215-214702f95cf3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("26fb115b-9891-45b4-92b1-6f213ddddb65"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("27254c9e-b341-4e28-9c4b-b8882c4e2e8a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("287c8e9f-d5f6-4402-931a-9f840eb21d8e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("28d7fc77-e165-45c1-aaeb-12cc6f2ef060"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2974465b-7f8e-4580-a1ab-96ecdcf8e8bc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("29781485-99a2-4652-a54a-11c0082d2ada"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2b618026-9b2a-4a22-81fa-0b082bee2727"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2c831a1b-1168-46d6-bb4b-a1eae026e1a0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2d6eea64-1e3d-40d2-a5d7-1df69abbeeb4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2d845c3f-237c-4b2f-b129-02b200d6bbea"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2f8e18ec-369f-4037-a8d8-40b7c4dcb6be"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("30ec986c-1c12-4dfb-97a6-e920abfb34ed"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3166a767-0b7f-499a-804d-13cc8bc40c9c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("32ca1304-95b5-422c-a3b0-e005480596cf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3319bcf8-c428-4486-a7f4-bc1191fe8268"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("331c2f22-d9c9-4cb6-b8c8-313607a34005"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("33790ea8-3d64-4146-af13-49f0bcf5f45a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("363f28f3-de05-4161-9f81-b67ee77257ba"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("36b66e3c-464f-49f1-9c8e-34e86c6dba2a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("37099bff-e5f4-45cf-a841-891c4c487ead"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("39407e5c-41aa-4522-aaf0-d36f787d1eb0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3a254c1f-df84-44fc-b79a-a738e3381a52"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3d44c9e7-9504-4306-a30d-f3b6f0801a75"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3daad659-4bed-4ae2-bcbb-6073f4187d6e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3db98f8c-fc1e-4a68-8bca-15ee2b37f185"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4050fb09-c7a9-4988-91f4-29246ce2c5b7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("40ad2c09-b74d-4512-965d-f00255e1094e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("430b2853-0ee8-44da-ab65-c2ee4e24b41e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("434149d2-8f5a-46fe-be60-80b80042fcef"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4379f6bd-9c7b-46f6-aee9-c9ac7bfeaa6e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("44da80b6-3c4d-4568-acfa-6411ca1e548a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("45f3fd97-04eb-47bc-a514-b9285f747422"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("46572486-1c7c-44ca-a142-a0f6b5b45101"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("46f97d7e-2fc1-43e6-a6ce-da9f3827f746"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("49213f67-56c1-4c8d-bdf5-91b189a5832a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("499f8e6b-0f7a-43b1-88cf-65b057509382"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4c00dc9c-96fa-43ab-91bf-5e1c46023fd7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4c78c19d-844e-408f-be70-d9548b6cc970"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4cb3c551-dc24-44d5-814b-6b14961d3b1a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4deb5910-5b75-4e94-9c35-cb99da0bc998"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("508838e1-d497-47a2-8e48-817ca5791a4f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("52a730f5-7c26-4ba5-8d31-1cf184ff3ad4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("52f69d13-7b4c-43bf-bd10-3863d694cada"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("537e7963-e8cf-4e22-99d9-c7f7facd4522"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("538d334f-4bc6-45b4-b3a2-8de69ba2c047"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("53be6168-0e89-4e76-bcbc-d3ab140c1ea3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5589fdf0-5a08-43a9-a54a-67c3c49f9a6e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("55fee01c-3345-4380-8eec-34578f40bc00"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("561f1d6a-06a2-45bd-a6e8-997f3cb29a77"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("56d69183-cd5e-4786-892a-bd99733db9f4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("56dfd5a7-e60f-4b9f-894c-09aba94a526f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("576fa948-343a-4cb6-aab0-caddc3fd7661"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5795e9db-564c-42b2-9c86-cd6f1c85d3d3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("58197086-109e-4cb1-a10b-de6271b30df6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5846a7e6-459f-4f3b-abf5-15a750a6e876"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5b76eeda-ec08-430d-a3bd-4e851f02fe7c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5bf8d529-4efd-478d-8efb-1d1d6879a243"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5c3d07fb-2dd5-408c-ad86-f4f6c83100af"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5d2a164b-24e8-4b13-ad34-87d4707fb3bc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5d3be95d-79d0-4d96-8c50-5953da5aeb23"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5d661e12-88c3-464d-af77-cbc6ccf7bc11"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5f16aafe-cdcf-4d45-801b-c3036446d8fc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5f25a6be-5a15-47c9-b54a-8b7ce86c20b6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5fee3472-e2d1-4c8e-9a4b-66e2d2a1e527"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("60191e76-34f2-489d-a200-9f01919472f1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("609b4c14-b52b-4bfd-97af-9b29c2f2c4ec"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("60bd2c3c-1508-4fca-afb1-5b13a0214326"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("61275e4b-7669-453a-9420-24e149801348"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("62405e83-d4aa-4383-ad28-f8c3d63d7b6f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("625408e4-26dc-4b8d-9245-fa927c66f550"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("626c1cdc-a68c-4777-9550-c9cd077aa5ab"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("62b39db1-bfbe-4acf-8493-89b3ecde4f60"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("62f71e25-1df1-4505-9df8-5d91cb613e4e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("63809a20-e4f3-49b4-adb1-ca967560403f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("642e5e1e-dc8f-45ae-acc8-9227a3fdf362"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("64eac7cd-f66f-4918-bec5-d7ec36d05268"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("678efd34-3c0e-4f24-bce8-809ef94b05af"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("68b8f360-cbb1-4301-a18d-f03dda955384"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6a56df46-2dc8-45c2-a3b1-585300acfe20"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6b133ee3-9e5b-408b-9e63-6ac05acc4657"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6c141aa5-d8f3-4011-9cc8-b0cccb72ac24"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6d4c4f98-36d2-421d-ba5a-5ef9a049c10a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6db04b7f-0738-4929-a720-cd88c2f3f20d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6e76bef6-c0c8-4762-abf4-bd89d60309d8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6ec7663e-96e5-44d0-9d6f-4bbea84aca9b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6efb58ce-d44a-4413-9ab0-fc127cd14e2a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6f756ec9-9747-49a7-b0b2-40d032c47343"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6fa5cd3d-ed8a-4d5e-8ecd-33ae3e2d3a06"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("70086ab5-bc87-4335-9cad-ec433c1584c1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("71b43fb8-719a-477b-bdb3-254d500429d2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("71f52b8c-b3ec-4cbf-9779-9ae4c0edb9d9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7231ccd6-7680-4b49-83c3-9cc525fb8f1d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7246b327-5bd9-48be-90bd-34d32cc331cc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7262bbf4-467c-4b32-9803-ba6b11b2c562"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("72db6b90-adf8-46de-bdce-4294611697a9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("735104d6-c35d-491c-9bd0-b60b7e462f26"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("74ba2c18-531c-4700-abbc-078a6c57df87"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("74ef9047-3521-43d9-867c-c347a2a8bbda"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("75bbedf2-0572-4531-8e8e-747c123d47ff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("75ed77c7-37c6-469f-924b-f7f68e95cc32"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("765da799-0856-4c23-8077-80272ee02c6c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("76d46213-45b7-4103-bed1-1c2065158ce6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7708a477-8902-411b-b095-ecc1c36dd667"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("78880a2f-08f3-4074-a2e7-fc9c922510b5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("79b07574-1a49-4be7-af5b-5f7611f1010a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7a97b117-04ed-4122-b8d5-a40beda122e7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7bc632f3-652d-4000-9edf-c36da10ec64a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7d21c3e3-1e16-4179-9f0d-76a1e9ccbcfb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7d2c3e18-2580-49bd-885e-966869bcf18d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7d7c0cc3-5dd3-463f-9c1f-58590986d5d5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7da830c5-5af2-4a04-ae5e-6be294f3a84c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7e4f6fa4-0b0f-47bb-a63d-73aedc031c46"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7e715557-add8-4e11-a2d1-8f923bd02d4f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ef9d728-37e4-468b-a18c-e841f6acba6d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7fabee22-2e4b-400c-9812-1f6b9590f15c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7fffca98-7d2d-474d-aa7b-dea38a6488fd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8121180c-ca11-40a4-90bb-f1b3e476f679"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("817291db-5d92-4d5b-ba5f-1432246647c0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8384f6fb-df8b-4da3-8fa6-b33e7eb5abc1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("848ee1f8-c8c6-4c37-b063-184918f20f80"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("84c22d61-2f56-423a-98cd-c0b7ade3089e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("84f5405d-e56a-4b19-946f-d0da2cbef06a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("852aa1f3-796c-43ff-b84a-75c2bb42b3b1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("85c9f013-b4e8-4a2d-8487-c7a02bbb09b9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("86cf6957-7b72-4f2a-b660-9008a43759c0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("871d30dd-8929-4378-8d62-a0c8f916f371"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("87a16f94-ceb5-412a-b579-df0308ebed8a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("888d9d36-5fc2-47a2-bc0a-5d465c44d5d8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("88b98217-7e71-403b-8823-4b0a9c83c03a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8af8187d-1270-4d72-8275-ddf55ff4f29a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8bc08ed5-f465-4c33-907c-b2798f2d3387"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8c00b998-762a-49fe-9fc7-7369e992a2f0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8c07b0e3-ada7-4173-a0e6-cf569acdbd34"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8c1de958-abdc-444c-a4ad-874c15018319"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8cde2bea-02da-432f-bf26-01115100031d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8e9dadc5-c3af-44fd-8d67-02db91a97189"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8f6c3d55-97b4-40c6-a538-f395e14ed017"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8fc80f84-b6f9-4659-9be8-5d536da09f32"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("91c90555-04f1-4b1a-a2d0-67b7a0aba959"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9294eee7-4760-47a2-9e8b-9d8406b8f163"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("92bba175-3481-4b66-a353-eb50f261d5b2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9339fb72-fc2a-4171-a6a4-4346227c140e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("944af941-3975-498b-b1a0-bd41e3666cf5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("94930418-2969-4e71-b596-939d2d28e455"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("94ba6435-fde8-43aa-a829-cde180b003ab"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("958eaf5f-3d79-4ccc-94b6-34eb65295d9e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9591bf68-2cc5-4661-9515-98211cf503f6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("95a087d9-6637-40b7-b8b3-5320e45d3af7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("96ed7e34-7d1e-438c-8df1-9dabe2744d42"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9706e013-7ffe-4ae1-8d86-1bbe870143cb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9727243d-55d5-44b8-8fde-0fb934df983e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("98742728-3e74-496e-bb4c-ec9856282f47"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("995e66f7-cc99-4990-9370-9aa60fe39e9c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9b4a376d-8dc0-41c3-a0c6-373a4ca79ee3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9b834f0f-e81d-42cc-8fe0-b00ef258969b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9f1f8adf-4cf0-48f6-b5dc-a672bd3089aa"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9fc2ffbf-e69c-4e79-88d6-17cad461a0da"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9fcdea42-fdb4-4000-93ec-f40b25282e40"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a10a79a3-d4a2-42fe-9619-73dd84364926"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a1153efd-953a-413e-ae45-207c5b9d69dd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a14867e0-756b-49da-a7cc-e7c19cda9130"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a1d7ca80-817d-4209-8bfe-951bf10cd8bf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a2bcf29a-6af2-42dd-b76c-8a4f66f80c1d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a2fbc399-5c29-4c16-b43e-a362ddd57912"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a3ec965b-6334-4976-b30f-3d76830c2d94"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a49b380b-15ae-426c-81cc-d686728af36a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a4c38138-cff4-4d1d-b0c5-c1b0c9134c14"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a4efea34-701e-47a8-a3fb-a7b8a7eade69"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a617a35d-5d70-4ee2-8604-5b5120591e29"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a79ddb8a-86a2-485a-81d1-1db795d838bc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a7dda783-cb6d-49bb-be2a-d7e6e4dadac8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a82a3ca4-811f-4e64-8718-fc56fa4145da"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a8eee6a5-634e-4c91-9b6a-e34dec66a553"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a92c76e1-4570-4455-81ff-a9402605748e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a92e166f-781f-41c0-bf63-f4222c3cca27"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a99e1372-d6fa-4071-9a89-627e7a5d8da3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ab34b2ad-c8b8-45c8-9848-4fc9e32df476"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ac426a3a-3cca-4773-a5ef-e639aa9eed38"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ac6f5a08-d61a-4765-9ec5-c78ab2125daf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ace8037d-30e8-4cae-b024-23cbe7103780"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("adea959f-d004-4e95-b533-e8e8ac6dff33"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ae2fdbec-c063-4698-a578-7df958310358"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ae55fd8b-acc7-467a-9d9c-eafc201ed005"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ae5b8ce9-1406-4a12-90de-8ff2f9ed7c86"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ae66bb12-49d7-4475-89ac-6a581c14c1c4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("af482c86-2600-4f4a-ab44-0064a6826c32"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("af4e290e-6731-45da-acdd-14c91aa104ab"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b2ab5979-fae2-4abd-9c9c-8ecef2f53864"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b43d0955-5ffd-415f-94d9-3c836948af75"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b682a899-0dbb-4a56-8cfa-d6c3b4bcaf5e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b6a1c1e8-eaf9-4733-ba75-1c0796bc0762"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b6da194a-6469-49af-95ba-c6c5f7bf184f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b732152d-7aa7-4a53-a2c4-c66d551e7d03"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b75f7353-77f9-4508-83b8-7a93d78e20a0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b7965f41-1789-4029-a607-459ba2093ef8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b80200f7-0ace-4c44-89cf-fbc84abec2fb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b877bb53-cdbe-4184-8f4a-aab192b0b685"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ba56ecbd-ac4c-41ec-b5a7-92dbc3e4669d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ba79483a-7706-4c9a-bbea-9e21d4775247"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bb4c49b9-fb39-444f-8515-98e21af452ef"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bb61e087-1d70-4188-bfbe-bc9060d87f47"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bbabab15-8a2a-4602-8e71-a76ed7824e6f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bd8d3b8b-fe2e-4114-a28c-6b5ee8aa9cd1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bd949d02-721c-4e3d-acc6-0bba295b51be"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bf3f8d09-97e1-4701-bbdf-ce54cb2d8ca6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bf5aa988-db8b-4640-a50e-fb22022c5688"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c0162f1c-04d3-4401-a723-4bb2f119b733"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c05fb28d-3e2c-45fe-a6f6-68ad42e7b87e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c0c33352-139b-4e84-bea2-56a090e9f8c1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c0e9f079-1662-47c4-86b6-be9a65b366c1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c0fc23ca-01ed-4b25-85c6-d3e23d03d857"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c1386736-8392-4c7a-a36a-68d57e230bd5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c17774d6-b55d-4a69-bc93-d9251ba237c4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c2c10d4e-be00-4376-88c9-d46658662f08"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c3a83d0d-5788-4b68-acdf-3772617fd4e7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c481cef7-9230-4be7-9ee4-1e8c02ac9f71"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c5663f5f-97f3-4c92-a6fa-cf03ddfbe2db"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c66552a8-4c6c-43ed-82b7-54eddf5c2cd7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c693b667-ba3d-4f60-bdb5-733dc3b7bba8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c72e2145-29c7-48d9-af65-e4f5336c649d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c79e0a2b-95b1-4c34-96c7-6ce58cc12563"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c87ef58b-186c-48e7-96e6-64cbf6e118a9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c8c4ed67-57d0-4af6-8b70-a3f8b1aa68f9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c9bdfcba-6ec7-44bc-a53f-fe762ae95863"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ca5e0e63-fcb2-43fd-9e0d-f9752ec5a917"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ca9ae98c-db3d-4c77-97a7-9d2ec125ae68"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cb8f6527-26a9-4970-bbd8-a68a17e393ec"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cc65e2a3-fcba-4d58-b8b4-a4eb2075c271"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ccb105c2-5aed-47d1-ad17-bffa1d5bd695"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ccf5cf97-08f6-49cb-807e-f619d4664cc1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cd9b5442-5312-40eb-a7c5-43aee42ed879"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ce08ee93-36b5-4411-8a48-366929948aa5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ce0d930b-089f-459b-a586-0de52a552d23"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ce580c2f-5b72-4456-9568-43b1bb714889"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ce95f686-d40e-4bbc-9b37-8149d588f30a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cf9fe5ed-cdc2-405b-966b-278aff8aed54"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d03edb1f-2991-4f8f-9744-c9b15b655d8c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d068d4cf-8d33-43bc-b918-0e660f0b3725"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d13268c2-6393-4dfe-8e5f-7ecc4d1c90ff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d317fad2-2394-4efc-92fa-73575caf8b33"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d339b214-43e9-4f6d-94d4-580165104097"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d33ba703-4c34-45e2-8668-d2bf14fca413"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d46debbd-c05d-4b5f-8b35-6c9236cab96a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d4ab3562-0723-4d7b-b859-e783e4a889e3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d551c73b-6a8c-4504-b0a8-591ce8e3c758"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d56d61c6-6fe8-4457-920b-9fbb812dd3c0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d68d59d6-aaa7-495d-9219-592773ce8de7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d6bedd92-9c76-441d-84f5-0084e03c99a5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d764ac80-3e1d-4c56-8d16-25971baf0a52"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d8834da2-537c-46fc-aedb-b72366b8d00a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("da37233b-7995-4ba8-b81f-ab8bb0bc5a5d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("da4c707f-7ffc-46b7-bb0f-20a012a2c074"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dac7aa03-18d7-44ab-8322-3f4432e9686b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("db316458-4cc1-405b-ad57-d49903c1e5fa"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("db821ff2-aa2d-4724-93a2-6dffa5ffb761"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dc469248-8c25-48e4-9d97-a0401d1cf3ba"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("df72ddcb-0c39-4d6e-ba9f-4379069bdb7e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dff03e92-8fa8-4f91-8955-75db0f8d09a0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e005a686-e68f-46ad-81d9-fdb29e32f8bb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e14a66b7-9f89-4c0e-a405-9ee729c3883c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e176287e-03f6-4247-a14b-dad789a48527"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e1bc925a-a465-4dbe-84c0-9496117a7be8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e21ea55a-a7e6-4e49-8cff-5215651f6674"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e27f8e38-4cf9-41eb-a00c-895b917e57c6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e2ba9352-d4f5-469d-88ea-677b05762c40"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e31300fc-f8ec-4ba2-8986-7b82a82f41fb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e34a2e1d-c926-4570-9b75-847d64833f6b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e57bde88-f6cc-4249-ba32-4ce77f13c1d8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e594701e-244f-449d-ba54-a7dc8816090e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e5d58cd0-5fb0-4787-9928-4ab4255e5fcf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e5e0151b-4204-467e-9d6b-79d73bb38ded"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e5ecd3eb-0262-44da-b8fa-eae2f9ed9910"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e63c9aa7-f6d0-4993-91e0-7e6db29d07cc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e64d274b-2271-4c7f-ac4f-bb8be7c65c79"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e8441ced-d8a3-41d1-aa7d-12ee7bcd95bf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e8a929b2-d9a2-4fb2-81fe-cade496f13e1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e993ba93-346a-4933-b5c9-8f027cf3542d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ea259033-3da5-43f7-b046-2ff31139c971"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("eb091ac5-3c71-4d83-b62d-2c50f7e0cc21"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("eb3dd37d-1240-4448-8329-67658194770d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("eb648e92-6478-404a-97e8-f5866abe15f4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ec2d74bc-9fb3-4a46-a53c-b820f04e625c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ed37d6ef-2ae9-4d46-a850-50789d8d2b41"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("eef8ff56-5444-48a1-8d16-1bc13c69b811"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ef0aac7b-b733-4ac3-8995-b120edf56e3c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ef2324bf-ee2d-4094-a42f-13c6beecd049"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f057c80e-04f2-4cf7-b291-5bfe5d83f0de"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f0764eff-6b38-453e-b66e-33e4282d01c4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f1c02a24-0fc0-44b8-be79-4f818d212b00"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f2ab1e62-1931-409e-b7e2-096a40d5f356"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f2f361b4-f3c6-4936-8d76-3489b6562af4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f3362918-aa9f-44d8-a1a3-80719830cc2d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f65b39f9-61b2-4112-92f0-52271ddd3bcc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f712b6f8-86c7-4ec4-ba30-47c2320fb896"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f736c018-cb3a-4331-8053-7fb274165639"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f7929e71-4bb7-4d8b-a1d8-33fcf1064c82"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f8117993-c102-4275-bbcb-4e8edb184d07"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f8a14497-19b0-48e2-b85b-ce08fa7bbf99"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f91874dd-7c0b-47f2-9fe8-5d180165c8d6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f9b03253-e11a-405f-a7e2-4e290833ac00"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f9ef66a3-01ec-4da6-995c-858c3235253e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fb131d79-256e-406e-8786-329edac32f57"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fbe5d5f4-d8ec-4471-a2d2-bdc75c57ba86"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fbf51763-37c0-4c9c-af60-79cb64538b59"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fe29d11b-ba86-43ed-acc6-2667023962eb"));

            migrationBuilder.CreateTable(
                name: "BookingPays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<double>(type: "float", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    CreditCard_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingPays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingPays_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "AppUserId");
                    table.ForeignKey(
                        name: "FK_BookingPays_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_BookingPays_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4688412f-909b-4d14-8bc7-9369ab019a80", "f4371fd3-dd60-46fb-b06e-e9b5ad88bc69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b26149ef-8284-462f-8c28-8b6682ea9fa9", "edc84d39-7a2d-451b-a922-65b83f80ff8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c29f94d7-cac0-4247-9103-3a6e49c56e20", "a110a096-bd8c-4fb7-947b-39d3057d00a5" });

            migrationBuilder.InsertData(
                table: "bookingDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { new Guid("001318ff-bd58-403c-8602-c652f7ee5c52"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("008dc459-ba84-4810-b4ab-57792e4b208c"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00df52f8-5224-436b-a718-f04ee1d2bee6"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0136d8eb-1ac6-4f03-8d53-7f06621557b0"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("017b057d-8128-4efc-92cc-9e38c6d682d4"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("01bc8ae1-ef03-4696-846b-a0e274ef8e6e"), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("01d876b8-d582-4fc6-9c52-cba8e2b4c14c"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0277c75f-1ed5-4128-845f-33b0c0165965"), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("02d5ad64-1d53-4878-a71e-f384d763e2d4"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("030060ec-0b07-45e2-838e-fa5ecf98a732"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03a6cac1-c9dc-44dc-8247-2c291c1ace6b"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0403a654-82e9-4c2f-a690-0961d1d1a0dd"), new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04a189d5-1df6-40c9-84ea-20d6b927c34e"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05ac3731-9d13-4499-81f4-8bff7a50a2a9"), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("06ece24a-fd24-42f0-bb31-b5667ed09950"), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("079267e7-0969-446d-b711-7eadf7f8f20f"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("079e95ca-735d-4efa-95fa-7cb3e85d754d"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08ea27c4-a7c1-44d4-9bfa-af2cb72ae31d"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09829080-10f2-46d2-b2d3-8d2e5fd1d9d0"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0998e4e2-f519-4988-837b-50bb31dbbd66"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0acca82f-f4f3-47e8-8d91-55e17a20f290"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ade63b1-078f-4eb4-8b94-76f6893520d9"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b382264-9621-485c-82fb-a8ea14a29ac5"), new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c033c80-3ad4-468c-b344-138e50b220ee"), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c5207a5-f5df-4ff9-b256-cb2d17ec03ad"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d893b6a-d846-4954-a387-869b1e0550b1"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e045c88-c05d-435c-87d3-093934800350"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e258381-b0dc-46f3-a03a-b3acb26169a6"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e7cdafe-665e-4ec7-b034-d05cb464e83b"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ef9b933-5ff3-4873-92c2-1871990354bf"), new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f09be12-ca0a-41ba-804e-68cde4d51528"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f18c0a3-8f8c-4368-9959-3f36ddf57ed8"), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fdeea50-518a-4326-9696-de6a1bce3332"), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11443144-001c-400e-afa9-8fe773b6c6b4"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("119dec61-8067-4a26-94f2-42e61b1bd29f"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11f62148-54e4-4540-b206-e803e9cabdc0"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1282dbe9-b7b3-4eb1-aa1d-42ffc3af5224"), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("12a306c0-257d-4705-917f-0f576ff88a2b"), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13a8c15a-3295-43b2-acbc-62353a1f0921"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13d41003-3086-4c81-be76-351f5d82c570"), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("13dd0b81-3be4-44c7-80a0-1a9c5e83b7d2"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15cf7bb7-c004-4d5e-95d2-e4b6da5f104c"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("176551ea-0f3e-4373-af50-45102054f848"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a71bd53-6405-4c08-9a26-76b6e54c42ac"), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a9cab7f-ead4-4d8d-a309-770ed77fc6b3"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b08864e-9426-4eb5-94de-a134dbdf3cde"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ca15654-0f1b-4d0c-8fa7-be1666f13c7a"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d10bd3a-3692-457e-ae69-db3fc6328d84"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d714ff9-6ac8-4e45-8e46-f2e630f894f0"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d90ecaf-582e-4ec9-b6b3-c428ef94b84f"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e46e495-2609-49f8-9c55-9e5da7836847"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e70c308-9413-4b3c-83ba-39e3c9236d9d"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1edfa52b-55dc-4362-8d61-37bcde3e658c"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("210000d7-a29f-43a0-bbb3-ea8e4cc60b42"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("210e2bf9-fe42-493d-a9fc-e87cb26676b9"), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("219056e9-9ac3-4a0d-86ec-46c753c0cf30"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21b2502c-ec36-421b-8e04-45209a9e8d52"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("237a55fe-f1ff-451b-95fb-3b462cc7219c"), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24b91988-4cf5-48b9-8725-888249a59ccf"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25b3d284-b3bd-4f85-8bb3-fc3770f1ec3d"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25c8309a-c756-46e8-a9ec-5c141c34271d"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25d05ee9-0407-4eea-b6cf-b0fd336d95cc"), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2627f4aa-a7ab-4843-94e4-6d4c4a1bb5a9"), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2689bb4f-e5d0-4096-9658-f53376185096"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26fba82d-7547-4195-9a3f-cf6d75e5a122"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27e75b95-b15b-4317-b377-f2582000f7d1"), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28c75724-34b0-4580-8ad5-6ed182a3aac0"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a98cb79-e114-4041-9f6e-6ce3194c861f"), new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b0208af-74d7-4170-a4d4-883234a9e873"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2bf82349-9edb-4081-8526-058f096eaad7"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c8ac92e-282b-460c-bcda-1aa348c6f437"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e52d8e1-dc4f-4415-918a-77aaaa2728af"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ec62998-b689-4c22-90a3-00c7a3e43fdd"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f43a785-3c63-4cc4-8272-be1c4439e2be"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("308745ad-e753-444f-8744-386c15f3d704"), new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31040dfb-6f2b-4aed-b769-89d16cc3c723"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32e6774c-781e-4b52-b9eb-fc07b61995ac"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("335db9b8-8a8d-431f-879c-ea2fccaddfd6"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34613b51-a17e-473c-ae52-f28775d4853a"), new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34a91929-e8da-42a8-9b1d-c96014256c26"), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37b7bc04-003c-4153-8ea5-de7ce93e3df3"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37ef98e9-6a74-49b9-a3b5-f702c4217eb9"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3812787a-d420-4dda-9979-3671a586ad73"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39abf65a-5bec-41ba-ac39-635b7fc58a4c"), new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a7cd74c-0247-4a06-a0df-588472be1982"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3aeebdf9-71e1-4667-8ae5-006204e464e0"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3baf1781-0e0a-4681-8e51-899e3500cb56"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c6c696a-68ec-4b32-916c-84b4df00a291"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3df3e24f-009a-4ff0-8b93-ba6fc2d58354"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e311109-d9fb-463d-9194-d54f5c577c42"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e996a33-efc7-444c-b7d4-f1e67a54de9f"), new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3fb28c4d-30da-44f0-b106-2e974eb32e06"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4214bd20-f4dc-42f0-81cb-e739a21e8839"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("42980cac-92ca-4ec3-a846-e97000c830a8"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4347efcf-de62-4613-ba88-1357d74362ce"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4406437b-458d-4efd-bafe-f1ecb579f6e6"), new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45ee73db-60a6-4f12-bdd3-90ca746b81bc"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("461b5722-9a13-4392-bdeb-4bc21b08dc94"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("473a84a1-ba28-49b7-af8b-9bcd66a14f03"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("476f3aa4-08b9-442e-a04f-bb595906a26c"), new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4773adf4-37a7-45d7-8463-5c4b0ce12052"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4830577f-0bfc-4d08-b675-06237677fbf5"), new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("487a74c6-5076-4d85-85cb-9c625755d6a1"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4890a52b-9710-46d4-8460-0040204f8584"), new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49823ee9-23f1-4035-b4a7-7984da1a182b"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a0fefde-6945-4f64-805e-c21377e42983"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a18b0cb-5644-4c6f-8c87-71acb2401252"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a2ecad7-216a-41f1-9d37-70542e5651d7"), new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4a78e63a-f83b-4dc0-9a29-a55fe88db6c8"), new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4adc46a3-81c6-4c4c-b52f-aeeb18da11c4"), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ae19276-330a-45f9-a387-d0dc2f3d1098"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4bb844f0-8919-4cad-a67d-2978ae7796eb"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c850e4d-08f8-4b21-b2b0-3e437f2fc5a6"), new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4d161847-6bc8-45c5-acc7-bdfb53034e37"), new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4dc8deca-a956-4268-8aca-248d142b5768"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4ec54a04-420c-4496-99ce-e063adf8dfd9"), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f70223a-1362-4fb6-9d66-5f0bea95bf42"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4fa2978a-1a1e-4605-aa3b-2003793ea056"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("501a348a-bac9-48a0-9dc3-7fa3d4aed573"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5126bd02-beaa-4466-bfe2-7b0235d1c987"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("513f1f6a-8b63-44df-b01a-67c8b215f4b4"), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("528c8d64-fc47-494b-b754-d1b547a5132e"), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52d5094b-e96c-4f27-8768-25a2c88db6e5"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53c735d2-63f6-4c31-96f4-d72e01930cff"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5455bbf2-ed79-490e-ace1-6068cc80d5bb"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56d7db42-5b45-49c9-b50e-1907e12cceb2"), new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("592b1d39-72e5-4abf-96fe-2a89e417ee95"), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("593a93e4-75d9-4862-a522-43c640a2fe76"), new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5952e695-30f7-44c3-a9a6-e9f1cf918c35"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("599ef4e1-c07c-4018-b01f-f4d9f134d3b6"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5aaebbd7-a378-4d1e-a85b-4e2dce4096dc"), new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5abb8705-71d8-45a0-a4c9-435fbca1e8ac"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b0ee327-fd0c-48ef-8e27-9c7f8d65388a"), new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b12d377-892a-4f4c-96c6-04f194366292"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c1bb508-18f1-4035-a633-d00f8dfbae11"), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5ce61ed7-45af-4529-bb12-165f4a2073ab"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5dd23ec7-ab9b-4e5e-a550-a6645302264c"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f760528-b0bc-475f-8fdc-3f383c3b5fdb"), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("605a13a9-d0f8-4877-8aab-aa3a47db9d88"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6199d27c-bd5a-4461-ae12-840e199700a5"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61b98065-2955-4bf7-a83e-c3b9fb5bc60b"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61d6a7ed-dedc-4f72-beff-731669fa93b8"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62db4c09-b8bc-4dcb-b996-8f1d83b52e0d"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("633bd56a-102d-4ae6-bf11-c63bce1dcc6f"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63c6dbd3-6729-4d15-9dd1-0ffd59d112dd"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64de9040-8ff0-4c98-b4be-8489a995acde"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67c378f0-a64e-42b2-b7fa-1a81d4b6d334"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67ffb250-ebb4-4121-b00b-fd9323d957be"), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("689921ad-6ffa-494a-aeb4-3a15b6f07bd2"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6955e8aa-ddf1-41d1-97df-be4377567ab7"), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6963cdb2-8a33-43ae-a31e-d6a5be1860a5"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69bd2a06-4629-4278-8dd9-a1bd0fe1cb41"), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69f182f8-a9dd-4156-89c1-7321a7d01cf4"), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6acbea85-4ad4-40f4-a1b3-22ad41514506"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b6a6bf8-c002-4403-9fe4-5267a64c6e0c"), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c4b3874-e7d4-4b64-a70b-61b82bc5cf78"), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6da08819-3095-4f80-a2ea-47d07c17404e"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f05bacc-a0f3-47e5-90b4-ee4aa9dce7ca"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f3aa9b4-a604-473c-a45b-0e61e552f440"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f5699b7-d71f-4789-bc72-2b2ffa22a87d"), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70576e6c-b04a-4d96-8fb2-de8f811dac77"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70cb9105-9e78-4042-a042-d048ffa962c3"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("719e572e-c234-43f4-8535-0a7d7d398c0b"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7216352c-28c1-41e8-9927-ca3c803ee1c7"), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72cbba9d-5619-4133-8f4d-14f39c61c2bb"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7329f611-b795-4883-8f01-ce8020d9532f"), new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7365b4ba-b9e2-4056-83db-6ea686280e61"), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("73b4a4d0-3c0f-4973-ba32-10ff3114a7e5"), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("751ca491-61f0-46f3-a3dc-f9e3ffc9f698"), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7617ff4e-3f7b-4180-b0d2-695da9325188"), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77004b73-d82b-4ee4-a718-fea8ea0e0b01"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7735c90e-b924-4ee8-a2f1-702f9cf687c6"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("783ee74d-6989-4458-9bdf-d63be40dabdf"), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79f7e0c0-7c70-4efa-8ca7-079fe0a81f6a"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ad8f6d9-fb07-4e67-ad3b-79452cd05929"), new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ae4ff81-9f55-484a-9006-e0b061103b36"), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c7c456f-3e32-498c-abe2-498d498fba28"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d532491-7f77-48c7-b0ac-877c1b03f7af"), new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d758702-aed0-4153-be6c-96c0a0f2b2fa"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e1b9580-2988-405e-84a0-e3aa9ef45a7b"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e3d4a1c-17bb-416c-8a08-2146237b5b2e"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e87a490-46da-4ac5-b3e0-aaecc706cd46"), new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ebb9f87-9d5d-4140-a42b-e2b511773391"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ef743ef-e3a4-4709-baa1-0c977d3aa4d3"), new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8024299f-c294-42fd-9dbb-1aa1ca4642e3"), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8116c9e3-bb97-44cf-8db8-8ec4ca849304"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("820c02e1-89ed-49e4-8979-c55221a8aa2b"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("825a38bb-473e-445f-8509-c32a9e4c4384"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83dfb938-a6ef-4730-b5fa-faee11b28ca4"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8624a03e-f686-4daa-8cb9-f51edd979e68"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("863fbdfb-df6e-4779-b751-0b2dd0e70b16"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86522362-bd7c-4be7-a9bf-8a1ea10e9d59"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86a31853-5037-4179-af08-eec826605104"), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("872f6665-e885-4af8-83ae-421f20a9750b"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("887e95df-4cda-42c3-86ec-a78af86cdb9f"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88c66f56-5ce8-42c4-8645-0611c2bc9540"), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89234de7-3d41-434f-a0f5-dd0429a17754"), new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8986c356-6a21-4137-be9c-ca2bc860abcc"), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89c384b3-563e-4778-8bee-b4822c16c37a"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a084256-fb9c-4ad0-9734-2a05ba80fa83"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a5ada02-3941-4591-b709-d11d2559bda3"), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b2f216f-91d7-46c9-a489-38fb8d41a978"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d04545a-2469-41a8-9fda-0ef95e0ae9b4"), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e17dcb9-427c-4659-b532-19e05d2e80d1"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e3c879c-a1af-4e32-8003-ea2eadf7359b"), new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e62beaa-c819-426d-a34a-fa4cd60762b8"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("915e43e4-0597-4955-b85e-06abb4d9e92c"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92074d82-1a34-490f-aecb-085ded07f998"), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9323a6a5-2228-48d2-930a-b3000be6dbff"), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("932ff914-bfb1-4f70-983e-9229bab71a9b"), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94fd96d5-8d5d-4c16-b799-8cff310a307e"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95c6005c-8910-4529-a5b4-1fa913d9f359"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95e9f374-4ff5-4286-b67a-0db776ebaa6c"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96921d63-a01a-4604-96f2-f3bfb8295041"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("977903cd-f337-43ae-9d9c-eb085f5ebe83"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9933011b-b5c2-499f-8ba0-8bc966d70aea"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99556ecc-0ca7-457f-a7b7-fe471b82e7db"), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9991fbef-92a1-4e02-82a5-06f31530b9b4"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("99c4eec3-647a-4849-b0c9-b388e963657f"), new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a7d12f1-c3af-40a0-8b43-377e50ffe237"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9ca33208-b0e3-466f-af32-7ecbf9709b0f"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cf55210-0124-419e-bcd7-38c045ebe6c2"), new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d8d8dd0-389f-40c5-992c-7195780dc999"), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9d8dcbaf-69be-4da3-a453-42ed3f5fb668"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e570c6f-f8b4-4e41-b0f1-f9aa3e7b1138"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9eac13d1-6e3d-4ebf-8b85-713a5d301141"), new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f5db3cb-a824-451b-b21f-7d58778b7434"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a01702d3-5b62-46e9-8130-e2db70cac86b"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a075b800-0b49-4d4f-9d12-ed160120acee"), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a09f4025-415c-4483-a3b7-bd525f502bd8"), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0fe56de-2309-429a-967e-68e2792645a0"), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a10cf97e-e013-4086-8f1c-8d56e2cc1114"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a133cc50-5b0f-4944-82cb-1bea0f8a1e3c"), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a20bd69e-e2a5-439b-88e9-a62a7e791dcb"), new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2bd647f-8a30-46f1-b5e8-0a72cfa67aa7"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3d095fe-6fb5-43fd-9f5b-b5727fbc60d2"), new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a513cc12-d9db-45ad-b914-0f4ebbffca8f"), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5d3c522-665e-43cc-b37e-ee5e79734160"), new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a65c3900-0e0d-41bb-9dcf-77d8c99a2794"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a73824ae-6db8-4042-95a1-0ccc63f56c56"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a838a0d3-f002-42bc-9fd4-d39cd9bc51df"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a926e9b3-89b0-4ac1-b0c1-d9228b48eebb"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9492846-29ea-4dc6-806f-bd998ee9b702"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9848edb-5863-4655-aa27-7902ac70d8b4"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a991d457-aa08-4b01-9306-f8cc5b280307"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abca79b9-ccd0-40be-8329-846f31482b40"), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac4dfe32-2bdf-4c50-9cec-52e957b16f0e"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae403e09-722b-41da-b71c-b531a322acb5"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af40b82b-523f-4b54-a651-040edd7581fc"), new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b0ec6541-c09b-461a-9e50-6dd2065ac66f"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b13d6a1d-b034-4d1f-88df-bb3ab8861d8f"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b17222ba-40a1-4f4f-a87a-cc132a9cef3b"), new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b199b687-7dd6-4655-acb9-1905e2f51a64"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b29f4688-72e9-41e8-a33c-1289669dd620"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4575982-a8ee-43ce-a600-9a34189a9fb2"), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b664f104-4aec-472b-90da-a233fd1bd1e9"), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6d0383e-9d06-4746-adb7-deed0c3d8629"), new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b805f934-849c-47ca-a19c-c2c4e8953387"), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b833ea39-276c-4f1f-87d6-d01ae24d3134"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b87d95e4-7b07-4eeb-9ec1-73402205ef24"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8b9a9b6-7c84-4da1-aaee-d0fd374ddbec"), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9523fb7-eb88-4e7c-a983-fee86e1422fb"), new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b975a2cc-6e47-46a5-8e6d-2f450cab6aa8"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b99c3c65-cf05-4fd6-9d07-25ac13898386"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bae6cded-7c26-423f-87d0-de1292f034fa"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb3cd052-4756-4da5-80e1-da407c4518e0"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc6b5912-0565-4472-a046-23c7987fba97"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd8ab484-bc09-4479-a03d-39e7003f461e"), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bdab3327-0b0b-4b43-a7d0-4186e45c1ee3"), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("beeecfac-aef8-43f8-93ae-5bf1681ab1e4"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c02e41cc-765b-4a13-adf8-8eae1450aca2"), new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c08042a9-88d7-4aeb-9d40-900f7cad4cde"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0e0c3bc-dbb4-4b5c-a151-c46612303990"), new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c13e70f7-5533-4ea2-917c-b764239a90ff"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c15a319d-3d6f-48be-b1bf-5362fbaba5b1"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c179dee4-f48b-4965-9213-b39bc7d8937b"), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2006e16-3324-4246-be2b-dd165c685585"), new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c246a8df-6656-418a-90e7-47160c1c4f2b"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2a8561b-a1ff-4cd8-ada2-ecc4bab4fdc2"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3da5dff-a0c4-47c8-9def-101137b01ca7"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3e7f1bb-a3f2-4b37-acf6-d1a5315f1932"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c409d2d1-7888-4984-aa18-29b759bcf3d1"), new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c44369f4-f262-4e55-82d5-e3d3b5c9b558"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c88190bc-1ada-41e4-88cd-bfe0621d06e2"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c92e037b-5d96-4b62-b76c-6155303c072f"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c93f1a95-e6d3-4bd4-bfbf-120050f4cc36"), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9fb2e15-08c6-4d0e-947a-dbbc55a90ff4"), new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cad5db0a-bf99-42dc-af48-30403896a760"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb113458-7f70-48de-a350-b9d9de0741d4"), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb488431-d00f-42e8-8d98-96377114d38a"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc47d6dd-b8fc-4555-a75a-740468260e8f"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc4c320c-aa07-4762-9b46-c4699452332d"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccf0a5da-59d4-41da-8f57-367d6f56b6c3"), new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd2ad91d-a58c-437e-bd2f-82165f1af8a9"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdb96252-6202-4bb8-8f30-6594257bdf6c"), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cdbd554c-6bea-4b3e-8f8c-776c99a652cd"), new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf549ed9-5184-4d1b-8c32-2c648670b3cf"), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf9c763f-474a-473c-abf8-837b78166eee"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cff84efe-bb0b-408f-8fd4-bc0f4d88d2ba"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0ddb19a-f3a4-4d29-b5fb-075e22d41a8a"), new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d216f01b-017f-485c-8a89-eef23bf236e4"), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4547df4-af59-4976-acbd-9baf1bf21aab"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4c20113-2bfc-42e0-8810-80266e41744e"), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d59b2bf9-6eaf-46bc-8c06-b0a48d93de31"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5d5bf16-4489-4d08-bfff-b9e0eb1badff"), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d608152a-5a3f-4603-afcd-33b94a9f0559"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8148643-4aae-42e0-84d9-69b55ed66c6c"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d820c5eb-3417-453a-9792-a56e212f7d48"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8b4512b-6b0f-4e78-aa8b-ba2b89cff0ca"), new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d96f8940-83cc-466e-87c8-d3d558b04a6d"), new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9870723-18a5-4904-b75a-93275587abf5"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9fa9373-2c3e-4e58-a8bb-01c727002a9c"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da69ef6e-c6f4-4f7e-89e3-54c77a9d9859"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da6abcc4-202f-4a35-acdf-b48703648070"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dabfeb84-5cf2-45f7-ab82-c16943c51e12"), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dbcac770-57a8-4e1f-9272-d8bcd0a94284"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dcfa8046-8243-4e40-8601-bf0b95470a2d"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de1e7cbb-9893-4ca4-bc61-86d3733b18a3"), new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("de60759c-cc3e-4128-98af-afaa8c47e36a"), new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df46a9f5-ca4f-4d48-9526-fc54b6f17bb7"), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e386dcb7-bf42-4028-8483-34676ed6e613"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e439a59a-6a12-46f1-bad4-542a9ea5b12a"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4c497b1-d0bc-4fca-a820-5ab4df318b09"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4dd0d3d-6114-49be-9668-b2d8a7ad944c"), new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e4dd879e-d080-47a3-bc39-7f95db9eb7f5"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e521973e-f24a-42c1-aa3e-1c6542601c31"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e63a52c1-fec9-4a9d-9225-f36b7ef8ef90"), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e65d1d2b-8287-4ec6-b707-b2d82d89cc64"), new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e666cb6a-ac08-4d7d-8380-3ab3564dbe96"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e67f6308-e9e7-4010-b2ca-3bb1922f86a2"), new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e90b273d-94a2-4dbf-9351-39a7c8fe2925"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9e1c11e-e478-49c4-a2b5-5836cb3688f3"), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea518c3d-1e0c-4880-83ee-3746e58e2579"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea567571-78ce-4d55-b8c0-5dd6b10c5ae6"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea6c9917-aafc-4fa6-a9f6-486596ea8895"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebae12f8-5b84-4c0e-8b77-cc3bf5fc8d78"), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed3428a1-9f3a-473a-bde6-ebd57d1ea324"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef1dfc36-2309-45e7-b829-8c3a07272744"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef5f9d17-003f-4349-bc39-ef9b658965c1"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f00ef0eb-c3a2-4ba2-b64d-3b1e03f5cb26"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0ba594a-ecf6-42f7-b8f6-132041008f7a"), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f11b690a-7e8a-4776-bf14-b2ab7898a269"), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f17c4831-08e3-41b7-ac84-87227ff481ac"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1ed77db-7805-4811-af79-b54635751ddb"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f20aa949-350e-40d9-9a66-d0195a4c5f3d"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f24bb9e8-7c5a-44fd-b0ae-0873ee90bb65"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f25e2925-21f1-4919-b87f-d69092ce7219"), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2e50637-6307-42ef-85d8-2623faeb6c31"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f465623a-a1ff-4936-956f-331302ef4bb0"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f57e84ec-e979-40d1-a549-89ce1b80bb97"), new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7169ac6-cfe0-451c-9847-8324ed38a4d6"), new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f730c165-aa54-4eb9-8bc0-7e0d9eaac983"), new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7cf1b7e-f3d1-4a15-baf9-ec7663d52782"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7f4a376-9603-42e5-8442-cabb1c97bc3c"), new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8a46201-49f2-4dc6-8b31-9791699e4bee"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8ac0d99-21f6-4fb2-ba3a-2bef2fd3b18b"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8c579e1-d823-49fd-9ebd-48af46cd3f8c"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9227f5c-6e9a-4209-a8cd-ae6b2253baef"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa66f7f9-6456-488c-b616-d264147a3c1b"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fabe5032-a609-4d8c-bd1e-e9123b363eb2"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb9ee2f8-d6eb-46a3-bbda-9a2af6e1004a"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbd6a2d5-f7e6-49b9-bb86-c352c16db2cc"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe100b54-fb34-4a67-a22d-c5c97527c19f"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("feb757b7-5bd5-46be-a5d8-75441fdb57a0"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff4165a6-e8af-4796-a0ce-513f72e92f5b"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingPays_CustomerId",
                table: "BookingPays",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPays_HotelId",
                table: "BookingPays",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingPays_RoomId",
                table: "BookingPays",
                column: "RoomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingPays");

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("001318ff-bd58-403c-8602-c652f7ee5c52"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("008dc459-ba84-4810-b4ab-57792e4b208c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("00df52f8-5224-436b-a718-f04ee1d2bee6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0136d8eb-1ac6-4f03-8d53-7f06621557b0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("017b057d-8128-4efc-92cc-9e38c6d682d4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("01bc8ae1-ef03-4696-846b-a0e274ef8e6e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("01d876b8-d582-4fc6-9c52-cba8e2b4c14c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0277c75f-1ed5-4128-845f-33b0c0165965"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("02d5ad64-1d53-4878-a71e-f384d763e2d4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("030060ec-0b07-45e2-838e-fa5ecf98a732"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("03a6cac1-c9dc-44dc-8247-2c291c1ace6b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0403a654-82e9-4c2f-a690-0961d1d1a0dd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("04a189d5-1df6-40c9-84ea-20d6b927c34e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("05ac3731-9d13-4499-81f4-8bff7a50a2a9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("06ece24a-fd24-42f0-bb31-b5667ed09950"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("079267e7-0969-446d-b711-7eadf7f8f20f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("079e95ca-735d-4efa-95fa-7cb3e85d754d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("08ea27c4-a7c1-44d4-9bfa-af2cb72ae31d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("09829080-10f2-46d2-b2d3-8d2e5fd1d9d0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0998e4e2-f519-4988-837b-50bb31dbbd66"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0acca82f-f4f3-47e8-8d91-55e17a20f290"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0ade63b1-078f-4eb4-8b94-76f6893520d9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0b382264-9621-485c-82fb-a8ea14a29ac5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0c033c80-3ad4-468c-b344-138e50b220ee"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0c5207a5-f5df-4ff9-b256-cb2d17ec03ad"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0d893b6a-d846-4954-a387-869b1e0550b1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0e045c88-c05d-435c-87d3-093934800350"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0e258381-b0dc-46f3-a03a-b3acb26169a6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0e7cdafe-665e-4ec7-b034-d05cb464e83b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0ef9b933-5ff3-4873-92c2-1871990354bf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0f09be12-ca0a-41ba-804e-68cde4d51528"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0f18c0a3-8f8c-4368-9959-3f36ddf57ed8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("0fdeea50-518a-4326-9696-de6a1bce3332"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("11443144-001c-400e-afa9-8fe773b6c6b4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("119dec61-8067-4a26-94f2-42e61b1bd29f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("11f62148-54e4-4540-b206-e803e9cabdc0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1282dbe9-b7b3-4eb1-aa1d-42ffc3af5224"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("12a306c0-257d-4705-917f-0f576ff88a2b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("13a8c15a-3295-43b2-acbc-62353a1f0921"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("13d41003-3086-4c81-be76-351f5d82c570"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("13dd0b81-3be4-44c7-80a0-1a9c5e83b7d2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("15cf7bb7-c004-4d5e-95d2-e4b6da5f104c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("176551ea-0f3e-4373-af50-45102054f848"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1a71bd53-6405-4c08-9a26-76b6e54c42ac"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1a9cab7f-ead4-4d8d-a309-770ed77fc6b3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1b08864e-9426-4eb5-94de-a134dbdf3cde"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1ca15654-0f1b-4d0c-8fa7-be1666f13c7a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1d10bd3a-3692-457e-ae69-db3fc6328d84"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1d714ff9-6ac8-4e45-8e46-f2e630f894f0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1d90ecaf-582e-4ec9-b6b3-c428ef94b84f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1e46e495-2609-49f8-9c55-9e5da7836847"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1e70c308-9413-4b3c-83ba-39e3c9236d9d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("1edfa52b-55dc-4362-8d61-37bcde3e658c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("210000d7-a29f-43a0-bbb3-ea8e4cc60b42"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("210e2bf9-fe42-493d-a9fc-e87cb26676b9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("219056e9-9ac3-4a0d-86ec-46c753c0cf30"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("21b2502c-ec36-421b-8e04-45209a9e8d52"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("237a55fe-f1ff-451b-95fb-3b462cc7219c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("24b91988-4cf5-48b9-8725-888249a59ccf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("25b3d284-b3bd-4f85-8bb3-fc3770f1ec3d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("25c8309a-c756-46e8-a9ec-5c141c34271d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("25d05ee9-0407-4eea-b6cf-b0fd336d95cc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2627f4aa-a7ab-4843-94e4-6d4c4a1bb5a9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2689bb4f-e5d0-4096-9658-f53376185096"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("26fba82d-7547-4195-9a3f-cf6d75e5a122"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("27e75b95-b15b-4317-b377-f2582000f7d1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("28c75724-34b0-4580-8ad5-6ed182a3aac0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2a98cb79-e114-4041-9f6e-6ce3194c861f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2b0208af-74d7-4170-a4d4-883234a9e873"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2bf82349-9edb-4081-8526-058f096eaad7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2c8ac92e-282b-460c-bcda-1aa348c6f437"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2e52d8e1-dc4f-4415-918a-77aaaa2728af"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2ec62998-b689-4c22-90a3-00c7a3e43fdd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("2f43a785-3c63-4cc4-8272-be1c4439e2be"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("308745ad-e753-444f-8744-386c15f3d704"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("31040dfb-6f2b-4aed-b769-89d16cc3c723"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("32e6774c-781e-4b52-b9eb-fc07b61995ac"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("335db9b8-8a8d-431f-879c-ea2fccaddfd6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("34613b51-a17e-473c-ae52-f28775d4853a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("34a91929-e8da-42a8-9b1d-c96014256c26"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("37b7bc04-003c-4153-8ea5-de7ce93e3df3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("37ef98e9-6a74-49b9-a3b5-f702c4217eb9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3812787a-d420-4dda-9979-3671a586ad73"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("39abf65a-5bec-41ba-ac39-635b7fc58a4c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3a7cd74c-0247-4a06-a0df-588472be1982"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3aeebdf9-71e1-4667-8ae5-006204e464e0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3baf1781-0e0a-4681-8e51-899e3500cb56"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3c6c696a-68ec-4b32-916c-84b4df00a291"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3df3e24f-009a-4ff0-8b93-ba6fc2d58354"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3e311109-d9fb-463d-9194-d54f5c577c42"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3e996a33-efc7-444c-b7d4-f1e67a54de9f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("3fb28c4d-30da-44f0-b106-2e974eb32e06"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4214bd20-f4dc-42f0-81cb-e739a21e8839"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("42980cac-92ca-4ec3-a846-e97000c830a8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4347efcf-de62-4613-ba88-1357d74362ce"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4406437b-458d-4efd-bafe-f1ecb579f6e6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("45ee73db-60a6-4f12-bdd3-90ca746b81bc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("461b5722-9a13-4392-bdeb-4bc21b08dc94"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("473a84a1-ba28-49b7-af8b-9bcd66a14f03"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("476f3aa4-08b9-442e-a04f-bb595906a26c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4773adf4-37a7-45d7-8463-5c4b0ce12052"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4830577f-0bfc-4d08-b675-06237677fbf5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("487a74c6-5076-4d85-85cb-9c625755d6a1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4890a52b-9710-46d4-8460-0040204f8584"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("49823ee9-23f1-4035-b4a7-7984da1a182b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4a0fefde-6945-4f64-805e-c21377e42983"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4a18b0cb-5644-4c6f-8c87-71acb2401252"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4a2ecad7-216a-41f1-9d37-70542e5651d7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4a78e63a-f83b-4dc0-9a29-a55fe88db6c8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4adc46a3-81c6-4c4c-b52f-aeeb18da11c4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4ae19276-330a-45f9-a387-d0dc2f3d1098"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4bb844f0-8919-4cad-a67d-2978ae7796eb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4c850e4d-08f8-4b21-b2b0-3e437f2fc5a6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4d161847-6bc8-45c5-acc7-bdfb53034e37"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4dc8deca-a956-4268-8aca-248d142b5768"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4ec54a04-420c-4496-99ce-e063adf8dfd9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4f70223a-1362-4fb6-9d66-5f0bea95bf42"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("4fa2978a-1a1e-4605-aa3b-2003793ea056"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("501a348a-bac9-48a0-9dc3-7fa3d4aed573"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5126bd02-beaa-4466-bfe2-7b0235d1c987"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("513f1f6a-8b63-44df-b01a-67c8b215f4b4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("528c8d64-fc47-494b-b754-d1b547a5132e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("52d5094b-e96c-4f27-8768-25a2c88db6e5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("53c735d2-63f6-4c31-96f4-d72e01930cff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5455bbf2-ed79-490e-ace1-6068cc80d5bb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("56d7db42-5b45-49c9-b50e-1907e12cceb2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("592b1d39-72e5-4abf-96fe-2a89e417ee95"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("593a93e4-75d9-4862-a522-43c640a2fe76"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5952e695-30f7-44c3-a9a6-e9f1cf918c35"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("599ef4e1-c07c-4018-b01f-f4d9f134d3b6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5aaebbd7-a378-4d1e-a85b-4e2dce4096dc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5abb8705-71d8-45a0-a4c9-435fbca1e8ac"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5b0ee327-fd0c-48ef-8e27-9c7f8d65388a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5b12d377-892a-4f4c-96c6-04f194366292"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5c1bb508-18f1-4035-a633-d00f8dfbae11"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5ce61ed7-45af-4529-bb12-165f4a2073ab"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5dd23ec7-ab9b-4e5e-a550-a6645302264c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("5f760528-b0bc-475f-8fdc-3f383c3b5fdb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("605a13a9-d0f8-4877-8aab-aa3a47db9d88"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6199d27c-bd5a-4461-ae12-840e199700a5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("61b98065-2955-4bf7-a83e-c3b9fb5bc60b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("61d6a7ed-dedc-4f72-beff-731669fa93b8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("62db4c09-b8bc-4dcb-b996-8f1d83b52e0d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("633bd56a-102d-4ae6-bf11-c63bce1dcc6f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("63c6dbd3-6729-4d15-9dd1-0ffd59d112dd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("64de9040-8ff0-4c98-b4be-8489a995acde"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("67c378f0-a64e-42b2-b7fa-1a81d4b6d334"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("67ffb250-ebb4-4121-b00b-fd9323d957be"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("689921ad-6ffa-494a-aeb4-3a15b6f07bd2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6955e8aa-ddf1-41d1-97df-be4377567ab7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6963cdb2-8a33-43ae-a31e-d6a5be1860a5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("69bd2a06-4629-4278-8dd9-a1bd0fe1cb41"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("69f182f8-a9dd-4156-89c1-7321a7d01cf4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6acbea85-4ad4-40f4-a1b3-22ad41514506"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6b6a6bf8-c002-4403-9fe4-5267a64c6e0c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6c4b3874-e7d4-4b64-a70b-61b82bc5cf78"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6da08819-3095-4f80-a2ea-47d07c17404e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6f05bacc-a0f3-47e5-90b4-ee4aa9dce7ca"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6f3aa9b4-a604-473c-a45b-0e61e552f440"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("6f5699b7-d71f-4789-bc72-2b2ffa22a87d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("70576e6c-b04a-4d96-8fb2-de8f811dac77"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("70cb9105-9e78-4042-a042-d048ffa962c3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("719e572e-c234-43f4-8535-0a7d7d398c0b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7216352c-28c1-41e8-9927-ca3c803ee1c7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("72cbba9d-5619-4133-8f4d-14f39c61c2bb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7329f611-b795-4883-8f01-ce8020d9532f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7365b4ba-b9e2-4056-83db-6ea686280e61"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("73b4a4d0-3c0f-4973-ba32-10ff3114a7e5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("751ca491-61f0-46f3-a3dc-f9e3ffc9f698"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7617ff4e-3f7b-4180-b0d2-695da9325188"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("77004b73-d82b-4ee4-a718-fea8ea0e0b01"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7735c90e-b924-4ee8-a2f1-702f9cf687c6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("783ee74d-6989-4458-9bdf-d63be40dabdf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("79f7e0c0-7c70-4efa-8ca7-079fe0a81f6a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ad8f6d9-fb07-4e67-ad3b-79452cd05929"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ae4ff81-9f55-484a-9006-e0b061103b36"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7c7c456f-3e32-498c-abe2-498d498fba28"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7d532491-7f77-48c7-b0ac-877c1b03f7af"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7d758702-aed0-4153-be6c-96c0a0f2b2fa"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7e1b9580-2988-405e-84a0-e3aa9ef45a7b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7e3d4a1c-17bb-416c-8a08-2146237b5b2e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7e87a490-46da-4ac5-b3e0-aaecc706cd46"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ebb9f87-9d5d-4140-a42b-e2b511773391"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("7ef743ef-e3a4-4709-baa1-0c977d3aa4d3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8024299f-c294-42fd-9dbb-1aa1ca4642e3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8116c9e3-bb97-44cf-8db8-8ec4ca849304"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("820c02e1-89ed-49e4-8979-c55221a8aa2b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("825a38bb-473e-445f-8509-c32a9e4c4384"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("83dfb938-a6ef-4730-b5fa-faee11b28ca4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8624a03e-f686-4daa-8cb9-f51edd979e68"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("863fbdfb-df6e-4779-b751-0b2dd0e70b16"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("86522362-bd7c-4be7-a9bf-8a1ea10e9d59"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("86a31853-5037-4179-af08-eec826605104"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("872f6665-e885-4af8-83ae-421f20a9750b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("887e95df-4cda-42c3-86ec-a78af86cdb9f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("88c66f56-5ce8-42c4-8645-0611c2bc9540"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("89234de7-3d41-434f-a0f5-dd0429a17754"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8986c356-6a21-4137-be9c-ca2bc860abcc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("89c384b3-563e-4778-8bee-b4822c16c37a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8a084256-fb9c-4ad0-9734-2a05ba80fa83"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8a5ada02-3941-4591-b709-d11d2559bda3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8b2f216f-91d7-46c9-a489-38fb8d41a978"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8d04545a-2469-41a8-9fda-0ef95e0ae9b4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8e17dcb9-427c-4659-b532-19e05d2e80d1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8e3c879c-a1af-4e32-8003-ea2eadf7359b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("8e62beaa-c819-426d-a34a-fa4cd60762b8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("915e43e4-0597-4955-b85e-06abb4d9e92c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("92074d82-1a34-490f-aecb-085ded07f998"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9323a6a5-2228-48d2-930a-b3000be6dbff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("932ff914-bfb1-4f70-983e-9229bab71a9b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("94fd96d5-8d5d-4c16-b799-8cff310a307e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("95c6005c-8910-4529-a5b4-1fa913d9f359"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("95e9f374-4ff5-4286-b67a-0db776ebaa6c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("96921d63-a01a-4604-96f2-f3bfb8295041"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("977903cd-f337-43ae-9d9c-eb085f5ebe83"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9933011b-b5c2-499f-8ba0-8bc966d70aea"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("99556ecc-0ca7-457f-a7b7-fe471b82e7db"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9991fbef-92a1-4e02-82a5-06f31530b9b4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("99c4eec3-647a-4849-b0c9-b388e963657f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9a7d12f1-c3af-40a0-8b43-377e50ffe237"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9ca33208-b0e3-466f-af32-7ecbf9709b0f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9cf55210-0124-419e-bcd7-38c045ebe6c2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9d8d8dd0-389f-40c5-992c-7195780dc999"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9d8dcbaf-69be-4da3-a453-42ed3f5fb668"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9e570c6f-f8b4-4e41-b0f1-f9aa3e7b1138"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9eac13d1-6e3d-4ebf-8b85-713a5d301141"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("9f5db3cb-a824-451b-b21f-7d58778b7434"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a01702d3-5b62-46e9-8130-e2db70cac86b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a075b800-0b49-4d4f-9d12-ed160120acee"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a09f4025-415c-4483-a3b7-bd525f502bd8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a0fe56de-2309-429a-967e-68e2792645a0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a10cf97e-e013-4086-8f1c-8d56e2cc1114"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a133cc50-5b0f-4944-82cb-1bea0f8a1e3c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a20bd69e-e2a5-439b-88e9-a62a7e791dcb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a2bd647f-8a30-46f1-b5e8-0a72cfa67aa7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a3d095fe-6fb5-43fd-9f5b-b5727fbc60d2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a513cc12-d9db-45ad-b914-0f4ebbffca8f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a5d3c522-665e-43cc-b37e-ee5e79734160"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a65c3900-0e0d-41bb-9dcf-77d8c99a2794"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a73824ae-6db8-4042-95a1-0ccc63f56c56"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a838a0d3-f002-42bc-9fd4-d39cd9bc51df"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a926e9b3-89b0-4ac1-b0c1-d9228b48eebb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a9492846-29ea-4dc6-806f-bd998ee9b702"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a9848edb-5863-4655-aa27-7902ac70d8b4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("a991d457-aa08-4b01-9306-f8cc5b280307"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("abca79b9-ccd0-40be-8329-846f31482b40"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ac4dfe32-2bdf-4c50-9cec-52e957b16f0e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ae403e09-722b-41da-b71c-b531a322acb5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("af40b82b-523f-4b54-a651-040edd7581fc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b0ec6541-c09b-461a-9e50-6dd2065ac66f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b13d6a1d-b034-4d1f-88df-bb3ab8861d8f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b17222ba-40a1-4f4f-a87a-cc132a9cef3b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b199b687-7dd6-4655-acb9-1905e2f51a64"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b29f4688-72e9-41e8-a33c-1289669dd620"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b4575982-a8ee-43ce-a600-9a34189a9fb2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b664f104-4aec-472b-90da-a233fd1bd1e9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b6d0383e-9d06-4746-adb7-deed0c3d8629"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b805f934-849c-47ca-a19c-c2c4e8953387"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b833ea39-276c-4f1f-87d6-d01ae24d3134"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b87d95e4-7b07-4eeb-9ec1-73402205ef24"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b8b9a9b6-7c84-4da1-aaee-d0fd374ddbec"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b9523fb7-eb88-4e7c-a983-fee86e1422fb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b975a2cc-6e47-46a5-8e6d-2f450cab6aa8"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("b99c3c65-cf05-4fd6-9d07-25ac13898386"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bae6cded-7c26-423f-87d0-de1292f034fa"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bb3cd052-4756-4da5-80e1-da407c4518e0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bc6b5912-0565-4472-a046-23c7987fba97"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bd8ab484-bc09-4479-a03d-39e7003f461e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("bdab3327-0b0b-4b43-a7d0-4186e45c1ee3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("beeecfac-aef8-43f8-93ae-5bf1681ab1e4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c02e41cc-765b-4a13-adf8-8eae1450aca2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c08042a9-88d7-4aeb-9d40-900f7cad4cde"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c0e0c3bc-dbb4-4b5c-a151-c46612303990"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c13e70f7-5533-4ea2-917c-b764239a90ff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c15a319d-3d6f-48be-b1bf-5362fbaba5b1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c179dee4-f48b-4965-9213-b39bc7d8937b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c2006e16-3324-4246-be2b-dd165c685585"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c246a8df-6656-418a-90e7-47160c1c4f2b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c2a8561b-a1ff-4cd8-ada2-ecc4bab4fdc2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c3da5dff-a0c4-47c8-9def-101137b01ca7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c3e7f1bb-a3f2-4b37-acf6-d1a5315f1932"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c409d2d1-7888-4984-aa18-29b759bcf3d1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c44369f4-f262-4e55-82d5-e3d3b5c9b558"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c88190bc-1ada-41e4-88cd-bfe0621d06e2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c92e037b-5d96-4b62-b76c-6155303c072f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c93f1a95-e6d3-4bd4-bfbf-120050f4cc36"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("c9fb2e15-08c6-4d0e-947a-dbbc55a90ff4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cad5db0a-bf99-42dc-af48-30403896a760"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cb113458-7f70-48de-a350-b9d9de0741d4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cb488431-d00f-42e8-8d98-96377114d38a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cc47d6dd-b8fc-4555-a75a-740468260e8f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cc4c320c-aa07-4762-9b46-c4699452332d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ccf0a5da-59d4-41da-8f57-367d6f56b6c3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cd2ad91d-a58c-437e-bd2f-82165f1af8a9"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cdb96252-6202-4bb8-8f30-6594257bdf6c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cdbd554c-6bea-4b3e-8f8c-776c99a652cd"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cf549ed9-5184-4d1b-8c32-2c648670b3cf"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cf9c763f-474a-473c-abf8-837b78166eee"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("cff84efe-bb0b-408f-8fd4-bc0f4d88d2ba"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d0ddb19a-f3a4-4d29-b5fb-075e22d41a8a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d216f01b-017f-485c-8a89-eef23bf236e4"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d4547df4-af59-4976-acbd-9baf1bf21aab"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d4c20113-2bfc-42e0-8810-80266e41744e"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d59b2bf9-6eaf-46bc-8c06-b0a48d93de31"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d5d5bf16-4489-4d08-bfff-b9e0eb1badff"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d608152a-5a3f-4603-afcd-33b94a9f0559"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d8148643-4aae-42e0-84d9-69b55ed66c6c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d820c5eb-3417-453a-9792-a56e212f7d48"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d8b4512b-6b0f-4e78-aa8b-ba2b89cff0ca"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d96f8940-83cc-466e-87c8-d3d558b04a6d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d9870723-18a5-4904-b75a-93275587abf5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("d9fa9373-2c3e-4e58-a8bb-01c727002a9c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("da69ef6e-c6f4-4f7e-89e3-54c77a9d9859"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("da6abcc4-202f-4a35-acdf-b48703648070"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dabfeb84-5cf2-45f7-ab82-c16943c51e12"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dbcac770-57a8-4e1f-9272-d8bcd0a94284"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("dcfa8046-8243-4e40-8601-bf0b95470a2d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("de1e7cbb-9893-4ca4-bc61-86d3733b18a3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("de60759c-cc3e-4128-98af-afaa8c47e36a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("df46a9f5-ca4f-4d48-9526-fc54b6f17bb7"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e386dcb7-bf42-4028-8483-34676ed6e613"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e439a59a-6a12-46f1-bad4-542a9ea5b12a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e4c497b1-d0bc-4fca-a820-5ab4df318b09"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e4dd0d3d-6114-49be-9668-b2d8a7ad944c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e4dd879e-d080-47a3-bc39-7f95db9eb7f5"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e521973e-f24a-42c1-aa3e-1c6542601c31"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e63a52c1-fec9-4a9d-9225-f36b7ef8ef90"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e65d1d2b-8287-4ec6-b707-b2d82d89cc64"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e666cb6a-ac08-4d7d-8380-3ab3564dbe96"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e67f6308-e9e7-4010-b2ca-3bb1922f86a2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e90b273d-94a2-4dbf-9351-39a7c8fe2925"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("e9e1c11e-e478-49c4-a2b5-5836cb3688f3"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ea518c3d-1e0c-4880-83ee-3746e58e2579"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ea567571-78ce-4d55-b8c0-5dd6b10c5ae6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ea6c9917-aafc-4fa6-a9f6-486596ea8895"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ebae12f8-5b84-4c0e-8b77-cc3bf5fc8d78"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ed3428a1-9f3a-473a-bde6-ebd57d1ea324"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ef1dfc36-2309-45e7-b829-8c3a07272744"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ef5f9d17-003f-4349-bc39-ef9b658965c1"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f00ef0eb-c3a2-4ba2-b64d-3b1e03f5cb26"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f0ba594a-ecf6-42f7-b8f6-132041008f7a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f11b690a-7e8a-4776-bf14-b2ab7898a269"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f17c4831-08e3-41b7-ac84-87227ff481ac"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f1ed77db-7805-4811-af79-b54635751ddb"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f20aa949-350e-40d9-9a66-d0195a4c5f3d"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f24bb9e8-7c5a-44fd-b0ae-0873ee90bb65"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f25e2925-21f1-4919-b87f-d69092ce7219"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f2e50637-6307-42ef-85d8-2623faeb6c31"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f465623a-a1ff-4936-956f-331302ef4bb0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f57e84ec-e979-40d1-a549-89ce1b80bb97"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f7169ac6-cfe0-451c-9847-8324ed38a4d6"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f730c165-aa54-4eb9-8bc0-7e0d9eaac983"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f7cf1b7e-f3d1-4a15-baf9-ec7663d52782"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f7f4a376-9603-42e5-8442-cabb1c97bc3c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f8a46201-49f2-4dc6-8b31-9791699e4bee"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f8ac0d99-21f6-4fb2-ba3a-2bef2fd3b18b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f8c579e1-d823-49fd-9ebd-48af46cd3f8c"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("f9227f5c-6e9a-4209-a8cd-ae6b2253baef"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fa66f7f9-6456-488c-b616-d264147a3c1b"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fabe5032-a609-4d8c-bd1e-e9123b363eb2"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fb9ee2f8-d6eb-46a3-bbda-9a2af6e1004a"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fbd6a2d5-f7e6-49b9-bb86-c352c16db2cc"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("fe100b54-fb34-4a67-a22d-c5c97527c19f"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("feb757b7-5bd5-46be-a5d8-75441fdb57a0"));

            migrationBuilder.DeleteData(
                table: "bookingDates",
                keyColumn: "Id",
                keyValue: new Guid("ff4165a6-e8af-4796-a0ce-513f72e92f5b"));

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HotelId = table.Column<int>(type: "int", nullable: false),
                    RoomId = table.Column<int>(type: "int", nullable: false),
                    Checkin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Checkout = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreditCard_Num = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    totalPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "AppUserId");
                    table.ForeignKey(
                        name: "FK_Bookings_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Bookings_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4e48f5c1-e446-4192-8b3c-f666b815d41a", "806c0124-45d6-485f-86db-9af180b88609" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "33c144d3-0e84-4d45-8b66-dfdfc9b66e3f", "d3a589f4-6e5e-45b5-8e34-ba8a3962a5ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22",
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "29ff8a6f-0e77-49dd-a792-97415b9c68bf", "cab98b38-11cf-4a76-8cc4-6f3eb0793fe8" });

            migrationBuilder.InsertData(
                table: "bookingDates",
                columns: new[] { "Id", "Date" },
                values: new object[,]
                {
                    { new Guid("018763d6-a0c3-4974-80ca-b5006aa7990d"), new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("01c42ba7-857a-4800-92f3-fe738c7afa93"), new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03edf409-2c52-4e79-9a87-54a23e8563ef"), new DateTime(2023, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("04418be2-cbfb-43dc-8e3b-3402d5416d84"), new DateTime(2023, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("047c7ed4-f8dd-41a9-9661-bc6229dffc39"), new DateTime(2023, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0553e669-9c83-4add-a752-13011b0e9603"), new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("055efb4c-8fa9-40b7-ad7f-ec218227e7f3"), new DateTime(2023, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0583f5f7-9c09-4b43-a9d5-dce1c43aa0d0"), new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0661a3df-6511-4ff5-84c9-3ced883aa872"), new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("07c5bec2-4de2-4eb0-b105-95681eb17a4e"), new DateTime(2023, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("092717d0-cd48-477d-966c-eabc1fa4174d"), new DateTime(2023, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("093d5ff6-9129-4501-9b0f-790a1f43e288"), new DateTime(2023, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09a53396-88b2-46c2-8ad5-1f015b677c80"), new DateTime(2023, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0a2c9958-2167-42ed-8689-d109e087e7c7"), new DateTime(2023, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ac178c9-85c9-4858-8272-bc56ff4fd6b9"), new DateTime(2023, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0af07cbe-e1b0-45b9-a01c-0ce9d153fd9f"), new DateTime(2023, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c324319-1d67-4ab9-bd63-928ca9b647f0"), new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c6fb0f7-248b-458e-ada1-b24190fa11f6"), new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d2d4720-8b9a-4064-a131-5da9e6bef3f2"), new DateTime(2023, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0dfaf0ca-c0c0-4d03-8150-60c342ecde5c"), new DateTime(2023, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e19d310-55b8-49f9-9523-6b7a65dd6761"), new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f2bdc38-3603-4455-be77-b32e7a337297"), new DateTime(2023, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f7259b7-c68f-402d-9b32-29973b705a45"), new DateTime(2023, 3, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1125afea-dbfe-4c4e-9d46-8963bcaac290"), new DateTime(2023, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1281ef69-f11b-42c4-bc06-09782a0ce2d0"), new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("131f6ffb-8225-4bd1-b09e-045194e4d4df"), new DateTime(2023, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1417c3db-c920-4514-b5b6-609faa3e8acf"), new DateTime(2023, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("155a5f43-5c63-4852-8675-8df4b5ea04e9"), new DateTime(2023, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1573813c-43a9-4cb5-8368-79cdf93d73b1"), new DateTime(2023, 12, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("15ee8c15-f5ba-4baa-8b1e-775b8494ee06"), new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16353d35-78ec-49e0-9029-98f6b95f7b7d"), new DateTime(2023, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("16dc7053-45b8-46ff-a0e1-43d8f51c1474"), new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17ff8a48-8694-4707-9345-571be68b8288"), new DateTime(2023, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("18f4c18f-d5c8-41f8-b52f-0150c5f2774a"), new DateTime(2023, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("195a48a1-bf53-4b39-a928-e9b2af7ace7b"), new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("197c5436-89e3-4089-bfe5-843579a957c0"), new DateTime(2023, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a4f4b49-cff3-49c1-b68f-2e61baad2a6f"), new DateTime(2023, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b428ba7-6c1d-4bba-af3e-54ae3b67ed51"), new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b9d8a39-0897-43b2-8778-06edf614e678"), new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1bbc7707-415b-402d-8b8b-d842a3c1a631"), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c4a09a6-1f35-4e01-889d-ba9e4ffad4c9"), new DateTime(2023, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1c7bd806-5637-4931-9a7e-217505d20832"), new DateTime(2023, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d3ca668-c9a2-4ed2-bea5-91b2f6d4a52e"), new DateTime(2023, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d3ddb0e-ddf5-449a-94f1-500ea3c2a045"), new DateTime(2023, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1dcdaee1-53bd-4797-9e43-6bb425bdb2fa"), new DateTime(2023, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e3443ed-7a4f-4fc8-a67b-0353dc1ec5b7"), new DateTime(2023, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f9acadb-72d4-4cf1-85a1-6dafe9ffbdff"), new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f9dae5d-3b6b-4aac-9c90-bf57427e1efc"), new DateTime(2023, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("208db32a-8ae3-4083-80cf-7f6620094561"), new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20ef1ed8-8933-42e9-9f41-2f1c66319d36"), new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21082e12-3825-44b6-b39c-1ea06e0de3fe"), new DateTime(2023, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21cf2174-e379-4933-b647-b9f8a95b960e"), new DateTime(2023, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21eb2d15-34a9-4644-b29d-74de8787b88c"), new DateTime(2023, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("21f6b633-1a9b-47ac-a1da-aadbbad17e98"), new DateTime(2023, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("220dbe40-1fb9-42cf-8728-d103bf6f451c"), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22233a6f-3cdc-4bf7-a9de-af757025ca12"), new DateTime(2023, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24d38da3-fe1b-4035-a985-0ca06e52fefc"), new DateTime(2023, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("24e0a5d3-af33-46ae-bd3d-9c0c180857c2"), new DateTime(2023, 12, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25314ade-d92d-4225-8e94-1b4663c51069"), new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26adf7bf-32bb-4951-b215-214702f95cf3"), new DateTime(2023, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("26fb115b-9891-45b4-92b1-6f213ddddb65"), new DateTime(2023, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("27254c9e-b341-4e28-9c4b-b8882c4e2e8a"), new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("287c8e9f-d5f6-4402-931a-9f840eb21d8e"), new DateTime(2023, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28d7fc77-e165-45c1-aaeb-12cc6f2ef060"), new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2974465b-7f8e-4580-a1ab-96ecdcf8e8bc"), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("29781485-99a2-4652-a54a-11c0082d2ada"), new DateTime(2023, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b618026-9b2a-4a22-81fa-0b082bee2727"), new DateTime(2023, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2c831a1b-1168-46d6-bb4b-a1eae026e1a0"), new DateTime(2023, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d6eea64-1e3d-40d2-a5d7-1df69abbeeb4"), new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d845c3f-237c-4b2f-b129-02b200d6bbea"), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2f8e18ec-369f-4037-a8d8-40b7c4dcb6be"), new DateTime(2023, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("30ec986c-1c12-4dfb-97a6-e920abfb34ed"), new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3166a767-0b7f-499a-804d-13cc8bc40c9c"), new DateTime(2023, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32ca1304-95b5-422c-a3b0-e005480596cf"), new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3319bcf8-c428-4486-a7f4-bc1191fe8268"), new DateTime(2023, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("331c2f22-d9c9-4cb6-b8c8-313607a34005"), new DateTime(2023, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33790ea8-3d64-4146-af13-49f0bcf5f45a"), new DateTime(2023, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("363f28f3-de05-4161-9f81-b67ee77257ba"), new DateTime(2023, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36b66e3c-464f-49f1-9c8e-34e86c6dba2a"), new DateTime(2023, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("37099bff-e5f4-45cf-a841-891c4c487ead"), new DateTime(2023, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("39407e5c-41aa-4522-aaf0-d36f787d1eb0"), new DateTime(2023, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a254c1f-df84-44fc-b79a-a738e3381a52"), new DateTime(2023, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3d44c9e7-9504-4306-a30d-f3b6f0801a75"), new DateTime(2023, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3daad659-4bed-4ae2-bcbb-6073f4187d6e"), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3db98f8c-fc1e-4a68-8bca-15ee2b37f185"), new DateTime(2023, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4050fb09-c7a9-4988-91f4-29246ce2c5b7"), new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40ad2c09-b74d-4512-965d-f00255e1094e"), new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("430b2853-0ee8-44da-ab65-c2ee4e24b41e"), new DateTime(2023, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("434149d2-8f5a-46fe-be60-80b80042fcef"), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4379f6bd-9c7b-46f6-aee9-c9ac7bfeaa6e"), new DateTime(2023, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("44da80b6-3c4d-4568-acfa-6411ca1e548a"), new DateTime(2023, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45f3fd97-04eb-47bc-a514-b9285f747422"), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46572486-1c7c-44ca-a142-a0f6b5b45101"), new DateTime(2023, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("46f97d7e-2fc1-43e6-a6ce-da9f3827f746"), new DateTime(2023, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49213f67-56c1-4c8d-bdf5-91b189a5832a"), new DateTime(2023, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("499f8e6b-0f7a-43b1-88cf-65b057509382"), new DateTime(2023, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c00dc9c-96fa-43ab-91bf-5e1c46023fd7"), new DateTime(2023, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c78c19d-844e-408f-be70-d9548b6cc970"), new DateTime(2023, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cb3c551-dc24-44d5-814b-6b14961d3b1a"), new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4deb5910-5b75-4e94-9c35-cb99da0bc998"), new DateTime(2023, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("508838e1-d497-47a2-8e48-817ca5791a4f"), new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52a730f5-7c26-4ba5-8d31-1cf184ff3ad4"), new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52f69d13-7b4c-43bf-bd10-3863d694cada"), new DateTime(2023, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("537e7963-e8cf-4e22-99d9-c7f7facd4522"), new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("538d334f-4bc6-45b4-b3a2-8de69ba2c047"), new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53be6168-0e89-4e76-bcbc-d3ab140c1ea3"), new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5589fdf0-5a08-43a9-a54a-67c3c49f9a6e"), new DateTime(2023, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55fee01c-3345-4380-8eec-34578f40bc00"), new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("561f1d6a-06a2-45bd-a6e8-997f3cb29a77"), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56d69183-cd5e-4786-892a-bd99733db9f4"), new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56dfd5a7-e60f-4b9f-894c-09aba94a526f"), new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("576fa948-343a-4cb6-aab0-caddc3fd7661"), new DateTime(2023, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5795e9db-564c-42b2-9c86-cd6f1c85d3d3"), new DateTime(2023, 1, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58197086-109e-4cb1-a10b-de6271b30df6"), new DateTime(2023, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5846a7e6-459f-4f3b-abf5-15a750a6e876"), new DateTime(2023, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5b76eeda-ec08-430d-a3bd-4e851f02fe7c"), new DateTime(2023, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bf8d529-4efd-478d-8efb-1d1d6879a243"), new DateTime(2023, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c3d07fb-2dd5-408c-ad86-f4f6c83100af"), new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d2a164b-24e8-4b13-ad34-87d4707fb3bc"), new DateTime(2023, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d3be95d-79d0-4d96-8c50-5953da5aeb23"), new DateTime(2023, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d661e12-88c3-464d-af77-cbc6ccf7bc11"), new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f16aafe-cdcf-4d45-801b-c3036446d8fc"), new DateTime(2023, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f25a6be-5a15-47c9-b54a-8b7ce86c20b6"), new DateTime(2023, 3, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5fee3472-e2d1-4c8e-9a4b-66e2d2a1e527"), new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60191e76-34f2-489d-a200-9f01919472f1"), new DateTime(2023, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("609b4c14-b52b-4bfd-97af-9b29c2f2c4ec"), new DateTime(2023, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("60bd2c3c-1508-4fca-afb1-5b13a0214326"), new DateTime(2023, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61275e4b-7669-453a-9420-24e149801348"), new DateTime(2023, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62405e83-d4aa-4383-ad28-f8c3d63d7b6f"), new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("625408e4-26dc-4b8d-9245-fa927c66f550"), new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("626c1cdc-a68c-4777-9550-c9cd077aa5ab"), new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62b39db1-bfbe-4acf-8493-89b3ecde4f60"), new DateTime(2023, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("62f71e25-1df1-4505-9df8-5d91cb613e4e"), new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63809a20-e4f3-49b4-adb1-ca967560403f"), new DateTime(2023, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("642e5e1e-dc8f-45ae-acc8-9227a3fdf362"), new DateTime(2023, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("64eac7cd-f66f-4918-bec5-d7ec36d05268"), new DateTime(2023, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("678efd34-3c0e-4f24-bce8-809ef94b05af"), new DateTime(2023, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("68b8f360-cbb1-4301-a18d-f03dda955384"), new DateTime(2023, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6a56df46-2dc8-45c2-a3b1-585300acfe20"), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b133ee3-9e5b-408b-9e63-6ac05acc4657"), new DateTime(2023, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6c141aa5-d8f3-4011-9cc8-b0cccb72ac24"), new DateTime(2023, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d4c4f98-36d2-421d-ba5a-5ef9a049c10a"), new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6db04b7f-0738-4929-a720-cd88c2f3f20d"), new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e76bef6-c0c8-4762-abf4-bd89d60309d8"), new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ec7663e-96e5-44d0-9d6f-4bbea84aca9b"), new DateTime(2023, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6efb58ce-d44a-4413-9ab0-fc127cd14e2a"), new DateTime(2023, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f756ec9-9747-49a7-b0b2-40d032c47343"), new DateTime(2023, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6fa5cd3d-ed8a-4d5e-8ecd-33ae3e2d3a06"), new DateTime(2023, 9, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70086ab5-bc87-4335-9cad-ec433c1584c1"), new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71b43fb8-719a-477b-bdb3-254d500429d2"), new DateTime(2023, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("71f52b8c-b3ec-4cbf-9779-9ae4c0edb9d9"), new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7231ccd6-7680-4b49-83c3-9cc525fb8f1d"), new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7246b327-5bd9-48be-90bd-34d32cc331cc"), new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7262bbf4-467c-4b32-9803-ba6b11b2c562"), new DateTime(2023, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("72db6b90-adf8-46de-bdce-4294611697a9"), new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("735104d6-c35d-491c-9bd0-b60b7e462f26"), new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74ba2c18-531c-4700-abbc-078a6c57df87"), new DateTime(2023, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74ef9047-3521-43d9-867c-c347a2a8bbda"), new DateTime(2023, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75bbedf2-0572-4531-8e8e-747c123d47ff"), new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75ed77c7-37c6-469f-924b-f7f68e95cc32"), new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("765da799-0856-4c23-8077-80272ee02c6c"), new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76d46213-45b7-4103-bed1-1c2065158ce6"), new DateTime(2023, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7708a477-8902-411b-b095-ecc1c36dd667"), new DateTime(2023, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78880a2f-08f3-4074-a2e7-fc9c922510b5"), new DateTime(2023, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79b07574-1a49-4be7-af5b-5f7611f1010a"), new DateTime(2023, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a97b117-04ed-4122-b8d5-a40beda122e7"), new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bc632f3-652d-4000-9edf-c36da10ec64a"), new DateTime(2023, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d21c3e3-1e16-4179-9f0d-76a1e9ccbcfb"), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d2c3e18-2580-49bd-885e-966869bcf18d"), new DateTime(2023, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7d7c0cc3-5dd3-463f-9c1f-58590986d5d5"), new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7da830c5-5af2-4a04-ae5e-6be294f3a84c"), new DateTime(2023, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e4f6fa4-0b0f-47bb-a63d-73aedc031c46"), new DateTime(2023, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e715557-add8-4e11-a2d1-8f923bd02d4f"), new DateTime(2023, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ef9d728-37e4-468b-a18c-e841f6acba6d"), new DateTime(2023, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fabee22-2e4b-400c-9812-1f6b9590f15c"), new DateTime(2023, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fffca98-7d2d-474d-aa7b-dea38a6488fd"), new DateTime(2023, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8121180c-ca11-40a4-90bb-f1b3e476f679"), new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("817291db-5d92-4d5b-ba5f-1432246647c0"), new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8384f6fb-df8b-4da3-8fa6-b33e7eb5abc1"), new DateTime(2023, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("848ee1f8-c8c6-4c37-b063-184918f20f80"), new DateTime(2023, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84c22d61-2f56-423a-98cd-c0b7ade3089e"), new DateTime(2023, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("84f5405d-e56a-4b19-946f-d0da2cbef06a"), new DateTime(2023, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("852aa1f3-796c-43ff-b84a-75c2bb42b3b1"), new DateTime(2023, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85c9f013-b4e8-4a2d-8487-c7a02bbb09b9"), new DateTime(2023, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86cf6957-7b72-4f2a-b660-9008a43759c0"), new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("871d30dd-8929-4378-8d62-a0c8f916f371"), new DateTime(2023, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87a16f94-ceb5-412a-b579-df0308ebed8a"), new DateTime(2023, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("888d9d36-5fc2-47a2-bc0a-5d465c44d5d8"), new DateTime(2023, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88b98217-7e71-403b-8823-4b0a9c83c03a"), new DateTime(2023, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8af8187d-1270-4d72-8275-ddf55ff4f29a"), new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8bc08ed5-f465-4c33-907c-b2798f2d3387"), new DateTime(2023, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c00b998-762a-49fe-9fc7-7369e992a2f0"), new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c07b0e3-ada7-4173-a0e6-cf569acdbd34"), new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8c1de958-abdc-444c-a4ad-874c15018319"), new DateTime(2023, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8cde2bea-02da-432f-bf26-01115100031d"), new DateTime(2023, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e9dadc5-c3af-44fd-8d67-02db91a97189"), new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f6c3d55-97b4-40c6-a538-f395e14ed017"), new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8fc80f84-b6f9-4659-9be8-5d536da09f32"), new DateTime(2023, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("91c90555-04f1-4b1a-a2d0-67b7a0aba959"), new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9294eee7-4760-47a2-9e8b-9d8406b8f163"), new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92bba175-3481-4b66-a353-eb50f261d5b2"), new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9339fb72-fc2a-4171-a6a4-4346227c140e"), new DateTime(2023, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("944af941-3975-498b-b1a0-bd41e3666cf5"), new DateTime(2023, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94930418-2969-4e71-b596-939d2d28e455"), new DateTime(2023, 2, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94ba6435-fde8-43aa-a829-cde180b003ab"), new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("958eaf5f-3d79-4ccc-94b6-34eb65295d9e"), new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9591bf68-2cc5-4661-9515-98211cf503f6"), new DateTime(2023, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95a087d9-6637-40b7-b8b3-5320e45d3af7"), new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("96ed7e34-7d1e-438c-8df1-9dabe2744d42"), new DateTime(2023, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9706e013-7ffe-4ae1-8d86-1bbe870143cb"), new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9727243d-55d5-44b8-8fde-0fb934df983e"), new DateTime(2023, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98742728-3e74-496e-bb4c-ec9856282f47"), new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("995e66f7-cc99-4990-9370-9aa60fe39e9c"), new DateTime(2023, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b4a376d-8dc0-41c3-a0c6-373a4ca79ee3"), new DateTime(2023, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9b834f0f-e81d-42cc-8fe0-b00ef258969b"), new DateTime(2023, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9f1f8adf-4cf0-48f6-b5dc-a672bd3089aa"), new DateTime(2023, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fc2ffbf-e69c-4e79-88d6-17cad461a0da"), new DateTime(2023, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9fcdea42-fdb4-4000-93ec-f40b25282e40"), new DateTime(2023, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a10a79a3-d4a2-42fe-9619-73dd84364926"), new DateTime(2023, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1153efd-953a-413e-ae45-207c5b9d69dd"), new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a14867e0-756b-49da-a7cc-e7c19cda9130"), new DateTime(2023, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1d7ca80-817d-4209-8bfe-951bf10cd8bf"), new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2bcf29a-6af2-42dd-b76c-8a4f66f80c1d"), new DateTime(2023, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a2fbc399-5c29-4c16-b43e-a362ddd57912"), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a3ec965b-6334-4976-b30f-3d76830c2d94"), new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a49b380b-15ae-426c-81cc-d686728af36a"), new DateTime(2023, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4c38138-cff4-4d1d-b0c5-c1b0c9134c14"), new DateTime(2023, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a4efea34-701e-47a8-a3fb-a7b8a7eade69"), new DateTime(2023, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a617a35d-5d70-4ee2-8604-5b5120591e29"), new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a79ddb8a-86a2-485a-81d1-1db795d838bc"), new DateTime(2023, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a7dda783-cb6d-49bb-be2a-d7e6e4dadac8"), new DateTime(2023, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a82a3ca4-811f-4e64-8718-fc56fa4145da"), new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8eee6a5-634e-4c91-9b6a-e34dec66a553"), new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a92c76e1-4570-4455-81ff-a9402605748e"), new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a92e166f-781f-41c0-bf63-f4222c3cca27"), new DateTime(2023, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a99e1372-d6fa-4071-9a89-627e7a5d8da3"), new DateTime(2023, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ab34b2ad-c8b8-45c8-9848-4fc9e32df476"), new DateTime(2023, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac426a3a-3cca-4773-a5ef-e639aa9eed38"), new DateTime(2023, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac6f5a08-d61a-4765-9ec5-c78ab2125daf"), new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ace8037d-30e8-4cae-b024-23cbe7103780"), new DateTime(2023, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("adea959f-d004-4e95-b533-e8e8ac6dff33"), new DateTime(2023, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae2fdbec-c063-4698-a578-7df958310358"), new DateTime(2023, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae55fd8b-acc7-467a-9d9c-eafc201ed005"), new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae5b8ce9-1406-4a12-90de-8ff2f9ed7c86"), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae66bb12-49d7-4475-89ac-6a581c14c1c4"), new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af482c86-2600-4f4a-ab44-0064a6826c32"), new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af4e290e-6731-45da-acdd-14c91aa104ab"), new DateTime(2023, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2ab5979-fae2-4abd-9c9c-8ecef2f53864"), new DateTime(2023, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b43d0955-5ffd-415f-94d9-3c836948af75"), new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b682a899-0dbb-4a56-8cfa-d6c3b4bcaf5e"), new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6a1c1e8-eaf9-4733-ba75-1c0796bc0762"), new DateTime(2023, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b6da194a-6469-49af-95ba-c6c5f7bf184f"), new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b732152d-7aa7-4a53-a2c4-c66d551e7d03"), new DateTime(2023, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b75f7353-77f9-4508-83b8-7a93d78e20a0"), new DateTime(2023, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b7965f41-1789-4029-a607-459ba2093ef8"), new DateTime(2023, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b80200f7-0ace-4c44-89cf-fbc84abec2fb"), new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b877bb53-cdbe-4184-8f4a-aab192b0b685"), new DateTime(2023, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba56ecbd-ac4c-41ec-b5a7-92dbc3e4669d"), new DateTime(2023, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba79483a-7706-4c9a-bbea-9e21d4775247"), new DateTime(2023, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb4c49b9-fb39-444f-8515-98e21af452ef"), new DateTime(2023, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bb61e087-1d70-4188-bfbe-bc9060d87f47"), new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bbabab15-8a2a-4602-8e71-a76ed7824e6f"), new DateTime(2023, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd8d3b8b-fe2e-4114-a28c-6b5ee8aa9cd1"), new DateTime(2023, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bd949d02-721c-4e3d-acc6-0bba295b51be"), new DateTime(2023, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf3f8d09-97e1-4701-bbdf-ce54cb2d8ca6"), new DateTime(2023, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf5aa988-db8b-4640-a50e-fb22022c5688"), new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0162f1c-04d3-4401-a723-4bb2f119b733"), new DateTime(2023, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c05fb28d-3e2c-45fe-a6f6-68ad42e7b87e"), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0c33352-139b-4e84-bea2-56a090e9f8c1"), new DateTime(2023, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0e9f079-1662-47c4-86b6-be9a65b366c1"), new DateTime(2023, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0fc23ca-01ed-4b25-85c6-d3e23d03d857"), new DateTime(2023, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1386736-8392-4c7a-a36a-68d57e230bd5"), new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c17774d6-b55d-4a69-bc93-d9251ba237c4"), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2c10d4e-be00-4376-88c9-d46658662f08"), new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3a83d0d-5788-4b68-acdf-3772617fd4e7"), new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c481cef7-9230-4be7-9ee4-1e8c02ac9f71"), new DateTime(2023, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c5663f5f-97f3-4c92-a6fa-cf03ddfbe2db"), new DateTime(2023, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c66552a8-4c6c-43ed-82b7-54eddf5c2cd7"), new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c693b667-ba3d-4f60-bdb5-733dc3b7bba8"), new DateTime(2023, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c72e2145-29c7-48d9-af65-e4f5336c649d"), new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c79e0a2b-95b1-4c34-96c7-6ce58cc12563"), new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c87ef58b-186c-48e7-96e6-64cbf6e118a9"), new DateTime(2023, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c8c4ed67-57d0-4af6-8b70-a3f8b1aa68f9"), new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9bdfcba-6ec7-44bc-a53f-fe762ae95863"), new DateTime(2023, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca5e0e63-fcb2-43fd-9e0d-f9752ec5a917"), new DateTime(2023, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca9ae98c-db3d-4c77-97a7-9d2ec125ae68"), new DateTime(2023, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb8f6527-26a9-4970-bbd8-a68a17e393ec"), new DateTime(2023, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc65e2a3-fcba-4d58-b8b4-a4eb2075c271"), new DateTime(2023, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccb105c2-5aed-47d1-ad17-bffa1d5bd695"), new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ccf5cf97-08f6-49cb-807e-f619d4664cc1"), new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd9b5442-5312-40eb-a7c5-43aee42ed879"), new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce08ee93-36b5-4411-8a48-366929948aa5"), new DateTime(2023, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce0d930b-089f-459b-a586-0de52a552d23"), new DateTime(2023, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce580c2f-5b72-4456-9568-43b1bb714889"), new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce95f686-d40e-4bbc-9b37-8149d588f30a"), new DateTime(2023, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf9fe5ed-cdc2-405b-966b-278aff8aed54"), new DateTime(2023, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d03edb1f-2991-4f8f-9744-c9b15b655d8c"), new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d068d4cf-8d33-43bc-b918-0e660f0b3725"), new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d13268c2-6393-4dfe-8e5f-7ecc4d1c90ff"), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d317fad2-2394-4efc-92fa-73575caf8b33"), new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d339b214-43e9-4f6d-94d4-580165104097"), new DateTime(2023, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d33ba703-4c34-45e2-8668-d2bf14fca413"), new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d46debbd-c05d-4b5f-8b35-6c9236cab96a"), new DateTime(2023, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4ab3562-0723-4d7b-b859-e783e4a889e3"), new DateTime(2023, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d551c73b-6a8c-4504-b0a8-591ce8e3c758"), new DateTime(2023, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d56d61c6-6fe8-4457-920b-9fbb812dd3c0"), new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d68d59d6-aaa7-495d-9219-592773ce8de7"), new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6bedd92-9c76-441d-84f5-0084e03c99a5"), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d764ac80-3e1d-4c56-8d16-25971baf0a52"), new DateTime(2023, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8834da2-537c-46fc-aedb-b72366b8d00a"), new DateTime(2023, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da37233b-7995-4ba8-b81f-ab8bb0bc5a5d"), new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("da4c707f-7ffc-46b7-bb0f-20a012a2c074"), new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dac7aa03-18d7-44ab-8322-3f4432e9686b"), new DateTime(2023, 8, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db316458-4cc1-405b-ad57-d49903c1e5fa"), new DateTime(2023, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("db821ff2-aa2d-4724-93a2-6dffa5ffb761"), new DateTime(2023, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dc469248-8c25-48e4-9d97-a0401d1cf3ba"), new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df72ddcb-0c39-4d6e-ba9f-4379069bdb7e"), new DateTime(2023, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dff03e92-8fa8-4f91-8955-75db0f8d09a0"), new DateTime(2023, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e005a686-e68f-46ad-81d9-fdb29e32f8bb"), new DateTime(2023, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e14a66b7-9f89-4c0e-a405-9ee729c3883c"), new DateTime(2023, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e176287e-03f6-4247-a14b-dad789a48527"), new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1bc925a-a465-4dbe-84c0-9496117a7be8"), new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e21ea55a-a7e6-4e49-8cff-5215651f6674"), new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e27f8e38-4cf9-41eb-a00c-895b917e57c6"), new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2ba9352-d4f5-469d-88ea-677b05762c40"), new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e31300fc-f8ec-4ba2-8986-7b82a82f41fb"), new DateTime(2023, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e34a2e1d-c926-4570-9b75-847d64833f6b"), new DateTime(2023, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e57bde88-f6cc-4249-ba32-4ce77f13c1d8"), new DateTime(2023, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e594701e-244f-449d-ba54-a7dc8816090e"), new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5d58cd0-5fb0-4787-9928-4ab4255e5fcf"), new DateTime(2023, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5e0151b-4204-467e-9d6b-79d73bb38ded"), new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5ecd3eb-0262-44da-b8fa-eae2f9ed9910"), new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e63c9aa7-f6d0-4993-91e0-7e6db29d07cc"), new DateTime(2023, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e64d274b-2271-4c7f-ac4f-bb8be7c65c79"), new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8441ced-d8a3-41d1-aa7d-12ee7bcd95bf"), new DateTime(2023, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8a929b2-d9a2-4fb2-81fe-cade496f13e1"), new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e993ba93-346a-4933-b5c9-8f027cf3542d"), new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ea259033-3da5-43f7-b046-2ff31139c971"), new DateTime(2023, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb091ac5-3c71-4d83-b62d-2c50f7e0cc21"), new DateTime(2023, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb3dd37d-1240-4448-8329-67658194770d"), new DateTime(2023, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb648e92-6478-404a-97e8-f5866abe15f4"), new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec2d74bc-9fb3-4a46-a53c-b820f04e625c"), new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ed37d6ef-2ae9-4d46-a850-50789d8d2b41"), new DateTime(2023, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eef8ff56-5444-48a1-8d16-1bc13c69b811"), new DateTime(2023, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef0aac7b-b733-4ac3-8995-b120edf56e3c"), new DateTime(2023, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef2324bf-ee2d-4094-a42f-13c6beecd049"), new DateTime(2023, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f057c80e-04f2-4cf7-b291-5bfe5d83f0de"), new DateTime(2023, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f0764eff-6b38-453e-b66e-33e4282d01c4"), new DateTime(2023, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1c02a24-0fc0-44b8-be79-4f818d212b00"), new DateTime(2023, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2ab1e62-1931-409e-b7e2-096a40d5f356"), new DateTime(2023, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2f361b4-f3c6-4936-8d76-3489b6562af4"), new DateTime(2023, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3362918-aa9f-44d8-a1a3-80719830cc2d"), new DateTime(2023, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f65b39f9-61b2-4112-92f0-52271ddd3bcc"), new DateTime(2023, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f712b6f8-86c7-4ec4-ba30-47c2320fb896"), new DateTime(2023, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f736c018-cb3a-4331-8053-7fb274165639"), new DateTime(2023, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7929e71-4bb7-4d8b-a1d8-33fcf1064c82"), new DateTime(2023, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8117993-c102-4275-bbcb-4e8edb184d07"), new DateTime(2023, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8a14497-19b0-48e2-b85b-ce08fa7bbf99"), new DateTime(2023, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f91874dd-7c0b-47f2-9fe8-5d180165c8d6"), new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9b03253-e11a-405f-a7e2-4e290833ac00"), new DateTime(2023, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9ef66a3-01ec-4da6-995c-858c3235253e"), new DateTime(2023, 8, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb131d79-256e-406e-8786-329edac32f57"), new DateTime(2023, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbe5d5f4-d8ec-4471-a2d2-bdc75c57ba86"), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fbf51763-37c0-4c9c-af60-79cb64538b59"), new DateTime(2023, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe29d11b-ba86-43ed-acc6-2667023962eb"), new DateTime(2023, 1, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_HotelId",
                table: "Bookings",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_RoomId",
                table: "Bookings",
                column: "RoomId");
        }
    }
}
