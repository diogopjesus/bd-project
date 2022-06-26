USE p1g7;
GO;

-- Get Game details
CREATE PROCEDURE SPS_getGameDetails @game INT
AS 
	BEGIN 
		SELECT * FROM FD.V_MISCONDUCT WHERE game=@game
		SELECT * FROM FD.V_GOAL WHERE game=@game
		SELECT * FROM FD.V_SUBSTITUTION WHERE game=@game
	END
RETURN

-- Get game stats (home and away)
CREATE PROCEDURE SPS_getGameStats @game INT
AS
	BEGIN
		SELECT * FROM FD.TEAM_STAT WHERE game=@game AND home_team=1
		SELECT * FROM FD.TEAM_STAT WHERE game=@game AND home_team=0
	END
RETURN

-- Get teams that participate in competition
CREATE PROCEDURE SPS_getCompetitionTeams @competition INT
AS
    SELECT t.*
    FROM FD.TEAM_PLAYS_COMPETITION tpc
    INNER JOIN FD.V_TEAM t ON tpc.team = t.id
    WHERE tpc.competition = @competition
RETURN 
   
   
-- get teams that dont participate in competition
CREATE PROCEDURE SPS_getTeamsExceptCompetition @competition INT
AS
    SELECT DISTINCT t.* 
    FROM  FD.V_TEAM t
    LEFT OUTER JOIN FD.TEAM_PLAYS_COMPETITION tpc ON tpc.team = t.id
    WHERE t.id NOT IN (SELECT team FROM FD.TEAM_PLAYS_COMPETITION WHERE competition=@competition)
RETURN


-- modify (update or insert) a player
CREATE PROCEDURE SPS_modifyPlayer @id INT, @fname str128, @minit VARCHAR(1), @lname str128, @birth_date DATE, @country VARCHAR(128), @team INT, @position VARCHAR(32), @preferred_foot VARCHAR(5), @height INT, @weight DECIMAL(4,1), @shirt_number INT
AS
    BEGIN TRANSACTION
    IF @id IS NULL
    BEGIN
        INSERT INTO FD.PLAYER VALUES (@fname, @minit, @lname, @birth_date, @country, @team, @position, @preferred_foot, @height, @weight, @shirt_number)
    END
    ELSE
    BEGIN
        UPDATE FD.PLAYER
        SET fname = @fname, minit = @minit, lname  = @lname, birth_date = @birth_date, country = @country, team = @team, position = @position,
            preferred_foot = @preferred_foot, height = @height, weight = @weight, shirt_number = @shirt_number
        WHERE id = @id
    END
    COMMIT TRANSACTION
RETURN

-- delete player by ID
CREATE PROCEDURE SPS_deletePlayer @id INT
AS
    DELETE FROM FD.PLAYER WHERE id=@id
RETURN

-- modify (update or insert) a player
CREATE PROCEDURE SPS_modifyTeam (@id INT, @name VARCHAR(256), @abbreviation CHAR(3), @stadium INT, @country VARCHAR(128), @coach INT)
AS
    BEGIN TRANSACTION
    IF @id IS NULL
    BEGIN
        INSERT INTO FD.TEAM VALUES (@name, @abbreviation, @stadium, @country, @coach)
    END
    ELSE
    BEGIN
        UPDATE FD.TEAM SET name=@name, abbreviation=@abbreviation, stadium=@stadium, country=@country, coach=@coach WHERE id=@id
    END
    COMMIT TRANSACTION
RETURN

-- delete team by ID
CREATE PROCEDURE SPS_deleteTeam @id INT
AS
    DELETE FROM FD.TEAM WHERE id=@id
RETURN

-- get players able to participate in a game
CREATE PROCEDURE SPS_getPossibleParticipants @game INT
AS
    SELECT p.*
    FROM FD.PLAYER p
    WHERE team IN (SELECT home_team FROM FD.GAME WHERE id=@game)
    OR team IN (SELECT away_team FROM FD.GAME WHERE id=@game)
RETURN 


-- Auxiliary user defined type to receive multiple id's of teams in 
CREATE TYPE FD.idlist AS TABLE(
    id INT NULL
);

-- modify (update or insert) a competition
CREATE PROCEDURE SPS_modifyCompetition (@id INT, @name str128, @type str256, @continent VARCHAR(13), @country str128, @teams FD.idlist READONLY)
AS
    BEGIN TRANSACTION
    
    DECLARE @team INT
    SELECT @team = min(id) FROM @teams
    
    IF @id IS NULL
    BEGIN
        INSERT INTO FD.COMPETITION VALUES (@name, @type, @continent, @country)
        
        DECLARE @competition INT
        SET @competition = SCOPE_IDENTITY()
        
        WHILE @team IS NOT NULL
        BEGIN
            INSERT INTO FD.TEAM_PLAYS_COMPETITION(competition,team) VALUES (@competition, @team)
            SELECT @team = min(id) FROM @teams WHERE id > @team
        END
    END
    
    ELSE
    BEGIN
        UPDATE FD.COMPETITION SET name=@name, type=@type, continent=@continent, country=@country WHERE id=@id
        
        WHILE @team IS NOT NULL
        BEGIN
            INSERT INTO FD.TEAM_PLAYS_COMPETITION(competition,team) VALUES (@id, @team)
            SELECT @team = min(id) FROM @teams WHERE id > @team
        END
    END
    
    COMMIT TRANSACTION
RETURN

-- delete competition by ID
CREATE PROCEDURE SPS_deleteCompetition @id INT
AS
    DELETE FROM FD.COMPETITION WHERE id=@id
RETURN


-- get players by team
CREATE PROCEDURE SPS_getPlayerByTeam @team INT
AS
    SELECT * FROM FD.V_PLAYER WHERE team_id = @team
RETURN

