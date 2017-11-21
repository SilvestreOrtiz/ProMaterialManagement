USE [DataMaster]
GO
/****** Object:  Table [dbo].[AceroGHerramienta]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AceroGHerramienta](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[Calidad] [text] NULL,
	[Perfil] [text] NULL,
	[Acabado] [text] NULL,
	[Medidas] [text] NULL,
	[Tipo] [text] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_AceroGHerramienta] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AceroGMaquinaria]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AceroGMaquinaria](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[Calidad] [text] NULL,
	[Perfil] [text] NULL,
	[Acabado] [text] NULL,
	[Medidas] [text] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_AceroGMaquinaria] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AceroInoxidable]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AceroInoxidable](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[Calidad] [text] NULL,
	[Perfil] [text] NULL,
	[Acabado] [text] NULL,
	[Espesor] [text] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_AceroInoxidable] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Material]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/****** Object:  Table [dbo].[Metales]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metales](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[Mineral] [text] NULL,
	[MateriaPrima] [text] NULL,
	[SemiFabricado] [text] NULL,
	[Estado] [text] NULL,
	[Cantidad] [int] NULL,
 CONSTRAINT [PK_Metales] PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 20/11/2017 13:12:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Tipo] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AceroGHerramienta] ON 

INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (1, N'D-2', N'REDONDO', N'PREMAQUINADO', N'1/2"A24"', N'ACEROS HERRAMIENTA PARA TRABAJO FRIO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (2, N'D-2', N'PLACA', N'LAMINADO CALIENTE', N'1/2"A12"', N'ACEROS HERRAMIENTA PARA TRABAJO FRIO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (3, N'0-1', N'REDONDO', N'PREMAQUINADO', N'1/2"A91/2"', N'ACEROS HERRAMIENTA PARA TRABAJO FRIO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (4, N'0-1', N'PLACA', N'LAMINADO CALIENTE', N'1/2"A4"', N'ACEROS HERRAMIENTA PARA TRABAJO FRIO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (5, N'ACERO PLATA W-1', N'REDONDO', N'RECTIFICADO', N'1/8"A4"', N'ACEROS HERRAMIENTA PARA TRABAJO FRIO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (6, N'H-13', N'REDONDO', N'PREMAQUINADO', N'1/2"A16"', N'ACEROS HERRAMENTA TRABAJO CALIENTE', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (7, N'H-13', N'REDONDO', N'LAMINADO CALIENTE', N'1/2"A16"', N'ACEROS HERRAMENTA TRABAJO CALIENTE', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (8, N'H-13', N'PLACA', N'LAMINADO CALIENTE', N'1/2"A14"', N'ACEROS HERRAMENTA TRABAJO CALIENTE', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (9, N'S-7', N'PLACA', N'LAMINADO CALIENTE', N'1"A8"', N'ACEROS HERRAMENTA TRABAJO A IMPACTO', NULL)
INSERT [dbo].[AceroGHerramienta] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Tipo], [Cantidad]) VALUES (10, N'M-2', N'REDONDO', N'ESTIRADO EN FRIO', N'9MM A 105MM', N'ACEROS HERRAMENTA ALTA VELOCIDAD', NULL)
SET IDENTITY_INSERT [dbo].[AceroGHerramienta] OFF
SET IDENTITY_INSERT [dbo].[AceroGMaquinaria] ON 

INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (1, N'1018', N'REDONDO', N'ESTIRADO EN FRIO', N'1/8" A 6 1/2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (2, N'1018', N'REDONDO', N'LAMINADO EN CALIENTE  Y PREMAQUINADO', N'3 1/4" A 15"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (3, N'1018', N'CUADRADO', N'ESTIRADO EN FRIO', N'1/8"A4"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (4, N'1018', N'HEXAGONAL', N'ESTIRADO EN FRIO', N'3/8"A2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (5, N'1018', N'SOLERAS', N'ESTIRADO EN FRIO', N'1/8"X1/2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (6, N'1045', N'REDONDO', N'ESTIRADO EN FRIO', N'1/4"4"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (7, N'1045', N'REDONDO', N'LAMINADO EN CALIENTE', N'4 1/8"A28"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (8, N'1045', N'PLACA', N'LAMINADO EN CALIENTE', N'1/2"A5"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (9, N'12L14', N'REDONDO', N'ESTIRADO EN FRIO', N'3/16"A31/2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (10, N'12L14', N'HEXAGONAL', N'ESTIRADO EN FRIO', N'1/4"A3"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (11, N'4140', N'REDONDO', N'ESTIRADO EN FRIO', N'1/2"A41/2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (12, N'4140R', N'REDONDO', N'LAMINADO CALIENTE', N'1"A24"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (13, N'4140R', N'PLACA', N'LAMINADO CALIENTE', N'1/2"A41/2"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (14, N'4140LC', N'REDONDO', N'LAMINADO CALIENTE', N'7/8"A24"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (15, N'4140LC', N'PLACAS', N'LAMINADO CALIENTE', N'1/2"A14"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (16, N'8620', N'REDONDO', N'ESTIRADO EN FRIO', N'9/16"A4"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (17, N'8620', N'REDONDO', N'ESTIRADO EN FRIO', N'3"A 18"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (18, N'9840R', N'REDONDO', N'LAMINADO CALIENTE', N'1"A10"', NULL)
INSERT [dbo].[AceroGMaquinaria] ([idMaterial], [Calidad], [Perfil], [Acabado], [Medidas], [Cantidad]) VALUES (19, N'9840R', N'REDONDO', N'LAMINADO CALIENTE', N'1"A12"', NULL)
SET IDENTITY_INSERT [dbo].[AceroGMaquinaria] OFF
SET IDENTITY_INSERT [dbo].[AceroInoxidable] ON 

INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (1, N'T303', N'REDONDOS', N'ESTIRADO EN FRIO Y RECTIFICADO', N'3/16"A23/4"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (2, N'T304', N'REDONDOS', N'ESTIRADO EN FRIO Y RECTIFICADO', N'3/16"A12"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (3, N'T304', N'CUADRADOS', N'ESTIRADO EN FRIO', N'3/8"A21/2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (4, N'T304', N'HEXAGONALES', N'ESTIRADO EN  FRIO', N'5/8"A2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (5, N'T304', N'SOLERAS PERLIFICADAS', N'LAMINADO EN CALIENTE', N'1/8"A1"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (6, N'T304', N'ANGULOS', N'LAMINADO EN CALIENTE', N'3/16"A1/4"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (7, N'T304L', N'REDONDOS', N'ESTIRADO EN FRIO Y RECTIFICADO', N'3/16"A23/4"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (8, N'T304L', N'REDONDOS', N'ESTIRADO EN FRIO Y RECTIFICADO', N'3/16"A12"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (9, N'T304L', N'CUADRADOS', N'ESTIRADO EN FRIO', N'3/8"A21/2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (10, N'T304L', N'HEXAGONALES', N'ESTIRADO EN  FRIO', N'3/8"A21/2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (11, N'T304L', N'SOLERAS PERLIFICADAS', N'LAMINADO EN CALIENTE', N'1/8"A1"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (12, N'T304L', N'ANGULOS', N'LAMINADO EN CALIENTE', N'3/16"A1/4"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (13, N'T316', N'REDONDOS', N'ESTIRADO EN FRIO', N'1/4"A31/2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (14, N'T316L', N'REDONDOS', N'ESTIRADO EN FRIO', N'1/4"A31/2"', NULL)
INSERT [dbo].[AceroInoxidable] ([idMaterial], [Calidad], [Perfil], [Acabado], [Espesor], [Cantidad]) VALUES (15, N'T416', N'REDONDOS', N'ESTIRADO EN FRIO U RECTIFICADO', N'3/16"A5"', NULL)
SET IDENTITY_INSERT [dbo].[AceroInoxidable] OFF
SET IDENTITY_INSERT [dbo].[Metales] ON 

INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (1, N'Cobre', N'Cobre Electrolitico', N'BARRAS', N'RECOCIDO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (2, N'Cobre', N'Cobre Electrolitico', N'SOLERAS', N'SEMIDURO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (3, N'Cobre', N'Cobre Electrolitico', N'PERFILES', N'DURO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (4, N'Cobre', N'Cobre Electrolitico', N'ALAMBRE', N'RECOCIDO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (5, N'Cobre', N'Cobre Electrolitico', N'LAMINA', N'SEMIDURO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (6, N'Cobre', N'Cobre Electrolitico', N'ENCINTA', N'DURO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (7, N'Cobre', N'Cobre Electrolitico', N'ENCINTA', N'ACERADO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (8, N'Cobre', N'COBRE 99,4% PUREZA', N'LAMINA', N'ACERADO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (9, N'Cobre', N'COBRE 99,4% PUREZA', N'TUBOS', N'DURO', NULL)
INSERT [dbo].[Metales] ([idMaterial], [Mineral], [MateriaPrima], [SemiFabricado], [Estado], [Cantidad]) VALUES (10, N'Cobre', N'COBRE', N'FUNDIDO', N'FUNDIDO', NULL)
SET IDENTITY_INSERT [dbo].[Metales] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Nombre], [Email], [Password], [Tipo], [Telefono]) VALUES (1, N'Silvestre', N'silvestre.isw@gmail.com', N'masterdata123', N'Administrador', N'6221635794')
INSERT [dbo].[Usuario] ([Id], [Nombre], [Email], [Password], [Tipo], [Telefono]) VALUES (2, N'evelyn', N'evelynfea.feax2@gmail.com', N'nose123', N'Administrado', N'6335545454')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
USE [master]
GO
ALTER DATABASE [DataMaster] SET  READ_WRITE 
GO
