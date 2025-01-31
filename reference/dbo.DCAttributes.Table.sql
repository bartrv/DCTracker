USE [testJunkDB]
GO
/****** Object:  Table [dbo].[DCAttributes]    Script Date: 8/1/2023 10:48:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DCAttributes](
	[AttributeID] [int] IDENTITY(1,1) NOT NULL,
	[AttributeName] [nvarchar](64) NOT NULL,
	[AttributeValue] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AttributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DCAttributes] ON 

INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (1, N'Reflexes', 0)
INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (2, N'Coordination', 0)
INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (3, N'Physique', 0)
INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (4, N'Knowledge', 0)
INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (5, N'Perception', 0)
INSERT [dbo].[DCAttributes] ([AttributeID], [AttributeName], [AttributeValue]) VALUES (6, N'Presence', 0)
SET IDENTITY_INSERT [dbo].[DCAttributes] OFF
GO
