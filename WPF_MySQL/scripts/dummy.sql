-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 20-11-2020 a las 10:00:37
-- Versión del servidor: 10.4.11-MariaDB
-- Versión de PHP: 7.4.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dummy`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `name` varchar(20) NOT NULL,
  `surname` varchar(50) NOT NULL,
  `timestamp` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`id`, `name`, `surname`, `timestamp`) VALUES
(1, 'Luis', 'del Moral Martínez', '2020-11-20 08:51:25'),
(2, 'Miguel', 'Álvarez Mejías', '2020-11-20 08:57:28'),
(3, 'Gabriel', 'Aranda Alonso', '2020-11-20 08:57:28'),
(4, 'Antonio Manuel', 'Arrabal Ordoñez', '2020-11-20 08:57:28'),
(5, 'José Antonio', 'Bello Martínez', '2020-11-20 08:57:28'),
(6, 'Rafael Jesús', 'Bermúdez Carvajal', '2020-11-20 08:57:28'),
(7, 'José Antonio', 'Carmona de la Fuente', '2020-11-20 08:57:28'),
(8, 'Javier', 'Castro Carracedo', '2020-11-20 08:57:28'),
(9, 'Isaac Manuel', 'Cejudo Alfaro', '2020-11-20 08:57:28'),
(10, 'Pedro Antonio', 'Entrenas García', '2020-11-20 08:57:28'),
(11, 'Manuel', 'Expósito Osorio', '2020-11-20 08:57:28'),
(12, 'Fermín', 'Expósito Villegas', '2020-11-20 08:57:28'),
(13, 'Rafael', 'Gálvez Ruiz', '2020-11-20 08:57:28'),
(14, 'David', 'García Moreno', '2020-11-20 08:57:28'),
(15, 'Francisco', 'Gordillo Maldonado', '2020-11-20 08:57:28'),
(16, 'Cristóbal', 'Guillén Barcos', '2020-11-20 08:57:28'),
(17, 'Christopher', 'Holzmann Pérez', '2020-11-20 08:57:28'),
(18, 'Javier', 'Linares Gómez', '2020-11-20 08:57:28'),
(19, 'Jorge', 'López Mansilla', '2020-11-20 08:57:28'),
(20, 'Raúl', 'Marín Abad', '2020-11-20 08:57:28'),
(21, 'Cristian', 'Miranda Fernández', '2020-11-20 08:57:28'),
(22, 'Alejandro', 'Modelo Llamas', '2020-11-20 08:57:28'),
(23, 'Manuel Ángel', 'Molina Fernández', '2020-11-20 08:57:28'),
(24, 'Luis', 'Monserrat Castañeda', '2020-11-20 08:57:28'),
(25, 'Juan José', 'Morcillo Luque', '2020-11-20 08:57:28'),
(26, 'Juan', 'Muñoz Palomares', '2020-11-20 08:57:28'),
(27, 'José Antonio', 'Pizarro Cerezo', '2020-11-20 08:57:28'),
(28, 'Jesús', 'Rodríguez Aranda', '2020-11-20 08:57:28'),
(29, 'Jesús', 'rubio Perales', '2020-11-20 08:57:28');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=30;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
