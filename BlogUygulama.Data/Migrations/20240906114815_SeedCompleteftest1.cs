using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogUygulama.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedCompleteftest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "IsDeleted", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("01724477-e4e7-46ec-a3bb-495663c7f953"), "Admin Test 2", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(4586), null, null, false, null, null, "Asp.Net Core" },
                    { new Guid("52b35ac9-c1c4-498c-ae60-3642b55dd160"), "Admin Test 1", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(4579), null, null, false, null, null, "Asp.Net Core" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "FileName", "FileType", "IsDeleted", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("a2c46d1b-e450-4d2f-a301-900e51393d1f"), "Admin Test 2", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(6847), null, null, "images/testimage2", "png", false, null, null },
                    { new Guid("ec79553f-e5e0-445f-a239-7dc1a3ab1486"), "Admin Test 1", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(6840), null, null, "images/testimage", "jpg", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DeletedBy", "DeletedDate", "ImageId", "IsDeleted", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("5f5a3b4b-8ccd-4f4c-a098-73f16d703ef7"), new Guid("01724477-e4e7-46ec-a3bb-495663c7f953"), " Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec neque odio, consequat nec sodales non, viverra sit amet justo. Quisque dignissim quam sit amet erat luctus, et euismod metus gravida. Integer vitae ante rutrum, dignissim felis non, porttitor magna. Donec nec orci nisl. Vestibulum congue, lorem hendrerit sollicitudin scelerisque, diam erat blandit metus, vel porta arcu est in lacus. Fusce rhoncus dignissim massa, vel cursus purus consequat ac. Donec finibus eleifend mauris, id feugiat est tempor at. Morbi quis luctus orci. Sed id nisl nec lorem blandit facilisis sit amet eu justo. Morbi leo massa, tempus ut efficitur vel, rhoncus ut purus.\r\n\r\nSuspendisse porta urna a leo aliquam, id laoreet nunc blandit. Donec id arcu nisl. Phasellus augue dui, convallis et vulputate in, varius et ante. Nam sit amet placerat ipsum, id ultrices ex. In malesuada, est tempor pellentesque fringilla, felis dui tempus tellus, at pellentesque eros tortor nec dolor. Nunc at varius lectus. Praesent at magna porttitor, tempor tellus quis, fermentum purus.\r\n\r\nSed feugiat dapibus lacus. Pellentesque ut aliquet dui, vitae malesuada purus. In et sollicitudin tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam eu bibendum eros. Donec rutrum varius facilisis. Etiam dui lectus, pulvinar a mauris in, gravida pulvinar sem. Sed in ligula in odio bibendum bibendum. Nam gravida vehicula blandit. In sit amet lectus ultricies, ornare sem sed, suscipit ligula. Maecenas vulputate augue sit amet risus pretium aliquam.\r\n\r\nNam tristique lectus a leo ultrices scelerisque. Phasellus id libero vel nisi ornare porttitor id fermentum massa. Nullam fringilla facilisis erat, vel hendrerit odio hendrerit sit amet. Vivamus sed metus ac purus facilisis auctor. Nunc at ultricies nunc. Etiam volutpat turpis bibendum dui posuere, in sodales mauris interdum. Vivamus sed ullamcorper ante. Mauris porttitor est turpis, sed suscipit mi tristique fringilla. Pellentesque eget convallis lacus. Nunc scelerisque pretium velit laoreet auctor. Aliquam non faucibus velit, ac lobortis libero.\r\n\r\nFusce bibendum justo libero, porta blandit ligula ultricies vel. Curabitur quis eleifend tortor. Maecenas eleifend tincidunt elit in maximus. Suspendisse potenti. Praesent in finibus sem. Pellentesque ante nisi, laoreet at porttitor a, lacinia et nibh. Ut fringilla erat ac ullamcorper pharetra. Curabitur mauris elit, cursus eu ullamcorper id, dignissim quis tellus. Integer velit nibh, commodo et nibh non, semper pharetra est. Mauris a enim in lectus euismod tempus. Ut euismod tempor suscipit. Nam ut dolor quis nisi faucibus venenatis vitae ac augue. Maecenas laoreet risus nec dignissim congue. Donec congue fringilla orci, eget fermentum eros bibendum sed. Vivamus id eleifend massa.\r\n\r\nCurabitur tristique eget velit sit amet ultrices. Duis lacinia, magna a scelerisque gravida, ante lectus commodo mauris, at volutpat purus enim vel ligula. Duis sed lacus id sem tristique placerat non in enim. Etiam ornare feugiat quam sit amet congue. Sed molestie magna ut ligula mattis, eu congue erat accumsan. Maecenas et magna placerat, vehicula enim id, viverra dolor. Quisque dignissim, lectus sit amet suscipit iaculis, ipsum nisi auctor urna, a ultricies diam lectus non est. Etiam porttitor sem eget risus sagittis sodales. Sed bibendum purus sit amet urna imperdiet, sed lacinia orci congue. Mauris pellentesque, sapien eu condimentum convallis, leo magna consectetur sapien, vel consequat leo mi non diam. Suspendisse ac urna eros. Proin eu feugiat mi.", "Admin Test 2", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(1816), null, null, new Guid("a2c46d1b-e450-4d2f-a301-900e51393d1f"), false, null, null, "Visual Studio Deneme Makalesi 2", 20 },
                    { new Guid("bd01bf13-8989-4761-8ec9-a59ef0328853"), new Guid("52b35ac9-c1c4-498c-ae60-3642b55dd160"), " Asp.net Core  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec neque odio, consequat nec sodales non, viverra sit amet justo. Quisque dignissim quam sit amet erat luctus, et euismod metus gravida. Integer vitae ante rutrum, dignissim felis non, porttitor magna. Donec nec orci nisl. Vestibulum congue, lorem hendrerit sollicitudin scelerisque, diam erat blandit metus, vel porta arcu est in lacus. Fusce rhoncus dignissim massa, vel cursus purus consequat ac. Donec finibus eleifend mauris, id feugiat est tempor at. Morbi quis luctus orci. Sed id nisl nec lorem blandit facilisis sit amet eu justo. Morbi leo massa, tempus ut efficitur vel, rhoncus ut purus.\r\n\r\nSuspendisse porta urna a leo aliquam, id laoreet nunc blandit. Donec id arcu nisl. Phasellus augue dui, convallis et vulputate in, varius et ante. Nam sit amet placerat ipsum, id ultrices ex. In malesuada, est tempor pellentesque fringilla, felis dui tempus tellus, at pellentesque eros tortor nec dolor. Nunc at varius lectus. Praesent at magna porttitor, tempor tellus quis, fermentum purus.\r\n\r\nSed feugiat dapibus lacus. Pellentesque ut aliquet dui, vitae malesuada purus. In et sollicitudin tortor. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Etiam eu bibendum eros. Donec rutrum varius facilisis. Etiam dui lectus, pulvinar a mauris in, gravida pulvinar sem. Sed in ligula in odio bibendum bibendum. Nam gravida vehicula blandit. In sit amet lectus ultricies, ornare sem sed, suscipit ligula. Maecenas vulputate augue sit amet risus pretium aliquam.\r\n\r\nNam tristique lectus a leo ultrices scelerisque. Phasellus id libero vel nisi ornare porttitor id fermentum massa. Nullam fringilla facilisis erat, vel hendrerit odio hendrerit sit amet. Vivamus sed metus ac purus facilisis auctor. Nunc at ultricies nunc. Etiam volutpat turpis bibendum dui posuere, in sodales mauris interdum. Vivamus sed ullamcorper ante. Mauris porttitor est turpis, sed suscipit mi tristique fringilla. Pellentesque eget convallis lacus. Nunc scelerisque pretium velit laoreet auctor. Aliquam non faucibus velit, ac lobortis libero.\r\n\r\nFusce bibendum justo libero, porta blandit ligula ultricies vel. Curabitur quis eleifend tortor. Maecenas eleifend tincidunt elit in maximus. Suspendisse potenti. Praesent in finibus sem. Pellentesque ante nisi, laoreet at porttitor a, lacinia et nibh. Ut fringilla erat ac ullamcorper pharetra. Curabitur mauris elit, cursus eu ullamcorper id, dignissim quis tellus. Integer velit nibh, commodo et nibh non, semper pharetra est. Mauris a enim in lectus euismod tempus. Ut euismod tempor suscipit. Nam ut dolor quis nisi faucibus venenatis vitae ac augue. Maecenas laoreet risus nec dignissim congue. Donec congue fringilla orci, eget fermentum eros bibendum sed. Vivamus id eleifend massa.\r\n\r\nCurabitur tristique eget velit sit amet ultrices. Duis lacinia, magna a scelerisque gravida, ante lectus commodo mauris, at volutpat purus enim vel ligula. Duis sed lacus id sem tristique placerat non in enim. Etiam ornare feugiat quam sit amet congue. Sed molestie magna ut ligula mattis, eu congue erat accumsan. Maecenas et magna placerat, vehicula enim id, viverra dolor. Quisque dignissim, lectus sit amet suscipit iaculis, ipsum nisi auctor urna, a ultricies diam lectus non est. Etiam porttitor sem eget risus sagittis sodales. Sed bibendum purus sit amet urna imperdiet, sed lacinia orci congue. Mauris pellentesque, sapien eu condimentum convallis, leo magna consectetur sapien, vel consequat leo mi non diam. Suspendisse ac urna eros. Proin eu feugiat mi.", "Admin Test ", new DateTime(2024, 9, 6, 14, 48, 14, 845, DateTimeKind.Local).AddTicks(1783), null, null, new Guid("ec79553f-e5e0-445f-a239-7dc1a3ab1486"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("5f5a3b4b-8ccd-4f4c-a098-73f16d703ef7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("bd01bf13-8989-4761-8ec9-a59ef0328853"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01724477-e4e7-46ec-a3bb-495663c7f953"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52b35ac9-c1c4-498c-ae60-3642b55dd160"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("a2c46d1b-e450-4d2f-a301-900e51393d1f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("ec79553f-e5e0-445f-a239-7dc1a3ab1486"));
        }
    }
}
