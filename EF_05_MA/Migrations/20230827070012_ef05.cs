using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_05_MA.Migrations
{
    /// <inheritdoc />
    public partial class ef05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Loaimonan",
                columns: table => new
                {
                    LoaimonanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tenloai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loaimonan", x => x.LoaimonanID);
                });

            migrationBuilder.CreateTable(
                name: "Nguyenlieu",
                columns: table => new
                {
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tennguyenlieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nguyenlieu", x => x.NguyenlieuID);
                });

            migrationBuilder.CreateTable(
                name: "Monan",
                columns: table => new
                {
                    MonanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoaimonanID = table.Column<int>(type: "int", nullable: false),
                    Tenmon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giaban = table.Column<double>(type: "float", nullable: false),
                    Gioithieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cachlam = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monan", x => x.MonanID);
                    table.ForeignKey(
                        name: "FK_Monan_Loaimonan_LoaimonanID",
                        column: x => x.LoaimonanID,
                        principalTable: "Loaimonan",
                        principalColumn: "LoaimonanID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Congthucs",
                columns: table => new
                {
                    CongthucID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NguyenlieuID = table.Column<int>(type: "int", nullable: false),
                    MonanID = table.Column<int>(type: "int", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Donvitinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Congthucs", x => x.CongthucID);
                    table.ForeignKey(
                        name: "FK_Congthucs_Monan_MonanID",
                        column: x => x.MonanID,
                        principalTable: "Monan",
                        principalColumn: "MonanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Congthucs_Nguyenlieu_NguyenlieuID",
                        column: x => x.NguyenlieuID,
                        principalTable: "Nguyenlieu",
                        principalColumn: "NguyenlieuID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Congthucs_MonanID",
                table: "Congthucs",
                column: "MonanID");

            migrationBuilder.CreateIndex(
                name: "IX_Congthucs_NguyenlieuID",
                table: "Congthucs",
                column: "NguyenlieuID");

            migrationBuilder.CreateIndex(
                name: "IX_Monan_LoaimonanID",
                table: "Monan",
                column: "LoaimonanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Congthucs");

            migrationBuilder.DropTable(
                name: "Monan");

            migrationBuilder.DropTable(
                name: "Nguyenlieu");

            migrationBuilder.DropTable(
                name: "Loaimonan");
        }
    }
}
