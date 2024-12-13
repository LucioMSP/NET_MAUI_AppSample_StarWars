using Android.Content;
using Google.Android.Material.Tabs;
using Microsoft.Maui.Controls.Handlers.Compatibility;
using Microsoft.Maui.Controls.Platform.Compatibility;
using Color = Android.Graphics.Color;

namespace StarWars.Platforms.Android.CustomRender
{
    public class CustomTabRenderer : ShellRenderer
    {
        public CustomTabRenderer(Context context) : base(context)
        {

        }
        protected override IShellTabLayoutAppearanceTracker CreateTabLayoutAppearanceTracker(ShellSection shellSection)
        {
            return new CustomTabLayoutAppearanceTracker(shellSection);
        }

    }
    internal class CustomTabLayoutAppearanceTracker : IShellTabLayoutAppearanceTracker
    {
        public CustomTabLayoutAppearanceTracker(ShellSection shellSection)
        {

        }
        public void Dispose()
        {

        }
        public void ResetAppearance(TabLayout tabLayout)
        {

        }
        public void SetAppearance(TabLayout tabLayout, ShellAppearance appearance)
        {
            tabLayout.TabMode = TabLayout.ModeFixed;
            tabLayout.SetBackgroundColor(Color.White);
            tabLayout.SetTabTextColors(Color.DarkGray, Color.Black);
            tabLayout.SetSelectedTabIndicatorColor(Color.Black);
        }
    }
}
 