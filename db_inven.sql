-- phpMyAdmin SQL Dump
-- version 5.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 26 Jul 2021 pada 03.52
-- Versi server: 10.4.11-MariaDB
-- Versi PHP: 7.4.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_inven`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_barang`
--

CREATE TABLE `tb_barang` (
  `id_brg` int(11) NOT NULL,
  `nama_barang` varchar(30) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `kd_barang` varchar(10) NOT NULL,
  `kondisi` varchar(20) NOT NULL,
  `stok` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tb_barang`
--

INSERT INTO `tb_barang` (`id_brg`, `nama_barang`, `jumlah`, `kd_barang`, `kondisi`, `stok`) VALUES
(1, 'Gayor', 2, 'K001', 'Barul', -3),
(2, 'Bendera Merah Putih', 800, 'K002', 'Baru', 816),
(3, 'Microfon', 611, 'K003', 'Baru', 611),
(4, 'Sound Sistem', 1, 'K004', 'Layak Pakai', 1),
(6, 'Saput Tangan Ajaib', 1, 'KD_123', 'Utuh', 1),
(7, 'Kantoong ajaib', 3, 'K_123', 'bagus', 3);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tb_pinjam`
--

CREATE TABLE `tb_pinjam` (
  `id_pinjam` int(11) NOT NULL,
  `nama_peminjam` varchar(50) NOT NULL,
  `id_brg` int(11) NOT NULL,
  `jumlah` int(11) NOT NULL,
  `instansi` varchar(50) NOT NULL,
  `kontak` varchar(14) NOT NULL,
  `tgl_pinjam` timestamp NOT NULL DEFAULT current_timestamp(),
  `tgl_kembali` datetime DEFAULT NULL,
  `tgl_pred_kembali` date NOT NULL,
  `status` varchar(18) NOT NULL DEFAULT 'belum kembali'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tb_pinjam`
--

INSERT INTO `tb_pinjam` (`id_pinjam`, `nama_peminjam`, `id_brg`, `jumlah`, `instansi`, `kontak`, `tgl_pinjam`, `tgl_kembali`, `tgl_pred_kembali`, `status`) VALUES
(1, 'Dika', 2, 18, 'sadffa', 'adff', '2021-07-01 20:57:19', NULL, '0000-00-00', 'kembali'),
(2, 'asf', 1, -1, 'sdf', 'hh', '2021-07-01 21:06:28', NULL, '0000-00-00', 'kembali'),
(3, 'AD', 1, -2, 'we', '22', '2021-07-01 22:23:06', '2021-07-02 18:15:25', '0000-00-00', 'kembali'),
(4, 'Aku', 2, 12, 'asas', '1334', '2021-07-01 23:15:33', '0000-00-00 00:00:00', '0000-00-00', 'kembali'),
(5, 'ad', 2, 6, 'asd', '334', '2021-07-01 23:30:31', '0000-00-00 00:00:00', '0000-00-00', 'kembali'),
(6, 'zx', 2, 6, 'zxc', 'zx', '2021-07-01 23:36:20', '0000-00-00 00:00:00', '0000-00-00', 'belum kembali'),
(7, 'Surjey', 7, 2, 'UKM', '73639476', '2021-07-02 02:26:57', '0000-00-00 00:00:00', '0000-00-00', 'kembali'),
(8, 'adasffsafas', 2, 5, 'fsaa', 'afsfsaf', '2021-07-02 10:13:36', '0000-00-00 00:00:00', '0000-00-00', 'belum kembali'),
(9, '324gsdf', 2, 4, '4tdsgf', 'gdsg4', '2021-07-02 10:25:07', '2021-07-10 06:31:00', '0000-00-00', 'kembali');

--
-- Trigger `tb_pinjam`
--
DELIMITER $$
CREATE TRIGGER `minStok` AFTER INSERT ON `tb_pinjam` FOR EACH ROW UPDATE tb_barang set stok = stok- NEW.Jumlah WHERE id_brg= new.id_brg
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `plusSTOK` AFTER UPDATE ON `tb_pinjam` FOR EACH ROW UPDATE tb_barang set stok = stok+ NEW.Jumlah WHERE id_brg= new.id_brg AND new.status='kembali'
$$
DELIMITER ;
DELIMITER $$
CREATE TRIGGER `plusStokKurang` AFTER UPDATE ON `tb_pinjam` FOR EACH ROW UPDATE tb_barang set stok = stok+ (old.Jumlah - NEW.Jumlah) WHERE id_brg= new.id_brg AND new.status='belum kembali'
$$
DELIMITER ;

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  ADD PRIMARY KEY (`id_brg`);

--
-- Indeks untuk tabel `tb_pinjam`
--
ALTER TABLE `tb_pinjam`
  ADD PRIMARY KEY (`id_pinjam`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tb_barang`
--
ALTER TABLE `tb_barang`
  MODIFY `id_brg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT untuk tabel `tb_pinjam`
--
ALTER TABLE `tb_pinjam`
  MODIFY `id_pinjam` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
