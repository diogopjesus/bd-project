CREATE FUNCTION UDF_getGameParticipants (@game INT, @home_team BIT) RETURNS TABLE AS
    RETURN (SELECT p.team as team, p.name as name, p.position as position, p.player_id as player_id
            FROM FD.PLAYER_PARTICIPATES_GAME pcg
            INNER JOIN FD.V_PLAYER p ON pcg.player = p.player_id
            WHERE pcg.home_team = @home_team AND pcg.game = @game)


CREATE FUNCTION UDF_getPlayerStatByGameAndPlayer (@game INT, @player INT) RETURNS TABLE AS
    RETURN (SELECT ps.game as game, p.team as team, p.name as name, p.position as position, ps.time_played,
            ps.goals, ps.assists, ps.touches, ps.passes, ps.shots, ps.tackles
            FROM FD.PLAYER_STAT ps
            INNER JOIN FD.V_PLAYER p ON ps.player = p.player_id
            WHERE ps.player = @player AND ps.game = @game)

CREATE FUNCTION UDF_getTeamStatByGame (@game INT, @home_team BIT) RETURNS TABLE AS
    RETURN (SELECT ts.game as game, t.name as team, t.abbreviation as abbreviation, ts.ball_possesion,
            ts.total_shots, ts.offsides, ts.passes, ts.tackles, ts.fouls, ts.corner_kicks
            FROM FD.TEAM_STAT ts
            INNER JOIN FD.V_TEAM t ON ts.team = t.id
            WHERE ts.game = @game AND ts.home_team = @home_team)

