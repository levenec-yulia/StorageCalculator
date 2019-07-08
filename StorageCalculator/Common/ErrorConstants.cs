namespace StorageCalculator.Common
{
    /// <summary>
    /// Сообщения об ошибках применяемые в разных частях кода
    /// </summary>
    public static class ErrorConstants
    {
        public static readonly string CANT_LOAD_DATA = $"Data file {PathConstants.SETTINGS_FILE_PATH} corrupted\nAdvice: try to repair data or delete file and restart app.";

        public const string CANT_CALCULATE_MAX_CAPACITY = "Cant calculate max capacity";

        public const string CANT_CALCULATE_OCCUPANCY = "Cant calculate max ocuppancy";

        public const string CANT_EQUAL = "Cant equal objects";

        public const string WRONG_DATA = "Wrong info check for digits your fields";

        public const string WRONG_STORAGE_SIZE = "Wrong storage size: Storage must be Largest than Cargo and 0";

        public const string WRONG_CARGO_SIZE = "Wrong cargo size: Cargo must be Less than Storage and Largest than 0";

        public const string WRONG_STORAGE_STATE = "Wrong storage state: Count must be Largest than -1 and Less than Max Capacity of storage";

        public const string ERROR = "ERROR";

        public const string CRITICAL_ERROR = "CRITICAL ERROR";

        public const string WRONG_TIME_SELECT = "Date from must be less or same as to";
    }
}
