Seeder:
1. cd to BeeTest (cd BeeTest)
2. run the seeder script (dotnet run seed)

Optimizations & Key Features:
- Storing Files in a Cloud Storage Service like Firebase to Optimize Database Memory Usage.
- Saving Question Details in a JSON String format, to Make the Program more Expandable (Adding a new QuestionType doesn't Imply Creating a New Table / Adding a Column). Also reducing the amount of JOIN operations needed.
- SignalR for Server Time.
- Indexing for Users Table on Email

Thank You :)