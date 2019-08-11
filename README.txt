1.	The first project is an imported visual studio code project; AngularUI. It needs visual studio terminal with command ng serve -o to run. It communicates with the Services.webApi project.

2.	Then there is a entity crud SPA project.

3.	The last two projects are real world projects in production. It integrates with an Api (WaboxApp). The first sends whatsapp messages with RestSharp. The second is a Rest webhook that waits for incoming messages and writes them to the database. It is just meant to show other implementations that i did.  There is a similar setup for a finance portal integration that i can add as well. It requires additional tables, so the functionality for that is commented out.
