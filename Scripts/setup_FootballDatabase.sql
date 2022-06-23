/*
Script to create database schema
*/
USE p1g7
GO

-- schema
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name='FD') -- FD=FootballDatabase
BEGIN
    exec('CREATE SCHEMA FD;')
END
GO


-- types
IF NOT EXISTS( SELECT * FROM sys.types WHERE name='str128')
BEGIN
    CREATE TYPE str128 FROM VARCHAR(128)
END

IF NOT EXISTS( SELECT * FROM sys.types WHERE name='str256')
BEGIN
    CREATE TYPE str256 FROM VARCHAR(256)
END

GO

-- because enums dont exist in t-sql we create restricted tables to represent them
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'CONTINENT')
BEGIN
    CREATE TABLE FD.CONTINENT(
        name VARCHAR(13),

        PRIMARY KEY(name),
        
        CHECK (name IN ('Africa', 'Asia', 'Europe', 'North America', 'Oceania', 'South America'))
    )

    INSERT INTO FD.CONTINENT VALUES ('Africa'), ('Asia'), ('Europe'), ('North America'), ('Oceania'), ('South America')
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'COMPETITION_TYPE')
BEGIN
    CREATE TABLE FD.COMPETITION_TYPE(
        name str256,
        
        PRIMARY KEY (name),
        
        CHECK (name IN ('Domestic League', 'Domestic Cup', 'International League', 'International Cup', 'Friendly Tournament'))
    )

    INSERT INTO FD.COMPETITION_TYPE VALUES ('Domestic League'), ('Domestic Cup'), ('International League'), ('International Cup'), ('Friendly Tournament')
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'FOOT')
BEGIN
    CREATE TABLE FD.FOOT(
        foot VARCHAR(5) NOT NULL,
        
        PRIMARY KEY (foot),
        
        CHECK (foot IN ('Right', 'Left', 'Both'))
    )

    INSERT INTO FD.FOOT VALUES ('Right'), ('Left'), ('Both')
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'POSITION')
BEGIN
    CREATE TABLE FD.POSITION(
        position VARCHAR(32) NOT NULL,
        abbreviation VARCHAR(2) NOT NULL,
          
        PRIMARY KEY (position),
        
        CHECK (position IN ('Goalkeeper', 'Defender Right', 'Defender Center', 'Defender Left',  'Defensive Midfielder', 'Midfielder Right', 'Midfielder Center', 'Midfielder Left', 'Attacking Midfielder', 'Right Winger', 'Left Winger', 'Striker')),
        CHECK (abbreviation IN ('GK', 'DR', 'DC', 'DL', 'DM', 'MR', 'MC', 'ML', 'AM', 'RW', 'LW', 'ST'))
    )

    INSERT INTO FD.POSITION VALUES ('Goalkeeper', 'GK'), ('Defender Right', 'DR'), ('Defender Center', 'DC'), ('Defender Left', 'DL'),  ('Defensive Midfielder', 'DM'), ('Midfielder Right', 'MR'), ('Midfielder Center', 'MC'), ('Midfielder Left', 'ML'), ('Attacking Midfielder', 'AM'), ('Right Winger', 'RW'), ('Left Winger', 'LW'), ('Striker', 'ST')
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'CARD')
BEGIN
    CREATE TABLE FD.CARD(
        card VARCHAR(6) NOT NULL,
        
        PRIMARY KEY (card),
        
        CHECK (card IN ('Red', 'Yellow'))
    )

    INSERT INTO FD.CARD VALUES ('Red'), ('Yellow')
