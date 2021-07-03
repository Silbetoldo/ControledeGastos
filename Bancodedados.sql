-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 14-Jun-2021 às 00:09
-- Versão do servidor: 10.4.18-MariaDB
-- versão do PHP: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `contas`
--
DROP DATABASE IF EXISTS `contas`;
CREATE DATABASE IF NOT EXISTS `contas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `contas`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `contas`
--

DROP TABLE IF EXISTS `contas`;
CREATE TABLE `contas` (
  `IdContas` int(11) NOT NULL,
  `tipo` varchar(80) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `compra` varchar(80) COLLATE utf8mb4_unicode_520_ci NOT NULL,
  `valor` decimal(10,2) DEFAULT NULL,
  `pago` varchar(80) COLLATE utf8mb4_unicode_520_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_520_ci;

--
-- Extraindo dados da tabela `contas`
--

INSERT INTO `contas` (`IdContas`, `tipo`, `compra`, `valor`, `pago`) VALUES
(105, 'Fixa', 'Energia', '50.00', 'Sim'),
(106, 'Fixa', 'Agua', '40.00', 'Sim'),
(108, 'Fixa', 'Sapato', '50.00', 'Sim'),
(109, 'Variável', 'Short', '30.00', 'Sim');

-- --------------------------------------------------------

--
-- Estrutura da tabela `login`
--

DROP TABLE IF EXISTS `login`;
CREATE TABLE `login` (
  `IdLogin` int(11) NOT NULL,
  `user` varchar(50) NOT NULL,
  `senha` varchar(128) NOT NULL,
  `Nome` varchar(80) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `login`
--

INSERT INTO `login` (`IdLogin`, `user`, `senha`, `Nome`) VALUES
(87, 'a', 'a', 'a'),
(88, 'sil', 'sil', 'Sil');

-- --------------------------------------------------------

--
-- Estrutura da tabela `logincontas`
--

DROP TABLE IF EXISTS `logincontas`;
CREATE TABLE `logincontas` (
  `IdLogin` int(11) NOT NULL,
  `IdContas` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `contas`
--
ALTER TABLE `contas`
  ADD PRIMARY KEY (`IdContas`);

--
-- Índices para tabela `login`
--
ALTER TABLE `login`
  ADD PRIMARY KEY (`IdLogin`);

--
-- Índices para tabela `logincontas`
--
ALTER TABLE `logincontas`
  ADD UNIQUE KEY `idloginContasFK` (`IdLogin`),
  ADD UNIQUE KEY `idContasloginFK` (`IdContas`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `contas`
--
ALTER TABLE `contas`
  MODIFY `IdContas` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=112;

--
-- AUTO_INCREMENT de tabela `login`
--
ALTER TABLE `login`
  MODIFY `IdLogin` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=89;

--
-- Restrições para despejos de tabelas
--

--
-- Limitadores para a tabela `logincontas`
--
ALTER TABLE `logincontas`
  ADD CONSTRAINT `IdContasloginFK` FOREIGN KEY (`IdContas`) REFERENCES `contas` (`IdContas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `IdloginContasFK` FOREIGN KEY (`IdLogin`) REFERENCES `login` (`IdLogin`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
