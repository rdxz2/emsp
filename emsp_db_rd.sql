-- Adminer 4.3.1 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `dosen`;
CREATE TABLE `dosen` (
  `id_dosen` char(6) COLLATE ascii_bin NOT NULL,
  `nama` varchar(50) COLLATE ascii_bin NOT NULL,
  `jenis_kelamin` enum('Pria','Wanita') COLLATE ascii_bin NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `tempat_lahir` varchar(20) COLLATE ascii_bin NOT NULL,
  `email` varchar(50) COLLATE ascii_bin NOT NULL,
  `hp` varchar(20) COLLATE ascii_bin NOT NULL,
  `password` varchar(32) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `dosen` (`id_dosen`, `nama`, `jenis_kelamin`, `tanggal_lahir`, `tempat_lahir`, `email`, `hp`, `password`) VALUES
('D00001',	'Suprapto Nugroho',	'Pria',	'1978-12-23',	'Blitar',	'suprapto@dosen.uni.ac.id',	'08179909828',	'beb204ded84ba984ee5b74f4f4bcf9f2'),
('D00002',	'Himawan',	'Pria',	'1984-07-18',	'Jakarta',	'himawan@dosen.uni.ac.id',	'081623829052',	'3cb98ad580672180da39966691467300'),
('D00003',	'Heri Heru',	'Pria',	'1972-09-12',	'Palembang',	'heri@dosen.uni.ac.id',	'085719571023',	'6812af90c6a1bbec134e323d7e70587b'),
('D00004',	'Devianti',	'Wanita',	'1972-09-12',	'Tangerang',	'devianti@dosen.uni.ac.id',	'089790923312',	'911729b7003cad6def2d241b2ff8882f');

DROP TABLE IF EXISTS `dosen_matkul`;
CREATE TABLE `dosen_matkul` (
  `id_ambildosen` char(6) CHARACTER SET latin1 NOT NULL,
  `id_dosen` char(6) CHARACTER SET latin1 NOT NULL,
  `id_matkul` char(6) CHARACTER SET latin1 NOT NULL,
  PRIMARY KEY (`id_ambildosen`),
  KEY `fk_id_dosen_dm` (`id_dosen`),
  KEY `fk_id_matkul_dm` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;


DROP TABLE IF EXISTS `jurusan`;
CREATE TABLE `jurusan` (
  `id_jurusan` char(3) COLLATE ascii_bin NOT NULL,
  `nama_jurusan` varchar(25) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `jurusan` (`id_jurusan`, `nama_jurusan`) VALUES
('AK',	'Akuntansi'),
('ANM',	'Animasi'),
('DG',	'Desain Grafis'),
('IF',	'Informatika'),
('MNJ',	'Manajemen'),
('SI',	'Sistem Informasi'),
('SIN',	'Sinematografi'),
('TK',	'Teknik Komputer'),
('UM',	'Umum');

DROP TABLE IF EXISTS `kelas`;
CREATE TABLE `kelas` (
  `id_kelas` char(6) COLLATE ascii_bin NOT NULL,
  `id_matkul` char(6) COLLATE ascii_bin DEFAULT NULL,
  `id_ruangan` char(5) COLLATE ascii_bin DEFAULT NULL,
  `id_dosen` char(6) COLLATE ascii_bin DEFAULT NULL,
  `tanggal` date DEFAULT NULL,
  `waktu` time DEFAULT NULL,
  PRIMARY KEY (`id_kelas`),
  KEY `fk_id_matkul_kelas` (`id_matkul`),
  KEY `fk_id_ruangan_kelas` (`id_ruangan`),
  KEY `fk_id_dosen_kelas` (`id_dosen`),
  CONSTRAINT `fk_id_ruangan_kelas` FOREIGN KEY (`id_ruangan`) REFERENCES `ruangan` (`id_ruangan`),
  CONSTRAINT `kelas_ibfk_2` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`),
  CONSTRAINT `kelas_ibfk_3` FOREIGN KEY (`id_dosen`) REFERENCES `dosen` (`id_dosen`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `kelas` (`id_kelas`, `id_matkul`, `id_ruangan`, `id_dosen`, `tanggal`, `waktu`) VALUES
('K00001',	'TK0102',	'B0005',	'D00001',	'2018-06-19',	'08:00:00'),
('K00002',	'TK0101',	'B0005',	'D00001',	'2018-06-20',	'10:00:00'),
('K00003',	'IF0103',	'B0002',	'D00004',	'2018-06-19',	'08:00:00');

DROP TABLE IF EXISTS `mahasiswa`;
CREATE TABLE `mahasiswa` (
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `nama_depan` varchar(20) COLLATE ascii_bin NOT NULL,
  `nama_belakang` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `tempat_lahir` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `tanggal_lahir` date DEFAULT NULL,
  `alamat` varchar(100) COLLATE ascii_bin DEFAULT NULL,
  `id_jurusan` char(3) COLLATE ascii_bin NOT NULL,
  `angkatan` int(4) NOT NULL,
  `email` varchar(50) COLLATE ascii_bin DEFAULT NULL,
  `hp` varchar(20) COLLATE ascii_bin DEFAULT NULL,
  `jenis_kelamin` enum('pria','wanita') COLLATE ascii_bin DEFAULT NULL,
  PRIMARY KEY (`id_mahasiswa`),
  KEY `fk_id_jurusan_m` (`id_jurusan`),
  CONSTRAINT `mahasiswa_ibfk_1` FOREIGN KEY (`id_jurusan`) REFERENCES `jurusan` (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `mahasiswa` (`id_mahasiswa`, `nama_depan`, `nama_belakang`, `tempat_lahir`, `tanggal_lahir`, `alamat`, `id_jurusan`, `angkatan`, `email`, `hp`, `jenis_kelamin`) VALUES
('00000022221',	'Nata',	'Nataan',	'Papua',	'1999-09-19',	'Duta Garden Blok A/9',	'TK',	2016,	'nata@student.uni.ac.id',	'08123123451',	'pria'),
('00000034874',	'William',	'Darian',	'Tangerang',	'1997-10-10',	'Jl. Raya Puspitek No. 12',	'SI',	2013,	'william.darian@student.uni.ac.id',	'081592929595',	'pria'),
('00000038444',	'Veronica',	'Dian',	'Pontianak',	'1998-02-28',	'Citra 7',	'MNJ',	2014,	'veronica.dian@student.uni.ac.id',	'089812329878',	'wanita'),
('00000074654',	'Richard',	'Dharmawan',	'Jakarta',	'2000-10-03',	'Metro 2',	'TK',	2015,	'richard.dharmawan@student.uni.ac.id',	'081508150815',	'pria'),
('00000088522',	'Jennifer',	'Nangoy',	'Makassar',	'1997-10-10',	'Jl. Binong No. 14',	'DG',	2013,	'jennifer.nangoy@student.uni.ac.id',	'087583094012',	'wanita'),
('00000089109',	'George',	'Joseph',	'Yogyakarta',	'2000-01-30',	'Jl. Batusari No. 99',	'SIN',	2014,	'george.joseph@student.uni.ac.id',	'081528401785',	'pria');

DROP TABLE IF EXISTS `mahasiswa_kehadiran`;
CREATE TABLE `mahasiswa_kehadiran` (
  `id_kehadiran` char(6) COLLATE ascii_bin NOT NULL,
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `id_kelas` char(6) COLLATE ascii_bin NOT NULL,
  `kehadiran` enum('hadir','absen') COLLATE ascii_bin DEFAULT NULL,
  `terlambat` enum('terlambat','tepat waktu') COLLATE ascii_bin DEFAULT NULL,
  `waktu_datang` timestamp NULL DEFAULT NULL,
  PRIMARY KEY (`id_kehadiran`),
  KEY `fk_id_mahasiswa_mk` (`id_mahasiswa`),
  KEY `fk_id_kelas-mk` (`id_kelas`),
  CONSTRAINT `mahasiswa_kehadiran_ibfk_1` FOREIGN KEY (`id_mahasiswa`) REFERENCES `mahasiswa` (`id_mahasiswa`),
  CONSTRAINT `mahasiswa_kehadiran_ibfk_2` FOREIGN KEY (`id_kelas`) REFERENCES `kelas` (`id_kelas`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `mahasiswa_kehadiran` (`id_kehadiran`, `id_mahasiswa`, `id_kelas`, `kehadiran`, `terlambat`, `waktu_datang`) VALUES
('MK0001',	'00000074654',	'K00001',	'hadir',	'tepat waktu',	'2018-06-19 01:11:45'),
('MK0002',	'00000089109',	'K00001',	'hadir',	'tepat waktu',	'2018-06-19 01:08:12'),
('MK0003',	'00000022221',	'K00001',	'hadir',	'terlambat',	'2018-06-19 01:21:59'),
('MK0004',	'00000074654',	'K00002',	'hadir',	'tepat waktu',	'2018-06-20 03:02:13'),
('MK0005',	'00000089109',	'K00002',	'absen',	NULL,	NULL);

DROP TABLE IF EXISTS `mahasiswa_matkul`;
CREATE TABLE `mahasiswa_matkul` (
  `id_ambil` char(6) COLLATE ascii_bin NOT NULL,
  `id_mahasiswa` char(11) COLLATE ascii_bin NOT NULL,
  `id_matkul` char(6) COLLATE ascii_bin NOT NULL,
  `nilai_tugas_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_tugas_praktek` int(3) DEFAULT '0',
  `nilai_uts_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_uts_praktek` int(3) DEFAULT '0',
  `nilai_uas_teori` int(3) NOT NULL DEFAULT '0',
  `nilai_uas_praktek` int(3) DEFAULT '0',
  PRIMARY KEY (`id_ambil`),
  KEY `fk_id_mahasiswa_mm` (`id_mahasiswa`),
  KEY `fk_id_matkul_mm` (`id_matkul`),
  CONSTRAINT `mahasiswa_matkul_ibfk_1` FOREIGN KEY (`id_mahasiswa`) REFERENCES `mahasiswa` (`id_mahasiswa`),
  CONSTRAINT `mahasiswa_matkul_ibfk_2` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `mahasiswa_matkul` (`id_ambil`, `id_mahasiswa`, `id_matkul`, `nilai_tugas_teori`, `nilai_tugas_praktek`, `nilai_uts_teori`, `nilai_uts_praktek`, `nilai_uas_teori`, `nilai_uas_praktek`) VALUES
('M00001',	'00000074654',	'IF0103',	0,	0,	0,	0,	0,	0),
('M00002',	'00000074654',	'ANM102',	0,	0,	0,	0,	0,	0),
('M00003',	'00000074654',	'TK0102',	0,	0,	0,	0,	0,	0),
('M00004',	'00000089109',	'IF0101',	0,	0,	0,	0,	0,	0),
('M00005',	'00000089109',	'IF0102',	0,	0,	0,	0,	0,	0),
('M00006',	'00000034874',	'TK0102',	0,	0,	0,	0,	0,	0),
('M00007',	'00000034874',	'ANM102',	0,	0,	0,	0,	0,	0),
('M00008',	'00000038444',	'IF0103',	0,	0,	0,	0,	0,	0),
('M00009',	'00000038444',	'IF0103',	0,	0,	0,	0,	0,	0),
('M00010',	'00000088522',	'TK0102',	0,	0,	0,	0,	0,	0),
('M00011',	'00000088522',	'TK0103',	0,	0,	0,	0,	0,	0);

DROP TABLE IF EXISTS `matkul`;
CREATE TABLE `matkul` (
  `id_matkul` char(6) COLLATE ascii_bin NOT NULL,
  `nama_matkul` varchar(50) COLLATE ascii_bin NOT NULL,
  `id_jurusan` char(3) COLLATE ascii_bin DEFAULT NULL,
  `jumlah_sks` int(1) DEFAULT NULL,
  PRIMARY KEY (`id_matkul`),
  KEY `id_jurusan` (`id_jurusan`),
  CONSTRAINT `matkul_ibfk_1` FOREIGN KEY (`id_jurusan`) REFERENCES `jurusan` (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `matkul` (`id_matkul`, `nama_matkul`, `id_jurusan`, `jumlah_sks`) VALUES
('ANM102',	'Motion Graphic',	'DG',	3),
('DG0101',	'Digital Painting',	'DG',	2),
('IF0101',	'Pengantar Teknologi Multimedia',	'IF',	2),
('IF0102',	'Pengantar Teknologi Multimedia - LAB',	'IF',	1),
('IF0103',	'Logika Pemrograman',	'IF',	3),
('SI0101',	'Analisis Pasar',	'SI',	3),
('SI0102',	'Antar Muka',	'SI',	2),
('SIN101',	'Directing',	'SIN',	3),
('TK0101',	'Sirkuit Elektronik',	'TK',	2),
('TK0102',	'Fisika Dasar',	'TK',	3),
('TK0103',	'Kalkulus',	'TK',	3),
('UM0101',	'Pancasila',	'UM',	2),
('UM0102',	'Bahasa Indonesia',	'UM',	2);

DROP TABLE IF EXISTS `ruangan`;
CREATE TABLE `ruangan` (
  `id_ruangan` char(5) COLLATE ascii_bin NOT NULL,
  `nama_ruangan` varchar(50) COLLATE ascii_bin DEFAULT NULL,
  PRIMARY KEY (`id_ruangan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `ruangan` (`id_ruangan`, `nama_ruangan`) VALUES
('A0001',	'Ruang Kelas Normal'),
('A0002',	'Ruang Kelas Normal'),
('A0003',	'Ruang Kelas Normal'),
('A0004',	'Ruang Kelas Normal'),
('A0005',	'Ruang Kelas Normal'),
('B0001',	'Laboratorium Komputer'),
('B0002',	'Laboratorium Komputer'),
('B0003',	'Laboratorium Komputer'),
('B0004',	'Laboratorium Komputer'),
('B0005',	'Laboratorium Fisika');

-- 2018-06-20 03:16:25