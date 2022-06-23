USE p1g7;
GO;

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
CREATE PROCEDURE GetCompetition @Competition INT,
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
    SELECT * FROM FD.TEAM_PLAYS_COMPETITION tpc WHERE tpc.team = @Team AND tpc.competition = @Competition;
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
    WHERE game.id == @Game
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
        INNER JOIN FD.COUNTRY cty on (cty.id = team.country)
        INNER JOIN FD.STADIUM sta on (sta.id = team.stadium)
    WHERE team.id = @Team
GO;

CREATE PROCEDURE GetTeamGames @Team INT
    AS
    SELECT * FROM FD.GAME game WHERE game.away_team = @Team;
    SELECT * FROM FD.GAME game WHERE game.home_team = @Team;
GO;   

CREATE PROCEDURE GetPlayersInTeam @Team INT
    AS
    SELECT * FROM FD.PLAYER player WHERE player.team = @Team;
GO;




/* PROCEDURES TO ADD */

GO
CREATE PROCEDURE add_Player (@id INT, @id_team INT, @position VARCHAR(32), @preferred_foot VARCHAR(32), @height INT, @weight DECIMAL(4,1), @shirt_number INT, @fname VARCHAR(128), @minit VARCHAR(1), @lname  VARCHAR(128), @birthdate DATE, @country VARCHAR(128))
AS
BEGIN
    BEGIN TRY
        INSERT INTO FD.PLAYER (@id, @id_team, @position, @preferred_foot, @height, @weight, @shirt_number, @fname, @minit, @lname, @birthdate, @country)
        PRINT 'Player Added with Success!'
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_Game (@id INT, @home_goals INT, @away_goals INT, @date DATE, @id_stadium INT, @id_competition INT, @id_referee INT, @home_team INT)
AS
    BEGIN TRY
        BEGIN TRANSACTION
            INSERT INTO FD.GAME (@id, @home_goals, @away_goals, @data, @id_stadium, @id_competition, @id_referee, @home_team, @away_team)
            INSERT INTO FD.TEAM_STAT (@id, @home_team, 0, 0, 0, 0, 0, 0, 0, 1); /*Start Empty for Home Team stats*/
            INSERT INTO FD.TEAM_STAT (@id, @away_team, 0, 0, 0, 0, 0, 0, 0, 0); /*Start Empty for Away Team stats*/
             PRINT 'Game Added with Success!'
        COMMIT
    END TRY
    BEGIN CATCH
        PRINT ERROR_MESSAGE()
        ROLLBACK
    END CATCH
END

GO
CREATE PROCEDURE add_MissConduct (@id INT, @id_game INT, @game_time INT, @card VARCHAR(6), @team INT)
AS
    BEGIN TRY
        INSERT INTO FD.MISSCONDUCT(@id, @id_game, @game_time, @card, @team)
        PRINT 'MissConduct Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
CREATE PROCEDURE add_Team (@id INT, @name VARCHAR(256), @abreviation CHAR(3), @id_stadium INT, @country VARCHAR(128), @id_coach INT, @id_competition INT)
AS
    BEGIN TRY
        INSERT INTO FD.TEAM (@id, @name, @abreviation, @id_stadium, @country, @id_coach)
        INSERT INTO FD.TEAM_PLAYS_COMPETITION (@id, @id_competition, 0, 0, 0, 0, 0)
        PRINT 'Team Added with Success!'
    END TRY
    BEGIN CATCH 
        PRINT ERROR_MESSAGE()
    END CATCH
END

GO
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


/* APAGAR JOGADORES */
GO
CREATE PROCEDURE delete_Player_id( @id VARCHAR(20))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM FD.PLAYER WHERE id=@id; 
			PRINT 'Success'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* APAGAR ESTÁDIOS */
GO
CREATE PROCEDURE delete_stadium_id( @id VARCHAR(20))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM FD.STADIUM WHERE id=@id; 
			PRINT 'Success'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END

/* APAGAR JOGOS */
GO
CREATE PROCEDURE delete_game_id( @id VARCHAR(20))
AS
BEGIN
	BEGIN TRY
		BEGIN TRANSACTION
			DELETE FROM FD.GAME WHERE id=@id; 
			PRINT 'Success'
		COMMIT
	END TRY
	BEGIN CATCH
		PRINT ERROR_MESSAGE()
		ROLLBACK
	END CATCH
END