# Honestly

## Usage

I think it is a code smell when you need to declare and assign a bool before you know what value it actually should have, but sometimes it is convenient. This library protects you from writing errounous code by giving you a runtime exception instead. Instead of initializing boolean with default values of null, false or true, you can use any of `Honestly.DontKnow`/`True`/`False`/`Null`. Honestly automatically convert to bool and bool? when needed.

```
var dbExists = false;
...
if(dbExists) // Are we sure it doesn't exist, or does dbExists still has it default value?

```

```
var dbExists = Honestly.DontKnow;
if(dbExists) -> throws Exception
```

## Credits
Icon made by [Freepik](https://www.flaticon.com/authors/freepik) from www.flaticon.com 
