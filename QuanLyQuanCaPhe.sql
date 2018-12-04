/*
 Navicat MongoDB Data Transfer

 Source Server         : admin
 Source Server Type    : MongoDB
 Source Server Version : 40002
 Source Host           : localhost:27017
 Source Schema         : QuanLyQuanCaPhe

 Target Server Type    : MongoDB
 Target Server Version : 40002
 File Encoding         : 65001

 Date: 26/11/2018 09:03:56
*/


// ----------------------------
// Collection structure for Customer
// ----------------------------
db.getCollection("Customer").drop();
db.createCollection("Customer");

// ----------------------------
// Documents of Customer
// ----------------------------
db.getCollection("Customer").insert([ {
    _id: ObjectId("5be2e73eb2cbf2912bd85b2a"),
    HoTen: "Khách Hàng 2",
    tuoi: NumberLong("18"),
    dienThoai: NumberLong("745456456"),
    DiaChi: "Quận 1",
    maGiamGia: "12"
} ]);
db.getCollection("Customer").insert([ {
    _id: ObjectId("5be2e743b2cbf2912bd85b34"),
    HoTen: "Khách Hàng 3",
    tuoi: NumberLong("18"),
    dienThoai: NumberLong("712396541"),
    DiaChi: "Quận 1",
    maGiamGia: "12"
} ]);
db.getCollection("Customer").insert([ {
    _id: ObjectId("5be2e7cbb2cbf2912bd85b9e"),
    HoTen: "Khách Hàng 1",
    tuoi: NumberLong("20"),
    dienThoai: NumberLong("123456"),
    DiaChi: "Quận 2",
    maGiamGia: "2"
} ]);
db.getCollection("Customer").insert([ {
    _id: ObjectId("5be98ab34e6b06bd4352a378"),
    HoTen: "Khách Hàng 6",
    tuoi: NumberLong("18"),
    dienThoai: NumberLong("745456456"),
    DiaChi: "Quận 1",
    maGiamGia: "12"
} ]);

// ----------------------------
// Collection structure for Employees
// ----------------------------
db.getCollection("Employees").drop();
db.createCollection("Employees");

// ----------------------------
// Documents of Employees
// ----------------------------
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee487"),
    TenNV: "Nguyễn Văn Nam ",
    NgaySinh: ISODate("2018-11-11T00:00:00.000Z"),
    DiaChi: " Hà Nội",
    DienThoai: NumberLong("164895223"),
    soThe: "123132321"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee489"),
    TenNV: "Trần Thị Liên",
    NgaySinh: ISODate("1998-02-20T17:00:00.000Z"),
    DiaChi: "Hà Tĩnh",
    DienThoai: NumberLong("1685051237"),
    soThe: "1233321312312"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee48d"),
    TenNV: "Trần Thành Đạt",
    NgaySinh: ISODate("1998-02-06T17:00:00.000Z"),
    DiaChi: "Đà Lạt",
    DienThoai: NumberLong("1685051237"),
    soThe: " 1234353453453"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee48f"),
    TenNV: "Nguyễn Thành Đồng",
    NgaySinh: ISODate("2012-12-19T06:01:17.171Z"),
    DiaChi: "Gia Lai",
    DienThoai: NumberLong("123411102"),
    soThe: " 12323423423"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee491"),
    TenNV: "Hồ Ngọc Sơn",
    NgaySinh: ISODate("2012-12-19T00:00:00.000Z"),
    DiaChi: " Hà Tĩnh",
    DienThoai: NumberLong("1232322113"),
    soThe: "  123234234234"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bbb1d6818e6cd60e68ee493"),
    TenNV: "Võ Hồng Phúc",
    NgaySinh: ISODate("2018-02-02T00:00:00.000Z"),
    DiaChi: "Bình Định",
    DienThoai: NumberLong("123410223"),
    soThe: " 1232342432"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bc00627474fd44b91ae9c00"),
    TenNV: "Nguyễn Văn An",
    NgaySinh: ISODate("2018-02-02T00:00:00.000Z"),
    DiaChi: "Đồng Tháp",
    DienThoai: NumberLong("164895223"),
    soThe: " 2434234234234"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bc00738474fd44b91ae9c84"),
    TenNV: "Trần Thị Hà",
    NgaySinh: ISODate("2018-02-02T00:00:00.000Z"),
    DiaChi: "tp. Hồ Chí Minh",
    DienThoai: NumberLong("164895223"),
    soThe: " 1234323423423"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bf63476b678f1738d9c5c9e"),
    TenNV: "Nguyễn Văn Nam 2",
    NgaySinh: ISODate("2018-11-11T00:00:00.000Z"),
    DiaChi: "  Hà Nội",
    DienThoai: NumberLong("164895223"),
    soThe: " 12343534534"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bf67823b678f1738d9c7e89"),
    TenNV: "Phan Văn Trí",
    NgaySinh: ISODate("1998-05-21T00:00:00.000Z"),
    DiaChi: " Quảng Nam",
    DienThoai: NumberLong("1685053517"),
    soThe: "999999999"
} ]);
db.getCollection("Employees").insert([ {
    _id: ObjectId("5bf678b3b678f1738d9c7ee8"),
    TenNV: "Nguyễn Cu Toản",
    NgaySinh: ISODate("1997-02-11T00:00:00.000Z"),
    DiaChi: "  Hà Nội",
    DienThoai: NumberLong("2342342"),
    soThe: "42342343"
} ]);

