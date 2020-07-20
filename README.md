# ogs-generator

## Objective
+ Extract my list of played games to sgf files, and generate a list of browsable games.

## Things to do
### Phase 1
+ Generate API keys
+ Generate domain objects (json to C#)
+ Use the generated keys to get the list of games (using POSTMAN)
+ Write the messager class responsible for posting messages to the API
+ Login to the server, and generate session token
+ Use session token to get game list
+ Iterate game list, and get link to sgf file writing it to disk
### Phase 2
+ Create a React page which uses a goban component to display the games
+ Game move statistics. Test hypothesis that there's a significant chance I win a game when I 1) play in the morning 2) against bot 3) start as black playing <kbd>F4</kbd>
+ (Maybe) Add comments