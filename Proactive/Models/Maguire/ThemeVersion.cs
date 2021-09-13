using System;
using System.Collections.Generic;

#nullable disable

namespace Proactive.Models.Maguire
{
    public partial class ThemeVersion
    {
        public int VersionId { get; set; }
        public Guid ThemeId { get; set; }
        public Guid SpaceId { get; set; }
        public string SpaceFont { get; set; }
        public string SpaceLogo { get; set; }
        public string SpaceWallpaper { get; set; }
        public string BodyBgColour { get; set; }
        public string HeaderBgColour { get; set; }
        public string MenuBgColour { get; set; }
        public string TitleBgColour { get; set; }
        public string ContentBgColour { get; set; }
        public string FooterBgColour { get; set; }
        public string ButtonsAndLinksColour { get; set; }
        public string HighlightColour { get; set; }
        public string DarkFontColour { get; set; }
        public string LightFontColour { get; set; }
        public string FeatureFontColour { get; set; }
        public string LabelFontColour { get; set; }
        public string ErrorFontColour { get; set; }
        public string TextShadow { get; set; }
        public string MaxMobile { get; set; }
        public string MinTablet { get; set; }
        public string MaxTablet { get; set; }
        public string FontSize1 { get; set; }
        public string FontSize2 { get; set; }
        public string FontSize3 { get; set; }
        public string FontSize4 { get; set; }
        public string FontSize5 { get; set; }
        public string FontSize6 { get; set; }
        public string FontSize7 { get; set; }
        public string FontSize8 { get; set; }
        public string BoxSizing { get; set; }
        public string BorderWidth { get; set; }
        public string BorderStyle { get; set; }
        public string BorderColour { get; set; }
        public string BorderRadius { get; set; }
        public string BoxShadow { get; set; }
        public string ContainerBoxSizing { get; set; }
        public string ContainerBorderWidth { get; set; }
        public string ContainerBorderStyle { get; set; }
        public string ContainerBorderColour { get; set; }
        public string ContainerBorderRadius { get; set; }
        public string ContainerBoxShadow { get; set; }
        public string Lighten { get; set; }
        public string Darken { get; set; }
        public string Bold { get; set; }
        public string Normal { get; set; }
        public string Light { get; set; }

        public virtual Space Space { get; set; }
    }
}
