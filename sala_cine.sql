-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-07-2017 a las 02:40:14
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `sala_cine`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `asientos`
--

CREATE TABLE IF NOT EXISTS `asientos` (
  `id_asiento` int(10) NOT NULL,
  `nombre_asiento` varchar(10) DEFAULT NULL,
  `estado_asiento` tinyint(1) DEFAULT NULL,
  `id_sala` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `asientos`
--

INSERT INTO `asientos` (`id_asiento`, `nombre_asiento`, `estado_asiento`, `id_sala`) VALUES
(1, 'A00', NULL, 0),
(1, 'A00', NULL, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `sala`
--

CREATE TABLE IF NOT EXISTS `sala` (
  `id_sala` int(10) NOT NULL,
  `nombe_sala` varchar(50) DEFAULT NULL,
  `descripcion` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id_usuarios` int(10) NOT NULL,
  `nombre_usuario` varchar(50) DEFAULT NULL,
  `edad_usuario` int(10) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `tipo_usuario` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`id_usuarios`),
  UNIQUE KEY `id_usuarios` (`id_usuarios`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`id_usuarios`, `nombre_usuario`, `edad_usuario`, `password`, `direccion`, `correo`, `tipo_usuario`) VALUES
(1, 'gerardo', 21, '12345', 'direccion', 'ge_call@hotmail.com', 'administrador');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
