ALTER TABLE Underviser
ADD FOREIGN KEY (Koordinator_id) REFERENCES Koordinator(Koordinator_id);
