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
4. When adding a primary key on the `PostTag` model:
```
Unable to create a 'DbContext' of type ''. The exception 'Cannot use table 'PostTag' for entity type 'PostTag' since it is being used for entity type 'PostTag (Dictionary<string, object>)' and potentially other entity types, but there is no linking relationship.
 Add a foreign key to 'PostTag' on the primary key properties and pointing to the primary key on another entity type mapped to 'PostTag'.
```
