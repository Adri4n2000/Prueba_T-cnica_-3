-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 13-10-2022 a las 02:54:52
-- Versión del servidor: 10.4.24-MariaDB
-- Versión de PHP: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `sistema`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `ID` int(11) NOT NULL,
  `Numero_Documento` varchar(80) COLLATE utf8mb4_bin NOT NULL,
  `Primer_Nombre` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Segundo_Nombre` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Primer_Apellido` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Segundo_Apellido` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Telefono` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `Correo` varchar(255) COLLATE utf8mb4_bin NOT NULL,
  `Direccion` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `Edad` tinyint(4) NOT NULL,
  `Genero` varchar(100) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`ID`, `Numero_Documento`, `Primer_Nombre`, `Segundo_Nombre`, `Primer_Apellido`, `Segundo_Apellido`, `Telefono`, `Correo`, `Direccion`, `Edad`, `Genero`) VALUES
(1, '0987865765', 'Andres', 'Gerard', 'Osorio', 'Hinestroza', '3049586789', 'Osorio32@gmail.com', 'Calle 56', 23, 'Masculino'),
(2, '7896756456', 'Juan', 'Fernando', 'Perez', 'Corral', '3678765678', 'Corral45@gmail.com', 'Calle 78', 21, 'Masculino'),
(3, '5674563456', 'Julieta', 'Lucia', 'Ponce', 'Castrillon', '3112678905', 'Castrillon67@gmail.com', 'Calle 56', 34, 'Femenino'),
(4, '8978675645', 'Efrain', 'Jesus', 'Casas', 'Mejia', '3789876564', 'Mejia@hotmail.com', 'Avenida 12', 45, 'Masculino'),
(5, '9878989987', 'Manuela', 'Ximena', 'Pava', 'Torre', '3678475849', 'Torre@gmail.com', 'Calle 48', 20, 'Femenino'),
(6, '9764735643', 'Ana', 'Maria', 'Mar', 'Posada', '3098475432', 'Posada10@gmail.com', 'Calle 89', 22, 'Femenino'),
(7, '76453234546', 'Monica', 'Patricia', 'Avalos', 'Mendoza', '3219878906', 'Mendoza@yahoo.com', 'Avenida 34', 24, 'Femenino'),
(8, '3647898765', 'Sebastian', 'Carlos', 'Yepez', 'Campo', '3678985678', 'Campo90@hotmail.com', 'Calle 79', 56, 'Masculino'),
(9, '8765434567', 'Sara', 'Teresa', 'Sanchez', 'Pinar', '3874564578', 'Pinar95@gmail.com', 'Avenida 23', 21, 'Femenino'),
(10, '8474567890', 'Adriana', 'Marcela', 'Quintero', 'Vasquez', '3789475678', 'Vasquez13@yahoo.com', 'Calle 90', 30, 'Femenino'),
(11, '6475849384', 'Sandra', 'Alicia', 'Zapata', 'Higuita', '3056787645', 'Higuita12@gmail.com', 'Calle 54', 46, 'Femenino');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
