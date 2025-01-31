USE [testJunkDB]
GO
/****** Object:  Table [dbo].[DCSkills]    Script Date: 8/1/2023 10:48:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DCSkills](
	[SkillID] [int] IDENTITY(1,1) NOT NULL,
	[SkillName] [nvarchar](64) NOT NULL,
	[ParentAttribute] [int] NOT NULL,
	[SkillValue] [int] NOT NULL,
	[ParentSkillID] [int] NULL,
	[IsSpecial] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DCSkills] ON 

INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (1, N'Acrobatics', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (2, N'Boating', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (3, N'Brawling', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (4, N'Climbing', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (5, N'Dodge', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (6, N'Driving', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (7, N'Martial Arts', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (8, N'Melee Weapons', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (9, N'Piloting', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (10, N'Riding', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (11, N'Sneak', 1, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (12, N'Catch', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (13, N'Lockpicking', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (14, N'Marksmanship', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (15, N'Missile Weapons', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (16, N'Slight of Hand', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (17, N'Thievery', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (18, N'Thrown Weapons', 2, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (19, N'Flying', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (20, N'Leap', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (21, N'Lifting', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (22, N'Resistance', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (23, N'Running', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (24, N'Swimming', 3, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (25, N'Arcane Lore', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (26, N'Computer Ops.', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (27, N'Criminology', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (28, N'Demolitions', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (29, N'Forgery', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (30, N'Languages', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (31, N'Medicine', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (32, N'Navigation', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (33, N'Research', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (34, N'Scholar', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (35, N'Science', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (36, N'Security', 4, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (37, N'Artist', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (38, N'Engineering', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (39, N'Hide', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (40, N'Invent', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (41, N'Know-How', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (42, N'Repair', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (43, N'Search', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (44, N'Shadowing', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (45, N'Streetwise', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (46, N'Surveillance', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (47, N'Survival', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (48, N'Tracking', 5, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (49, N'Animal Handling', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (50, N'Bluff', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (51, N'Charm', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (52, N'Command', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (53, N'Disguise', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (54, N'Interrogation', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (55, N'Intimidation', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (56, N'Persuasion', 6, 0, NULL, 0)
INSERT [dbo].[DCSkills] ([SkillID], [SkillName], [ParentAttribute], [SkillValue], [ParentSkillID], [IsSpecial]) VALUES (57, N'Willpower', 6, 0, NULL, 0)
SET IDENTITY_INSERT [dbo].[DCSkills] OFF
GO
ALTER TABLE [dbo].[DCSkills] ADD  DEFAULT ((0)) FOR [SkillValue]
GO
ALTER TABLE [dbo].[DCSkills] ADD  DEFAULT (NULL) FOR [ParentSkillID]
GO
ALTER TABLE [dbo].[DCSkills] ADD  CONSTRAINT [DF_DCSkills_IsSpecial]  DEFAULT ((0)) FOR [IsSpecial]
GO
