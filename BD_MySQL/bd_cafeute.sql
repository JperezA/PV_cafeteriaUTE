-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Servidor: localhost
-- Tiempo de generación: 28-05-2014 a las 20:33:22
-- Versión del servidor: 5.5.24-log
-- Versión de PHP: 5.4.3

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `bd_cafeute`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `clientes`
--

CREATE TABLE IF NOT EXISTS `clientes` (
  `idClientes` int(8) NOT NULL,
  `Clie_nombre` varchar(45) NOT NULL,
  `Clie_apellipat` varchar(45) NOT NULL,
  `Clie_apellimat` varchar(45) NOT NULL,
  `Clie_fechanac` varchar(45) NOT NULL,
  `Clie_imail` varchar(100) NOT NULL,
  `Clie_dir` varchar(200) NOT NULL,
  `Clie_dir_edifi` varchar(45) DEFAULT NULL,
  `Clie_cp` int(5) DEFAULT NULL,
  `Clie_estado` varchar(65) DEFAULT NULL,
  `Clie_id_user_sis` int(8) NOT NULL,
  PRIMARY KEY (`idClientes`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `comidas`
--

CREATE TABLE IF NOT EXISTS `comidas` (
  `Id_comidas` int(11) NOT NULL AUTO_INCREMENT,
  `com_nom` varchar(50) NOT NULL,
  `com_descrip` varchar(200) NOT NULL,
  `com_precio` double NOT NULL,
  PRIMARY KEY (`Id_comidas`),
  UNIQUE KEY `Id_comidas` (`Id_comidas`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `comidas`
--

INSERT INTO `comidas` (`Id_comidas`, `com_nom`, `com_descrip`, `com_precio`) VALUES
(1, 'Pirata', 'Combo Piratas', 35),
(2, 'papas', 'papas ', 20);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `corte`
--

CREATE TABLE IF NOT EXISTS `corte` (
  `idCorte` int(11) NOT NULL AUTO_INCREMENT,
  `Cor_fecha` datetime NOT NULL,
  `Cor_inicio` double NOT NULL,
  `Cor_final` double NOT NULL,
  `Cor_ganancia` double NOT NULL,
  `Cor_empleado` int(11) NOT NULL,
  PRIMARY KEY (`idCorte`),
  KEY `fk_corte_idx` (`Cor_empleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `credito`
--

CREATE TABLE IF NOT EXISTS `credito` (
  `idCredito` int(11) NOT NULL,
  `Clie_cred_saldo` varchar(45) NOT NULL,
  `Clie_cred_limite` varchar(45) DEFAULT NULL,
  KEY `fk_credito_clie_idx` (`idCredito`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleados`
--

CREATE TABLE IF NOT EXISTS `empleados` (
  `idEmpleados` int(4) NOT NULL AUTO_INCREMENT,
  `Em_nombre` varchar(45) NOT NULL,
  `Em_apellido` varchar(100) NOT NULL,
  `Em_direccion` varchar(70) NOT NULL,
  `Em_ciudad` varchar(45) NOT NULL,
  `Em_estado` varchar(45) NOT NULL,
  `Em_cp` int(5) DEFAULT NULL,
  `Em_telefono` varchar(15) DEFAULT NULL,
  `Em_correo` varchar(45) DEFAULT NULL,
  `Em_observacion` varchar(250) DEFAULT NULL,
  `Em_fecha` date NOT NULL,
  `Usuario_sis_id` int(5) DEFAULT NULL,
  `Movil` varchar(15) DEFAULT NULL,
  PRIMARY KEY (`idEmpleados`),
  KEY `fk_Empleados_Users1_idx` (`Usuario_sis_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `empleados`
--

INSERT INTO `empleados` (`idEmpleados`, `Em_nombre`, `Em_apellido`, `Em_direccion`, `Em_ciudad`, `Em_estado`, `Em_cp`, `Em_telefono`, `Em_correo`, `Em_observacion`, `Em_fecha`, `Usuario_sis_id`, `Movil`) VALUES
(1, 'ADMIN', 'admin', '------', '--------', '-------------', 0, '---------', 'jonatanperez83@gmail.com', 'Administrador del sistema', '2014-03-01', 1, '---------------'),
(2, 'JONATAN', 'PEREZ DEL ANGEL', 'QUERETARO #14091', 'APOCADA', 'NUEVO LEON', 2, '(111)111-0000', '------CORREO', 'Prueba1', '2014-03-30', 2, '222-222-0000'),
(3, 'q', 'q', 'qq', 'q', 'q', 22, '(   )   -', '2', '55', '2013-05-05', 3, '   -   -'),
(4, 'Gaby ', 'buentello ', ' aura', 'apodaca', 'nuevo leon', 66635, '(81 )   -', 'misa@hotmail.com', 'nada ', '2014-06-13', 4, '   -   -'),
(5, 'Christian ', 'Cantu', 'Mexico  86 #6732', 'Apodaca', 'Nuevo Leon ', 83030, '(   )   -', '--', '', '2014-07-31', 5, '   -   -');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `max_ticket`
--

CREATE TABLE IF NOT EXISTS `max_ticket` (
  `ticket` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `max_ticket`
--

INSERT INTO `max_ticket` (`ticket`) VALUES
(50);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nota_pedidos`
--

CREATE TABLE IF NOT EXISTS `nota_pedidos` (
  `idNota_pedidos` int(10) NOT NULL,
  `Ped_total` double NOT NULL,
  `Ped_fecha` datetime NOT NULL,
  `Ped_fechaentrega` datetime NOT NULL,
  `Ped_estado` varchar(15) NOT NULL,
  `Ped_id_clie` int(8) NOT NULL,
  PRIMARY KEY (`idNota_pedidos`),
  KEY `fk_pedi_clie_idx` (`Ped_id_clie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `nota_vent`
--

CREATE TABLE IF NOT EXISTS `nota_vent` (
  `idNota` int(10) NOT NULL AUTO_INCREMENT,
  `Not_total` double NOT NULL,
  `Not_fecha` datetime NOT NULL,
  `Not_pago` double NOT NULL,
  `Not_cambio` double NOT NULL,
  `Not_Id_cliente` int(5) NOT NULL,
  `Not_Id_empleado` int(4) NOT NULL,
  PRIMARY KEY (`idNota`),
  KEY `Fk_not_id_empleado_idx` (`Not_Id_empleado`),
  KEY `fk_not_id_cliente_idx` (`Not_Id_cliente`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=2 ;

--
-- Volcado de datos para la tabla `nota_vent`
--

INSERT INTO `nota_vent` (`idNota`, `Not_total`, `Not_fecha`, `Not_pago`, `Not_cambio`, `Not_Id_cliente`, `Not_Id_empleado`) VALUES
(1, 34, '2014-04-02 00:00:00', 2, 2, 0, 3);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `pedido_prod`
--

CREATE TABLE IF NOT EXISTS `pedido_prod` (
  `Nota_id_pedido` int(10) NOT NULL,
  `producto_descripcion` varchar(45) NOT NULL,
  `producto_precio` double NOT NULL,
  `producto_cantidad` int(11) NOT NULL,
  `producto_id` int(18) NOT NULL,
  KEY `fk_pedido_productos_idx` (`producto_id`),
  KEY `fk_pedido_nota_idx` (`Nota_id_pedido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE IF NOT EXISTS `productos` (
  `idProductos` int(18) NOT NULL AUTO_INCREMENT,
  `Produc_id_Proveedor` int(10) NOT NULL,
  `Prod_codigo` varchar(20) NOT NULL,
  `Prod_fecha` datetime NOT NULL,
  `Prod_nombre` varchar(45) NOT NULL,
  `Prod_existencia` double NOT NULL,
  `Prod_precio_provee` double NOT NULL,
  `Prod_precio_vent` double NOT NULL,
  `Pro_descrip` varchar(255) NOT NULL,
  `Unidad` tinyint(1) NOT NULL,
  PRIMARY KEY (`idProductos`),
  KEY `fk_prod_provee_idx` (`Produc_id_Proveedor`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=21 ;

--
-- Volcado de datos para la tabla `productos`
--

INSERT INTO `productos` (`idProductos`, `Produc_id_Proveedor`, `Prod_codigo`, `Prod_fecha`, `Prod_nombre`, `Prod_existencia`, `Prod_precio_provee`, `Prod_precio_vent`, `Pro_descrip`, `Unidad`) VALUES
(3, 10, '2', '2014-03-03 00:00:00', 'Coca', 10, 8, 10, 'ES un refresco', 0),
(16, 8, '1', '2014-04-04 03:47:11', 'GalletasX', 50, 3.5, 4, 'BUENISIMAS GALLLETAS', 1),
(17, 8, '3', '2014-04-04 03:47:38', 'GalletasY', 50, 3.5, 4.5, 'BUENISIMAS GALLLETAS', 1),
(18, 8, '4', '2014-04-04 03:47:59', 'GalletasZ', 50, 4.5, 5.5, 'BUENISIMAS GALLLETAS', 1),
(19, 7, '5', '2014-04-04 03:48:45', 'GALLETASB', 50, 6, 7, 'BUENISIMAS GALLLETAS', 1),
(20, 8, '6', '2014-04-08 00:18:30', 'XXXXX', 50, 1, 4, 'XXXXXXXXXXXXXXXXXXXXXXX', 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE IF NOT EXISTS `proveedores` (
  `idProveedores` int(11) NOT NULL AUTO_INCREMENT,
  `Provee_emprem` varchar(200) DEFAULT NULL,
  `provee_nombre` varchar(80) NOT NULL,
  `Provee_apellido` varchar(100) DEFAULT NULL,
  `Provee_direccion` varchar(200) DEFAULT NULL,
  `Provee_ciudad` varchar(65) DEFAULT NULL,
  `Provee_estado` varchar(65) DEFAULT NULL,
  `Provee_cp` int(5) DEFAULT NULL,
  `Provee_tel` varchar(15) DEFAULT NULL,
  `Provee_correo` varchar(100) DEFAULT NULL,
  `Provee_descrip` text,
  PRIMARY KEY (`idProveedores`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=11 ;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`idProveedores`, `Provee_emprem`, `provee_nombre`, `Provee_apellido`, `Provee_direccion`, `Provee_ciudad`, `Provee_estado`, `Provee_cp`, `Provee_tel`, `Provee_correo`, `Provee_descrip`) VALUES
(1, 'eme', 'coca', 'nn', 'direc', 'ciud', 'ess', 2323, 'te333', 'fhjskfs@sdi', 'dshdkjsjhfkjsfhjskf'),
(4, 'SHJDSO', 'Loscar', '2', '2', '2', '2 ', 22, '21', 'joana@adsa.com', 'ss'),
(6, 'H37218', 'Pepsico', 'pepsi', 'Av. Leon #4279', 'Monterrey', 'Nuevo Leon', 36127, '371931041', 'pepsico@pepsi.com', 'Es un distribuidor de refrescos'),
(7, 'YE282E2', 'GrupoBimbo', 'Bimbo', 'av. Saltillo #7328', 'Monterrey', 'Nuevo Leon', 37124, '2173042569', 'grupobimbo@bimbo.com', 'Es una empresa de distribución de Comestibles'),
(8, 'YE2733', 'GrupoArca', 'Arca', 'AV. Acapulco #7312', 'Apodaca', 'Nuevo Leon', 32090, '324929357092', 'grupoarca@arca.com', 'Es una empresa que distribuye refrescos y botanas '),
(9, 'N36GD', 'GrupoMoctezuma ', 'Carta blanca   ', 'Av. Miguel Aleman ', 'Apocada', 'Nuevo Leon', 37483, '054938843', 'grupomoctesuma@moctesuma.com          ', 'Es una empresa que distribulle Bebidas con Alcohol'),
(10, 'RII382', 'Coca Cola', '-------', 'AV. Colon #7612', 'Monterrey', 'Nuevo Leon', 3827, '2571931', 'coca@cocacola.com', 'Empresa que distribuye refrescos');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `provee_producto`
--

CREATE TABLE IF NOT EXISTS `provee_producto` (
  `id_provee_producto` int(11) NOT NULL AUTO_INCREMENT,
  `cod_productos` varchar(20) NOT NULL,
  `id_provee` int(11) NOT NULL,
  PRIMARY KEY (`id_provee_producto`),
  UNIQUE KEY `cod_productos` (`cod_productos`),
  KEY `cod_productos_2` (`cod_productos`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `idUsers` int(11) NOT NULL AUTO_INCREMENT,
  `U_name` varchar(10) NOT NULL,
  `U_pass` varchar(9) NOT NULL,
  `U_Type` varchar(45) NOT NULL,
  `UsVenta` tinyint(1) NOT NULL,
  `UsProductos` tinyint(1) NOT NULL,
  `UsPedidos` tinyint(1) NOT NULL,
  `UsCorte` tinyint(1) NOT NULL,
  `UsInventario` tinyint(1) NOT NULL,
  `UsProveedores` tinyint(1) NOT NULL,
  `UsClientes` tinyint(1) NOT NULL,
  `UsEmpleados` tinyint(1) NOT NULL,
  `UsConfiguracion` tinyint(1) NOT NULL,
  `UsPantalla` tinyint(1) NOT NULL,
  PRIMARY KEY (`idUsers`),
  UNIQUE KEY `U_name_UNIQUE` (`U_name`),
  UNIQUE KEY `idUsers` (`idUsers`),
  UNIQUE KEY `idUsers_2` (`idUsers`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=6 ;

--
-- Volcado de datos para la tabla `users`
--

INSERT INTO `users` (`idUsers`, `U_name`, `U_pass`, `U_Type`, `UsVenta`, `UsProductos`, `UsPedidos`, `UsCorte`, `UsInventario`, `UsProveedores`, `UsClientes`, `UsEmpleados`, `UsConfiguracion`, `UsPantalla`) VALUES
(1, 'Admin', 'Admin', 'Admin', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(2, 'jperez', 'hola111', 'Prueba21', 1, 0, 1, 0, 1, 0, 0, 0, 0, 1),
(3, 'qq', 'qq', 'qqq', 0, 0, 1, 0, 0, 1, 0, 0, 0, 0),
(4, 'misa', '123', '', 1, 1, 1, 1, 1, 1, 1, 1, 1, 1),
(5, 'christian', 'daewdda', 'empleado', 1, 1, 1, 1, 0, 0, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user_clie`
--

CREATE TABLE IF NOT EXISTS `user_clie` (
  `idUser_clie` int(8) NOT NULL,
  `Clie_user` varchar(45) NOT NULL,
  `Clie_pass` varchar(45) NOT NULL,
  KEY `fk_user_clie` (`idUser_clie`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

CREATE TABLE IF NOT EXISTS `ventas` (
  `idVenta` int(11) NOT NULL AUTO_INCREMENT,
  `Ven_prod_codigo` varchar(20) NOT NULL,
  `Ven_prod_descrip` varchar(45) NOT NULL,
  `Ven_pro_precvent` double NOT NULL,
  `Ven_cantidad` double NOT NULL,
  `Importe` double NOT NULL,
  `Not_id_venta` int(10) NOT NULL,
  PRIMARY KEY (`idVenta`),
  KEY `FK_Not_id_venta_idx` (`Not_id_venta`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=5 ;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`idVenta`, `Ven_prod_codigo`, `Ven_prod_descrip`, `Ven_pro_precvent`, `Ven_cantidad`, `Importe`, `Not_id_venta`) VALUES
(1, '3', 'GalletasY', 4.5, 1, 4.5, 2),
(2, '2', 'Coca', 10, 1, 10, 2),
(3, '2', 'Coca', 10, 1, 10, 2),
(4, '5', 'GALLETASB', 7, 1, 7, 2);

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `corte`
--
ALTER TABLE `corte`
  ADD CONSTRAINT `fk_corte` FOREIGN KEY (`Cor_empleado`) REFERENCES `empleados` (`idEmpleados`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `credito`
--
ALTER TABLE `credito`
  ADD CONSTRAINT `fk_credito_clie` FOREIGN KEY (`idCredito`) REFERENCES `clientes` (`idClientes`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `empleados`
--
ALTER TABLE `empleados`
  ADD CONSTRAINT `Usuarios_sis` FOREIGN KEY (`Usuario_sis_id`) REFERENCES `users` (`idUsers`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `nota_pedidos`
--
ALTER TABLE `nota_pedidos`
  ADD CONSTRAINT `fk_pedi_clie` FOREIGN KEY (`Ped_id_clie`) REFERENCES `clientes` (`idClientes`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `nota_vent`
--
ALTER TABLE `nota_vent`
  ADD CONSTRAINT `Fk_not_id_empleado` FOREIGN KEY (`Not_Id_empleado`) REFERENCES `empleados` (`idEmpleados`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `pedido_prod`
--
ALTER TABLE `pedido_prod`
  ADD CONSTRAINT `fk_pedido_nota` FOREIGN KEY (`Nota_id_pedido`) REFERENCES `nota_pedidos` (`idNota_pedidos`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_pedido_productos` FOREIGN KEY (`producto_id`) REFERENCES `productos` (`idProductos`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `productos`
--
ALTER TABLE `productos`
  ADD CONSTRAINT `fk_prod_provee` FOREIGN KEY (`Produc_id_Proveedor`) REFERENCES `proveedores` (`idProveedores`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Filtros para la tabla `user_clie`
--
ALTER TABLE `user_clie`
  ADD CONSTRAINT `fk_user_clie` FOREIGN KEY (`idUser_clie`) REFERENCES `clientes` (`idClientes`) ON DELETE NO ACTION ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
