# Guess the Number Game 🎲

## Overview
The "Guess the Number" game is a simple console-based application written in C#. The program generates a random number between 1 and 10 you can change the range of numbers, and the player tries to guess it. After each guess, the program provides feedback, guiding the player to guess a higher or lower number. The game tracks the number of attempts and allows the player to play multiple rounds.

## Features
- Random number generation between 1 and 10.
- Feedback for incorrect guesses ("Try Smaller Number" or "Try Bigger Number").
- Tracks and displays the number of attempts for each round.
- Option to replay or exit after each round.


## Gameplay Instructions
1. The program will prompt you to guess a number between 1 and 10.
2. Type your guess and press `Enter`.
3. Based on your guess, the program will give feedback:
   - If the guess is too high: "Try Smaller Number."
   - If the guess is too low: "Try Bigger Number."
4. Keep guessing until you find the correct number.
5. At the end of each round, you can choose to play again or exit by typing `Y` (Yes) or `N` (No).

## Example
```
Guess a number between 1 and 10: 5
Try Bigger Number
Guess a number between 1 and 10: 8
Try Smaller Number
Guess a number between 1 and 10: 7
Correct! The Number is: 7
Number of attempts: 3
Would you like to play again (Y/N): n
Thanks for playing
```

## Requirements
- [.NET Framework](https://dotnet.microsoft.com/) or [Visual Studio](https://visualstudio.microsoft.com/) installed on your machine.

## Files Included
- **`Program.cs`**: The main source code for the game.
- **`.sln`**: Solution file for Visual Studio.
- **`.csproj`**: Project configuration file for Visual Studio.

## License
This project is open-source and available under the [MIT LICENSE](LICENSE).

## Contributing
Contributions are welcome! Feel free to fork this repository, make changes, and submit a pull request.

## Author
- **Your Name**: Replace this with your name or GitHub username.

---

Enjoy the game! 🎉
