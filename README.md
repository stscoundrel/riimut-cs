# Riimut

Transform latin letters to runes &amp; vice versa. C# version.

Includes transformers for four main runic alphabets:

- Elder Futhark
- Younger Futhark
- Medieval Futhork
- Futhorc (Anglo-Frisian runes)

### Install

```
dotnet add package Riimut
```

### Usage

Text to runes:
```csharp
// Ships four runic dialects under Riimut namespace.
using Riimut;

// From Old Groms runestone.
string content = "auk tani karþi kristna";
string youngerFuthark = YoungerFuthark.LettersToRunes(content);
Console.WriteLine(youngerFuthark); // ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ

// From 4th century axe in Jutland
string content = "wagagastiz alu wihgu sikijaz aiþalataz";
string elderFuthark = ElderFuthark.LettersToRunes(content);
Console.WriteLine(elderFuthark); // ᚹᚨᚷᚨᚷᚨᛋᛏᛁᛉ:ᚨᛚᚢ:ᚹᛁᚻᚷᚢ:ᛋᛁᚲᛁᛃᚨᛉ:ᚨᛁᚦᚨᛚᚨᛏᚨᛉ

// From Lord's Prayer, in Old Norse.
string content = "Faðer uor som ast i himlüm, halgað warðe þit nama";
string medievalFuthork = MedievalFuthork.LettersToRunes(content);
Console.WriteLine(medievalFuthork); // ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ,:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ

// From 8th century Franks Casket, in late West Saxon.
string content = "fisc.flodu.ahofonferg | enberig |";
string futhorc = Futhorc.LettersToRunes(content);
Console.WriteLine(futhorc); // ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|

```

Runes to text:
```csharp

// All four dialects contain RunesToLetters method.
using Riimut;

string runicText = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";
string latinText = YoungerFuthark.RunesToLetters(runicText);

Console.WriteLine(latinText); // "auk tani karþi kristna"

```


#### What's in the name?

"Riimut" is the Finnish word for "runes".
