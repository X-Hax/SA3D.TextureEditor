using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using SA3D.TextureEditor.ViewModels;
using SA3D.TextureEditor.Views;

namespace SA3D.TextureEditor
{
    /// <summary>
    ///
    /// </summary>
    public class App : Application
    {
        /// <summary>
        ///
        /// </summary>
        public override void Initialize()
        {
            Name = "Texture Editor";

            AvaloniaXamlLoader.Load(this);
        }

        /// <summary>
        ///
        /// </summary>
        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
