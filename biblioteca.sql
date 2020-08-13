-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-08-2020 a las 20:50:55
-- Versión del servidor: 10.3.16-MariaDB
-- Versión de PHP: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `biblioteca`
--

DELIMITER $$
--
-- Procedimientos
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `ADD_GAME` (IN `pName` VARCHAR(100), IN `pPlat` INT, IN `pSPlat` INT, IN `pUser` INT)  BEGIN
IF EXISTS (SELECT juego, id_plat, id_splat,id_user FROM biblioteca WHERE juego = pName AND id_plat = pPlat AND id_splat = pSPlat AND id_user = pUser AND id_est = 2)
THEN
UPDATE biblioteca SET id_est = 1;
ELSE
	INSERT INTO biblioteca (juego,id_plat,id_splat,id_est,id_user)
    VALUES (pName, pPlat, pSPlat, 1, pUser);
END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_GAME` (IN `pName` VARCHAR(100), IN `pPlat` INT, IN `pSPlat` INT, IN `pUser` INT)  BEGIN
SELECT juego AS "c1", id_plat AS "c2", id_splat AS "c3", id_user AS "c4" FROM biblioteca WHERE juego = pName AND id_plat = pPlat AND id_splat = pSPlat AND id_user = pUser AND id_est = 1;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_PLATAFORM` (IN `pName` VARCHAR(30))  BEGIN
SELECT * FROM subplataformas WHERE nombre = pName;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CHECK_USER` (IN `pUser` VARCHAR(30))  BEGIN
SELECT * FROM usuarios WHERE usuario = pUser;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CREATE_PLATAFORM` (IN `pID` INT, IN `pName` VARCHAR(30))  NO SQL
BEGIN
IF NOT EXISTS (SELECT * FROM subplataformas WHERE nombre = pName)
THEN
INSERT INTO subplataformas (nombre, ID_plataforma)
	VALUES (pName,pID);
