# WebApplication2

An example repo for https://github.com/dotnet/efcore/issues/32381

1. git pull https://github.com/GiannhsR/WebApplication2.git 
2. run `dotnet ef migrations add Initial`
3. Exception received 
 ```
 System.InvalidOperationException: The entity type 'PostTag' requires a primary key to be defined.
 If you intended to use a keyless entity type, call 'HasNoKey' in 'OnModelCreating'. For more information on keyless entity types, 
 see https://go.microsoft.com/fwlink/?linkid=2141943
 ```
