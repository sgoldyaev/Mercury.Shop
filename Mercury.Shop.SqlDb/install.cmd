
sqlcmd -S . -i Security\MercuryDb.sql
sqlcmd -S . -i Security\MercuryLogin.sql
sqlcmd -S . -i Security\MercuryUser.sql
sqlcmd -S . -i Security\RoleMemberships.sql
sqlcmd -S . -i dbo\Tables\Product.sql
sqlcmd -S . -i "dbo\Stored Procedures\GenerateMockProducts.sql"

pause
