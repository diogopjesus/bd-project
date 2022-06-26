# Instruções de utilização

Para poder colocar o ambiente como foi testado deve correr os scripts deste diretório pela seguinte ordem:
- drop\_FootballDatabase.sql - Para remover tabelas (caso já tenha corrido algum script ateriormente).
- setup\_FootballDatabase.sql - Para criar o schema e as respetivas tabelas.
- index\_FootballDatabase.sql - Para criar os indexs usados no projeto.
- trigger\_FootballDabase.sql - Apenas o trigger TR\_insert\_new\_game, para atribuir vitorias/empates/derrotas automaticamente ao inserir um jogo.
- insert\_FootballDatabase.sql - Para povoar as tabelas com informação de teste.
- trigger\_FootballDabase.sql - Deve correr os restantes triggers individualmente e não o script todo de uma vez.
- view\_FootballDatabase.sql - Deve correr cada view individualmente e não o script todo de uma vez.
- udf\_FootballDatabase.sql - Deve correr cada UDF individualmente e não o script todo de uma vez.
- stored\_procedure\_FootballDatabase.sql - Deve correr cada stored\_procedure individualmente e não o script todo de uma vez

## Alguma Informação relevante
A informação do insert_FootballDatabase.sql é toda real exceptuando a informação relacionada com os jogos.
Essa informação foi obtida através de scraping do site [sofifa.com](sofifa.com) por um script escrito em python.
Os comandos foram depois gerados automaticamente de acordo com essa informação retirada.
A informação é relevante à primeira liga de futebol portuguesa de 2021/2022.