END

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'FD' AND TABLE_NAME = 'COUNTRY')
BEGIN
    CREATE TABLE FD.COUNTRY(
	    name str128 NOT NULL,
	    continent VARCHAR(13) NOT NULL,

	    PRIMARY KEY (name),
	    FOREIGN KEY (continent) REFERENCES FD.CONTINENT(name)
    )

    INSERT INTO FD.COUNTRY VALUES ('Algeria','Africa'), ('Angola','Africa'),
        ('Benin','Africa'), ('Botswana','Africa'), ('Burkina Faso','Africa'),
        ('Burundi','Africa'), ('Cameroon','Africa'), ('Cape Verde','Africa'),
        ('Central African Republic','Africa'), ('Chad','Africa'),
        ('Comoros','Africa'), ('Congo','Africa'),
        ('Congo, Democratic Republic Of','Africa'), ('Djibouti','Africa'),
        ('Egypt','Africa'), ('Equatorial Guinea','Africa'), ('Eritrea','Africa'),
        ('Ethiopia','Africa'), ('Gabon','Africa'), ('Gambia','Africa'),
        ('Ghana','Africa'), ('Guinea','Africa'), ('Guinea-Bissau','Africa'),
        ('Ivory Coast','Africa'), ('Kenya','Africa'), ('Lesotho','Africa'),
        ('Liberia','Africa'), ('Libya','Africa'), ('Madagascar','Africa'),
        ('Malawi','Africa'), ('Mali','Africa'), ('Mauritania','Africa'),
        ('Mauritius','Africa'), ('Morocco','Africa'), ('Mozambique','Africa'),
        ('Namibia','Africa'), ('Niger','Africa'), ('Nigeria','Africa'),
        ('Rwanda','Africa'), ('Sao Tome And Principe','Africa'),
        ('Senegal','Africa'), ('Seychelles','Africa'), ('Sierra Leone','Africa'),
        ('Somalia','Africa'), ('South Africa','Africa'), ('South Sudan','Africa'),
        ('Sudan','Africa'), ('Swaziland','Africa'), ('Tanzania','Africa'),
        ('Togo','Africa'), ('Tunisia','Africa'), ('Uganda','Africa'),
        ('Zambia','Africa'), ('Zimbabwe','Africa'), ('Afghanistan','Asia'),
        ('Bahrain','Asia'), ('Bangladesh','Asia'), ('Bhutan','Asia'),
        ('Brunei','Asia'), ('Burma (Myanmar)','Asia'), ('Cambodia','Asia'),
        ('China','Asia'), ('East Timor','Asia'), ('India','Asia'),
        ('Indonesia','Asia'), ('Iran','Asia'), ('Iraq','Asia'), ('Israel','Asia'),
        ('Japan','Asia'), ('Jordan','Asia'), ('Kazakhstan','Asia'),
        ('Korea, North','Asia'), ('Korea, South','Asia'), ('Kuwait','Asia'),
        ('Kyrgyzstan','Asia'), ('Laos','Asia'), ('Lebanon','Asia'),
        ('Malaysia','Asia'), ('Maldives','Asia'), ('Mongolia','Asia'),
        ('Nepal','Asia'), ('Oman','Asia'), ('Pakistan','Asia'),
        ('Palestine', 'Asia'), ('Philippines','Asia'), ('Qatar','Asia'),
        ('Saudi Arabia','Asia'), ('Singapore','Asia'), ('Sri Lanka','Asia'),
        ('Syria','Asia'), ('Tajikistan','Asia'), ('Thailand','Asia'),
        ('Turkey','Asia'), ('Turkmenistan','Asia'), ('United Arab Emira tes','Asia'),
        ('Uzbekistan','Asia'), ('Vietnam','Asia'), ('Yemen','Asia'),
        ('Albania','Europe'), ('Andorra','Europe'), ('Armenia','Europe'),
        ('Austria','Europe'), ('Azerbaijan','Europe'), ('Belarus','Europe'),
        ('Belgium','Europe'), ('Bosnia And Herzegovina','Europe'),
        ('Bulgaria','Europe'), ('Croatia','Europe'), ('Cyprus','Europe'),
        ('Czech Republic','Europe'), ('Denmark','Europe'), ('England','Europe'), ('Estonia','Europe'),
        ('Finland','Europe'), ('France','Europe'), ('Georgia','Europe'),
        ('Germany','Europe'), ('Greece','Europe'), ('Hungary','Europe'),
        ('Iceland','Europe'), ('Ireland','Europe'), ('Italy','Europe'),
        ('Latvia','Europe'), ('Liechtenstein','Europe'), ('Lithuania','Europe'),
        ('Luxembourg','Europe'), ('Macedonia','Europe'), ('Malta','Europe'),
        ('Moldova','Europe'), ('Monaco','Europe'), ('Montenegro','Europe'),
        ('Netherlands','Europe'), ('Northern Ireland', 'Europe'), ('Norway','Europe'), ('Poland','Europe'),
        ('Portugal','Europe'), ('Romania','Europe'), ('Russia','Europe'), ('San Marino','Europe'),
        ('Serbia','Europe'), ('Scotland', 'Europe'), ('Slovakia','Europe'), ('Slovenia','Europe'),
        ('Spain','Europe'), ('Sweden','Europe'), ('Switzerland','Europe'),
        ('Ukraine','Europe'), ('Vatican City','Europe'), ('Wales','Europe'),
        ('Antigua And Barbuda','North America'), ('Bahamas','North America'),
        ('Barbados','North America'), ('Belize','North America'),
        ('Canada','North America'), ('Costa Rica','North America'),
        ('Cuba','North America'), ('Dominica','North America'),
        ('Dominican Republic','North America'), ('El Salvador','North America'),
        ('Grenada','North America'), ('Guatemala','North America'),
        ('Haiti','North America'), ('Honduras','North America'),
        ('Jamaica','North America'), ('Mexico','North America'),
        ('Nicaragua','North America'), ('Panama','North America'),
        ('Saint Kitts And Nevis','North America'), ('Saint Lucia','North America'),
        ('Saint Vincent And The Grenadines','North America'),
        ('Trinidad And Tobago','North America'), ('United States of America','North America'),
        ('Australia','Oceania'), ('Fiji','Oceania'), ('Kiribati','Oceania'),
        ('Marshall Islands','Oceania'), ('Micronesia','Oceania'),
        ('Nauru','Oceania'), ('New Zealand','Oceania'), ('Palau','Oceania'),
        ('Papua New Guinea','Oceania'), ('Samoa','Oceania'),
        ('Solomon Islands','Oceania'), ('Tonga','Oceania'), ('Tuvalu','Oceania'),
        ('Vanuatu','Oceania'), ('Argentina','South America'),
        ('Bolivia','South America'), ('Brazil','South America'),
        ('Chile','South America'), ('Colombia','South America'),
        ('Ecuador','South America'), ('Guyana','South America'),
        ('Paraguay','South America'), ('Peru','South America'),
        ('Suriname','South America'), ('Uruguay','South America'),
        ('Venezuela','South America')
