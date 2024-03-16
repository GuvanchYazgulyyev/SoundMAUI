using Plugin.Maui.Audio;

namespace SoundMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        private readonly IAudioManager audioManager;
        public MainPage(IAudioManager audioManager)
        {
            InitializeComponent();
            this.audioManager = audioManager;
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var play = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("music.mp4"));
            play.Play();
        }
    }

}
