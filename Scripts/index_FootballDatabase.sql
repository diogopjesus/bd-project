
CREATE INDEX idx_player ON FD.PLAYER(team); 

CREATE INDEX idx_teamID ON FD.TEAM(id);

CREATE INDEX idx_gameID ON FD.GAME(id);

CREATE INDEX idx_game ON FD.GAME(competition);

CREATE INDEX idx_substitution ON FD.SUBSTITUTION(game);

CREATE INDEX idx_missConduct ON FD.MISSCONDUCT(game);

CREATE INDEX idx_teamStat ON FD.TEAM_STAT(game); 

CREATE INDEX idx_playerStat ON FD.PLAYER_STAT(game);