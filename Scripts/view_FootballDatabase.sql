CREATE VIEW FD.V_MATCH AS
    SELECT g.id AS game_id, c.id AS competition_id, c.name AS competition, g.date AS date, t1.id AS home_id, t1.name AS home_team, t1.abbreviation AS home_abv, g.home_goals AS home_goals, t2.id AS away_id, t2.name AS away_team, t2.abbreviation AS away_abv, g.away_goals AS away_goals, s.name AS stadium, r.fname + ' ' + COALESCE(r.minit + ' ', '') + r.lname AS referee
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
    p.birth_date as birth_date, c.continent as continent, c.name as country, p.shirt_number, p.preferred_foot, p.height, p.weight 
    FROM FD.PLAYER p
    INNER JOIN FD.COUNTRY c ON p.country = c.name
    INNER JOIN FD.POSITION po ON p.position = po.position
    LEFT OUTER JOIN FD.TEAM t ON p.team = t.id

CREATE VIEW FD.V_TEAM_IN_COMPETITION AS
    SELECT c.continent as continent, c.country as country,  c.id as competition_id, c.name as competition, t.id as team_id, t.abbreviation as abbreviation, t.name as name,
    t.stadium as stadium, t.attendance as attendance, t.coach as coach, tpc.wins as wins, tpc.draws as draws, tpc.loses as losses, tpc.goals_scored as goals_scored, tpc.goals_conceded as goals_conceded   
    FROM FD.TEAM_PLAYS_COMPETITION tpc
    INNER JOIN FD.COMPETITION c ON tpc.competition = c.id
    INNER JOIN FD.V_TEAM t ON tpc.team = t.id

CREATE VIEW FD.V_MISCONDUCT AS
    SELECT m.game AS game,
    m.gametime AS gametime,
    CASE m.home_team
    WHEN 1 THEN ma.home_team
    WHEN 0 THEN ma.away_team
    ELSE Null END AS team,
    p.name AS player, m.card AS card
    FROM FD.MISCONDUCT m
    INNER JOIN FD.V_MATCH ma ON m.game = ma.game_id
    INNER JOIN FD.V_PLAYER p ON m.player = p.player_id


CREATE VIEW FD.V_GOAL AS
    SELECT g.game AS game,
    g.gametime AS gametime,
    CASE g.home_team
    WHEN 1 THEN m.home_team
    WHEN 0 THEN m.away_team
    ELSE Null END AS team,
    p1.name AS scorer, p2.name AS assistant
    FROM FD.GOAL g
    INNER JOIN FD.V_MATCH m ON g.game = m.game_id
    INNER JOIN FD.V_PLAYER p1 ON g.scorer = p1.player_id
    INNER JOIN FD.V_PLAYER p2 ON g.assistant = p2.player_id


CREATE VIEW FD.V_SUBSTITUTION AS
    SELECT s.game AS game,
    s.gametime AS gametime,
    CASE s.home_team
    WHEN 1 THEN m.home_team
    WHEN 0 THEN m.away_team
    ELSE Null END AS team,
    p1.name AS player_in, p2.name AS player_out
    FROM FD.SUBSTITUTION s
    INNER JOIN FD.V_MATCH m ON s.game = m.game_id
    INNER JOIN FD.V_PLAYER p1 ON s.player_in = p1.player_id
    INNER JOIN FD.V_PLAYER p2 ON s.player_out = p2.player_id
