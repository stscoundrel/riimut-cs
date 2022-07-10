# Riimut

Transform latin letters to runes &amp; vice versa. C# version.

Includes transformers for five main runic alphabets:

- Elder Futhark
- Younger Futhark
- Medieval Futhork
- Futhorc (Anglo-Frisian runes)
- Staveless Futhark

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
Dialect youngerFuthark = new YoungerFuthark();
string result = youngerFuthark.LettersToRunes(content);
Console.WriteLine(result); // ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ

// From 4th century axe in Jutland
string content = "wagagastiz alu wihgu sikijaz aiþalataz";
Dialect elderFuthark = new ElderFuthark();
string result = elderFuthark.LettersToRunes(content);
Console.WriteLine(result); // ᚹᚨᚷᚨᚷᚨᛋᛏᛁᛉ:ᚨᛚᚢ:ᚹᛁᚻᚷᚢ:ᛋᛁᚲᛁᛃᚨᛉ:ᚨᛁᚦᚨᛚᚨᛏᚨᛉ

// From Lord's Prayer, in Old Norse.
string content = "Faðer uor som ast i himlüm, halgað warðe þit nama";
Dialect medievalFuthork = new MedievalFuthork();
string result = MedievalFuthork.LettersToRunes(content);
Console.WriteLine(result); // ᚠᛆᚦᚽᚱ:ᚢᚮᚱ:ᛋᚮᛘ:ᛆᛋᛏ:ᛁ:ᚼᛁᛘᛚᚢᛘ,:ᚼᛆᛚᚵᛆᚦ:ᚠᛆᚱᚦᚽ:ᚦᛁᛏ:ᚿᛆᛘᛆ

// From 8th century Franks Casket, in late West Saxon.
string content = "fisc.flodu.ahofonferg | enberig |";
Dialect futhorc = new Futhorc();
string result = futhorc.LettersToRunes(content);
Console.WriteLine(result); // ᚠᛁᛋᚳ.ᚠᛚᚩᛞᚢ.ᚪᚻᚩᚠᚩᚾᚠᛖᚱᚷ:|:ᛖᚾᛒᛖᚱᛁᚷ:|

// From Old Norse text in Hög runestone.
string content = "kuþniutr þru sun lit rita stin þina ak bru kirþi aftiʀ bruþr sina asbiurn ak at kuþlaf";
Dialect staveless = new StavelessFuthark();
string result = staveless.LettersToRunes(content);
Console.WriteLine(result); // ᛍ╮ו⸜ᛁ╮⸍◟:ו◟╮:╵╮⸜:⸌ᛁ⸍:◟ᛁ⸍⸝:╵⸍ᛁ⸜:וᛁ⸜⸝:⸝ᛍ:ˏ◟╮:ᛍᛁ◟וᛁ:⸝ᛙ⸍ᛁʀ:ˏ◟╮ו◟:╵ᛁ⸜⸝:⸝╵ˏᛁ╮◟⸜:⸝ᛍ:⸝⸍:ᛍ╮ו⸌⸝ᛙ

```

Runes to text:
```csharp

// All four dialects contain RunesToLetters method.
using Riimut;

string runicText = "ᛅᚢᚴ:ᛏᛅᚾᛁ:ᚴᛅᚱᚦᛁ:ᚴᚱᛁᛋᛏᚾᛅ";
Dialect youngerFuthark = new YoungerFuthark();
string latinText = youngerFuthark.RunesToLetters(runicText);

Console.WriteLine(latinText); // "auk tani karþi kristna"

```


Rune variants in Younger Futhark:

Younger Futhark comes with long branch (Danish) and short twig (Norwegian & Swedish) variants.
```csharp

using Riimut;

string letters = "aábcdðeéfghiíjklmnoópqrstþuúvwxyýzåäæöøǫþ";
YoungerFuthark youngerFuthark = new YoungerFuthark();

// Comes with named methods per style.
string longBranch = youngerFuthark.LettersToLongBranchRunes(letters);
string shortTwig = youngerFuthark.LettersToShortTwigRunes(letters);

Console.WriteLine(longBranch); // ᛅᛅᛒᛋᛏᚦᛁᛁᚠᚴᚼᛁᛁᛁᚴᛚᛘᚾᚢᚢᛒᚴᚱᛋᛏᚦᚢᚢᚢᚢᛋᚢᚢᛋᚢᛅᛅᚢᚢᚢᚦ"
Console.WriteLine(shortTwig); // ᛆᛆᛒᛌᛐᚦᛁᛁᚠᚴᚽᛁᛁᛁᚴᛚᛘᚿᚢᚢᛒᚴᚱᛌᛐᚦᚢᚢᚢᚢᛌᚢᚢᛌᚢᛆᛆᚢᚢᚢᚦ

// Instance can also be created with default style. Then LettersToRunes will use that style.
YoungerFuthark youngerFutharkLongBranch = new YoungerFuthark(YoungerFuthark.Variant.LongBranch);
YoungerFuthark youngerFutharkShortTwig = new YoungerFuthark(YoungerFuthark.Variant.ShortTwig);

// Or you can switch the style of instance at will.
youngerFutharkLongBranch.EnableShortTwig();
youngerFutharkShortTwig.EnableLongBranch();

```


#### What's in the name?

"Riimut" is the Finnish word for "runes".
