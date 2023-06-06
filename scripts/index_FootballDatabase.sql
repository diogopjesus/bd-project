USE p1g7;

CREATE INDEX idx_player ON FD.PLAYER(team); 

CREATE INDEX idx_game ON FD.GAME(competition);

CREATE INDEX idx_substitution ON FD.SUBSTITUTION(game);

CREATE INDEX idx_misconduct ON FD.MISCONDUCT(game);

CREATE INDEX idx_goal ON FD.GOAL(game);

CREATE INDEX idx_playerStat ON FD.PLAYER_STAT(player);

CREATE INDEX idx_teamPlaysCompetition ON FD.TEAM_PLAYS_COMPETITION(competition);

