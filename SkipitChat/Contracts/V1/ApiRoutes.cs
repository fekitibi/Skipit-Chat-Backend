using System;
namespace SkipitChat.Contracts
{
    public static class ApiRoutes
    {
        public const string Version = "v1";
        public const string Root = "api";

        public const string Base = Root + "/" + Version;

        public static class Accessibilities
        {
            public const string GetAll = Base + "/accessibilities";
            public const string Get = Base + "/accessibilities/{name}";
        }

        public static class Tickets
        {
            public const string GetCityPass = Base + "/tickets/city/{duration}/{ticket99}";
            public const string GetAllCityPass = Base + "/tickets/city";
            public const string GetZoneByZoneNumber = Base + "/tickets/zone/{zoneNumber}/{age}/{disabled}/{animal}/{bycicle}";
            public const string GetAllZones = Base + "/tickets/city/zone";
        }
    }
}
