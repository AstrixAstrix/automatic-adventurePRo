﻿CREATE TABLE [emp].[OrderX] (
    [Id]                INT            IDENTITY (1, 1) NOT NULL,
    [OrderId]           INT            NOT NULL,
    [ExternalOrderId]   NVARCHAR (36)  NOT NULL,
    [ExternalAccountId] NVARCHAR (36)  NOT NULL,
    [ExternalCompanyId] NVARCHAR (36)  NOT NULL,
    [Priority]          INT            NOT NULL,
    [Xml]               XML            NOT NULL,
    [ProvisionDate]     DATETIME2 (7)  NOT NULL,
    [StatusTypeId]      INT            NOT NULL,
    [OrginatingIp]      NVARCHAR (15)  NULL,
    [ActionTypeId]      INT            NOT NULL,
    [ResultMessage]     NVARCHAR (MAX) NULL,
    [CompletionDate]    DATETIME2 (7)  NULL,
    [StartDate]         DATETIME2 (7)  NULL,
    [Log]               NVARCHAR (MAX) NULL,
    [ResponseSent]      BIT            NOT NULL,
    [CreatedByUser]     NVARCHAR (20)  NOT NULL,
    [ModifiedByUser]    NVARCHAR (20)  NOT NULL,
    [DateCreated]       DATETIME2 (7)  NOT NULL,
    [DateModified]      DATETIME2 (7)  NOT NULL,
    [Version]           INT            NOT NULL,
    [RecordModified]    DATETIME2 (7)  NOT NULL,
    [Action]            CHAR (1)       NOT NULL,
    CONSTRAINT [PK_ProvisionOrderX] PRIMARY KEY CLUSTERED ([Id] ASC)
);

