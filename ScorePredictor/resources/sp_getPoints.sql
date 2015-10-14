DECLARE @Points int;

DECLARE @UserId int;
DECLARE @FixtureId int;

DECLARE @HomePrediction int;
DECLARE @AwayPrediction int;
DECLARE @HomeScore int;
DECLARE @AwayScore int;

SET @Points = 0;

SET @UserId = 1;
SET @FixtureId = 1;

SET @HomePrediction = (select home_prediction from predictionTable where userId = @UserId);
SET @AwayPrediction = (select away_prediction from predictionTable where userId = @UserId);
SET @HomeScore = (select Home_Score from resultsTable where fixtureId = @FixtureId);
SET @AwayScore = (select Away_Score from resultsTable where fixtureId = @FixtureId);

IF ((@HomePrediction = @HomeScore) AND (@AwayPrediction = @AwayScore)) 
	SET @Points = 2;
ELSE 
	IF ((@HomePrediction > @AwayPrediction) AND (@HomeScore > @AwayScore) OR (@HomePrediction < @AwayPrediction) AND (@HomeScore < @AwayScore) OR (@HomePrediction = @AwayPrediction) AND (@HomeScore = @AwayScore)) 
		SET @Points = 1;

UPDATE weekPoints
SET points = points + @Points
Where userId = @UserId
