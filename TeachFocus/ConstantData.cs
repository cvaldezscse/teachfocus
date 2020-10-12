using System;
using System.IO;
using System.Reflection;

namespace TeachFocus
{
    public static class ConstantData
    {
        public static readonly string COMING_SOON_MESSAGE = "Coming Soon"; 
        public static readonly string STUDENTNAME_IS_REQUIRED_FIELD_MESSAGE = "Student name is a required field"; 
        public static readonly string VALIDATION_STUDENTNAME_ERROR = "Student Name field Error";
        public static readonly string BASE_GRADE = "Calificación: {0}";

        //CONFIGURABLE VALUES
        public static readonly string STUDENT_NAME_REPLACE_VALUE = "%STUDENT_NAME%";

        //ERROR MANAGEMENT
        public static readonly string ERROR_WITHFILE_MESSAGE = "Error with the file: {0}";


        //PATHS
        public static readonly string TEMPLATES_PATH = Environment.CurrentDirectory + @"../../../Resources/{0}";


        //FILENAMES
        public static readonly string CHALLENGE1_TEXT_FILENAME = "Challenge1_Full_Template.txt";

    }
}
