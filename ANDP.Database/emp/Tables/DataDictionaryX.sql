﻿CREATE TABLE [emp].[DataDictionaryX] (
    [Id]               INT           IDENTITY (1, 1) NOT NULL,
    [DataDictionaryId] INT           NOT NULL,
    [CompanyId]        INT           NOT NULL,
    [EquipmentId]      INT           NOT NULL,
    [Key1]             NVARCHAR (50) NOT NULL,
    [Key2]             NVARCHAR (50) NOT NULL,
    [Key3]             NVARCHAR (50) NOT NULL,
    [Key4]             NVARCHAR (50) NOT NULL,
    [Key5]             NVARCHAR (50) NOT NULL,
    [Key6]             NVARCHAR (50) NOT NULL,
    [Key7]             NVARCHAR (50) NOT NULL,
    [Key8]             NVARCHAR (50) NOT NULL,
    [Key9]             NVARCHAR (50) NOT NULL,
    [Value1]           NVARCHAR (50) NOT NULL,
    [Value2]           NVARCHAR (50) NOT NULL,
    [Value3]           NVARCHAR (50) NOT NULL,
    [Value4]           NVARCHAR (50) NOT NULL,
    [Value5]           NVARCHAR (50) NOT NULL,
    [Value6]           NVARCHAR (50) NOT NULL,
    [Value7]           NVARCHAR (50) NOT NULL,
    [Value8]           NVARCHAR (50) NOT NULL,
    [Value9]           NVARCHAR (50) NOT NULL,
    [Active]           BIT           NOT NULL,
    [CreatedByUser]    NVARCHAR (20) NOT NULL,
    [ModifiedByUser]   NVARCHAR (20) NOT NULL,
    [DateCreated]      DATETIME2 (7) NOT NULL,
    [DateModified]     DATETIME2 (7) NOT NULL,
    [Version]          INT           NOT NULL,
    [RecordModified]   DATETIME2 (7) NOT NULL,
    [Action]           CHAR (1)      NOT NULL,
    CONSTRAINT [PK_emp_DataDictionaryX] PRIMARY KEY CLUSTERED ([Id] ASC)
);

