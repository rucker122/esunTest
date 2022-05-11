CREATE TABLE [dbo].[BRIDGE] (
    [ID]            INT           NOT NULL,
    [non_bridge]    NVARCHAR (10) NULL,
    [bridge_id]     NVARCHAR (10) NULL,
    [bridge_name]   NVARCHAR (20) NULL,
    [adm]           NVARCHAR (10) NULL,
    [section]       NVARCHAR (10) NULL,
    [county]        NVARCHAR (10) NULL,
    [town]          NVARCHAR (10) NULL,
    [route]         NVARCHAR (10) NULL,
    [river_cross]   NVARCHAR (2)  NULL,
    [double_bridge] NVARCHAR (2)  NULL,
    [designer]      NVARCHAR (10) NULL,
    [engineer]      NVARCHAR (10) NULL,
    [builder]       NVARCHAR (10) NULL,
    CONSTRAINT [PK_BRIDGE] PRIMARY KEY CLUSTERED ([ID] ASC)
);

