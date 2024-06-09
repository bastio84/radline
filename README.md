# RadLine

This is a FORK of the RadLine library from [spectreconsole](https://github.com/spectreconsole) ([patriksvensson](https://github.com/patriksvensson)).

This fork aims to provide some improvement on the original library (for now):
* readonly editor
* and possibility to place new lines wherever you want in the editor.

Following part of README file is from original library.

# Building

```
> dotnet tool restore
> dotnet cake
```

# Known issues

* Terminal is not set in raw mode, so some key combinations might not
  work in certain terminals.
* Any modifier with `ENTER` key does not register on macOS, due to a bug
  in the System.Console.ReadKey implementation. We will be moving away
  from using this before release.
