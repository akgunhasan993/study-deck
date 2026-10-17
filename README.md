# StudyDeck

A small but effective console app, open to improvement. It keeps your knowledge fresh with the well-known Leitner method. Instead of showing you what you already know every day, it spaces those cards out, and it brings the ones you don't know in front of you again and again until they stick. There's no escaping what you need to learn. Let's learn!

## How the Leitner method works

Every card starts in box 1. If you answer correctly, it moves up one box. If you get it wrong, it drops back to box 1. The higher the box, the less often the card shows up.

| Box | Review interval |
|-----|-----------------|
| 1   | Every day       |
| 2   | Every 2 days    |
| 3   | Every 4 days    |
| 4   | Every 7 days    |
| 5   | Every 14 days   |

## Features

- Add cards with a question and an answer
- List all cards and the box each one is in
- Study mode: only cards that are due today are asked
- Session summary at the end of each study round
- Cards are saved to a JSON file, so nothing is lost when you close the app

## Getting started

You need the [.NET SDK](https://dotnet.microsoft.com/download) installed.

```bash
git clone https://github.com/akgunhasan993/study-deck.git
cd study-deck/DeskProject
dotnet run
```

## Usage

```
Choose a number:
1- Add card
2- Cards list
3- Study
0- Exit
```

## Built with

C#, .NET, System.Text.Json

## Roadmap

- [ ] Delete and edit cards
- [ ] Topic tags and per-topic statistics
- [ ] Colorful table-based interface (Spectre.Console)