
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/26/2021 22:05:41
-- Generated from EDMX file: D:\Diplom\Diplom\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Consumables_ToHardware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Сonsumables] DROP CONSTRAINT [FK_Consumables_ToHardware];
GO
IF OBJECT_ID(N'[dbo].[FK_Histoty_ToCabinet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Histoty] DROP CONSTRAINT [FK_Histoty_ToCabinet];
GO
IF OBJECT_ID(N'[dbo].[FK_Histoty_ToHardware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Histoty] DROP CONSTRAINT [FK_Histoty_ToHardware];
GO
IF OBJECT_ID(N'[dbo].[FK_MainGroup_ToHardware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MainGroup] DROP CONSTRAINT [FK_MainGroup_ToHardware];
GO
IF OBJECT_ID(N'[dbo].[FK_OtherHardwares_ToHardware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OtherHardwares] DROP CONSTRAINT [FK_OtherHardwares_ToHardware];
GO
IF OBJECT_ID(N'[dbo].[FK_Printers_ToHardware]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Printers] DROP CONSTRAINT [FK_Printers_ToHardware];
GO
IF OBJECT_ID(N'[dbo].[FK_ResponsiblePersons_ToCabinets]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResponsiblePersons] DROP CONSTRAINT [FK_ResponsiblePersons_ToCabinets];
GO
IF OBJECT_ID(N'[dbo].[FK_ResponsiblePersons_ToWorkers]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ResponsiblePersons] DROP CONSTRAINT [FK_ResponsiblePersons_ToWorkers];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cabinets]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cabinets];
GO
IF OBJECT_ID(N'[dbo].[Hardware]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hardware];
GO
IF OBJECT_ID(N'[dbo].[Histoty]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Histoty];
GO
IF OBJECT_ID(N'[dbo].[MainGroup]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MainGroup];
GO
IF OBJECT_ID(N'[dbo].[OtherHardwares]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OtherHardwares];
GO
IF OBJECT_ID(N'[dbo].[Printers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Printers];
GO
IF OBJECT_ID(N'[dbo].[ResponsiblePersons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ResponsiblePersons];
GO
IF OBJECT_ID(N'[dbo].[Workers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Workers];
GO
IF OBJECT_ID(N'[dbo].[Сonsumables]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Сonsumables];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cabinets'
CREATE TABLE [dbo].[Cabinets] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(10)  NOT NULL,
    [Floor] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Hardware'
CREATE TABLE [dbo].[Hardware] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [SerialNumber] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Histoty'
CREATE TABLE [dbo].[Histoty] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [IsEnterUsing] bit  NOT NULL,
    [CabinetId] int  NOT NULL,
    [HardwareId] int  NOT NULL
);
GO

-- Creating table 'MainGroup'
CREATE TABLE [dbo].[MainGroup] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ModelProcessor] nvarchar(50)  NOT NULL,
    [RAM] int  NOT NULL,
    [DiskSize] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'OtherHardwares'
CREATE TABLE [dbo].[OtherHardwares] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Description] nvarchar(100)  NOT NULL
);
GO

-- Creating table 'Printers'
CREATE TABLE [dbo].[Printers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(50)  NOT NULL,
    [TypeCartridge] nvarchar(50)  NOT NULL,
    [HavePrintDoubleList] bit  NOT NULL,
    [IsMFY] bit  NOT NULL
);
GO

-- Creating table 'Workers'
CREATE TABLE [dbo].[Workers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Name] nvarchar(50)  NOT NULL,
    [MiddleName] nvarchar(50)  NOT NULL,
    [Position] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Сonsumables'
CREATE TABLE [dbo].[Сonsumables] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Model] nvarchar(50)  NOT NULL,
    [Interface] nvarchar(20)  NOT NULL,
    [Amount] int  NOT NULL
);
GO

-- Creating table 'ResponsiblePersons'
CREATE TABLE [dbo].[ResponsiblePersons] (
    [Workers_Id] int  NOT NULL,
    [Cabinets_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cabinets'
ALTER TABLE [dbo].[Cabinets]
ADD CONSTRAINT [PK_Cabinets]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Hardware'
ALTER TABLE [dbo].[Hardware]
ADD CONSTRAINT [PK_Hardware]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Histoty'
ALTER TABLE [dbo].[Histoty]
ADD CONSTRAINT [PK_Histoty]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MainGroup'
ALTER TABLE [dbo].[MainGroup]
ADD CONSTRAINT [PK_MainGroup]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OtherHardwares'
ALTER TABLE [dbo].[OtherHardwares]
ADD CONSTRAINT [PK_OtherHardwares]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Printers'
ALTER TABLE [dbo].[Printers]
ADD CONSTRAINT [PK_Printers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Workers'
ALTER TABLE [dbo].[Workers]
ADD CONSTRAINT [PK_Workers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Сonsumables'
ALTER TABLE [dbo].[Сonsumables]
ADD CONSTRAINT [PK_Сonsumables]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Workers_Id], [Cabinets_Id] in table 'ResponsiblePersons'
ALTER TABLE [dbo].[ResponsiblePersons]
ADD CONSTRAINT [PK_ResponsiblePersons]
    PRIMARY KEY CLUSTERED ([Workers_Id], [Cabinets_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CabinetId] in table 'Histoty'
ALTER TABLE [dbo].[Histoty]
ADD CONSTRAINT [FK_Histoty_ToCabinet]
    FOREIGN KEY ([CabinetId])
    REFERENCES [dbo].[Cabinets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Histoty_ToCabinet'
CREATE INDEX [IX_FK_Histoty_ToCabinet]
ON [dbo].[Histoty]
    ([CabinetId]);
GO

-- Creating foreign key on [Id] in table 'Сonsumables'
ALTER TABLE [dbo].[Сonsumables]
ADD CONSTRAINT [FK_Consumables_ToHardware]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Hardware]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [HardwareId] in table 'Histoty'
ALTER TABLE [dbo].[Histoty]
ADD CONSTRAINT [FK_Histoty_ToHardware]
    FOREIGN KEY ([HardwareId])
    REFERENCES [dbo].[Hardware]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Histoty_ToHardware'
CREATE INDEX [IX_FK_Histoty_ToHardware]
ON [dbo].[Histoty]
    ([HardwareId]);
GO

-- Creating foreign key on [Id] in table 'MainGroup'
ALTER TABLE [dbo].[MainGroup]
ADD CONSTRAINT [FK_MainGroup_ToHardware]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Hardware]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'OtherHardwares'
ALTER TABLE [dbo].[OtherHardwares]
ADD CONSTRAINT [FK_OtherHardwares_ToHardware]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Hardware]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Printers'
ALTER TABLE [dbo].[Printers]
ADD CONSTRAINT [FK_Printers_ToHardware]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Hardware]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Workers_Id] in table 'ResponsiblePersons'
ALTER TABLE [dbo].[ResponsiblePersons]
ADD CONSTRAINT [FK_ResponsiblePersons_Workers]
    FOREIGN KEY ([Workers_Id])
    REFERENCES [dbo].[Workers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Cabinets_Id] in table 'ResponsiblePersons'
ALTER TABLE [dbo].[ResponsiblePersons]
ADD CONSTRAINT [FK_ResponsiblePersons_Cabinets]
    FOREIGN KEY ([Cabinets_Id])
    REFERENCES [dbo].[Cabinets]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ResponsiblePersons_Cabinets'
CREATE INDEX [IX_FK_ResponsiblePersons_Cabinets]
ON [dbo].[ResponsiblePersons]
    ([Cabinets_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------