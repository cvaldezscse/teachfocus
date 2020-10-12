using System;
using System.IO;

namespace TeachFocus
{
    public static class Utils
    {
        public static string GetChallenge1Text(string templateName, string studentName)
        {
            try
            {
                var finalText = File.ReadAllText(string.Format(ConstantData.TEMPLATES_PATH, ConstantData.CHALLENGE1_TEXT_FILENAME));
                finalText = finalText.Replace(ConstantData.STUDENT_NAME_REPLACE_VALUE, studentName);
                return finalText;
            }
            catch (IOException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DefineFinalChallenge1Grade(bool[] elements)
        {
            return string.Empty;
        }
    }
}
