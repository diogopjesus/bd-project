-- Disable inserts for tables that work like enums
CREATE TRIGGER TR_continent ON FD.CONTINENT
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add continents! Table is closed to insertions.', 16, 1);

CREATE TRIGGER TR_country ON FD.COUNTRY
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add countries! Table is closed to insertions.', 16, 1)

CREATE TRIGGER TR_position ON FD.POSITION
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add positions! Table is closed to insertions.', 16, 1)

CREATE TRIGGER TR_foot ON FD.FOOT
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add preferred feet! Table is closed to insertions.', 16, 1)

CREATE TRIGGER TR_competittion_type ON FD.COMPETITION_TYPE
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add competition types! Table is closed to insertions.', 16, 1)

CREATE TRIGGER TR_card ON FD.CARD
INSTEAD OF INSERT
AS
    RAISERROR('ERROR: Can not add cards! Table is closed to insertions.', 16, 1)

-- Constraints on adding a new team
--   Coach should not be coaching other teams
--   Stadium should be in the same country as team
CREATE TRIGGER TR_insert_new_team ON FD.TEAM
AFTER INSERT
AS
BEGIN
    DECLARE @teamCT str128
   	DECLARE @stadiumCT str128
    DECLARE @stadiumID INT
    DECLARE @coachID INT

    SELECT @coachID = coach FROM INSERTED;
    IF EXISTS (SELECT id FROM FD.TEAM WHERE id = @coachID)
    BEGIN
        RAISERROR('ERROR: Coach already working for other team!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    SELECT @teamCT = country, @stadiumID = stadium FROM INSERTED
    SELECT @stadiumCT = country FROM FD.STADIUM WHERE id = @stadiumID

    IF (@teamCT != @stadiumCT)
    BEGIN
        RAISERROR('ERROR: Stadium is not in the same country as team!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END

-- Constraints on associating team with competition
--   Team should be in the same continent (and country if applicable) as competition
--   Should only be possible to add team and competition columns. The other columns are updated according to the data from table GAME
CREATE TRIGGER TR_associate_team_with_competition ON FD.TEAM_PLAYS_COMPETITION
AFTER INSERT
AS
BEGIN
    DECLARE @competitionID INT
    DECLARE @teamID INT
    DECLARE @teamCT str128
    DECLARE @teamCN varchar(13)

    IF EXISTS(
        SELECT * FROM INSERTED
        WHERE wins != 0 OR
              draws != 0 OR
              loses != 0 OR
              goals_scored != 0 OR
              goals_conceded != 0
    )
    BEGIN
        RAISERROR('ERROR: Cannot add statistics related to games (wins,draws,losses,goals)! These are updated automatically when games are added.', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    SELECT @competitionID = competition, @teamID = team FROM INSERTED;
    SELECT @teamCT = country FROM FD.TEAM WHERE id = @teamID;
    SELECT @teamCN = continent FROM FD.COUNTRY WHERE name = @teamCT;

    IF NOT EXISTS(
        SELECT id FROM FD.COMPETITION
        WHERE id=@competitionID AND
              (country=@teamCT OR
                  (country IS Null AND continent=@teamCN) OR
                  continent IS Null
              )
    )
    BEGIN
        RAISERROR('ERROR: Team should be in the same continent or country (if applicable) of competition!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END

-- Constraints on Competition
--   Domestic competitions should have a country associated
CREATE TRIGGER TR_insert_new_competition ON FD.COMPETITION
AFTER INSERT
AS
BEGIN
    DECLARE @cmptCT str128
    DECLARE @cmptCN varchar(13)
    DECLARE @cmptTY str256
    SELECT @cmptTY = type, @cmptCT = country, @cmptCN = continent FROM INSERTED
    IF (@cmptTY = 'International Cup' OR @cmptTY = 'International League') AND
        @cmptCT IS NOT NULL
    BEGIN
        RAISERROR('ERROR: International competitions can not have country associated!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END

    IF (@cmptTY = 'Domestic League' OR @cmptTY = 'Domestic Cup') AND
        @cmptCT IS NULL
    BEGIN
        RAISERROR('ERROR: Domestic competitions neet to have country associated!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    IF (NOT EXISTS (SELECT name FROM FD.COUNTRY WHERE name=@cmptCT AND continent=@cmptCN)) AND (@cmptCT IS NOT NULL)
    BEGIN
    	RAISERROR('ERROR: Invalid continent associated with country!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END 
END

-- Constraints on Player
--   Players can not have the same number
CREATE TRIGGER TR_insert_new_player ON FD.PLAYER
AFTER INSERT
AS
BEGIN
    DECLARE @shirt INT
    DECLARE @teamID INT
    SELECT @shirt = shirt_number, @teamID = team FROM INSERTED

    IF (SELECT COUNT(*) FROM FD.PLAYER WHERE team = @teamID AND shirt_number = @shirt) > 1
    BEGIN
        RAISERROR('ERROR: Shirt number is already in use by other player of same team!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END


-- Constraints on new game
--   Can not have a game with the one of the teams on the same day
--   Teams participating in game should belong to competition
--   Update team on competition table
CREATE TRIGGER TR_insert_new_game ON FD.GAME
AFTER INSERT
AS
BEGIN
    DECLARE @homeID INT
    DECLARE @homeGoals INT
    DECLARE @awayID INT
    DECLARE @awayGoals INT
    DECLARE @competitionID INT
    SELECT @homeID=home_team, @homeGoals=home_goals, @awayID=away_team, @awayGoals=away_goals, @competitionID=competition FROM INSERTED
    
    DECLARE @tab TABLE (id INT);
    INSERT INTO @tab(id) SELECT team FROM TEAM_PLAYS_COMPETITION WHERE competition=@competitionID
    IF (@homeID NOT IN (SELECT * FROM @tab)) OR (@awayID NOT IN (SELECT * FROM @tab))
    BEGIN
        RAISERROR('ERROR: One of the teams does not play in the competition!',16,1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    IF @homeGoals > @awayGoals
    BEGIN
        UPDATE TEAM_PLAYS_COMPETITION SET wins=wins+1, goals_scored=goals_scored+@homeGoals, goals_conceded=goals_conceded+@awayGoals WHERE team=@homeID AND competition=@competitionID
        UPDATE TEAM_PLAYS_COMPETITION SET loses=loses+1, goals_scored=goals_scored+@awayGoals, goals_conceded=goals_conceded+@homeGoals WHERE team=@awayID AND competition=@competitionID
    END
    
    IF @homeGoals < @awayGoals
    BEGIN
        UPDATE TEAM_PLAYS_COMPETITION SET loses=loses+1, goals_scored=goals_scored+@homeGoals, goals_conceded=goals_conceded+@awayGoals WHERE team=@homeID AND competition=@competitionID
        UPDATE TEAM_PLAYS_COMPETITION SET wins=wins+1, goals_scored=goals_scored+@awayGoals, goals_conceded=goals_conceded+@homeGoals WHERE team=@awayID AND competition=@competitionID
    END
    
    IF @homeGoals = @awayGoals
    BEGIN
        UPDATE TEAM_PLAYS_COMPETITION SET draws=draws+1, goals_scored=goals_scored+@homeGoals, goals_conceded=goals_conceded+@awayGoals WHERE team=@homeID AND competition=@competitionID
        UPDATE TEAM_PLAYS_COMPETITION SET draws=draws+1, goals_scored=goals_scored+@awayGoals, goals_conceded=goals_conceded+@homeGoals WHERE team=@awayID AND competition=@competitionID
    END
END

