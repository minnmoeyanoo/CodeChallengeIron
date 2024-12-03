namespace CodeChanllengeIron.Business
{
    public class KeypadTranslator
    {
        private static readonly Dictionary<char, string> Keypad = new()
        {
            { '1', "!@#$%^&*()" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };
        public static string OldPhonePad(string input)
        {
            string output = "";
            string currentKey = "";
            foreach (char c in input)
            {
                if (c == '#')
                {
                    if (!string.IsNullOrEmpty(currentKey))
                    {
                        ConvertKeyToLetter(currentKey, ref output);
                    }
                }
                else if (c == '*')
                {
                    if (!string.IsNullOrEmpty(currentKey))
                    {
                        currentKey = "";
                    }
                    else if (!string.IsNullOrEmpty(output))
                    {
                        output = output[..^1];
                    }
                }
                else if (c == ' ')
                {
                    if (!string.IsNullOrEmpty(currentKey))
                    {
                        ConvertKeyToLetter(currentKey, ref output);
                        currentKey = "";
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(currentKey) && c != currentKey[0])
                    {
                        ConvertKeyToLetter(currentKey, ref output);
                        currentKey = "";
                    }
                    currentKey += c;
                }
            }
            return output;
        }
        
        private static void ConvertKeyToLetter(string currentKey, ref string output)
        {
            char key = currentKey[0];
            int keyCount = currentKey.Length;
            if (Keypad.TryGetValue(key, out string? letters))
            {
                output += letters[(keyCount - 1) % letters.Length];
            }
        }
    }
}
