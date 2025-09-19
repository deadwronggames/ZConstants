namespace DeadWrongGames.ZConstants
{
    public static class Constants
    {
        // File names
        public const string PERSISTENT_GO_FILE_NAME_WITH_EXTENSION = "PF_PersistentGO.prefab";
        
        // Folder names
        public const string ROOT_FOLDER_NAME = "Assets";
        public const string PROJECT_FOLDER_NAME = "_Project";
        public const string SERVICES_FOLDER_NAME = "Services";
        public const string SERVICES_ASSETS_FOLDER_NAME = "_Assets";
        public const string SERVICES_EVENT_CHANNEL_SO_FOLDER_NAME = "EventChannelSO";
        public const string SERVICES_SOUND_DATA_SO_FOLDER_NAME = "SoundDataSO";
        
        // Paths
        public const string PACKAGE_PERSISTENT_GO_FULL_PATH = "Packages/ZServices/Runtime/_Assets/" + "/" + PERSISTENT_GO_FILE_NAME_WITH_EXTENSION;
        public const string SERVICE_RESOURCE_PATH = SERVICES_FOLDER_NAME + "/" + SERVICES_ASSETS_FOLDER_NAME + "/Resources";
        public const string SERVICE_RESOURCE_FULL_PATH = ROOT_FOLDER_NAME + "/" + PROJECT_FOLDER_NAME + "/" + SERVICE_RESOURCE_PATH;
    }
}
