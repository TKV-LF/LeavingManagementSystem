-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Máy chủ: 127.0.0.1
-- Thời gian đã tạo: Th1 29, 2022 lúc 10:03 AM
-- Phiên bản máy phục vụ: 10.4.21-MariaDB
-- Phiên bản PHP: 8.0.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Cơ sở dữ liệu: `request`
--

-- --------------------------------------------------------

--
-- Cấu trúc bảng cho bảng `request`
--

CREATE TABLE `request` (
  `Id` int(11) NOT NULL,
  `StudentName` longtext DEFAULT NULL,
  `Class` longtext DEFAULT NULL,
  `Title` longtext DEFAULT NULL,
  `LeaveDate` datetime(6) NOT NULL,
  `LeaveType` longtext DEFAULT NULL,
  `ReasonForLeave` longtext DEFAULT NULL,
  `Status` int(11) NOT NULL DEFAULT 1,
  `CreatedTime` datetime(6) NOT NULL,
  `UpdatedTime` datetime(6) NOT NULL,
  `CreatedBy` char(36) CHARACTER SET ascii NOT NULL,
  `UpdatedBy` char(36) CHARACTER SET ascii NOT NULL,
  `IsDeleted` tinyint(1) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Đang đổ dữ liệu cho bảng `request`
--

INSERT INTO `request` (`Id`, `StudentName`, `Class`, `Title`, `LeaveDate`, `LeaveType`, `ReasonForLeave`, `Status`, `CreatedTime`, `UpdatedTime`, `CreatedBy`, `UpdatedBy`, `IsDeleted`) VALUES
(15, 'Nguyen Trong Thuy', '.Net 02', 'Xin nghi ', '2022-01-29 15:59:00.000000', 'Late Coming', 'xin nghi', 1, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', '00000000-0000-0000-0000-000000000000', '00000000-0000-0000-0000-000000000000', 0),
(16, 'Hoang Van Hoang', '.Net 02', 'nghi', '2022-01-29 15:59:00.000000', 'Leave a half of day', NULL, 2, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', '00000000-0000-0000-0000-000000000000', '00000000-0000-0000-0000-000000000000', 0),
(17, 'Tran Van Tuan', '.Net 02', 'Nghi', '2022-01-14 16:00:00.000000', 'Leave one day', NULL, 4, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', '00000000-0000-0000-0000-000000000000', '00000000-0000-0000-0000-000000000000', 0),
(18, 'Trinh Hoang ', '.Net 02', 'nghi', '2022-01-30 16:00:00.000000', 'Late Coming', NULL, 3, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', '00000000-0000-0000-0000-000000000000', '00000000-0000-0000-0000-000000000000', 0),
(19, 'Hoang Hung', '.Net 01', 'nghi', '2022-01-20 16:00:00.000000', 'Leave a half of day', 'nghi', 1, '0001-01-01 00:00:00.000000', '0001-01-01 00:00:00.000000', '00000000-0000-0000-0000-000000000000', '00000000-0000-0000-0000-000000000000', 0);

--
-- Chỉ mục cho các bảng đã đổ
--

--
-- Chỉ mục cho bảng `request`
--
ALTER TABLE `request`
  ADD PRIMARY KEY (`Id`);

--
-- AUTO_INCREMENT cho các bảng đã đổ
--

--
-- AUTO_INCREMENT cho bảng `request`
--
ALTER TABLE `request`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
