/*
SQLyog Community v12.2.0 (64 bit)
MySQL - 5.7.19 : Database - emsp_db
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`emsp_db` /*!40100 DEFAULT CHARACTER SET ascii COLLATE ascii_bin */;

USE `emsp_db`;

/*Table structure for table `jurusan` */

DROP TABLE IF EXISTS `jurusan`;

CREATE TABLE `jurusan` (
  `id_jurusan` char(2) COLLATE ascii_bin NOT NULL,
  `nama_jurusan` varchar(25) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `jurusan` */

/*Table structure for table `mahasiswa` */

DROP TABLE IF EXISTS `mahasiswa`;

CREATE TABLE `mahasiswa` (
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `nama_depan` varchar(20) COLLATE ascii_bin NOT NULL,
  `nama_belakang` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `tempat_lahir` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `alamat` varchar(100) COLLATE ascii_bin DEFAULT NULL,
  `id_jurusan` char(2) COLLATE ascii_bin NOT NULL,
  `angkatan` int(4) NOT NULL,
  PRIMARY KEY (`id_mahasiswa`),
  KEY `fk_id_jurusan_m` (`id_jurusan`),
  CONSTRAINT `fk_id_jurusan_m` FOREIGN KEY (`id_jurusan`) REFERENCES `jurusan` (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `mahasiswa` */

/*Table structure for table `matkul` */

DROP TABLE IF EXISTS `matkul`;

CREATE TABLE `matkul` (
  `id_matkul` varchar(6) COLLATE ascii_bin NOT NULL,
  `nama_matkul` varchar(25) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `matkul` */

/*Table structure for table `mahasiswa_absen` */

DROP TABLE IF EXISTS `mahasiswa_absen`;

CREATE TABLE `mahasiswa_absen` (
  `id_absen` char(6) COLLATE ascii_bin NOT NULL,
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `id_matkul` varchar(6) COLLATE ascii_bin NOT NULL,
  `tanggal` date DEFAULT NULL,
  `jam_masuk` time DEFAULT NULL,
  `jam_keluar` time DEFAULT NULL,
  PRIMARY KEY (`id_absen`),
  KEY `fk_id_mahasiswa_ma` (`id_mahasiswa`),
  KEY `fk_id_matkul_ma` (`id_matkul`),
  CONSTRAINT `fk_id_mahasiswa_ma` FOREIGN KEY (`id_mahasiswa`) REFERENCES `mahasiswa` (`id_mahasiswa`),
  CONSTRAINT `fk_id_matkul_ma` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `mahasiswa_absen` */

/*Table structure for table `mahasiswa_kehadiran` */

DROP TABLE IF EXISTS `mahasiswa_kehadiran`;

CREATE TABLE `mahasiswa_kehadiran` (
  `id_kehadiran` char(6) COLLATE ascii_bin NOT NULL,
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `id_matkul` varchar(6) COLLATE ascii_bin NOT NULL,
  `kehadiran` int(2) DEFAULT '0',
  PRIMARY KEY (`id_kehadiran`),
  KEY `fk_id_mahasiswa_mk` (`id_mahasiswa`),
  KEY `fk_id_matkul_mk` (`id_matkul`),
  CONSTRAINT `fk_id_mahasiswa_mk` FOREIGN KEY (`id_mahasiswa`) REFERENCES `mahasiswa` (`id_mahasiswa`),
  CONSTRAINT `fk_id_matkul_mk` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `mahasiswa_kehadiran` */

/*Table structure for table `mahasiswa_matkul` */

DROP TABLE IF EXISTS `mahasiswa_matkul`;

CREATE TABLE `mahasiswa_matkul` (
  `id_ambil` char(6) COLLATE ascii_bin NOT NULL,
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `id_matkul` varchar(6) COLLATE ascii_bin NOT NULL,
  `nilai_tugas_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_tugas_praktek` int(3) DEFAULT '0',
  `nilai_uts_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_uts_praktek` int(3) DEFAULT '0',
  `nilai_uas_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_uas_praktek` int(3) DEFAULT '0',
  PRIMARY KEY (`id_ambil`),
  KEY `fk_id_mahasiswa_mm` (`id_mahasiswa`),
  KEY `fk_id_matkul_mm` (`id_matkul`),
  CONSTRAINT `fk_id_mahasiswa_mm` FOREIGN KEY (`id_mahasiswa`) REFERENCES `mahasiswa` (`id_mahasiswa`),
  CONSTRAINT `fk_id_matkul_mm` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

/*Data for the table `mahasiswa_matkul` */


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
