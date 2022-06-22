DECLARE @StadiumID INT;
DECLARE @CoachID INT;
DECLARE @TeamID INT;

/* STADIUMS */

/* portuguese premier league */
INSERT INTO FD.STADIUM VALUES (64642 ,"Estádio do Sport Lisboa e Benfica (Estádio da Luz)", "Portugal") -- Benfica
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Nélson", "", "Veríssimo", "1977-04-17", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Sport Lisboa e Benfica", "BEN", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()
INSERT INTO FD.PLAYER VALUES ("Teste", "", "Sobrenome", "1990-01-01", "Portugal", @TeamID, "Goalkeeper", "Right", 180, 75.5, 7l)

INSERT INTO FD.STADIUM VALUES (50033 ,"Estádio do Dragão", "Portugal") -- Porto
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Sérgio", "", "Conceição", "1974-11-15", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube do Porto", "POR", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (50095 ,"Estádio José Alvalade – Século XXI", "Portugal") -- Sporting
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Rúben", "", "Amorim", "1985-01-27", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Sporting Clube de Portugal", "SPO", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (38593 ,"Estádio Nacional", "Portugal") -- Belenenses SAD
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Franclim", "", "Carvalho", "1987-03-30", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Os Belenenses Futebol, SAD", "BEL", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (30286 ,"Estádio Municipal de Braga", "Portugal") -- Braga
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Carlos", "", "Carvalhal", "1965-12-04", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Sporting Clube de Braga", "BRA", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (30029 ,"Estádio D. Afonso Henriques", "Portugal") -- Vit. Guimarães
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Pedro", "", "Filipe", "1980-12-14", "Portugal") -- VSC
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Vitória Sport Clube", "VIT", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (28263 ,"Estádio do Bessa – Século XXI", "Portugal") -- Boavista
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Armando", "", "Teixeira", "1976-09-25", "Portugal") -- BFC
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Boavista Futebol Clube", "BOA", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (15277 ,"Estádio de São Miguel", "Portugal") -- Santa Clara
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Mário", "", "Silva", "1977-04-24", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Clube Desportivo Santa Clara", "STA", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (12374 ,"Estádio Cidade de Barcelos", "Portugal") -- Gil Vincente
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Ricardo", "", "Soares", "1974-11-11", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Gil Vicente Futebol Clube", "GIL", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (10600 ,"Estádio dos Barreiros", "Portugal") -- Marítimo
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Vasco", "", "Seabra", "1983-09-15", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Club Sport Marítimo", "MAR", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (9544 ,"Estádio do Portimonense Sporting Clube", "Portugal") -- Portimonense
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Paulo", "", "Sérgio", "1968-02-19", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Portimonense Sporting Clube", "PTM", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (9077 ,"Estádio da Mata Real", "Portugal") -- Paços de Ferreira
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("César", "", "Peixoto", "1980-05-12", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube Paços de Ferreira", "PFE", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (8000,"Estádio Municipal 22 de Junho", "Portugal") -- Famalicão
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Rui", "", "Silva", "1977-03-14", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube de Famalicão", "FAM", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (8000 ,"Estádio António Coimbra da Mota", "Portugal") -- Estoril
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Bruno", "", "Pinheiro", "1976-10-30", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Grupo Desportivo Estoril Praia", "EST", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (6500 ,"Estádio do Futebol Clube de Vizela", "Portugal") -- Vizela
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Álvaro", "", "Pacheco", "1971-06-25", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube de Vizela", "VIZ", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (6153 ,"Parque de Jogos Comendador Joaquim de Almeida Freitas", "Portugal") -- Moreirense
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Ricardo", "S", "Pinto", "1972-10-10", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube de Vizela", "VIZ", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (5000 ,"Estádio Municipal de Arouca", "Portugal") -- Arouca
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Armando", "", "Evangelista", "1973-11-03", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Futebol Clube de Arouca", "ARO", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()


INSERT INTO FD.STADIUM VALUES (5000 ,"Estádio João Cardoso", "Portugal") -- Tondela
SET @StadiumID = SCOPE_IDENTITY()
INSERT INTO FD.COACH VALUES ("Nuno", "", "Campos", "1975-04-20", "Portugal")
SET @CoachID = SCOPE_IDENTITY()
INSERT INTO FD.TEAM VALUES ("Clube Desportivo de Tondela", "TON", @StadiumID, "Portugal", @CoachID)
SET @TeamID = SCOPE_IDENTITY()







/* english premier league */
INSERT INTO FD.STADIUM VALUES (55017, "Etihad Stadium", "England") -- Man City
INSERT INTO FD.STADIUM VALUES (53394, "Anfield", "England") -- Liverpool
INSERT INTO FD.STADIUM VALUES (40267, "Stamford Bridge", "England") -- Chelsea
INSERT INTO FD.STADIUM VALUES (62850, "Tottenham Hotspur Stadium", "England") -- Tottenham
INSERT INTO FD.STADIUM VALUES (60704, "Emirates Stadium", "England") -- Arsenal
INSERT INTO FD.STADIUM VALUES (74140, "Old Trafford", "England") -- Man Utd
INSERT INTO FD.STADIUM VALUES (60000, "London Stadium", "England") -- West Ham
INSERT INTO FD.STADIUM VALUES (32261, "King Power Stadium", "England") -- Leicester
INSERT INTO FD.STADIUM VALUES (31780, "Falmer Stadium", "England") -- Brighton
INSERT INTO FD.STADIUM VALUES (32050, "Molineux Stadium", "England") -- Wolverhampton
INSERT INTO FD.STADIUM VALUES (52305, "St James' Park", "England") -- Newcastle
INSERT INTO FD.STADIUM VALUES (25486, "Selhurst Park", "England") -- Crystal Palace
INSERT INTO FD.STADIUM VALUES (17250, "Brentford Community Stadium ", "England") -- Brentford
INSERT INTO FD.STADIUM VALUES (42749, "Villa Park", "England") -- Aston Villa
INSERT INTO FD.STADIUM VALUES (32384, "St Mary's Stadium", "England") -- Southampton
INSERT INTO FD.STADIUM VALUES (39414, "Goodison Park", "England") -- Everton
INSERT INTO FD.STADIUM VALUES (37678, "Elland Road", "England") -- Leeds
INSERT INTO FD.STADIUM VALUES (22200, "Turf Moor", "England") -- Burnley
INSERT INTO FD.STADIUM VALUES (53394, "Vicarage Road", "England") -- Watford
INSERT INTO FD.STADIUM VALUES (27359, "Carrow Road", "England") -- Norwich
