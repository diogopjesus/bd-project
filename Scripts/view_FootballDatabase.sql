CREATE VIEW FD.V_MATCH AS
    SELECT g.id AS game_id, c.name AS competition, g.date AS date, t1.id as home_id, t1.name AS home_team, g.home_goals AS home_goals,
    t2.id as away_id, t2.name AS away_team, g.away_goals AS away_goals, s.name AS stadium, r.fname + ' ' + COALESCE(r.minit + ' ', '') + r.lname AS referee
    FROM FD.GAME g
    LEFT OUTER JOIN FD.REFEREE r ON g.referee = r.id
    INNER JOIN FD.TEAM t1 ON g.home_team = t1.id
    INNER JOIN FD.TEAM t2 ON g.away_team = t2.id
    INNER JOIN FD.COMPETITION c ON g.competition = c.id
    LEFT OUTER JOIN FD.STADIUM s ON g.stadium = s.id

CREATE VIEW FD.V_TEAM AS
    SELECT t.id as id, t.abbreviation AS abbreviation, t.name AS name, co.continent AS continent, co.name AS country, s.name AS stadium,
    s.attendance AS attendance, c.fname + ' ' + COALESCE(c.minit + ' ', '') + c.lname as coach
    FROM FD.TEAM t
    LEFT OUTER JOIN FD.STADIUM s ON t.stadium = s.id
    LEFT OUTER JOIN FD.COACH c ON t.coach = c.id
    INNER JOIN FD.COUNTRY co on t.country = co.name

CREATE VIEW FD.V_PLAYER AS
    SELECT t.id as team_id, t.name as team, p.id as player_id, p.fname + ' ' + COALESCE(p.minit + ' ', '') + p.lname as name, po.position as position, po.abbreviation as position_abv,
    p.birth_date as brith_date, c.continent as continent, c.name as country, p.shirt_number, p.preferred_foot, p.height, p.weight 
    FROM FD.PLAYER p
    INNER JOIN FD.COUNTRY c ON p.country = c.name
    INNER JOIN FD.POSITION po ON p.position = po.position
    INNER JOIN FD.TEAM t ON p.team = t.id

CREATE VIEW FD.V_TEAM_IN_COMPETITION AS
    SELECT c.continent as continent, c.country as country, c.name as competition, t.abbreviation as abbreviation, t.name as name,
    t.stadium as stadium, t.attendance as attendance, t.coach as coach  
    FROM FD.TEAM_PLAYS_COMPETITION tpc
    INNER JOIN FD.COMPETITION c ON tpc.competition = c.id
    INNER JOIN FD.V_TEAM t ON tpc.team = t.id

CREATE VIEW FD.V_MISSCONDUCT AS
    SELECT m.game as game_id, ma.home_team as home_team, ma.away_team as away_team, m.card as card,
    m.home_team as home_player, p.name as player, m.gametime as gametime
    FROM FD.MISSCONDUCT m
    INNER JOIN FD.V_MATCH ma ON m.game = ma.game_id
    INNER JOIN FD.V_PLAYER p ON m.player = p.player_id

CREATE VIEW FD.V_GOAL AS
    SELECT g.game as game_id, m.home_team as home_team, m.away_team as away_team,
    m.home_team as home_goal, g.gametime as gametime, p1.name as scorer, p2.name as assistant
    FROM FD.GOAL g
    INNER JOIN FD.V_MATCH m ON g.game = m.game_id
    INNER JOIN FD.V_PLAYER p1 ON g.scorer = p1.player_id
    INNER JOIN FD.V_PLAYER p2 ON g.assistant = p2.player_id

-- TODO: SUBSTITUTION