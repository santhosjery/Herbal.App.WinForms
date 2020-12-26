/****** Object:  Table [dbo].[Tax]    Script Date: 10/10/2020 16:15:28 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Scale](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ScaleName] [varchar](500) NULL,
	[IsActive] [bit] NOT NULL,
	[CreatedOn] [datetime] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[ModifiedOn] [datetime] NULL,
	[ModifiedBy] [int] NULL,
 CONSTRAINT [PK_Scale] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Scale]  WITH CHECK ADD  CONSTRAINT [FK_Scale_AppUser] FOREIGN KEY([CreatedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[Scale] CHECK CONSTRAINT [FK_Scale_AppUser]
GO

ALTER TABLE [dbo].[Scale]  WITH CHECK ADD  CONSTRAINT [FK_Scale_AppUser1] FOREIGN KEY([ModifiedBy])
REFERENCES [dbo].[AppUser] ([Id])
GO

ALTER TABLE [dbo].[Scale] CHECK CONSTRAINT [FK_Scale_AppUser1]
GO
