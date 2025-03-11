# UI Test Automation Framework - French Numbers Quiz

## Run Tests
`dotnet test` 

### Run Tests Against Different Environments
1. Set the base URL  
  Windows CMD `set BaseURL="http://localhost:3000"`  
  Linux Bash `export BaseURL="http://localhost:3000"`  
2. Run the tests  
  `dotnet test`  

### Run Specific Test Categories (tags)
1. One category  
  `dotnet test --filter TestCategory=Smoke`  
2. Two or more categories (and)  
  `dotnet test --filter TestCategory=Smoke&TestCategory=HappyPath`  
3. Two or more categories (or)  
  `dotnet test --filter TestCategory=Smoke|TestCategory=HappyPath`  
