-- truncate the table first
TRUNCATE TABLE dbo.Actors;
GO
 
-- import the file
BULK INSERT dbo.Actors
FROM 'zepto_v2.csv'
WITH
(
        FORMAT='CSV',
        FIRSTROW=2
)
GO