END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CREATE_USER` (IN `pUser` VARCHAR(30), IN `pPass` VARCHAR(30))  BEGIN
IF NOT EXISTS (SELECT * FROM usuarios WHERE usuario = pUser)
THEN
INSERT INTO usuarios (usuario, contraseña)
	VALUES (pUser,pPass);
END IF;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DATA_DELETE` (IN `pID` INT, IN `pUser` INT)  BEGIN
UPDATE biblioteca SET id_est = 2 WHERE ID = pID AND id_user = pUser;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DATA_MOD` (IN `pID` INT, IN `pName` VARCHAR(100), IN `pPlat` INT, IN `pSPlat` INT, IN `pUser` INT)  BEGIN
UPDATE biblioteca SET juego = pName, id_plat = pPlat, id_splat = pSPlat WHERE ID = pID AND id_user = pUser;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `LOGIN` (IN `pUser` VARCHAR(30), IN `pPass` VARCHAR(30))  BEGIN
SELECT * FROM usuarios WHERE usuario = pUser AND contraseña = pPass;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `OBTENER_PLATAFORMAS` ()  NO SQL
SELECT * FROM plataformas$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `OBTENER_SPLATAFORMAS` (IN `pID` INT)  NO SQL
SELECT * FROM subplataformas WHERE ID_plataforma = pID$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `USER_DATA` (IN `pUser` INT)  BEGIN
SELECT biblioteca.ID AS "ID", biblioteca.juego AS "JUEGO", plataformas.plataforma AS "PLATAFORMA", subplataformas.nombre AS "SERVICIO" FROM ((`biblioteca` INNER JOIN plataformas ON biblioteca.id_plat = plataformas.ID) INNER JOIN subplataformas on biblioteca.id_splat = subplataformas.ID) WHERE id_user = pUser AND id_est = 1;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `biblioteca`
--

CREATE TABLE `biblioteca` (
  `ID` int(11) NOT NULL,
  `juego` varchar(100) DEFAULT NULL,
  `id_plat` int(11) DEFAULT NULL,
  `id_splat` int(11) DEFAULT NULL,
  `id_est` int(11) DEFAULT NULL,
  `id_user` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `biblioteca`
--

INSERT INTO `biblioteca` (`ID`, `juego`, `id_plat`, `id_splat`, `id_est`, `id_user`) VALUES
(1, 'Mortal Kombat 11', 1, 1, 1, 1),
(2, 'Mortal Kombat X', 1, 1, 1, 1),
(3, 'Mortal Kombat X', 2, 6, 1, 1),
(6, 'Half-Life 2', 1, 1, 1, 1),
(8, 'RESIDENT EVIL ', 1, 1, 2, 1),
(9, 'ASSASINS CREED 2', 1, 1, 1, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `estados`
--

CREATE TABLE `estados` (
  `ID` int(11) NOT NULL,
  `estado` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `estados`
--

INSERT INTO `estados` (`ID`, `estado`) VALUES
(1, 'activo'),
(2, 'inactivo');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `plataformas`
--

CREATE TABLE `plataformas` (
  `ID` int(11) NOT NULL,
  `plataforma` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `plataformas`
--

INSERT INTO `plataformas` (`ID`, `plataforma`) VALUES
(1, 'PC'),
(2, 'Consola'),
(3, 'Celular');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `subplataformas`
--

CREATE TABLE `subplataformas` (
  `ID` int(11) NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `ID_plataforma` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `subplataformas`
--

INSERT INTO `subplataformas` (`ID`, `nombre`, `ID_plataforma`) VALUES
(1, 'STEAM', 1),
(2, 'PLAYSTATION 2', 2),
(3, 'IOS', 3),
(4, 'ORIGIN', 1),
(5, 'UPLAY', 1),
(6, 'PLAYSTATION 4', 2),
(7, 'GOG', 1),
(8, 'ANDROID', 3),
(9, 'XBOX ONE', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `usuario` varchar(30) DEFAULT NULL,
  `contraseña` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID`, `usuario`, `contraseña`) VALUES
(1, 'admin', 'admin');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `biblioteca`
--
ALTER TABLE `biblioteca`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `id_plat` (`id_plat`),
  ADD KEY `id_splat` (`id_splat`),
  ADD KEY `id_est` (`id_est`),
  ADD KEY `id_user` (`id_user`);

--
-- Indices de la tabla `estados`
--
ALTER TABLE `estados`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `plataformas`
--
ALTER TABLE `plataformas`
  ADD PRIMARY KEY (`ID`);

--
-- Indices de la tabla `subplataformas`
--
ALTER TABLE `subplataformas`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID_plataforma` (`ID_plataforma`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `biblioteca`
--
ALTER TABLE `biblioteca`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `estados`
--
ALTER TABLE `estados`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `plataformas`
--
ALTER TABLE `plataformas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT de la tabla `subplataformas`
--
ALTER TABLE `subplataformas`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `biblioteca`
--
ALTER TABLE `biblioteca`
  ADD CONSTRAINT `biblioteca_ibfk_1` FOREIGN KEY (`id_plat`) REFERENCES `plataformas` (`ID`),
  ADD CONSTRAINT `biblioteca_ibfk_2` FOREIGN KEY (`id_splat`) REFERENCES `subplataformas` (`ID`),
  ADD CONSTRAINT `biblioteca_ibfk_3` FOREIGN KEY (`id_est`) REFERENCES `estados` (`ID`),
  ADD CONSTRAINT `biblioteca_ibfk_4` FOREIGN KEY (`id_user`) REFERENCES `usuarios` (`ID`);

--
-- Filtros para la tabla `subplataformas`
--
ALTER TABLE `subplataformas`
  ADD CONSTRAINT `subplataformas_ibfk_1` FOREIGN KEY (`ID_plataforma`) REFERENCES `plataformas` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
