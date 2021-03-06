USE [Gestion]
GO
/****** Object:  StoredProcedure [dbo].[Clientes_GetAll]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clientes_GetAll]
AS
SET NOCOUNT ON
SELECT
	Clientes.Id, 
	Clientes.RazonSocial, 
	Clientes.CUIT, 
	Clientes.Activo

FROM Clientes WITH (NOLOCK)


GO
/****** Object:  StoredProcedure [dbo].[Clientes_GetByActivo]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clientes_GetByActivo]
	@blnActivo 	Bit
AS
SET NOCOUNT ON
SELECT
	Clientes.Id, 
	Clientes.RazonSocial, 
	Clientes.CUIT, 
	Clientes.Activo

FROM Clientes WITH (NOLOCK)
WHERE Clientes.Activo = @blnActivo


GO
/****** Object:  StoredProcedure [dbo].[Clientes_GetById]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Clientes_GetById]
	@intId 	Int
AS
SET NOCOUNT ON
SELECT
	Clientes.Id, 
	Clientes.RazonSocial, 
	Clientes.CUIT, 
	Clientes.Activo

FROM Clientes WITH (NOLOCK)
WHERE Clientes.Id = @intId


GO
/****** Object:  StoredProcedure [dbo].[Clientes_Insert]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Clientes_Insert]
	@strRazonSocial	varchar(150) = null, 
	@strCUIT		varchar(20) = null, 
	@blnActivo		bit = null
AS
--SET NOCOUNT ON
INSERT INTO Clientes_ (
	Clientes.RazonSocial, 
	Clientes.CUIT, 
	Clientes.Activo
)VALUES(
	@strRazonSocial, 
	@strCUIT, 
	@blnActivo
)

RETURN SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[Clientes_InsertScalar]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Clientes_InsertScalar]
	@strRazonSocial	varchar(150) = null, 
	@strCUIT		varchar(20) = null, 
	@blnActivo		bit = null
AS
--SET NOCOUNT ON
INSERT INTO Clientes_ (
	Clientes.RazonSocial, 
	Clientes.CUIT, 
	Clientes.Activo
)VALUES(
	@strRazonSocial, 
	@strCUIT, 
	@blnActivo
)

SELECT SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[Personas_GetAll]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Personas_GetAll]
AS
SET NOCOUNT ON
SELECT
	Personas.Id, 
	Personas.Nombre, 
	Personas.Email, 
	Personas.Activo

FROM Personas WITH (NOLOCK)


GO
/****** Object:  StoredProcedure [dbo].[Personas_GetByActivo]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Personas_GetByActivo]
	@blnActivo 	Bit
AS
SET NOCOUNT ON
SELECT
	Personas.Id, 
	Personas.Nombre, 
	Personas.Email, 
	Personas.Activo

FROM Personas WITH (NOLOCK)
WHERE Personas.Activo = @blnActivo


GO
/****** Object:  StoredProcedure [dbo].[Personas_GetById]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Personas_GetById]
	@intId 	Int
AS
SET NOCOUNT ON
SELECT
	Personas.Id, 
	Personas.Nombre, 
	Personas.Email, 
	Personas.Activo

FROM Personas WITH (NOLOCK)
WHERE Personas.Id = @intId


GO
/****** Object:  StoredProcedure [dbo].[Personas_Insert]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Personas_Insert]
	@strNombre	varchar(150) = null, 
	@strEmail	varchar(320) = null, 
	@blnActivo	bit = null
AS
--SET NOCOUNT ON
INSERT INTO Personas (
	Personas.Nombre, 
	Personas.Email, 
	Personas.Activo
)VALUES(
	@strNombre, 
	@strEmail, 
	@blnActivo
)

RETURN SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[Personas_InsertScalar]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Personas_InsertScalar]
	@strNombre	varchar(150) = null, 
	@strEmail	varchar(320) = null, 
	@blnActivo	bit = null
AS
--SET NOCOUNT ON
INSERT INTO Personas (
	Personas.Nombre, 
	Personas.Email, 
	Personas.Activo
)VALUES(
	@strNombre, 
	@strEmail, 
	@blnActivo
)

SELECT SCOPE_IDENTITY()

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RazonSocial] [varchar](150) NULL,
	[CUIT] [varchar](20) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 7/2/2019 6:58:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NULL,
	[Email] [varchar](320) NULL,
	[Activo] [bit] NULL,
 CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [RazonSocial], [CUIT], [Activo]) VALUES (1, N'Garbarino S.A.', N'30-54008821-3', 1)
INSERT [dbo].[Clientes] ([Id], [RazonSocial], [CUIT], [Activo]) VALUES (2, N'YPF', N'30-54668997-9', 1)
INSERT [dbo].[Clientes] ([Id], [RazonSocial], [CUIT], [Activo]) VALUES (3, N'StarBucks', N'30-71004052-0', 0)
INSERT [dbo].[Clientes] ([Id], [RazonSocial], [CUIT], [Activo]) VALUES (4, N'ORT', N'33-54019689-9', 1)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
SET IDENTITY_INSERT [dbo].[Personas] ON 

INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (1, N'Arruguete', N'arruguete@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (2, N'Caputo', N'caputo@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (3, N'Farbiarz', N'farbiarz@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (4, N'Gibaut', N'gibaut@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (5, N'Houli', N'houli@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (6, N'Kemeny', N'kemeny@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (7, N'Lerner', N'lerner@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (8, N'Liu', N'liu@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (9, N'Lombardi', N'lombardi@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (10, N'Margossian', N'margossian@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (11, N'Peres', N'peres@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (12, N'Peret', N'peret@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (13, N'Rabinowicz', N'rabinowicz@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (14, N'Ramos', N'ramos@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (15, N'Riccardi', N'riccardi@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (16, N'Rosenblat', N'rosenblat@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (17, N'Saidman', N'saidman@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (18, N'Santoro', N'santoro@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (19, N'Schlafman', N'schlafman@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (20, N'Sporn', N'sporn@gmail.com', 0)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (21, N'Uberman', N'uberman@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (22, N'Vilamowski', N'vilamowski@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (23, N'Waibschnaider', N'waibschnaider@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (24, N'Wischñevsky', N'wischñevsky@gmail.com', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (1001, N'Cachito', N'cacho@castania.com.ar', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (1002, N'12', N'', 1)
INSERT [dbo].[Personas] ([Id], [Nombre], [Email], [Activo]) VALUES (1003, N'polsgy', N'', 0)
SET IDENTITY_INSERT [dbo].[Personas] OFF
