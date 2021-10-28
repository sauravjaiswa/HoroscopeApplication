using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HoroscopeApplication.Migrations
{
    public partial class AddSunsignsTableWithSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoroscopeCaches");

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 1, "01-01", "Capricorn" },
                    { 249, "05-09", "Virgo" },
                    { 248, "04-09", "Virgo" },
                    { 247, "03-09", "Virgo" },
                    { 246, "02-09", "Virgo" },
                    { 245, "01-09", "Virgo" },
                    { 244, "31-08", "Virgo" },
                    { 243, "30-08", "Virgo" },
                    { 242, "29-08", "Virgo" },
                    { 250, "06-09", "Virgo" },
                    { 241, "28-08", "Virgo" },
                    { 239, "26-08", "Virgo" },
                    { 238, "25-08", "Virgo" },
                    { 237, "24-08", "Virgo" },
                    { 236, "23-08", "Virgo" },
                    { 235, "22-08", "Leo" },
                    { 234, "21-08", "Leo" },
                    { 233, "20-08", "Leo" },
                    { 232, "19-08", "Leo" },
                    { 240, "27-08", "Virgo" },
                    { 251, "07-09", "Virgo" },
                    { 252, "08-09", "Virgo" },
                    { 253, "09-09", "Virgo" },
                    { 272, "28-09", "Libra" },
                    { 271, "27-09", "Libra" },
                    { 270, "26-09", "Libra" },
                    { 269, "25-09", "Libra" },
                    { 268, "24-09", "Libra" },
                    { 267, "23-09", "Libra" },
                    { 266, "22-09", "Virgo" },
                    { 265, "21-09", "Virgo" },
                    { 264, "20-09", "Virgo" },
                    { 263, "19-09", "Virgo" },
                    { 262, "18-09", "Virgo" },
                    { 261, "17-09", "Virgo" },
                    { 260, "16-09", "Virgo" },
                    { 259, "15-09", "Virgo" },
                    { 258, "14-09", "Virgo" },
                    { 257, "13-09", "Virgo" },
                    { 256, "12-09", "Virgo" },
                    { 255, "11-09", "Virgo" },
                    { 254, "10-09", "Virgo" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 231, "18-08", "Leo" },
                    { 230, "17-08", "Leo" },
                    { 229, "16-08", "Leo" },
                    { 228, "15-08", "Leo" },
                    { 204, "22-07", "Cancer" },
                    { 203, "21-07", "Cancer" },
                    { 202, "20-07", "Cancer" },
                    { 201, "19-07", "Cancer" },
                    { 200, "18-07", "Cancer" },
                    { 199, "17-07", "Cancer" },
                    { 198, "16-07", "Cancer" },
                    { 197, "15-07", "Cancer" },
                    { 196, "14-07", "Cancer" },
                    { 195, "13-07", "Cancer" },
                    { 194, "12-07", "Cancer" },
                    { 193, "11-07", "Cancer" },
                    { 192, "10-07", "Cancer" },
                    { 191, "09-07", "Cancer" },
                    { 190, "08-07", "Cancer" },
                    { 189, "07-07", "Cancer" },
                    { 188, "06-07", "Cancer" },
                    { 187, "05-07", "Cancer" },
                    { 186, "04-07", "Cancer" },
                    { 205, "23-07", "Leo" },
                    { 273, "29-09", "Libra" },
                    { 206, "24-07", "Leo" },
                    { 208, "26-07", "Leo" },
                    { 227, "14-08", "Leo" },
                    { 226, "13-08", "Leo" },
                    { 225, "12-08", "Leo" },
                    { 224, "11-08", "Leo" },
                    { 223, "10-08", "Leo" },
                    { 222, "09-08", "Leo" },
                    { 221, "08-08", "Leo" },
                    { 220, "07-08", "Leo" },
                    { 219, "06-08", "Leo" },
                    { 218, "05-08", "Leo" },
                    { 217, "04-08", "Leo" },
                    { 216, "03-08", "Leo" },
                    { 215, "02-08", "Leo" },
                    { 214, "01-08", "Leo" },
                    { 213, "31-07", "Leo" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 212, "30-07", "Leo" },
                    { 211, "29-07", "Leo" },
                    { 210, "28-07", "Leo" },
                    { 209, "27-07", "Leo" },
                    { 207, "25-07", "Leo" },
                    { 274, "30-09", "Libra" },
                    { 275, "01-10", "Libra" },
                    { 276, "02-10", "Libra" },
                    { 341, "06-12", "Sagittarius" },
                    { 340, "05-12", "Sagittarius" },
                    { 339, "04-12", "Sagittarius" },
                    { 338, "03-12", "Sagittarius" },
                    { 337, "02-12", "Sagittarius" },
                    { 336, "01-12", "Sagittarius" },
                    { 335, "30-11", "Sagittarius" },
                    { 334, "29-11", "Sagittarius" },
                    { 333, "28-11", "Sagittarius" },
                    { 332, "27-11", "Sagittarius" },
                    { 331, "26-11", "Sagittarius" },
                    { 330, "25-11", "Sagittarius" },
                    { 329, "24-11", "Sagittarius" },
                    { 328, "23-11", "Sagittarius" },
                    { 327, "22-11", "Sagittarius" },
                    { 326, "21-11", "Scorpio" },
                    { 325, "20-11", "Scorpio" },
                    { 324, "19-11", "Scorpio" },
                    { 323, "18-11", "Scorpio" },
                    { 342, "07-12", "Sagittarius" },
                    { 322, "17-11", "Scorpio" },
                    { 343, "08-12", "Sagittarius" },
                    { 345, "10-12", "Sagittarius" },
                    { 364, "29-12", "Capricorn" },
                    { 363, "28-12", "Capricorn" },
                    { 362, "27-12", "Capricorn" },
                    { 361, "26-12", "Capricorn" },
                    { 360, "25-12", "Capricorn" },
                    { 359, "24-12", "Capricorn" },
                    { 358, "23-12", "Capricorn" },
                    { 357, "22-12", "Capricorn" },
                    { 356, "21-12", "Sagittarius" },
                    { 355, "20-12", "Sagittarius" },
                    { 354, "19-12", "Sagittarius" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 353, "18-12", "Sagittarius" },
                    { 352, "17-12", "Sagittarius" },
                    { 351, "16-12", "Sagittarius" },
                    { 350, "15-12", "Sagittarius" },
                    { 349, "14-12", "Sagittarius" },
                    { 348, "13-12", "Sagittarius" },
                    { 347, "12-12", "Sagittarius" },
                    { 346, "11-12", "Sagittarius" },
                    { 344, "09-12", "Sagittarius" },
                    { 185, "03-07", "Cancer" },
                    { 321, "16-11", "Scorpio" },
                    { 319, "14-11", "Scorpio" },
                    { 295, "21-10", "Libra" },
                    { 294, "20-10", "Libra" },
                    { 293, "19-10", "Libra" },
                    { 292, "18-10", "Libra" },
                    { 291, "17-10", "Libra" },
                    { 290, "16-10", "Libra" },
                    { 289, "15-10", "Libra" },
                    { 288, "14-10", "Libra" },
                    { 287, "13-10", "Libra" },
                    { 286, "12-10", "Libra" },
                    { 285, "11-10", "Libra" },
                    { 284, "10-10", "Libra" },
                    { 283, "09-10", "Libra" },
                    { 282, "08-10", "Libra" },
                    { 281, "07-10", "Libra" },
                    { 280, "06-10", "Libra" },
                    { 279, "05-10", "Libra" },
                    { 278, "04-10", "Libra" },
                    { 277, "03-10", "Libra" },
                    { 296, "22-10", "Libra" },
                    { 320, "15-11", "Scorpio" },
                    { 297, "23-10", "Scorpio" },
                    { 299, "25-10", "Scorpio" },
                    { 318, "13-11", "Scorpio" },
                    { 317, "12-11", "Scorpio" },
                    { 316, "11-11", "Scorpio" },
                    { 315, "10-11", "Scorpio" },
                    { 314, "09-11", "Scorpio" },
                    { 313, "08-11", "Scorpio" },
                    { 312, "07-11", "Scorpio" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 311, "06-11", "Scorpio" },
                    { 310, "05-11", "Scorpio" },
                    { 309, "04-11", "Scorpio" },
                    { 308, "03-11", "Scorpio" },
                    { 307, "02-11", "Scorpio" },
                    { 306, "01-11", "Scorpio" },
                    { 305, "31-10", "Scorpio" },
                    { 304, "30-10", "Scorpio" },
                    { 303, "29-10", "Scorpio" },
                    { 302, "28-10", "Scorpio" },
                    { 301, "27-10", "Scorpio" },
                    { 300, "26-10", "Scorpio" },
                    { 298, "24-10", "Scorpio" },
                    { 184, "02-07", "Cancer" },
                    { 183, "01-07", "Cancer" },
                    { 182, "30-06", "Cancer" },
                    { 66, "06-03", "Pisces" },
                    { 65, "05-03", "Pisces" },
                    { 64, "04-03", "Pisces" },
                    { 63, "03-03", "Pisces" },
                    { 62, "02-03", "Pisces" },
                    { 61, "01-03", "Pisces" },
                    { 60, "29-02", "Pisces" },
                    { 59, "28-02", "Pisces" },
                    { 58, "27-02", "Pisces" },
                    { 57, "26-02", "Pisces" },
                    { 56, "25-02", "Pisces" },
                    { 55, "24-02", "Pisces" },
                    { 54, "23-02", "Pisces" },
                    { 53, "22-02", "Pisces" },
                    { 52, "21-02", "Pisces" },
                    { 51, "20-02", "Pisces" },
                    { 50, "19-02", "Pisces" },
                    { 49, "18-02", "Aquarius" },
                    { 48, "17-02", "Aquarius" },
                    { 67, "07-03", "Pisces" },
                    { 47, "16-02", "Aquarius" },
                    { 68, "08-03", "Pisces" },
                    { 70, "10-03", "Pisces" },
                    { 89, "29-03", "Aries" },
                    { 88, "28-03", "Aries" },
                    { 87, "27-03", "Aries" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 86, "26-03", "Aries" },
                    { 85, "25-03", "Aries" },
                    { 84, "24-03", "Aries" },
                    { 83, "23-03", "Aries" },
                    { 82, "22-03", "Aries" },
                    { 81, "21-03", "Aries" },
                    { 80, "20-03", "Pisces" },
                    { 79, "19-03", "Pisces" },
                    { 78, "18-03", "Pisces" },
                    { 77, "17-03", "Pisces" },
                    { 76, "16-03", "Pisces" },
                    { 75, "15-03", "Pisces" },
                    { 74, "14-03", "Pisces" },
                    { 73, "13-03", "Pisces" },
                    { 72, "12-03", "Pisces" },
                    { 71, "11-03", "Pisces" },
                    { 69, "09-03", "Pisces" },
                    { 90, "30-03", "Aries" },
                    { 46, "15-02", "Aquarius" },
                    { 44, "13-02", "Aquarius" },
                    { 20, "20-01", "Aquarius" },
                    { 19, "19-01", "Capricorn" },
                    { 18, "18-01", "Capricorn" },
                    { 17, "17-01", "Capricorn" },
                    { 16, "16-01", "Capricorn" },
                    { 15, "15-01", "Capricorn" },
                    { 14, "14-01", "Capricorn" },
                    { 13, "13-01", "Capricorn" },
                    { 12, "12-01", "Capricorn" },
                    { 11, "11-01", "Capricorn" },
                    { 10, "10-01", "Capricorn" },
                    { 9, "09-01", "Capricorn" },
                    { 8, "08-01", "Capricorn" },
                    { 7, "07-01", "Capricorn" },
                    { 6, "06-01", "Capricorn" },
                    { 5, "05-01", "Capricorn" },
                    { 4, "04-01", "Capricorn" },
                    { 3, "03-01", "Capricorn" },
                    { 2, "02-01", "Capricorn" },
                    { 21, "21-01", "Aquarius" },
                    { 45, "14-02", "Aquarius" },
                    { 22, "22-01", "Aquarius" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 24, "24-01", "Aquarius" },
                    { 43, "12-02", "Aquarius" },
                    { 42, "11-02", "Aquarius" },
                    { 41, "10-02", "Aquarius" },
                    { 40, "09-02", "Aquarius" },
                    { 39, "08-02", "Aquarius" },
                    { 38, "07-02", "Aquarius" },
                    { 37, "06-02", "Aquarius" },
                    { 36, "05-02", "Aquarius" },
                    { 35, "04-02", "Aquarius" },
                    { 34, "03-02", "Aquarius" },
                    { 33, "02-02", "Aquarius" },
                    { 32, "01-02", "Aquarius" },
                    { 31, "31-01", "Aquarius" },
                    { 30, "30-01", "Aquarius" },
                    { 29, "29-01", "Aquarius" },
                    { 28, "28-01", "Aquarius" },
                    { 27, "27-01", "Aquarius" },
                    { 26, "26-01", "Aquarius" },
                    { 25, "25-01", "Aquarius" },
                    { 23, "23-01", "Aquarius" },
                    { 365, "30-12", "Capricorn" },
                    { 91, "31-03", "Aries" },
                    { 93, "02-04", "Aries" },
                    { 158, "06-06", "Gemini" },
                    { 157, "05-06", "Gemini" },
                    { 156, "04-06", "Gemini" },
                    { 155, "03-06", "Gemini" },
                    { 154, "02-06", "Gemini" },
                    { 153, "01-06", "Gemini" },
                    { 152, "31-05", "Gemini" },
                    { 151, "30-05", "Gemini" },
                    { 150, "29-05", "Gemini" },
                    { 149, "28-05", "Gemini" },
                    { 148, "27-05", "Gemini" },
                    { 147, "26-05", "Gemini" },
                    { 146, "25-05", "Gemini" },
                    { 145, "24-05", "Gemini" },
                    { 144, "23-05", "Gemini" },
                    { 143, "22-05", "Gemini" },
                    { 142, "21-05", "Gemini" },
                    { 141, "20-05", "Taurus" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 140, "19-05", "Taurus" },
                    { 159, "07-06", "Gemini" },
                    { 139, "18-05", "Taurus" },
                    { 160, "08-06", "Gemini" },
                    { 162, "10-06", "Gemini" },
                    { 181, "29-06", "Cancer" },
                    { 180, "28-06", "Cancer" },
                    { 179, "27-06", "Cancer" },
                    { 178, "26-06", "Cancer" },
                    { 177, "25-06", "Cancer" },
                    { 176, "24-06", "Cancer" },
                    { 175, "23-06", "Cancer" },
                    { 174, "22-06", "Cancer" },
                    { 173, "21-06", "Cancer" },
                    { 172, "20-06", "Gemini" },
                    { 171, "19-06", "Gemini" },
                    { 170, "18-06", "Gemini" },
                    { 169, "17-06", "Gemini" },
                    { 168, "16-06", "Gemini" },
                    { 167, "15-06", "Gemini" },
                    { 166, "14-06", "Gemini" },
                    { 165, "13-06", "Gemini" },
                    { 164, "12-06", "Gemini" },
                    { 163, "11-06", "Gemini" },
                    { 161, "09-06", "Gemini" },
                    { 92, "01-04", "Aries" },
                    { 138, "17-05", "Taurus" },
                    { 136, "15-05", "Taurus" },
                    { 112, "21-04", "Taurus" },
                    { 111, "20-04", "Taurus" },
                    { 110, "19-04", "Aries" },
                    { 109, "18-04", "Aries" },
                    { 108, "17-04", "Aries" },
                    { 107, "16-04", "Aries" },
                    { 106, "15-04", "Aries" },
                    { 105, "14-04", "Aries" },
                    { 104, "13-04", "Aries" },
                    { 103, "12-04", "Aries" },
                    { 102, "11-04", "Aries" },
                    { 101, "10-04", "Aries" },
                    { 100, "09-04", "Aries" },
                    { 99, "08-04", "Aries" }
                });

            migrationBuilder.InsertData(
                table: "Sunsigns",
                columns: new[] { "Id", "Date", "SunSign" },
                values: new object[,]
                {
                    { 98, "07-04", "Aries" },
                    { 97, "06-04", "Aries" },
                    { 96, "05-04", "Aries" },
                    { 95, "04-04", "Aries" },
                    { 94, "03-04", "Aries" },
                    { 113, "22-04", "Taurus" },
                    { 137, "16-05", "Taurus" },
                    { 114, "23-04", "Taurus" },
                    { 116, "25-04", "Taurus" },
                    { 135, "14-05", "Taurus" },
                    { 134, "13-05", "Taurus" },
                    { 133, "12-05", "Taurus" },
                    { 132, "11-05", "Taurus" },
                    { 131, "10-05", "Taurus" },
                    { 130, "09-05", "Taurus" },
                    { 129, "08-05", "Taurus" },
                    { 128, "07-05", "Taurus" },
                    { 127, "06-05", "Taurus" },
                    { 126, "05-05", "Taurus" },
                    { 125, "04-05", "Taurus" },
                    { 124, "03-05", "Taurus" },
                    { 123, "02-05", "Taurus" },
                    { 122, "01-05", "Taurus" },
                    { 121, "30-04", "Taurus" },
                    { 120, "29-04", "Taurus" },
                    { 119, "28-04", "Taurus" },
                    { 118, "27-04", "Taurus" },
                    { 117, "26-04", "Taurus" },
                    { 115, "24-04", "Taurus" },
                    { 366, "31-12", "Capricorn" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Sunsigns",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.CreateTable(
                name: "HoroscopeCaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedTimestamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Compatibility = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Current_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_range = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lucky_number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lucky_time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mood = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sunsign = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoroscopeCaches", x => x.Id);
                });
        }
    }
}
