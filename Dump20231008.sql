CREATE DATABASE  IF NOT EXISTS `employeems` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_bin */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `employeems`;
-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: employeems
-- ------------------------------------------------------
-- Server version	8.0.34

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bangcongnhanviencoban`
--

DROP TABLE IF EXISTS `bangcongnhanviencoban`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bangcongnhanviencoban` (
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `phuCapKhac` int DEFAULT NULL,
  `thuong` int DEFAULT NULL,
  `kyLuat` int DEFAULT NULL,
  `thang` int DEFAULT NULL,
  `nam` int DEFAULT NULL,
  `soNgayCong` int DEFAULT NULL,
  `soNgayNghi` int DEFAULT NULL,
  `soGioLamThem` int DEFAULT NULL,
  `luong` decimal(15,2) DEFAULT NULL,
  `ghiChu` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maLuong` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maNV`),
  KEY `Fk.BangCongNhanVienCoBan_TTNVCoBan_idx` (`maNV`),
  KEY `Fk.BangCongNhanVienCoBan_idx` (`maLuong`),
  CONSTRAINT `Fk.BangCongNhanVienCoBan` FOREIGN KEY (`maLuong`) REFERENCES `bangluongcty` (`maLuong`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk.BangCongNhanVienCoBan_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bangcongnhanviencoban`
--

LOCK TABLES `bangcongnhanviencoban` WRITE;
/*!40000 ALTER TABLE `bangcongnhanviencoban` DISABLE KEYS */;
INSERT INTO `bangcongnhanviencoban` VALUES ('nv1',5000000,1500000,100000,4,2023,23,0,24,20060000.00,NULL,'ml3'),('nv10',3000000,100000,0,3,2023,21,2,12,15480000.00,NULL,'ml3'),('nv11',1000000,100000,200000,3,2023,24,3,12,14480000.00,'','ml3'),('nv2',5000000,200000,0,3,2023,21,2,12,14560000.00,NULL,'ml2'),('nv3',5000000,100000,500000,3,2023,20,2,12,16580000.00,NULL,'ml3'),('nv4',3500000,2000000,0,3,2023,24,2,12,19080000.00,NULL,'ml3'),('nv5',2500000,400000,100000,3,2023,26,2,14,13640000.00,'','ml2'),('nv6',2000000,500000,0,3,2023,23,2,12,9580000.00,NULL,'ml1'),('nv7',2500000,600000,0,3,2023,24,2,12,10380000.00,NULL,'ml1'),('nv8',3000000,500000,0,3,2023,20,2,12,9980000.00,NULL,'ml1'),('nv9',6000000,400000,100000,3,2023,26,2,14,17140000.00,'','ml2');
/*!40000 ALTER TABLE `bangcongnhanviencoban` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bangcongnhanviencoban_luong_insert_trigger` BEFORE INSERT ON `bangcongnhanviencoban` FOR EACH ROW BEGIN
  DECLARE luongCB INT;
  DECLARE phuCapCV INT;
  SELECT luongCoBan INTO luongCB FROM employeems.bangluongcty WHERE maLuong = NEW.maLuong;
  SELECT phuCapChucVu INTO phuCapCV FROM employeems.bangluongcty WHERE maLuong = NEW.maLuong;
  SET NEW.luong = (luongCB/25)*NEW.soNgayCong + NEW.soGioLamThem*40000 + phuCapCV + NEW.phuCapKhac + NEW.thuong - NEW.kyLuat;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bangcongnhanviencoban_phucapthaisan_trigger` BEFORE INSERT ON `bangcongnhanviencoban` FOR EACH ROW BEGIN
    IF 
    (SELECT COUNT(*) 
	FROM employeems.thaisan
	WHERE maNV = new.maNV AND DATE(CONCAT(New.nam, '-', new.thang, '-28')) BETWEEN ngayNghiSinh AND ngayTroLaiLam) > 0
    THEN	
    BEGIN
		SELECT troCapCongTy INTO @phuCapThaiSan
		FROM employeems.thaisan
		WHERE maNV = NEW.maNV;
        IF NEW.phuCapKhac < @phuCapThaiSan THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Giá trị phụ cấp nhỏ hơn phụ cấp thai sản.';
		END IF;
	END;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bangcongnhanviencoban_luong_update_trigger` BEFORE UPDATE ON `bangcongnhanviencoban` FOR EACH ROW BEGIN
  DECLARE luongCB INT;
  DECLARE phuCapCV INT;
  SELECT luongCoBan INTO luongCB FROM employeems.bangluongcty WHERE maLuong = NEW.maLuong;
  SELECT phuCapChucVu INTO phuCapCV FROM employeems.bangluongcty WHERE maLuong = NEW.maLuong;
  SET NEW.luong = (luongCB/25)*NEW.soNgayCong + NEW.soGioLamThem*40000 + phuCapCV + NEW.phuCapKhac + NEW.thuong - NEW.kyLuat;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `bangcongnhanviencoban_phucapthaisan_update_trigger` BEFORE UPDATE ON `bangcongnhanviencoban` FOR EACH ROW BEGIN
    IF 
    (SELECT COUNT(*) 
	FROM employeems.thaisan
	WHERE maNV = new.maNV AND DATE(CONCAT(New.nam, '-', new.thang, '-28')) BETWEEN ngayNghiSinh AND ngayTroLaiLam) > 0
    THEN	
    BEGIN
		SELECT troCapCongTy INTO @phuCapThaiSan
		FROM employeems.thaisan
		WHERE maNV = NEW.maNV;
        IF NEW.phuCapKhac < @phuCapThaiSan THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Giá trị phụ cấp nhỏ hơn phụ cấp thai sản.';
		END IF;
	END;
    END IF;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `bangluongcty`
--

DROP TABLE IF EXISTS `bangluongcty`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bangluongcty` (
  `maLuong` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `luongCoBan` int DEFAULT NULL,
  `ngayNhap` datetime DEFAULT NULL,
  `ghiChu` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `chucVu` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `phuCapChucVu` int DEFAULT NULL,
  PRIMARY KEY (`maLuong`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bangluongcty`
--

LOCK TABLES `bangluongcty` WRITE;
/*!40000 ALTER TABLE `bangluongcty` DISABLE KEYS */;
INSERT INTO `bangluongcty` VALUES ('ml1',5000000,'2023-09-23 00:00:00','','Chuyên viên IT',2000000),('ml2',7000000,'2023-08-24 00:00:00','','Chuyên viên IT',3000000),('ml3',10000000,'2023-10-23 00:00:00','','Chuyên viên CSKH',3500000);
/*!40000 ALTER TABLE `bangluongcty` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `baocaotinhtrangnhansu`
--

DROP TABLE IF EXISTS `baocaotinhtrangnhansu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `baocaotinhtrangnhansu` (
  `tongSoNV` int NOT NULL,
  `ngayTaoBaoCao` datetime DEFAULT NULL,
  `thang` int DEFAULT NULL,
  `nam` int DEFAULT NULL,
  `soNVRoiToChuc` int NOT NULL,
  `maBaoCao` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `maPhong` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`maBaoCao`),
  KEY `Fk.BaoCaoTinhTrangNhanSu_PhongBan_idx` (`maPhong`),
  CONSTRAINT `Fk.BaoCaoTinhTrangNhanSu_PhongBan` FOREIGN KEY (`maPhong`) REFERENCES `phongban` (`maPhong`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baocaotinhtrangnhansu`
--

LOCK TABLES `baocaotinhtrangnhansu` WRITE;
/*!40000 ALTER TABLE `baocaotinhtrangnhansu` DISABLE KEYS */;
INSERT INTO `baocaotinhtrangnhansu` VALUES (1,'2023-10-02 09:31:55',10,2023,1,'bc1','p1'),(1,'2023-10-02 09:32:04',10,2023,1,'bc2','p2'),(1,'2023-10-02 09:32:16',10,2023,0,'bc3','p9');
/*!40000 ALTER TABLE `baocaotinhtrangnhansu` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `baocaotinhtrangnhansu_insert_trigger` BEFORE INSERT ON `baocaotinhtrangnhansu` FOR EACH ROW BEGIN
    SET NEW.ngayTaoBaoCao = NOW();
    SET NEW.thang = MONTH(NOW());
    SET NEW.nam = YEAR(NOW());
    
    SELECT COUNT(*) INTO @tongSoNV
    FROM employeems.ttnvcoban
    WHERE maPhong = NEW.maPhong;

    SET NEW.tongSoNV = @tongSoNV;

    SELECT COUNT(*) INTO @soNVRoiToChuc
    FROM employeems.nvroitochuc
    WHERE MONTH(ngayRoi) = NEW.thang AND YEAR(ngayRoi) = NEW.nam AND new.maPhong = maPhong;
    
    SET NEW.soNVRoiToChuc = @soNVRoiToChuc;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `baohiem`
--

DROP TABLE IF EXISTS `baohiem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `baohiem` (
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `loaiBaoHiem` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maBaoHiem` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ngayCap` date DEFAULT NULL,
  `noiCap` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ghiChu` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ngayKetThuc` date DEFAULT NULL,
  `maSoBH` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maBaoHiem`),
  KEY `Fk.BaoHiem_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.BaoHiem_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `baohiem`
--

LOCK TABLES `baohiem` WRITE;
/*!40000 ALTER TABLE `baohiem` DISABLE KEYS */;
INSERT INTO `baohiem` VALUES ('nv1','Bảo Hiểm Lao Động xác định','bh1','2022-12-09','Gia Lai',NULL,'2023-12-09','325426'),('nv5','Bảo Hiểm Lao Động','bh2','2021-03-21','Bình Định',NULL,'2022-03-27','433266'),('nv2','Bảo Hiểm Lao Động xác định','bh3','2023-03-12','Gia Lâm',NULL,'2024-03-11','434277');
/*!40000 ALTER TABLE `baohiem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `bophan`
--

DROP TABLE IF EXISTS `bophan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bophan` (
  `maBoPhan` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin NOT NULL,
  `tenBoPhan` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `ngayThanhLap` date DEFAULT NULL,
  `ghiChu` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maBoPhan`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bophan`
--

LOCK TABLES `bophan` WRITE;
/*!40000 ALTER TABLE `bophan` DISABLE KEYS */;
INSERT INTO `bophan` VALUES ('bp1','Phát triển phần mềm','1995-06-23',NULL),('bp2','Hỗ trợ kỹ thuật và quản lý hạ tầng','1994-07-24',NULL),('bp3','Quản lý dự án và quản lý chất lượng','1995-06-23',NULL),('bp4','Phân tích dữ liệu và khoa học dữ liệu','1995-03-24',NULL);
/*!40000 ALTER TABLE `bophan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `hopdong`
--

DROP TABLE IF EXISTS `hopdong`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `hopdong` (
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `chucVu` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `thoiHanLamViec` int DEFAULT NULL,
  `ngayKiKet` date DEFAULT NULL,
  `ngayHetHan` date DEFAULT NULL,
  `maHopDong` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `loaiHopDong` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maHopDong`),
  KEY `Fk.HopDong_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.HopDong_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `hopdong`
--

LOCK TABLES `hopdong` WRITE;
/*!40000 ALTER TABLE `hopdong` DISABLE KEYS */;
INSERT INTO `hopdong` VALUES ('nv1','Chuyên viên PTYC',5,'2023-01-23','2028-01-01','hd1','Hợp đồng lao động xác định'),('nv10','Chuyên viên PTDL',4,'2023-01-23','2027-01-01','hd10','Hợp đồng lao động xác định'),('nv11','Chuyên viên KHDL',4,'2023-01-23','2027-01-01','hd11','Hợp đồng lao động xác định'),('nv2','Chuyên viên TKPM',5,'2023-01-23','2028-01-01','hd2','Hợp đồng lao động xác định'),('nv3','Chuyên viên PTPM',4,'2023-01-23','2027-01-01','hd3','Hợp đồng lao động xác định'),('nv4','Chuyên viên KTPM',4,'2023-01-23','2027-01-01','hd4','Hợp đồng lao động xác định'),('nv5','Chuyên viên QLCH',4,'2023-01-23','2027-01-01','hd5','Hợp đồng lao động xác định'),('nv6','Chuyên viên HTND',3,'2023-01-23','2026-01-01','hd6','Hợp đồng lao động xác định'),('nv7','Chuyên viên QLM',4,'2023-01-23','2027-01-01','hd7','Hợp đồng lao động xác định'),('nv8','Chuyên viên QLDA',4,'2023-01-23','2027-01-01','hd8','Hợp đồng lao động xác định'),('nv9','Chuyên viên QLCL',4,'2023-01-23','2027-01-01','hd9','Hợp đồng lao động xác định');
/*!40000 ALTER TABLE `hopdong` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `khoadaotao`
--

DROP TABLE IF EXISTS `khoadaotao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `khoadaotao` (
  `maKhoaDT` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `tenKhoaDT` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ngayBatDau` date DEFAULT NULL,
  `thoiGian` int DEFAULT NULL,
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tienDo` int DEFAULT NULL,
  `daHoanThanh` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`maKhoaDT`),
  KEY `Fk.KhoaDaoTao_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.KhoaDaoTao_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `khoadaotao`
--

LOCK TABLES `khoadaotao` WRITE;
/*!40000 ALTER TABLE `khoadaotao` DISABLE KEYS */;
INSERT INTO `khoadaotao` VALUES ('mkdt1','Quản lý Nhân sự tập trung','2023-04-20',60,'nv1',45,0),('mkdt2','Quản lý Phòng Ban','2023-03-15',30,'nv3',30,1),('mkdt3','Thực chiến marketing','2023-03-10',30,'nv4',17,0),('mkdt4','Thực chiến SEO','2023-04-15',30,'nv6',13,0),('mkdt5','Thực chiến SEO','2023-03-13',40,'nv2',14,0);
/*!40000 ALTER TABLE `khoadaotao` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `khoadaotao_insert_trigger` BEFORE INSERT ON `khoadaotao` FOR EACH ROW BEGIN
	SET New.daHoanThanh = 
    case 
    when new.tienDo < new.thoiGian then 0
    else 1
    end;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `khoadaotao_update_trigger` BEFORE UPDATE ON `khoadaotao` FOR EACH ROW BEGIN
	SET New.daHoanThanh = 
    case 
    when new.tienDo < new.thoiGian then 0
    else 1
    end;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `lichlamviec`
--

DROP TABLE IF EXISTS `lichlamviec`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `lichlamviec` (
  `maLichLamViec` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `thang` int DEFAULT NULL,
  `nam` int DEFAULT NULL,
  `ngayLamViec` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `gioVao` time DEFAULT NULL,
  `gioRa` time DEFAULT NULL,
  `caLamViec` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maLichLamViec`),
  KEY `Fk.LichLamViec_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.LichLamViec_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lichlamviec`
--

LOCK TABLES `lichlamviec` WRITE;
/*!40000 ALTER TABLE `lichlamviec` DISABLE KEYS */;
INSERT INTO `lichlamviec` VALUES ('llv1',4,2023,NULL,'07:30:00','16:30:00','1,2','nv1'),('llv10',2,2023,'13,18','07:30:00','11:30:00','1','nv2'),('llv11',1,2023,'15,18','07:30:00','11:35:00','1','nv3'),('llv12',6,2023,NULL,'07:30:00','11:30:00','1','nv11'),('llv2',5,2023,NULL,'07:30:00','11:30:00','1','nv4'),('llv3',6,2023,'17,19','07:30:00','11:30:00','1','nv2'),('llv4',7,2023,'17,18','07:30:00','11:30:00','1','nv5'),('llv5',7,2023,'17,20','07:30:00','11:30:00','1','nv6'),('llv6',7,2023,NULL,'07:30:00','11:30:00','1','nv7'),('llv7',8,2023,'17','07:30:00','11:30:00','1','nv8'),('llv8',9,2023,NULL,'07:30:00','11:30:00','1','nv9'),('llv9',6,2023,NULL,'07:30:00','11:30:00','1','nv10');
/*!40000 ALTER TABLE `lichlamviec` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nvroitochuc`
--

DROP TABLE IF EXISTS `nvroitochuc`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nvroitochuc` (
  `hoTen` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CMND` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ngayRoi` date DEFAULT NULL,
  `lyDo` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maPhong` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`CMND`),
  KEY `Fk.NVRoiToChuc_PhongBan_idx` (`maPhong`),
  CONSTRAINT `Fk.NVRoiToChuc_PhongBan` FOREIGN KEY (`maPhong`) REFERENCES `phongban` (`maPhong`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nvroitochuc`
--

LOCK TABLES `nvroitochuc` WRITE;
/*!40000 ALTER TABLE `nvroitochuc` DISABLE KEYS */;
INSERT INTO `nvroitochuc` VALUES ('Khanh','1234567890','2023-10-01','Lật đổ cty','p3'),('Bảo Long','234637858','2023-10-01','Lật đổ ElonMusk','p1'),('Hiền Hồ','657483949','2023-10-01','Lật đổ ElonMusk','p2');
/*!40000 ALTER TABLE `nvroitochuc` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `nvroitochuc_insert_trigger` BEFORE INSERT ON `nvroitochuc` FOR EACH ROW BEGIN
	DELETE FROM employeems.ttnvcoban WHERE CMND = NEW.CMND;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`root`@`localhost`*/ /*!50003 TRIGGER `nvroitochuc_update_trigger` BEFORE UPDATE ON `nvroitochuc` FOR EACH ROW BEGIN
	DELETE FROM employeems.ttnvcoban WHERE CMND = NEW.CMND;
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `phongban`
--

DROP TABLE IF EXISTS `phongban`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `phongban` (
  `maPhong` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `maBoPhan` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_bin DEFAULT NULL,
  `tenPhong` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ngayThanhLap` date DEFAULT NULL,
  `ghiChu` varchar(50) CHARACTER SET utf8mb3 COLLATE utf8mb3_general_ci DEFAULT NULL,
  PRIMARY KEY (`maPhong`),
  KEY `Fk_idx` (`maBoPhan`),
  CONSTRAINT `FkPhongBan_BoPhan` FOREIGN KEY (`maBoPhan`) REFERENCES `bophan` (`maBoPhan`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `phongban`
--

LOCK TABLES `phongban` WRITE;
/*!40000 ALTER TABLE `phongban` DISABLE KEYS */;
INSERT INTO `phongban` VALUES ('p1','bp1','Phân tích yêu cầu','1995-06-25',NULL),('p10','bp4','Phân tích dữ liệu','1995-09-24',NULL),('p11','bp4','Khoa học dữ liệu','1995-09-22',NULL),('p2','bp1','Thiết kế phần mềm','1996-06-24',NULL),('p3','bp1','Phát triển phần mềm','1995-07-23',NULL),('p4','bp1','Kiểm thử phần mềm','1995-04-25',NULL),('p5','bp1','Cấu hình quản lý','1995-05-23',NULL),('p6','bp2','Hỗ trợ người dùng','1996-04-25',NULL),('p7','bp2','Quản lý mạng','1995-07-12',NULL),('p8','bp3','Quản lý dự án','1995-12-23',NULL),('p9','bp3','Quản lý chất lượng','1996-11-25',NULL);
/*!40000 ALTER TABLE `phongban` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `quyen`
--

DROP TABLE IF EXISTS `quyen`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `quyen` (
  `maQuyen` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `tenQuyen` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`maQuyen`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `quyen`
--

LOCK TABLES `quyen` WRITE;
/*!40000 ALTER TABLE `quyen` DISABLE KEYS */;
INSERT INTO `quyen` VALUES ('mq1','ADMIN'),('mq2','USER'),('mq3','MANAGER');
/*!40000 ALTER TABLE `quyen` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `thaisan`
--

DROP TABLE IF EXISTS `thaisan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `thaisan` (
  `maNV` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ngayVeSom` date DEFAULT NULL,
  `ngayNghiSinh` date DEFAULT NULL,
  `ngayTroLaiLam` date DEFAULT NULL,
  `troCapCongTy` int DEFAULT NULL,
  `ghiChu` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maThaiSan` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `ngayTaoYeuCau` datetime DEFAULT NULL,
  PRIMARY KEY (`maThaiSan`),
  KEY `Fk.ThaiSan_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.ThaiSan_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `thaisan`
--

LOCK TABLES `thaisan` WRITE;
/*!40000 ALTER TABLE `thaisan` DISABLE KEYS */;
INSERT INTO `thaisan` VALUES ('nv2','2023-09-23','2023-09-25','2024-04-23',5000000,NULL,'ts1','2023-08-24 00:00:00'),('nv3','2023-07-29','2023-09-23','2024-03-19',5000000,NULL,'ts2','2023-06-29 00:00:00'),('nv9','2023-01-01','2023-02-25','2023-04-23',4000000,NULL,'ts3','2023-01-11 00:00:00');
/*!40000 ALTER TABLE `thaisan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ttcanhan`
--

DROP TABLE IF EXISTS `ttcanhan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ttcanhan` (
  `maNV` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hoTen` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `noiSinh` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `nguyenQuan` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `dCThuongTru` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `dcTamTru` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `sdt` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `danToc` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `tonGiao` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `quocTich` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `hocVan` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ghiChu` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `anhDaiDien` blob NOT NULL,
  PRIMARY KEY (`maNV`),
  CONSTRAINT `Fk.TTCaNhan_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ttcanhan`
--

LOCK TABLES `ttcanhan` WRITE;
/*!40000 ALTER TABLE `ttcanhan` DISABLE KEYS */;
INSERT INTO `ttcanhan` VALUES ('nv1','Nguyễn Đan','GiaLai','Bình Định','Bình Dương',NULL,'0332051115','Kinh',NULL,'Việt Nam','Đại học',NULL,''),('nv10','Ngọc Hữu','GiaLai','Bình Phước','Bình Dương',NULL,'1132051115','Kinh','Việt Nam','Phật giáo','Đại học',NULL,''),('nv11','Võ Tòng','Hà Nội','Lai Chấu','Bình Dương',NULL,'0332771115','Kinh',NULL,'Việt Nam','Đại học',NULL,''),('nv2','GiaHuy','Đồng Tháp','Thái Nguyên','Bình Dương',NULL,'0443251115','Kinh','Phật giáo','Việt Nam','Đại học',NULL,''),('nv3','Bảo Ngọc','Bến Tre','Bình Định','Bình Dương',NULL,'0332051115','Kinh',NULL,'Việt Nam','Đại học',NULL,''),('nv4','Thành Võ','Hồ Chí Minh','Bình Dương','Bình Dương',NULL,'43327761115','Kinh','Đạo giáo','Việt Nam','Đại học',NULL,''),('nv5','Ngọc Huy','Hà Nội','Ninh Bình','Bình Dương',NULL,'0332051235','Kinh',NULL,'Việt Nam','Đại học',NULL,''),('nv6','Gia Lâm','Thanh Hóa','Thái Nguyên','Bình Dương',NULL,'0337651115','Kinh','Phật giáo','Việt Nam','Đại học',NULL,''),('nv7','Tấn Trương','Bảo Lộc','Bình Định','Bình Dương',NULL,'0332098715','Kinh','Phật giáo','Việt Nam','Đại học',NULL,''),('nv8','Hồng Hinh','Thái Bình','Lâm Đồng','Bình Dương',NULL,'0662051115','Kinh',NULL,'Việt Nam','Đại học',NULL,''),('nv9','Bảo Trâm','GiaLai','Quãng Ngãi','Bình Dương',NULL,'0232051135','Kinh','Việt Nam','Kito giáo','Đại học',NULL,'');
/*!40000 ALTER TABLE `ttcanhan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `ttnvcoban`
--

DROP TABLE IF EXISTS `ttnvcoban`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ttnvcoban` (
  `maNV` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hoTen` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maPhong` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ngaySinh` date DEFAULT NULL,
  `gioiTinh` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `ttHonNhan` char(10) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `CMND` varchar(15) COLLATE utf8mb4_unicode_ci NOT NULL,
  `noiCap` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `chucVu` varchar(20) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`maNV`),
  UNIQUE KEY `CMND_UNIQUE` (`CMND`),
  KEY `Fk.ttnvCoBan_PhongBan_idx` (`maPhong`),
  CONSTRAINT `Fk.ttnvCoBan_PhongBan` FOREIGN KEY (`maPhong`) REFERENCES `phongban` (`maPhong`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ttnvcoban`
--

LOCK TABLES `ttnvcoban` WRITE;
/*!40000 ALTER TABLE `ttnvcoban` DISABLE KEYS */;
INSERT INTO `ttnvcoban` VALUES ('nv1','Nguyễn Đan','p1','2003-03-27','Nam','Độc thân','0327947368','GiaLai','Chuyên viên PTYC'),('nv10','Ngọc Hữu','p10','2002-12-04','Nam','Độc thân','9324747377','Sài Gòn','Chuyên viên PTDL'),('nv11','Võ Tòng','p11','2001-09-12','Nam','Độc thân','4378027477','Quảng Ninh','Chuyên viên KHDL'),('nv2','Gia Huy','p2','2005-12-23','Nam','Kết hôn','0365789412','GiaLai','Chuyên viên TKPM'),('nv3','Bảo Ngọc','p3','2004-06-28','Nữ','Kết hôn','0355789444','Hà Nội','Chuyên viên PTPM'),('nv4','Thành Võ','p4','2006-08-27','Nam','Độc thân','0327956842','Hà Nội','Chuyên viên KTPM'),('nv5','Ngọc Huy','p5','2002-11-23','Nam','Độc thân','0326644783','Hài Phòng','Chuyên viên CHQL'),('nv6','Gia Lâm','p6','2003-09-25','Nam','Độc thân','4784327777','Hải Dương','Chuyên viên HTND'),('nv7','Tấn Trương','p7','2002-06-22','Nữ','Kết hôn','8473872999','Ninh Bình','Chuyên viên QLM'),('nv8','Hồng Hinh','p8','2003-04-19','Nữ','Kết hôn','8473473778','Gia Lai','Chuyên viên QLDA'),('nv9','Bảo Trâm','p9','2003-01-15','Nữ','Độc thân','4672727466','Bình Dương','Chuyên viên QLCL');
/*!40000 ALTER TABLE `ttnvcoban` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `userName` varchar(50) COLLATE utf8mb4_unicode_ci NOT NULL,
  `pass` varchar(20) COLLATE utf8mb4_unicode_ci NOT NULL,
  `hoTen` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `maQuyen` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `idUser` char(10) COLLATE utf8mb4_unicode_ci NOT NULL,
  `maNV` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  PRIMARY KEY (`idUser`),
  UNIQUE KEY `userName_UNIQUE` (`userName`),
  KEY `Fk.User_Quyen_idx` (`maQuyen`),
  KEY `Fk.User_TTNVCoBan_idx` (`maNV`),
  CONSTRAINT `Fk.User_Quyen` FOREIGN KEY (`maQuyen`) REFERENCES `quyen` (`maQuyen`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `Fk.User_TTNVCoBan` FOREIGN KEY (`maNV`) REFERENCES `ttnvcoban` (`maNV`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('admin','123','Nguyễn Đan','mq1','us1','nv1'),('user','123','Gia Huy','mq2','us2','nv2'),('manager','123','Bảo Ngọc','mq3','us3','nv3');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'employeems'
--

--
-- Dumping routines for database 'employeems'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-08 19:50:57