END

GO


-- tables
CREATE TABLE FD.COMPETITION(
	id INT IDENTITY(1,1),
	name str128 NOT NULL,
	type str256 NOT NULL,
	continent VARCHAR(13),
	country str128,

	PRIMARY KEY (id),
	FOREIGN KEY (continent) REFERENCES FD.CONTINENT(name),
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),
	FOREIGN KEY (type) REFERENCES FD.COMPETITION_TYPE(name)
)

CREATE TABLE FD.STADIUM(
	id INT IDENTITY(1,1),
	attendance INT NOT NULL,
	name str256 NOT NULL,
	country str128 NOT NULL,

	PRIMARY KEY (id),
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),

    CHECK(attendance >= 0)
)

CREATE TABLE FD.REFEREE(
	id INT IDENTITY(1,1),
	fname str128 NOT NULL,
	minit VARCHAR(1),
	lname str128 NOT NULL,
	birth_date DATE NOT NULL,
	country str128 NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),
)

CREATE TABLE FD.COACH(
	id INT IDENTITY(1,1),
	fname str128 NOT NULL,
	minit VARCHAR(1),
	lname str128 NOT NULL,
	birth_date DATE NOT NULL,
	country str128 NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),
)

CREATE TABLE FD.TEAM(
	id INT IDENTITY(1,1),
	name str256 NOT NULL,
	abreviation CHAR(3) NOT NULL,
	stadium INT,
	country	str128 NOT NULL,
	coach INT,
	
	PRIMARY KEY (id),
	FOREIGN KEY (stadium) REFERENCES FD.STADIUM(id) ON DELETE SET NULL,
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),
	FOREIGN KEY (coach) REFERENCES FD.COACH(id) ON DELETE SET NULL
)

