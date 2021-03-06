using ColossalFramework.Globalization;
using ColossalFramework.Plugins;
using System.Collections.Generic;

namespace TimeWarpMod
{

    public class i18n
    {
        private Dictionary<string, string> _ = new Dictionary<string, string>();
        public string lang;
        private static i18n _current;
        //private static i18n english = new i18n("en");

        public string this[string key]
        {
            get {
                string value;
                if (!_.TryGetValue(key.ToUpper(), out value))
                {
                    DebugOutputPanel.AddMessage(PluginManager.MessageType.Warning, "No translation for string: " + key);
                    return "#" + key;
                }
                return value;    
            }
        }

        public static i18n current
        {
            get
            {
                if (_current == null || !LocaleManager.instance.language.Equals(_current.lang))
                {
                    _current = new i18n(LocaleManager.instance.language);
                }
                return _current;
            }
        }

        private i18n(string selectedLanguage)
        {
            lang = selectedLanguage;
            switch (selectedLanguage)
            {
                
                case "nl":
                    _["MOD_NAME"]               = "Tijdsprong";
                    _["MOD_DESCRIPTION"]        = "Rechtermuisknop op de gebiedenknop om het moment van de dag te veranderen";

                    _["TOGGLE_TOOLTIP"]         = "Dag-/nachtinstellingen";
                    _["ZOOMBUTTON_TOOLTIP"]     = "Gebieden \n Rechtermuisknop om het moment van de dag te veranderen";
                    _["SUNCONTROL"]             = "Zonbediening";
                    _["SUNCONTROL_TITLE"]       = "Dag-/nachtinstellingen";
                    _["SUNCONTROL_SIZE"]        = "Zongrootte";
                    _["SUNCONTROL_INTENSITY"]   = "Zonne-intensiteit";
                    _["LATTITUDE"]              = "Breedtegraad: ";
                    _["LONGITUDE"]              = "Lengtegraad: ";
                    _["SPEED_PAUSED"]           = "Snelheid Uitgeschakeld";
                    _["SPEED_NORMAL"]           = "Normaal";
                    _["SPEED_DISABLED"]         = "Gehandicapte";
                    _["SPEED"]                  = "Snelheid: ";
                    _["NIGHT_DISABLED"]         = "Nachtcyclus uitgeschakeld in instellingen";

                    return;
                case "de":
                    _["MOD_NAME"]               = "Zeitsprung";
                    _["MOD_DESCRIPTION"]        = "Rechtsklick auf dem Gebietenknopf, um die Tageszeit zu ändern";

                    _["TOGGLE_TOOLTIP"]         = "Tag / Nacht-einstellungen";
                    _["ZOOMBUTTON_TOOLTIP"]     = "Gebiete \n Rechtsklick um die Tageszeit zu ändern";
                    _["SUNCONTROL"]             = "Sonnebedienung";
                    _["SUNCONTROL_TITLE"]       = "Tag / Nacht-einstellungen";
                    _["SUNCONTROL_SIZE"]        = "Sonnegröße";
                    _["SUNCONTROL_INTENSITY"]   = "Sonnenintensität";
                    _["LATTITUDE"]              = "Breitengrad: ";
                    _["LONGITUDE"]              = "Längengrad: ";
                    _["SPEED_PAUSED"]           = "Pausiert";
                    _["SPEED_NORMAL"]           = "Normal";
                    _["SPEED_DISABLED"]         = "Behindert";
                    _["SPEED"]                  = "Geschwindigkeit: ";
                    _["NIGHT_DISABLED"]         = "Nacht-Zyklus in den Einstellungen deaktiviert";

                    return;
                case "it":

                    _["MOD_NAME"]               = "Distorsione del tempo";
                    _["MOD_DESCRIPTION"]        = "Tasto destro del mouse sul bottone aree per cambiare l'ora del giorno";

                    _["TOGGLE_TOOLTIP"]         = "Impostazioni giorno / notte";
                    _["ZOOMBUTTON_TOOLTIP"]     = "Aree \n Tasto destro del mouse per cambiare l'ora del giorno";
                    _["SUNCONTROL"]             = "Controllo del sole";
                    _["SUNCONTROL_TITLE"]       = "Impostazioni giorno / notte";
                    _["SUNCONTROL_SIZE"]        = "Formato sole";
                    _["SUNCONTROL_INTENSITY"]   = "Intensità solare";
                    _["LATTITUDE"]              = "Lattitudine: ";
                    _["LONGITUDE"]              = "Longitudine: ";
                    _["SPEED_PAUSED"]           = "In pausa";
                    _["SPEED_NORMAL"]           = "Normale";
                    _["SPEED_DISABLED"]         = "Disabilitato";
                    _["SPEED"]                  = "Velocità: ";
                    _["NIGHT_DISABLED"]         = "Ciclo Notte disattivata nelle impostazioni";

                    return;
                case "ko":

                    _["MOD_NAME"]               = "타임 워프 모드";
                    _["MOD_DESCRIPTION"]        = "모드전용 패널에서 스크롤바를 움직여 시간을 조절 할 수 있습니다";

                    _["TOGGLE_TOOLTIP"]         = "낮/밤 주기 설정";
                    _["ZOOMBUTTON_TOOLTIP"]     = "패널에서 \n 스크롤바를 움직여 시간을 조절 할 수 있습니다";
                    _["SUNCONTROL"]             = "태양 설정";
                    _["SUNCONTROL_TITLE"]       = "낮/밤 주기 설정";
                    _["SUNCONTROL_SIZE"]        = "태양 크기";
                    _["SUNCONTROL_INTENSITY"]   = "태양 광도";
                    _["LATTITUDE"]              = "위도 : ";
                    _["LONGITUDE"]              = "경도 : ";
                    _["SPEED_PAUZED"]           = "정지";
                    _["SPEED_NORMAL"]           = "보통";
                    _["SPEED_DISABLED"]         = "비활성화";
                    _["SPEED"]                  = "주기속도: ";
            
                    _["NIGHT_DISABLED"]         = "게임플레이 설정에서 주/야간 주기기능을 켜십시오";
					
                return;
                default:
                    _["MOD_NAME"]               = "Time Warp";
                    _["MOD_DESCRIPTION"]        = "Right click on the Area Zoom button to set the time of day";

                    _["TOGGLE_TOOLTIP"]         = "Day/Night Settings";
                    _["ZOOMBUTTON_TOOLTIP"]     = "Areas \n Right Click to set time of day";
                    _["SUNCONTROL"]             = "Sun control";
                    _["SUNCONTROL_TITLE"]       = "Day/Night Settings";
                    _["SUNCONTROL_SIZE"]        = "Sun Size";
                    _["SUNCONTROL_INTENSITY"]   = "Sun Intensity";
                    _["LATTITUDE"]              = "Lattitude: ";
                    _["LONGITUDE"]              = "Longitude: ";
                    _["SPEED_PAUSED"]           = "Paused";
                    _["SPEED_NORMAL"]           = "Normal";
                    _["SPEED_DISABLED"]         = "Disabled";
                    _["SPEED"]                  = "Speed: ";
            
                    _["NIGHT_DISABLED"]         = "Night cycle disabled in settings";

                    return;
            }
            
        }
    }
}
