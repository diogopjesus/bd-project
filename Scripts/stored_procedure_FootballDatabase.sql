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










CREATE PROCEDURE add_Game (@id INT, @home_goals INT, @away_goals INT, @date DATE, @id_stadium INT, @id_competition INT, @id_referee INT, @home_team INT, @away_team INT)
AS
    BEGIN TRANSACTION
    IF @id IS NULL
    BEGIN
        INSERT INTO FD.GAME (@id, @home_goals, @away_goals, @date, @id_stadium, @id_competition, @id_referee, @home_team, @away_team)
        INSERT INTO FD.TEAM_STAT VALUES (@home_team, 0, 0, 0, 0, 0, 0, 0, 1); /*Start Empty for Home Team stats*/
        INSERT INTO FD.TEAM_STAT (@id, @away_team, 0, 0, 0, 0, 0, 0, 0, 0); /*Start Empty for Away Team stats*/
         PRINT 'Game Added with Success!'
    END
    COMMIT TRAN
END


CREATE PROCEDURE add_competition (@id INT, @name VARCHAR(256), @type VARCHAR(256), @continent VARCHAR(256), @country VARCHAR(256) )
AS
    BEGIN TRY
        INSERT INTO FD.COMPETITION(@id, @name, @type, @continent, @country)
        PRINT 'Competition Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END



/* GETS GAME ID ACCORDING TO ID */
CREATE PROCEDURE GetGame @Game INT
    AS
    SELECT * FROM FD.GAME g WHERE g.id =  @Game
GO;

/* GETS PLAYER INFO ACCORDING TO ID*/ 
CREATE PROCEDURE GetPlayerInfo @Player INT
    AS 
    SELECT * FROM FD.PLAYER p WHERE p.id = @Player
GO;

/* GETS A COMPETITION */
CREATE PROCEDURE GetCompetition @Competition INT
    AS 
    SELECT * FROM FD.COMPETITION comp WHERE comp.id = @Competition
GO;

/* GETS ALL GAMES IN A CERTAIN COMPETITION */
CREATE PROCEDURE SelectGamesInCompetition @Game_Comp INT 
    AS 
    SELECT * FROM FD.GAME game WHERE game.competition =  @Game_Comp;
GO;

/* GETS ALL TEAMS IN A CERTAIN COMPETITION */
CREATE PROCEDURE SelectTeamsInCompetition @Team INT, @Competition INT
    AS 
    SELECT * FROM FD.TEAM_PLAYS_COMPETITION tpc WHERE tpc.team = @Team AND tpc.competition = @Competition
GO;

/* GETS ALL INFO IN A CERTAIN GAME */
CREATE PROCEDURE GetInfoGame 
    @Game INT
AS

SELECT *
    FROM FD.GAME game 
        INNER JOIN FD.TEAM_STAT ts on (game.id = ts.game)
        INNER JOIN FD.REFEREE ref on (game.referee = ref.id)
        INNER JOIN FD.STADIUM sta on (game.stadium = sta.id)
        INNER JOIN FD.COMPETITION comp on (game.competition = comp.id)
    WHERE game.id = @Game
GO;

CREATE PROCEDURE GetPlayersInGame 
    @Game INT
AS
SELECT * 
    FROM FD.PLAYER_PARTICPATES_GAME ppg 
        INNER JOIN FD.GAME game on (game.id = ppg.game)
        INNER JOIN FD.PLAYER plr on (plr.id = ppg.player)
    WHERE ppg.game = @Game
GO;

/* GET ALL INFORMATION FOR A TEAM - Players, Matches, Stadium, Pais, Country, Coach*/
CREATE PROCEDURE GetInfoTeam 
    @Team INT
AS

SELECT *
    FROM FD.TEAM team
        INNER JOIN FD.COACH ch on (ch.id = team.coach)
        INNER JOIN FD.COUNTRY cty on (cty.name = team.country)
        INNER JOIN FD.STADIUM sta on (sta.id = team.stadium)
    WHERE team.id = @Team
GO;

CREATE PROCEDURE GetTeamGames @Team INT
    AS
    SELECT * FROM FD.V_MATCH game WHERE game.away_id = @Team OR game.home_id = @Team;
GO;   

CREATE PROCEDURE GetPlayersInTeam @Team INT
    AS
    SELECT * FROM FD.PLAYER player WHERE player.team = @Team;
GO;

/* PROCEDURES TO ADD */


GO


GO
CREATE PROCEDURE add_MissConduct (@id INT, @id_game INT, @game_time INT, @card VARCHAR(6), @team INT)
AS
    BEGIN TRY
        INSERT INTO FD.MISSCONDUCT(@id, @id_game, @game_time, @card, @team)
        PRINT ('MissConduct Added with Success!')
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO


GO


GO
CREATE PROCEDURE add_referee (@id INT, @fname VARCHAR(128), @minit VARCHAR(1), @lname  VARCHAR(128), @birthdate DATE, @country  VARCHAR(128))
AS
    BEGIN TRY
        INSERT INTO FD.REFEREE(@id, @fname, @minit, @lname, @birthdate, @country)
        PRINT 'Referee Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_coach (@id INT, @fname VARCHAR(128), @minit VARCHAR(1), @lname  VARCHAR(128), @birthdate DATE, @country  VARCHAR(128))
AS
    BEGIN TRY
        INSERT INTO FD.COACH(@id, @fname, @minit, @lname, @birthdate, @country)
        PRINT 'Coach Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_stadium (@id INT, @attendace INT, @name VARCHAR(128), @country VARCHAR(128))
AS
    BEGIN TRY
        INSERT INTO FD.STADIUM(@id, @attendance, @name, @country)
        PRINT 'Stadium Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_goals (@id INT, @game INT, @gametime INT, @HomeTeam BIT, @scorer INT, @assitant INT)
AS
    BEGIN TRY
        INSERT INTO FD.GOALS(@id, @game, @gametime, @HomeTeam, @scorer, @assistant)
        PRINT 'Goal Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_player_stat (@id_game INT, @id_player INT, @time_pled INT, @goals INT, @assists INT, @touches INT, @passes INT,@shots INT, @tackles INT, @homeTeam BIT)
AS
    BEGIN TRY
        INSERT INTO FD.PLAYER_STAT(@id_game, @id_player, @time_pled, @goals, @assists, @touches, @passes, @shots, @tackles, @homeTeam)
        PRINT 'Player Stat Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_team_stat (@id_game INT, @id_team INT, @ball_possesion INT, @total_shots INT, @offsides INT, @passes INT, @tackles INT, @fouls INT, @corner_kicks INT, @home_team BIT)
AS
    BEGIN TRY
        INSERT INTO FD.TEAM_STAT(@id_game, @id_team, @ball_possesion, @total_shots, @offsides, @passes, @tackles, @fouls, @corner_kicks, @home_team)
        PRINT 'Team Stat Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_substitution (@id INT, @game INT, @gametime INT, @homeTeam BIT, @playerIn INT, @playerOut INT)
AS
    BEGIN TRY
        INSERT INTO FD.SUBSTITUTION(@id, @game, @gametime, @homeTeam, @playerIn, @playerOut)
        PRINT 'Substitution Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END
