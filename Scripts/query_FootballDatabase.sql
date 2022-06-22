/* */ 
SELECT 
FROM FD.GAME g INNER JOIN FD.PLAYER_STAT ps ON g.id = ps.game
               INNER JOIN FD.TEAM_STAT ts ON g.id = ts.game
               inner join FD.PLAYER pl ON ps.id = pl.id
               
