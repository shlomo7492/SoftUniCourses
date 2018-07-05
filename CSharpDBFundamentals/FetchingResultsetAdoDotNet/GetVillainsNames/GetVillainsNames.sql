SELECT v.[Name]
	,COUNT(*) AS [NumberOfMinions]
FROM
	[Villains] AS v
JOIN 
	[VillainMinions] AS vm
ON  v.[Id]=vm.[VillainId]
 GROUP BY v.[Name]
 HAVING COUNT(*)>3
 ORDER BY [NumberOfMinions] DESC