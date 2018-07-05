SELECT m.[Name],m.[Age] FROM [Minions] AS m 
JOIN [VillainMinions] AS vm
ON m.[Id]=vm.[MinionId]
WHERE vm.[VillainId]=@Id