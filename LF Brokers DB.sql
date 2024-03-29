USE [master]
GO
/****** Object:  Database [LFbrokers]    Script Date: 9/18/2019 6:01:45 PM ******/
CREATE DATABASE [LFbrokers]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LFbrokers', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LFbrokers.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LFbrokers_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\LFbrokers_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [LFbrokers] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LFbrokers].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LFbrokers] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LFbrokers] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LFbrokers] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LFbrokers] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LFbrokers] SET ARITHABORT OFF 
GO
ALTER DATABASE [LFbrokers] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LFbrokers] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LFbrokers] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LFbrokers] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LFbrokers] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LFbrokers] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LFbrokers] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LFbrokers] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LFbrokers] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LFbrokers] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LFbrokers] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LFbrokers] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LFbrokers] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LFbrokers] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LFbrokers] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LFbrokers] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LFbrokers] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LFbrokers] SET RECOVERY FULL 
GO
ALTER DATABASE [LFbrokers] SET  MULTI_USER 
GO
ALTER DATABASE [LFbrokers] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LFbrokers] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LFbrokers] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LFbrokers] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LFbrokers] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'LFbrokers', N'ON'
GO
ALTER DATABASE [LFbrokers] SET QUERY_STORE = OFF
GO
USE [LFbrokers]
GO
/****** Object:  Table [dbo].[Aseguradora]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aseguradora](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Codigo] [int] NOT NULL,
 CONSTRAINT [PK_Aseguradora] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CodigoPostal]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CodigoPostal](
	[ID] [int] NOT NULL,
	[CodigoPostal] [nchar](10) NOT NULL,
	[Localidad] [int] NOT NULL,
	[Zona] [int] NOT NULL,
 CONSTRAINT [PK_CodigoPostal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[ID] [int] NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
	[Observaciones] [nvarchar](max) NULL,
	[Producto] [int] NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EspecialidadCliente]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EspecialidadCliente](
	[ID] [int] NOT NULL,
	[Especialidad] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
	[Vigente] [bit] NULL,
 CONSTRAINT [PK_EspecialidadCliente] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EspecialidadesCubiertas]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EspecialidadesCubiertas](
	[ID] [int] NOT NULL,
	[Especialidad] [int] NOT NULL,
	[MayorRiesgo] [bit] NULL,
	[Poliza] [int] NOT NULL,
 CONSTRAINT [PK_EspecialidadesCubiertas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EspecialidadPrimaPorSuma]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EspecialidadPrimaPorSuma](
	[ID] [int] NOT NULL,
	[Especialidad] [int] NOT NULL,
	[PrimaBase] [decimal](18, 0) NOT NULL,
	[SumaAsegurada] [decimal](18, 0) NOT NULL,
	[ProductoAseguradora] [int] NOT NULL,
	[EspecialidadCodigoExterno] [nchar](10) NOT NULL,
	[PrimaVigenteDesde] [date] NOT NULL,
 CONSTRAINT [PK_EspecialidadPrimaPorSuma] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquidacionAseguradora]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidacionAseguradora](
	[ID] [int] NOT NULL,
	[Aseguradora] [int] NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[Monto] [decimal](16, 2) NOT NULL,
 CONSTRAINT [PK_LiquidacionAseguradora] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LiquidacionPolizaCuota]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LiquidacionPolizaCuota](
	[ID] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
	[NroCuota] [int] NOT NULL,
	[Estado] [nvarchar](50) NOT NULL,
	[Monto] [decimal](16, 2) NOT NULL,
	[LiquidacionAseguradora] [int] NOT NULL,
 CONSTRAINT [PK_LiquidacionPolizaCuota] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Localidad]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Localidad](
	[ID] [int] NOT NULL,
	[Localidad] [nvarchar](50) NOT NULL,
	[Provincia] [int] NOT NULL,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionesCotizacion]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionesCotizacion](
	[ID] [int] NOT NULL,
	[Poliza] [int] NOT NULL,
	[PrimaBase] [decimal](18, 0) NOT NULL,
	[SumaAsegurada] [decimal](18, 0) NULL,
	[RecargoPrima%] [decimal](2, 2) NULL,
	[ComisionPrima] [decimal](2, 2) NULL,
	[PrimaPoliza] [decimal](18, 0) NULL,
	[PremioTotal] [decimal](18, 0) NULL,
	[PremioCuota] [decimal](18, 0) NULL,
	[Condicion] [nvarchar](50) NULL,
	[Aseguradora] [int] NOT NULL,
	[OpcionElegida] [bit] NULL,
 CONSTRAINT [PK_OpcionesCotizacion] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[ID] [int] NOT NULL,
	[TipoDocumento] [nvarchar](50) NOT NULL,
	[NroDocumento] [nvarchar](50) NOT NULL,
	[Nombres] [nvarchar](50) NOT NULL,
	[Apellidos] [nvarchar](50) NOT NULL,
	[Calle] [nvarchar](50) NOT NULL,
	[Altura] [int] NOT NULL,
	[Piso] [int] NULL,
	[Departamento] [nchar](10) NULL,
	[Obervaciones] [nvarchar](max) NULL,
	[FechaNacimiento] [date] NOT NULL,
	[CodigoPostal] [int] NOT NULL,
	[Telefono] [nvarchar](50) NULL,
	[Celular] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Poliza]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Poliza](
	[ID] [int] NOT NULL,
	[Cliente] [int] NOT NULL,
	[Estado] [nvarchar](50) NOT NULL,
	[CantidadCuotas] [int] NOT NULL,
	[ProductoAseguradora] [int] NOT NULL,
	[RecargosFinancieros] [decimal](2, 2) NOT NULL,
	[Impuestos] [decimal](2, 2) NOT NULL,
	[SumaAsegurada] [decimal](18, 0) NOT NULL,
	[PrimaBase] [decimal](18, 0) NOT NULL,
	[RecargoPrima%] [decimal](2, 2) NULL,
	[ComisionPrima] [decimal](2, 2) NULL,
	[PrimaPoliza] [decimal](18, 0) NULL,
	[PremioTotal] [decimal](18, 0) NULL,
	[PremioCuota] [decimal](18, 0) NULL,
	[VigenciaDesde] [date] NULL,
	[VigenciaHasta] [date] NULL,
	[Matricula] [nvarchar](50) NULL,
	[NumeroPoliza] [nvarchar](50) NULL,
	[Agente] [int] NOT NULL,
	[MotivoRecotizacion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Poliza] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID] [int] NOT NULL,
	[Producto] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
	[Ramo] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductoAseguradora]    Script Date: 9/18/2019 6:01:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductoAseguradora](
	[ID] [int] NOT NULL,
	[Producto] [int] NOT NULL,
	[Aseguradora] [int] NOT NULL,
	[Activo] [bit] NOT NULL,
	[ComisionPrimaBase] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_ProductoAseguradora] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 9/18/2019 6:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[ID] [int] NOT NULL,
	[Provincia] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ramo]    Script Date: 9/18/2019 6:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ramo](
	[ID] [int] NOT NULL,
	[Ramo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Ramo] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecargoCuotas]    Script Date: 9/18/2019 6:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecargoCuotas](
	[ID] [int] NOT NULL,
	[Aseguradora] [int] NOT NULL,
	[CantidadCuotas] [int] NOT NULL,
	[RecargoFinanciero] [decimal](16, 2) NOT NULL,
 CONSTRAINT [PK_RecargoCuotas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zona]    Script Date: 9/18/2019 6:01:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zona](
	[ID] [int] NOT NULL,
	[Zona] [nvarchar](50) NOT NULL,
	[Impuesto] [decimal](2, 2) NOT NULL,
 CONSTRAINT [PK_Zona] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CodigoPostal]  WITH CHECK ADD  CONSTRAINT [FK_CodigoPostal_Localidad] FOREIGN KEY([Localidad])
REFERENCES [dbo].[Localidad] ([ID])
GO
ALTER TABLE [dbo].[CodigoPostal] CHECK CONSTRAINT [FK_CodigoPostal_Localidad]
GO
ALTER TABLE [dbo].[CodigoPostal]  WITH CHECK ADD  CONSTRAINT [FK_CodigoPostal_Zona] FOREIGN KEY([Zona])
REFERENCES [dbo].[Zona] ([ID])
GO
ALTER TABLE [dbo].[CodigoPostal] CHECK CONSTRAINT [FK_CodigoPostal_Zona]
GO
ALTER TABLE [dbo].[EspecialidadCliente]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadCliente_Especialidad] FOREIGN KEY([Especialidad])
REFERENCES [dbo].[Especialidad] ([ID])
GO
ALTER TABLE [dbo].[EspecialidadCliente] CHECK CONSTRAINT [FK_EspecialidadCliente_Especialidad]
GO
ALTER TABLE [dbo].[EspecialidadesCubiertas]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesCubiertas_Especialidad] FOREIGN KEY([Especialidad])
REFERENCES [dbo].[Especialidad] ([ID])
GO
ALTER TABLE [dbo].[EspecialidadesCubiertas] CHECK CONSTRAINT [FK_EspecialidadesCubiertas_Especialidad]
GO
ALTER TABLE [dbo].[EspecialidadesCubiertas]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesCubiertas_Poliza] FOREIGN KEY([Poliza])
REFERENCES [dbo].[Poliza] ([ID])
GO
ALTER TABLE [dbo].[EspecialidadesCubiertas] CHECK CONSTRAINT [FK_EspecialidadesCubiertas_Poliza]
GO
ALTER TABLE [dbo].[EspecialidadPrimaPorSuma]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadPrimaPorSuma_Especialidad] FOREIGN KEY([Especialidad])
REFERENCES [dbo].[Especialidad] ([ID])
GO
ALTER TABLE [dbo].[EspecialidadPrimaPorSuma] CHECK CONSTRAINT [FK_EspecialidadPrimaPorSuma_Especialidad]
GO
ALTER TABLE [dbo].[EspecialidadPrimaPorSuma]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadPrimaPorSuma_ProductoAseguradora] FOREIGN KEY([ProductoAseguradora])
REFERENCES [dbo].[ProductoAseguradora] ([ID])
GO
ALTER TABLE [dbo].[EspecialidadPrimaPorSuma] CHECK CONSTRAINT [FK_EspecialidadPrimaPorSuma_ProductoAseguradora]
GO
ALTER TABLE [dbo].[LiquidacionAseguradora]  WITH CHECK ADD  CONSTRAINT [FK_LiquidacionAseguradora_Aseguradora] FOREIGN KEY([Aseguradora])
REFERENCES [dbo].[Aseguradora] ([ID])
GO
ALTER TABLE [dbo].[LiquidacionAseguradora] CHECK CONSTRAINT [FK_LiquidacionAseguradora_Aseguradora]
GO
ALTER TABLE [dbo].[LiquidacionPolizaCuota]  WITH CHECK ADD  CONSTRAINT [FK_LiquidacionPolizaCuota_LiquidacionAseguradora] FOREIGN KEY([LiquidacionAseguradora])
REFERENCES [dbo].[LiquidacionAseguradora] ([ID])
GO
ALTER TABLE [dbo].[LiquidacionPolizaCuota] CHECK CONSTRAINT [FK_LiquidacionPolizaCuota_LiquidacionAseguradora]
GO
ALTER TABLE [dbo].[LiquidacionPolizaCuota]  WITH CHECK ADD  CONSTRAINT [FK_LiquidacionPolizaCuota_Poliza] FOREIGN KEY([Poliza])
REFERENCES [dbo].[Poliza] ([ID])
GO
ALTER TABLE [dbo].[LiquidacionPolizaCuota] CHECK CONSTRAINT [FK_LiquidacionPolizaCuota_Poliza]
GO
ALTER TABLE [dbo].[Localidad]  WITH CHECK ADD  CONSTRAINT [FK_Localidad_Provincia] FOREIGN KEY([Provincia])
REFERENCES [dbo].[Provincia] ([ID])
GO
ALTER TABLE [dbo].[Localidad] CHECK CONSTRAINT [FK_Localidad_Provincia]
GO
ALTER TABLE [dbo].[OpcionesCotizacion]  WITH CHECK ADD  CONSTRAINT [FK_OpcionesCotizacion_Poliza] FOREIGN KEY([Poliza])
REFERENCES [dbo].[Poliza] ([ID])
GO
ALTER TABLE [dbo].[OpcionesCotizacion] CHECK CONSTRAINT [FK_OpcionesCotizacion_Poliza]
GO
ALTER TABLE [dbo].[Persona]  WITH CHECK ADD  CONSTRAINT [FK_Persona_CodigoPostal] FOREIGN KEY([CodigoPostal])
REFERENCES [dbo].[CodigoPostal] ([ID])
GO
ALTER TABLE [dbo].[Persona] CHECK CONSTRAINT [FK_Persona_CodigoPostal]
GO
ALTER TABLE [dbo].[Poliza]  WITH CHECK ADD  CONSTRAINT [FK_Poliza_Persona] FOREIGN KEY([Cliente])
REFERENCES [dbo].[Persona] ([ID])
GO
ALTER TABLE [dbo].[Poliza] CHECK CONSTRAINT [FK_Poliza_Persona]
GO
ALTER TABLE [dbo].[Poliza]  WITH CHECK ADD  CONSTRAINT [FK_Poliza_Persona1] FOREIGN KEY([Agente])
REFERENCES [dbo].[Persona] ([ID])
GO
ALTER TABLE [dbo].[Poliza] CHECK CONSTRAINT [FK_Poliza_Persona1]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Ramo] FOREIGN KEY([Ramo])
REFERENCES [dbo].[Ramo] ([ID])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Ramo]
GO
ALTER TABLE [dbo].[ProductoAseguradora]  WITH CHECK ADD  CONSTRAINT [FK_ProductoAseguradora_Aseguradora] FOREIGN KEY([Aseguradora])
REFERENCES [dbo].[Aseguradora] ([ID])
GO
ALTER TABLE [dbo].[ProductoAseguradora] CHECK CONSTRAINT [FK_ProductoAseguradora_Aseguradora]
GO
ALTER TABLE [dbo].[ProductoAseguradora]  WITH CHECK ADD  CONSTRAINT [FK_ProductoAseguradora_Producto] FOREIGN KEY([Producto])
REFERENCES [dbo].[Producto] ([ID])
GO
ALTER TABLE [dbo].[ProductoAseguradora] CHECK CONSTRAINT [FK_ProductoAseguradora_Producto]
GO
ALTER TABLE [dbo].[RecargoCuotas]  WITH CHECK ADD  CONSTRAINT [FK_RecargoCuotas_Aseguradora] FOREIGN KEY([Aseguradora])
REFERENCES [dbo].[Aseguradora] ([ID])
GO
ALTER TABLE [dbo].[RecargoCuotas] CHECK CONSTRAINT [FK_RecargoCuotas_Aseguradora]
GO
USE [master]
GO
ALTER DATABASE [LFbrokers] SET  READ_WRITE 
GO