// ----------------------------
// Collection structure for OrderDrink
// ----------------------------
db.getCollection("OrderDrink").drop();
db.createCollection("OrderDrink");

// ----------------------------
// Documents of OrderDrink
// ----------------------------
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bec43f1e9ada5528a824dfd"),
    tenBan: "Bàn F6",
    soHoaDon: NumberLong("1"),
    khachHang: " X",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Banh Flan",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Banh Flan"
    ],
    gia: 52000,
    thoiGian: "14/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bec441ae9ada5528a824e6d"),
    tenBan: "Bàn F6",
    soHoaDon: NumberLong("2"),
    khachHang: " Khách Hàng 3",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Banh Flan",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Banh Flan",
        "Cà Phê Sữa",
        "Macchiato",
        "Thuốc Lá",
        "Cà Phê Sữa",
        "Macchiato",
        "Thuốc Lá"
    ],
    gia: 72160,
    thoiGian: "14/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5befd8b8a52d54395ebb9a27"),
    tenBan: "Bàn F1",
    soHoaDon: NumberLong("1"),
    khachHang: " Khách Hàng 3",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Thuốc Lá",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Thuốc Lá"
    ],
    gia: 54560,
    thoiGian: "17/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bf24ca0c03e8ea0dff76490"),
    tenBan: "Bàn F9",
    soHoaDon: NumberLong("1"),
    khachHang: " Tran Thanh Dat",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Americano",
        "Thuốc Lá",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Americano",
        "Thuốc Lá"
    ],
    gia: 97000,
    thoiGian: "19/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bf61a47b678f1738d9c52d4"),
    tenBan: "Bàn F9",
    soHoaDon: NumberLong("1"),
    khachHang: " Tran Thanh Dat",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Americano",
        "Thuốc Lá",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Americano",
        "Thuốc Lá"
    ],
    gia: 97000,
    thoiGian: "19/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bf67cd2b678f1738d9c8069"),
    tenBan: "Bàn F6",
    soHoaDon: NumberLong("1"),
    khachHang: " Phan Cu",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Thuốc Lá",
        "Banh Flan",
        "Banh Macaron",
        "Cà Phê Sữa",
        "Thuốc Lá",
        "Banh Flan",
        "Banh Macaron",
        "Cà Phê Sữa"
    ],
    gia: 62000,
    thoiGian: "22/11/2018"
} ]);
db.getCollection("OrderDrink").insert([ {
    _id: ObjectId("5bfad04fb678f1738d9c8a54"),
    tenBan: "Bàn F6",
    soHoaDon: NumberLong("1"),
    khachHang: " Khách Hàng 3",
    phucVu: "Phan Văn Trí",
    tenSanPham: [
        "Thuốc Lá",
        "Banh Flan",
        "Cà Phê Sữa",
        "Ca phe Arabica",
        "Thuốc Lá",
        "Banh Flan",
        "Cà Phê Sữa",
        "Ca phe Arabica"
    ],
    gia: 63360,
    thoiGian: "25/11/2018"
} ]);

