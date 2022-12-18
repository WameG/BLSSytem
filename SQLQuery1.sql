CREATE TABLE Bog( Bog_id int NOT NULL PRIMARY KEY,Title VARCHAR (30) NOT NULL,Forfatter VARCHAR(30) NOT NULL, Udgivelsesår INT NOT NULL, ISBN FLOAT NOT NULL, Billede VARCHAR (256) NOT NULL); 
CREATE TABLE Underviser(Underviser_id int NOT NULL PRIMARY KEY, Navn VARCHAR(50) NOT NULL, Initialer VARCHAR(10) NOT NULL);
CREATE TABLE Hold (Hold_id int NOT NULL PRIMARY KEY);
CREATE TABLE UnderviserBog(UnderviserBog_id int NOT NULL PRIMARY KEY,Underviser_id int NOT NULL FOREIGN KEY (Underviser_id) REFERENCES Underviser (Underviser_id), Bog_id int NOT NULL FOREIGN KEY (Bog_id) REFERENCES Bog (Bog_id));
CREATE TABLE UnderviserHold( UnderviserHold_id int NOT NULL PRIMARY KEY, Underviser_id int NOT NULL FOREIGN KEY (Underviser_id) REFERENCES Underviser (Underviser_id), Hold_id int NOT NULL FOREIGN KEY (Hold_id) REFERENCES Hold (Hold_id));
CREATE TABLE BogHold (BogHold_id int NOT NULL PRIMARY KEY, Bog_id int NOT NULL FOREIGN KEY (Bog_id) REFERENCES Bog (Bog_id), Hold_id int NOT NULL FOREIGN KEY (Hold_id) REFERENCES Hold (Hold_id));
CREATE TABLE Fag(Fag_id int NOT NULL PRIMARY KEY, Fag_navn VARCHAR (50) NOT NULL);
CREATE TABLE Semestre( Semestre_id int NOT NULL PRIMARY KEY, Navn VARCHAR (50) NOT NULL);
CREATE TABLE Uddannelse (Uddannelse_id int NOT NULL PRIMARY KEY, Uddannelse_navn VARCHAR (50) NOT NULL);
CREATE TABLE [dbo].HoldFag (
    [HoldFag_id] INT NOT NULL,
    [Hold_id]    INT NOT NULL,
    [Fag_id]     INT NOT NULL,
    PRIMARY KEY CLUSTERED ([HoldFag_id] ASC),
    FOREIGN KEY ([Hold_id]) REFERENCES [dbo].[Hold] ([Hold_id]),
    FOREIGN KEY ([Fag_id]) REFERENCES [dbo].[Fag] ([Fag_id])
);
