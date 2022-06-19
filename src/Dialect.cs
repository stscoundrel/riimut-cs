namespace Riimut
{
    public interface Dialect
    {
        public string LettersToRunes(string content);

        public string RunesToLetters(string content);
    }
}
