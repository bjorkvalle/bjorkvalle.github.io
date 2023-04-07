namespace bjorkvalle.client.Pages.Wedding2023
{
    public static class Translations
    {
        public static Dictionary<string, Dictionary<string, string>> LanguageMap =>
            new()
            {
                {
                    nameof(Keys.Invitation.Title),
                    new Dictionary<string, string>
                    {
                        { Keys.Languages.Swedish, "Bröllopsinbjudan!" },
                        { Keys.Languages.English, "Wedding invitation!" },
                        { Keys.Languages.Romanian, "Invitatie la cununia civila!" }
                    }
                },
                {
                    nameof(Keys.Invitation.Description),
                    new Dictionary<string, string>
                    {
                        {
                            Keys.Languages.Swedish,
                            "Välkomna till en fullspäckad eftermiddag med vigsel, lunch och fika under loppet av några timmar.\n\nFör den som kan, vågar och orkar så blir det nån slags enklare utgång senare på kvällen. 🥳"
                        },
                        {
                            Keys.Languages.English,
                            "Welcome to a packed afternoon with a wedding ceremony, lunch, and coffee within the span of a few hours.\n\nFor those who are able, willing, and up for it, there will be some kind of casual outing later in the evening. 🥳"
                        },
                        {
                            Keys.Languages.Romanian,
                            "Bun venit la o după-amiază aglomerată cu ceremonia de nuntă, prânzul și cafeaua, toate în decursul câtorva ore. Pentru cei care sunt capabili, dispuși și interesați, mai târziu în seară va avea loc o ieșire într-un mod mai relaxat. 🥳"
                        },
                    }
                },
                {
                    nameof(Keys.Invitation.Schedule),
                    new Dictionary<string, string>
                    {
                        { Keys.Languages.Swedish, "Schema" },
                        { Keys.Languages.English, "Schedule" },
                        { Keys.Languages.Romanian, "Program" },
                    }
                },
                {
                    nameof(Keys.Invitation.Restaurant),
                    new Dictionary<string, string>
                    {
                        { Keys.Languages.Swedish, "Restaurang" },
                        { Keys.Languages.English, "Restaurant (swe)" },
                        { Keys.Languages.Romanian, "Restaurant (swe)" },
                    }
                },
            };

        public static class Keys
        {
            public static class Invitation
            {
                public const string Title = nameof(Title);
                public const string Description = nameof(Description);
                public const string Schedule = nameof(Schedule);
                public const string Restaurant = nameof(Restaurant);
            }

            public static class Languages
            {
                public const string Swedish = "se";
                public const string English = "en";
                public const string Romanian = "ro";
            }
        }

        public static string GetValue(string key, string langKey)
        {
            if (LanguageMap.TryGetValue(key, out Dictionary<string, string> langDict))
            {
                if (string.IsNullOrEmpty(langKey))
                    langKey = "en";

                return langDict.GetValueOrDefault(
                    langKey,
                    $"{GetPlaceholder(langKey)}.{GetPlaceholder(key)}"
                );
            }
            return GetPlaceholder(key);
        }

        public static string GetPlaceholder(string key)
        {
            return $"[{key}]";
        }
    }
}