// ----------------------------
// Collection structure for Products
// ----------------------------
db.getCollection("Products").drop();
db.createCollection("Products");

// ----------------------------
// Documents of Products
// ----------------------------
db.getCollection("Products").insert([ {
    _id: ObjectId("5bbb1da618e6cd60e68ee4e1"),
    TenHang: "Cà Phê Sữa",
    Gia: 22000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff59e2b27db0e07a74c2c"),
    TenHang: "Ca phe Arabica",
    Gia: 20000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff5c32b27db0e07a74c40"),
    TenHang: "Ca phe Cherry",
    Gia: 25000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff5da2b27db0e07a74c46"),
    TenHang: "Capuchino",
    Gia: 30000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff5f22b27db0e07a74c54"),
    TenHang: "Macchiato",
    Gia: 40000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6082b27db0e07a74c5c"),
    TenHang: "Americano",
    Gia: 35000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6392b27db0e07a74c70"),
    TenHang: "Banh Flan",
    Gia: 10000,
    DanhMuc: "Sản Phẩm Khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6512b27db0e07a74c78"),
    TenHang: "Banh Tiramisu",
    Gia: 15000,
    DanhMuc: "Sản Phẩm Khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6652b27db0e07a74c86"),
    TenHang: "Banh Cookies",
    Gia: 10000,
    DanhMuc: "Sản Phẩm khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff67e2b27db0e07a74c8e"),
    TenHang: "Banh Macaron",
    Gia: 10000,
    DanhMuc: "Sản Phẩm Khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6992b27db0e07a74c96"),
    TenHang: "Mousse cake",
    Gia: 20000,
    DanhMuc: "Sản Phẩm Khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bdff6a52b27db0e07a74ca0"),
    TenHang: "Thuốc Lá",
    Gia: 20000,
    DanhMuc: "Sản Phẩm Khác"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5be1abb9b2cbf2912bd84eb0"),
    TenHang: "Cà Phê Sữa1",
    Gia: 22000,
    DanhMuc: "Nước Uống"
} ]);
db.getCollection("Products").insert([ {
    _id: ObjectId("5bf61760b678f1738d9c514c"),
    TenHang: "Cà Phê Sữa",
    Gia: 22000,
    DanhMuc: "Nước Uống"
} ]);

// ----------------------------
// Collection structure for Table
// ----------------------------
db.getCollection("Table").drop();
db.createCollection("Table");

// ----------------------------
// Documents of Table
// ----------------------------
db.getCollection("Table").insert([ {
    _id: ObjectId("5bca8db94648d2e1eab125ce"),
    TenBan: "Bàn F1",
    SoCho: NumberLong("4"),
    TinhTrang: true
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bca90194648d2e1eab125cf"),
    TenBan: "Bàn F2",
    SoCho: NumberLong("4"),
    TinhTrang: true
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bca90b8f8df6608c74c2823"),
    TenBan: "Bàn F3",
    SoCho: NumberLong("4"),
    TinhTrang: false
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bca90c0f8df6608c74c282b"),
    TenBan: "Bàn F4",
    SoCho: NumberLong("4"),
    TinhTrang: true
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bdff7972b27db0e07a74d69"),
    TenBan: "Bàn F5",
    SoCho: NumberLong("4"),
    TinhTrang: false
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bdff7a12b27db0e07a74d6d"),
    TenBan: "Bàn F6",
    SoCho: NumberLong("4"),
    TinhTrang: true
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5bdff7b82b27db0e07a74d7d"),
    TenBan: "Bàn F7",
    SoCho: NumberLong("4"),
    TinhTrang: false
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5be1a9d8b2cbf2912bd84e42"),
    TenBan: "Bàn F8",
    SoCho: NumberLong("6"),
    TinhTrang: true
} ]);
db.getCollection("Table").insert([ {
    _id: ObjectId("5be1a9e2b2cbf2912bd84e4a"),
    TenBan: "Bàn F9",
    SoCho: NumberLong("3"),
    TinhTrang: true
} ]);

// ----------------------------
// Collection structure for UserAccount
// ----------------------------
db.getCollection("UserAccount").drop();
db.createCollection("UserAccount");

