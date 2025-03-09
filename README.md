How to run
1. git clone https://github.com/BelalAbdibaliev/LocoParser
2. docker compose -f docker/docker-compose.yml up -d
3. cd src/Core/Infrastructure
4. dotnet ef database update --startup-project ../../Application/LocoParser.BlazorApp\LocoParser.BlazorApp.csproj
