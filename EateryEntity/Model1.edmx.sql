
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/29/2023 13:52:31
-- Generated from EDMX file: C:\Users\vasia\work\Bender\EateryEntity\EateryEntity\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Eatery];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProductPurchase]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Purchase] DROP CONSTRAINT [FK_ProductPurchase];
GO
IF OBJECT_ID(N'[dbo].[FK_DishProduct_DishSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DishProduct] DROP CONSTRAINT [FK_DishProduct_DishSet];
GO
IF OBJECT_ID(N'[dbo].[FK_DishProduct_Product]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DishProduct] DROP CONSTRAINT [FK_DishProduct_Product];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DishSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DishSet];
GO
IF OBJECT_ID(N'[dbo].[Product]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Product];
GO
IF OBJECT_ID(N'[dbo].[Purchase]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purchase];
GO
IF OBJECT_ID(N'[dbo].[DishProduct]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DishProduct];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DishSet'
CREATE TABLE [dbo].[DishSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Product'
CREATE TABLE [dbo].[Product] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(max)  NOT NULL,
    [Price] float  NOT NULL,
    [PurchaseId] int  NOT NULL
);
GO

-- Creating table 'Purchase'
CREATE TABLE [dbo].[Purchase] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [ProductId] int  NOT NULL
);
GO

-- Creating table 'DishProduct'
CREATE TABLE [dbo].[DishProduct] (
    [DishSet_Id] int  NOT NULL,
    [Product_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'DishSet'
ALTER TABLE [dbo].[DishSet]
ADD CONSTRAINT [PK_DishSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Product'
ALTER TABLE [dbo].[Product]
ADD CONSTRAINT [PK_Product]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Purchase'
ALTER TABLE [dbo].[Purchase]
ADD CONSTRAINT [PK_Purchase]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [DishSet_Id], [Product_Id] in table 'DishProduct'
ALTER TABLE [dbo].[DishProduct]
ADD CONSTRAINT [PK_DishProduct]
    PRIMARY KEY CLUSTERED ([DishSet_Id], [Product_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ProductId] in table 'Purchase'
ALTER TABLE [dbo].[Purchase]
ADD CONSTRAINT [FK_ProductPurchase]
    FOREIGN KEY ([ProductId])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductPurchase'
CREATE INDEX [IX_FK_ProductPurchase]
ON [dbo].[Purchase]
    ([ProductId]);
GO

-- Creating foreign key on [DishSet_Id] in table 'DishProduct'
ALTER TABLE [dbo].[DishProduct]
ADD CONSTRAINT [FK_DishProduct_DishSet]
    FOREIGN KEY ([DishSet_Id])
    REFERENCES [dbo].[DishSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Product_Id] in table 'DishProduct'
ALTER TABLE [dbo].[DishProduct]
ADD CONSTRAINT [FK_DishProduct_Product]
    FOREIGN KEY ([Product_Id])
    REFERENCES [dbo].[Product]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DishProduct_Product'
CREATE INDEX [IX_FK_DishProduct_Product]
ON [dbo].[DishProduct]
    ([Product_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------