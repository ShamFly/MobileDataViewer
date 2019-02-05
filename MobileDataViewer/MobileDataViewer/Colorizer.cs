using System.Collections.Generic;

namespace MobileDataViewer
{
    public class ColorEntry
    {
        public string Name;
        public string ColorCode;
    }

    public static class Colorizer
    {
        public const int GroupWidth = 6;
        public const int GroupCount = 20;

        private static int Indexer = 0;

        public static void ResetColor()
        {
            Indexer = 0;
        }

        public static string GetNextColorCode()
        {
            string c = Colors[Indexer].ColorCode;
            Indexer += GroupWidth * 3 + 1;
            if (Indexer >= (GroupWidth * GroupCount))
            {
                Indexer -= GroupWidth * GroupCount;
            }
            return c;

        }


        public static List<ColorEntry> Colors = new List<ColorEntry>()
        {
            
            /* Turquoise */
            new ColorEntry () { Name = "turquoise", ColorCode = "#1abc9c" },
            new ColorEntry () { Name = "turquoise-50", ColorCode = "#e8f8f5" },
            new ColorEntry () { Name = "turquoise-100", ColorCode = "#d1f2eb" },
            new ColorEntry () { Name = "turquoise-200", ColorCode = "#a3e4d7" },
            new ColorEntry () { Name = "turquoise-300", ColorCode = "#76d7c4" },
            new ColorEntry () { Name = "turquoise-400", ColorCode = "#48c9b0" },
            /*
            new ColorEntry () { Name = "turquoise-500", ColorCode = "#1abc9c" },
            new ColorEntry () { Name = "turquoise-600", ColorCode = "#17a589" },
            new ColorEntry () { Name = "turquoise-700", ColorCode = "#148f77" },
            new ColorEntry () { Name = "turquoise-800", ColorCode = "#117864" },
            new ColorEntry () { Name = "turquoise-900", ColorCode = "#0e6251" }
            ,*/

            /* Green Sea */
            new ColorEntry () { Name = "green-sea", ColorCode = "#16a085" },
            new ColorEntry () { Name = "green-sea-50", ColorCode = "#e8f6f3" },
            new ColorEntry () { Name = "green-sea-100", ColorCode = "#d0ece7" },
            new ColorEntry () { Name = "green-sea-200", ColorCode = "#a2d9ce" },
            new ColorEntry () { Name = "green-sea-300", ColorCode = "#73c6b6" },
            new ColorEntry () { Name = "green-sea-400", ColorCode = "#45b39d" },
            /*
            new ColorEntry () { Name = "green-sea-500", ColorCode = "#16a085" },
            new ColorEntry () { Name = "green-sea-600", ColorCode = "#138d75" },
            new ColorEntry () { Name = "green-sea-700", ColorCode = "#117a65" },
            new ColorEntry () { Name = "green-sea-800", ColorCode = "#0e6655" },
            new ColorEntry () { Name = "green-sea-900", ColorCode = "#0b5345" }
            ,*/

            /* Emerald */
            new ColorEntry () { Name = "emerald", ColorCode = "#2ecc71" },
            new ColorEntry () { Name = "emerald-50", ColorCode = "#eafaf1" },
            new ColorEntry () { Name = "emerald-100", ColorCode = "#d5f5e3" },
            new ColorEntry () { Name = "emerald-200", ColorCode = "#abebc6" },
            new ColorEntry () { Name = "emerald-300", ColorCode = "#82e0aa" },
            new ColorEntry () { Name = "emerald-400", ColorCode = "#58d68d" },
            /*
            new ColorEntry () { Name = "emerald-500", ColorCode = "#2ecc71" },
            new ColorEntry () { Name = "emerald-600", ColorCode = "#28b463" },
            new ColorEntry () { Name = "emerald-700", ColorCode = "#239b56" },
            new ColorEntry () { Name = "emerald-800", ColorCode = "#1d8348" },
            new ColorEntry () { Name = "emerald-900", ColorCode = "#186a3b" }
            ,*/

            /* Nephritis */
            new ColorEntry () { Name = "nephritis", ColorCode = "#27ae60" },
            new ColorEntry () { Name = "nephritis-50", ColorCode = "#e9f7ef" },
            new ColorEntry () { Name = "nephritis-100", ColorCode = "#d4efdf" },
            new ColorEntry () { Name = "nephritis-200", ColorCode = "#a9dfbf" },
            new ColorEntry () { Name = "nephritis-300", ColorCode = "#7dcea0" },
            new ColorEntry () { Name = "nephritis-400", ColorCode = "#52be80" },
            /*
            new ColorEntry () { Name = "nephritis-500", ColorCode = "#27ae60" },
            new ColorEntry () { Name = "nephritis-600", ColorCode = "#229954" },
            new ColorEntry () { Name = "nephritis-700", ColorCode = "#1e8449" },
            new ColorEntry () { Name = "nephritis-800", ColorCode = "#196f3d" },
            new ColorEntry () { Name = "nephritis-900", ColorCode = "#145a32" }
            ,*/

            /* Peter River */
            new ColorEntry () { Name = "peter-river", ColorCode = "#3498db" },
            new ColorEntry () { Name = "peter-river-50", ColorCode = "#ebf5fb" },
            new ColorEntry () { Name = "peter-river-100", ColorCode = "#d6eaf8" },
            new ColorEntry () { Name = "peter-river-200", ColorCode = "#aed6f1" },
            new ColorEntry () { Name = "peter-river-300", ColorCode = "#85c1e9" },
            new ColorEntry () { Name = "peter-river-400", ColorCode = "#5dade2" },
            /*
            new ColorEntry () { Name = "peter-river-500", ColorCode = "#3498db" },
            new ColorEntry () { Name = "peter-river-600", ColorCode = "#2e86c1" },
            new ColorEntry () { Name = "peter-river-700", ColorCode = "#2874a6" },
            new ColorEntry () { Name = "peter-river-800", ColorCode = "#21618c" },
            new ColorEntry () { Name = "peter-river-900", ColorCode = "#1b4f72" }
            ,*/

            /* Belize Hole */
            new ColorEntry () { Name = "belize-hole", ColorCode = "#2980b9" },
            new ColorEntry () { Name = "belize-hole-50", ColorCode = "#eaf2f8" },
            new ColorEntry () { Name = "belize-hole-100", ColorCode = "#d4e6f1" },
            new ColorEntry () { Name = "belize-hole-200", ColorCode = "#a9cce3" },
            new ColorEntry () { Name = "belize-hole-300", ColorCode = "#7fb3d5" },
            new ColorEntry () { Name = "belize-hole-400", ColorCode = "#5499c7" },
            /*
            new ColorEntry () { Name = "belize-hole-500", ColorCode = "#2980b9" },
            new ColorEntry () { Name = "belize-hole-600", ColorCode = "#2471a3" },
            new ColorEntry () { Name = "belize-hole-700", ColorCode = "#1f618d" },
            new ColorEntry () { Name = "belize-hole-800", ColorCode = "#1a5276" },
            new ColorEntry () { Name = "belize-hole-900", ColorCode = "#154360" }
            ,*/

            /* Amethyst */
            new ColorEntry () { Name = "amethyst", ColorCode = "#9b59b6" },
            new ColorEntry () { Name = "amethyst-50", ColorCode = "#f5eef8" },
            new ColorEntry () { Name = "amethyst-100", ColorCode = "#ebdef0" },
            new ColorEntry () { Name = "amethyst-200", ColorCode = "#d7bde2" },
            new ColorEntry () { Name = "amethyst-300", ColorCode = "#c39bd3" },
            new ColorEntry () { Name = "amethyst-400", ColorCode = "#af7ac5" },
            /*
            new ColorEntry () { Name = "amethyst-500", ColorCode = "#9b59b6" },
            new ColorEntry () { Name = "amethyst-600", ColorCode = "#884ea0" },
            new ColorEntry () { Name = "amethyst-700", ColorCode = "#76448a" },
            new ColorEntry () { Name = "amethyst-800", ColorCode = "#633974" },
            new ColorEntry () { Name = "amethyst-900", ColorCode = "#512e5f" }
            ,*/

            /* Wisteria */
            new ColorEntry () { Name = "wisteria", ColorCode = "#8e44ad" },
            new ColorEntry () { Name = "wisteria-50", ColorCode = "#f4ecf7" },
            new ColorEntry () { Name = "wisteria-100", ColorCode = "#e8daef" },
            new ColorEntry () { Name = "wisteria-200", ColorCode = "#d2b4de" },
            new ColorEntry () { Name = "wisteria-300", ColorCode = "#bb8fce" },
            new ColorEntry () { Name = "wisteria-400", ColorCode = "#a569bd" },
            /*
            new ColorEntry () { Name = "wisteria-500", ColorCode = "#8e44ad" },
            new ColorEntry () { Name = "wisteria-600", ColorCode = "#7d3c98" },
            new ColorEntry () { Name = "wisteria-700", ColorCode = "#6c3483" },
            new ColorEntry () { Name = "wisteria-800", ColorCode = "#5b2c6f" },
            new ColorEntry () { Name = "wisteria-900", ColorCode = "#4a235a" }
            ,*/

            /* Wet Asphalt */
            new ColorEntry () { Name = "wet-asphalt", ColorCode = "#34495e" },
            new ColorEntry () { Name = "wet-asphalt-50", ColorCode = "#ebedef" },
            new ColorEntry () { Name = "wet-asphalt-100", ColorCode = "#d6dbdf" },
            new ColorEntry () { Name = "wet-asphalt-200", ColorCode = "#aeb6bf" },
            new ColorEntry () { Name = "wet-asphalt-300", ColorCode = "#85929e" },
            new ColorEntry () { Name = "wet-asphalt-400", ColorCode = "#5d6d7e" },
            /*
            new ColorEntry () { Name = "wet-asphalt-500", ColorCode = "#34495e" },
            new ColorEntry () { Name = "wet-asphalt-600", ColorCode = "#2e4053" },
            new ColorEntry () { Name = "wet-asphalt-700", ColorCode = "#283747" },
            new ColorEntry () { Name = "wet-asphalt-800", ColorCode = "#212f3c" },
            new ColorEntry () { Name = "wet-asphalt-900", ColorCode = "#1b2631" }
            ,*/

            /* Midnight Blue */
            new ColorEntry () { Name = "midnight-blue", ColorCode = "#2c3e50" },
            new ColorEntry () { Name = "midnight-blue-50", ColorCode = "#eaecee" },
            new ColorEntry () { Name = "midnight-blue-100", ColorCode = "#d5d8dc" },
            new ColorEntry () { Name = "midnight-blue-200", ColorCode = "#abb2b9" },
            new ColorEntry () { Name = "midnight-blue-300", ColorCode = "#808b96" },
            new ColorEntry () { Name = "midnight-blue-400", ColorCode = "#566573" },
            /*
            new ColorEntry () { Name = "midnight-blue-500", ColorCode = "#2c3e50" },
            new ColorEntry () { Name = "midnight-blue-600", ColorCode = "#273746" },
            new ColorEntry () { Name = "midnight-blue-700", ColorCode = "#212f3d" },
            new ColorEntry () { Name = "midnight-blue-800", ColorCode = "#1c2833" },
            new ColorEntry () { Name = "midnight-blue-900", ColorCode = "#17202a" }
            ,*/

            /* Sunflower */
            new ColorEntry () { Name = "sunflower", ColorCode = "#f1c40f" },
            new ColorEntry () { Name = "sunflower-50", ColorCode = "#fef9e7" },
            new ColorEntry () { Name = "sunflower-100", ColorCode = "#fcf3cf" },
            new ColorEntry () { Name = "sunflower-200", ColorCode = "#f9e79f" },
            new ColorEntry () { Name = "sunflower-300", ColorCode = "#f7dc6f" },
            new ColorEntry () { Name = "sunflower-400", ColorCode = "#f4d03f" },
            /*
            new ColorEntry () { Name = "sunflower-500", ColorCode = "#f1c40f" },
            new ColorEntry () { Name = "sunflower-600", ColorCode = "#d4ac0d" },
            new ColorEntry () { Name = "sunflower-700", ColorCode = "#b7950b" },
            new ColorEntry () { Name = "sunflower-800", ColorCode = "#9a7d0a" },
            new ColorEntry () { Name = "sunflower-900", ColorCode = "#7d6608" }
            ,*/

            /* Orange */
            new ColorEntry () { Name = "orange", ColorCode = "#f39c12" },
            new ColorEntry () { Name = "orange-50", ColorCode = "#fef5e7" },
            new ColorEntry () { Name = "orange-100", ColorCode = "#fdebd0" },
            new ColorEntry () { Name = "orange-200", ColorCode = "#fad7a0" },
            new ColorEntry () { Name = "orange-300", ColorCode = "#f8c471" },
            new ColorEntry () { Name = "orange-400", ColorCode = "#f5b041" },
            /*
            new ColorEntry () { Name = "orange-500", ColorCode = "#f39c12" },
            new ColorEntry () { Name = "orange-600", ColorCode = "#d68910" },
            new ColorEntry () { Name = "orange-700", ColorCode = "#b9770e" },
            new ColorEntry () { Name = "orange-800", ColorCode = "#9c640c" },
            new ColorEntry () { Name = "orange-900", ColorCode = "#7e5109" }
            ,*/

            /* Carrot */
            new ColorEntry () { Name = "carrot", ColorCode = "#e67e22" },
            new ColorEntry () { Name = "carrot-50", ColorCode = "#fdf2e9" },
            new ColorEntry () { Name = "carrot-100", ColorCode = "#fae5d3" },
            new ColorEntry () { Name = "carrot-200", ColorCode = "#f5cba7" },
            new ColorEntry () { Name = "carrot-300", ColorCode = "#f0b27a" },
            new ColorEntry () { Name = "carrot-400", ColorCode = "#eb984e" },
            /*
            new ColorEntry () { Name = "carrot-500", ColorCode = "#e67e22" },
            new ColorEntry () { Name = "carrot-600", ColorCode = "#ca6f1e" },
            new ColorEntry () { Name = "carrot-700", ColorCode = "#af601a" },
            new ColorEntry () { Name = "carrot-800", ColorCode = "#935116" },
            new ColorEntry () { Name = "carrot-900", ColorCode = "#784212" }
            ,*/

            /* Pumpkin */
            new ColorEntry () { Name = "pumpkin", ColorCode = "#d35400" },
            new ColorEntry () { Name = "pumpkin-50", ColorCode = "#fbeee6" },
            new ColorEntry () { Name = "pumpkin-100", ColorCode = "#f6ddcc" },
            new ColorEntry () { Name = "pumpkin-200", ColorCode = "#edbb99" },
            new ColorEntry () { Name = "pumpkin-300", ColorCode = "#e59866" },
            new ColorEntry () { Name = "pumpkin-400", ColorCode = "#dc7633" },
            /*
            new ColorEntry () { Name = "pumpkin-500", ColorCode = "#d35400" },
            new ColorEntry () { Name = "pumpkin-600", ColorCode = "#ba4a00" },
            new ColorEntry () { Name = "pumpkin-700", ColorCode = "#a04000" },
            new ColorEntry () { Name = "pumpkin-800", ColorCode = "#873600" },
            new ColorEntry () { Name = "pumpkin-900", ColorCode = "#6e2c00" }
            ,*/

            /* Alizarin */
            new ColorEntry () { Name = "alizarin", ColorCode = "#e74c3c" },
            new ColorEntry () { Name = "alizarin-50", ColorCode = "#fdedec" },
            new ColorEntry () { Name = "alizarin-100", ColorCode = "#fadbd8" },
            new ColorEntry () { Name = "alizarin-200", ColorCode = "#f5b7b1" },
            new ColorEntry () { Name = "alizarin-300", ColorCode = "#f1948a" },
            new ColorEntry () { Name = "alizarin-400", ColorCode = "#ec7063" },
            /*
            new ColorEntry () { Name = "alizarin-500", ColorCode = "#e74c3c" },
            new ColorEntry () { Name = "alizarin-600", ColorCode = "#cb4335" },
            new ColorEntry () { Name = "alizarin-700", ColorCode = "#b03a2e" },
            new ColorEntry () { Name = "alizarin-800", ColorCode = "#943126" },
            new ColorEntry () { Name = "alizarin-900", ColorCode = "#78281f" }
            ,*/

            /* Pomegranate */
            new ColorEntry () { Name = "pomegranate", ColorCode = "#c0392b" },
            new ColorEntry () { Name = "pomegranate-50", ColorCode = "#f9ebea" },
            new ColorEntry () { Name = "pomegranate-100", ColorCode = "#f2d7d5" },
            new ColorEntry () { Name = "pomegranate-200", ColorCode = "#e6b0aa" },
            new ColorEntry () { Name = "pomegranate-300", ColorCode = "#d98880" },
            new ColorEntry () { Name = "pomegranate-400", ColorCode = "#cd6155" },
            /*
            new ColorEntry () { Name = "pomegranate-500", ColorCode = "#c0392b" },
            new ColorEntry () { Name = "pomegranate-600", ColorCode = "#a93226" },
            new ColorEntry () { Name = "pomegranate-700", ColorCode = "#922b21" },
            new ColorEntry () { Name = "pomegranate-800", ColorCode = "#7b241c" },
            new ColorEntry () { Name = "pomegranate-900", ColorCode = "#641e16" }
            ,*/

            /* Clouds */
            new ColorEntry () { Name = "clouds", ColorCode = "#ecf0f1" },
            new ColorEntry () { Name = "clouds-50", ColorCode = "#fdfefe" },
            new ColorEntry () { Name = "clouds-100", ColorCode = "#fbfcfc" },
            new ColorEntry () { Name = "clouds-200", ColorCode = "#f7f9f9" },
            new ColorEntry () { Name = "clouds-300", ColorCode = "#f4f6f7" },
            new ColorEntry () { Name = "clouds-400", ColorCode = "#f0f3f4" },
            /*
            new ColorEntry () { Name = "clouds-500", ColorCode = "#ecf0f1" },
            new ColorEntry () { Name = "clouds-600", ColorCode = "#d0d3d4" },
            new ColorEntry () { Name = "clouds-700", ColorCode = "#b3b6b7" },
            new ColorEntry () { Name = "clouds-800", ColorCode = "#979a9a" },
            new ColorEntry () { Name = "clouds-900", ColorCode = "#7b7d7d" }
            ,*/

            /* Silver */
            new ColorEntry () { Name = "silver", ColorCode = "#bdc3c7" },
            new ColorEntry () { Name = "silver-50", ColorCode = "#f8f9f9" },
            new ColorEntry () { Name = "silver-100", ColorCode = "#f2f3f4" },
            new ColorEntry () { Name = "silver-200", ColorCode = "#e5e7e9" },
            new ColorEntry () { Name = "silver-300", ColorCode = "#d7dbdd" },
            new ColorEntry () { Name = "silver-400", ColorCode = "#cacfd2" },
            /*
            new ColorEntry () { Name = "silver-500", ColorCode = "#bdc3c7" },
            new ColorEntry () { Name = "silver-600", ColorCode = "#a6acaf" },
            new ColorEntry () { Name = "silver-700", ColorCode = "#909497" },
            new ColorEntry () { Name = "silver-800", ColorCode = "#797d7f" },
            new ColorEntry () { Name = "silver-900", ColorCode = "#626567" }
            ,*/

            /* Concrete */
            new ColorEntry () { Name = "concrete", ColorCode = "#95a5a6" },
            new ColorEntry () { Name = "concrete-50", ColorCode = "#f4f6f6" },
            new ColorEntry () { Name = "concrete-100", ColorCode = "#eaeded" },
            new ColorEntry () { Name = "concrete-200", ColorCode = "#d5dbdb" },
            new ColorEntry () { Name = "concrete-300", ColorCode = "#bfc9ca" },
            new ColorEntry () { Name = "concrete-400", ColorCode = "#aab7b8" },
            /*
            new ColorEntry () { Name = "concrete-500", ColorCode = "#95a5a6" },
            new ColorEntry () { Name = "concrete-600", ColorCode = "#839192" },
            new ColorEntry () { Name = "concrete-700", ColorCode = "#717d7e" },
            new ColorEntry () { Name = "concrete-800", ColorCode = "#5f6a6a" },
            new ColorEntry () { Name = "concrete-900", ColorCode = "#4d5656" }
            ,*/

            /* Asbestos */
            new ColorEntry () { Name = "asbestos", ColorCode = "#7f8c8d" },
            new ColorEntry () { Name = "asbestos-50", ColorCode = "#f2f4f4" },
            new ColorEntry () { Name = "asbestos-100", ColorCode = "#e5e8e8" },
            new ColorEntry () { Name = "asbestos-200", ColorCode = "#ccd1d1" },
            new ColorEntry () { Name = "asbestos-300", ColorCode = "#b2babb" },
            new ColorEntry () { Name = "asbestos-400", ColorCode = "#99a3a4" },
            /*
            new ColorEntry () { Name = "asbestos-500", ColorCode = "#7f8c8d" },
            new ColorEntry () { Name = "asbestos-600", ColorCode = "#707b7c" },
            new ColorEntry () { Name = "asbestos-700", ColorCode = "#616a6b" },
            new ColorEntry () { Name = "asbestos-800", ColorCode = "#515a5a" },
            new ColorEntry () { Name = "asbestos-900", ColorCode = "#424949" }

            */
        };
    }
}