CREATE TABLE FD.TEAM_PLAYS_COMPETITION(
	team INT NOT NULL,
	competition INT NOT NULL,
	wins INT NOT NULL DEFAULT 0,
	draws INT NOT NULL DEFAULT 0,
	loses INT NOT NULL DEFAULT 0,
	goals_scored INT NOT NULL DEFAULT 0,
	goals_conceded INT NOT NULL DEFAULT 0,

	PRIMARY KEY (team,competition),
	FOREIGN KEY (team) REFERENCES FD.TEAM(id) ON DELETE CASCADE,
	FOREIGN KEY (competition) REFERENCES FD.COMPETITION(id) ON DELETE CASCADE,
	
	CHECK (wins >= 0),
	CHECK (draws >= 0),
	CHECK (loses >= 0),
	CHECK (goals_scored >= 0),
	CHECK (goals_conceded >= 0)
)

CREATE TABLE FD.PLAYER(
	id INT IDENTITY(1,1),
	fname str128 NOT NULL,
	minit VARCHAR(1),
	lname str128 NOT NULL,
	birth_date DATE NOT NULL,
	country str128 NOT NULL,
	team INT,
	position VARCHAR(32) NOT NULL,
	preferred_foot VARCHAR(5) NOT NULL,
	height INT NOT NULL,    -- Em centimetros (180cm por ex)
   	weight DECIMAL(4,1) NOT NULL,    -- Em kg (75.2kg por ex)
	shirt_number INT NOT NULL,

	PRIMARY KEY (id),
	FOREIGN KEY (country) REFERENCES FD.COUNTRY(name),
	FOREIGN KEY (team) REFERENCES FD.TEAM(id) ON DELETE SET NULL,
	FOREIGN KEY (position) REFERENCES FD.POSITION(position),
	FOREIGN KEY (preferred_foot) REFERENCES FD.FOOT(foot),
	
    CHECK (weight > 0),
	CHECK (weight < 300), -- Absurd numbers just to limit option
    CHECK (height > 0),
	CHECK (height < 300), -- Absurd numbers just to limit option
    CHECK (shirt_number > 0),
    CHECK (shirt_number < 100)
)

CREATE TABLE FD.GAME(
	id INT IDENTITY(1,1),
	home_goals INT NOT NULL DEFAULT 0,
	away_goals INT NOT NULL DEFAULT 0,
	date DATE NOT NULL,
	stadium INT,
	competition INT NOT NULL,
	referee INT,
	home_team INT NOT NULL,
	away_team INT NOT NULL,

	PRIMARY KEY (id),
	FOREIGN KEY (stadium) REFERENCES FD.STADIUM(id) ON DELETE SET NULL,
	FOREIGN KEY (competition) REFERENCES FD.COMPETITION(id) ON DELETE CASCADE,
	FOREIGN KEY (referee) REFERENCES FD.REFEREE(id) ON DELETE SET NULL,
	FOREIGN KEY (home_team) REFERENCES FD.TEAM(id),
	FOREIGN KEY (away_team) REFERENCES FD.TEAM(id),

    CHECK (home_goals >= 0),
    CHECK (away_goals >= 0),
    CHECK (home_team != away_team)
)

