CREATE TABLE Types (
  ID_type int identity (1,1) NOT NULL,
  Type varchar (100) NOT NULL,
  PRIMARY KEY (ID_type),
);

CREATE TABLE Nedvizh (
  ID_nedvizh int identity (1,1) NOT NULL,
  ID_type int NOT NULL,
  Location varchar (150) NOT NULL,
  Room varchar (100) NOT NULL,
  Floor varchar (100) NOT NULL,
  Area varchar (100) NOT NULL,
  Opisanie varchar (700) NOT NULL,
  Cost int NOT NULL,
  PRIMARY KEY (ID_nedvizh),
  FOREIGN KEY (ID_type) REFERENCES Types(ID_type),
);

CREATE TABLE Users (
  ID_user int identity (1,1) NOT NULL,
  Login varchar (70) NOT NULL,
  Password varchar (70) NOT NULL,
  Full_name varchar (200) NOT NULL,
  Number varchar (70) NOT NULL,
  Status varchar (100) NOT NULL,
  PRIMARY KEY (ID_user)
);

CREATE TABLE Sdelka (
  ID_Sdelka int identity (1,1) NOT NULL,
  ID_user int NOT NULL,
  ID_nedvizh int NOT NULL,
  Data date NOT NULL,
  PRIMARY KEY (ID_sdelka),
  FOREIGN KEY (ID_user) REFERENCES Users(ID_user),
  FOREIGN KEY (ID_nedvizh) REFERENCES Nedvizh(ID_nedvizh)
);