// ----------------------------
// Documents of UserAccount
// ----------------------------
db.getCollection("UserAccount").insert([ {
    _id: ObjectId("5bf67029b678f1738d9c7b23"),
    tenNV: "Trần Thị Liên",
    taiKhoan: "lien",
    matKhau: "123456"
} ]);
db.getCollection("UserAccount").insert([ {
    _id: ObjectId("5bf6733bb678f1738d9c7c88"),
    tenNV: "Võ Hồng Phúc",
    taiKhoan: "phuc",
    matKhau: "123456"
} ]);
db.getCollection("UserAccount").insert([ {
    _id: ObjectId("5bf67890b678f1738d9c7eca"),
    tenNV: "Phan Văn Trí",
    taiKhoan: "tri",
    matKhau: "123456"
} ]);

// ----------------------------
// Collection structure for system.js
// ----------------------------
db.getCollection("system.js").drop();
db.createCollection("system.js");

// ----------------------------
// Documents of system.js
// ----------------------------
db.getCollection("system.js").insert([ {
    _id: "tinhtong",
    value: Code("function tong(a,b)\r\n    {\r\n        return a+b;\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "sapxep",
    value: Code("function (){\r\n       return  db.getCollection('Hang').find({}).sort({\r\n    \"Gia\":1.0\r\n    });\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertEmployees",
    value: Code("function (tennv,ngaysinh,diachi,dienthoai,soThe)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Employees.insert({\"TenNV\":tennv,\r\n            \"NgaySinh\":ISODate(ngaysinh),\r\n            \"DiaChi\":diachi,\r\n            \"DienThoai\":NumberLong(dienthoai),\r\n            \"soThe\":soThe})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertProducts",
    value: Code("function (tenHang,Gia,DanhMuc)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Products.insert({\"TenHang\":tenHang,\r\n            \"Gia\":Gia,\r\n            \"DanhMuc\":DanhMuc\r\n        })\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "CountEmployees",
    value: Code("function ()\r\n    {\r\n        return db.getCollection('Employees').find({}).count();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "RemoveProducts",
    value: Code("function (id){\r\n        db.loadServerScripts();\r\n        return db.Products.remove({\"_id\":ObjectId(id)})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "RemoveEmployees",
    value: Code("function (id){\r\n        db.loadServerScripts();\r\n        return db.Employees.remove({\"_id\":ObjectId(id)})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getProducts",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getEmployees",
    value: Code("function ()\r\n    { \r\n        return db.Employees.find({}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "UpdateProducts",
    value: Code("function (id,tenHang,gia,danhMuc)\r\n    {  \r\n        db.loadServerScripts();\r\n        return db.Products.updateOne({_id:ObjectId(id)},{ $set: {TenHang:tenHang , Gia: gia,DanhMuc:danhMuc}})\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "UpdateEmployees",
    value: Code("function (id,tennv,ngaysinh,diachi,sdt,soThe)\r\n    {  \r\n           db.loadServerScripts();\r\n        return db.Employees.updateOne({_id:ObjectId(id)},{ $set: {TenNV:tennv , NgaySinh: ISODate(ngaysinh),DiaChi:diachi,DienThoai:NumberLong(sdt),soThe:soThe}})\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getNuocUong",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({DanhMuc:\"Nước Uống\"}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getSanPhamKhac",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({DanhMuc:\"Sản Phẩm Khác\"}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getProductsName",
    value: Code("function (tenhang)\r\n    { \r\n        return db.Products.findOne({TenHang:tenhang});\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getTable",
    value: Code("function ()\r\n    { \r\n        return db.Table.find().toArray();\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "RemoveTable",
    value: Code("function (tenban){\r\n        db.loadServerScripts();\r\n        return db.Table.remove({\"TenBan\":tenban})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertTable",
    value: Code("function (tenBan,SoCho)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Table.insert({\"TenBan\":tenBan,\r\n            \"SoCho\":NumberLong(SoCho),\r\n            \"TinhTrang\":true\r\n        })\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "UpdateTable",
    value: Code("function (id,tenban,socho,tinhtrang)\r\n    {  \r\n        db.loadServerScripts();\r\n        if(tinhtrang==\"True\")\r\n            return db.Table.updateOne({_id:ObjectId(id)},{ $set: {TenBan:tenban,SoCho:NumberLong(socho),TinhTrang:true}});\r\n            else\r\n                return db.Table.updateOne({_id:ObjectId(id)},{ $set: {TenBan:tenban,SoCho:NumberLong(socho),TinhTrang:false}});\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertOrder",
    value: Code("function (tenban,soHoaDon,khachHang,phucvu,tenSanPham,gia,thoigian){\r\n        return db.OrderDrink.insert({\"tenBan\":tenban,\"soHoaDon\":NumberLong(soHoaDon),\"khachHang\":khachHang,\"phucVu\":phucvu,\"tenSanPham\":tenSanPham,\"gia\":gia,\"thoiGian\":thoigian})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getCustomer",
    value: Code("function ()\r\n    { \r\n        return db.Customer.find({}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertCustomer",
    value: Code("function (HoTen,tuoi,dienThoai,DiaChi,maGiamGia)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Customer.insert({\"HoTen\":HoTen,\r\n            \"tuoi\":NumberLong(tuoi),\r\n            \"dienThoai\":NumberLong(dienThoai),\r\n            \"DiaChi\":DiaChi,\r\n            \"maGiamGia\":maGiamGia,\r\n           })\r\n        \r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "RemoveCustomer",
    value: Code("function (id)\r\n    {\r\n       \r\n        db.loadServerScripts();\r\n        return db.Customer.remove({\"_id\":ObjectId(id)})\r\n       \r\n        \r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "UpdateCustomer",
    value: Code("function (id,hoten,tuoi,dienthoai,diachi,magiamgia)\r\n    {  \r\n           db.loadServerScripts();\r\n        return db.Customer.updateOne({_id:ObjectId(id)},{ $set: {HoTen:hoten , tuoi:NumberLong(tuoi),dienThoai:NumberLong(dienthoai),\r\n            DiaChi:diachi,maGiamGia:magiamgia}})\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getOrderM",
    value: Code("function (hoten)\r\n    { \r\n        return db.Customer.findOne({HoTen:hoten});\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "thongKeHoaDon",
    value: Code("function (thoigian)\r\n    { \r\n        return db.OrderDrink.find({thoiGian:thoigian}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "CreateUser",
    value: Code("function (_name,_pass,_role)\r\n    {\r\n        var user = {\r\n  'user' : _name,\r\n  'pwd' : _pass,\r\n  'roles' : [\r\n      {'role' : _role, 'db' : 'QuanLyQuanCaPhe'}\r\n  ],\r\n       mechanisms:[  \r\n  \"SCRAM-SHA-1\"\r\n ]\r\n}\r\n\r\nreturn db.createUser(user);\r\n\r\n    }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "getAccount",
    value: Code("function ()\r\n    { \r\n        return db.UserAccount.find({}).toArray();\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "insertAccount",
    value: Code("function (tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.UserAccount.insert({\"tenNV\":tenNV,\r\n            \"taiKhoan\":tenTK,\r\n            \"matKhau\":mk\r\n        })\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "InsertAccount",
    value: Code("function (tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        CreateUser(tenTK,mk,\"Employees\");\r\n        return db.UserAccount.insert({\"tenNV\":tenNV,\r\n            \"taiKhoan\":tenTK,\r\n            \"matKhau\":mk\r\n        })\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "DropUser",
    value: Code("function (name)\r\n    {\r\n        db.dropUser(name);\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "RemoveAccount",
    value: Code("function (id,name)\r\n    {\r\n        db.loadServerScripts();\r\n        DropUser(name);\r\n        \r\n         return db.UserAccount.remove({\"_id\":ObjectId(id)})\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "ChangeAccount",
    value: Code("function (_name,_pass)\r\n    {\r\n        db.loadServerScripts();\r\n           DropUser(_name); \r\n            CreateUser(_name,_pass,\"Employees\");\r\n        }")
} ]);
db.getCollection("system.js").insert([ {
    _id: "UpdateUser",
    value: Code("function (id,tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        ChangeAccount(tenTK,mk);\r\n        return db.UserAccount.updateOne({_id:ObjectId(id)},{ $set: {tenNV:tenNV , taiKhoan: tenTK,matKhau:mk}})\r\n        }")
} ]);

// ----------------------------
// Function structure for ChangeAccount
// ----------------------------
db.system.js.deleteOne({
    _id: "ChangeAccount"
});
delimiter ;;
db.system.js.insert({
    _id: "ChangeAccount",
    value: Code("function (_name,_pass)\r\n    {\r\n        db.loadServerScripts();\r\n           DropUser(_name); \r\n            CreateUser(_name,_pass,\"Employees\");\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for CountEmployees
// ----------------------------
db.system.js.deleteOne({
    _id: "CountEmployees"
});
delimiter ;;
db.system.js.insert({
    _id: "CountEmployees",
    value: Code("function ()\r\n    {\r\n        return db.getCollection('Employees').find({}).count();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for CreateUser
// ----------------------------
db.system.js.deleteOne({
    _id: "CreateUser"
});
delimiter ;;
db.system.js.insert({
    _id: "CreateUser",
    value: Code("function (_name,_pass,_role)\r\n    {\r\n        var user = {\r\n  'user' : _name,\r\n  'pwd' : _pass,\r\n  'roles' : [\r\n      {'role' : _role, 'db' : 'QuanLyQuanCaPhe'}\r\n  ],\r\n       mechanisms:[  \r\n  \"SCRAM-SHA-1\"\r\n ]\r\n}\r\n\r\nreturn db.createUser(user);\r\n\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for DropUser
// ----------------------------
db.system.js.deleteOne({
    _id: "DropUser"
});
delimiter ;;
db.system.js.insert({
    _id: "DropUser",
    value: Code("function (name)\r\n    {\r\n        db.dropUser(name);\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertAccount
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertAccount"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertAccount",
    value: Code("function (tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        CreateUser(tenTK,mk,\"Employees\");\r\n        return db.UserAccount.insert({\"tenNV\":tenNV,\r\n            \"taiKhoan\":tenTK,\r\n            \"matKhau\":mk\r\n        })\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertCustomer
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertCustomer"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertCustomer",
    value: Code("function (HoTen,tuoi,dienThoai,DiaChi,maGiamGia)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Customer.insert({\"HoTen\":HoTen,\r\n            \"tuoi\":NumberLong(tuoi),\r\n            \"dienThoai\":NumberLong(dienThoai),\r\n            \"DiaChi\":DiaChi,\r\n            \"maGiamGia\":maGiamGia,\r\n           })\r\n        \r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertEmployees
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertEmployees"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertEmployees",
    value: Code("function (tennv,ngaysinh,diachi,dienthoai,soThe)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Employees.insert({\"TenNV\":tennv,\r\n            \"NgaySinh\":ISODate(ngaysinh),\r\n            \"DiaChi\":diachi,\r\n            \"DienThoai\":NumberLong(dienthoai),\r\n            \"soThe\":soThe})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertOrder
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertOrder"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertOrder",
    value: Code("function (tenban,soHoaDon,khachHang,phucvu,tenSanPham,gia,thoigian){\r\n        return db.OrderDrink.insert({\"tenBan\":tenban,\"soHoaDon\":NumberLong(soHoaDon),\"khachHang\":khachHang,\"phucVu\":phucvu,\"tenSanPham\":tenSanPham,\"gia\":gia,\"thoiGian\":thoigian})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertProducts
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertProducts"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertProducts",
    value: Code("function (tenHang,Gia,DanhMuc)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Products.insert({\"TenHang\":tenHang,\r\n            \"Gia\":Gia,\r\n            \"DanhMuc\":DanhMuc\r\n        })\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for InsertTable
// ----------------------------
db.system.js.deleteOne({
    _id: "InsertTable"
});
delimiter ;;
db.system.js.insert({
    _id: "InsertTable",
    value: Code("function (tenBan,SoCho)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.Table.insert({\"TenBan\":tenBan,\r\n            \"SoCho\":NumberLong(SoCho),\r\n            \"TinhTrang\":true\r\n        })\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for RemoveAccount
// ----------------------------
db.system.js.deleteOne({
    _id: "RemoveAccount"
});
delimiter ;;
db.system.js.insert({
    _id: "RemoveAccount",
    value: Code("function (id,name)\r\n    {\r\n        db.loadServerScripts();\r\n        DropUser(name);\r\n        \r\n         return db.UserAccount.remove({\"_id\":ObjectId(id)})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for RemoveCustomer
// ----------------------------
db.system.js.deleteOne({
    _id: "RemoveCustomer"
});
delimiter ;;
db.system.js.insert({
    _id: "RemoveCustomer",
    value: Code("function (id)\r\n    {\r\n       \r\n        db.loadServerScripts();\r\n        return db.Customer.remove({\"_id\":ObjectId(id)})\r\n       \r\n        \r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for RemoveEmployees
// ----------------------------
db.system.js.deleteOne({
    _id: "RemoveEmployees"
});
delimiter ;;
db.system.js.insert({
    _id: "RemoveEmployees",
    value: Code("function (id){\r\n        db.loadServerScripts();\r\n        return db.Employees.remove({\"_id\":ObjectId(id)})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for RemoveProducts
// ----------------------------
db.system.js.deleteOne({
    _id: "RemoveProducts"
});
delimiter ;;
db.system.js.insert({
    _id: "RemoveProducts",
    value: Code("function (id){\r\n        db.loadServerScripts();\r\n        return db.Products.remove({\"_id\":ObjectId(id)})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for RemoveTable
// ----------------------------
db.system.js.deleteOne({
    _id: "RemoveTable"
});
delimiter ;;
db.system.js.insert({
    _id: "RemoveTable",
    value: Code("function (tenban){\r\n        db.loadServerScripts();\r\n        return db.Table.remove({\"TenBan\":tenban})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for UpdateCustomer
// ----------------------------
db.system.js.deleteOne({
    _id: "UpdateCustomer"
});
delimiter ;;
db.system.js.insert({
    _id: "UpdateCustomer",
    value: Code("function (id,hoten,tuoi,dienthoai,diachi,magiamgia)\r\n    {  \r\n           db.loadServerScripts();\r\n        return db.Customer.updateOne({_id:ObjectId(id)},{ $set: {HoTen:hoten , tuoi:NumberLong(tuoi),dienThoai:NumberLong(dienthoai),\r\n            DiaChi:diachi,maGiamGia:magiamgia}})\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for UpdateEmployees
// ----------------------------
db.system.js.deleteOne({
    _id: "UpdateEmployees"
});
delimiter ;;
db.system.js.insert({
    _id: "UpdateEmployees",
    value: Code("function (id,tennv,ngaysinh,diachi,sdt,soThe)\r\n    {  \r\n           db.loadServerScripts();\r\n        return db.Employees.updateOne({_id:ObjectId(id)},{ $set: {TenNV:tennv , NgaySinh: ISODate(ngaysinh),DiaChi:diachi,DienThoai:NumberLong(sdt),soThe:soThe}})\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for UpdateProducts
// ----------------------------
db.system.js.deleteOne({
    _id: "UpdateProducts"
});
delimiter ;;
db.system.js.insert({
    _id: "UpdateProducts",
    value: Code("function (id,tenHang,gia,danhMuc)\r\n    {  \r\n        db.loadServerScripts();\r\n        return db.Products.updateOne({_id:ObjectId(id)},{ $set: {TenHang:tenHang , Gia: gia,DanhMuc:danhMuc}})\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for UpdateTable
// ----------------------------
db.system.js.deleteOne({
    _id: "UpdateTable"
});
delimiter ;;
db.system.js.insert({
    _id: "UpdateTable",
    value: Code("function (id,tenban,socho,tinhtrang)\r\n    {  \r\n        db.loadServerScripts();\r\n        if(tinhtrang==\"True\")\r\n            return db.Table.updateOne({_id:ObjectId(id)},{ $set: {TenBan:tenban,SoCho:NumberLong(socho),TinhTrang:true}});\r\n            else\r\n                return db.Table.updateOne({_id:ObjectId(id)},{ $set: {TenBan:tenban,SoCho:NumberLong(socho),TinhTrang:false}});\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for UpdateUser
// ----------------------------
db.system.js.deleteOne({
    _id: "UpdateUser"
});
delimiter ;;
db.system.js.insert({
    _id: "UpdateUser",
    value: Code("function (id,tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        ChangeAccount(tenTK,mk);\r\n        return db.UserAccount.updateOne({_id:ObjectId(id)},{ $set: {tenNV:tenNV , taiKhoan: tenTK,matKhau:mk}})\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getAccount
// ----------------------------
db.system.js.deleteOne({
    _id: "getAccount"
});
delimiter ;;
db.system.js.insert({
    _id: "getAccount",
    value: Code("function ()\r\n    { \r\n        return db.UserAccount.find({}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getCustomer
// ----------------------------
db.system.js.deleteOne({
    _id: "getCustomer"
});
delimiter ;;
db.system.js.insert({
    _id: "getCustomer",
    value: Code("function ()\r\n    { \r\n        return db.Customer.find({}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getEmployees
// ----------------------------
db.system.js.deleteOne({
    _id: "getEmployees"
});
delimiter ;;
db.system.js.insert({
    _id: "getEmployees",
    value: Code("function ()\r\n    { \r\n        return db.Employees.find({}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getNuocUong
// ----------------------------
db.system.js.deleteOne({
    _id: "getNuocUong"
});
delimiter ;;
db.system.js.insert({
    _id: "getNuocUong",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({DanhMuc:\"Nước Uống\"}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getOrderM
// ----------------------------
db.system.js.deleteOne({
    _id: "getOrderM"
});
delimiter ;;
db.system.js.insert({
    _id: "getOrderM",
    value: Code("function (hoten)\r\n    { \r\n        return db.Customer.findOne({HoTen:hoten});\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getProducts
// ----------------------------
db.system.js.deleteOne({
    _id: "getProducts"
});
delimiter ;;
db.system.js.insert({
    _id: "getProducts",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getProductsName
// ----------------------------
db.system.js.deleteOne({
    _id: "getProductsName"
});
delimiter ;;
db.system.js.insert({
    _id: "getProductsName",
    value: Code("function (tenhang)\r\n    { \r\n        return db.Products.findOne({TenHang:tenhang});\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getSanPhamKhac
// ----------------------------
db.system.js.deleteOne({
    _id: "getSanPhamKhac"
});
delimiter ;;
db.system.js.insert({
    _id: "getSanPhamKhac",
    value: Code("function ()\r\n    { \r\n        return db.Products.find({DanhMuc:\"Sản Phẩm Khác\"}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for getTable
// ----------------------------
db.system.js.deleteOne({
    _id: "getTable"
});
delimiter ;;
db.system.js.insert({
    _id: "getTable",
    value: Code("function ()\r\n    { \r\n        return db.Table.find().toArray();\r\n    }")
})
;;
delimiter ;

// ----------------------------
// Function structure for insertAccount
// ----------------------------
db.system.js.deleteOne({
    _id: "insertAccount"
});
delimiter ;;
db.system.js.insert({
    _id: "insertAccount",
    value: Code("function (tenNV,tenTK,mk)\r\n    {\r\n        db.loadServerScripts();\r\n        return db.UserAccount.insert({\"tenNV\":tenNV,\r\n            \"taiKhoan\":tenTK,\r\n            \"matKhau\":mk\r\n        })\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for sapxep
// ----------------------------
db.system.js.deleteOne({
    _id: "sapxep"
});
delimiter ;;
db.system.js.insert({
    _id: "sapxep",
    value: Code("function (){\r\n       return  db.getCollection('Hang').find({}).sort({\r\n    \"Gia\":1.0\r\n    });\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for thongKeHoaDon
// ----------------------------
db.system.js.deleteOne({
    _id: "thongKeHoaDon"
});
delimiter ;;
db.system.js.insert({
    _id: "thongKeHoaDon",
    value: Code("function (thoigian)\r\n    { \r\n        return db.OrderDrink.find({thoiGian:thoigian}).toArray();\r\n        }")
})
;;
delimiter ;

// ----------------------------
// Function structure for tinhtong
// ----------------------------
db.system.js.deleteOne({
    _id: "tinhtong"
});
delimiter ;;
db.system.js.insert({
    _id: "tinhtong",
    value: Code("function tong(a,b)\r\n    {\r\n        return a+b;\r\n        }")
})
;;
delimiter ;
