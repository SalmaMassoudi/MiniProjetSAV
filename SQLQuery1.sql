CREATE TABLE Technicien (
    IdTechnicien INT IDENTITY PRIMARY KEY,
    Nom NVARCHAR(100),
    Specialite NVARCHAR(100)
);
CREATE TABLE Client (
    IdClient INT IDENTITY PRIMARY KEY,
    Nom NVARCHAR(100),
    Email NVARCHAR(100),
    Telephone NVARCHAR(20)
);
CREATE TABLE Produit (
    IdProduit INT IDENTITY PRIMARY KEY,
    Nom NVARCHAR(100),
    Categorie NVARCHAR(100),
    GarantieMois INT
);
CREATE TABLE Retour (
    IdRetour INT IDENTITY PRIMARY KEY,
    DateRetour DATE,
    Motif NVARCHAR(200),
    Statut NVARCHAR(50),
    TypeRetour NVARCHAR(50),

    IdProduit INT FOREIGN KEY REFERENCES Produit(IdProduit),
    IdClient INT FOREIGN KEY REFERENCES Client(IdClient)
);
