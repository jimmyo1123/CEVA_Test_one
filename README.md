Test 1: .Net Core/Spring Boot:
Create a .Net Core Web or Spring Boot REST API, which accepts the below array as JSON
request and perform the following tasks
1. Create directory “Users”, If not exist at specified path in a config file
a. Create Sub Directory “IN”.
2. Store the Request as JSON file in “IN” directory” created above

## Sample Request (POST /api/users)

```json
JSON Request:
[
  {
  "ID": 64,
  "UserID": 7,
  "EmployeeID": "CLGAXO",
  "SiteName": "MULGRAVE",
  "BusinessUnitName": "Telstra Logistics - Melbourne",
  "AccountName": "IBM AUSTRALIA LTD",
  "GroupName": "Transport",
  "CategoryName": "Activity - Productive",
  "TypeName": "Transport - Freight Sorting",
  "Date": "2018-02-14",
  "Duration": "00:30",
  "IsProcessed": false
  },
  {
  "ID": 66,
  "UserID": 7,
  "EmployeeID": "CLGAXO",
  "SiteName": "MULGRAVE",
  "BusinessUnitName": "Telstra Logistics - Melbourne",
  "AccountName": "IBM AUSTRALIA LTD",
  "GroupName": "Picking",
  "CategoryName": "Activity - Productive",
  "TypeName": "Picking - Bulk",
  "Date": "2018-02-15",
  "Duration": "00:30",
  "IsProcessed": false
  }
]
