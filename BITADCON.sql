USE [BIT_ADCON]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Bitacora_Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario_Id] [int] NOT NULL,
	[Accion] [varchar](250) NOT NULL,
	[Detalles] [text] NULL,
	[Fecha] [timestamp] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Bitacora_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[Cargo_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Cargo] [varchar](50) NOT NULL,
	[Descripcion] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Cargo_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ciudades](
	[ciudadID] [int] IDENTITY(1,1) NOT NULL,
	[nombreCiudad] [nvarchar](200) NULL,
	[Pais_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Cliente_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Comercial] [varchar](250) NOT NULL,
	[RTN] [varchar](20) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[Pais_Id] [int] NOT NULL,
	[Telefono] [varchar](20) NOT NULL,
	[Pagina_web] [varchar](500) NULL,
	[Correo_Electronico] [varchar](500) NOT NULL,
	[Representante_legal] [varchar](250) NOT NULL,
	[Puesto] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Cliente_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contratos]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contratos](
	[Contrato_Id] [int] IDENTITY(10001,1) NOT NULL,
	[Fecha_Elaboracion] [date] NOT NULL,
	[Fecha_Inicio_Contrato] [date] NOT NULL,
	[Fecha_Fin_Contrato] [date] NOT NULL,
	[Moneda_Id] [char](2) NOT NULL,
	[Estatus] [varchar](50) NOT NULL,
	[Cliente_Id] [int] NOT NULL,
	[Empleado_Encargado_ID] [int] NOT NULL,
	[Tipo_Facturacion] [varchar](50) NOT NULL,
	[Cantidad_Cuotas] [int] NOT NULL,
	[Comentarios] [text] NOT NULL,
	[Renovacion_Automatica] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Contrato_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_Contrato]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_Contrato](
	[Detalle_Contrato_Id] [int] IDENTITY(1,1) NOT NULL,
	[Contrato_Id] [int] NOT NULL,
	[Producto_Id] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Impuesto] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NOT NULL,
	[Comentarios] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Detalle_Contrato_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Empleado_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empleado] [varchar](100) NOT NULL,
	[Apellido_Empleado] [varchar](100) NOT NULL,
	[Direccion_Empleado] [varchar](255) NOT NULL,
	[Correo_Empleado] [varchar](100) NOT NULL,
	[Cargo_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Empleado_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Moneda]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Moneda](
	[Codigo_Moneda] [char](2) NOT NULL,
	[Nombre_Moneda] [char](30) NOT NULL,
	[Abreviatura_Moneda] [char](10) NOT NULL,
	[Signo_Moneda] [char](3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo_Moneda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pais](
	[Pais_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Pais] [varchar](250) NULL,
	[Codigo_Iso] [char](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[Producto_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Producto] [varchar](100) NOT NULL,
	[marca] [varchar](100) NOT NULL,
	[modelo] [varchar](100) NOT NULL,
	[versionProducto] [varchar](100) NOT NULL,
	[Precio_Producto] [decimal](18, 2) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[Tipo_Usuario_Id] [int] IDENTITY(1,1) NOT NULL,
	[Nivel_Usuario] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Tipo_Usuario_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Usuario_Id] [int] IDENTITY(1,1) NOT NULL,
	[empleadoID] [int] NOT NULL,
	[Nombre_Usuario] [varchar](50) NOT NULL,
	[Contrasenia] [varchar](100) NOT NULL,
	[Tipo_Usuario_Id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuario_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios_Datos]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios_Datos](
	[Usuario_Datos_Id] [int] IDENTITY(1,1) NOT NULL,
	[Contrato_Id] [int] NOT NULL,
	[Nombre_Completo] [varchar](200) NOT NULL,
	[Direccion_Usuario] [varchar](255) NOT NULL,
	[Telefono_Usuario] [varchar](20) NOT NULL,
	[Correo_Usuario] [varchar](100) NOT NULL,
	[Puesto_Usuario] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Usuario_Datos_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD FOREIGN KEY([Cargo_Id])
REFERENCES [dbo].[Cargos] ([Cargo_Id])
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD CHECK  (([Estatus]='Anulado' OR [Estatus]='Vencido' OR [Estatus]='Aprobado' OR [Estatus]='Grabación'))
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD CHECK  (([Renovacion_Automatica]='No' OR [Renovacion_Automatica]='Si'))
GO
ALTER TABLE [dbo].[Contratos]  WITH CHECK ADD CHECK  (([Tipo_Facturacion]='Anual' OR [Tipo_Facturacion]='Semestral' OR [Tipo_Facturacion]='Trimestral' OR [Tipo_Facturacion]='Bimestral' OR [Tipo_Facturacion]='Mensual'))
GO
ALTER TABLE [dbo].[Tipo_Usuario]  WITH CHECK ADD CHECK  (([Nivel_Usuario]='Usuario Basico' OR [Nivel_Usuario]='Administrador'))
GO
/****** Object:  StoredProcedure [dbo].[CRUD_CARGOS]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_CARGOS]
@accion NVARCHAR(10) = NULL,
@codigo int = null,
@cargo VARCHAR(50) = NULL,
@descripcion VARCHAR(100) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Cargo_Id, Nombre_Cargo, Descripcion
		FROM [dbo].[Cargos]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Cargos]
           ([Nombre_Cargo]
           ,[Descripcion])
		VALUES
           (@cargo
           ,@descripcion)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Cargos]
		  SET [Nombre_Cargo] = @cargo
			  ,[Descripcion] = @descripcion
		WHERE Cargo_Id =  @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Cargos]
		WHERE Cargo_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_CLIENTES]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_CLIENTES]
@accion NVARCHAR(50),
@codigo int = NULL,
@nombre NVARCHAR(250),
@rtn nvarchar(20),
@direccion varchar(MAX),
@paisID INT = NULL,
@telefono varchar(20),
@paginaWeb varchar(500),
@correo varchar(500),
@representante varchar(50),
@puesto varchar(50)
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT a.Cliente_Id, a.Nombre_Comercial, a.RTN, a.Direccion, c.Nombre_Pais, a.Telefono, a.Pagina_web, a.Correo_Electronico, a.Representante_legal, a.Puesto
		FROM [dbo].[Clientes] a inner join [dbo].[Ciudades] b
		on a.Pais_Id = b.Pais_Id inner join [dbo].[Pais] c
		on b.Pais_Id = c.Pais_Id
		group by c.Pais_Id, a.Cliente_Id, a.Nombre_Comercial, a.RTN, a.Direccion, a.Telefono, a.Pagina_web, a.Correo_Electronico, a.Representante_legal, a.Puesto, c.Nombre_Pais
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Clientes]
           ([Nombre_Comercial]
           ,[RTN]
           ,[Direccion]
           ,[Pais_Id]
           ,[Telefono]
           ,[Pagina_web]
           ,[Correo_Electronico]
           ,[Representante_legal]
           ,[Puesto])
		 VALUES
			(@nombre
			,@rtn
			,@direccion
			,@paisID
			,@telefono
			,@paginaWeb
			,@correo
			,@representante
			,@puesto)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Clientes]
		   SET [Nombre_Comercial] = @nombre
			  ,[RTN] = @rtn
			  ,[Direccion] = @direccion
			  ,[Pais_Id] = @paisID
			  ,[Telefono] = @telefono
			  ,[Pagina_web] = @paginaWeb
			  ,[Correo_Electronico] = @correo
			  ,[Representante_legal] = @representante
			  ,[Puesto] = @puesto
		 WHERE Cliente_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Clientes]
      WHERE Cliente_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_EMPLEADOS]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_EMPLEADOS]
@accion nvarchar(30),
@codigo int = null,
@nombre varchar(50) = null,
@apellido varchar(50) = null,
@direccion varchar(max) = null,
@correo varchar(200) = null,
@cargo int = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT a.Empleado_Id, a.Nombre_Empleado, a.Apellido_Empleado, b.Cargo_Id, b.Nombre_Cargo, a.Direccion_Empleado, a.Correo_Empleado
		FROM [dbo].[Empleados] a inner join [dbo].[Cargos] b
		on
		a.Cargo_Id = b.Cargo_Id
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Empleados]
           ([Nombre_Empleado]
           ,[Apellido_Empleado]
           ,[Direccion_Empleado]
           ,[Correo_Empleado]
           ,[Cargo_Id])
		VALUES
           (@nombre
           ,@apellido
           ,@direccion
           ,@correo
           ,@cargo)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Empleados]
   SET [Nombre_Empleado] = @nombre
      ,[Apellido_Empleado] = @apellido
      ,[Direccion_Empleado] = @direccion
      ,[Correo_Empleado] = @correo
      ,[Cargo_Id] = @cargo
 WHERE Empleado_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Empleados]
      WHERE Empleado_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_MONEDAS]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_MONEDAS]
@accion nvarchar(30),
@codigoMoneda char(2) = null,
@nombreMoneda char(30) = null,
@abreviatura char(10) = null,
@signo char(3) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Codigo_Moneda, Nombre_Moneda, Abreviatura_Moneda, Signo_Moneda
		FROM [dbo].[Moneda]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Moneda]
           ([Codigo_Moneda]
           ,[Nombre_Moneda]
           ,[Abreviatura_Moneda]
           ,[Signo_Moneda])
     VALUES
           (@codigoMoneda
           ,@nombreMoneda
           ,@abreviatura
           ,@signo)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Moneda]
		   SET [Nombre_Moneda] = @nombreMoneda
			  ,[Abreviatura_Moneda] = @abreviatura
			  ,[Signo_Moneda] = @signo
		 WHERE Codigo_Moneda = @codigoMoneda
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Moneda]
      WHERE Codigo_Moneda = @codigoMoneda
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_PAISES]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_PAISES]
@accion nvarchar(30),
@codigo INT = null,
@pais varchar(250) = null,
@codigoISO char(2) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Pais_Id, Nombre_Pais, Codigo_Iso
		FROM [dbo].[Pais]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Pais]
           ([Nombre_Pais]
           ,[Codigo_Iso])
		 VALUES
			(@pais
			,@codigoISO)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Pais]
		   SET [Nombre_Pais] = @pais
			  ,[Codigo_Iso] = @codigoISO
		 WHERE Pais_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Pais]
      WHERE Pais_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_PRODUCTOS]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_PRODUCTOS]
@accion NVARCHAR(10) = NULL,
@codigo int = null,
@producto VARCHAR(50) = NULL,
@marca VARCHAR(100) = null,
@modelo VARCHAR(100) = null,
@version VARCHAR(100) = null,
@precio decimal = null,
@tipo int = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Producto_Id, Nombre_Producto, marca, modelo, versionProducto, Precio_Producto
		FROM [dbo].[Productos]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Productos]
           ([Nombre_Producto]
           ,[marca]
           ,[modelo]
           ,[versionProducto]
           ,[Precio_Producto])
		VALUES
           (@producto
           ,@marca
           ,@modelo
           ,@version
		   ,@precio)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Productos]
		   SET [Nombre_Producto] = @producto
			  ,[marca] = @marca
			  ,[modelo] = @modelo
			  ,[versionProducto] = @version
			  ,[Precio_Producto] = @precio
		 WHERE Producto_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Productos]
		WHERE Producto_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_TIPO_USUARIO]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_TIPO_USUARIO]
@accion nvarchar(30),
@codigo int = null,
@nivel varchar(50) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Tipo_Usuario_Id,  Nivel_Usuario
		FROM [dbo].[Tipo_Usuario]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Tipo_Usuario]
           ([Nivel_Usuario])
		VALUES
           (@nivel)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Tipo_Usuario]
		   SET [Nivel_Usuario] = @nivel
		 WHERE Tipo_Usuario_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Tipo_Usuario]
      WHERE Tipo_Usuario_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_USUARIOS]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_USUARIOS]
@accion nvarchar(30),
@codigo int = null,
@empleadoID int = null,
@nombreUsuario varchar(50) = null,
@contrasenia varchar(255) = null,
@correo varchar(200) = null,
@tipo varchar(100) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT a.Usuario_Id, b.Empleado_Id, b.Nombre_Empleado, b.Apellido_Empleado, a.Contrasenia, c.Nivel_Usuario
		FROM [dbo].[Usuarios] a inner join [dbo].[Empleados] b
		on
		a.empleadoID = b.Empleado_Id inner join [dbo].[Tipo_Usuario] c
		on
		a.Tipo_Usuario_Id = c.Tipo_Usuario_Id
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Usuarios]
           ([empleadoID]
           ,[Nombre_Usuario]
           ,[Contrasenia]
           ,[Tipo_Usuario_Id])
		VALUES
           (@empleadoID
           ,@nombreUsuario
           ,@contrasenia
           ,@tipo)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Usuarios]
		   SET [empleadoID] = @empleadoID
			  ,[Nombre_Usuario] = @nombreUsuario
			  ,[Contrasenia] = @contrasenia
			  ,[Tipo_Usuario_Id] = @tipo
		 WHERE Usuario_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Usuarios]
      WHERE Usuario_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[CRUD_USUARIOS_CLIENTES]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[CRUD_USUARIOS_CLIENTES]
@accion nvarchar(30),
@codigo int = null,
@contratoID int = null,
@nombre varchar(250) = null,
@direccion varchar(255) = null,
@telefono varchar(20) = null,
@correo varchar(100) = null,
@puesto varchar(100) = null
AS
BEGIN
	IF(@accion = 'Mostrar')
	BEGIN
		SELECT Usuario_Datos_Id, Contrato_Id, Nombre_Completo, Direccion_Usuario, Telefono_Usuario, Correo_Usuario, Puesto_Usuario
		FROM [dbo].[Usuarios_Datos]
	END

	IF(@accion = 'Insertar')
	BEGIN
		INSERT INTO [dbo].[Usuarios_Datos]
           ([Contrato_Id]
           ,[Nombre_Completo]
           ,[Direccion_Usuario]
           ,[Telefono_Usuario]
           ,[Correo_Usuario]
           ,[Puesto_Usuario])
		VALUES
           (@contratoID
           ,@nombre
           ,@direccion
           ,@telefono
           ,@correo
           ,@puesto)
	END

	IF(@accion = 'Actualizar')
	BEGIN
		UPDATE [dbo].[Usuarios_Datos]
		   SET [Contrato_Id] = @contratoID
			  ,[Nombre_Completo] = @nombre	
			  ,[Direccion_Usuario] = @direccion
			  ,[Telefono_Usuario] = @telefono
			  ,[Correo_Usuario] = @correo
			  ,[Puesto_Usuario] = @puesto
		WHERE Usuario_Datos_Id = @codigo
	END

	IF(@accion = 'Eliminar')
	BEGIN
		DELETE FROM [dbo].[Usuarios_Datos]
      WHERE Usuario_Datos_Id = @codigo
	END
END
GO
/****** Object:  StoredProcedure [dbo].[MostrarComboBox]    Script Date: 22/10/2023 22:08:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[MostrarComboBox]
@accion NVARCHAR(50),
@paisID INT = NULL
AS
BEGIN
	IF(@accion = 'ListarPaises')
	BEGIN
		SELECT Pais_Id, Nombre_Pais
		FROM [dbo].[Pais]
	END
	IF(@accion = 'ListarCiudades')
	BEGIN
		SELECT ciudadID, nombreCiudad, Pais_Id
		FROM [dbo].[Ciudades]
		WHERE Pais_Id = @paisID
	END

	IF(@accion = 'ListarUsuarios')
	BEGIN
		SELECT Contrato_Id
		FROM [dbo].[Contratos]
	END

	IF(@accion = 'ListarCargos')
	BEGIN
		SELECT Cargo_Id, Nombre_Cargo
		FROM Cargos
	END

	IF(@accion = 'ListarTipoU')
	BEGIN
		SELECT Tipo_Usuario_Id, Nivel_Usuario
		FROM [dbo].[Tipo_Usuario]
	END

	IF(@accion = 'ListarMonedas')
	BEGIN
		SELECT Codigo_Moneda, Nombre_Moneda
		FROM [dbo].[Moneda]
	END
END
GO