CREATE TABLE FD.PLAYER_PARTICIPATES_GAME(
	game INT NOT NULL,
	player INT NOT NULL,
	home_team BIT NOT NULL,
	starter BIT NOT NULL,

	PRIMARY KEY (game,player),
	FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
	FOREIGN KEY (player) REFERENCES FD.PLAYER(id) ON DELETE CASCADE
)

CREATE TABLE FD.GOAL(
    id INT IDENTITY(1,1),
    game INT NOT NULL,
    gametime INT NOT NULL,
    home_team BIT NOT NULL,
    scorer INT,
    assistant INT,
    
    PRIMARY KEY (id),
    FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
    FOREIGN KEY (scorer) REFERENCES FD.PLAYER(id),
    FOREIGN KEY (assistant) REFERENCES FD.PLAYER(id),
    

    CHECK (gametime > 0),
    CHECK (gametime <= 90)

)

CREATE TABLE FD.PLAYER_STAT(
	game INT NOT NULL,
	player INT NOT NULL,
	time_played INT NOT NULL DEFAULT 0,
	goals INT NOT NULL DEFAULT 0,
	assists INT NOT NULL DEFAULT 0,
	touches INT NOT NULL DEFAULT 0,
	passes INT NOT NULL DEFAULT 0,
	shots INT NOT NULL DEFAULT 0,
	tackles INT NOT NULL DEFAULT 0,
	home_team BIT NOT NULL,

	PRIMARY KEY (game,player),
	FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
	FOREIGN KEY (player) REFERENCES FD.PLAYER(id),
	
	CHECK (time_played > 0),
    CHECK (time_played <= 90),
    CHECK (goals >= 0),
    CHECK (assists >= 0),
    CHECK (touches >= 0),
    CHECK (passes >= 0),
    CHECK (shots >= 0),
    CHECK (tackles >= 0)
)

CREATE TABLE FD.TEAM_STAT(
	game INT NOT NULL,
	home_team BIT NOT NULL,
	team INT NOT NULL,
	ball_possesion INT NOT NULL,
	total_shots INT NOT NULL DEFAULT 0,
	offsides INT NOT NULL DEFAULT 0, 
	passes INT NOT NULL DEFAULT 0,
	tackles INT NOT NULL DEFAULT 0,
	fouls INT NOT NULL DEFAULT 0,
	corner_kicks INT NOT NULL DEFAULT 0,

	PRIMARY KEY (game,home_team),
	FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
	FOREIGN KEY (team) REFERENCES FD.TEAM(id),
	
	CHECK (ball_possesion > 0),
	CHECK (ball_possesion < 100),
	CHECK (total_shots >= 0),
	CHECK (offsides >= 0),
	CHECK (passes >= 0),
	CHECK (tackles >= 0),
	CHECK (fouls >= 0),
	CHECK (corner_kicks >= 0)
)

CREATE TABLE FD.SUBSTITUTION(
	id INT IDENTITY(1,1),
	game INT NOT NULL,
	gametime INT NOT NULL,
	home_team BIT NOT NULL,
	player_in INT NOT NULL,
	player_out INT NOT NULL,
	
	PRIMARY KEY (id),
	FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
	FOREIGN KEY (player_in) REFERENCES FD.PLAYER(id),
	FOREIGN KEY (player_out) REFERENCES FD.PLAYER(id),
	
	CHECK (gametime > 0),
	CHECK (gametime <= 90)
)

CREATE TABLE FD.MISSCONDUCT(
	id INT IDENTITY(1,1),
	game INT NOT NULL,
	player INT NOT NULL,
	gametime INT NOT NULL,
	card VARCHAR(6) NOT NULL,
	home_team BIT NOT NULL,

	PRIMARY KEY (id),
	FOREIGN KEY (game) REFERENCES FD.GAME(id) ON DELETE CASCADE,
	FOREIGN KEY (player) REFERENCES FD.PLAYER(id),
	FOREIGN KEY (card) REFERENCES FD.CARD(card),
	
	CHECK (gametime > 0),
	CHECK (gametime <= 90)
)
