CREATE TABLE IF NOT EXISTS `__EFMigrationsHistory` (
    `MigrationId` varchar(150) CHARACTER SET utf8mb4 NOT NULL,
    `ProductVersion` varchar(32) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK___EFMigrationsHistory` PRIMARY KEY (`MigrationId`)
) CHARACTER SET=utf8mb4;

START TRANSACTION;

ALTER DATABASE CHARACTER SET utf8mb4;

CREATE TABLE `user` (
    `id` INTEGER NOT NULL,
    `email` VARCHAR(100) CHARACTER SET utf8mb4 NOT NULL,
    `senha` VARCHAR(1000) CHARACTER SET utf8mb4 NOT NULL,
    CONSTRAINT `PK_user` PRIMARY KEY (`id`)
) CHARACTER SET=utf8mb4;

INSERT INTO `__EFMigrationsHistory` (`MigrationId`, `ProductVersion`)
VALUES ('20221102021128_V1.0.0_DDL_DATABASE', '6.0.10');

COMMIT;

