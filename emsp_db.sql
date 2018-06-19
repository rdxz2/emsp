-- Adminer 4.3.1 MySQL dump

SET NAMES utf8;
SET time_zone = '+00:00';
SET foreign_key_checks = 0;
SET sql_mode = 'NO_AUTO_VALUE_ON_ZERO';

DROP TABLE IF EXISTS `dosen`;
CREATE TABLE `dosen` (
  `id_dosen` char(6) COLLATE ascii_bin NOT NULL,
  `id_matkul` char(6) COLLATE ascii_bin NOT NULL,
  `nama` varchar(50) COLLATE ascii_bin NOT NULL,
  `jenis_kelamin` enum('Pria','Wanita') COLLATE ascii_bin NOT NULL,
  `tanggal_lahir` date NOT NULL,
  `tempat_lahir` varchar(20) COLLATE ascii_bin NOT NULL,
  `email` varchar(50) COLLATE ascii_bin NOT NULL,
  `hp` varchar(20) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_dosen`),
  KEY `fk_id_matkul_dosen` (`id_matkul`),
  CONSTRAINT `fk_id_matkul_dosen` FOREIGN KEY (`id_matkul`) REFERENCES `matkul` (`id_matkul`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `dosen` (`id_dosen`, `id_matkul`, `nama`, `jenis_kelamin`, `tanggal_lahir`, `tempat_lahir`, `email`, `hp`) VALUES
('D00001',	'UM0101',	'Suprapto Nugroho',	'Pria',	'1978-12-23',	'Blitar',	'suprapto@dosen.uni.ac.id',	'08179909828'),
('D00002',	'IF0101',	'Ratu',	'Wanita',	'1978-12-05',	'Aceh',	'ratu@dosen.uni.ac.id',	''),
('D00003',	'IF0102',	'Widya',	'Wanita',	'1986-01-18',	'Pangkalpinang',	'widya@dosen.uni.ac.id',	'08179909828'),
('D00004',	'IF0103',	'Luhut',	'Pria',	'1985-04-06',	'Palembang',	'luhut@dosen.uni.ac.id',	'08179909850'),
('D00005',	'UM0101',	'Winda',	'Wanita',	'1987-05-04',	'Semarang',	'winda@dosen.uni.ac.id',	'08179906428'),
('D00006',	'UM0102',	'Setiawan',	'Pria',	'1981-06-10',	'Tegal',	'setiawan@dosen.uni.ac.id',	'081799309648'),
('D00007',	'TK0101',	'Rio Hartono',	'Pria',	'1980-07-13',	'Salatiga',	'rio.hartono@dosen.uni.ac.id',	'081799098542'),
('D00008',	'TK0102',	'Hamish Tri',	'Pria',	'1977-08-24',	'Sydney, Australia',	'hamish.tri@dosen.uni.ac.id',	'081768098528'),
('D00009',	'TK0103',	'Hugo',	'Pria',	'1986-11-03',	'Maluku',	'hugo@dosen.uni.ac.id',	'08179908118'),
('D00010',	'SI0101',	'Sam Sul',	'Pria',	'1989-10-30',	'Jambi',	'samsul@dosen.uni.ac.id',	'081793909558'),
('D00011',	'SI0102',	'Don Bon',	'Pria',	'1988-09-29',	'Samarinda',	'donbon@dosen.uni.ac.id',	'08179909662'),
('D00012',	'DG0101',	'Margareth Vy',	'Wanita',	'1988-09-28',	'Balikpapan',	'margareth.vy@dosen.uni.ac.id',	'08179909655'),
('D00013',	'SIN101',	'Aryo Oscar',	'Pria',	'1985-04-08',	'Jakarta',	'aryo.oscar@dosen.uni.ac.id',	'081799661608'),
('D00014',	'ANM102',	'Joseph Donn',	'Pria',	'1987-05-17',	'Tangerang',	'joseph.donn@dosen.uni.ac.id',	'08176221211'),
('D00015',	'UM0102',	'Fitria Zulfa',	'Wanita',	'1990-08-16',	'Bogor',	'fitria.zulfa@dosen.uni.ac.id',	'08178855331'),
('D00016',	'TK0101',	'Maxwell Nat',	'Pria',	'1991-09-20',	'Surabaya',	'maxwell.nat@dosen.uni.ac.id',	'081799098555');

DROP TABLE IF EXISTS `jurusan`;
CREATE TABLE `jurusan` (
  `id_jurusan` char(3) COLLATE ascii_bin NOT NULL,
  `nama_jurusan` varchar(25) COLLATE ascii_bin NOT NULL,
  PRIMARY KEY (`id_jurusan`)
) ENGINE=InnoDB DEFAULT CHARSET=ascii COLLATE=ascii_bin;

INSERT INTO `jurusan` (`id_jurusan`, `nama_jurusan`) VALUES
('ANM',	'Animasi'),
('DG',	'Desain Grafis'),
('IF',	'Informatika'),
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
('15001010001',	'Prilly',	'Ruby',	'Bandung',	'1998-08-12',	'Metro Permata',	'IF',	2015,	'prilly.ruby@mhs.uni.ac.id',	'081911022613',	'wanita'),
('15001010002',	'Goldy',	'Vivid',	'Jakarta',	'1997-09-29',	'Kelapa Gading',	'IF',	2015,	'goldy.vivid@mhs.uni.ac.id',	'082911978899',	'wanita'),
('15001010003',	'Nicta',	'Niv',	'Jakarta',	'1997-12-01',	'Bumi Serpong Damai',	'IF',	2015,	'nicta.niv@mhs.uni.ac.id',	'081605971545',	'wanita'),
('15001010004',	'Edberuto',	'Kato',	'Osaka, Jepang',	'1997-04-20',	'Bumi Serpong Damai',	'IF',	2015,	'edberuto.kato@mhs.uni.ac.id',	'087756563639',	'pria'),
('15001010005',	'Arberuto',	'Kato',	'Osaka, Jepang',	'1997-04-21',	'Bumi Serpong Damai',	'IF',	2015,	'arberuto.kato@mhs.uni.ac.id',	'088219232345',	'pria'),
('15001010006',	'Ricky',	'Ferdian',	'Bandung',	'1998-02-02',	'Alam Sutera',	'IF',	2015,	'ricky.ferdian@mhs.uni.ac.id',	'081235546282',	'pria'),
('15001010007',	'Magenta',	'Lucid',	'Medan',	'1996-12-14',	'Tangerang',	'IF',	2015,	'magenta.lucid@mhs.uni.ac.id',	'081511611111',	'wanita'),
('15002010001',	'Richard',	'Dharmawan',	'Jakarta',	'1997-01-12',	'Metro Permata',	'TK',	2015,	'richard.dharmawan@mhs.uni.ac.id',	'081911022313',	'pria'),
('15002010002',	'Stefanus',	'Kurnia',	'Jakarta',	'1997-06-28',	'Kelapa Gading',	'TK',	2015,	'stefanus.kurnia@mhs.uni.ac.id',	'081911978891',	'pria'),
('15002010003',	'William',	'Sutedja',	'Jakarta',	'1997-08-19',	'Bumi Serpong Damai',	'TK',	2015,	'william.sutedja@mhs.uni.ac.id',	'081600971545',	'pria'),
('15002010004',	'Steven',	'Ricardo',	'Lasem',	'1997-04-27',	'Tangerang',	'TK',	2015,	'steven.ricardo@mhs.uni.ac.id',	'087756563434',	'pria'),
('15002010005',	'Budi',	'Sutjipto',	'Jakarta',	'1997-11-11',	'Pondok Indah',	'TK',	2015,	'budi.sutjipto@mhs.uni.ac.id',	'088211233345',	'pria'),
('15002010006',	'Kevin',	'Muljono',	'Jakarta',	'1998-08-19',	'Salemba',	'TK',	2015,	'kevin.muljono@mhs.uni.ac.id',	'081235546686',	'pria'),
('15002010007',	'Muhammad',	'Miqdad',	'Jakarta',	'1997-01-21',	'Serang',	'TK',	2015,	'muh.miqdad@mhs.uni.ac.id',	'081511211181',	'pria'),
('15002010008',	'Hafiz',	'Rudiyanto',	'Palembang',	'1997-06-09',	'Depok',	'TK',	2015,	'hafiz.rudiyanto@mhs.uni.ac.id',	'0899923299656',	'pria'),
('15002010009',	'Anthonny',	'Setiawan',	'Blitar',	'1997-12-12',	'Gading Serpong',	'TK',	2015,	'anthonny.setiawan@mhs.uni.ac.id',	'087723239696',	'pria'),
('15002010010',	'Rafless',	'Pradita',	'Pekanbaru',	'1997-11-05',	'Gading Serpong',	'TK',	2015,	'rafless.pradita@mhs.uni.ac.id',	'085899651232',	'pria'),
('15002010011',	'Matthew',	'Oktavianus',	'Kupang',	'1997-06-29',	'Kabupaten Tangerang',	'TK',	2015,	'matthew.oktavianus@mhs.uni.ac.id',	'085667768867',	'pria'),
('15002010012',	'Gerald',	'Roy',	'Yogyakarta',	'1997-03-12',	'Gading Serpong',	'TK',	2015,	'gerald.roy@mhs.uni.ac.id',	'0888789968112',	'pria'),
('15002010013',	'Veronica',	'Setia',	'Jakarta',	'1996-10-17',	'Poris',	'TK',	2015,	'veronica.setia@mhs.uni.ac.id',	'085688789989',	'wanita'),
('15002010014',	'Jennifer',	'Gunawan',	'Jakarta',	'1998-03-06',	'Karawaci',	'TK',	2015,	'jennifer.gunawan@mhs.uni.ac.id',	'087766867757',	'wanita'),
('15002010015',	'Nata',	'',	'Tangerang',	'1997-05-05',	'Karawaci',	'TK',	2015,	'nata@mhs.uni.ac.id',	'081987789969',	'pria'),
('15002010016',	'Julian',	'Widhana',	'Tangerang',	'1997-01-09',	'Gading Serpong',	'TK',	2015,	'julian.widhana@mhs.uni.ac.id',	'084745455656',	'pria'),
('15002010017',	'Fajar',	'Pri',	'Bekasi',	'1997-06-05',	'Gading Serpong',	'TK',	2015,	'fajar.pri@mhs.uni.ac.id',	'087898769876',	'pria'),
('15002010018',	'Kurnia',	'Adijaya',	'Bekasi',	'1997-08-07',	'Gading Serpong',	'TK',	2015,	'kurnia.adijaya@mhs.uni.ac.id',	'084556563232',	'pria'),
('15002010019',	'Elena',	'Rose',	'Yogyakarta',	'1997-01-01',	'Alam Sutera',	'TK',	2015,	'elena.rose@mhs.uni.ac.id',	'082545454878',	'wanita'),
('15002010020',	'Sugeng',	'Priambodo',	'Semarang',	'1997-02-23',	'',	'TK',	2015,	'sugeng.priambodo@mhs.uni.ac.id',	'087889898321',	'pria'),
('15002010021',	'Marvin',	'Gunardi',	'Jakarta',	'1997-09-01',	'Bandar Wijaya',	'TK',	2015,	'marvin.gunardi@mhs.uni.ac.id',	'087787788998',	'pria'),
('15002010022',	'Gregorius',	'Vincent',	'Jakarta',	'1997-08-16',	'Modernland Tangerang',	'TK',	2015,	'gregorius.vincent@mhs.uni.ac.id',	'087975641321',	'pria'),
('15003010001',	'Ferry',	'Rukminto',	'Jakarta',	'1997-03-12',	'Metro Permata',	'SI',	2015,	'ferry.rukminto@mhs.uni.ac.id',	'081911022913',	'pria'),
('15003010002',	'Vicky',	'Firdaus',	'Jakarta',	'1997-06-29',	'Kelapa Gading',	'SI',	2015,	'vicky.firdaus@mhs.uni.ac.id',	'081911978899',	'pria'),
('15003010003',	'Feliana',	'Angelica',	'Jakarta',	'1997-08-01',	'Bumi Serpong Damai',	'SI',	2015,	'feliana.angelica@mhs.uni.ac.id',	'081608971545',	'wanita'),
('15003010004',	'Roy',	'Sirumpait',	'Medan',	'1997-10-27',	'Tangerang',	'SI',	2015,	'roy.sirumpait@mhs.uni.ac.id',	'087756563634',	'pria'),
('15003010005',	'Nathalia',	'Cyan',	'Pontianak',	'1997-08-11',	'Pondok Indah',	'SI',	2015,	'nathalia.cyan@mhs.uni.ac.id',	'088219233345',	'wanita'),
('15003010006',	'Teuku',	'Luqman',	'Aceh',	'1998-02-19',	'Salemba',	'SI',	2015,	'teuku.luqman@mhs.uni.ac.id',	'081235546286',	'pria'),
('15003010007',	'Viviany Lim',	'Lucy',	'Jakarta',	'1997-12-21',	'Serang',	'SI',	2015,	'lim.vivany@mhs.uni.ac.id',	'081511611181',	'wanita');

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


-- 2018-06-17 17:04:44
