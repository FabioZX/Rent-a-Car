USE ZX

CREATE TABLE Vehiculos(
idvehiculos INT IDENTITY(1,1),
NoChasis VARCHAR(50),
NoMotor VARCHAR(50),
NoPlaca VARCHAR(50),
idtipovehiculo uniqueidentifier,
TipoVehiculo VARCHAR(50),
idmarcas uniqueidentifier,
Marcas VARCHAR(50),
idmodelos uniqueidentifier,
Modelos VARCHAR(50),
idcombustible uniqueidentifier,
Combustible VARCHAR(50),
idcliente uniqueidentifier,
ClienteNombre VARCHAR(50),
Correo VARCHAR(50),
CedulaCliente CHAR(13),
NoTarjeta CHAR(20),
Limite FLOAT,
PersonaFisica BIT,
PersonaJuridica BIT,
idempleado uniqueidentifier,
EmpleadoNombre VARCHAR(50),
CedulaEmpleado VARCHAR(13),
Tanda VARCHAR(50),
Comision FLOAT, 
FechaIngreso DATETIME,
idtransaccion uniqueidentifier,
Ralladuras BIT,
CCombustible1 BIT,
CCombustible2 BIT,
CCombustible3 BIT,
CCombustible4 BIT,
Gomas BIT,
Gato BIT,
Roturas BIT,
EGomas1 BIT,
EGomas2 BIT,
EGomas3 BIT,
EGomas4 BIT,
FechaInspeccion DATETIME,
NoRenta uniqueidentifier,
FechaRenta DATETIME,
FechaDevolucion DATETIME,
CostoDia INT,
CantidadDias INT,
Resultado INT,
ResultadoComision INT,
Comentario VARCHAR(100)
);

select * from Vehiculos

INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'SALAG2V63EA728267','KNAFB1216Y581','SDF4567');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1G1ZS57FX7F266280','4T1BF1FK9CU59','WER3245');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'JHMCN36495C001453','1GYFK63837R30','GLZ2376');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'2GNFLGEK3F6172471','1GYS4BEF1CR12','HJK1234');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'3C4PDDBG3ET257801','4V4JBAPEXVN85','GLS7625');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1D7HU18N02J178913','2G1FP22P1R211','FKD8202');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'19XFB2F56DE034458','4F2CZ92Z78KM1','HNX1890');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'2CNDL73F266158448','1J4GK48K84W27','KJS1983');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'JTJGF10U410099376','1FMCU9GX9FUB0','SDL9356');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1FTYR14U51PA58853','FADP3J20DL150','OTY7293');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'JS3TD62V214157473','1G1PC5SB8E734','QWE4562');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1FTWW3B59AEA49673','1FMYU70E9YUA0','CXZ2356');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1G2ZF57B984160185','2LMDU68C87BJ2','ASD9090');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1HTSCABP8SH691740','3VWD17AJ4EM21','UYT3981');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'3D4PG4FB3AT235350','1G4PP5SK9E420','TRE9726');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'5FRYD4H49FB022125','1GYS4JKJ5FR27','HGF5628');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'3C3CFFDR7ET263432','1YVGF22C02527','LKJ7253');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'2GTEK19R0V1509329','1GCRKSE70CZ21','VBN6283');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'3TMMU4FN4BM026326','2HNYD18236H51','POI7281');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'WP0EA0916CS160343','5TBBT54187S45','MNB8654');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'JN8AZ08T97W521531','1FMZU32E6XZB6','UHV9786');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1C4RJFBG9EC453122','2FAFP73W65X12','EFB5427');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'2G1WD58C081322267','3LN6L2LU9FR61','PLM9873');
INSERT INTO Vehiculos ( idtipovehiculo, idmarcas, idmodelos, idcombustible, idcliente, idempleado, idtransaccion, NoRenta, NoChasis, NoMotor, NoPlaca) VALUES(NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),NEWID(),'1FMEE11N2SHB40526','5J6RM4H7XCL04','WDV2458');

CREATE TABLE Login(
Username VARCHAR(50), --En Edit Top 200 Rows Agregar como Username Admin y JValdez, en Password admin y 123456
Password VARCHAR(50),
Roles VARCHAR(50)
);