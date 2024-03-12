-- Tabla PERSONA
create database tiendabl 
CREATE TABLE PERSONA (
    idpersona INT PRIMARY KEY,
    nombre VARCHAR(255),
    apellidos VARCHAR(255),
    telefono VARCHAR(20),
    CI VARCHAR(20),
    correo VARCHAR(255),
    estado VARCHAR(50)
);

-- Tabla USUARIO
CREATE TABLE USUARIO (
    idusuario INT PRIMARY KEY,
    idpersona INT,
    nombreuser VARCHAR(50),
    contraseña VARCHAR(255),
    fechareg DATE,
    FOREIGN KEY (idpersona) REFERENCES PERSONA(idpersona)
);

-- Tabla USUARIOROL
CREATE TABLE USUARIOROL (
    idusuariorol INT PRIMARY KEY,
    idusuario INT,
    idrol INT,
    fechaasigna DATE,
    estado VARCHAR(50),
    FOREIGN KEY (idusuario) REFERENCES USUARIO(idusuario),
    FOREIGN KEY (idrol) REFERENCES ROL(idrol)
);

-- Tabla ROL
CREATE TABLE ROL (
    idrol INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);

-- Tabla CLIENTE
CREATE TABLE CLIENTE (
    idcliente INT PRIMARY KEY,
    idpersona INT,
    tipocliente VARCHAR(50),
    codigoclie VARCHAR(20),
    estado VARCHAR(50),
    FOREIGN KEY (idpersona) REFERENCES PERSONA(idpersona)
);

-- Tabla VENTA
CREATE TABLE VENTA (
    idventa INT PRIMARY KEY,
    idcliente INT,
    idvendedor INT,
    fecha DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idcliente) REFERENCES CLIENTE(idcliente),
    FOREIGN KEY (idvendedor) REFERENCES PERSONA(idpersona)
);

-- Tabla DETALLEVENT
CREATE TABLE DETALLEVENT (
    iddetallevent INT PRIMARY KEY,
    idventa INT,
    idproducto INT,
    cantidad INT,
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idventa) REFERENCES VENTA(idventa),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto)
);

-- Tabla DETALLEING
CREATE TABLE DETALLEING (
    iddetalleing INT PRIMARY KEY,
    idproducto INT,
    idingreso INT,
    fechavenc DATE,
    cantidad INT,
    preciocosto DECIMAL(10, 2),
    precioventa DECIMAL(10, 2),
    subtotal DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto),
    FOREIGN KEY (idingreso) REFERENCES INGRESO(idingreso)
);

-- Tabla INGRESO
CREATE TABLE INGRESO (
    idingreso INT PRIMARY KEY,
    idproveedor INT,
    fechaingreso DATE,
    total DECIMAL(10, 2),
    estado VARCHAR(50),
    FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR(idproveedor)
);

-- Tabla PRODUCTO
CREATE TABLE PRODUCTO (
    idproducto INT PRIMARY KEY,
    idtipoproducto INT,
    nombre VARCHAR(255),
    codigobarra VARCHAR(50),
    idmarca INT,
    unidad VARCHAR(50),
    descripcion TEXT,
    estado VARCHAR(50),
    FOREIGN KEY (idtipoproducto) REFERENCES TIPOPROD(idtipoprod),
    FOREIGN KEY (idmarca) REFERENCES MARCA(idmarca)
);

-- Tabla PROVEE
CREATE TABLE PROVEE (
    idprovee INT PRIMARY KEY,
    idproducto INT,
    idproveedor INT,
    fecha DATE,
    precio DECIMAL(10, 2),
    FOREIGN KEY (idproducto) REFERENCES PRODUCTO(idproducto),
    FOREIGN KEY (idproveedor) REFERENCES PROVEEDOR(idproveedor)
);

-- Tabla PROVEEDOR
CREATE TABLE PROVEEDOR (
    idproveedor INT PRIMARY KEY,
    nombre VARCHAR(255),
    telefono VARCHAR(20),
    direccion VARCHAR(255),
    estado VARCHAR(50)
);

-- Tabla TIPOPROD
CREATE TABLE TIPOPROD (
    idtipoprod INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);

-- Tabla MARCA
CREATE TABLE MARCA (
    idmarca INT PRIMARY KEY,
    nombre VARCHAR(50),
    estado VARCHAR(50)
);
