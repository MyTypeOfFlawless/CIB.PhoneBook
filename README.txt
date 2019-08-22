1.	The first project (AngularUI) is a visual studio code project; In visual studio, terminal with ng serve -o. It communicates with the Services.webApi project.

2.	Then there is an entity framework crud SPA project.

3.	The last two projects are real world projects in production. It integrates with an Api (WaboxApp). The first sends whatsapp messages with RestSharp. The second is a Rest webhook that waits for incoming messages and writes them to the database. It requires additional tables, so the functionality for that is commented out.
