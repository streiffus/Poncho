# Poncho
WIP C# Game framework

Poncho is a basic foundation for creating game frameworks.

By itself, Poncho does nothing - you'll need to implement a few required interfaces in another framework of your choice and hook them into Poncho (for example, Monogame).

To do so, create a class that implements IGameApp. Then, pass that class or instance of that class into App.Init().

Poncho attempts to use a display list just like Adobe Flash. There is a concept of a Stage and you can add Sprites to the Stage and other Sprites.

This is still very much a work in progress. Expect active development to be sporadic.
